using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Common.Enums;
using DevExpress.XtraBars;
using System.Linq.Expressions;
using System;
using SenfoniYazilim.Erp.Common.Message;
using System.Linq;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.Collections.Generic;
using System.Windows.Forms;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.TransferBetweenWarehousesForms
{
    public partial class TransferDemandItemsListForm : BaseListForm
    {
        private  Expression<Func<TransferItemsBetweenWareHouses, bool>> _filter;

        public TransferDemandItemsListForm()
        {
            InitializeComponent();

            Bll = new TarnsferItemsBetweenWareHousesBll();
            HideItems = new BarItem[] { btnTalepBirlestir,btnTeklifTopla,btnYoneticiOnayinaGonder,btnCancel,btnActive};
            ShowItems = new BarItem[] { btnTransfer };

            if(AnaForm.KullaniciYetkisi==KullaniciYetkisi.Yonetici)
                 _filter = x => x.IsClosed != AktifKartlariGoster ;
            else
                _filter = x => x.IsClosed != AktifKartlariGoster&&x.CreatorUserId==AnaForm.KullaniciId;
        }

        public TransferDemandItemsListForm(params object[] prm):this()
        {
            //_filter = x => x.IsActive == AktifKartlariGoster && !x.IsClosed && !x.IsCancel && !x.IsTransfered && !ListeDisiTutulacakKayitlar.Contains(x.Id);
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.TransferDemandBetweenWarehouses;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<TransferDemandBetweenWarehousesEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((TarnsferItemsBetweenWareHousesBll)Bll).List(_filter);
        }

        protected override void PerformProccess()
        {
            var items = HareketRowsSelected.GetSelectedRows().Cast<TarnsferItemsBetweenWareHousesL>().Where(x=>x.RemainingQuantity>0).ToList();

            if (items.Count == 0) return;

            if (TranferItem() && InsertStockMoving())
                Messages.BilgiMesaji("Transfer İşlemi Gerçekleştirildi.");
            else
                Messages.HataMesaji("İşlem Esnasında Bir Hata İle Karşılaşıldı. İşlem Yarım Kaldı.");

            items.ForEach(x =>
            {
                x.TransferedQuantity = x.TransferedQuantity + x.RemainingQuantity;
                x.IsClosed = x.TransferedQuantity >= x.DemandedQuantity;
                x.RemainingQuantity = 0;
            });

            ((TarnsferItemsBetweenWareHousesBll)Bll).Update(items.Cast<BaseHareketEntity>().ToList());

            HareketRowsSelected.ClearSelection();
            Listele();
        }

        private bool TranferItem()
        {
            var items = HareketRowsSelected.GetSelectedRows().Cast<TarnsferItemsBetweenWareHousesL>().Where(x=>x.RemainingQuantity>0).ToList();

            if (items.Count == 0) return false;

            var transferedItems = new List<WareHouseStockL>();

            items.ForEach(x =>
            {
                var warehouseItem = new WareHouseStockL
                {
                    MaterialId = x.MaterialId,
                    WareHouseId = x.TransferedWareHouseId,
                    UnitId=x.UnitId,
                    Quantity = x.RemainingQuantity,
                };
                transferedItems.Add(warehouseItem);
            });
            items.ForEach(x =>
            {
                var warehouseItem = new WareHouseStockL
                {
                    MaterialId = x.MaterialId,
                    WareHouseId = x.TransferWareHouseId,
                    UnitId=x.UnitId,
                    Quantity = -x.RemainingQuantity,
                };

                transferedItems.Add(warehouseItem);
            });

            return GetAnySingleOrListBll.UpdateWarehouseStock(transferedItems);
        }

        private bool InsertStockMoving()
        {
            var items = HareketRowsSelected.GetSelectedRows().Cast<TarnsferItemsBetweenWareHousesL>().Where(x => x.RemainingQuantity > 0).ToList();

            if (items.Count == 0) return false;

            var hareketList = new List<BaseHareketEntity>();

            items.ForEach(x =>
            {
                var stokHareketi = new StokHareketleri
                {
                    Id = 0,
                    StokId = x.MaterialId,
                    UnitId=x.UnitId,
                    DepoId = x.TransferWareHouseId,
                    FormId = x.OwnerFormId,
                    FormItemId=x.Id,
                    HareketTuru = HareketTuru.Cikis,
                    HareketCinsi = "TepolarArasıTransfer",
                    IslemMiktari = x.RemainingQuantity,
                    HareketTarihi = DateTime.Now,
                };
                hareketList.Add(stokHareketi);
            });
            items.ForEach(x =>
            {
                var stokHareketi = new StokHareketleri
                {
                    Id = 0,
                    StokId = x.MaterialId,
                    UnitId=x.UnitId,
                    DepoId = x.TransferedWareHouseId,
                    FormId = x.OwnerFormId,
                    FormItemId=x.Id,
                    HareketTuru = HareketTuru.Giris,
                    HareketCinsi = "TepolarArasıTransfer",
                    IslemMiktari = x.RemainingQuantity,
                    HareketTarihi = DateTime.Now,
                };
                hareketList.Add(stokHareketi);
            });
            return GetAnySingleOrListBll.InsertStokHareketleri(hareketList);
        }

        protected override void FormCaptionAyarla(bool _switch = false)
        {
            if (AktifKartlariGoster)
            {
                btnAktifPasifKartlar.Caption = "Pasif Kartlar";
                btnChangeBaseStatus.Caption = "Pasif";
                Tablo.ViewCaption = Text;
                // _filter = x => x.IsActive == AktifKartlariGoster && !x.IsClosed && !x.IsCancel && !x.IsTransfered;
                btnTransfer.Visibility = BarItemVisibility.Always;
                Listele();
            }
            else
            {
                btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                btnChangeBaseStatus.Caption = "Aktif";
                Tablo.ViewCaption = Text + "- Pasif Kartlar";
                //_filter = x => x.IsActive == AktifKartlariGoster || x.IsClosed || x.IsCancel;
                btnTransfer.Visibility = BarItemVisibility.Never;
                Listele();
            }
            SutunGizleGoster();
        }

        protected override void SutunGizleGoster()
        {
            //colIsActive.Visible = !AktifKartlariGoster;
            //colIsCancel.Visible = !AktifKartlariGoster;
            colRemainingQuantity.Visible = AktifKartlariGoster;
            colIsClosed.Visible = !AktifKartlariGoster;
            colMaterialQuantity.Visible = AktifKartlariGoster;
            colItemRezervedQyt.Visible = AktifKartlariGoster;
            colOpenQuantity.Visible = AktifKartlariGoster;
        }

        protected override void EntityDelete()
        {
            var selectedEntities = HareketRowsSelected.GetSelectedRows().EntityListConvert<TarnsferItemsBetweenWareHousesL>().ToList();

            if (selectedEntities.Count == 0) { Messages.KartSecmemeUyariMesaji(); return; }

            if (selectedEntities.Any(x => x.TransferedQuantity > 0))
            {
                Messages.HataMesaji("Transfer İşlemi Yapılmış Kayıtlar Var. İşlem Gerçekleştirilemez");
                return;
            }
            //if (!DeleteConfirm(selectedEntities.Any(x => x.ManagerComfirmState != YoneticiOnayDurum.IslemYapilmadi), selectedEntities.Any(x => x.OfferComfirmState != YoneticiOnayDurum.IslemYapilmadi), selectedEntities.Any(x => x.PurchaseOrderId != null))) return;

            var deletingEntity = new List<BaseHareketEntity>();

            selectedEntities.ForEach(x =>
            {
                deletingEntity.Add(x);
            });

            ((TarnsferItemsBetweenWareHousesBll)Bll).Delete(deletingEntity);

            HareketRowsSelected.ClearSelection();
            Listele();
        }
        
        protected override void ShowEditForm(long id)
        {
            if (id == -1)
            {
                base.ShowEditForm(id);
                return;
            }

            var focusedEntity = Tablo.GetRow<TarnsferItemsBetweenWareHousesL>(false);//HareketRowsSelected.GetSelectedRows().EntityListConvert<TarnsferItemsBetweenWareHousesL>().FirstOrDefault(); //Tablo.GetRow<TumSatinalmaTalepKalemleri>();
            if (focusedEntity == null) return;
            var result = ShowEditForms<TransferDemandBetweenWarehousesEditForm>.ShowDialogForm(BaseKartTuru, focusedEntity.OwnerFormId, focusedEntity.Id);
            ShowEditFormDefault(result);
            HareketRowsSelected.ClearSelection();
        }
        //aşağıdaki iki event, BaseListFormda SütunGizleGöster metodunu çağırdı için performansı etkilememesi adına
        //override edilerek içi boşaltılmıştır.
        protected override void Tablo_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e){}

        protected override void Tablo_RowDeleted(object sender, RowDeletedEventArgs e){}

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!TabloLoaded) return;
            if (e.Column == colRemainingQuantity)
            {
                //var entity = Tablo.GetRow<TarnsferItemsBetweenWareHousesL>(false);
                //if (entity == null) return;
                //if (entity.OpenQuantity < entity.RemainingQuantity)
                //{
                //    Messages.HataMesaji("Transfer Edilecek Miktar , Kullanılabilir Miktarı Geçemez!");
                //    Tablo.FocusedColumn = colRemainingQuantity;
                //}
            }
        }

        //private void AddStock(List<TarnsferItemsBetweenWareHousesL> items)
        //{
        //    var entitiesUpdated = new List<BaseHareketEntity>();
        //    var entitiesInserted = new List<BaseHareketEntity>();

        //    items.ForEach(x =>
        //    {
        //        var entity = GetAnySingleOrListBll.SingleWarehouseStock(x.MaterialId, x.TransferedWareHouseId);
        //        if (entity == null)
        //        {
        //            var warehouseStock = new WareHouseStocks
        //            {
        //                MaterialId = x.MaterialId,
        //                WareHouseId = x.TransferedWareHouseId,
        //                Quantity = x.RemainingQuantity
        //            };
        //            entitiesInserted.Add(warehouseStock);
        //        }
        //        else
        //        {
        //            entity.Quantity = entity.Quantity + x.RemainingQuantity;
        //            entitiesUpdated.Add(entity);
        //        }
        //    });
        //    var enti = InsertOrUpdateAnyItems.UpdateWarehouseStock(entitiesUpdated);
        //    var inst = InsertOrUpdateAnyItems.InsertWarehouseStock(entitiesInserted);
        //}

        //private bool RemoveStock(List<TarnsferItemsBetweenWareHousesL> items)
        //{
        //    var entitiesUpdated = new List<BaseHareketEntity>();
        //    var entitiesInserted = new List<BaseHareketEntity>();

        //    items.ForEach(x =>
        //    {
        //        var entity = GetAnySingleOrListBll.SingleWarehouseStock(x.MaterialId, x.TransferedWareHouseId);
        //        if (entity == null)
        //        {
        //            var warehouseStock = new WareHouseStocks
        //            {
        //                MaterialId = x.MaterialId,
        //                WareHouseId = x.TransferWareHouseId,
        //                Quantity = -x.RemainingQuantity
        //            };
        //            entitiesInserted.Add(warehouseStock);
        //        }
        //        else
        //        {
        //            entity.Quantity = entity.Quantity - x.RemainingQuantity;
        //            entitiesUpdated.Add(entity);
        //        }
        //    });
            
        //    if (entitiesInserted.Cast<WareHouseStocks>().Any(x => x.Quantity < 0) || entitiesUpdated.Cast<WareHouseStocks>().Any(x => x.Quantity < 0))
        //    {
        //        var message = "İşlem Sonucu Eksiye Düşen Stoklar Mevcut. Devam Etmek İstiyor musunuz?";
        //        var result = Messages.EvetSeciliEvetHayirIptal(message, "Uyarı");
        //        switch (result)
        //        {
        //            case DialogResult.Cancel:
        //                return false;
        //            case DialogResult.Yes:
        //                Yes();
        //                return true;
        //            case DialogResult.No:
        //                No();
        //                return false;
        //        }
        //    }

        //    return true;

        //    void Yes()
        //    {
        //        var enti = InsertOrUpdateAnyItems.UpdateWarehouseStock(entitiesUpdated);
        //        var inst = InsertOrUpdateAnyItems.InsertWarehouseStock(entitiesInserted);
        //        items.ForEach(x =>
        //        {
        //            x.IsTransfered = true;
        //            x.TransferedQuantity =x.TransferedQuantity + x.RemainingQuantity;
        //            x.IsClosed = x.DemandedQuantity <= x.TransferedQuantity;
        //        });

        //        ((TarnsferItemsBetweenWareHousesBll)Bll).Update(items.Cast<BaseHareketEntity>().ToList());

        //        HareketRowsSelected.ClearSelection();
        //        Listele();
        //    }

        //    bool No()
        //    {
        //        HareketRowsSelected.ClearSelection();
        //        return true;
        //    }
        //}
    }
}
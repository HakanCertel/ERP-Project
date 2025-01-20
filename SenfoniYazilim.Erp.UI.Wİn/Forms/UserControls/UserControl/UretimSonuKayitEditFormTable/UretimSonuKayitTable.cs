using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using System.Linq;
using System.Collections.Generic;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.CRPForms.IsEmriForms;
using SenfoniYazilim.Erp.Model.Dto.CRPDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Common.Enums;
using System;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.UretimSonuKayitEditFormTable
{
    public partial class UretimSonuKayitTable :BaseTablo
    {
        public UretimSonuKayitTable()
        {
            InitializeComponent();

            Bll = new UretimSonuKayitBilgileriBll();
            Tablo = tablo;
            EventsLoad();

            ShowItems = new BarItem[] { btnKartDuzenle,btnHareketEkle };
            //insUpNavigator.Navigator.Buttons.Append.Visible = false;
        }

        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((UretimSonuKayitBilgileriBll)Bll).List(x => x.UretimSonuKayitId==OwnerForm.Id).toBindingList<UretimSonuKayitBilgileriL>();
            //((UretimSonuKayitEditForm)OwnerForm)._kayitBilgileriL.FiltreleDataSource<UretimSonuKayitBilgileriL>(false, Tablo, x => !x.AnaKod);
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colDepoKodu)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemDepo, colDepoId,colDepoAdi);
        }
        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var entity = Tablo.GetRow<UretimSonuKayitBilgileriL>();

            if (entity == null) return;

            if (e.Column == colBirimIhtiyac)
            {
                entity.KayitMiktari = entity.BirimIhtiyac*((UretimSonuKayitEditForm)OwnerForm).txtKalanMiktar.Value;
                entity.Update = true;
            }
            
           base.Tablo_CellValueChanged(sender, e);
        }
        protected internal override bool HatalıGiriş()
        {
            if (tablo.DataController.ListSource.Count <= 0)
            {
                Messages.HataMesaji("Üretim Sonu Kayıt Bilgileri Tablosunda Eklenmiş Bir Kayıt Olmadığı İçin Kayıt İşlemi Gerçekleştirilemez.");
            }
            if (!TableValueChanged) return false;
            /*  if (tablo.HasColumnErrors)*/
            tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<UretimSonuKayitBilgileriL>(i);

                if (entitiy.BirimIhtiyac == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colBirimIhtiyac;
                    tablo.SetColumnError(colBirimIhtiyac, "Miktar Alanına Geçerli Bir Değer Giriniz .");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected internal List<UretimSonuKayitBilgileriL> CreateUSB(IEnumerable<WorkOrderMaterialItemsL> womiL)
        {
            var usblist = new List<UretimSonuKayitBilgileriL>();

            foreach (var womi in womiL)
            {
                var entity = new UretimSonuKayitBilgileriL
                {
                    UretimSonuKayitId =OwnerForm.Id,
                    MalzemeIhtiyacBilgileriId = womi.MalzemeIhtiyacBilgileriId,
                    StokId = womi.MaterialId,
                    StokKodu = womi.MaterialCode,
                    StokAdi = womi.MaterialName,
                    DepoId = womi.WarehouseId,
                    DepoKodu = womi.WarehouseCode,
                    DepoAdi = womi.WarehouseName,
                    BirimId = womi.UnitId,
                    BirimAdi = womi.UnitName,
                    BirimIhtiyac = womi.UnitQty,
                    FireMiktari = womi.WastageQty,
                    Insert = true
                };

                entity.KayitMiktari =womi.UnitQty* (decimal)((UretimSonuKayitEditForm)OwnerForm).txtKalanMiktar.EditValue;

                Tablo.DataController.ListSource.Add(entity);
                //usblist.Add(entity);
            }
            return usblist;
        }

        protected internal override IList<BaseHareketEntity> TranferItem()
        {
            //return base.TranferItem();
            var source = Tablo.DataController.ListSource.Cast<UretimSonuKayitBilgileriL>().ToList();
            if (source.Count == 0) return null;
            var transferedItems = new List<WareHouseStockL>();

            source.ForEach(x =>
            {
                var warehouseItem = new WareHouseStockL
                {
                    MaterialId = x.StokId,
                    WareHouseId = x.DepoId,
                    UnitId=x.BirimId,
                    Quantity = - x.ToplamMiktar,
                };

                transferedItems.Add(warehouseItem);
            });
            var warehouse = new WareHouseStockL
            {
                MaterialId = ((UretimSonuKayitEditForm)OwnerForm).txtKod.Id,
                WareHouseId =(long) ((UretimSonuKayitEditForm)OwnerForm).txtDepoKodu.Id,
                Quantity = ((UretimSonuKayitEditForm)OwnerForm).txtKalanMiktar.Value+ ((UretimSonuKayitEditForm)OwnerForm).txtFireMiktari.Value,
                UnitId= ((UretimSonuKayitEditForm)OwnerForm).txtUnit.Id,
            };

            transferedItems.Add(warehouse);

            return transferedItems.Cast<BaseHareketEntity>().ToList();
        }

        protected internal override bool InsertStockMoving()
        {
            var source = Tablo.DataController.ListSource.Cast<UretimSonuKayitBilgileriL>().ToList();
            if (source.Count == 0) return false;
            var hareketList = new List<BaseHareketEntity>();
            source.ForEach(x =>
            {
                var stokHareketi = new StokHareketleri
                {
                    Id = 0,
                    StokId = x.StokId,
                    UnitId=x.BirimId,
                    DepoId = x.DepoId,
                    FormId = OwnerForm.Id,
                    FormCode = ((UretimSonuKayitEditForm)OwnerForm).OldEntity.Kod,
                    FormItemId = x.Id,
                    HareketTuru = HareketTuru.Cikis,
                    HareketCinsi = "Uretim Sonu Kayıt İşlemi",
                    IslemMiktari = x.KayitMiktari,
                    HareketTarihi = DateTime.Now,
                };
                hareketList.Add(stokHareketi);
            });

            var stokHareketiMain = new StokHareketleri
            {
                Id = 0,
                StokId = ((UretimSonuKayitEditForm)OwnerForm).txtKod.Id,
                UnitId= ((UretimSonuKayitEditForm)OwnerForm).txtUnit.Id,
                DepoId = (long)((UretimSonuKayitEditForm)OwnerForm).txtDepoKodu.Id,
                FormId = OwnerForm.Id,
                FormCode = ((UretimSonuKayitEditForm)OwnerForm).OldEntity.Kod,
                FormItemId =(int)OwnerForm.Id,
                HareketTuru = HareketTuru.Giris,
                HareketCinsi = "Uretim Sonu Kayıt İşlemi",
                IslemMiktari = ((UretimSonuKayitEditForm)OwnerForm).txtKalanMiktar.Value + ((UretimSonuKayitEditForm)OwnerForm).txtFireMiktari.Value,
                HareketTarihi = DateTime.Now,
            };

            hareketList.Add(stokHareketiMain);

            return Erp.Bll.Functions.GetAnySingleOrListBll.InsertStokHareketleri(hareketList);
        }

    }
}

using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System.Collections;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Dto.CRPDto;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.TransferBetweenWarehousesForms
{
    public partial class TransferDemandBetweenWarehouseTable : BaseTablo
    {
        protected internal TransferCreatingMethod _transferMethod;
        protected internal string _demandSourceCode;
        protected internal WorkOrdersL _wo;
        private bool _newRowParameter=false;//yeni satır eklendiğinde satırın transfer birimi hücresini malzemebirimi ile eşitlem amacıyla kullanılacaktır
        private Birim _defaultUnit;
        private List<Birim> _units;

        public TransferDemandBetweenWarehouseTable()
        {
            InitializeComponent();

            Bll = new TarnsferItemsBetweenWareHousesBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            base.Yukle();
            if (_transferMethod == TransferCreatingMethod.ChooseRequestItem)
                GetRequest(Tablo.DataController.ListSource);
            _units = GetAnySingleOrListBll.ListUnitItems(null);
            repositoryItemLookUpUnitCodeOfTransfer.DataSource = _units;
            repositoryItemLookUpUnitCodeOfTransfer.ValueMember = "Id";
            repositoryItemLookUpUnitCodeOfTransfer.DisplayMember = "BirimAdi";

        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((TarnsferItemsBetweenWareHousesBll)Bll).List(x => x.OwnerFormId == OwnerForm.Id).toBindingList<TarnsferItemsBetweenWareHousesL>();
        }
        protected override void HareketEkle()
        {
            _newRowParameter = true;
            _transferMethod = ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferCreatingMethod.Text.GetEnum<TransferCreatingMethod>();

            var transferDepoId = ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferWarehouse.Id;
            var transferEdilenDepoId = ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferedWarehouse.Id;

            if (transferDepoId == null|| transferEdilenDepoId==null)
            {
                Messages.HataMesaji("Lütfen Depo Alanlarına Geçerli Bir Değer Giriniz .");
                ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferWarehouse.Focus();
                return;
            }
            var source = Tablo.DataController.ListSource;

            var entities = _transferMethod == TransferCreatingMethod.ChooseMaterial ? GetMaterial(source) :
                           _transferMethod == TransferCreatingMethod.ChooseRequestItem ? GetRequest(source) : null;

            if (entities == null) return;
          

            Tablo.Focus();
            Tablo.RefreshDataSource();
            Tablo.FocusedRowHandle = Tablo.DataRowCount - 1;
            Tablo.FocusedColumn = colMaterialCode;
            ButtonEnabledDurum(true);
        }

        protected internal override bool HatalıGiriş()
        {
            if (tablo.DataController.ListSource.Count <= 0)
            {
                Messages.HataMesaji("Eklenmiş Bir Kayıt Olmadığı İçin Kayıt İşlemi Gerçekleştirilemez.");
                return true;
            }
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<TarnsferItemsBetweenWareHousesL>();

                if (entity.DemandedQuantity == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colDemandedQuantity;
                    tablo.SetColumnError(colDemandedQuantity, "Miktar Alanına Geçerli Bir Değer Giriniz .");
                }
                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }
            return false;
        }

        protected internal override bool TopluHareketSil()
        {
            var source = tablo.DataController.ListSource.Cast<TarnsferItemsBetweenWareHousesL>();

            if (source == null) return true;

            source.ForEach(x =>
            {
                x.Delete = true;
            });

            //tablo.RefreshDataSource();

            ButtonEnabledDurum(true);
            return Kaydet();
        }

        protected internal override IList<BaseHareketEntity> TranferItem()
        {
            var source = Tablo.DataController.ListSource.Cast<TarnsferItemsBetweenWareHousesL>().ToList();
            if (source.Count == 0) return null;
            var transferedItems = new List<WareHouseStockL>();
            source.ForEach(x =>
            {
                var warehouseItem = new WareHouseStockL
                {
                    MaterialId = x.MaterialId,
                    WareHouseId = x.TransferedWareHouseId,
                    UnitId=x.UnitId,
                    Quantity = x.TransferedQuantity,
                };
                transferedItems.Add(warehouseItem);
            });
            source.ForEach(x =>
            {
                var warehouseItem = new WareHouseStockL
                {
                    MaterialId = x.MaterialId,
                    WareHouseId = x.TransferWareHouseId,
                    UnitId=x.UnitId,
                    Quantity = -x.TransferedQuantity,
                };

                transferedItems.Add(warehouseItem);
            });

            return transferedItems.Cast<BaseHareketEntity>().ToList();
        }

        protected internal override bool InsertStockMoving()
        {
            var source =Tablo.DataController.ListSource.Cast<TarnsferItemsBetweenWareHousesL>().ToList();
            if (source.Count == 0) return false;
            var hareketList = new List<BaseHareketEntity>();
            source.ForEach(x =>
            {
                var stokHareketi = new StokHareketleri
                {
                    Id = 0,
                    StokId = x.MaterialId,
                    UnitId=x.UnitId,
                    DepoId = x.TransferWareHouseId,
                    FormId = OwnerForm.Id,
                    FormCode = ((TransferDemandBetweenWarehousesEditForm)OwnerForm).OldEntity.Kod,
                    FormItemId=x.Id,
                    HareketTuru = HareketTuru.Cikis,
                    HareketCinsi = "DepolarArasıTransfer",
                    IslemMiktari = x.TransferedQuantity,
                    HareketTarihi = DateTime.Now,
                };
                hareketList.Add(stokHareketi);
            });
            source.ForEach(x =>
            {
                var stokHareketi = new StokHareketleri
                {
                    Id = 0,
                    StokId = x.MaterialId,
                    UnitId=x.UnitId,
                    DepoId = x.TransferedWareHouseId,
                    FormId = OwnerForm.Id,
                    FormCode= ((TransferDemandBetweenWarehousesEditForm)OwnerForm).OldEntity.Kod,
                    FormItemId=x.Id,
                    HareketTuru = HareketTuru.Giris,
                    HareketCinsi = "DepolarArasıTransfer",
                    IslemMiktari = x.TransferedQuantity,
                    HareketTarihi = DateTime.Now,
                };
                hareketList.Add(stokHareketi);
            });
            return GetAnySingleOrListBll.InsertStokHareketleri(hareketList);
        }

        protected internal override void SutunGizleGoster()
        {
            base.SutunGizleGoster();
            if (!_isLoaded) return;
            colTransferedQuantity.Visible = ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransfer.Checked;
            colOpenQuantity.Visible = ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransfer.Checked;
        }

        protected override void RowCellAllowEdit()
        {
            //base.RowCellAllowEdit();
            if(!_isLoaded) return;
            var entity = Tablo.GetRow<TarnsferItemsBetweenWareHousesL>(false);
            if (entity == null) return;
            colDemandedQuantity.OptionsColumn.AllowEdit = !entity.IsClosed;
            colBirimAdi.OptionsColumn.AllowEdit = !entity.IsClosed;
            colDemandedDate.OptionsColumn.AllowEdit = !entity.IsClosed;
        }

        private List<TarnsferItemsBetweenWareHousesL> GetMaterial(IList source)
        {
            if (source == null) return null;

            ListeDisiTutulacakKayitlar?.Clear();

            ListeDisiTutulacakKayitlar = source.Cast<TarnsferItemsBetweenWareHousesL>().Where(x => !x.Delete).Select(x => x.MaterialId).ToList();

            var entities = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok,true)?.EntityListConvert<MaterialL>().ToList();

            if (entities == null) return null;

            foreach (var entity in entities)
            {
                var depoId =(long) ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferWarehouse.Id;

                var storageStockQty = Convert.ToDecimal(GetAnySingleOrListBll.SingleWarehouseStock(entity.Id, depoId)?.Quantity);

                var rezervedQty = GetAnySingleOrListBll.ListRezervasyonBilgisi(x=>x.WarehouseId==depoId&&x.MaterialId==entity.Id)
                    ?.Sum(x => x.RezervedQty);

                var row = new TarnsferItemsBetweenWareHousesL
                {
                    OwnerFormId=OwnerForm.Id,
                    DemandSourceCode=_demandSourceCode,
                    CreatorUserId=AnaForm.KullaniciId,
                    DemandingUserId = ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtDemandingUser.Id,
                    DocumentDate=DateTime.Now,
                    UnitId=(long)entity.UnitId,
                    UnitCodeOfTransfer=entity.UnitCode,
                    MaterialId = entity.Id,
                    MaterialCode = entity.StockCode,
                    MaterialName = entity.StockName,
                    MaterialUnitCode=entity.UnitCode,
                    MaterialQuantity=storageStockQty,
                    TransferCreatingMethod=_transferMethod,
                    DescriptionOfTransferProccess=DescriptionOfTransferProccess.TransferDemand,
                    TransferWareHouseId=(long)((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferWarehouse.Id,
                    TransferWareHouseName =((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferWarehouse.Text,
                    TransferedWareHouseId=(long)((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferedWarehouse.Id,
                    TransferedWareHousename = ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferedWarehouse.Text,
                    OpenQuantity=storageStockQty-rezervedQty,
                    Insert = true,
                };
                if (((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtDemandedDate.EditValue != null)
                    row.DemandedDate = (DateTime)((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtDemandedDate.EditValue;

                //row.TransferedQuantity = row.OpenQuantity > row.DemandedQuantity ? row.DemandedQuantity : (decimal)row.OpenQuantity;

                source.Add(row);
            }
            return source.Cast<TarnsferItemsBetweenWareHousesL>().ToList();
        }

        protected internal List<TarnsferItemsBetweenWareHousesL> GetRequest(IList source)
        {
            if (source == null) return null;

            var entities = GetAnySingleOrListBll.ListWorkOrderMaterialItems(x => x.OwnerFormId == _wo.Id);

            if (entities == null) return null;

            foreach (var entity in entities)
            {
                var depoId = (long)((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferWarehouse.Id;

                var storageStockQty = Convert.ToDecimal(GetAnySingleOrListBll.SingleWarehouseStock(entity.Id, depoId)?.Quantity);

                var rezervedQty = GetAnySingleOrListBll.ListRezervasyonBilgisi(x => x.WarehouseId == depoId && x.MaterialId == entity.Id)
                    ?.Sum(x => x.RezervedQty);

                var row = new TarnsferItemsBetweenWareHousesL
                {
                    OwnerFormId = OwnerForm.Id,
                    DemandSourceCode = _demandSourceCode,
                    RezerveRelatedItemId=entity.MalzemeIhtiyacBilgileriId,
                    CreatorUserId = AnaForm.KullaniciId,
                    DemandingUserId = ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtDemandingUser.Id,
                    DocumentDate = DateTime.Now,
                    UnitId = (long)entity.UnitId,
                    UnitCodeOfTransfer = entity.UnitCode,
                    MaterialId = entity.Id,
                    MaterialCode = entity.MaterialCode,
                    MaterialName = entity.MaterialName,
                    MaterialUnitCode = entity.UnitCode,
                    MaterialQuantity = storageStockQty,
                    TransferCreatingMethod = _transferMethod,
                    DescriptionOfTransferProccess = DescriptionOfTransferProccess.TransferDemand,
                    TransferWareHouseId = (long)((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferWarehouse.Id,
                    TransferWareHouseName = ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferWarehouse.Text,
                    TransferedWareHouseId = (long)((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferedWarehouse.Id,
                    TransferedWareHousename = ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferedWarehouse.Text,
                    OpenQuantity = storageStockQty - rezervedQty,
                    DemandedQuantity=entity.RemainingRequestQty,
                    DemandSource = KartTuru.IsEmri,
                    DemandSourceDescription=KartTuru.IsEmri.toName(),
                    Insert = true,
                };
                if (((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtDemandedDate.EditValue != null)
                    row.DemandedDate = (DateTime)((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtDemandedDate.EditValue;

                //row.TransferedQuantity = row.OpenQuantity > row.DemandedQuantity ? row.DemandedQuantity : (decimal)row.OpenQuantity;

                source.Add(row);
            }
            return source.Cast<TarnsferItemsBetweenWareHousesL>().ToList();
        }

        protected override void LookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            var entity = Tablo.GetRow<TarnsferItemsBetweenWareHousesL>(false);

            entity.UnitId =Convert.ToInt64(((LookUpEdit) sender).EditValue);

            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);

        }

        protected override void Tablo_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            base.Tablo_FocusedRowObjectChanged(sender, e);
            var entity = Tablo.GetRow<TarnsferItemsBetweenWareHousesL>(false);
            if (!_newRowParameter || entity==null) return;
            Tablo.SetFocusedRowCellValue(colBirimAdi, entity.UnitId);
            _newRowParameter = false;
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);
            var entity = Tablo.GetRow<TarnsferItemsBetweenWareHousesL>(false);
            if (entity == null) return;
            if (e.Column == colDemandedQuantity)
            {
                entity.TransferedQuantity = entity.OpenQuantity > entity.DemandedQuantity ? entity.DemandedQuantity
                    :(decimal)entity.OpenQuantity; 
            }
        }

    }
}

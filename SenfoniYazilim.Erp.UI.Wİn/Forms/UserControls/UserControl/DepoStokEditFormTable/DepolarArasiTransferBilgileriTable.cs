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
using SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.TransferBetweenWarehousesForms;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System.Collections;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.DepoStokEditFormTable
{
    public partial class DepolarArasiTransferBilgileriTable : BaseTablo
    {
        protected internal TransferCreatingMethod _transferMethod;
        private Birim _defaultUnit;
        private List<Birim> _units;

        public DepolarArasiTransferBilgileriTable()
        {
            InitializeComponent();

            Bll = new TarnsferItemsBetweenWareHousesBll();
            Tablo = tablo;
            EventsLoad();


        }
        protected internal override void Yukle()
        {
            base.Yukle();
            _units = Erp.Bll.Functions.GetAnySingleOrListBll.ListUnitItems(null);
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

            //var statu=((TransferBetweenWarehousesEditForm)OwnerForm).txtTransferStatu.Text.GetEnum<TransferStatu>();

            #region Comment
            //if (statu == TransferStatu.Uretim)
            //{
            //    ListeDisiTutulacakKayitlar = source.Select(x => x.MaterialId).ToList();

            //    var entities = ShowListForms<DATMalzemeIhtiyaclariListForm>.ShowDialogListForm(KartTuru.DepolarArasiTransfer, ListeDisiTutulacakKayitlar, true,Convert.ToUInt64( transferDepoId)).EntityListConvert<MrpMalzemeIhtiyacBilgileriBirlestirL>();

            //    if (entities == null) return;

            //    DepoTransferBilgileriOlustur(entities.ToList());
            //}
            //else if(statu == TransferStatu.Acik)
            //{
            //    /*transferDepoStokIdList*/
            //    ListeDisiTutulacakKayitlar = GeneralFunctions.ListDepoStok(x => x.WareHouseId == transferDepoId).Cast<WareHouseStockL>().Select(x => x.MaterialId).ToList(); ;

            //    var entities = ShowListForms<DATStokListForm>.ShowDialogListForm(KartTuru.Stok, ListeDisiTutulacakKayitlar, true, (long)transferDepoId).EntityListConvert<MaterialL>();

            //    if (entities == null) return;

            //    DepoTransferBilgileriOlustur(entities.ToList());
            //}
            #endregion

            Tablo.Focus();
            Tablo.RefreshDataSource();
            Tablo.FocusedRowHandle = Tablo.DataRowCount - 1;
            Tablo.FocusedColumn = colMaterialCode;
            ButtonEnabledDurum(true);
        }
        private List<TarnsferItemsBetweenWareHousesL> GetMaterial(IList source)
        {
            if (source == null) return null;

            ListeDisiTutulacakKayitlar?.Clear();

            ListeDisiTutulacakKayitlar = source.Cast<TarnsferItemsBetweenWareHousesL>().Where(x => !x.Delete).Select(x => x.MaterialId).ToList();

            var entities = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, true)?.EntityListConvert<MaterialL>().ToList();

            if (entities == null) return null;

            foreach (var entity in entities)
            {
                var storageStockQty = Convert.ToDecimal(GetAnySingleOrListBll.SingleWarehouseStock(entity.Id, entity.DepoId)?.Quantity);

                var row = new TarnsferItemsBetweenWareHousesL
                {
                    OwnerFormId=OwnerForm.Id,
                    CreatorUserId=AnaForm.KullaniciId,
                    DemandedDate=(DateTime) ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtDemandedDate.EditValue,
                    DemandingUserId = ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtDemandingUser.Id,
                    DocumentDate=DateTime.Now,
                    MaterialId = entity.Id,
                    MaterialCode = entity.StockCode,
                    MaterialName = entity.StockName,
                    MaterialUnitCode=entity.UnitCode,
                    MaterialQuantity=storageStockQty,
                    TransferCreatingMethod=_transferMethod,
                    TransferWareHouseId=(long)((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferWarehouse.Id,
                    TransferWareHouseName =((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferWarehouse.Text,
                    TransferedWareHouseId=(long)((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferedWarehouse.Id,
                    TransferedWareHousename = ((TransferDemandBetweenWarehousesEditForm)OwnerForm).txtTransferedWarehouse.Text,
                    UnitCodeOfTransfer=entity.UnitCode,
                    Insert = true,
                };
                source.Add(row);
            }
            return source.Cast<TarnsferItemsBetweenWareHousesL>().ToList();
        }
        private List<TarnsferItemsBetweenWareHousesL> GetRequest(IList source)
        {
            return null;
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
        //private void DepoTransferBilgileriOlustur(List<MrpMalzemeIhtiyacBilgileriBirlestirL> mibEntities)
        //{
        //    var source = Tablo.DataController.ListSource;

        //    if (mibEntities == null) return;

        //    foreach (var entity in mibEntities)
        //    {
        //        var row = new TarnsferItemsBetweenWareHousesL
        //        {
        //            CreatorUserId = AnaForm.KullaniciId,
        //            TransferId = OwnerForm.Id,
        //            TransferWareHouseId = Convert.ToInt64(((TransferBetweenWarehousesEditForm)OwnerForm).txtTransferDepo.Id),
        //            TransferedWareHouseId = Convert.ToInt64(((TransferBetweenWarehousesEditForm)OwnerForm).txtTransferEdilenDepo.Id),
        //            MaterialId = entity.StokId,
        //            MaterialCode = entity.StokKodu,
        //            MaterialName = entity.StokAdi,
        //            TransferDate= DateTime.Now,
        //            TransferStatu= ((TransferBetweenWarehousesEditForm)OwnerForm).txtTransferStatu.Text.GetEnum<TransferStatu>(),
        //            DemandedQuantity = 0,
        //            MaterialQuantity= GeneralFunctions.SingleDepoStok(entity.StokId,entity.DepoId).Quantity,
        //            RezerveQuantity= Convert.ToDecimal(entity.ToplamRezerveMiktar),
        //            RequestQuantity=entity.NetIhtiyac,
        //            UnitNameOfTransfer = entity.Birim,
        //            Insert = true
        //        };
        //        row.OpenQuantity = row.MaterialQuantity - row.RezerveQuantity;// Convert.ToDecimal(entity.AcikMiktar);

        //        source.Add(row);
        //    }

        //}
        //private void DepoTransferBilgileriOlustur(List<MaterialL> mibEntities)
        //{
        //    var source = Tablo.DataController.ListSource;

        //    if (mibEntities == null) return;

        //    foreach (var entity in mibEntities)
        //    {
        //        var row = new TarnsferItemsBetweenWareHousesL
        //        {
        //            CreatorUserId = AnaForm.KullaniciId,
        //            TransferId = OwnerForm.Id,
        //            TransferWareHouseId = Convert.ToInt64(((TransferBetweenWarehousesEditForm)OwnerForm).txtTransferDepo.Id),
        //            TransferedWareHouseId = Convert.ToInt64(((TransferBetweenWarehousesEditForm)OwnerForm).txtTransferEdilenDepo.Id),
        //            MaterialId = entity.Id,
        //            MaterialCode = entity.Kod,
        //            MaterialName = entity.StockName,
        //            TransferDate= DateTime.Now,
        //            TransferStatu = ((TransferBetweenWarehousesEditForm)OwnerForm).txtTransferStatu.Text.GetEnum<TransferStatu>(),
        //            DemandedQuantity = 0,
        //            MaterialQuantity = GeneralFunctions.SingleDepoStok(entity.Id, entity.DepoId).Quantity,
        //            UnitCodeOfTransfer = entity.Unit,
        //            Insert = true
        //        };
        //        row.MaterialQuantity = GeneralFunctions.SingleDepoStok(row.MaterialId, row.TransferWareHouseId).Quantity;
        //        row.RezerveQuantity= GeneralFunctions.RezervasyonBilgisi(row.MaterialId, row.TransferWareHouseId)?.ToplamRezerveEdilenMiktar;
        //        row.OpenQuantity = row.MaterialQuantity - row.RezerveQuantity;
        //        source.Add(row);
        //    }
        //}
        //protected internal override void SutunGizleGoster()
        //{
        //    var statu = ((TransferBetweenWarehousesEditForm)OwnerForm).txtTransferStatu.Text.GetEnum<TransferStatu>();
        //    if (statu == TransferStatu.Uretim)
        //    {
        //        colIhtiyacMiktari.Visible = true;
        //        colIhtiyacMiktari.VisibleIndex = 5;
        //    }
        //    else
        //        colIhtiyacMiktari.Visible = false;
        //}

    }
}

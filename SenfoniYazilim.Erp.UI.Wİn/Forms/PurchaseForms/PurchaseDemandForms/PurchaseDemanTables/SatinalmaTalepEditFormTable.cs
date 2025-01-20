using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Model.Dto;
using DevExpress.XtraGrid.Views.Base;
using SenfoniYazilim.Erp.Common.Message;
using DevExpress.XtraPrinting.Native;
using System;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using System.Collections.Generic;
using System.Collections;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.PurchaseDemandForms;
using SenfoniYazilim.Erp.Model.Dto.SalesDto;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.SatinalmaFormTables
{
    public partial class SatinalmaTalepEditFormTable : BaseTablo
    {
        private KartTuru _dataSourceCardType;

        public SatinalmaTalepEditFormTable()
        {
            InitializeComponent();

            Bll = new PurchaseDemandItemsTableBll();
            Tablo = tablo;
            EventsLoad();

        }
        protected internal override void Yukle()
        {
            base.Yukle();

            if (((PurchaseDemanEditForm)OwnerForm).DataSourceCardType == KartTuru.SalesItems)
                GetFromSaleItems(Tablo.DataController.ListSource);
            else if (((PurchaseDemanEditForm)OwnerForm).DataSourceCardType == KartTuru.MaterialRequirmentPlaning)
                GetFromMetarialRequirementItems(Tablo.DataController.ListSource);
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((PurchaseDemandItemsTableBll)Bll).List(x => x.OwnerFormId == OwnerForm.Id).toBindingList<PurchaseDemandItemsL>();
        }
        protected override void HareketEkle()
        {
            var source = Tablo.DataController.ListSource;

            _dataSourceCardType = ((PurchaseDemanEditForm)OwnerForm).DataSourceCardType;

            GetMaterial(source);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colStockCode;

            ButtonEnabledDurum(true);
        }
        private void GetFromSaleItems(IList source)
        {
            if (source == null) return ;
            var entities = new List<SalesItemsL>();

            if (((PurchaseDemanEditForm)OwnerForm).SelectedEntities == null) return;

            entities = ((PurchaseDemanEditForm)OwnerForm).SelectedEntities.Cast<SalesItemsL>().ToList();

            foreach (var entity in entities)
            {
                var row = new PurchaseDemandItemsL
                {
                    OwnerFormId = OwnerForm.Id,
                    CreatorId = AnaForm.KullaniciId,
                    MaterialId = entity.MaterialId,
                    StockCode = entity.MaterialCode,
                    StockName = entity.MaterialName,
                    UnitId = entity.UnitOfMaterialSalesId,
                    UnitCode=entity.UnitCodeOfMaterialSales,
                    DemandQty=entity.SalesQty,
                    DemandedDate = entity.DeliveryDate,
                    DataSourceCardType=KartTuru.SalesItems,
                    DataSourceFormId=entity.SalesId,
                    DataSourceItemId=entity.Id,
                    Insert = true,
                };
                source.Add(row);
            }

            source.Cast<PurchaseDemandItemsL>().ToList();

        }

        private void GetFromMetarialRequirementItems(IList source)
        {
            if (source == null) return;
            var entities = new List<MalzemeIhtiyacBilgileriL>();

            if (((PurchaseDemanEditForm)OwnerForm).SelectedEntities == null) return;

            entities = ((PurchaseDemanEditForm)OwnerForm).SelectedEntities.Cast<MalzemeIhtiyacBilgileriL>().ToList();

            foreach (var entity in entities)
            {
                var row = new PurchaseDemandItemsL
                {
                    OwnerFormId = OwnerForm.Id,
                    CreatorId = AnaForm.KullaniciId,
                    MaterialId = entity.StokId,
                    StockCode = entity.StokKodu,
                    StockName = entity.StokAdi,
                    UnitId = entity.BirimId,
                    UnitCode = entity.BirimAdi,
                    DemandQty = entity.NetIhtiyac,
                    DemandedDate = entity.TavsiyeEdilenBaslamaTarihi,
                    DataSourceCardType = KartTuru.MaterialRequirmentPlaning,
                    DataSourceFormId = entity.DemandId,
                    DataSourceItemId = entity.Id,
                    Insert = true,
                };
                source.Add(row);
            }

            source.Cast<PurchaseDemandItemsL>().ToList();

        }
        private List<PurchaseDemandItemsL> GetMaterial(IList source)
        {
            if (source == null) return null;
            var stoklar = new List<MaterialL>();

            ListeDisiTutulacakKayitlar?.Clear();

            ListeDisiTutulacakKayitlar = source.Cast<PurchaseDemandItemsL>().Where(x => !x.Delete).Select(x => x.MaterialId).ToList();


            stoklar = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, true).EntityListConvert<MaterialL>()?.ToList();

            if (stoklar == null) return null;

            foreach (var stok in stoklar)
            {
                var row = new PurchaseDemandItemsL
                {
                    OwnerFormId = OwnerForm.Id,
                    CreatorId = AnaForm.KullaniciId,
                    MaterialId = stok.Id,
                    StockCode = stok.Kod,
                    StockName = stok.StockName,
                    UnitId=(long)stok.UnitId,
                    UnitCode = stok.UnitCode,
                    DemandedDate = DateTime.Now,
                    Insert = true,
                };
                source.Add(row);
            }

            return source.Cast<PurchaseDemandItemsL>().ToList();
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colStockCode)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemButtonSatinalmaTalepStok, colStockId);
            if (e.FocusedColumn == colCompanyName)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemButtonFirma, colDemandedCompanyId);
        }

        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<PurchaseDemandItemsL>(i);

                if (entitiy.StockCode == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colStockCode;
                    tablo.SetColumnError(colStockCode, "Stok Kodu Alanına Geçerli Bir Değer Giriniz .");
                }
                if (entitiy.DemandQty == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colDemandQty;
                    tablo.SetColumnError(colDemandQty, "Miktar Alanına Geçerli Bir Değer Giriniz .");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected internal override bool TopluHareketSil()
        {
            var source = tablo.DataController.ListSource.Cast<PurchaseDemandItemsL>()
                .Where(x=>!x.IsComfirmed&&!x.IsCreatedOrder&&!x.IsTopDemandExisted);

            if (source == null) return false;

            var silinenKayitVarmi = false;

            source.ForEach(x =>
            {
                x.Delete = true;
                silinenKayitVarmi = true;
            });

            if (!silinenKayitVarmi) return false;

            tablo.RefreshDataSource();
            return true;
            //ButtonEnabledDurum(true);
        }

        protected override void HareketSil()
        {
            var entity = Tablo.GetRow<PurchaseDemandItemsL>(false);

            if (entity == null) return;

            if (entity.IsComfirmed || entity.IsCreatedOrder || entity.IsTopDemandExisted)
            {
                Messages.KayıtSilinemezMesaji();
                return;
            }

            base.HareketSil();
        }

    }
}

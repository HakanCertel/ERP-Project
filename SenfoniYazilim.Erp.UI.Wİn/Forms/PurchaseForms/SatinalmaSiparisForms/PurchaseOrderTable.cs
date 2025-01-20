using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.PurchaseDemandForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.SatinalmaTeklifForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaSiparisForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.SatinalmaSiparisForms
{
    public partial class PurchaseOrderTable : BaseTablo
    {
        public PurchaseOrderCreatingMethod _offerMethod;
        private DovizBilgileri _defaultCurrency;
        private Kdv _defaultTaxRate;
        private Birim _defaultUnit;
        private List<Birim> _units;
        private List<DovizBilgileri> _currenies;
        private List<Kdv> _taxRates;

        public PurchaseOrderTable()
        {
            InitializeComponent();
            Bll = new PurchaseOrderItemsBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            base.Yukle();

            //_currenies = GetAnySingleOrListBll.ListCurrencyItems(null);
            _taxRates = GetAnySingleOrListBll.ListTaxRate(null);
            _units = GetAnySingleOrListBll.ListUnitItems(null);

            //_defaultCurrency = _currenies.FirstOrDefault();
            _defaultTaxRate = _taxRates.FirstOrDefault();

            repositoryItemLookUpUnit.DataSource = _units;
            repositoryItemLookUpUnit.ValueMember = "Id";
            repositoryItemLookUpUnit.DisplayMember = "BirimAdi";

            repositoryItemLookUpTax.DataSource = _taxRates;
            repositoryItemLookUpTax.ValueMember = "Id";
            repositoryItemLookUpTax.DisplayMember = "Kod";
            //repositoryItemComboCurrency.Items.AddRange(_currenies.Select(x => x.Kod).ToList());
            repositoryItemComboTax.Items.AddRange(_taxRates.Select(x => x.Kod).ToList());
            repositoryItemComboUnit.Items.AddRange(_units.Select(x => x.Kod).ToList());
            if (((PurchaseOrderEditForm)OwnerForm).txtOrderCreatingMethod.Text.GetEnum<PurchaseOrderCreatingMethod>() == PurchaseOrderCreatingMethod.ChoosePurchaseOfferItem)
                GetOfferItems(Tablo.DataController.ListSource);
            if (((PurchaseOrderEditForm)OwnerForm).txtOrderCreatingMethod.Text.GetEnum<PurchaseOrderCreatingMethod>() == PurchaseOrderCreatingMethod.ChoosePurchaseDemandItem)
                GetDemandItems(Tablo.DataController.ListSource);
        }

        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((PurchaseOrderItemsBll)Bll).List(x => x.OwnerFormId == OwnerForm.Id).toBindingList<PurchaseOrderItemsL>();
        }

        protected override void HareketEkle()
        {
            _offerMethod = ((PurchaseOrderEditForm)OwnerForm).txtOrderCreatingMethod.Text.GetEnum<PurchaseOrderCreatingMethod>();

            if (((PurchaseOrderEditForm)OwnerForm).txtCompanyName.Id == null)
            {
                Messages.BilgiMesaji("Lütfen Firma Bilgisi Seçiniz!");
                ((PurchaseOrderEditForm)OwnerForm).txtCompanyName.Focus();
                return;
            }
            var source = Tablo.DataController.ListSource;

            var entities = _offerMethod == PurchaseOrderCreatingMethod.ChooseMaterial ? GetMaterial(source)
                        : _offerMethod == PurchaseOrderCreatingMethod.ChoosePurchaseDemandItem ? GetDemandItems(source) 
                        : _offerMethod==PurchaseOrderCreatingMethod.ChoosePurchaseOfferItem?GetOfferItems(source):null;

            if (entities == null) return;

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colMaterialCode;

            //((PurchaseOrderEditForm)OwnerForm).txtCompanyName.Enabled = false;

            ButtonEnabledDurum(true);
        }
        private List<PurchaseOrderItemsL> GetMaterial(IList source)
            {
                if (source == null) return null;
                var orderedCompanyId = ((PurchaseOrderEditForm)OwnerForm).txtCompanyName.Id;

                ListeDisiTutulacakKayitlar?.Clear();

                ListeDisiTutulacakKayitlar = source.Cast<PurchaseOrderItemsL>().Where(x => !x.Delete).Select(x => x.MaterialId).ToList();

                var entities = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, true)?.EntityListConvert<MaterialL>().ToList();

                if (entities == null) return null;

                foreach (var entity in entities)
                {
                    var _defaultUnitPrice = Convert.ToDecimal(GetAnySingleOrListBll.GetDefaultMaterialUnitPrice((long)orderedCompanyId, entity.Id));
                    var storageStockQty = Convert.ToDecimal(GetAnySingleOrListBll.SingleWarehouseStock(entity.Id, entity.DepoId)?.Quantity);
                    var materialRelatedCompany=GetAnySingleOrListBll.GetMaterialRelatedCompany(x => x.CompanyId == (long)orderedCompanyId && x.MaterialId == entity.Id);

                    var row = new PurchaseOrderItemsL
                    {
                        OwnerFormId = OwnerForm.Id,
                        OrderCreatorId=AnaForm.KullaniciId,
                        MaterialId = entity.Id,
                        //CurrencyId = _defaultCurrency.Id,
                        TaxRateId = _defaultTaxRate.Id,
                        UnitOfMaterialOrderedId = _units.Where(x => x.Kod == entity.UnitCode).Select(x => x.Id).FirstOrDefault(),
                        UnitCodeOfOrder = _units.Where(x => x.Kod == entity.UnitCode).Select(x => x.Kod).FirstOrDefault(),
                        PurchaseOrderCreatingMethod = ((PurchaseOrderEditForm)OwnerForm).txtOrderCreatingMethod.Text.GetEnum<PurchaseOrderCreatingMethod>(),
                        MaterialCode = entity.StockCode,
                        MaterialName = entity.StockName,
                        MaterialUnit = entity.UnitCode,
                        CompanyMaterialCod=materialRelatedCompany?.CompanyMaterialCode,
                        CompanyMaterialName=materialRelatedCompany?.CompanyMaterialName,
                        CompanyMaterialUnit=materialRelatedCompany?.CompanyMaterialUnitName,
                        TaxCode = _defaultTaxRate.Kod,
                        TaxRateValue = _defaultTaxRate.KdvOrani,
                        //CurrencyCode = _defaultCurrency.Kod,
                        //CurrencyName = _defaultCurrency.DovizAdi,
                        DefaultUnitPrice = _defaultUnitPrice,
                        StorageStockQty = storageStockQty,
                        MaxPurchaseOrderQty = materialRelatedCompany?.MaxOrderQty,
                        MinPurchaseOrderQty = materialRelatedCompany?.MinOrderQty,
                        MaxStockQty = entity.MaxStockQty,
                        MinStockQty = entity.MinStockQty,
                        Insert = true,
                    };
                    source.Add(row);
                }
                return source.Cast<PurchaseOrderItemsL>().ToList();
            }

        private List<PurchaseOrderItemsL> GetDemandItems(IList source)
        {
            if (source == null) return null;
            var orderedCompanyId =Convert.ToInt64( ((PurchaseOrderEditForm)OwnerForm).txtCompanyName.Id);
            var entities = new List<PurchaseDemandItemsListFormL>();

            ListeDisiTutulacakKayitlar?.Clear();

            ListeDisiTutulacakKayitlar=source.Cast<PurchaseOrderItemsL>().Where(x => !x.Delete).Select(x => (long)x.Id).ToList();

            if (((PurchaseOrderEditForm)OwnerForm).SelectedEntities == null)
                entities = ShowListForms<PurchaseDemanItemsListForm>.ShowDialogHareketListForm(ListeDisiTutulacakKayitlar, true, true)?.EntityListConvert<PurchaseDemandItemsListFormL>()?.ToList();
            else
                entities = ((PurchaseOrderEditForm)OwnerForm).SelectedEntities.Cast<PurchaseDemandItemsListFormL>().ToList();

            if (entities == null) return null;

            foreach (var entity in entities)
            {
                var _defaultUnitPrice = Convert.ToDecimal(GetAnySingleOrListBll.GetDefaultMaterialUnitPrice((long)orderedCompanyId, entity.Id));
                var storageStockQty = Convert.ToDecimal(GetAnySingleOrListBll.SingleWarehouseStock(entity.Id, entity.DepoId)?.Quantity);
                var materialRelatedCompany = GetAnySingleOrListBll.GetMaterialRelatedCompany(x=>x.CompanyId==(long)orderedCompanyId&&x.MaterialId== entity.MaterialId);

                var row = new PurchaseOrderItemsL
                {
                    OwnerFormId = OwnerForm.Id,
                    OrderCreatorId=AnaForm.KullaniciId,
                    PurchaseDemandId=entity.OwnerFormId,
                    PurchaseDemandItemId=entity.Id,
                    MaterialId = entity.MaterialId,
                    //CurrencyId = _defaultCurrency.Id,
                    TaxRateId = _defaultTaxRate.Id,
                    UnitOfMaterialOrderedId = _units.Where(x => x.Kod == entity.MaterialUnit).Select(x => x.Id).FirstOrDefault(),
                    UnitCodeOfOrder = _units.Where(x => x.Kod == entity.MaterialUnit).Select(x => x.Kod).FirstOrDefault(),
                    PurchaseOrderCreatingMethod = ((PurchaseOrderEditForm)OwnerForm).txtOrderCreatingMethod.Text.GetEnum<PurchaseOrderCreatingMethod>(),
                    PurchaseOrderQty=entity.DemandQty,
                    DemandedDate=entity.DemandedDate,
                    MaterialCode = entity.MaterialCode,
                    MaterialName = entity.MaterialName,
                    MaterialUnit = entity.MaterialUnit,
                    CompanyMaterialCod = materialRelatedCompany?.CompanyMaterialCode,
                    CompanyMaterialName = materialRelatedCompany?.CompanyMaterialName,
                    CompanyMaterialUnit = materialRelatedCompany?.CompanyMaterialUnitName,
                    TaxCode = _defaultTaxRate.Kod,
                    TaxRateValue = _defaultTaxRate.KdvOrani,
                    //CurrencyCode = _defaultCurrency.Kod,
                    //CurrencyName = _defaultCurrency.DovizAdi,
                    DefaultUnitPrice = _defaultUnitPrice,
                    StorageStockQty = storageStockQty,
                    MaxPurchaseOrderQty = materialRelatedCompany?.MaxOrderQty,
                    MinPurchaseOrderQty = materialRelatedCompany?.MinOrderQty,
                    MaxStockQty = entity.MaxStockQty,
                    MinStockQty = entity.MinStockQty,
                    Insert = true,
                };
                source.Add(row);
            }
            return source.Cast<PurchaseOrderItemsL>().ToList();
        }

        private List<PurchaseOrderItemsL> GetOfferItems(IList source)
        {
            if (source == null) return null;
            var orderedCompanyId = Convert.ToInt64(((PurchaseOrderEditForm)OwnerForm).txtCompanyName.Id);
            var entities = new List<PurchaseOfferItemL>();
            ListeDisiTutulacakKayitlar?.Clear();

            ListeDisiTutulacakKayitlar = source.Cast<PurchaseOfferItemL>().Where(x => !x.Delete).Select(x => (long)x.Id).ToList();
            if (((PurchaseOrderEditForm)OwnerForm).SelectedEntities == null)
                entities = ShowListForms<PurchaseOfferItemsListForm>.ShowDialogHareketListForm(ListeDisiTutulacakKayitlar, true, true)?.EntityListConvert<PurchaseOfferItemL>()?.ToList();
            else
                entities = ((PurchaseOrderEditForm)OwnerForm).SelectedEntities.Cast<PurchaseOfferItemL>().ToList();
            if (entities == null) return null;

            foreach (var entity in entities)
            {
                var _defaultUnitPrice = Convert.ToDecimal(GetAnySingleOrListBll.GetDefaultMaterialUnitPrice((long)orderedCompanyId, entity.Id));
                var storageStockQty = Convert.ToDecimal(GetAnySingleOrListBll.SingleWarehouseStock(entity.Id, entity.DepoId)?.Quantity);
                var materialRelatedCompany = GetAnySingleOrListBll.GetMaterialRelatedCompany(x => x.CompanyId == (long)orderedCompanyId && x.MaterialId == entity.MaterialId);

                var row = new PurchaseOrderItemsL
                {
                    OwnerFormId = OwnerForm.Id,
                    OrderCreatorId=AnaForm.KullaniciId,
                    PurchaseOfferId = entity.OfferId,
                    PurchaseOfferItemId = entity.Id,
                    MaterialId = entity.MaterialId,
                    //CurrencyId = _defaultCurrency.Id,
                    TaxRateId = _defaultTaxRate.Id,
                    UnitOfMaterialOrderedId = _units.Where(x => x.Kod == entity.MaterialUnit).Select(x => x.Id).FirstOrDefault(),
                    UnitCodeOfOrder = _units.Where(x => x.Kod == entity.MaterialUnit).Select(x => x.Kod).FirstOrDefault(),
                    PurchaseOrderCreatingMethod = ((PurchaseOrderEditForm)OwnerForm).txtOrderCreatingMethod.Text.GetEnum<PurchaseOrderCreatingMethod>(),
                    PurchaseOrderQty = entity.OfferQty,
                    DemandedDate = entity.DemandedDate,
                    MaterialCode = entity.MaterialCode,
                    MaterialName = entity.MaterialName,
                    MaterialUnit = entity.MaterialUnit,
                    CompanyMaterialCod = materialRelatedCompany?.CompanyMaterialCode,
                    CompanyMaterialName = materialRelatedCompany?.CompanyMaterialName,
                    CompanyMaterialUnit = materialRelatedCompany?.CompanyMaterialUnitName,
                    TaxCode = _defaultTaxRate.Kod,
                    TaxRateValue = _defaultTaxRate.KdvOrani,
                    //CurrencyCode = _defaultCurrency.Kod,
                    //CurrencyName = _defaultCurrency.DovizAdi,
                    DefaultUnitPrice = _defaultUnitPrice,
                    StorageStockQty = storageStockQty,
                    MaxPurchaseOrderQty = materialRelatedCompany?.MaxOrderQty,
                    MinPurchaseOrderQty = materialRelatedCompany?.MinOrderQty,
                    MaxStockQty = entity.MaxStockQty,
                    MinStockQty = entity.MinStockQty,
                    Insert = true,
                };
                source.Add(row);
            }
            return source.Cast<PurchaseOrderItemsL>().ToList();
        }

        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<PurchaseOrderItemsL>(i);

                if (entitiy.PurchaseOrderQty == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colPurchaseOrderQty;
                    tablo.SetColumnError(colPurchaseOrderQty, "Miktar Alanına Geçerli Bir Değer Giriniz .");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected internal void TopluHareketSil()
        {
            var source = tablo.DataController.ListSource.Cast<PurchaseOrderItemsL>();

            if (source == null) return;

            source.ForEach(x =>
            {
                x.Delete = true;
            });

            //tablo.RefreshDataSource();

            ButtonEnabledDurum(true);
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!_isLoaded) return;

            var selectedRow = Tablo.GetRow<PurchaseOrderItemsL>();
            if (selectedRow == null) return;
            if (e.Column == colPurchaseOrderQty)
            {
                selectedRow.NetAmount = selectedRow.PurchaseOrderQty * selectedRow.UnitPrice;
                selectedRow.TaxAmount = selectedRow.NetAmount * selectedRow.TaxRateValue;
                selectedRow.TotalAmount = selectedRow.NetAmount + selectedRow.TaxAmount;
            }
            else if (e.Column == colDiscountRate)
            {
                selectedRow.DiscountAmount = selectedRow.NetAmount * selectedRow.DiscountRate/100;
                selectedRow.DiscountedTotalAmount = selectedRow.NetAmount - selectedRow.DiscountAmount;
                selectedRow.TaxAmount = selectedRow.DiscountedTotalAmount * selectedRow.TaxRateValue;
                selectedRow.TotalAmount = selectedRow.NetAmount + selectedRow.TaxAmount;
            }
            else if (e.Column == colUnitPrice)
            {
                selectedRow.NetAmount = selectedRow.PurchaseOrderQty * selectedRow.UnitPrice;
                selectedRow.DiscountAmount = selectedRow.NetAmount * selectedRow.DiscountRate/100;
                selectedRow.DiscountedTotalAmount = selectedRow.NetAmount - selectedRow.DiscountAmount;
                selectedRow.TaxAmount = selectedRow.DiscountedTotalAmount * selectedRow.TaxRateValue;
                selectedRow.TotalAmount = selectedRow.NetAmount + selectedRow.TaxAmount;
            }
            else if (e.Column == colTaxRateId)
            {
                var tax = _taxRates.Where(x => x.Id == selectedRow.TaxRateId).FirstOrDefault();//.KdvOrani;
                if (tax == null) return;
                selectedRow.TaxAmount = selectedRow.DiscountedTotalAmount * Convert.ToDecimal(tax?.KdvOrani);
                selectedRow.TotalAmount = selectedRow.DiscountedTotalAmount + selectedRow.TaxAmount;
            }
            

            base.Tablo_CellValueChanged(sender, e);
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }

        //protected override void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    if (!_isLoaded) return;

        //    insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);

        //    var selectedRow = Tablo.GetRow<PurchaseOrderItemsL>(false);
        //    if (selectedRow == null) return;
        //    if (Tablo.FocusedColumn == colTaxCode)
        //    {
        //        var newValue = ((ComboBoxEdit)sender).EditValue.ToString();

        //        var tax = _taxRates.Where(x => x.Kod == newValue)?.FirstOrDefault();//.KdvOrani;
        //        if (tax == null) return;
        //        selectedRow.TaxCode = tax.Kod;
        //        selectedRow.TaxRate = tax;
        //        selectedRow.TaxRateValue = tax.KdvOrani;
        //        selectedRow.TaxRateId = tax.Id;
        //        selectedRow.TaxAmount = selectedRow.DiscountedTotalAmount * Convert.ToDecimal( tax?.KdvOrani);
        //        selectedRow.TotalAmount = selectedRow.NetAmount + selectedRow.TaxAmount;
        //    }
            
        //    base.ComboBox_SelectedValueChanged(sender, e);
        //}

    }
}

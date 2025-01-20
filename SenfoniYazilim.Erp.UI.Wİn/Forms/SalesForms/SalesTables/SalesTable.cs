using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General.SalesBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Dto.SalesDto;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SaleWayBillForms.SalesTables
{
    public partial class SalesTable : BaseTablo
    {
        public SaleCreatingMethod _saleMethod;
        private DovizBilgileri _defaultCurrency;
        private Kdv _defaultTaxRate;
        private Birim _defaultUnit;
        private List<DovizBilgileri> _currenies;
        private List<Kdv> _taxRates;
        private List<Birim> _units;

        public SalesTable()
        {
            InitializeComponent();
            Bll = new SalesItemsBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            base.Yukle();

            _currenies = GetAnySingleOrListBll.ListCurrencyItems(null);
            _taxRates = GetAnySingleOrListBll.ListTaxRate(null);
            _units = GetAnySingleOrListBll.ListUnitItems(null);

            _defaultCurrency = _currenies.FirstOrDefault();
            _defaultTaxRate = _taxRates.FirstOrDefault();

            repositoryItemComboCurrency.Items.AddRange(_currenies.Select(x => x.Kod).ToList());
            repositoryItemComboTax.Items.AddRange(_taxRates.Select(x => x.Kod).ToList());

            repositoryItemLookUpUnit.DataSource = _units;
            repositoryItemLookUpUnit.ValueMember = "Id";
            repositoryItemLookUpUnit.DisplayMember = "BirimAdi";

            repositoryItemLookUpTax.DataSource = _taxRates;
            repositoryItemLookUpTax.ValueMember = "Id";
            repositoryItemLookUpTax.DisplayMember = "Kod";

            if (((SalesEditForm)OwnerForm).SelectedEntities != null)
                GetOfferItems(Tablo.DataController.ListSource);
        }

        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((SalesItemsBll)Bll).List(x => x.SalesId == OwnerForm.Id).toBindingList<SalesItemsL>();
        }

        protected override void HareketEkle()
        {
            _saleMethod = ((SalesEditForm)OwnerForm).txtSaleCreatingMethod.Text.GetEnum<SaleCreatingMethod>();

            if (((SalesEditForm)OwnerForm).txtCompanyName.Id == 0)
            {
                Messages.BilgiMesaji("Lütfen Firma Bilgisi Seçiniz!");
                ((SalesEditForm)OwnerForm).txtCompanyName.Focus();
                return;
            }
            var source = Tablo.DataController.ListSource;

            var entities = _saleMethod == SaleCreatingMethod.ChooseMaterial ? GetMaterial(source)
                       : _saleMethod == SaleCreatingMethod.ChooseOfferItem ? GetOfferItems(source) : null;

            if (entities == null) return;
            ((SalesEditForm)OwnerForm).txtCurrency.Enabled = false;
            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colMaterialCode;

            ButtonEnabledDurum(true);
        }

        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<SalesItemsL>(i);

                if (entitiy.SalesQty == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colSalesQty;
                    tablo.SetColumnError(colSalesQty, "Miktar Alanına Geçerli Bir Değer Giriniz .");
                }
                if (entitiy.UnitOfMaterialSalesId == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colUnitOfMaterialSalesId;
                    tablo.SetColumnError(colUnitOfMaterialSalesId, "Birim Alanına Geçerli Bir Değer Giriniz .");
                }
                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected internal void TopluHareketSil()
        {
            var source = tablo.DataController.ListSource.Cast<SalesItemsL>();

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

            var selectedRow = Tablo.GetRow<SalesItemsL>();
            if (selectedRow == null) return;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            if (e.Column == colSalesQty)
            {
                selectedRow.NetAmount = selectedRow.SalesQty * selectedRow.UnitPrice;
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
                selectedRow.NetAmount = selectedRow.SalesQty * selectedRow.UnitPrice;
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
            ButtonEnabledDurum(true);
            base.Tablo_CellValueChanged(sender, e);
        }

        private List<SalesItemsL> GetOfferItems(IList source)
        {
            if (source == null) return null;

            var entities = new List<SalesOfferItemsL>();

            var companyId = ((SalesEditForm)OwnerForm).txtCompanyName.Id;
            var currencyId = (long?)((SalesEditForm)OwnerForm).txtCurrency.EditValue;

            ListeDisiTutulacakKayitlar?.Clear();

            ListeDisiTutulacakKayitlar = source.Cast<SalesItemsL>().Where(x => !x.Delete).Select(x => (long)x.SalesOfferItemId).ToList();

            if (((SalesEditForm)OwnerForm).SelectedEntities != null)
            {
                entities = ((SalesEditForm)OwnerForm).SelectedEntities.Cast<SalesOfferItemsL>().ToList();
                companyId = entities.FirstOrDefault().CompanyOfferedId;
                currencyId = entities.FirstOrDefault().CurrencyId;
            }
            else
                entities = ShowListForms<SalesOfferItemsListForm>.ShowDialogHareketListForm(ListeDisiTutulacakKayitlar, true, true,companyId,currencyId)?.EntityListConvert<SalesOfferItemsL>()?.ToList();

            if (entities == null) return null;

            foreach (var entity in entities)
            {
                var _defaultUnitPrice = Convert.ToDecimal(GetAnySingleOrListBll.GetDefaultMaterialUnitPrice((long)companyId, entity.Id));
                //var storageStockQty = Convert.ToDecimal(GetAnySingleOrListBll.SingleWarehouseStock(entity.Id, entity.DepoId)?.Quantity);
                var materialRelatedCompany = GetAnySingleOrListBll.GetMaterialRelatedCompany(x => x.CompanyId == (long)companyId && x.MaterialId == entity.Id);
                var defaultCurrencyId = Convert.ToInt64(((SalesEditForm)OwnerForm).txtCurrency.EditValue);

                var row = new SalesItemsL
                {
                    SalesId = OwnerForm.Id,
                    CreatorId=AnaForm.KullaniciId,
                    SalesOfferId=entity.SalesOfferId,
                    SalesOfferItemId=entity.Id,
                    SalesItemDescription=entity.OfferItemDescription,
                    CompanySalesId = (long)companyId,
                    DeliveryCompanyId = ((SalesEditForm)OwnerForm).txtDeliveredCompany.Id,
                    SalesQty=entity.SalesOfferQty,
                    DepoId=entity.DepoId,
                    MaterialId = entity.Id,
                    UnitOfMaterialSalesId= entity.UnitOfMaterialOfferId,//_units.Where(x => x.Kod == entity.Unit).Select(x => x.Id).FirstOrDefault(),
                    UnitCodeOfMaterialSales = entity.UnitCodeOfMaterialOffer,//_units.Where(x => x.Kod == entity.Unit).Select(x => x.Kod).FirstOrDefault(),
                    MaterialCode = entity.MaterialCode,
                    MaterialName = entity.MaterialName,
                    MaterialUnit = entity.MaterialUnit,
                    CompanyMaterialCod = entity.CompanyMaterialCod,//materialRelatedCompany?.CompanyMaterialCode,
                    CompanyMaterialName = entity.CompanyMaterialName,//materialRelatedCompany?.CompanyMaterialName,
                    CompanyMaterialUnit = entity.CompanyMaterialUnit,//materialRelatedCompany?.CompanyMaterialUnitName,
                    TaxRateId = entity.TaxRateId,//_defaultTaxRate.Id,
                    TaxCode = _defaultTaxRate.Kod,
                    TaxRateValue = _defaultTaxRate.KdvOrani,
                    CurrencyId = entity.CurrencyId,//defaultCurrencyId,
                    CurrencyCode = _currenies.Where(x => x.Id == defaultCurrencyId).FirstOrDefault().Kod,
                    DiscountRate=entity.DiscountRate,
                    NetAmount=entity.NetAmount,
                    DiscountAmount=entity.DiscountAmount,
                    TaxAmount=entity.TaxAmount,
                    TotalAmount=entity.TotalAmount,
                    SalesItemFile=entity.OfferItemFile,
                    DefaultUnitPrice = entity.DefaultUnitPrice,
                    UnitPrice=entity.DefaultUnitPrice,
                    StorageStockQty = entity.StorageStockQty,
                    MaxSalesQty =entity.MaxSalesQty,
                    MinSalesQty =entity.MinSalesQty,
                    DeliveryDate = entity.DeliveryDate,//((SalesEditForm)OwnerForm).txtDeliveryDate.DateTime,
                    DemandedDate = entity.DemandedDate,//((SalesEditForm)OwnerForm).txtDemandedDate.DateTime,
                    Insert = true,
                };
                if (((SalesEditForm)OwnerForm).txtDeliveryDate.EditValue != null)
                    row.DeliveryDate = (DateTime)((SalesEditForm)OwnerForm).txtDeliveryDate.EditValue;
                if (((SalesEditForm)OwnerForm).txtDemandedDate.EditValue != null)
                    row.DemandedDate = (DateTime)((SalesEditForm)OwnerForm).txtDemandedDate.EditValue;
                row.NetAmount = row.SalesQty * row.UnitPrice;
                row.DiscountAmount = row.NetAmount * row.DiscountRate / 100;
                row.DiscountedTotalAmount = row.NetAmount - row.DiscountAmount;
                row.TaxAmount = row.DiscountedTotalAmount * row.TaxRateValue;
                row.TotalAmount = row.NetAmount + row.TaxAmount;


                source.Add(row);
            }
            return source.Cast<SalesItemsL>().ToList();
        }

        private List<SalesItemsL> GetMaterial(IList source)
        {
            if (source == null) return null;

            var companyId = ((SalesEditForm)OwnerForm).txtCompanyName.Id;

            ListeDisiTutulacakKayitlar?.Clear();

            ListeDisiTutulacakKayitlar = source.Cast<SalesItemsL>().Where(x => !x.Delete).Select(x => x.MaterialId).ToList();

            var entities = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, true)?.EntityListConvert<MaterialL>().ToList();

            if (entities == null) return null;

            foreach (var entity in entities)
            {
                var _defaultUnitPrice = Convert.ToDecimal(GetAnySingleOrListBll.GetDefaultMaterialUnitPrice((long)companyId, entity.Id));
                var storageStockQty = Convert.ToDecimal(GetAnySingleOrListBll.SingleWarehouseStock(entity.Id, entity.DepoId)?.Quantity);
                var materialRelatedCompany = GetAnySingleOrListBll.GetMaterialRelatedCompany(x => x.CompanyId == (long)companyId && x.MaterialId == entity.Id);
                var defaultCurrencyId = (long)((SalesEditForm)OwnerForm).txtCurrency.EditValue;

                var row = new SalesItemsL
                {
                    SalesId = OwnerForm.Id,
                    CreatorId=AnaForm.KullaniciId,
                    CompanySalesId = (long)((SalesEditForm)OwnerForm).txtCompanyName.Id,
                    DeliveryCompanyId = ((SalesEditForm)OwnerForm).txtDeliveredCompany.Id,
                    MaterialId = entity.Id,
                    DepoId=entity.DepoId,
                    CurrencyId = defaultCurrencyId,
                    TaxRateId = _defaultTaxRate.Id,
                    UnitOfMaterialSalesId=(long)entity.UnitId, //_units.Where(x => x.Kod == entity.Unit).Select(x => x.Id).FirstOrDefault(),
                    UnitCodeOfMaterialSales = entity.UnitCode,//_units.Where(x => x.Kod == entity.Unit).Select(x => x.Kod).FirstOrDefault(),
                    MaterialCode = entity.StockCode,
                    MaterialName = entity.StockName,
                    MaterialUnit = entity.UnitCode,
                    CompanyMaterialCod = materialRelatedCompany?.CompanyMaterialCode,
                    CompanyMaterialName = materialRelatedCompany?.CompanyMaterialName,
                    CompanyMaterialUnit = materialRelatedCompany?.CompanyMaterialUnitName,
                    TaxCode = _defaultTaxRate.Kod,
                    TaxRateValue = _defaultTaxRate.KdvOrani,
                    CurrencyCode = _currenies.Where(x => x.Id == defaultCurrencyId).FirstOrDefault().Kod,
                    UnitPrice=_defaultUnitPrice,
                    DefaultUnitPrice = _defaultUnitPrice,
                    StorageStockQty = storageStockQty,
                    MaxSalesQty =materialRelatedCompany?.MaxOrderQty,//GetEntityOrListOfAnyTableFunction.GetCompanyRelatedMaterial((long)offeredCompanyId,entity.Id).MaxOrderQty,
                    MinSalesQty = materialRelatedCompany?.MinOrderQty,//GetEntityOrListOfAnyTableFunction.GetCompanyRelatedMaterial((long)offeredCompanyId,entity.Id).MinOrderQty,
                    //DeliveryDate = ((SalesEditForm)OwnerForm).txtDeliveryDate.DateTime,
                    //DemandedDate = ((SalesEditForm)OwnerForm).txtDemandedDate.DateTime,
                    Insert = true,
                };
                if (((SalesEditForm)OwnerForm).txtPriceList.EditValue != null)
                    row.PriceListId = (long)((SalesEditForm)OwnerForm).txtPriceList.EditValue;
                if (((SalesEditForm)OwnerForm).txtDeliveryDate.EditValue != null)
                    row.DeliveryDate = (DateTime)((SalesEditForm)OwnerForm).txtDeliveryDate.EditValue;
                if (((SalesEditForm)OwnerForm).txtDemandedDate.EditValue != null)
                    row.DemandedDate = (DateTime)((SalesEditForm)OwnerForm).txtDemandedDate.EditValue;

                row.NetAmount = row.SalesQty * row.UnitPrice;
                row.DiscountAmount = row.NetAmount * row.DiscountRate / 100;
                row.DiscountedTotalAmount = row.NetAmount - row.DiscountAmount;
                row.TaxAmount = row.DiscountedTotalAmount * row.TaxRateValue;
                row.TotalAmount = row.NetAmount + row.TaxAmount;

                source.Add(row);
            }
            return source.Cast<SalesItemsL>().ToList();
        }
    }
}

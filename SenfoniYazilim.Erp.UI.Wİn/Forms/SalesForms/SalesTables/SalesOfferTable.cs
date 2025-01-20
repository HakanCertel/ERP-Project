using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General.SalesBll;
using SenfoniYazilim.Erp.Common.Enums;
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
using System.Collections.Generic;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SaleWayBillForms.SalesTables
{
    public partial class SalesOfferTable : BaseTablo
    {
        public PurchaseOrderCreatingMethod _offerMethod;
        private DovizBilgileri _defaultCurrency;
        private Kdv _defaultTaxRate;
        private Birim _defaultUnit;
        private List<DovizBilgileri> _currenies;
        private List<Kdv> _taxRates;
        private List<Birim> _units;

        public SalesOfferTable()
        {
            InitializeComponent();
            Bll = new SalesOfferItemsBll();
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

            repositoryItemLookUpTax.DataSource = _taxRates;
            repositoryItemLookUpTax.ValueMember = "Id";
            repositoryItemLookUpTax.DisplayMember = "Kod";

            repositoryItemComboCurrency.Items.AddRange(_currenies.Select(x => x.Kod).ToList());
            repositoryItemComboTax.Items.AddRange(_taxRates.Select(x => x.Kod).ToList());
            repositoryItemComboUnit.Items.AddRange(_units.Select(x => x.Kod).ToList());
        }

        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((SalesOfferItemsBll)Bll).List(x => x.SalesOfferId == OwnerForm.Id).toBindingList<SalesOfferItemsL>();
        }

        protected override void HareketEkle()
        {

            if (((SalesOfferEditForm)OwnerForm).txtCompanyName.Id == 0)
            {
                Messages.BilgiMesaji("Lütfen Firma Bilgisi Seçiniz!");
                ((SalesOfferEditForm)OwnerForm).txtCompanyName.Focus();
                return;
            }
            var source = Tablo.DataController.ListSource;

            if (source == null) return ;

            var offeredCompanyId = ((SalesOfferEditForm)OwnerForm).txtCompanyName.Id;

            ListeDisiTutulacakKayitlar?.Clear();

            ListeDisiTutulacakKayitlar = source.Cast<SalesOfferItemsL>().Where(x => !x.Delete).Select(x => x.MaterialId).ToList();

            var entities = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, true)?.EntityListConvert<MaterialL>().ToList();

            if (entities == null) return ;

            foreach (var entity in entities)
            {
                var _defaultUnitPrice = Convert.ToDecimal(GetAnySingleOrListBll.GetDefaultMaterialUnitPrice((long)offeredCompanyId, entity.Id));
                var storageStockQty = Convert.ToDecimal(GetAnySingleOrListBll.SingleWarehouseStock(entity.Id, entity.DepoId)?.Quantity);
                var materialRelatedCompany = GetAnySingleOrListBll.GetMaterialRelatedCompany(x => x.CompanyId == (long)offeredCompanyId && x.MaterialId == entity.Id);
                var defaultCurrencyId = (long)((SalesOfferEditForm)OwnerForm).txtCurrency.EditValue;
                var row = new SalesOfferItemsL
                {
                    SalesOfferId = OwnerForm.Id,
                    CreatorId=AnaForm.KullaniciId,
                    CompanyOfferedId = (long)((SalesOfferEditForm)OwnerForm).txtCompanyName.Id,
                    DeliveryCompanyId= ((SalesOfferEditForm)OwnerForm).txtDeliveredCompany.Id,
                    MaterialId = entity.Id,
                    CurrencyId = defaultCurrencyId,
                    TaxRateId = _defaultTaxRate.Id,
                    UnitOfMaterialOfferId= (long)entity.UnitId,//_units.Where(x => x.Kod == entity.Unit).Select(x => x.Id).FirstOrDefault(),
                    UnitCodeOfMaterialOffer = entity.UnitCode,//_units.Where(x => x.Kod == entity.Unit).Select(x => x.Kod).FirstOrDefault(),
                    MaterialCode = entity.StockCode,
                    MaterialName = entity.StockName,
                    MaterialUnit = entity.UnitCode,
                    DepoId=entity.DepoId,
                    CompanyMaterialCod = materialRelatedCompany?.CompanyMaterialCode,
                    CompanyMaterialName = materialRelatedCompany?.CompanyMaterialName,
                    CompanyMaterialUnit = materialRelatedCompany?.CompanyMaterialUnitName,
                    TaxCode = _defaultTaxRate.Kod,
                    TaxRateValue = _defaultTaxRate.KdvOrani,
                    CurrencyCode = _currenies.Where(x=>x.Id==defaultCurrencyId).FirstOrDefault().Kod,
                    //CurrencyName = _defaultCurrency.DovizAdi,
                    DefaultUnitPrice = _defaultUnitPrice,
                    StorageStockQty = storageStockQty,
                    MaxSalesQty = materialRelatedCompany?.MaxOrderQty,//GetEntityOrListOfAnyTableFunction.GetCompanyRelatedMaterial((long)offeredCompanyId,entity.Id)?.MaxOrderQty,
                    MinSalesQty = materialRelatedCompany?.MinOrderQty,//GetEntityOrListOfAnyTableFunction.GetCompanyRelatedMaterial((long)offeredCompanyId,entity.Id)?.MinOrderQty,
                    //DeliveryDate=DateTime.Now,//((SalesOfferEditForm)OwnerForm).txtDeliveryDate.DateTime,
                    //DemandedDate=DateTime.Now,//((SalesOfferEditForm)OwnerForm).txtDemandedDate.DateTime,
                    Insert = true,
                };
                if (((SalesOfferEditForm)OwnerForm).txtPriceList.EditValue != null)
                    row.PriceListId =(long)((SalesOfferEditForm)OwnerForm).txtPriceList.EditValue;
                if (((SalesOfferEditForm)OwnerForm).txtDeliveryDate.EditValue != null)
                    row.DeliveryDate = (DateTime)((SalesOfferEditForm)OwnerForm).txtDeliveryDate.EditValue;
                if (((SalesOfferEditForm)OwnerForm).txtDemandedDate.EditValue != null)
                    row.DemandedDate = (DateTime)((SalesOfferEditForm)OwnerForm).txtDemandedDate.EditValue;
                source.Add(row);
            }

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
                var entitiy = tablo.GetRow<SalesOfferItemsL>(i);

                if (entitiy.SalesOfferQty == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colSalesOfferQty;
                    tablo.SetColumnError(colSalesOfferQty, "Miktar Alanına Geçerli Bir Değer Giriniz .");
                }
                if (entitiy.UnitOfMaterialOfferId == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colUnitCodeOfMaterialOffer;
                    tablo.SetColumnError(colUnitCodeOfMaterialOffer, "Birim Alanına Geçerli Bir Değer Giriniz .");
                }
                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected internal void TopluHareketSil()
        {
            var source = tablo.DataController.ListSource.Cast<SalesOfferItemsL>();

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
            var selectedRow = Tablo.GetRow<SalesOfferItemsL>();
            if (selectedRow == null) return;
            if (e.Column == colSalesOfferQty)
            {
                selectedRow.NetAmount = selectedRow.SalesOfferQty * selectedRow.UnitPrice;
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
                selectedRow.NetAmount = selectedRow.SalesOfferQty * selectedRow.UnitPrice;
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

        protected override void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);

            var selectedRow = Tablo.GetRow<SalesOfferItemsL>(false);
            if (selectedRow == null) return;
            if (Tablo.FocusedColumn == colUnitCodeOfMaterialOffer)
            {
                var newValue = ((ComboBoxEdit)sender).EditValue.ToString();

                var unit = _units.Where(x => x.Kod == newValue)?.FirstOrDefault();//.KdvOrani;
                if (unit == null) return;
                selectedRow.UnitOfMaterialOfferId = unit.Id;
            }
            ButtonEnabledDurum(true);
            base.ComboBox_SelectedValueChanged(sender, e);
        }

    }
}

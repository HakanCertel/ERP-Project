using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using DevExpress.XtraGrid.Views.Base;
using SenfoniYazilim.Erp.Common.Message;
using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.Common.Enums;
using System.Collections.Generic;
using SenfoniYazilim.Erp.Common.Functions;
using System.Collections;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.PurchaseDemandForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaTeklifForms;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.SatinalmaTeklifForms.PurchaseOfferTable
{
    public partial class PurchaseOfferEditFormTable : BaseTablo
    {
        #region Variants
            protected internal PurchaseOfferCreatingMethod _offerMethod;
            private  DovizBilgileri _defaultCurrency;
            private  Kdv _defaultTaxRate;
            private Birim _defaultUnit;
            private  List<DovizBilgileri> _currenies;
            private  List<Kdv> _taxRates;
            private  List<Birim> _units;
        #endregion

        public PurchaseOfferEditFormTable()
        {
            InitializeComponent();

            Bll = new PurchaseOfferItemsBll();
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

            repositoryItemComboBoxDoviz.Items.AddRange(_currenies.Select(x => x.Kod).ToList());
            repositoryItemComboBoxKdv.Items.AddRange(_taxRates.Select(x => x.Kod).ToList());
            repositoryItemComboUnitOfOffer.Items.AddRange(_units.Select(x => x.Kod).ToList());

            if (_offerMethod == PurchaseOfferCreatingMethod.ChoosePurchaseDemandItem)
                GetDemandItems(Tablo.DataController.ListSource);
        }

        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((PurchaseOfferItemsBll)Bll).List(x => x.OfferId == OwnerForm.Id&&!x.IsOfferClosed).toBindingList<PurchaseOfferItemL>();
        }

        protected override void HareketEkle()
        {
            _offerMethod = ((PurchaseOfferEditForm)OwnerForm).txtOfferCreatingMethod.Text.GetEnum<PurchaseOfferCreatingMethod>();

            if (((PurchaseOfferEditForm)OwnerForm).txtOfferedCompanyName.Id == null&& !((PurchaseOfferEditForm)OwnerForm).tglIsMultipleCompany.IsOn)
            {
                Messages.BilgiMesaji("Lütfen Firma Bilgisi Seçiniz!");
                ((PurchaseOfferEditForm)OwnerForm).txtOfferedCompanyName.Focus();
                return;
            }
           
            var source = Tablo.DataController.ListSource;

            var entities = _offerMethod == PurchaseOfferCreatingMethod.ChooseMaterial ? GetMaterial(source)
                        : _offerMethod == PurchaseOfferCreatingMethod.ChoosePurchaseDemandItem ? GetDemandItems(source) : null;
            
            if (entities == null) return;
            
            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colMaterialCode;

            ButtonEnabledDurum(true);
        }

        protected internal override void AddExternalRow()
        {
            ((PurchaseOfferEditForm)OwnerForm).tglIsMultipleCompany.IsOn = true;
            //if (((PurchaseOfferEditForm)OwnerForm).txtOfferedCompanyName.Id == null && !((PurchaseOfferEditForm)OwnerForm).tglIsMultipleCompany.IsOn)
            //{
            //    Messages.BilgiMesaji("Lütfen Firma Bilgisi Seçiniz!");
            //    ((PurchaseOfferEditForm)OwnerForm).txtOfferedCompanyName.Focus();
            //    return;
            //}
            var source = Tablo.DataController.ListSource;
            var entities =  GetDemandItems(source);

            if (entities == null) return;

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
                var entitiy = tablo.GetRow<PurchaseOfferItemL>(i);

                if (entitiy.MaterialCode == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colMaterialCode;
                    tablo.SetColumnError(colMaterialCode, "Stok Kodu Alanına Geçerli Bir Değer Giriniz .");
                }
                if (entitiy.OfferedCompanyName == "")
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colOfferedCompanyName;
                    tablo.SetColumnError(colOfferedCompanyName, "Teklif Alınan Firma Alanına Geçerli Bir Değer Giriniz .");

                }
                if (entitiy.OfferQty == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colOfferQty;
                    tablo.SetColumnError(colOfferQty, "Miktar Alanına Geçerli Bir Değer Giriniz .");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected internal void TopluHareketSil()
        {
            var source = tablo.DataController.ListSource.Cast<PurchaseOfferItemL>();

            if (source == null) return;

            source.ForEach(x =>
            {
                x.Delete = true;
            });

            //tablo.RefreshDataSource();

            ButtonEnabledDurum(true);
        }

        protected override void CopyValueToDownCells()
        {
            var source = Tablo.DataController.ListSource.Cast<PurchaseOfferItemL>().ToList();
            if (source == null) return;
            var entity = Tablo.GetRow<PurchaseOfferItemL>(false);
            if (entity == null) return;
            for (int i = Tablo.FocusedRowHandle+1; i < source.Count; i++)
            {
                source[i].OfferQty = entity.OfferQty;
                Tablo.RefreshRow(i);
            }
        }

        protected internal override void SutunGizleGoster()
        {
            if (((PurchaseOfferEditForm)OwnerForm).tglIsMultipleCompany.IsOn == true)
            {
                colOfferedCompanyName.Visible = true;
                colOfferedCompanyName.VisibleIndex = 0;
                colOfferedComapanyId.Visible = true;
                colOfferedComapanyId.VisibleIndex = 1;
            }
            else if (((PurchaseOfferEditForm)OwnerForm).tglIsMultipleCompany.IsOn == false)
            {
                colOfferedCompanyName.Visible = false;
            }
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var selectedRow = Tablo.GetRow<PurchaseOfferItemL>();
            if (selectedRow == null) return;
            if (e.Column == colOfferQty)
            {
                selectedRow.NetAmount = selectedRow.OfferQty * selectedRow.UnitPrice;
                selectedRow.TaxAmount = selectedRow.NetAmount * selectedRow.TaxRateValue;
                selectedRow.TotalAmount = selectedRow.NetAmount+selectedRow.TaxAmount;
            }
            else if (e.Column == colDiscountRate)
            {
                selectedRow.DiscountAmount = selectedRow.NetAmount * selectedRow.DiscountRate / 100;
                selectedRow.DiscountedTotalAmount = selectedRow.NetAmount - selectedRow.DiscountAmount;
                selectedRow.TaxAmount = selectedRow.DiscountedTotalAmount * selectedRow.TaxRateValue;
                selectedRow.TotalAmount = selectedRow.NetAmount + selectedRow.TaxAmount;
            }
            else if (e.Column == colUnitPrice)
            {
                selectedRow.NetAmount = selectedRow.OfferQty * selectedRow.UnitPrice;
                selectedRow.DiscountAmount = selectedRow.NetAmount * selectedRow.DiscountRate/100;
                selectedRow.DiscountedTotalAmount = selectedRow.NetAmount - selectedRow.DiscountAmount;
                selectedRow.TaxAmount = selectedRow.DiscountedTotalAmount * selectedRow.TaxRateValue;
                selectedRow.TotalAmount = selectedRow.NetAmount + selectedRow.TaxAmount;
            }
            if (e.Column == colTaxRateId)
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
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);

            var selectedRow = Tablo.GetRow<PurchaseOfferItemL>(false);
            if (selectedRow == null) return;
            
            if (Tablo.FocusedColumn == colUnitCodeOfOffer)
            {
                var newValue = ((ComboBoxEdit)sender).EditValue.ToString();

                var unit = _units.Where(x => x.Kod == newValue)?.FirstOrDefault();//.KdvOrani;
                if (unit == null) return;
                selectedRow.UnitOfMaterialOfferedId = unit.Id;
            }
            base.ComboBox_SelectedValueChanged(sender, e);
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            //if (e.FocusedColumn == colMaterialCode)
            //    e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemButtonSatinalmaTalepStok, colMaterialId);
            if (e.FocusedColumn == colOfferedCompanyName)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemButtonFirma, colOfferedComapanyId);
        }

        private List<PurchaseOfferItemL> GetMaterial(IList source)
        {
            if (source == null) return null;

            ListeDisiTutulacakKayitlar?.Clear();

            var offeredCompanyId = ((PurchaseOfferEditForm)OwnerForm).txtOfferedCompanyName.Id;

            ListeDisiTutulacakKayitlar = source.Cast<PurchaseOfferItemL>().Where(x => !x.Delete).Select(x => x.MaterialId).ToList();

            var offerItems = new List<PurchaseOfferItemL>();

            var entities = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, true)?.EntityListConvert<MaterialL>().ToList();

            if (entities == null) return null;

            foreach (var entity in entities)
            {
                var storageStockQty = GetAnySingleOrListBll.SingleWarehouseStock(entity.Id, entity.DepoId)?.Quantity;

                var row = new PurchaseOfferItemL
                {
                    OfferId = OwnerForm.Id,
                    //PurchaseDemandId = entity.PurchaseDemandId,
                    MaterialId = entity.Id,
                    CurrencyId = _defaultCurrency.Id,
                    TaxRateId = _defaultTaxRate.Id,
                    OfferedCompanyId=Convert.ToInt64( offeredCompanyId),
                    UnitOfMaterialOfferedId=_units.Where(x=>x.Kod==entity.UnitCode).Select(x=>x.Id).FirstOrDefault(),
                    UnitCodeOfOffer= _units.Where(x=>x.Kod==entity.UnitCode).Select(x=>x.Kod).FirstOrDefault(),
                    //OfferItemDescription = ((PurchaseOfferEditForm)OwnerForm).txtPurchaseOfferedDescription.Text,
                    //PurchaseDemandItemId = entity.PurchaseDemandItemId,
                    //PurchaseOrderId = entity.PurchaseOrderId,
                    //PurchaseOrderItemId = entity.PurchaseOrderItemId,
                    //OfferQty = entity.OfferQty,
                    //UnitPrice = entity.UnitPrice,
                    //DiscountRate = entity.DiscountRate,
                    //DeliveryDate = entity.DeliveryDate,
                    ValidityStartDate = ((PurchaseOfferEditForm)OwnerForm).txtValidityStartDate.DateTime,
                    ValidityEndDate = ((PurchaseOfferEditForm)OwnerForm).txtValidityEndDate.DateTime,
                    //IsOfferComfirmed = entity.IsOfferComfirmed,
                    //IsOfferCancel = entity.IsOfferCancel,
                    //IsOfferActive = entity.IsOfferActive,
                    //IsOfferClosed = entity.IsOfferClosed,
                    //IsOffferLocked = entity.IsOffferLocked,
                    PurchaseOfferCreatingMethod = ((PurchaseOfferEditForm)OwnerForm).txtOfferCreatingMethod.Text.GetEnum<PurchaseOfferCreatingMethod>(),
                    //DemandedCompanyId = entity.DemandedCompanyId,
                    //ConnectedItemsId = entity.ConnectedItemsId,
                    //DemandQty = entity.DemandQty,--> bu sütun teklif olauşturma yöntemine bağlı olarak gizlenip gösterilecek
                    //ComfirmedQty = entity.ComfirmedQty,--> yukarıdaki ile aynı
                    //DemandedDate = entity.DemandedDate,-->yukarıdaki ile aynı
                    MaterialCode = entity.StockCode,
                    MaterialName = entity.StockName,
                    MaterialUnit = entity.UnitCode,
                    TaxCode = _defaultTaxRate.Kod,
                    TaxRateValue = _defaultTaxRate.KdvOrani,
                    CurrencyCode = _defaultCurrency.Kod,
                    CurrencyName = _defaultCurrency.DovizAdi,
                    OfferedCompanyName = ((PurchaseOfferEditForm)OwnerForm).txtOfferedCompanyName.Text,
                    //PurchaseDemanItemDescription = entity.PurchaseDemanItemDescription,
                    //NetAmount = entity.NetAmount,
                    //NetAmountBasedLocalCurrency = entity.NetAmountBasedLocalCurrency,
                    //TotalAmount = entity.TotalAmount,
                    //TaxAmount = entity.TaxAmount,
                    //TaxAmountBasedLocalCurrency = entity.TaxAmountBasedLocalCurrency,
                    //---->DiscountAmount = entity.DiscountAmount,
                    StorageStockQty=storageStockQty,
                    //------>MaxPurchaseOrderQty = entity.MaxPurchaseOrderQty,
                    //------->MinPurchaseOrderQty = entity.MinPurchaseOrderQty,
                    MaxStockQty = entity.MaxStockQty,
                    MinStockQty = entity.MinStockQty,
                    //RemainingOrderQty = entity.RemainingOrderQty,
                    //IsTopDemand = entity.IsTopDemand,
                    Insert = true,
                };
                source.Add(row);
            }
            return source.Cast<PurchaseOfferItemL>().ToList();
        }

        private List<PurchaseOfferItemL> GetDemandItems(IList source)
        {
            if (source == null) return null;
            var offerItems = new List<PurchaseOfferItemL>();
            var entities = new List<PurchaseDemandItemsListFormL>();
            var offeredCompanyId = Convert.ToInt64(((PurchaseOfferEditForm)OwnerForm).txtOfferedCompanyName.Id);

            ListeDisiTutulacakKayitlar?.Clear();

            ListeDisiTutulacakKayitlar = source.Cast<PurchaseOfferItemL>().Where(x => !x.Delete).Select(x => (long)x.Id).ToList();

            if (((PurchaseOfferEditForm)OwnerForm).SelectedEntities == null)
                entities = ShowListForms<PurchaseDemanItemsListForm>.ShowDialogHareketListForm(ListeDisiTutulacakKayitlar, true,true,true).EntityListConvert<PurchaseDemandItemsListFormL>()?.ToList();
            else
               entities = ((PurchaseOfferEditForm)OwnerForm).SelectedEntities.Cast<PurchaseDemandItemsListFormL>().ToList();

            if (entities == null) return null;

            foreach (var entity in entities)
            {
                var row = new PurchaseOfferItemL
                {
                    OfferId = OwnerForm.Id,
                    OfferedCompanyId = offeredCompanyId,
                    OfferedCompanyName = ((PurchaseOfferEditForm)OwnerForm).txtOfferedCompanyName.Text,
                    ValidityStartDate = ((PurchaseOfferEditForm)OwnerForm).txtValidityStartDate.DateTime,
                    ValidityEndDate = ((PurchaseOfferEditForm)OwnerForm).txtValidityEndDate.DateTime,
                    OfferQty = entity.ComfirmedQty,
                    UnitOfMaterialOfferedId = _units.Where(x => x.Kod == entity.MaterialUnit).Select(x => x.Id).FirstOrDefault(),
                    PurchaseOfferCreatingMethod = ((PurchaseOfferEditForm)OwnerForm).txtOfferCreatingMethod.Text.GetEnum<PurchaseOfferCreatingMethod>(),
                    UnitPrice = 0,
                    DiscountRate = 0,
                    PurchaseDemandId = entity.OwnerFormId,
                    PurchaseDemandItemId = entity.Id,
                    DemandedCompanyId = entity.DemandedCompanyId,
                    ConnectedItemsId = entity.ConnectedItemsId,
                    DemandQty = entity.DemandQty,
                    ComfirmedQty = entity.ComfirmedQty,
                    DemandedDate = entity.DemandedDate,
                    PurchaseMainDescription = entity.DemandDescription,
                    PurchaseDemanItemDescription = entity.DemandItemDescription,
                    DemandFile = entity.DemandFile,
                    IsTopDemand = entity.IsTopDemand,
                    MaxStockQty = entity.MaxStockQty,
                    MinStockQty = entity.MinStockQty,
                    MaxPurchaseOrderQty = entity.MaxPurchaseOrderQty,
                    MinPurchaseOrderQty = entity.MinPurchaseOrderQty,
                    StorageStockQty = entity.StorageStockQty,
                    CompanyPriceListCost = Convert.ToDecimal(GetAnySingleOrListBll.GetDefaultMaterialUnitPrice(offeredCompanyId, entity.MaterialId)),
                    //DeliveryDate = 0,
                    MaterialId = entity.MaterialId,
                    MaterialCode = entity.MaterialCode,
                    MaterialName = entity.MaterialName,
                    MaterialUnit = entity.MaterialUnit,
                    TaxRateId = _defaultTaxRate.Id,
                    TaxCode = _defaultTaxRate.Kod,
                    TaxRateValue = _defaultTaxRate.KdvOrani,
                    CurrencyId = _defaultCurrency.Id,
                    CurrencyCode = _defaultCurrency.Kod,
                    CurrencyName = _defaultCurrency.DovizAdi,
                    Insert = true,
                };

                source.Add(row);
            }
            return source.Cast<PurchaseOfferItemL>().ToList();
        }

    }
}

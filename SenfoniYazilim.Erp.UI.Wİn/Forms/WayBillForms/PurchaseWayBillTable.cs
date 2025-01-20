using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General.WayBillBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Dto.WayBillDto;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.SatinalmaSiparisForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WayBillForms
{
    public partial class PurchaseWayBillTable : BaseTablo
    {
        public WayBillCreatingMethod _offerMethod;
        private DovizBilgileri _defaultCurrency;
        private Kdv _defaultTaxRate;
        private Birim _defaultUnit;
        private List<DovizBilgileri> _currenies;
        private List<Kdv> _taxRates;
        private List<Birim> _units;

        public PurchaseWayBillTable()
        {
            InitializeComponent();
            Bll = new PurchaseWayBillItemsBll();
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

            repositoryItemLookUpUnit.DataSource = _units;
            repositoryItemLookUpUnit.ValueMember = "Id";
            repositoryItemLookUpUnit.DisplayMember = "BirimAdi";

            repositoryItemComboCurrency.Items.AddRange(_currenies.Select(x => x.Kod).ToList());
            repositoryItemComboTax.Items.AddRange(_taxRates.Select(x => x.Kod).ToList());
            //repositoryItemComboUnit.Items.AddRange(_units.Select(x => x.Kod).ToList());
        }

        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((PurchaseWayBillItemsBll)Bll).List(x => x.WayBillId == OwnerForm.Id).toBindingList<PurchaseWayBillItemsL>();
        }

        protected override void HareketEkle()
        {
            _offerMethod = ((PurchaseWayBillEditForm)OwnerForm).txtWayBillCreatingMethod.Text.GetEnum<WayBillCreatingMethod>();

            if (((PurchaseWayBillEditForm)OwnerForm).txtCompanyName.Id == null)
            {
                Messages.BilgiMesaji("Lütfen Firma Bilgisi Seçiniz!");
                ((PurchaseWayBillEditForm)OwnerForm).txtCompanyName.Focus();
                return;
            }
            var source = Tablo.DataController.ListSource;

            var entities = _offerMethod == WayBillCreatingMethod.ChooseMaterial ? GetMaterial(source)
                        : _offerMethod == WayBillCreatingMethod.ChooseOrderItem ? GetOrderItems(source) : null; 

            if (entities == null) return;

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colMaterialCode;

            //((PurchaseOrderEditForm)OwnerForm).txtCompanyName.Enabled = false;

            ButtonEnabledDurum(true);
        }

        private List<PurchaseWayBillItemsL> GetMaterial(IList source)
        {
            if (source == null) return null;
            var orderedCompanyId = ((PurchaseWayBillEditForm)OwnerForm).txtCompanyName.Id;

            ListeDisiTutulacakKayitlar?.Clear();

            ListeDisiTutulacakKayitlar = source.Cast<PurchaseWayBillItemsL>().Where(x => !x.Delete).Select(x => x.MaterialId).ToList();

            var entities = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, true)?.EntityListConvert<MaterialL>().ToList();

            if (entities == null) return null;

            foreach (var entity in entities)
            {
                var _defaultUnitPrice = Convert.ToDecimal(GetAnySingleOrListBll.GetDefaultMaterialUnitPrice((long)orderedCompanyId, entity.Id));
                var storageStockQty = Convert.ToDecimal(GetAnySingleOrListBll.SingleWarehouseStock(entity.Id, entity.DepoId)?.Quantity);
                var materialRelatedCompany=GetAnySingleOrListBll.GetMaterialRelatedCompany(x => x.CompanyId == (long)orderedCompanyId && x.MaterialId == entity.Id);

                var row = new PurchaseWayBillItemsL
                {
                    WayBillId=OwnerForm.Id,
                    CompanyId = (long)((PurchaseWayBillEditForm)OwnerForm).txtCompanyName.Id,
                    MaterialId = entity.Id,
                    CurrencyId = _defaultCurrency.Id,
                    TaxRateId = _defaultTaxRate.Id,
                    MaterialUnitOfProccessId = _units.Where(x => x.Kod == entity.UnitCode).Select(x => x.Id).FirstOrDefault(),
                    UnitCodeOfProccess = _units.Where(x => x.Kod == entity.UnitCode).Select(x => x.Kod).FirstOrDefault(),
                    WayBillCreatingMethod = ((PurchaseWayBillEditForm)OwnerForm).txtWayBillCreatingMethod.Text.GetEnum<WayBillCreatingMethod>(),
                    MaterialCode = entity.StockCode,
                    MaterialName = entity.StockName,
                    MaterialUnit = entity.UnitCode,
                    CompanyMaterialCod=materialRelatedCompany?.CompanyMaterialCode,
                    CompanyMaterialName=materialRelatedCompany?.CompanyMaterialName,
                    CompanyMaterialUnit=materialRelatedCompany?.CompanyMaterialUnitName,
                    TaxCode = _defaultTaxRate.Kod,
                    TaxRateValue = _defaultTaxRate.KdvOrani,
                    CurrencyCode = _defaultCurrency.Kod,
                    CurrencyName = _defaultCurrency.DovizAdi,
                    DefaultUnitPrice = _defaultUnitPrice,
                    Insert = true,
                };
                source.Add(row);
            }
            return source.Cast<PurchaseWayBillItemsL>().ToList();
        }

        private List<PurchaseWayBillItemsL> GetOrderItems(IList source)
        {
            if (source == null) return null;
            var orderedCompanyId =Convert.ToInt64( ((PurchaseWayBillEditForm)OwnerForm).txtCompanyName.Id);

            ListeDisiTutulacakKayitlar?.Clear();

            ListeDisiTutulacakKayitlar=source.Cast<PurchaseWayBillItemsL>().Where(x => !x.Delete).Select(x => (long)x.Id).ToList();

            var entities= ShowListForms<PurchaseOrderItemsListForm>.ShowDialogHareketListForm(ListeDisiTutulacakKayitlar,true,true)?.EntityListConvert<PurchaseOrderItemsL>()?.ToList();

            if (entities == null) return null;

            foreach (var entity in entities)
            {
                var _defaultUnitPrice = Convert.ToDecimal(GetAnySingleOrListBll.GetDefaultMaterialUnitPrice((long)orderedCompanyId, entity.Id));
                var storageStockQty = Convert.ToDecimal(GetAnySingleOrListBll.SingleWarehouseStock(entity.Id, entity.DepoId)?.Quantity);
                var materialRelatedCompany = GetAnySingleOrListBll.GetMaterialRelatedCompany(x=>x.CompanyId==(long)orderedCompanyId&&x.MaterialId== entity.MaterialId);

                var row = new PurchaseWayBillItemsL
                {
                    WayBillId=OwnerForm.Id,
                    CompanyId = (long)((PurchaseWayBillEditForm)OwnerForm).txtCompanyName.Id,
                    PurchaseOrderItemId=entity.Id,
                    PurchaseDemandItemId=entity.PurchaseDemandItemId,
                    MaterialId = entity.MaterialId,
                    CurrencyId = _defaultCurrency.Id,
                    TaxRateId = _defaultTaxRate.Id,
                    MaterialUnitOfProccessId = _units.Where(x => x.Kod == entity.MaterialUnit).Select(x => x.Id).FirstOrDefault(),
                    UnitCodeOfProccess = _units.Where(x => x.Kod == entity.MaterialUnit).Select(x => x.Kod).FirstOrDefault(),
                    WayBillCreatingMethod = ((PurchaseWayBillEditForm)OwnerForm).txtWayBillCreatingMethod.Text.GetEnum<WayBillCreatingMethod>(),
                    Quantity=(decimal)entity.PurchaseOrderQty,
                    DemandedDate=entity.DemandedDate,
                    MaterialCode = entity.MaterialCode,
                    MaterialName = entity.MaterialName,
                    MaterialUnit = entity.MaterialUnit,
                    CompanyMaterialCod = materialRelatedCompany?.CompanyMaterialCode,
                    CompanyMaterialName = materialRelatedCompany?.CompanyMaterialName,
                    CompanyMaterialUnit = materialRelatedCompany?.CompanyMaterialUnitName,
                    TaxCode = _defaultTaxRate.Kod,
                    TaxRateValue = _defaultTaxRate.KdvOrani,
                    CurrencyCode = _defaultCurrency.Kod,
                    CurrencyName = _defaultCurrency.DovizAdi,
                    DefaultUnitPrice = _defaultUnitPrice,
                    Insert = true,
                };
                source.Add(row);
            }
            return source.Cast<PurchaseWayBillItemsL>().ToList();
        }

        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<PurchaseWayBillItemsL>(i);

                if (entitiy.Quantity == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colQuantity;
                    tablo.SetColumnError(colQuantity, "Miktar Alanına Geçerli Bir Değer Giriniz .");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected internal void TopluHareketSil()
        {
            var source = tablo.DataController.ListSource.Cast<PurchaseWayBillItemsL>();

            if (source == null) return;

            source.ForEach(x =>
            {
                x.Delete = true;
            });

            //tablo.RefreshDataSource();

            ButtonEnabledDurum(true);
        }
        protected internal override IList<BaseHareketEntity> TranferItem()
        {
            //return base.TranferItem();
            var source = Tablo.DataController.ListSource.Cast<PurchaseWayBillItemsL>().ToList();
            if (source.Count == 0) return null;
            var transferedItems = new List<WareHouseStockL>();

            source.ForEach(x =>
            {
                var warehouseItem = new WareHouseStockL
                {
                    MaterialId = x.MaterialId,
                    WareHouseId = (long)((PurchaseWayBillEditForm)OwnerForm).txtWarehouse.Id,
                    UnitId=x.MaterialUnitOfProccessId,
                    Quantity = x.Quantity,
                };

                transferedItems.Add(warehouseItem);
            });

            return transferedItems.Cast<BaseHareketEntity>().ToList();
        }
        protected internal override bool InsertStockMoving()
        {
            var source = Tablo.DataController.ListSource.Cast<PurchaseWayBillItemsL>().ToList();
            if (source.Count == 0) return false;
            var hareketList = new List<BaseHareketEntity>();
            source.ForEach(x =>
            {
                var stokHareketi = new StokHareketleri
                {
                    Id = 0,
                    StokId = x.MaterialId,
                    UnitId=x.MaterialUnitOfProccessId,
                    DepoId = (long)((PurchaseWayBillEditForm)OwnerForm).txtWarehouse.Id,
                    FormId = OwnerForm.Id,
                    FormCode = ((PurchaseWayBillEditForm)OwnerForm).txtKod.Text,
                    FormItemId = x.Id,
                    HareketTuru = HareketTuru.Giris,
                    HareketCinsi = "Satınalma İrsaliyesi",
                    IslemMiktari = x.Quantity,
                    HareketTarihi = DateTime.Now,
                };
                hareketList.Add(stokHareketi);
            });

            return GetAnySingleOrListBll.InsertStokHareketleri(hareketList);
        }
        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var selectedRow = Tablo.GetRow<PurchaseWayBillItemsL>();
            if (selectedRow == null) return;
            if (e.Column == colQuantity)
            {
                selectedRow.NetAmount = selectedRow.Quantity * selectedRow.UnitPrice;
                selectedRow.TaxAmount = selectedRow.NetAmount * selectedRow.TaxRateValue;
                selectedRow.TotalAmount = selectedRow.NetAmount + selectedRow.TaxAmount;
            }
            else if (e.Column == colDiscountRate)
            {
                selectedRow.DiscountAmount = selectedRow.NetAmount * selectedRow.DiscountRate;
                selectedRow.DiscountedTotalAmount = selectedRow.NetAmount - selectedRow.DiscountAmount;
                selectedRow.TaxAmount = selectedRow.DiscountedTotalAmount * selectedRow.TaxRateValue;
                selectedRow.TotalAmount = selectedRow.NetAmount + selectedRow.TaxAmount;
            }
            else if (e.Column == colUnitPrice)
            {
                selectedRow.NetAmount = selectedRow.Quantity * selectedRow.UnitPrice;
                selectedRow.DiscountAmount = selectedRow.NetAmount * selectedRow.DiscountRate;
                selectedRow.DiscountedTotalAmount = selectedRow.NetAmount - selectedRow.DiscountAmount;
                selectedRow.TaxAmount = selectedRow.DiscountedTotalAmount * selectedRow.TaxRateValue;
                selectedRow.TotalAmount = selectedRow.NetAmount + selectedRow.TaxAmount;
            }
            //else if (e.Column == colTaxCode)
            //{
            //    var taxRate = _taxRates.Where(x => x.Kod == selectedRow.TaxCode)?.FirstOrDefault().KdvOrani;
            //    if (taxRate == null) return;
            //    selectedRow.TaxAmount = selectedRow.DiscountedTotalAmount * (decimal)taxRate;
            //    selectedRow.TotalAmount = selectedRow.NetAmount + selectedRow.TaxAmount;
            //}

            base.Tablo_CellValueChanged(sender, e);
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }

        //protected override void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);

        //    var selectedRow = Tablo.GetRow<PurchaseWayBillItemsL>(false);
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

using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.General.SalesBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto.Company;
using SenfoniYazilim.Erp.Model.Dto.SalesDto;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.Model.Entities.Company;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SaleWayBillForms
{
    public partial class SalesOfferEditForm : BaseEditForm
    {
        private readonly IEnumerable<EvrakTurleriL> _documentTypeItems;
        private readonly List<PaymentMethodItemsL> _paymentMethodItems;
        private readonly List<DovizBilgileri> _currencyItems;
        private List<CompanyPriceListL> _companyPriceList;
        private static  AddressItems _companyAddressItem;
        private static  CompanyContact _companyContactItem;
        private static AddressItems _deliveryAddressItem;
        private static CompanyContact _deliveryContactItem;

        public SalesOfferEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new SalesOfferBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.PurchaseOffer;

            EventsLoad();
            
            _documentTypeItems = GetAnySingleOrListBll.ListDocumentTypeItems(null);
            _paymentMethodItems = GetAnySingleOrListBll.ListPaymentMethodItems(null).ToList();
            _currencyItems = GetAnySingleOrListBll.ListCurrencyItems(null);
            //txtWayBillCreatingMethod.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<PurchaseWayBillCreatingMethod>());
            txtDocumentType.Properties.Items.AddRange(_documentTypeItems.Select(x => x.EvrakTurAdi).ToList());
            txtPaymentMethod.FillLookUpEdit<PaymentMethodItemsL>(_paymentMethodItems, "PaymentMethodCode", "PaymentMetheodDescription");
            txtCurrency.FillLookUpEdit<DovizBilgileri>(_currencyItems, "Id", "DovizAdi");
            //txtWithHoldingRate.FillLookUpEdit()
        }
        
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SalesOfferS() : ((SalesOfferBll)Bll).Single(FilterFunctions.Filter<SalesOffer>(Id));
            NesneyiKontrollereBagla();
            
            TabloYukle();
            
            if (BaseIslemTuru != IslemTuru.EntityInsert)
            {
                _companyPriceList = GetAnySingleOrListBll.ListCompanyPriceList(x => x.CompanyId == txtCompanyName.Id).Where(x => x.CompanyPriceListValidityEnd > txtDocumentDate.DateTime).ToList();
                txtPriceList.FillLookUpEdit(_companyPriceList, "CompanyPriceListsId", "CompanyPriceListName");
                return;
            }
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtPaymentMethod.EditValue = _paymentMethodItems?.FirstOrDefault().PaymentMethodCode;
            txtCurrency.EditValue = _currencyItems?.FirstOrDefault().Id;
            txtKod.Text = ((SalesOfferBll)Bll).YeniKodVer("STK");
            txtDocumentDate.EditValue = DateTime.Now;
            txtDemandedDate.EditValue = DateTime.Now;
            txtDeliveryDate.EditValue = DateTime.Now;
            txtCompanyName.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SalesOfferS)OldEntity;
            _companyAddressItem = entity.CompanyAddressItems?.Where(x => x.Id == entity.CompanyAddressItemId).FirstOrDefault();
            _companyContactItem = entity.CompanyContactItems?.Where(x => x.Id == entity.CompanyContactItemId).FirstOrDefault();
            _deliveryAddressItem = entity.DeliveryAddressItems?.Where(x => x.Id == entity.DeliveryCompanyAddressId).FirstOrDefault();
            _deliveryContactItem = entity.DeliveryCompanyContactItems?.Where(x => x.Id == entity.DeliveryCompanyContactItemId).FirstOrDefault();
            txtKod.Text = entity.Kod;
            txtCompanyName.Id = entity.CompanyId;
            txtCompanyName.Text = entity.CompanyNameOrdered;
            txtCompanyAddress.Text = entity.CompanyAddress;
            txtCompanyContactName.Text = entity.CompanyContactName;
            txtCompanyContactEMail.Text = entity.CompanyContactEMail;
            txtCompanyContactPhone.Text = entity.CompanyContactMobilePhone;
            txtDeliveredCompany.Id = entity.DeliveryCompanyId;
            txtDeliveredCompany.Text = entity.DeliveryCompanyDescription;
            txtDeliveredAddress.Text = entity.DeliveryAddress;
            txtDeliveryCompanyContact.Text = entity.DeliveryCompanyContactName;
            txtDeliveryContactEmail.Text = entity.DeliveryCompanyContactEMail;
            txtDeliveryContactMobile.Text = entity.DeliveryCompanyContactMobilePhone;
            txtSaleOfferNote.Text = entity.SalesOfferNote;
            txtSalesOfferDescription.Text = entity.SalesOfferDescription;
            txtPaymentMethod.EditValue = entity.PaymentMethodCode;
            txtPriceList.EditValue = entity.PriceListId;
            txtCurrency.EditValue = entity.CurrencyId;
            txtBank.Id = entity.BankId;
            txtBank.Text = entity.BankDescription;
            txtBankAccount.Text = entity.BankAccountName;
            txtBankAccount.Id = entity.BankAccountId;
            txtDocumentType.EditValue = entity.DocumentTypeDescription;
            txtDocumentDate.EditValue = entity.DocumentDate;
            txtDeliveryDate.EditValue = entity.DeliveryDate;
            txtDemandedDate.EditValue = entity.DemandedDate;
            txtVase.EditValue = entity.Vase;
            txtDiscountType.EditValue = entity.DiscountTypeDescription;
            txtFirstDiscount.EditValue = entity.FirstDiscount;
            txtSecondDiscount.EditValue = entity.SecondDiscount;
            tglDurum.IsOn = entity.Durum;
            //txtProject.Text=
            //txtProject.Id=
            if (entity.CompanyAddressItems!=null)
                txtCompanyAddress.Properties.Items.AddRange(entity.DeliveryAddressItems?.Select(x=>x.EntireAddress)?.ToList());
            if(entity.CompanyContactItems!=null)
                txtCompanyContactName.Properties.Items.AddRange(entity.CompanyContactItems.Select(x => x.ContactFullName).ToList());
            if (entity.DeliveryAddressItems != null)
                txtDeliveredAddress.Properties.Items.AddRange(entity.DeliveryAddressItems?.Select(x=>x.EntireAddress).ToList());
            if(entity.DeliveryCompanyContactItems!=null)
                txtDeliveryCompanyContact.Properties.Items.AddRange(entity.DeliveryCompanyContactItems.Select(x=>x.ContactFullName).ToList());
        }

        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new SalesOffer
            {
                Id = Id,
                Kod = txtKod.Text,
                CompanyId = (long)txtCompanyName.Id,
                CompanyAddressItemId = _companyAddressItem?.Id,
                CompanyContactItemId = _companyContactItem?.Id,
                DeliveryCompanyId = txtDeliveredCompany?.Id,
                DeliveryCompanyAddressId = _deliveryAddressItem?.Id,
                DeliveryCompanyContactItemId = _deliveryContactItem?.Id,
                CurrencyId = (long)txtCurrency.EditValue,
                //PriceListId=(long)txtPriceList.EditValue,
                CreatorId = BaseIslemTuru == IslemTuru.EntityInsert ? AnaForm.KullaniciId : ((SalesOffer)OldEntity).CreatorId,
                UpdatingUserId = AnaForm.KullaniciId,
                BankId = txtBank.Id,
                BankAccountId = txtBankAccount.Id,
                PaymentMethodId = _paymentMethodItems?.Where(x => x.PaymentMethodCode == Convert.ToString(txtPaymentMethod.EditValue))?.FirstOrDefault()?.Id,
                Vase = (int)txtVase.EditValue,
                CreatingDate = BaseIslemTuru == IslemTuru.EntityInsert ? DateTime.Now : ((SalesOffer)OldEntity).CreatingDate,
                DocumentDate = (DateTime)txtDocumentDate.EditValue,
                SalesOfferDescription = txtSalesOfferDescription.Text,
                SalesOfferNote = txtSaleOfferNote.Text,
                Durum = tglDurum.IsOn,
            };
            if (txtDeliveryDate.EditValue != null)
                ((SalesOffer)CurrentEntity).DeliveryDate = (DateTime)txtDeliveryDate.EditValue;
            if (txtDemandedDate.EditValue != null)
                ((SalesOffer)CurrentEntity).DemandedDate = (DateTime)txtDemandedDate.EditValue;
            if (txtPriceList.EditValue != null)
            {
                ((SalesOffer)CurrentEntity).PriceListId = (long)txtPriceList.EditValue;
                txtCurrency.ReadOnly = true;
            }
            ButonEnabledDurumu();
        }

        protected internal override void ButonEnabledDurumu()
        {
            bool TableValueChanged()
            {
                if (salesOfferTable.TableValueChanged) return true;

                return false;
            }
            if (!IsLoaded) return;
            Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, TableValueChanged());
        }

        protected override void TabloYukle()
        {
            salesOfferTable.OwnerForm = this;
            salesOfferTable.Yukle();
        }

        protected override bool EntityInsert()
        {
            if (salesOfferTable.HatalıGiriş()) return false;
            ((SalesOffer)CurrentEntity).UpdatingDate = DateTime.Now;
            ((SalesOffer)CurrentEntity).UpdatingUserId = AnaForm.KullaniciId;
            var result = ((SalesOfferBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod)&& salesOfferTable.Kaydet();

            return result;
        }

        protected override bool EntityUpdate()
        {
            if (salesOfferTable.HatalıGiriş()) return false;
            ((SalesOffer)CurrentEntity).UpdatingDate = DateTime.Now;
            ((SalesOffer)CurrentEntity).UpdatingUserId = AnaForm.KullaniciId;
            var result = ((SalesOfferBll)Bll).Update(OldEntity, CurrentEntity) && salesOfferTable.Kaydet();
            if (result)
            {
                var offerItems = GetAnySingleOrListBll.ListSalesOfferItems(x => x.SalesOfferId == Id);
                offerItems.ForEach(x => x.IsActive = tglDurum.IsOn);
                InstanceBaseHareketEntityBll<SalesOfferItems, SalesOfferItemsBll>.UpdateEntities(offerItems);
            }

            return result;
        }

        protected override void EntityDelete()
        {
            salesOfferTable.TopluHareketSil();

            var result = salesOfferTable.Kaydet() && ((SalesOfferBll)Bll).Delete(OldEntity);

            RefreshYapilacak = true;
            Close();
        }

        protected override void SecimYap(object sender)
        {
            if (!IsLoaded) return;
            if (!(sender is ButtonEdit)) return;
            using (var sec = new SelectFunctions())
            {
                if (sender == txtCompanyName)
                {
                    sec.Sec(txtCompanyName);
                    var companyAdressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x => x.CompanyId == txtCompanyName.Id);
                    var companyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x => x.CompanyId == txtCompanyName.Id);

                    if (companyAdressItems != null)
                    {
                        txtCompanyAddress.Properties.Items.Clear();
                        txtCompanyAddress.Properties.Items.AddRange(companyAdressItems.Select(x => x.EntireAddress).ToList());
                        txtCompanyAddress.Text = companyAdressItems.Where(x => x.IsDefault).Select(x => x.EntireAddress).FirstOrDefault();
                        _companyAddressItem = companyAdressItems.Where(x => x.IsDefault).FirstOrDefault();

                    }
                    if (companyContactItems != null)
                    {
                        txtCompanyContactName.Properties.Items.Clear();
                        txtCompanyContactName.Properties.Items.AddRange(companyContactItems.Select(x => x.ContactFullName).ToList());
                        _companyContactItem = companyContactItems?.Where(x => x.IsDefault)?.FirstOrDefault();
                        txtCompanyContactName.Text = _companyContactItem?.ContactFullName;//companyContactItems?.Where(x => x.IsDefault).FirstOrDefault()?.ContactFullName;
                        txtCompanyContactPhone.Text = _companyContactItem?.ContactPhoneNumber;//companyContactItems?.Where(x => x.IsDefault).FirstOrDefault()?.ContactPhoneNumber;
                        txtCompanyContactEMail.Text = _companyContactItem?.ContactEMail;//companyContactItems?.Wh
                    }
                    if (txtDeliveredCompany.Id == null)
                    {
                        txtDeliveredCompany.Id = txtCompanyName.Id;
                        txtDeliveredCompany.Text = txtCompanyName.Text;

                        var deliveryCompanyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x => x.CompanyId == txtDeliveredCompany.Id);
                        var deliveryAdressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x => x.CompanyId == txtDeliveredCompany.Id);

                        if (deliveryAdressItems != null)
                        {
                            txtDeliveredAddress.Properties.Items.Clear();
                            txtDeliveredAddress.Properties.Items.AddRange(deliveryAdressItems.Select(x => x.EntireAddress).ToList());
                            _deliveryAddressItem = deliveryAdressItems.Where(x => x.IsDefault).FirstOrDefault();
                            txtDeliveredAddress.Text = _deliveryAddressItem?.EntireAddress;
                        }
                        if (deliveryCompanyContactItems != null)
                        {
                            txtDeliveryCompanyContact.Properties.Items.Clear();
                            txtDeliveryCompanyContact.Properties.Items.AddRange(deliveryCompanyContactItems.Select(x => x.ContactFullName).ToList());
                            _deliveryContactItem = deliveryCompanyContactItems?.Where(x => x.IsDefault)?.FirstOrDefault();
                            txtDeliveryCompanyContact.Text = _deliveryContactItem?.ContactFullName;//companyContactItems?.Where(x => x.IsDefault).FirstOrDefault()?.ContactFullName;
                            txtDeliveryContactMobile.Text = _deliveryContactItem?.ContactPhoneNumber;//companyContactItems?.Where(x => x.IsDefault).FirstOrDefault()?.ContactPhoneNumber;
                            txtDeliveryContactEmail.Text = _deliveryContactItem?.ContactEMail;//companyContactItems?.Where(x => x.IsDefault).FirstOrDefault()?.ContactEMail;
                        }
                    }
                    _companyPriceList = GetAnySingleOrListBll.ListCompanyPriceList(x => x.CompanyId == txtCompanyName.Id).Where(x => x.CompanyPriceListValidityEnd > txtDocumentDate.DateTime).ToList();
                    txtPriceList.FillLookUpEdit(_companyPriceList, "CompanyPriceListsId", "CompanyPriceListName");
                }

                else if (sender == txtDeliveredCompany)
                {
                    sec.Sec(txtDeliveredCompany);

                    var companyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x => x.CompanyId == txtDeliveredCompany.Id);
                    var deliveryAdressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x => x.CompanyId == txtDeliveredCompany.Id);

                    if (deliveryAdressItems != null)
                    {
                        txtDeliveredAddress.Properties.Items.Clear();
                        txtDeliveredAddress.Properties.Items.AddRange(deliveryAdressItems.Select(x => x.EntireAddress).ToList());
                        _deliveryAddressItem = deliveryAdressItems.Where(x => x.IsDefault).FirstOrDefault();
                        txtDeliveredAddress.Text = _deliveryAddressItem?.EntireAddress;
                    }
                    if (companyContactItems != null)
                    {
                        txtDeliveryCompanyContact.Properties.Items.Clear();
                        txtDeliveryCompanyContact.Properties.Items.AddRange(companyContactItems.Select(x => x.ContactFullName).ToList());
                        _deliveryContactItem = companyContactItems?.Where(x => x.IsDefault)?.FirstOrDefault();
                        txtDeliveryCompanyContact.Text = _deliveryContactItem?.ContactFullName;//companyContactItems?.Where(x => x.IsDefault).FirstOrDefault()?.ContactFullName;
                        txtDeliveryContactMobile.Text = _deliveryContactItem?.ContactPhoneNumber;//companyContactItems?.Where(x => x.IsDefault).FirstOrDefault()?.ContactPhoneNumber;
                        txtDeliveryContactEmail.Text = _deliveryContactItem?.ContactEMail;//companyContactItems?.Where(x => x.IsDefault).FirstOrDefault()?.ContactEMail;
                    }
                }
                else if (sender == txtBank)
                    sec.Sec(txtBank);
                else if (sender == txtBankAccount)
                    sec.Sec(txtBankAccount, txtBank);
            }
        }

        protected override void DeleteConnectedControls(object sender)
        {
            if (sender == txtDeliveredCompany)
            {
                txtDeliveryCompanyContact.Text = null;
                txtDeliveryContactEmail.Text = null;
                txtDeliveryContactMobile.Text = null;
                txtDeliveredAddress.Text = null;
                _deliveryAddressItem = null;
                _deliveryContactItem = null;
            }
            else if (sender == txtCompanyName)
            {
                txtCompanyContactName.Text = null;
                txtCompanyContactEMail.Text = null;
                txtCompanyContactPhone.Text = null;
                txtCompanyAddress.Text = null;
                _companyAddressItem = null;
                _companyContactItem = null;
            }
            else if (sender == txtPriceList)
            {
                txtPriceList.EditValue = null;
                txtCurrency.ReadOnly = false;
            }
            else if (sender == txtPaymentMethod)
                txtPaymentMethod.EditValue = null;
        }

        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;

            if (sender == txtBank)
            {
                txtBankAccount.Id = null;
                txtBankAccount.Text = null;
                txtBankAccount.Focus();
            }
            else if (sender == txtPriceList)
            {
                var entity = _companyPriceList.Where(x => x.CompanyPriceListsId == (long)txtPriceList.EditValue).FirstOrDefault();
                txtCurrency.EditValue = entity.CurrencyId;
                txtCurrency.ReadOnly = true;
            }
            else if (sender == txtCurrency)
            {
                var source = salesOfferTable.Tablo.DataController.ListSource.Cast<SalesOfferItemsL>().ToList();
                if (source.Count == 0) return;
                source.ForEach(x =>
                {
                    x.CurrencyId = (long)txtCurrency.EditValue;
                    x.CurrencyCode = _currencyItems.Where(y => y.Id == x.CurrencyId).FirstOrDefault().Kod;
                });
                salesOfferTable.Tablo.RefreshDataSource();
            }
            //else if(sender==txtCurrency)
            GuncelNesneOlustur();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;

            if (sender == txtDeliveryCompanyContact)
            {
                var entity = GetAnySingleOrListBll.GetCompanyContactItem(x => x.ContactFullName == txtDeliveryCompanyContact.Text);
                if (entity == null) return;
                txtDeliveryContactEmail.Text = entity?.ContactEMail;
                txtDeliveryContactMobile.Text = entity?.ContactPhoneNumber;
                txtDeliveryCompanyContact.Text = entity?.ContactFullName;
                _deliveryContactItem = entity;
            }
            else if (sender == txtCompanyContactName)
            {
                var entity = GetAnySingleOrListBll.GetCompanyContactItem(x => x.ContactFullName == txtCompanyContactName.Text);
                if (entity == null) return;
                txtCompanyContactEMail.Text = entity.ContactEMail;
                txtCompanyContactPhone.Text = entity.ContactPhoneNumber;
                txtCompanyContactName.Text = entity.ContactFullName;
                _companyContactItem = entity;
            }
            
            else if (sender == txtCompanyAddress)
            {
                _companyAddressItem = GetAnySingleOrListBll.GetCompanyAddressItem(x => x.EntireAddress == txtCompanyAddress.Text);
                txtCompanyAddress.Text = _companyAddressItem?.EntireAddress;
            }
            else if (sender == txtDeliveredAddress)
            {
                _deliveryAddressItem = GetAnySingleOrListBll.GetCompanyAddressItem(x => x.EntireAddress == txtDeliveredAddress.Text);
                txtDeliveredAddress.Text = _deliveryAddressItem?.EntireAddress;
            }
            GuncelNesneOlustur();
        }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            base.BaseEditForm_Shown(sender, e);
            if (BaseIslemTuru != IslemTuru.EntityUpdate) return;
            salesOfferTable.Tablo.Focus();
            salesOfferTable.Tablo.RowFocus("Id", SelectedItemId);
        }
    }
}
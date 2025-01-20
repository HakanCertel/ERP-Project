using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.General.SalesBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto.Company;
using SenfoniYazilim.Erp.Model.Dto.SalesDto;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
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
    public partial class SalesEditForm : BaseEditForm
    {
        private readonly SalesOfferS _saleOffer;
        private readonly IEnumerable<EvrakTurleriL> _documentTypeItems;
        private readonly List<PaymentMethodItemsL> _paymentMethodItems;
        private readonly List<DovizBilgileri> _currencyItems;
        private List<CompanyPriceListL> _companyPriceList;
        private static  AddressItems _companyAddressItem;
        private static  CompanyContact _companyContactItem;
        private static AddressItems _deliveryAddressItem;
        private static CompanyContact _deliveryContactItem;

        public SalesEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new SalesBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Sales;

            EventsLoad();
            
            _documentTypeItems = GetAnySingleOrListBll.ListDocumentTypeItems(null);
            _paymentMethodItems = GetAnySingleOrListBll.ListPaymentMethodItems(null).ToList();
            _currencyItems = GetAnySingleOrListBll.ListCurrencyItems(null);

            txtSaleCreatingMethod.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<SaleCreatingMethod>());
            txtDocumentType.Properties.Items.AddRange(_documentTypeItems.Select(x => x.EvrakTurAdi).ToList());
            txtPaymentMethod.FillLookUpEdit<PaymentMethodItemsL>(_paymentMethodItems, "PaymentMethodCode", "PaymentMetheodDescription");
            txtCurrency.FillLookUpEdit<DovizBilgileri>(_currencyItems, "Id", "DovizAdi");
        }
        public SalesEditForm(params object[] prm):this()
        {
            if (prm[0] != null)
                _saleOffer = (SalesOfferS)prm[0];
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SalesS() : ((SalesBll)Bll).Single(FilterFunctions.Filter<Sales>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru == IslemTuru.EntityInsert)
            {
                if(_saleOffer!=null)
                    _companyPriceList = GetAnySingleOrListBll.ListCompanyPriceList(x => x.CompanyId == _saleOffer.CompanyId).Where(x => x.CompanyPriceListValidityEnd > txtDocumentDate.DateTime).ToList();
                Id = BaseIslemTuru.IdOlustur(OldEntity);
                txtPaymentMethod.EditValue =_saleOffer!=null?_saleOffer.PaymentMethodCode: _paymentMethodItems?.FirstOrDefault().PaymentMethodCode;
                txtCurrency.EditValue =_saleOffer!=null?_saleOffer.CurrencyId: _currencyItems?.FirstOrDefault().Id;
                txtKod.Text = ((SalesBll)Bll).YeniKodVer("SLO");
                txtDocumentDate.EditValue = DateTime.Now;
                txtDemandedDate.EditValue = DateTime.Now;
                txtDeliveryDate.EditValue = DateTime.Now;
                txtCompanyName.Focus();
            }

            txtPriceList.FillLookUpEdit(_companyPriceList, "CompanyPriceListsId", "CompanyPriceListName");
            TabloYukle();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SalesS)OldEntity;
            if (_saleOffer != null)
            {
                entity.CompanyAddressItemId = _saleOffer.CompanyAddressItemId;
                entity.CompanyAddressItems = _saleOffer.CompanyAddressItems;
                entity.CompanyContactItemId = _saleOffer.CompanyContactItemId;
                entity.CompanyContactItems = _saleOffer.CompanyContactItems;
                entity.DeliveryCompanyAddressId = _saleOffer.DeliveryCompanyAddressId;
                entity.DeliveryAddressItems = _saleOffer.DeliveryAddressItems;
                entity.DeliveryCompanyContactItemId = _saleOffer.DeliveryCompanyContactItemId;
                entity.DeliveryCompanyContactItems = _saleOffer.DeliveryCompanyContactItems;
            }
            _companyAddressItem = entity.CompanyAddressItems?.Where(x => x.Id == entity.CompanyAddressItemId).FirstOrDefault();
            _companyContactItem = entity.CompanyContactItems?.Where(x => x.Id == entity.CompanyContactItemId).FirstOrDefault();
            _deliveryAddressItem = entity.DeliveryAddressItems?.Where(x => x.Id == entity.DeliveryCompanyAddressId).FirstOrDefault();
            _deliveryContactItem = entity.DeliveryCompanyContactItems?.Where(x => x.Id == entity.DeliveryCompanyContactItemId).FirstOrDefault();

            _companyPriceList = GetAnySingleOrListBll.ListCompanyPriceList(x => x.CompanyId == ((Sales)OldEntity).CompanyId);

            txtKod.Text = entity.Kod;
            txtCompanyName.Id =_saleOffer!=null?_saleOffer.CompanyId: entity.CompanyId;
            txtCompanyName.Text = _saleOffer != null ? _saleOffer.CompanyNameOrdered: entity.CompanyNameOrdered;
            txtCompanyAddress.Text = _saleOffer != null ? _saleOffer.CompanyAddress: entity.CompanyAddress;
            txtCompanyContactName.Text = _saleOffer != null ? _saleOffer.CompanyContactName: entity.CompanyContactName;
            txtCompanyContactEMail.Text = _saleOffer != null ? _saleOffer.CompanyContactEMail: entity.CompanyContactEMail;
            txtCompanyContactPhone.Text = _saleOffer != null ? _saleOffer.CompanyContactMobilePhone: entity.CompanyContactMobilePhone;
            txtDeliveredCompany.Id = _saleOffer != null ? _saleOffer.DeliveryCompanyId: entity.DeliveryCompanyId;
            txtDeliveredCompany.Text = _saleOffer != null ? _saleOffer.DeliveryCompanyDescription: entity.DeliveryCompanyDescription;
            txtDeliveredAddress.Text = _saleOffer != null ? _saleOffer.DeliveryAddress: entity.DeliveryAddress;
            txtDeliveryCompanyContact.Text = _saleOffer != null ? _saleOffer.DeliveryCompanyContactName: entity.DeliveryCompanyContactName;
            txtDeliveryContactEmail.Text = _saleOffer != null ? _saleOffer.DeliveryCompanyContactEMail: entity.DeliveryCompanyContactEMail;
            txtDeliveryContactMobile.Text = _saleOffer != null ? _saleOffer.DeliveryCompanyContactMobilePhone: entity.DeliveryCompanyContactMobilePhone;
            txtSaleNote.Text = _saleOffer != null ? _saleOffer.SalesOfferNote: entity.SalesNote;
            txtSalesDescription.Text = _saleOffer != null ? _saleOffer.SalesOfferDescription: entity.SalesDescription;
            txtPaymentMethod.EditValue = _saleOffer != null ? _saleOffer.PaymentMethodCode: entity.PaymentMethodCode;
            txtPriceList.EditValue = _saleOffer != null ? _saleOffer.PriceListId: entity.PriceListId;
            txtCurrency.EditValue = _saleOffer != null ? _saleOffer.CurrencyId: entity.CurrencyId;
            txtBank.Id = _saleOffer != null ? _saleOffer.BankId: entity.BankId;
            txtBank.Text = _saleOffer != null ? _saleOffer.BankDescription: entity.BankDescription;
            txtBankAccount.Text = _saleOffer != null ? _saleOffer.BankAccountName: entity.BankAccountName;
            txtBankAccount.Id = _saleOffer != null ? _saleOffer.BankAccountId: entity.BankAccountId;
            txtSerialNo.Text = entity.SerialNo;
            txtSequenceNo.Text = entity.SequenceNo;
            txtDocumentType.EditValue = entity.DocumentTypeDescription;
            txtDocumentDate.EditValue = entity.DocumentDate;
            txtDeliveryDate.EditValue = _saleOffer != null ? _saleOffer.DeliveryDate: entity.DeliveryDate;
            txtDemandedDate.EditValue = _saleOffer != null ? _saleOffer.DemandedDate: entity.DemandedDate;
            txtVase.EditValue = _saleOffer != null ? _saleOffer.Vase: entity.Vase;
            txtDiscountType.EditValue = entity.DiscountTypeDescription;
            txtFirstDiscount.EditValue = entity.FirstDiscount;
            txtSecondDiscount.EditValue = entity.SecondDiscount;
            txtSaleCreatingMethod.Text = _saleOffer != null ?SaleCreatingMethod.ChooseOfferItem.toName(): entity.SaleCreatingMethod.toName();
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
            CurrentEntity = new Sales
            {
                Id = Id,
                Kod = txtKod.Text,
                CompanyId =Convert.ToInt64( txtCompanyName.Id),
                CompanyAddressItemId=_companyAddressItem?.Id,
                CompanyContactItemId=_companyContactItem?.Id,
                DeliveryCompanyId = txtDeliveredCompany?.Id,
                DeliveryCompanyAddressId=_deliveryAddressItem?.Id,
                DeliveryCompanyContactItemId=_deliveryContactItem?.Id,
                CurrencyId =Convert.ToInt64( txtCurrency.EditValue),
                CreatorId = BaseIslemTuru == IslemTuru.EntityInsert ? AnaForm.KullaniciId : ((Sales)OldEntity).CreatorId,
                UpdatingUserId = AnaForm.KullaniciId,
                BankId = txtBank.Id,
                BankAccountId=txtBankAccount.Id,
                PaymentMethodId =_paymentMethodItems?.Where(x=>x.PaymentMethodCode==Convert.ToString( txtPaymentMethod.EditValue))?.FirstOrDefault()?.Id,
                Vase = (int)txtVase.EditValue,
                CreatingDate = BaseIslemTuru == IslemTuru.EntityInsert ? DateTime.Now : ((Sales)OldEntity).CreatingDate,
                DocumentDate =Convert.ToDateTime(txtDocumentDate.EditValue),
                SalesDescription = txtSalesDescription.Text,
                SalesNote = txtSaleNote.Text,
                SaleCreatingMethod=txtSaleCreatingMethod.Text.GetEnum<SaleCreatingMethod>(),
            };
            if (txtDeliveryDate.EditValue != null)
                ((Sales)CurrentEntity).DeliveryDate = (DateTime)txtDeliveryDate.EditValue;
            if (txtDemandedDate.EditValue != null)
                ((Sales)CurrentEntity).DemandedDate = (DateTime)txtDemandedDate.EditValue;
            if (txtPriceList.EditValue != null)
            {
                ((Sales)CurrentEntity).PriceListId = (long)txtPriceList.EditValue;
                txtCurrency.ReadOnly = true;
            }
            ButonEnabledDurumu();
        }

        protected internal override void ButonEnabledDurumu()
        {
            bool TableValueChanged()
            {
                if (salesTable.TableValueChanged) return true;

                return false;
            }
            if (!IsLoaded) return;
            Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, TableValueChanged());
        }

        protected override void TabloYukle()
        {
            if (salesTable.OwnerForm == null)
            {
                salesTable.OwnerForm = this;
                salesTable.Yukle();
            }
        }

        protected override bool EntityInsert()
        {
            if (salesTable.HatalıGiriş()) return false;
            ((Sales)CurrentEntity).UpdatingDate = DateTime.Now;
            ((Sales)CurrentEntity).UpdatingUserId = AnaForm.KullaniciId;

            var result = ((SalesBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod);//&&
             var askl=   salesTable.Kaydet();

            KayitSonrasiFormuKapat = result;

            if (_saleOffer != null&&result)
            {
                var saleItems=salesTable.Tablo.DataController.ListSource
                    .Cast<SalesItems>().Select(x=>x.SalesOfferItemId);
                var offerItems = SelectedEntities.Where(x => saleItems.Contains(x.Id)).Cast<SalesOfferItemsL>().ToList();

                offerItems.ForEach(x => {
                    x.IsCreatedOrder = true;
                    x.IsActive = false;
                });

                InstanceBaseHareketEntityBll<SalesOfferItems, SalesOfferItemsBll>.UpdateEntities(offerItems.Cast<BaseHareketEntity>().ToList());
            }

            return result;
        }

        protected override bool EntityUpdate()
        {
            if (salesTable.HatalıGiriş()) return false;
            ((Sales)CurrentEntity).UpdatingDate = DateTime.Now;
            ((Sales)CurrentEntity).UpdatingUserId = AnaForm.KullaniciId;
            var result = ((SalesBll)Bll).Update(OldEntity, CurrentEntity) && salesTable.Kaydet();

            return result;
        }

        protected override void EntityDelete()
        {
            salesTable.TopluHareketSil();

            var result = salesTable.Kaydet() && ((SalesBll)Bll).Delete(OldEntity);

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
                    var companyAdressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x=>x.CompanyId==txtCompanyName.Id);
                    var companyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x => x.CompanyId == txtCompanyName.Id);

                    if (companyAdressItems!=null)
                    {
                        txtCompanyAddress.Properties.Items.Clear();
                        txtCompanyAddress.Properties.Items.AddRange(companyAdressItems.Select(x => x.EntireAddress).ToList());
                        txtCompanyAddress.Text = companyAdressItems.Where(x=>x.IsDefault).Select(x => x.EntireAddress).FirstOrDefault();
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
                    if (txtDeliveredCompany.Id ==null)
                    {
                        txtDeliveredCompany.Id = txtCompanyName.Id;
                        txtDeliveredCompany.Text = txtCompanyName.Text;

                        var deliveryCompanyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x=>x.CompanyId==txtDeliveredCompany.Id);
                        var deliveryAdressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x=>x.CompanyId==txtDeliveredCompany.Id);

                        if (deliveryAdressItems != null)
                        {
                            txtDeliveredAddress.Properties.Items.Clear();
                            txtDeliveredAddress.Properties.Items.AddRange(deliveryAdressItems.Select(x => x.EntireAddress).ToList());
                            _deliveryAddressItem = deliveryAdressItems.Where(x=>x.IsDefault).FirstOrDefault();
                            txtDeliveredAddress.Text = _deliveryAddressItem?.EntireAddress;
                        }
                        if (deliveryCompanyContactItems != null)
                        {
                            txtDeliveryCompanyContact.Properties.Items.Clear();
                            txtDeliveryCompanyContact.Properties.Items.AddRange(deliveryCompanyContactItems.Select(x => x.ContactFullName).ToList());
                            _deliveryContactItem = deliveryCompanyContactItems?.Where(x=>x.IsDefault)?.FirstOrDefault();
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
                    sec.Sec(txtBankAccount,txtBank);
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
                txtPriceList.FillLookUpEdit(_companyPriceList, "CompanyPriceListsId", "CompanyPriceListName");
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
                var entity = _companyPriceList.Where(x => x.CompanyPriceListsId == (long)txtPriceList.EditValue);

                if (entity == null) return;

                txtCurrency.EditValue = entity?.FirstOrDefault()?.CurrencyId;

                if (salesTable.Tablo.DataController.ListSource.Cast<SalesItemsL>().Where(x => !x.Delete).Count() != 0)
                {
                    if (Messages.EvetSeciliEvetHayir("Tabloda bulunan kayıtların birim fiyatları değiştirilsin mi?", "Birim Fiyat Değişim Onay") == System.Windows.Forms.DialogResult.Yes)
                    {
                        var priceList=GetAnySingleOrListBll.ListPriceListItems(x => x.PriceListId == (long)txtPriceList.EditValue);

                        var source = salesTable.Tablo.DataController.ListSource.Cast<SalesItemsL>().ToList();

                        if (source.Count == 0||priceList==null) return;
                        source.ForEach(x =>
                        {
                            x.DefaultUnitPrice =Convert.ToDecimal( priceList.Where(y => y.MaterialId == x.MaterialId)?.FirstOrDefault()?.ItemPrice);
                        });

                        salesTable.Tablo.RefreshDataSource();

                        txtCurrency.ReadOnly = true;
                    }

                }
            }
            else if (sender == txtCurrency)
            {
                var source = salesTable.Tablo.DataController.ListSource.Cast<SalesItemsL>().ToList();
                if (source.Count == 0) return;
                source.ForEach(x =>
                {
                    x.CurrencyId = (long)txtCurrency.EditValue;
                    x.CurrencyCode = _currencyItems.Where(y => y.Id == x.CurrencyId).FirstOrDefault().Kod;
                });
                salesTable.Tablo.RefreshDataSource();
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
            salesTable.Tablo.Focus();
            salesTable.Tablo.RowFocus("Id", SelectedItemId);
        }
    }
}
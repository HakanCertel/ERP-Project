using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using SenfoniYazilim.Erp.Bll.General.SalesBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Model.Dto.Company;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Company;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaSiparisForms
{
    public partial class PurchaseOrderEditForm : BaseEditForm
    {
        private readonly PurchaseOrderCreatingMethod _orederMethod=PurchaseOrderCreatingMethod.ChooseMaterial;
        private readonly IEnumerable<EvrakTurleriL> _documentTypeItems;
        private readonly List<PaymentMethodItemsL> _paymentMethodItems;
        private readonly List<DovizBilgileri> _currencyItems;
        private  CompanyPriceListL _companyPriceList;
        private  AddressItems _companyAddressItem;
        private  CompanyContact _companyContactItem;
        private  AddressItems _deliveryAddressItem;
        private  CompanyContact _deliveryContactItem;

        public PurchaseOrderEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new PurchaseOrderBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.PurchaseOffer;

            EventsLoad();
            
            _documentTypeItems = GetAnySingleOrListBll.ListDocumentTypeItems(null);
            _paymentMethodItems = GetAnySingleOrListBll.ListPaymentMethodItems(null).ToList();
            _currencyItems = GetAnySingleOrListBll.ListCurrencyItems(null);
            
            txtOrderCreatingMethod.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<PurchaseOrderCreatingMethod>());
            txtDocumentType.Properties.Items.AddRange(_documentTypeItems.Select(x => x.EvrakTurAdi).ToList());
            txtPaymentMethod.FillLookUpEdit<PaymentMethodItemsL>(_paymentMethodItems, "PaymentMethodCode", "PaymentMetheodDescription");
            txtCurrency.FillLookUpEdit<DovizBilgileri>(_currencyItems,"Id", "DovizAdi");
           
            //txtWithHoldingRate.FillLookUpEdit()
        }
        public PurchaseOrderEditForm(params object[] prm):this()
        {
            if (prm[0] != null)
                _orederMethod = (PurchaseOrderCreatingMethod)prm[0];
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new PurchaseOrderS() : ((PurchaseOrderBll)Bll).Single(FilterFunctions.Filter<Model.Entities.Satınalma.PurchaseOrder>(Id));

            NesneyiKontrollereBagla();
            

            if (BaseIslemTuru == IslemTuru.EntityInsert)
            {
                Id = BaseIslemTuru.IdOlustur(OldEntity);
                txtPaymentMethod.EditValue = _paymentMethodItems?.FirstOrDefault().PaymentMethodCode;
                txtCurrency.EditValue = _currencyItems?.FirstOrDefault().Id;
                txtKod.Text = ((PurchaseOrderBll)Bll).YeniKodVer("STK");
                txtDocumentDate.EditValue = DateTime.Now;
                txtOrderCreatingMethod.Text = _orederMethod.toName();
                txtCompanyName.Focus();
            }
            TabloYukle();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (PurchaseOrderS)OldEntity;
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
            txtPurchaseOrderNote.Text = entity.PurchaseOrderNote;
            txtPurchaseOrderDescription.Text = entity.PurchaseOrderDescription;
            txtDocumentType.EditValue = entity.DocumentTypeDescription;
            txtDocumentDate.EditValue = entity.DocumentDate;
            txtPaymentMethod.EditValue = entity.PaymentMethodCode;
            txtCurrency.EditValue = entity.CurrencyId;
            txtBank.Id = entity.BankId;
            txtBank.Text = entity.BankDescription;
            txtBankAccount.Id = entity.BankAccountId;
            txtBankAccount.Text = entity.BankAccountName;
            txtSerialNo.Text = entity.SerialNo;
            txtSequenceNo.Text = entity.SequenceNo;
            txtOrderCreatingMethod.Text = entity.PurchaseOrderCreatingMethod.toName();
            txtDeliveryDate.EditValue = entity.DeliveryDate;
            txtVase.EditValue = entity.Vase;
            txtDiscountType.EditValue = entity.DiscountTypeDescription;
            txtFirstDiscount.EditValue = entity.FirstDiscount;
            txtSecondDiscount.EditValue = entity.SecondDiscount;
            tglDurum.IsOn = entity.Durum;
            //txtProject.Text=
            //txtProject.Id=
            if (entity.CompanyAddressItems != null)
                txtCompanyAddress.Properties.Items.AddRange(entity.DeliveryAddressItems?.Select(x => x.EntireAddress)?.ToList());
            if (entity.CompanyContactItems != null)
                txtCompanyContactName.Properties.Items.AddRange(entity.CompanyContactItems.Select(x => x.ContactFullName).ToList());
            if (entity.DeliveryAddressItems != null)
                txtDeliveredAddress.Properties.Items.AddRange(entity.DeliveryAddressItems?.Select(x => x.EntireAddress).ToList());
            if (entity.DeliveryCompanyContactItems != null)
                txtDeliveryCompanyContact.Properties.Items.AddRange(entity.DeliveryCompanyContactItems.Select(x => x.ContactFullName).ToList());

        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new PurchaseOrder
            {
                Id = Id,
                Kod = txtKod.Text,
                CompanyId = (long)txtCompanyName.Id,
                CompanyAddressItemId = _companyAddressItem?.Id,
                CompanyContactItemId = _companyContactItem?.Id,
                DeliveryCompanyId = txtDeliveredCompany.Id,
                DeliveryCompanyAddressId = _deliveryAddressItem?.Id,
                DeliveryCompanyContactItemId = _deliveryContactItem?.Id,
                PaymentMethodId = _paymentMethodItems?.Where(x => x.PaymentMetheodDescription == txtPaymentMethod.Text)?.FirstOrDefault()?.Id, //paymentMethodId,//Convert.ToInt32( _paymentMethodItems[txtPaymentMethod.ItemIndex]),
                CurrencyId = (long)txtCurrency.EditValue,//_currencyItems?.Where(x=>x.DovizAdi==txtCurrency.Text)?.FirstOrDefault()?.Id,//currencyId,//Convert.ToInt64( _currencyItems[txtCurrency.ItemIndex]),
                BankId = txtBank.Id,
                BankAccountId = txtBankAccount.Id,
                Vase = (int)txtVase.EditValue,
                OrderCreatorId = ((PurchaseOrder)OldEntity).OrderCreatorId,
                CreatingDate = ((PurchaseOrder)OldEntity).CreatingDate,
                UpdatingDate= ((PurchaseOrder)OldEntity).UpdatingDate,
                UpdatingOrder= ((PurchaseOrder)OldEntity).UpdatingOrder,
                DocumentDate = (DateTime)txtDocumentDate.EditValue,
                PurchaseOrderDescription = txtPurchaseOrderDescription.Text,
                PurchaseOrderNote = txtPurchaseOrderNote.Text,
                PurchaseOrderCreatingMethod = txtOrderCreatingMethod.Text.GetEnum<PurchaseOrderCreatingMethod>(),
                Durum=tglDurum.IsOn,
            };
            if (txtDeliveryDate.EditValue != null)
                ((PurchaseOrder)CurrentEntity).DeliveryDate =(DateTime)txtDeliveryDate.EditValue;
            ButonEnabledDurumu();
        }

        protected internal override void ButonEnabledDurumu()
        {
            bool TableValueChanged()
            {
                if (purchaseOrderTable.TableValueChanged) return true;

                return false;
            }
            if (!IsLoaded) return;
            Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, TableValueChanged());
        }

        protected override void TabloYukle()
        {
            purchaseOrderTable.OwnerForm = this;
            purchaseOrderTable.Yukle();
        }

        protected override bool EntityInsert()
        {
            if (purchaseOrderTable.HatalıGiriş()) return false;
            ((PurchaseOrder)CurrentEntity).CreatingDate = DateTime.Now;
            ((PurchaseOrder)CurrentEntity).OrderCreatorId = AnaForm.KullaniciId;
            ((PurchaseOrder)CurrentEntity).UpdatingDate = DateTime.Now;
            ((PurchaseOrder)CurrentEntity).UpdatingOrder = AnaForm.KullaniciId;

            var result = ((PurchaseOrderBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod)&&purchaseOrderTable.Kaydet();

            
            if (result && _orederMethod == PurchaseOrderCreatingMethod.ChoosePurchaseDemandItem)
            {
                var orderItems = GetAnySingleOrListBll.ListPurchaseOrderItems(x => x.OwnerFormId == Id).ToList();
                var demandList = new List<PurchaseDemandItems>();
                var saleList = new List<SalesItems>();
                orderItems.ForEach(x =>
                {
                    var demandItem = GetAnySingleOrListBll.GetPurchaseDemandItem(y => y.Id == x.PurchaseDemandItemId);

                    demandItem.IsCreatedOrder = true;
                    demandItem.PurchaseOrderItemId = x.Id;
                    demandItem.PurchaseOrderId = Id;

                    demandList.Add(demandItem);

                    var saleItem = GetAnySingleOrListBll.GetSaleItemL(y => y.PurchaseDemanItemId == x.PurchaseDemandItemId);

                    if (saleItem != null)
                    {
                        saleItem.ProccessComletedDate = x.DeliveryDate;
                        saleItem.SaleProccessStatus = SaleProccessStatus.CreatedPurchaseOrder;
                        saleList.Add(saleItem);
                    }
                });
               
                InstanceBaseHareketEntityBll<PurchaseDemandItems, PurchaseDemandItemsTableBll>
                    .UpdateEntities(demandList.Cast<BaseHareketEntity>().ToList());

                InstanceBaseHareketEntityBll<SalesItems, SalesItemsBll>
                   .UpdateEntities(saleList.Cast<BaseHareketEntity>().ToList());

            }

            if (result && _orederMethod == PurchaseOrderCreatingMethod.ChoosePurchaseOfferItem)
            {
                var orderItems = GetAnySingleOrListBll.ListPurchaseOrderItems(x => x.OwnerFormId == Id).ToList();
                var offerList = new List<PurchaseOfferItems>();
                var saleList = new List<SalesItems>();
                orderItems.ForEach(x =>
                {
                    var offerItem = GetAnySingleOrListBll.GetPurchaseOfferItem(y => y.Id == x.PurchaseOfferItemId);

                    offerItem.IsCreatedOrder = true;
                    offerItem.PurchaseOrderItemId = x.Id;
                    offerItem.PurchaseOrderId = Id;

                    offerList.Add(offerItem);

                    var saleItem = GetAnySingleOrListBll.GetSaleItemL(y => y.PurchaseDemanItemId == x.PurchaseDemandItemId);

                    if (saleItem != null)
                    {
                        saleItem.ProccessComletedDate = x.DeliveryDate;
                        saleItem.SaleProccessStatus = SaleProccessStatus.CreatedPurchaseOrder;
                        saleList.Add(saleItem);
                    }
                });

                InstanceBaseHareketEntityBll<PurchaseOfferItems, PurchaseOfferItemsBll>
                    .UpdateEntities(offerList.Cast<BaseHareketEntity>().ToList());

                InstanceBaseHareketEntityBll<SalesItems, SalesItemsBll>
                   .UpdateEntities(saleList.Cast<BaseHareketEntity>().ToList());

            }

            return result;
        }

        protected override bool EntityUpdate()
        {
            if (purchaseOrderTable.HatalıGiriş()) return false;
            ((PurchaseOrder)CurrentEntity).UpdatingDate = DateTime.Now;
            ((PurchaseOrder)CurrentEntity).UpdatingOrder = AnaForm.KullaniciId;
            var result = ((PurchaseOrderBll)Bll).Update(OldEntity, CurrentEntity) && purchaseOrderTable.Kaydet();

            if (result)
            {
                var orderItems = GetAnySingleOrListBll.ListPurchaseOrderItems(x => x.OwnerFormId == Id).ToList();
                var saleList = new List<SalesItems>();
                orderItems.ForEach(x =>
                {
                    var saleItem = GetAnySingleOrListBll.GetSaleItemL(y => y.PurchaseDemanItemId == x.PurchaseDemandItemId);

                    if (saleItem != null)
                    {
                        saleItem.ProccessComletedDate = x.DeliveryDate;
                        saleItem.SaleProccessStatus = SaleProccessStatus.CreatedPurchaseOrder;
                        saleList.Add(saleItem);
                    }
                });

                InstanceBaseHareketEntityBll<SalesItems, SalesItemsBll>
                   .UpdateEntities(saleList.Cast<BaseHareketEntity>().ToList());
            }
            return result;
        }

        protected override void EntityDelete()
        {
            purchaseOrderTable.TopluHareketSil();

            var result = purchaseOrderTable.Kaydet()&&((PurchaseOrderBll)Bll).Delete(OldEntity) ;

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
                    
                    if (companyAdressItems != null)
                    {
                        txtCompanyAddress.Properties.Items.Clear();
                        txtCompanyAddress.Properties.Items.AddRange(companyAdressItems.Select(x => x.EntireAddress).ToList());
                        txtCompanyAddress.Text = companyAdressItems.Where(x=>x.IsDefault).Select(x => x.EntireAddress).FirstOrDefault();
                        _companyAddressItem = companyAdressItems.Where(x=>x.IsDefault).FirstOrDefault();
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
                            txtDeliveryCompanyContact.Text = _deliveryContactItem?.ContactFullName;
                            txtDeliveryContactMobile.Text = _deliveryContactItem?.ContactPhoneNumber;
                            txtDeliveryContactEmail.Text = _deliveryContactItem?.ContactEMail;
                        }
                    }
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
                        _deliveryAddressItem = deliveryAdressItems?.Where(x => x.IsDefault).FirstOrDefault();
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

        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            else if (sender == txtBank)
            {
                txtBankAccount.Id = null;
                txtBankAccount.Text = null;
                txtBankAccount.Focus();
            }
            else if (sender is MyToogleSwitch)
            {
                purchaseOrderTable.Tablo.DataController
                    .ListSource?.Cast<PurchaseOrderItemsL>()
                    .ToList().ForEach(x => { x.IsActive = !x.IsActive; x.Update = true; });
            }
            else if (sender == txtDeliveredAddress)
            {
                _deliveryAddressItem = GetAnySingleOrListBll.GetCompanyAddressItem(x => x.EntireAddress == txtDeliveredAddress.Text);
                txtDeliveredAddress.Text = _deliveryAddressItem?.EntireAddress;
            }
            else if (sender == txtDeliveryCompanyContact)
            {
                var entity = GetAnySingleOrListBll.GetCompanyContactItem(x => x.ContactFullName == txtDeliveryCompanyContact.Text);

                if (entity == null) return;

                txtDeliveryContactEmail.Text = entity.ContactEMail;
                txtDeliveryContactMobile.Text = entity.ContactPhoneNumber;
                txtDeliveryCompanyContact.Text = entity.ContactFullName;
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
            base.Control_EditValueChanged(sender, e);
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
        }
    }
}
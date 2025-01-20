using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using SenfoniYazilim.Erp.Bll.General.WayBillBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Model.Dto.Company;
using SenfoniYazilim.Erp.Model.Dto.WayBillDto;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Company;
using SenfoniYazilim.Erp.Model.Entities.WayBillEntities;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using System;
using System.Collections.Generic;
using System.Linq;
using SenfoniYazilim.Erp.Model.Dto;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WayBillForms
{
    public partial class PurchaseWayBillEditForm : BaseEditForm
    {
        private readonly IEnumerable<EvrakTurleriL> _documentTypeItems;
        private readonly List<PaymentMethodItemsL> _paymentMethodItems;
        private readonly List<DovizBilgileri> _currencyItems;
        private static CompanyPriceListL _companyPriceList;
        private static  AddressItems _companyAddressItem;
        private static  CompanyContact _companyContactItem;
        private static AddressItems _deliveryAddressItem;
        private static CompanyContact _deliveryContactItem;

        public PurchaseWayBillEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new PurchaseWayBillBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.PurchaseOffer;

            EventsLoad();
            
            _documentTypeItems = GetAnySingleOrListBll.ListDocumentTypeItems(null);
            _paymentMethodItems = GetAnySingleOrListBll.ListPaymentMethodItems(null).ToList();
            _currencyItems = GetAnySingleOrListBll.ListCurrencyItems(null);

            txtWayBillCreatingMethod.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<WayBillCreatingMethod>());
            txtDocumentType.Properties.Items.AddRange(_documentTypeItems.Select(x => x.EvrakTurAdi).ToList());
            txtPaymentMethod.FillLookUpEdit<PaymentMethodItemsL>(_paymentMethodItems, "PaymentMethodCode", "PaymentMetheodDescription");
            txtCurrency.FillLookUpEdit<DovizBilgileri>(_currencyItems, "Id", "DovizAdi");
            //txtWithHoldingRate.FillLookUpEdit()
        }
        
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new PurchaseWayBillS() : ((PurchaseWayBillBll)Bll).Single(FilterFunctions.Filter<PurchaseWayBill>(Id));
            NesneyiKontrollereBagla();

            TabloYukle();
            
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtPaymentMethod.EditValue = _paymentMethodItems?.FirstOrDefault().PaymentMethodCode;
            txtCurrency.EditValue = _currencyItems?.FirstOrDefault().Id;
            txtKod.Text = ((PurchaseWayBillBll)Bll).YeniKodVer("STK");
            txtDocumentDate.EditValue = DateTime.Now;
            txtDeliveryDate.EditValue = DateTime.Now;
            txtCompanyName.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (PurchaseWayBillS)OldEntity;
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
            txtPurchaseWayBillNote.Text = entity.PurchaseWayBillNote;
            txtPurchaseWayBillDescription.Text = entity.PurchaseWayBillDescription;
            txtPaymentMethod.EditValue = entity.PaymentMethodCode;
            txtCurrency.EditValue = entity.CurrencyId;
            txtBank.Id = entity.BankId;
            txtBank.Text = entity.BankDescription;
            txtBankAccount.Text = entity.BankAccountName;
            txtBankAccount.Id = entity.BankAccountId;
            txtSerialNo.Text = entity.SerialNo;
            txtSequenceNo.Text = entity.SequenceNo;
            txtWayBillCreatingMethod.Text = entity.PurchaseWayBillCreatingMethod.toName();
            txtDocumentType.EditValue = entity.DocumentTypeDescription;
            txtDocumentDate.EditValue = entity.DocumentDate;
            txtDeliveryDate.EditValue = entity.DeliveryDate;
            txtVase.EditValue = entity.Vase;
            txtDiscountType.EditValue = entity.DiscountTypeDescription;
            txtFirstDiscount.EditValue = entity.FirstDiscount;
            txtSecondDiscount.EditValue = entity.SecondDiscount;
            txtWarehouse.Id = entity.WarehouseId;
            txtWarehouse.Text = entity.WarehouseCode;
            txtWarehouseName.Text = entity.WarehouseName;
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
            CurrentEntity = new PurchaseWayBill
            {
                Id = Id,
                Kod = txtKod.Text,
                CompanyId = (long)txtCompanyName.Id,
                CompanyAddressItemId=_companyAddressItem?.Id,
                CompanyContactItemId=_companyContactItem?.Id,
                DeliveryCompanyId = txtDeliveredCompany?.Id,
                DeliveryCompanyAddressId=_deliveryAddressItem?.Id,
                DeliveryCompanyContactItemId=_deliveryContactItem?.Id,
                CurrencyId =(long)txtCurrency.EditValue,
                CreatorId = BaseIslemTuru == IslemTuru.EntityInsert ? AnaForm.KullaniciId : ((PurchaseWayBill)OldEntity).CreatorId,
                UpdatingUserId = AnaForm.KullaniciId,
                BankId = txtBank.Id,
                BankAccountId=txtBankAccount.Id,
                PaymentMethodId =_paymentMethodItems?.Where(x=>x.PaymentMethodCode==Convert.ToString( txtPaymentMethod.EditValue))?.FirstOrDefault()?.Id,
                Vase = (int)txtVase.EditValue,
                CreatingDate = BaseIslemTuru == IslemTuru.EntityInsert ? DateTime.Now : ((PurchaseWayBill)OldEntity).CreatingDate,
                DocumentDate =(DateTime) txtDocumentDate.EditValue,
                PurchaseWayBillDescription = txtPurchaseWayBillDescription.Text,
                PurchaseWayBillNote = txtPurchaseWayBillNote.Text,
                WarehouseId=(long)txtWarehouse.Id,
            };
            if (txtDeliveryDate.EditValue != null)
                ((PurchaseWayBill)CurrentEntity).DeliveryDate = (DateTime)txtDeliveryDate.EditValue;
            ButonEnabledDurumu();
        }

        protected internal override void ButonEnabledDurumu()
        {
            bool TableValueChanged()
            {
                if (purchaseWayBillTable.TableValueChanged) return true;

                return false;
            }
            if (!IsLoaded) return;
            Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, TableValueChanged());
        }

        protected override void TabloYukle()
        {
            purchaseWayBillTable.OwnerForm = this;
            purchaseWayBillTable.Yukle();

            //txtCompanyName.Enabled = purchaseWayBillTable.Tablo.DataController.ListSource.Count > 0;

            //purchaseWayBillTable.Tablo.RowFocus("Id", SelectedItemId);
        }

        protected override bool EntityInsert()
        {
            if (purchaseWayBillTable.HatalıGiriş()) return false;

            ((PurchaseWayBill)CurrentEntity).UpdatingDate = DateTime.Now;
            ((PurchaseWayBill)CurrentEntity).UpdatingUserId = AnaForm.KullaniciId;

            var result = ((PurchaseWayBillBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod) && purchaseWayBillTable.Kaydet();

            if (result && txtWayBillCreatingMethod.Text.GetEnum<WayBillCreatingMethod>() == WayBillCreatingMethod.ChooseOrderItem)
            {
                var wayBillItems = GetAnySingleOrListBll.ListPurchaseWayBillItems(x => x.WayBillId == Id).ToList();

                var orderList = new List<PurchaseOrderItems>();
                wayBillItems.ForEach(x =>
                {
                    var orderItem = GetAnySingleOrListBll.GetPurchaseOrderItem(y => y.Id == x.PurchaseOrderItemId);
                    orderItem.IsCreatedWayBill = true;
                    orderItem.PurchaseWayBillItemId = x.Id;
                    orderItem.PurchaseWayBillId = Id;
                    orderItem.WayBillQty = orderItem.WayBillQty + x.Quantity;
                    orderList.Add(orderItem);
                });
                InstanceBaseHareketEntityBll<PurchaseOrderItems, PurchaseOrderItemsBll>
                    .UpdateEntities(orderList.Cast<BaseHareketEntity>().ToList());
            }
            if (result)
            {
                purchaseWayBillTable.Listele();
                var whmList = purchaseWayBillTable.TranferItem().Cast<WareHouseStockL>().ToList(); ;

                var insert = GetAnySingleOrListBll.UpdateWarehouseStock(whmList);

                if (insert)
                    purchaseWayBillTable.InsertStockMoving();
            }
            return result;
        }

        protected override bool EntityUpdate()
        {
            if (purchaseWayBillTable.HatalıGiriş()) return false;
            ((PurchaseWayBill)CurrentEntity).UpdatingDate = DateTime.Now;
            ((PurchaseWayBill)CurrentEntity).UpdatingUserId = AnaForm.KullaniciId;
            var result = ((PurchaseWayBillBll)Bll).Update(OldEntity, CurrentEntity) && purchaseWayBillTable.Kaydet();

            return result;
        }

        protected override void EntityDelete()
        {
            purchaseWayBillTable.TopluHareketSil();

            var result = purchaseWayBillTable.Kaydet()&&((PurchaseWayBillBll)Bll).Delete(OldEntity);

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
                else if (sender == txtWarehouse)
                    sec.Sec(txtWarehouse, txtWarehouseName);
            }
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
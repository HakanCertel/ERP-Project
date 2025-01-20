using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto.WayBillDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.WayBillEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General.WayBillBll
{
    public class PurchaseWayBillBll : BaseGenelBll<PurchaseWayBill>, IBaseGenelBll, IBaseCommonBll
    {
        public PurchaseWayBillBll() : base(KartTuru.PurchaseOrder) { }

        public PurchaseWayBillBll(Control ctrl) : base(ctrl, KartTuru.PurchaseWayBill) { }

        public override BaseEntity Single(Expression<Func<PurchaseWayBill, bool>> filter)
        {
            var purchaseWayBill= BaseSingle(filter, x => new PurchaseWayBillS
            {
                Id = x.Id,
                Kod = x.Kod,
                CompanyId = x.CompanyId,
                CompanyNameOrdered = x.Company.CariAdi,
                CompanyAddressItemId = x.CompanyAddressItemId,
                CompanyAddressItems = x.Company.AddressItems,
                CompanyContactItemId = x.CompanyContactItemId,
                CompanyContactItems = x.Company.CompanyContactItems,
                CompanyPriceListId = x.CompanyPriceListId,
                DeliveryCompanyId = x.DeliveryCompanyId,
                DeliveryCompanyCode = x.DeliveryCompany.Kod,
                DeliveryCompanyDescription = x.DeliveryCompany.CariAdi,
                DeliveryCompanyAddressId = x.DeliveryCompanyAddressId,
                DeliveryAddressItems = x.DeliveryCompany.AddressItems,
                DeliveryCompanyContactItemId = x.DeliveryCompanyContactItemId,
                DeliveryCompanyContactItems = x.DeliveryCompany.CompanyContactItems,
                DeliveryDate=x.DeliveryDate,
                PaymentMethodId = x.PaymentMethodId,
                PaymentMethodCode = x.PaymentMethod.PaymentMethodCode,
                PaymentMethodDescription = x.PaymentMethod.PaymentMetheodDescription,
                CurrencyId = x.CurrencyId,
                CurrencyCode = x.Currency.Kod,
                CurrencyDescription = x.Currency.Aciklama,
                ProjectId = x.ProjectId,
                UpdatingUserId = x.UpdatingUserId,
                WithHoldingRateId = x.WithHoldingRateId,
                BankId = x.BankId,
                BankCode = x.Bank.Kod,
                BankDescription = x.Bank.BankaAdi,
                BankAccountId = x.BankAccountId,
                BankAccountCode = x.BankAccount.Kod,
                BankAccountName = x.BankAccount.HesapAdi,
                DocumentTypeId = x.DocumentTypeId,
                DocumentTypeDescription = x.DocumentType.EvrakTurAdi,
                DiscountTypeId = x.DiscountTypeId,
                TransportTypeId = x.TransportTypeId,
                DeliveryTypeId = x.DeliveryTypeId,
                Vase = x.Vase,
                ExchangeRate = x.ExchangeRate,
                FirstDiscount = x.FirstDiscount,
                SecondDiscount = x.SecondDiscount,
                Subject = x.Subject,
                DocumentDate = x.DocumentDate,
                PurchaseWayBillNote = x.PurchaseWayBillNote,
                PurchaseWayBillDescription = x.PurchaseWayBillDescription,
                // WithHoldingRate=x.wi
                //DiscountTypeDescription=x.Dis
                Durum = x.Durum,
                WarehouseId=x.WarehouseId,
                WarehouseCode=x.Warehouse.Kod,
                WarehouseName=x.Warehouse.WarehouseName,
            });
            purchaseWayBill.CompanyAddressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x => x.CompanyId == purchaseWayBill.CompanyId).ToList();
            purchaseWayBill.CompanyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x => x.CompanyId == purchaseWayBill.CompanyId).ToList();

            purchaseWayBill.CompanyAddress = purchaseWayBill.CompanyAddressItems?.Where(x => x.Id == purchaseWayBill.CompanyAddressItemId)?.FirstOrDefault()?.EntireAddress;
            var CompanyContact = purchaseWayBill.CompanyContactItems?.Where(x => x.Id == purchaseWayBill.CompanyContactItemId)?.FirstOrDefault();

            purchaseWayBill.CompanyContactName = CompanyContact?.ContactFullName;
            purchaseWayBill.CompanyContactEMail = CompanyContact?.ContactEMail;
            purchaseWayBill.CompanyContactMobilePhone = CompanyContact?.ContactPhoneNumber;


            purchaseWayBill.DeliveryAddressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x => x.CompanyId == purchaseWayBill.CompanyId).ToList();
            purchaseWayBill.DeliveryCompanyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x => x.CompanyId == purchaseWayBill.CompanyId).ToList();

            purchaseWayBill.DeliveryAddress = purchaseWayBill.DeliveryAddressItems?.Where(x => x.Id == purchaseWayBill.DeliveryCompanyAddressId)?.FirstOrDefault()?.EntireAddress;
            var deliveryCompanyContact = purchaseWayBill.DeliveryCompanyContactItems?.Where(x => x.Id == purchaseWayBill.DeliveryCompanyContactItemId)?.FirstOrDefault();

            purchaseWayBill.DeliveryCompanyContactName = deliveryCompanyContact?.ContactFullName;
            purchaseWayBill.DeliveryCompanyContactEMail = deliveryCompanyContact?.ContactEMail;
            purchaseWayBill.DeliveryCompanyContactMobilePhone = deliveryCompanyContact?.ContactPhoneNumber;

            return purchaseWayBill;
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<PurchaseWayBill, bool>> filter)
        {
            return BaseList(filter, x => new
            {
                wayBill = x,
                contact = x.Company.CompanyContactItems.Where(y => y.IsDefault).Select(y => new
                {
                    name = y.ContactFullName,
                    mobile = y.ContactPhoneNumber,
                    eMail = y.ContactEMail
                }).FirstOrDefault(),

            }).Select(x => new PurchaseWayBillL
            {
                Id = x.wayBill.Id,
                Kod = x.wayBill.Kod,
                CompanyId=x.wayBill.CompanyId,
                DeliveryCompanyId=x.wayBill.DeliveryCompanyId,
                SerialNo=x.wayBill.SerialNo,
                SequenceNo=x.wayBill.SequenceNo,
                CompanyNameOrdered = x.wayBill.Company.CariAdi,
                DocumentDate = x.wayBill.DocumentDate,
                DeliveryCompanyDescription = x.wayBill.DeliveryCompany.CariAdi,
                PaymentMethodDescription = x.wayBill.PaymentMethod.PaymentMetheodDescription,
                Vase = x.wayBill.Vase,
                CurrencyDescription = x.wayBill.Currency.DovizAdi,
                BankAccountId = x.wayBill.BankAccountId,
                BankAccountCode = x.wayBill.BankAccount.Kod,
                BankAccountName = x.wayBill.BankAccount.HesapAdi,
                BankDescription = x.wayBill.Bank.BankaAdi,
                PurchaseWayBillDescription = x.wayBill.PurchaseWayBillDescription,
                PurchaseWayBillNote = x.wayBill.PurchaseWayBillNote,
                DeliveryCompanyContactName = x.contact.name,
                DeliveryCompanyContactMobilePhone = x.contact.mobile,
                DeliveryCompanyContactEMail = x.contact.eMail,
            }).ToList();
        }

    }
}

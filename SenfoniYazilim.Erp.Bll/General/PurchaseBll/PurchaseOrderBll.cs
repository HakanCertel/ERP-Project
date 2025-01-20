using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General.PurchaseBll
{
    public class PurchaseOrderBll:BaseGenelBll<PurchaseOrder>, IBaseGenelBll, IBaseCommonBll
    {
        public PurchaseOrderBll() : base(KartTuru.PurchaseOrder) { }

        public PurchaseOrderBll(Control ctrl) : base(ctrl, KartTuru.PurchaseOrder) { }

        public override BaseEntity Single(Expression<Func<PurchaseOrder, bool>> filter)
        {
            var purchaseOrder = BaseSingle(filter, x => new PurchaseOrderS
            {
                Id = x.Id,
                Kod = x.Kod,
                CompanyId = x.CompanyId,
                CompanyNameOrdered = x.Company.CariAdi,
                CompanyAddressItemId=x.CompanyAddressItemId,
                CompanyAddressItems = x.Company.AddressItems,
                CompanyContactItemId=x.CompanyContactItemId,
                CompanyContactItems=x.Company.CompanyContactItems,
                CompanyPriceListId=x.CompanyPriceListId,
                DeliveryCompanyId = x.DeliveryCompanyId,
                DeliveryCompanyCode=x.DeliveryCompany.Kod,
                DeliveryCompanyDescription=x.DeliveryCompany.CariAdi,
                DeliveryCompanyAddressId=x.DeliveryCompanyAddressId,
                DeliveryAddressItems=x.DeliveryCompany.AddressItems,
                DeliveryCompanyContactItemId = x.DeliveryCompanyContactItemId,
                DeliveryCompanyContactItems=x.DeliveryCompany.CompanyContactItems,
                PaymentMethodId = x.PaymentMethodId,
                PaymentMethodCode = x.PaymentMethod.PaymentMethodCode,
                PaymentMethodDescription = x.PaymentMethod.PaymentMetheodDescription,
                CurrencyId = x.CurrencyId,
                CurrencyCode=x.Currency.Kod,
                CurrencyDescription=x.Currency.Aciklama,
                ProjectId = x.ProjectId,
                UpdatingOrder = x.UpdatingOrder,
                WithHoldingRateId = x.WithHoldingRateId,
                BankId = x.BankId,
                BankCode=x.Bank.Kod,
                BankDescription=x.Bank.BankaAdi,
                BankAccountId=x.BankAccountId,
                BankAccountCode=x.BankAccount.Kod,
                BankAccountName=x.BankAccount.HesapAdi,
                DocumentTypeId = x.DocumentTypeId,
                DocumentTypeDescription=x.DocumentType.EvrakTurAdi,
                DiscountTypeId = x.DiscountTypeId,
                TransportTypeId = x.TransportTypeId,
                DeliveryTypeId = x.DeliveryTypeId,
                Vase = x.Vase,
                ExchangeRate = x.ExchangeRate,
                FirstDiscount = x.FirstDiscount,
                SecondDiscount = x.SecondDiscount,
                Subject = x.Subject,
                DocumentDate = x.DocumentDate,
                DeliveryDate = x.DeliveryDate,
                PurchaseOrderNote=x.PurchaseOrderNote,
                PurchaseOrderDescription=x.PurchaseOrderDescription,
               // WithHoldingRate=x.wi
               //DiscountTypeDescription=x.Dis
                Durum = x.Durum
            });
            purchaseOrder.CompanyAddressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x => x.CompanyId == purchaseOrder.CompanyId).ToList();
            purchaseOrder.CompanyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x => x.CompanyId == purchaseOrder.CompanyId).ToList();

            purchaseOrder.CompanyAddress = purchaseOrder.CompanyAddressItems?.Where(x => x.Id == purchaseOrder.CompanyAddressItemId)?.FirstOrDefault()?.EntireAddress;
            var CompanyContact = purchaseOrder.CompanyContactItems?.Where(x => x.Id == purchaseOrder.CompanyContactItemId)?.FirstOrDefault();

            purchaseOrder.CompanyContactName = CompanyContact?.ContactFullName;
            purchaseOrder.CompanyContactEMail = CompanyContact?.ContactEMail;
            purchaseOrder.CompanyContactMobilePhone = CompanyContact?.ContactPhoneNumber;


            purchaseOrder.DeliveryAddressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x => x.CompanyId == purchaseOrder.CompanyId).ToList();
            purchaseOrder.DeliveryCompanyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x => x.CompanyId == purchaseOrder.CompanyId).ToList();

            purchaseOrder.DeliveryAddress = purchaseOrder.DeliveryAddressItems?.Where(x => x.Id == purchaseOrder.DeliveryCompanyAddressId)?.FirstOrDefault()?.EntireAddress;
            var deliveryCompanyContact = purchaseOrder.DeliveryCompanyContactItems?.Where(x => x.Id == purchaseOrder.DeliveryCompanyContactItemId)?.FirstOrDefault();

            purchaseOrder.DeliveryCompanyContactName = deliveryCompanyContact?.ContactFullName;
            purchaseOrder.DeliveryCompanyContactEMail = deliveryCompanyContact?.ContactEMail;
            purchaseOrder.DeliveryCompanyContactMobilePhone = deliveryCompanyContact?.ContactPhoneNumber;

            return purchaseOrder;
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<PurchaseOrder, bool>> filter)
        {
            return BaseList(filter,x=> new
            {
                order=x,
                contact=x.Company.CompanyContactItems.Where(y=>y.IsDefault).Select(y=> new
                {
                    name=y.ContactFullName,
                    mobile=y.ContactPhoneNumber,
                    eMail=y.ContactEMail
                }).FirstOrDefault(),

            }).Select(x => new PurchaseOrderL
            {
                Id = x.order.Id,
                Kod=x.order.Kod,
                CompanyNameOrdered=x.order.Company.CariAdi,
                DocumentDate=x.order.DocumentDate,
                DeliveryCompanyDescription=x.order.DeliveryCompany.CariAdi,
                DeliveryDate=x.order.DeliveryDate,
                PaymentMethodDescription=x.order.PaymentMethod.PaymentMetheodDescription,
                Vase=x.order.Vase,
                CurrencyDescription=x.order.Currency.DovizAdi,
                BankAccountId=x.order.BankAccountId,
                BankAccountCode=x.order.BankAccount.Kod,
                BankAccountName=x.order.BankAccount.HesapAdi,
                BankDescription=x.order.Bank.BankaAdi,
                PurchaseOrderDescription=x.order.PurchaseOrderDescription,
                PurchaseOrderNote=x.order.PurchaseOrderNote,
                DeliveryCompanyContactName=x.contact.name,
                DeliveryCompanyContactMobilePhone=x.contact.mobile,
                DeliveryCompanyContactEMail=x.contact.eMail,
                CompanyContactName=x.order.CompanyContactItem.ContactFullName,
                CompanyContactEMail=x.order.CompanyContactItem.ContactEMail,
                CompanyContactMobilePhone=x.order.CompanyContactItem.ContactPhoneNumber,
            }).ToList();
        }

    }
}

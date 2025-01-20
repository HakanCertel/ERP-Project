using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto.SalesDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General.SalesBll
{
    public class SalesOfferBll : BaseGenelBll<SalesOffer>, IBaseGenelBll, IBaseCommonBll
    {
        public SalesOfferBll() : base(KartTuru.SalesOffer) { }

        public SalesOfferBll(Control ctrl) : base(ctrl, KartTuru.SalesOffer) { }

        public override BaseEntity Single(Expression<Func<SalesOffer, bool>> filter)
        {
            var salesOffer = BaseSingle(filter, x => new SalesOfferS
            {
                Id = x.Id,
                Kod = x.Kod,
                CompanyId = x.CompanyId,
                CompanyNameOrdered = x.Company.CariAdi,
                CompanyAddressItemId = x.CompanyAddressItemId,
                CompanyContactItemId = x.CompanyContactItemId,
                CompanyPriceListId = x.CompanyPriceListId,
                DeliveryCompanyId = x.DeliveryCompanyId,
                DeliveryCompanyCode = x.DeliveryCompany.Kod,
                DeliveryCompanyDescription = x.DeliveryCompany.CariAdi,
                DeliveryCompanyAddressId = x.DeliveryCompanyAddressId,
                DeliveryCompanyContactItemId = x.DeliveryCompanyContactItemId,
                DeliveryDate = x.DeliveryDate,
                DemandedDate=x.DemandedDate,
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
                SalesOfferNote = x.SalesOfferNote,
                SalesOfferDescription = x.SalesOfferDescription,
                // WithHoldingRate=x.wi
                //DiscountTypeDescription=x.Dis
                Durum = x.Durum,
                PriceListId=x.PriceListId
            });
            salesOffer.CompanyAddressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x => x.CompanyId == salesOffer.CompanyId).ToList();
            salesOffer.CompanyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x => x.CompanyId == salesOffer.CompanyId).ToList();

            salesOffer.CompanyAddress = salesOffer.CompanyAddressItems?.Where(x => x.Id == salesOffer.CompanyAddressItemId)?.FirstOrDefault()?.EntireAddress;
            var CompanyContact = salesOffer.CompanyContactItems?.Where(x => x.Id == salesOffer.CompanyContactItemId)?.FirstOrDefault();

            salesOffer.CompanyContactName = CompanyContact?.ContactFullName;
            salesOffer.CompanyContactEMail = CompanyContact?.ContactEMail;
            salesOffer.CompanyContactMobilePhone = CompanyContact?.ContactPhoneNumber;


            salesOffer.DeliveryAddressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x => x.CompanyId == salesOffer.CompanyId).ToList();
            salesOffer.DeliveryCompanyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x => x.CompanyId == salesOffer.CompanyId).ToList();

            salesOffer.DeliveryAddress = salesOffer.DeliveryAddressItems?.Where(x => x.Id == salesOffer.DeliveryCompanyAddressId)?.FirstOrDefault()?.EntireAddress;
            var deliveryCompanyContact = salesOffer.DeliveryCompanyContactItems?.Where(x => x.Id == salesOffer.DeliveryCompanyContactItemId)?.FirstOrDefault();

            salesOffer.DeliveryCompanyContactName = deliveryCompanyContact?.ContactFullName;
            salesOffer.DeliveryCompanyContactEMail = deliveryCompanyContact?.ContactEMail;
            salesOffer.DeliveryCompanyContactMobilePhone = deliveryCompanyContact?.ContactPhoneNumber;

            return salesOffer;
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<SalesOffer, bool>> filter)
        {
            return BaseList(filter, x => new
            {
                salesOffer = x,
                contact = x.Company.CompanyContactItems.Where(y => y.IsDefault).Select(y => new
                {
                    name = y.ContactFullName,
                    mobile = y.ContactPhoneNumber,
                    eMail = y.ContactEMail
                }).FirstOrDefault(),

            }).Select(x => new SalesOfferL
            {
                Id = x.salesOffer.Id,
                Kod = x.salesOffer.Kod,
                CompanyId = x.salesOffer.CompanyId,
                DeliveryCompanyId = x.salesOffer.DeliveryCompanyId,
                SerialNo = x.salesOffer.SerialNo,
                SequenceNo = x.salesOffer.SequenceNo,
                CompanyNameOffered = x.salesOffer.Company.CariAdi,
                DocumentDate = x.salesOffer.DocumentDate,
                DeliveryCompanyName= x.salesOffer.DeliveryCompany.CariAdi,
                PaymentMethodDescription = x.salesOffer.PaymentMethod.PaymentMetheodDescription,
                Vase = x.salesOffer.Vase,
                CurrencyDescription = x.salesOffer.Currency.DovizAdi,
                BankAccountId = x.salesOffer.BankAccountId,
                BankAccountCode = x.salesOffer.BankAccount.Kod,
                BankAccountName = x.salesOffer.BankAccount.HesapAdi,
                BankDescription = x.salesOffer.Bank.BankaAdi,
                SalesOfferDescription = x.salesOffer.SalesOfferDescription,
                SalesOfferNote = x.salesOffer.SalesOfferNote,
                CompanyContactName = x.salesOffer.CompanyContactItem.ContactFullName,
                CompanyContactMobilePhone = x.salesOffer.CompanyContactItem.ContactPhoneNumber,
                CompanyContactEMail = x.salesOffer.CompanyContactItem.ContactEMail,
                Location=x.salesOffer.Company.Location,
                PriceListId=x.salesOffer.PriceListId,
                PriceListName=x.salesOffer.PriceList.Description
            }).ToList();
        }

    }
}
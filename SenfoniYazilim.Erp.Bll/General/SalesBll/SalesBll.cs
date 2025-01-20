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
    public class SalesBll : BaseGenelBll<Sales>, IBaseGenelBll, IBaseCommonBll
    {
        public SalesBll() : base(KartTuru.Sales) { }

        public SalesBll(Control ctrl) : base(ctrl, KartTuru.Sales) { }

        public override BaseEntity Single(Expression<Func<Sales, bool>> filter)
        {
            var sales = BaseSingle(filter, x => new SalesS
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
                DemandedDate = x.DemandedDate,
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
                SalesNote = x.SalesNote,
                SalesDescription = x.SalesDescription,
                // WithHoldingRate=x.wi
                //DiscountTypeDescription=x.Dis
                Durum = x.Durum,
                SaleCreatingMethod = x.SaleCreatingMethod,
                PriceListId = x.PriceListId,
                PriceListName = x.PriceList.Description,
            });

            sales.CompanyAddressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x => x.CompanyId == sales.CompanyId).ToList();
            sales.CompanyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x => x.CompanyId == sales.CompanyId).ToList();

            sales.CompanyAddress = sales.CompanyAddressItems?.Where(x => x.Id == sales.CompanyAddressItemId)?.FirstOrDefault()?.EntireAddress;
            var CompanyContact = sales.CompanyContactItems?.Where(x => x.Id == sales.CompanyContactItemId)?.FirstOrDefault();
            sales.CompanyContactName = CompanyContact?.ContactFullName;
            sales.CompanyContactEMail = CompanyContact?.ContactEMail;
            sales.CompanyContactMobilePhone = CompanyContact?.ContactPhoneNumber;


            sales.DeliveryAddressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x => x.CompanyId == sales.CompanyId).ToList();
            sales.DeliveryCompanyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x => x.CompanyId == sales.CompanyId).ToList();

            sales.DeliveryAddress = sales.DeliveryAddressItems?.Where(x => x.Id == sales.DeliveryCompanyAddressId)?.FirstOrDefault()?.EntireAddress;
            var deliveryCompanyContact = sales.DeliveryCompanyContactItems?.Where(x => x.Id == sales.DeliveryCompanyContactItemId)?.FirstOrDefault();

            sales.DeliveryCompanyContactName = deliveryCompanyContact?.ContactFullName;
            sales.DeliveryCompanyContactEMail = deliveryCompanyContact?.ContactEMail;
            sales.DeliveryCompanyContactMobilePhone = deliveryCompanyContact?.ContactPhoneNumber;

            return sales;
        }
        
        public override IEnumerable<BaseEntity> List(Expression<Func<Sales, bool>> filter)
        {
            return BaseList(filter, x => new
            {
                sales = x,
                contact = x.Company.CompanyContactItems.Where(y => y.IsDefault).Select(y => new
                {
                    name = y.ContactFullName,
                    mobile = y.ContactPhoneNumber,
                    eMail = y.ContactEMail
                }).FirstOrDefault(),

            }).Select(x => new SalesL
            {
                Id = x.sales.Id,
                Kod = x.sales.Kod,
                CompanyId = x.sales.CompanyId,
                DeliveryCompanyId = x.sales.DeliveryCompanyId,
                SerialNo = x.sales.SerialNo,
                SequenceNo = x.sales.SequenceNo,
                CompanyNameOffered = x.sales.Company.CariAdi,
                DocumentDate = x.sales.DocumentDate,
                DeliveryCompanyName = x.sales.DeliveryCompany.CariAdi,
                PaymentMethodDescription = x.sales.PaymentMethod.PaymentMetheodDescription,
                Vase = x.sales.Vase,
                CurrencyDescription = x.sales.Currency.DovizAdi,
                BankAccountId = x.sales.BankAccountId,
                BankAccountCode = x.sales.BankAccount.Kod,
                BankAccountName = x.sales.BankAccount.HesapAdi,
                BankDescription = x.sales.Bank.BankaAdi,
                SalesDescription = x.sales.SalesDescription,
                SalesNote = x.sales.SalesNote,
                CompanyContactName=x.sales.CompanyContactItem.ContactFullName,
                CompanyContactMobilePhone=x.sales.CompanyContactItem.ContactPhoneNumber,
                CompanyContactEMail=x.sales.CompanyContactItem.ContactEMail,
                DeliveryCompanyContactName = x.sales.DeliveryCompanyContactItem.ContactFullName,
                DeliveryCompanyContactMobilePhone = x.sales.DeliveryCompanyContactItem.ContactPhoneNumber,
                DeliveryCompanyContactEMail = x.sales.DeliveryCompanyContactItem.ContactEMail,
                Location = x.sales.Company.Location,
            }).ToList();
        }

    }
    
    public static class FillEntity
{
    public static SalesS FillItem(this SalesS sales)
    {
        sales.CompanyAddressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x => x.CompanyId == sales.CompanyId).ToList();
        sales.CompanyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x => x.CompanyId == sales.CompanyId).ToList();

        sales.CompanyAddress = sales.CompanyAddressItems?.Where(x => x.Id == sales.CompanyAddressItemId)?.FirstOrDefault()?.EntireAddress;
        var CompanyContact = sales.CompanyContactItems?.Where(x => x.Id == sales.CompanyContactItemId)?.FirstOrDefault();
        //sales.CompanyAddress = GetAnySingleOrListBll.GetCompanyAddressItem(x => x.Id == sales.CompanyAddressItemId)?.EntireAddress;
        //var CompanyContact = GetAnySingleOrListBll.GetCompanyContactItem(x => x.Id == sales.CompanyContactItemId);

        sales.CompanyContactName = CompanyContact?.ContactFullName;
        sales.CompanyContactEMail = CompanyContact?.ContactEMail;
        sales.CompanyContactMobilePhone = CompanyContact?.ContactPhoneNumber;


        sales.DeliveryAddressItems = GetAnySingleOrListBll.ListCompanyAddressItem(x => x.CompanyId == sales.CompanyId).ToList();
        sales.DeliveryCompanyContactItems = GetAnySingleOrListBll.ListCompanyContactItems(x => x.CompanyId == sales.CompanyId).ToList();

        sales.DeliveryAddress = sales.DeliveryAddressItems?.Where(x => x.Id == sales.DeliveryCompanyAddressId)?.FirstOrDefault()?.EntireAddress;
        var deliveryCompanyContact = sales.DeliveryCompanyContactItems?.Where(x => x.Id == sales.DeliveryCompanyContactItemId)?.FirstOrDefault();

        //sales.DeliveryAddress = GetAnySingleOrListBll.GetCompanyAddressItem(x => x.Id == sales.DeliveryCompanyAddressId)?.EntireAddress;
        //var deliveryCompanyContact = GetAnySingleOrListBll.GetCompanyContactItem(x => x.Id == sales.DeliveryCompanyContactItemId);

        sales.DeliveryCompanyContactName = deliveryCompanyContact?.ContactFullName;
        sales.DeliveryCompanyContactEMail = deliveryCompanyContact?.ContactEMail;
        sales.DeliveryCompanyContactMobilePhone = deliveryCompanyContact?.ContactPhoneNumber;

        return sales;
    }
}
}
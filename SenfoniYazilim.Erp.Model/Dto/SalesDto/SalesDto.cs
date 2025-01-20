using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Company;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.SalesDto
{
    [NotMapped]
    public class SalesS : Sales
    {
        public string PaymentMethodCode { get; set; }
        public string PaymentMethodDescription { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyDescription { get; set; }
        public decimal WithHoldingRate { get; set; }
        public string WithHoldingRateDescription { get; set; }
        public string BankCode { get; set; }
        public string BankDescription { get; set; }
        public string BankAccountCode { get; set; }
        public string BankAccountName { get; set; }
        public string CompanyNameOrdered { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyContactName { get; set; }
        public string CompanyContactMobilePhone { get; set; }
        public string CompanyContactEMail { get; set; }
        public ICollection<AddressItems> CompanyAddressItems { get; set; }
        public ICollection<CompanyContact> CompanyContactItems { get; set; }
        public string DeliveryCompanyCode { get; set; }
        public string DeliveryCompanyDescription { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryCompanyContactName { get; set; }
        public string DeliveryCompanyContactMobilePhone { get; set; }
        public string DeliveryCompanyContactEMail { get; set; }
        public ICollection<AddressItems> DeliveryAddressItems { get; set; }
        public ICollection<CompanyContact> DeliveryCompanyContactItems { get; set; }
        public string DocumentTypeDescription { get; set; }
        public string DiscountTypeDescription { get; set; }
        public string TransportTypeDescription { get; set; }
        public string DeliveryTypeDescription { get; set; }
        public string PriceListName { get; set; }
    }
    [NotMapped]
    public class SalesL : BaseEntity
    {
        public int? PaymentMethodId { get; set; }
        public long CurrencyId { get; set; }
        public long? ProjectId { get; set; }
        public long OrderCreatorId { get; set; }
        public long? UpdatingOrder { get; set; }
        public int? WithHoldingRateId { get; set; }//tevkifat tablosu tanımlanacak sonrasında bağlantısı sağlanacak
        public long? BankId { get; set; }
        public long? BankAccountId { get; set; }
        public string BankAccountCode { get; set; }
        public string BankAccountName { get; set; }
        public long? CompanyContactId { get; set; }//firma ilgilisinin iletişim bilgileride bu formda yer almalı
        public long? CountryId { get; set; }
        public int DocumentTypeId { get; set; }
        public int? DiscountTypeId { get; set; }
        public int TransportTypeId { get; set; }
        public int DeliveryTypeId { get; set; }
        public int Vase { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal FirstDiscount { get; set; }
        public decimal SecondDiscount { get; set; }
        public string Subject { get; set; }
        public string SerialNo { get; set; }
        public string SequenceNo { get; set; }
        public string SalesDescription { get; set; }
        public string SalesNote { get; set; }
        public DateTime CreatingDate { get; set; }
        public DateTime UpdatingDate { get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public string PaymentMethodCode { get; set; }
        public string PaymentMethodDescription { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyDescription { get; set; }
        public int WithHoldingRate { get; set; }
        public string WithHoldingRateDescription { get; set; }
        public string BankCode { get; set; }
        public string BankDescription { get; set; }
        public long? DeliveryCompanyId { get; set; } //Varsayılan Olarak şirket bilgileri ve ıd si alınabilir
        public string DeliveryCompanyCode { get; set; }
        public string DeliveryCompanyName { get; set; }
        public long CompanyId { get; set; }
        public string CompanyNameOffered { get; set; }
        public string CompanyContactName { get; set; }
        public string CompanyContactMobilePhone { get; set; }
        public string CompanyContactEMail { get; set; }
        public string DeliveryCompanyContactName { get; set; }
        public string DeliveryCompanyContactMobilePhone { get; set; }
        public string DeliveryCompanyContactEMail { get; set; }
        public string DocumentTypeDescription { get; set; }
        public string DiscountTypeDescription { get; set; }
        public string TransportTypeDescription { get; set; }
        public string DeliveryTypeDescription { get; set; }

        public Location Location { get; set; }
    }
}

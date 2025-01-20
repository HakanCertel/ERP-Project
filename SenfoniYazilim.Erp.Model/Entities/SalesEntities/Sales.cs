using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Company;
using SenfoniYazilim.Erp.Model.Entities.PriceListEntities;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities.SalesEntities
{
    public class Sales : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [ZorunluAlan("Firma Bilgisi", "txtCompanyName")]
        public long CompanyId { get; set; }
        public int? CompanyAddressItemId { get; set; }
        public int? CompanyContactItemId { get; set; }
        public long? CompanyPriceListId { get; set; }
        public long? DeliveryCompanyId { get; set; }
        public int? DeliveryCompanyAddressId { get; set; }
        public int? DeliveryCompanyContactItemId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? DemandedDate { get; set; }
        public long? CurrencyId { get; set; }
        public long? ProjectId { get; set; }
        public long CreatorId { get; set; }
        public long? UpdatingUserId { get; set; }
        public long? BankId { get; set; }
        public long? BankAccountId { get; set; }
        public long? CountryId { get; set; }
        public int? PaymentMethodId { get; set; }
        public int? WithHoldingRateId { get; set; }//tevkifat tablosu tanımlanacak sonrasında bağlantısı sağlanacak
        public int? DocumentTypeId { get; set; }
        public int? DiscountTypeId { get; set; }
        public int? TransportTypeId { get; set; }
        public int? DeliveryTypeId { get; set; }
        public int? SalesPotencial { get; set; }
        public int Vase { get; set; } = 30;
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
        public SaleCreatingMethod SaleCreatingMethod { get; set; } = SaleCreatingMethod.ChooseMaterial;
        public long? PriceListId { get; set; }

        public Cari Company { get; set; }
        public Cari DeliveryCompany { get; set; }
        public DovizBilgileri Currency { get; set; }
        public CompanyContact DeliveryCompanyContactItem { get; set; }
        public CompanyContact CompanyContactItem { get; set; }
        public EvrakTurleri DocumentType { get; set; }
        public SevkiyatSekilleri TransportType { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public PaymentMethodItems PaymentMethod { get; set; }
        public Banka Bank { get; set; }
        public BankaHesap BankAccount { get; set; }
        public Kullanici Creator { get; set; }
        public Kullanici UpdatingUser { get; set; }
        public PriceList PriceList { get; set; }
    }
}

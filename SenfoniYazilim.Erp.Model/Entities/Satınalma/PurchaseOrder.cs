using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Company;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities.Satınalma
{
    public class PurchaseOrder:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get ; set ; }
        [ZorunluAlan("Firma Bilgisi","txtCompanyName")]
        public long CompanyId { get; set; }
        public int? CompanyAddressItemId { get; set; }
        public int? CompanyContactItemId { get; set; }
        public long? CompanyPriceListId { get; set; }
        public long? DeliveryCompanyId { get; set; }
        public int? DeliveryCompanyAddressId { get; set; }
        public int? DeliveryCompanyContactItemId { get; set; }
        public long? CurrencyId { get; set; }
        public long? ProjectId { get; set; }
        public long  OrderCreatorId { get; set; }
        public long? UpdatingOrder { get; set; }
        public long? BankId { get; set; }
        public long? BankAccountId { get; set; }
        public long? CountryId { get; set; }
        public int? PaymentMethodId { get; set; }
        public int? WithHoldingRateId { get; set; }//tevkifat tablosu tanımlanacak sonrasında bağlantısı sağlanacak
        public int? DocumentTypeId { get; set; }
        public int? DiscountTypeId { get; set; }
        public int? TransportTypeId { get; set; }
        public int? DeliveryTypeId { get; set; }
        //public int? OfferPotencial { get; set; }
        public int Vase { get; set; } = 30;
        public decimal ExchangeRate { get; set; }
        public decimal FirstDiscount { get; set; }
        public decimal SecondDiscount { get; set; }
        public string Subject { get; set; }
        public string SerialNo { get; set; }
        public string SequenceNo { get; set; }
        public PurchaseOrderCreatingMethod PurchaseOrderCreatingMethod { get; set; } = PurchaseOrderCreatingMethod.ChooseMaterial;
        public string PurchaseOrderDescription { get; set; }
        public string PurchaseOrderNote { get; set; }
        public DateTime CreatingDate { get; set; }
        public DateTime UpdatingDate { get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public Cari Company { get; set; }
        public DovizBilgileri Currency { get; set; }
        public Cari DeliveryCompany { get; set; }
        public Cari CompanyContact { get; set; }
        public EvrakTurleri  DocumentType { get; set; }
        public SevkiyatSekilleri TransportType { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public PaymentMethodItems PaymentMethod { get; set; }
        public Banka Bank { get; set; }
        public BankaHesap BankAccount { get; set; }
        public CompanyContact CompanyContactItem { get; set; }
        public ICollection<PurchaseOrderItems> PurchaseOrderItems { get; set; }
    }
}

using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;

namespace SenfoniYazilim.Erp.Model.Entities.SalesEntities
{
    public class SalesOfferItems : BaseHareketEntity
    {
        public long SalesOfferId { get; set; }
        public decimal SalesOfferQty { get; set; }
        public string OfferItemDescription { get; set; }
        public long CreatorId { get; set; }

        public long? CompanyOfferedId { get; set; }
        public long? DeliveryCompanyId { get; set; }

        public long MaterialId { get; set; }
        public long CurrencyId { get; set; }
        public long TaxRateId { get; set; }
        public long UnitOfMaterialOfferId { get; set; }
        public decimal DefaultUnitPrice { get; set; }

        public long? PriceListId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountRate { get; set; }
        public DateTime? DemandedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public byte[] OfferItemFile { get; set; }

        public bool IsCreatedOrder { get; set; }

        public Cari CompanyOffered { get; set; }
        public Cari DeliveryCompany { get; set; }
        public Birim UnitOfMaterialOffer { get; set; }
        public Material Material { get; set; }
        public DovizBilgileri Currency { get; set; }
        public Kdv TaxRate { get; set; }
        public SalesOffer SalesOffer { get; set; }
    }
}

using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;

namespace SenfoniYazilim.Erp.Model.Entities.Satınalma
{
    public class PurchaseOfferItems : BaseHareketEntity
    {
        public long OfferId { get; set; }
        public long  OfferedCompanyId { get; set; }
        public decimal CompanyPriceListCost { get; set; }
        public long MaterialId { get; set; }
        public long UnitOfMaterialOfferedId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal OfferQty { get; set; }
        public DateTime? ValidityStartDate { get; set; }
        public DateTime? ValidityEndDate { get; set; }
        public PurchaseOfferCreatingMethod PurchaseOfferCreatingMethod { get; set; }
        public string OfferItemDescription { get; set; }
        public decimal DiscountRate { get; set; }
        public long CurrencyId { get; set; }
        public long TaxRateId { get; set; }
        public long? PurchaseDemandId { get; set; } 
        public int? PurchaseDemandItemId { get; set; }
        public long? PurchaseOrderId { get; set; }
        public int? PurchaseOrderItemId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public bool IsOfferComfirmed { get; set; }
        public bool IsCreatedOrder { get; set; }
        public bool IsOfferCancel { get; set; }
        public bool IsOfferActive { get; set; } = true;
        public bool IsOfferClosed { get; set; }
        public bool IsOffferLocked { get; set; }

        public Birim UnitOfMaterialOffered { get; set; }
        public Material Material { get; set; }
        public SatinalmaTalep PurchaseDemand { get; set; }
        public Kdv TaxRate { get; set; }
        public DovizBilgileri Currency { get; set; }
        public PurchaseDemandItems PurchaseDemandItem { get; set; }
        public Cari OfferedCompany { get; set; }
        public PurchaseOrderItems PurchaseOrderItem { get; set; }
    }
}

using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.WayBillEntities;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using System.Collections.Generic;

namespace SenfoniYazilim.Erp.Model.Entities.Satınalma
{
    public class PurchaseOrderItems:BaseHareketEntity
    {
        public long OwnerFormId { get; set; }
        public long? PurchaseWayBillId { get; set; }
        public int? PurchaseWayBillItemId { get; set; }
        public decimal WayBillQty { get; set; }
        public bool IsCreatedWayBill { get; set; }
        public long? PurchaseDemandId { get; set; }
        public int? PurchaseDemandItemId { get; set; }
        public long? PurchaseOfferId { get; set; }
        public int? PurchaseOfferItemId { get; set; }
        public decimal PurchaseOrderQty { get; set; }
        public string OrderItemDescription { get; set; }
        public long OrderCreatorId { get; set; }

        public long MaterialId { get; set; }
        public long CurrencyId { get; set; }
        public long TaxRateId { get; set; }
        public long UnitOfMaterialOrderedId { get; set; }
        public decimal DefaultUnitPrice { get; set; }

        public decimal UnitPrice { get; set; }
        public decimal DiscountRate { get; set; }
        public DateTime? DemandedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public PurchaseOrderCreatingMethod PurchaseOrderCreatingMethod { get; set; }
        public byte[] OrderItemFile { get; set; }

        public PurchaseOrder OwnerForm { get; set; }
        public PurchaseWayBill PurchaeWayBill { get; set; }
        public PurchaseWayBillItems PurchaseWayBillItem { get; set; }

        public Kdv TaxRate { get; set; }
        public Birim UnitOfMaterialOrdered { get; set; }
        public Material Material { get; set; }

    }
}

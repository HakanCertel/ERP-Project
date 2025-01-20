using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;

namespace SenfoniYazilim.Erp.Model.Entities.SalesEntities
{
    public class SalesItems : BaseHareketEntity
    {
        public long SalesId { get; set; }
        public long? SalesOfferId { get; set; }
        public int? SalesOfferItemId { get; set; }
        public long CreatorId { get; set; }
        //public long? PriceListId { get; set; }
        public long? CompanySalesId { get; set; }
        public long? DeliveryCompanyId { get; set; }
        public decimal SalesQty { get; set; }
        public string SalesItemDescription { get; set; }

        public long MaterialId { get; set; }
        public long CurrencyId { get; set; }
        public long TaxRateId { get; set; }
        public long UnitOfMaterialSalesId { get; set; }
        public decimal DefaultUnitPrice { get; set; }

        public decimal UnitPrice { get; set; }
        public decimal DiscountRate { get; set; }
        public DateTime? DemandedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public byte[] SalesItemFile { get; set; }

        public string PurchaseDemandCode { get; set; }
        public int? PurchaseDemanItemId { get; set; }
        public DateTime? FirstPlanedDate { get; set; }
        public DateTime? FirstComletedDate { get; set; }
        public int? PlanId { get; set; }
        public string DispatchWayBillCode { get; set; }
        public int? DispatchWayBillItemId { get; set; }
        public decimal DispatchedQty { get; set; }
        public SaleProccessStatus SaleProccessStatus { get; set; } = SaleProccessStatus.NoProccess;
        public DateTime? ProccessComletedDate { get; set; }

        public Sales Sales { get; set; }
        public Cari CompanySales { get; set; }
        public Cari DeliveryCompany { get; set; }
        public PurchaseDemandItems PurchaseDemandItem { get; set; }
        public Birim UnitOfMaterialSales { get; set; }
        public Material Material { get; set; }
        public DovizBilgileri Currency { get; set; }
        public Kdv TaxRate { get; set; }
        public KapasiteIhtiyacBilgileri Plan { get; set; }
    }
}


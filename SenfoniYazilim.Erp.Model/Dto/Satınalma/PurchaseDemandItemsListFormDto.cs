using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.Satınalma
{
    [NotMapped]
    public class PurchaseDemandItemsListFormL:PurchaseDemandItems,IBaseHareketEntity
    {
        public int PurchaseDemandItemId { get; set; }
        public string PurchaseOfferDescription { get; set; }
        public string PurchaseOrderDescription { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialUnit { get; set; }
        public long DepoId { get; set; }
        public string DemandedCompanyName { get; set; }
        public string OrderedCompanyName { get; set; }
        public string PurchaseOfferItemDescription { get; set; }
        public string PurchaseOrderItemDescription { get; set; }
        public decimal? StorageStockQty { get; set; }
        public decimal? TotalPurchaseOrderQty { get; set; }
        public decimal? MaxPurchaseOrderQty { get; set; }
        public decimal? MinPurchaseOrderQty { get; set; }
        public decimal MaxStockQty { get; set; }
        public decimal MinStockQty { get; set; }
        public decimal? PurchaseOfferQty { get; set; }
        public decimal? PurchaseOrderQty { get; set; }
        public decimal? WayBillQty { get; set; }
        public decimal? RemainingOrderQty { get; set; }
        public string CreatorName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatingName { get; set; }
        public DateTime? UpdatingDate { get; set; }
        public string OfferedCompanyName { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.Satınalma
{
    [NotMapped]
    public class PurchaseDemandItemsL: PurchaseDemandItems, IBaseHareketEntity
    {
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string UnitCode { get; set; }
        public string CompanyName { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
    [NotMapped]
    public class EntirePurchaseDemandItems: PurchaseDemandItems , IBaseHareketEntity
    {
        public int PurchaseDemandItemId { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string Unit { get; set; }
        public decimal? StorageStockQty { get; set; }
        public decimal? TotalPurchaseOrderQty { get; set; }
        public decimal? MaxPurchaseOrderQty { get; set; }
        public decimal? MinPurchaseOrderQty { get; set; }
        public decimal? MaxStockQty { get; set; }
        public decimal? MinStockQty { get; set; }
        public decimal? PurchaseOfferQty { get; set; }
        public decimal? PurchaseOrderQty { get; set; }
        public decimal? RemainingOrderQty { get; set; }
        public string CompanyName { get; set; }
        public string RecordingCreator { get; set; }
        public string RecordingUpdateting { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string PurchaseMainDescription { get; set; }
        public string IsCreatedPurchaseOrder { get; set; }
        public string OfferedCompanyName { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

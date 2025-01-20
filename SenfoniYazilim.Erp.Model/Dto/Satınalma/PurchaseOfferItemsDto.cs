using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.Satınalma
{
    [NotMapped]
    public class PurchaseOfferItemL: PurchaseOfferItems, IBaseHareketEntity
    {
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialUnit { get; set; }
        public long DepoId { get; set; }
        public decimal MaxStockQty { get; set; }
        public decimal MinStockQty { get; set; }
        public decimal? StorageStockQty { get; set; }

        public long? DemandedCompanyId { get; set; }
        public int? ConnectedItemsId { get; set; }//tablodaki adını değiştir
        public decimal? DemandQty { get; set; }
        public decimal? ComfirmedQty { get; set; }
        public DateTime? DemandedDate { get; set; }
        public string PurchaseMainDescription { get; set; }
        public string PurchaseDemanItemDescription { get; set; }
        public byte[] DemandFile { get; set; }
        public bool? IsTopDemand { get; set; }

        public string UnitCodeOfOffer { get; set; }
        public string UnitNameOfOffer { get; set; }

        public string OfferedCompanyName { get; set; }
        public decimal? MaxPurchaseOrderQty { get; set; }
        public decimal? MinPurchaseOrderQty { get; set; }

        public string TaxCode { get; set; } = "%20";
        public decimal TaxRateValue { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public decimal NetAmount { get; set; }
        public decimal NetAmountBasedLocalCurrency { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal DiscountedTotalAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TaxAmountBasedLocalCurrency { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalAmountBasedLocalCurrency { get; set; }
        public decimal? RemainingOrderQty { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }   
    }
}

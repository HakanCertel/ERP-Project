using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.SalesDto
{
    [NotMapped]
    public class SalesOfferItemsL:SalesOfferItems, IBaseHareketEntity
    {
        public string OfferCode { get; set; }
        //public long CompanyOfferedId { get; set; }
        //public long? DeliveryCompanyId { get; set; }
        public string CompanyName { get; set; }
        public string DeliveryCompanyName { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialUnit { get; set; }
        public decimal? StorageStockQty { get; set; }
        public long DepoId { get; set; }
        public string CompanyMaterialCod { get; set; }
        public string CompanyMaterialName { get; set; }
        public string CompanyMaterialUnit { get; set; }

        public decimal? MaxSalesQty { get; set; }
        public decimal? MinSalesQty { get; set; }

        public string UnitCodeOfMaterialOffer{ get; set; }
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

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

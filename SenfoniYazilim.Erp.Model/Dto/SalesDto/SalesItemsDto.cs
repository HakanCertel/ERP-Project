using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.SalesDto
{
    [NotMapped]
    public class SalesItemsL : SalesItems, IBaseHareketEntity
    {
        public string SaleCode { get; set; }
        //public long? SalesOfferId { get; set; }
        //public int SalesOfferItemId { get; set; }
        public long? PriceListId { get; set; }
        //public long CompanySalesId { get; set; }
        //public long? DeliveryCompanyId { get; set; }
        public string CompanyName { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialUnit { get; set; }
        public UrunCinsi MaterialType { get; set; }
        public decimal? StorageStockQty { get; set; }
        public long DepoId { get; set; }
        public string CompanyMaterialCod { get; set; }
        public string CompanyMaterialName { get; set; }
        public string CompanyMaterialUnit { get; set; }

        public decimal? MaxSalesQty { get; set; }
        public decimal? MinSalesQty { get; set; }

        public string UnitCodeOfMaterialSales { get; set; }
        public string TaxCode { get; set; }
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

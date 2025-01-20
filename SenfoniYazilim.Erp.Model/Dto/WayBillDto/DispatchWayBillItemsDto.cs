using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.WayBillEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.WayBillDto
{
    [NotMapped]
    public class DispatchWayBillItemsL : DispatchWayBillItems, IBaseHareketEntity
    {
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialUnit { get; set; }

        public string CompanyMaterialCod { get; set; }
        public string CompanyMaterialName { get; set; }
        public string CompanyMaterialUnit { get; set; }

        public string UnitCodeOfProccess { get; set; }
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

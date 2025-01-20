using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class MaterialS : Material
    {
        public string StockCode { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
    }
    public class MaterialL:BaseEntityFeatures
    {
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public long? UnitId { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public long DepoId { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public UrunCinsi UrunCinsi { get; set; }
        public bool Uretilebilir { get; set; }
        public decimal MaxStockQty { get; set; }
        public decimal MinStockQty { get; set; }

        public string FeatureDescription1 { get; set; }
        public string FeatureDescription2 { get; set; }
        public string FeatureDescription3 { get; set; }
        public string FeatureDescription4 { get; set; }
        public string FeatureDescription5 { get; set; }
        public string FeatureDescription6 { get; set; }
        public string FeatureDescription7 { get; set; }
        public string FeatureDescription8 { get; set; }
        public string FeatureDescription9 { get; set; }
        public string FeatureDescription10 { get; set; }
        public string FeatureDescription11 { get; set; }
        public string FeatureDescription12 { get; set; }
        public string FeatureDescription13 { get; set; }
        public string FeatureDescription14 { get; set; }
        public string FeatureDescription15 { get; set; }
        public string FeatureDescription16 { get; set; }
        public string FeatureDescription17 { get; set; }
        public string FeatureDescription18 { get; set; }
        public string FeatureDescription19 { get; set; }
        public string FeatureDescription20 { get; set; }
    }
}

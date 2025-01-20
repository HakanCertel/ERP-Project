using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class WareHouseStockL : WareHouseStocks, IBaseHareketEntity
    {
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public UrunCinsi MaterialType { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }

        public bool Insert { get ; set ; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
    public class WareHouseStockBaseEntityL : BaseEntity
    {
        public long WareHouseId { get; set; }
        public long MaterialId { get; set; }
        public decimal Quantity { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public UrunCinsi MaterialType { get; set; }
        public string UnitCode { get; set; }
    }
}

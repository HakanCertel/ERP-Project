using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class WareHouseStocks:BaseHareketEntity
    {
        public long WareHouseId { get; set; }
        public long MaterialId { get; set; }
        public long UnitId { get; set; }
        public decimal Quantity { get; set; }

        public Material Material { get; set; }
        public WareHouse WareHouse { get; set; }
        public Birim Unit { get; set; }
    }
}

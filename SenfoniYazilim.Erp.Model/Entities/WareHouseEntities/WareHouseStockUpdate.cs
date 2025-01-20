using SenfoniYazilim.Erp.Model.Entities.Base;
using System;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class WareHouseStockUpdate:BaseHareketEntity
    {
        public long WareHouseId { get; set; }
        public long MaterialId { get; set; }
        public long UserId { get; set; }
        public string Unit { get; set; }
        public decimal Quantity { get; set; }
        public decimal NewQuantity { get; set; }
        public DateTime ProccessDate { get; set; }

        public Material Material { get; set; }
        public WareHouse WareHouse { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}

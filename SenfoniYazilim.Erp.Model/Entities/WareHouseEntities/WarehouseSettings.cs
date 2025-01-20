using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities.WareHouseEntities
{
    public class WarehouseSettings:BaseHareketEntity
    {
        public long WarehouseId { get; set; }
        public long UserId { get; set; }
        public bool CanDemand { get; set; }
        public bool CanTransfer { get; set; }
        public KullaniciYetkisi KullaniciYetkisi { get; set; }

        public WareHouse Warehouse { get; set; }
        public Kullanici User { get; set; }
    }
}

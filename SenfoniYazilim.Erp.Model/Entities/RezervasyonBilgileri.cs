using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.Model.ProductionManagmentEntites.MrpEntites;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class RezervasyonBilgileri:BaseHareketEntity
    {
        public long UserId { get; set; }
        public long UpdatingUserId { get; set; }
        public long? OwnerFormId { get; set; }
        public int? OwnerFormItemId { get; set; }
        public string OwnerFromCode { get; set; }
        public string OwnerFromName { get; set; }
        public long MaterialId { get; set; }
        public long WarehouseId { get; set; }
        public long? GrupId { get; set; }
        public string GrupAdi { get; set; }
        public long UnitId { get; set; }
        public string Birim { get; set; }
        public decimal RezervedQty { get; set; }
        public string Description { get; set; }

        public Kullanici User { get; set; }
        public Kullanici UpdatingUser { get; set; }
        public Mrp Siparis { get; set; }
        public Material Material { get; set; }
        public WareHouse Warehouse { get; set; }
        public Birim  Unit { get; set; }
        public OzelKod Grup { get; set; }
    }
}

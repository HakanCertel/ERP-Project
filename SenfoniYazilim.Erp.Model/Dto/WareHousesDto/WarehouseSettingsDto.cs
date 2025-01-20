using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.WareHouseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.WareHousesDto
{
    [NotMapped]
    public class WarehouseSettingsL:WarehouseSettings,IBaseHareketEntity
    {
        public string KullaniciAdiSoyadi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

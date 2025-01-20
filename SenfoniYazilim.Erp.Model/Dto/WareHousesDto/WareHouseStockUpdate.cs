using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class WareHouseStockUpdateL : WareHouseStockUpdate, IBaseHareketEntity
    {
        public string WareHouseCode { get; set; }
        public string WareHouseName { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class RezervasyonBilgileriL : RezervasyonBilgileri, IBaseHareketEntity
    {
        public string UserName { get; set; }
        public string UpdatingUserName { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public decimal TotalRezervedQty { get; set; }
        public decimal TotalMaterialQty { get; set; }
        public decimal OpenQty { get; set; }


        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

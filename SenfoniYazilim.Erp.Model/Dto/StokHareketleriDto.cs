using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class StokHareketleriL:StokHareketleri, IBaseHareketEntity
    {
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string UnitCode { get; set; }
        public string Unitname { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }        
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

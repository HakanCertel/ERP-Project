using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class Istasyon_Makina_Personel_BilgileriL : Istasyon_Makina_Personel_Bilgileri, IBaseHareketEntity
    {
        public string OperasyonAdi { get; set; }
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }
        public string PersonelAdiSoyadi { get; set; }
        public bool KapasiteBagi { get; set; }
        public bool Insert { get ; set ; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

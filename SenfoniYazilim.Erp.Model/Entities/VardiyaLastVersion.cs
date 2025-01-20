using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class VardiyaLastVersion:BaseEntityDurum
    {
        [Required, StringLength(50), Kod("Vardiya Sistem Adı", "txtVardiyaSistemAd"), ZorunluAlan("Vardiya Sistem Adı", "txtVardiyaSistemAd")]
        public string VardiyaAdi { get; set; }
        public int VardiyaSayisi { get; set; } = 1;
    }
}

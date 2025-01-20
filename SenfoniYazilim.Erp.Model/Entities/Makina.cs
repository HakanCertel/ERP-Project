using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Makina:BaseEntityDurum
    {
        public long? OperasyonId { get; set; }

        [Required, StringLength(50), ZorunluAlan("Makina Adı", "txtMakinaAdi")]
        public string MakinaAdi { get; set; }

        public string MakinaTanimi { get; set; }

        public string Istasyon { get; set; }

        public string Aciklama { get; set; }

        public bool IsCapacityBasedWorker { get; set; }

        public Operasyon Operasyon { get; set; }
    }
}

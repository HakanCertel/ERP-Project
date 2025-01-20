using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class OdemeTuru:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("OdemeTuru Adı", "txtOdemeTuruAdi")]
        public string OdemeTuruAdi { get; set; }

        public OdemeTipi OdemeTipi { get; set; } = OdemeTipi.Elden;

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}

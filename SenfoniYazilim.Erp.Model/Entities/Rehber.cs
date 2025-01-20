using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Rehber:BaseEntityDurum
    {       
            [Index("IX_Kod", IsUnique = true)]
            public override string Kod { get; set; }

            [Required, StringLength(50), ZorunluAlan("Rehber Adı soyadı", "txtAdiSoyadi")]
            public string AdiSoyadi { get; set; }

            [StringLength(17)]
            public string Telefon1 { get; set; }

            [StringLength(17)]
            public string Telefon2 { get; set; }

            [StringLength(500)]
            public string Aciklama { get; set; }      
    }
}

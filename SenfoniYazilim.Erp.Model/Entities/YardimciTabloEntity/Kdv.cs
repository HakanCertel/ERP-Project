using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity
{
    public class Kdv:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Required, ZorunluAlan("Kdv Oranı", "txtKdvOran")]
        public decimal KdvOrani { get; set; }
        
        public string Aciklama { get; set; }
    }
}

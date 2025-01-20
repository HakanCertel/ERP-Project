using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class WareHouse:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Depo Adı", "txtDepoAdi"),Kod("Depo Adı", "txtDepoAdi")]
        public string WarehouseName{ get; set; }

        [StringLength(250)]
        public string Description { get; set; }

    }
}

using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Rol : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Rol Adı", "txtRolAdi")]
        public string RolAdi { get; set; }

        public KullaniciYetkisi KullaniciYetkisi { get; set; } = KullaniciYetkisi.Kullanici;

        [StringLength(500)]
        public string Aciklam { get; set; }

    }
}

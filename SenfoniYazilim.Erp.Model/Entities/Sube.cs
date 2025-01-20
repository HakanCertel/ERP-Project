using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Sube:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Şube Adı", "txtSubeAdi")]
        public string SubeAdi { get; set; }

        [StringLength(255)]
        public string Adres { get; set; }
        [ZorunluAlan("Ülke Adı", "txtAdresUlke")]
        public long? AdresUlkeId { get; set; }
        [ZorunluAlan("İl Adı","txtAdresIl")]
        public long AdresIlId { get; set; }
        [ZorunluAlan("İlçe Adı", "txtAdresIlce")]
        public long AdresIlceId { get; set; }
        [StringLength(17)]
        public string Telefon { get; set; }
        [StringLength(17)]
        public string Fax { get; set; }
        [StringLength(32)]
        public string IbanNo { get; set; }
        [Column(TypeName ="image")]
        public byte[] Logo { get; set; }
        [StringLength(300)]
        public string GrupAdi { get; set; }
        public int? SiraNo { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }

        public string DenemeAlani { get; set; }

        public Il AdresIl { get; set; }

        public Ilce AdresIlce { get; set; }

        public Country AdresUlke { get; set; }
    }
}

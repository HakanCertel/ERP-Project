using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity
{
    public class DovizBilgileri: BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Doviz Adı", "txtDovizAdi")]
        public string DovizAdi { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public long KayitKisiId { get; set; }
        public long? GuncelleyenKisiId { get; set; }
        public string Aciklama { get; set; }

        public Kullanici KayitKisi { get; set; }
        public Kullanici GuncelleyenKisi { get; set; }
    }
}

using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Recete:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }
        [Required, ZorunluAlan("Reçete Adı", "txtReceteAdi")]
        public string ReceteAdi { get; set; }
        [Required, ZorunluAlan("Malzeme Kodu", "txtMalzemeKod")]
        public long StokId { get; set; }
        [Required, ZorunluAlan("Depo", "txtReceteDepo")]
        public long DepoId { get; set; }
        [Required, ZorunluAlan("Birim", "txtReceteBirim")]
        public long? ReceteBirimId { get; set; }
        public decimal Miktar { get; set; }
        public bool Varsayılan { get; set; } = true;

        public WareHouse Depo { get; set; }
        //public Birim ReceteBirim { get; set; }
        public Material Stok { get; set; }
        public WareHouse MalzemeDepo { get; set; }
        public Birim MalzemeBirim { get; set; }

        [InverseProperty("Recete")]
        public ICollection<ReceteBilgileri> ReceteBilgileri { get; set; }
        public ICollection<ReceteOperasyonBilgileri> ReceteOperasyonBilgileri { get; set; }
        public ICollection<ReceteOperasyonMakinaBilgileri> ReceteOperasyonMakinaBilgileri { get; set; }
        public ICollection<ReceteMakinaElemaniBilgileri> ReceteMakinaElemaniBilgileri { get; set; }
        public ICollection<MalzemeIhtiyacBilgileri> MalzemeIhtiyacBilgileri { get; set; }
    }
}

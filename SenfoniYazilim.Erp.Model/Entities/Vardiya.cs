using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Vardiya:BaseEntityDurum
    {
        [Required, StringLength(50), Kod("Vardiya Sistem Adı", "txtVardiyaSistemAd"), ZorunluAlan("Vardiya Sistem Adı", "txtVardiyaSistemAd")]
        public string VardiyaAdi { get; set; }
        public int VardiyaSayisi { get; set; } = 1;

        public ICollection<VardiyaBilgileriLastVersion> VardiyaBilgileriLastVersion { get; set; }
        public decimal GunlukKapasite { get; set; }
        public decimal HaftalikKapasite { get; set; }
        //[Required,  Kod("Haftalık Çalışma Gün Sayısı", "txtHaftalikCalismaGunSayisi1"), ZorunluAlan("Haftalık Çalışma Gün Sayısı", "txtHaftalikCalismaGunSayisi1")]
        public int HaftalikCalismaGunSayisi1 { get; set; } = 5;
        //[Required, StringLength(20), Kod("Mesai Başlama Saati", "txtMesaiBaslamaSaati1"), ZorunluAlan("Mesai Başlama Saati", "txtMesaiBaslamaSaati1")]
        public string MesaiBaslamaSaati1 { get; set; }
        //[Required, StringLength(20), Kod("Mesai Bitiş Saati", "txtMesaiBitisSaati1"), ZorunluAlan("Mesai Bitiş Saati", "txtMesaiBitisSaati1")]
        public string MesaiBitisSaati1 { get; set; }
        //[Required, Kod("Mola Süresi", "txtStandartMolaSuresi1"), ZorunluAlan("Mola Süresi", "txtStandartMolaSuresi1")]
        public decimal StandartMolaSuresi1 { get; set; } = 0;


        public int? HaftalikCalismaGunSayisi2 { get; set; } = 5;
        public string MesaiBaslamaSaati2 { get; set; }
        public string MesaiBitisSaati2 { get; set; }
        public decimal StandartMolaSuresi2 { get; set; } = 0;

        public int? HaftalikCalismaGunSayisi3 { get; set; } = 5;
        public string MesaiBaslamaSaati3 { get; set; }
        public string MesaiBitisSaati3 { get; set; }
        public decimal StandartMolaSuresi3 { get; set; } = 0;

        public bool YarimGun1 { get; set; }
        public string YarimBaslamaSaati1 { get; set; }
        public string YarimBitisSaati1 { get; set; }
        public decimal YarimGunMolaSuresi1 { get; set; } = 0;

        public bool YarimGun2 { get; set; }
        public string YarimBaslamaSaati2 { get; set; }
        public string YarimBitisSaati2 { get; set; }
        public decimal YarimGunMolaSuresi2 { get; set; }

        public bool YarimGun3 { get; set; }
        public string YarimBaslamaSaati3 { get; set; }
        public string YarimBitisSaati3 { get; set; }
        public decimal YarimGunMolaSuresi3 { get; set; } = 0;
    }
}

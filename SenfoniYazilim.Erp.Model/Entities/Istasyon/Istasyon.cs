using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Istasyon:BaseEntityDurum
    {
        [Required, StringLength(50), ZorunluAlan("İstasyon Adı", "txtIstasyonAdi")]
        public string IstasyonAdi { get; set; }
        [Required,  ZorunluAlan("Vardiya Sistemi", "txtVardiyaSistemi")]
        public long VardiyaId { get; set; }

        public string Aciklama { get; set; }

        public Vardiya Vardiya { get; set; }

        public ICollection<Istasyon_Makina_Personel_Bilgileri> Istasyon_Makina_Personel_Bilgileri { get; set; }
        public ICollection<IstasyonOperasyonBilgileri> IstasyonOperasyonBilgileri { get; set; }
        public ICollection<Makina_MakinaElemenlari_Bilgileri> Makina_MakinaElemenlari_Bilgileri { get; set; }
    }
}

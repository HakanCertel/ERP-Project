using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class Recete_Bilesen_Operasyon_Makina_Eleman_Sure_BilgileriL: Recete_Bilesen_Operasyon_Makina_Eleman_Sure_Bilgileri
    {
        public string SiparisKodu { get; set; }
        public string SiaprisAdi { get; set; }
        public string IstasyonKodu { get; set; }
        public string IstasyonAdi { get; set; }
        public string OperasyonKodu { get; set; }
        public string OperasyonAdi { get; set; }
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string StokBirim { get; set; }
        public string BagliOlduguUstReceteKodu { get; set; }
        public string BagliOlduguUstReceteAdi { get; set; }
        public string BagliOlduguAnaReceteKodu { get; set; }
        public string BagliOlduguAnaReceteAdi { get; set; }
        public ICollection<ReceteOperasyonBilgileri> ReceteOperasyonBilgileri { get; set; }//****malzeme ihtiyaçlarını oluştururken yardımcı property
        public ICollection<ReceteMakinaElemaniBilgileri> ReceteMakinaElemaniBilgileri { get; set; }//****malzeme ihtiyaçlarını oluştururken yardımcı property
        public ICollection<ReceteOperasyonMakinaBilgileri> ReceteOperasyonMakinaBilgileri { get; set; }//****malzeme ihtiyaçlarını oluştururken yardımcı property
    }
}

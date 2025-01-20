using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.Collections.Generic;

namespace SenfoniYazilim.Erp.Model.Dto
{
    public class ReceteMakinaIstasyonBilgileriL:BaseEntity
    {
        public long OperasyonId { get; set; }
        public string OperasyonAdi { get; set; }
        public long IstasyonId { get; set; }
        public string IstasyonKodu { get; set; }
        public string IstasyonAdi { get; set; }
        public long MakinaId { get; set; }
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }

        public ICollection< Makina_MakinaElemenlari_Bilgileri> Makina_MakinaElemenlari_Bilgileri { get; set; }
    }
}

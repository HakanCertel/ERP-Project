using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class IstasyonOperasyonBilgileriL : IstasyonOperasyonBilgileri, IBaseHareketEntity
    {
        public string OperasyonKodu { get; set; }
        public string OperasyonAdi { get; set; }
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [NotMapped]
    public class MrpMakinaBilgileriL : IstasyonOperasyonBilgileri
    {

        public string IstasyonKodu { get; set; }
        public string IstasyonAdi { get; set; }
        public string OperasyonKodu { get; set; }
        public string OperasyonAdi { get; set; }
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }
        public decimal DonemselKapasite { get; set; }
        public decimal KapasiteIhtiyaci { get; set; }
    }
    public class IstasyonOperasyonBilgileriBaseEntityL : BaseEntity
    {
        public long IstasyonId { get; set; }
        public string IstasyonKodu { get; set; }
        public string IstasyonAdi { get; set; }
        public long OperasyonId { get; set; }
        public string OperasyonKodu { get; set; }
        public string OperasyonAdi { get; set; }
        public long MakinaId { get; set; }
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }
        public ICollection<Makina_MakinaElemenlari_Bilgileri> Makina_MakinaElemenlari_Bilgileri { get; set; }
        public string Aciklama { get; set; }
    }

}

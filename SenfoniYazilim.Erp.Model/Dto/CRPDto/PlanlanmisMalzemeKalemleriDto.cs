using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.CRP;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.CRPDto
{
    [NotMapped]
    public class PlanlanmisMalzemeKalemleriL : PlanlanmisMalzemeKalemleri, IBaseHareketEntity
    {
        public string IsEmriKod { get; set; }
        public string AnaReceteKodu { get; set; }
        public string BagliOlduguUstReceteStokKodu { get; set; }
        public string BagliOlduguUstReceteStokAdi { get; set; }
        public long? DemandId { get; set; }
        public int? DemandItemId { get; set; }
        public string DemandCode { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public string IstasyonKodu { get; set; }
        public string IstasyonAdi { get; set; }
        public string OperasyonKodu { get; set; }
        public string OperasyonAdi { get; set; }
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }
        public string MakinaElemaniKodu { get; set; }
        public string MakinaElemaniAdi { get; set; }
        public decimal? ToplamUretimSuresi { get; set; }
        public decimal KalanSure { get; set; }
        public decimal? AcikMiktar { get; set; }
        public decimal KayitMiktari { get; set; }
        
        public long? CurrentId { get; set; }
        public string CurrentName { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public long? PersonelId { get; set; }
        public string PersonelName { get; set; }
        public string BirimAdi { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

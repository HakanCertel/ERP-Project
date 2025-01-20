using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.ProductionManagmentEntities.UretimSonuKayitEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.ProductionManagmentDto.UretimSonuKayitDto
{
    [NotMapped]
    public class UretimSonuKayitS:UretimSonuKayit
    {
        public string IsEmriKodu { get; set; }
        public decimal IsEmriMiktari { get; set; }
        public decimal UretilenMiktar { get; set; }
        public string CurrentName { get; set; }
        public string UserName { get; set; }
        public string PersonelName { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
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
        public string BirimAdi { get; set; }
        public decimal? OperasyonSuresi { get; set; }
    }
    [NotMapped]
    public class UretimSonuKayitL : UretimSonuKayit
    {
        public string IsEmriKodu { get; set; }
        public decimal IsEmriMiktari { get; set; }
        public string CurrentName { get; set; }
        public string UserName { get; set; }
        public string PersonelName { get; set; }
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
        public string BirimAdi { get; set; }
        public decimal? OperasyonSuresi { get; set; }
    }
}

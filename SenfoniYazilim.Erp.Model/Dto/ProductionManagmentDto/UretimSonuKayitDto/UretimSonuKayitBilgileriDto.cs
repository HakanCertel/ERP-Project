using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class UretimSonuKayitBilgileriL: UretimSonuKayitBilgileri, IBaseHareketEntity
    {
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public string BirimKodu { get; set; }
        public string BirimAdi { get; set; }
        public decimal ToplamMiktar { get; set; }
        public decimal Fark { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

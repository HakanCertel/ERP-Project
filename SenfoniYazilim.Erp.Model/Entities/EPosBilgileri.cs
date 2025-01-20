using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class EPosBilgileri:BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        [Required, StringLength(30)]
        public string Adi { get; set; }
        [Required, StringLength(30)]
        public string Soyadi { get; set; }
        public long BankaId { get; set; }
        public EPosKartTuru KartTuru { get; set; } = EPosKartTuru.Visa;
        [Required, StringLength(50)]
        public string KartNo { get; set; }
        [Required, StringLength(50)]
        public string SonKullanmaTarihi { get; set; }
        [Required, StringLength(50)]
        public string GuvenlikKodu { get; set; }

        public Banka Banka { get; set; }
    }
}

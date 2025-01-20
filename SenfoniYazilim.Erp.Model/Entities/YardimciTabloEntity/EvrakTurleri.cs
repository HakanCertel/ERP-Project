using SenfoniYazilim.Erp.Model.Entities.Base;
using System;

namespace SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity
{
    public class EvrakTurleri:BaseHareketEntity
    {
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string KaydiOlusturan { get; set; }
        public string KaydiGuncelleyen{ get; set; }
        public string EvrakTurAdi { get; set; }
        public string EvrakTurTipi { get; set; }
        public string EvrakTurKodu { get; set; }
        public bool StokEtkilenir { get; set; }
        public bool Durum { get; set; }
        public bool EFaturaOlusturulamaz { get; set; }
    }
}

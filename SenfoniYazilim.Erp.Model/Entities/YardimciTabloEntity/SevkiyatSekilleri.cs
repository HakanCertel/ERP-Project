using SenfoniYazilim.Erp.Model.Entities.Base;
using System;

namespace SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity
{
    public class SevkiyatSekilleri: BaseEntityDurum
    {
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string KaydiOlusturan { get; set; }
        public string KaydiGuncelleyen { get; set; }
        public string SevkiyatSekli { get; set; }
        public string Aciklama { get; set; }
    }
}

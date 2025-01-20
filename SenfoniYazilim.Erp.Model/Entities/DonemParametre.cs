using SenfoniYazilim.Erp.Model.Entities.Base;
using System;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class DonemParametre:BaseEntity
    {
        public long  SubeId { get; set; }
        public long DonemId { get; set; }
        //[Column("date")]
        public DateTime DonemBaslamaTarihi { get; set; } = DateTime.Now.Date;
        //[Column("date")]
        public DateTime DonemBitisTarihi { get; set; } = DateTime.Now.Date;
        //[Column("date")]
        public DateTime EgitimBaslamaTarihi { get; set; } = DateTime.Now.Date;
        //[Column("date")]
        public DateTime EgitimBitisTarihi { get; set; } = DateTime.Now.Date;
        public bool GünTarihininOncesineHizmetBaslamaTarihiGirilebilir { get; set; }
        public bool GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir { get; set; }
        public bool GünTarihininOncesineIptalTarihiGirilebilir { get; set; } = true;
        public bool GünTarihininSonrasinaIptalTarihiGirilebilir { get; set; } = true;
        public bool GünTarihininOncesineMakbuzTarihiGirilebilir { get; set; }
        public bool GünTarihininSonrasinaMakbuzTarihiGirilebilir { get; set; }
        //[Column("date")]
        public DateTime MaksimumTaksitTarihi { get; set; } = DateTime.Now.Date;
        public byte MaksimumTaksitSayisi { get; set; } = 12;
        public bool GittigiOkulZorunlu { get; set; } = true;
        public bool HizmetTahakkukKurusKullan { get; set; }
        public bool IndirimTahakkukKurusKullan { get; set; }
        public bool OdemePlaniKurusKullan { get; set; }
        public bool FaturaTahakkukKurusKullan { get; set; }
        public bool YetkiKontroluAnlikYapilacak { get; set; }

        public Donem Donem { get; set; }
        public Sube Sube { get; set; }
    }
}

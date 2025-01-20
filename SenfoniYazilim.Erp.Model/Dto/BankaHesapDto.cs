using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class BankaHesapS:BankaHesap
    {
        public string BankaAdi { get; set; }

        public string BankaSubeAdi { get; set; }

        public string OzelKod1Adi { get; set; }

        public string OzelKod2Adi { get; set; }
    }

    public class BankaHesapL:BaseEntity
    {
        public string HesapAdi { get; set; }

        public BankaHesapTuru HesapTuru { get; set; }

        public DateTime HesapAcilisTarihi { get; set; } = DateTime.Now.Date;

        public string HesapNo { get; set; }

        public string IbanNo { get; set; }

        public byte BlokeGunSayisi { get; set; }

        public string IsyeriNo { get; set; }

        public string TerminalNo { get; set; }       

        public string OzelKod1Adi { get; set; }

        public string OzelKod2Adi { get; set; }
       
        public string BankaAdi { get; set; }

        public string BankaSubeAdi { get; set; }

        public string Aciklama { get; set; }
    }

}

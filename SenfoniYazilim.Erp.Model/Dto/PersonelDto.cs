﻿using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using DevExpress.DataAccess.ObjectBinding;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class PersonelS:Personel
    {
        public string KimlikIlAdi { get; set; }

        public string KimlikIlceAdi { get; set; }

        public string OzelKod1Adi { get; set; }

        public string OzelKod2Adi { get; set; }

        public string OzelKod3Adi { get; set; }

        public string OzelKod4Adi { get; set; }

        public string OzelKod5Adi { get; set; }
    }

    public class PersonelL:BaseEntity
    {
        public string TcKimlikNo { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public Cinsiyet Cinsiyet { get; set; } 

        public string Telefon { get; set; }

        public KanGrubu KanGrubu { get; set; } 

        public string BabaAdi { get; set; }

        public string AnaAdi { get; set; }

        public string DogumYeri { get; set; }

        public DateTime? DogumTarihi { get; set; }

        public string KimlikSeri { get; set; }
        
        public string KimlikSiraNo { get; set; }

        public string KimlikIlAdi { get; set; }

        public string KimlikIlceAdi { get; set; }

        public string KimlikMahalleKoy { get; set; }

        public string KimlikCiltNo { get; set; }

        public string KimlikAileSiraNo { get; set; }

        public string KimlikBireySiraNo { get; set; }

        public string KimlikVerildiğiYer { get; set; }

        public string KimlikVerilisNedeni { get; set; }

        public string KimlikKayitNo { get; set; }

        public DateTime? KimlikVerilisTarihi { get; set; }
        
        public byte[] Resim { get; set; }

        public string OzelKod1Adi { get; set; }

        public string OzelKod2Adi { get; set; }

        public string OzelKod3Adi { get; set; }

        public string OzelKod4Adi { get; set; }

        public string OzelKod5Adi { get; set; }
    }
    [HighlightedClass]
    public class OgrenciR : IBaseEntity
    {
        public string OgrenciNo { get; set; }

        public string OkulNo { get; set; }

        public string TcKimlikNo { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string AdiSoyadi { get; set; }

        public Cinsiyet Cinsiyet { get; set; }

        public string Telefon { get; set; }

        public KanGrubu KanGrubu { get; set; }

        public string BabaAdi { get; set; }

        public string AnaAdi { get; set; }

        public string DogumYeri { get; set; }

        public DateTime? DogumTarihi { get; set; }

        public string KimlikSeri { get; set; }

        public string KimlikSiraNo { get; set; }

        public string KimlikIlAdi { get; set; }

        public string KimlikIlceAdi { get; set; }

        public string KimlikMahalleKoy { get; set; }

        public string KimlikCiltNo { get; set; }

        public string KimlikAileSiraNo { get; set; }

        public string KimlikBireySiraNo { get; set; }

        public string KimlikVerildiğiYer { get; set; }

        public string KimlikVerilisNedeni { get; set; }

        public string KimlikKayitNo { get; set; }

        public DateTime? KimlikVerilisTarihi { get; set; }

        public DateTime KayitTarihi { get; set; }

        public KayitSekli KayitSekli { get; set; }

        public KayitDurumu KayitDurumu { get; set; }

        public byte[] Resim { get; set; }

        public string Sinif { get; set; }

        public string GeldigiOkul { get; set; }

        public string Kontenjan { get; set; }

        public string Rehber { get; set; }

        public string YabanciDil { get; set; }

        public string Tesfik { get; set; }

        public string DönemAdi { get; set; }

        public string SubeAdi { get; set; }

        public string SubeAdres { get; set; }

        public string SubeAdresIlAdi { get; set; }

        public string SubeAdresIlceAdi { get; set; }

        public string SubeTelefon { get; set; }

        public string SubeFax { get; set; }

        public string SubeIbanNo { get; set; }

        public byte[] SubeLogo { get; set; }

        public IletisimBilgileriR VeliBilgileri { get; set; }

        public IletisimBilgileriR AnneBilgileri { get; set; }

        public IletisimBilgileriR BabaBilgileri { get; set; }

    }
}

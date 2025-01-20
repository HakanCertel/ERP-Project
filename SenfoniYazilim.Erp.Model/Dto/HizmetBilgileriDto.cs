using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using DevExpress.DataAccess.ObjectBinding;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class HizmetBilgileriL:HizmetBilgileri,IBaseHareketEntity
    {
        public string HizmetAdi { get; set; }
        public HizmetTipi HizmetTipi { get; set; }
        public string ServisYeriAdi { get; set; }
        public string IptalNedeniAdi { get; set; }
        public string GittigiOkulAgi { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
    [HighlightedClass]
    public class HizmetBilgileriR
    {
        public string HizmetAdi { get; set; }
        public string ServisYeriAdi { get; set; }
        public DateTime BaslamaTarihi{ get; set; }
        public DateTime IslemTarihi { get; set; }
        public decimal BrutUcret { get; set; }
        public decimal KistDonemDusulenUcret { get; set; }
        public decimal NetUcret { get; set; }
        public int EgitimGunSayisi { get; set; }
        public int AlinanaHizmetGunSayisi { get; set; }
        public int GunlukUcret { get; set; }
        public DateTime? IptalTarihi { get; set; }
        public string IptalNedeniAdi { get; set; }
        public string IptalNedeniAciklama { get; set; }
        public string GittigiOkulAgi { get; set; }
    }
}

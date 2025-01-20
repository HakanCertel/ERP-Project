using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using DevExpress.DataAccess.ObjectBinding;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class IndirimBilgileriL:IndirimBilgileri,IBaseHareketEntity
    {
        public string HizmetAdi { get; set; }
        public string IndirimAdi { get; set; }
        public string IptalNedeniAdi { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
    [HighlightedClass]
    public class IndirimBilgileriR
    {
        public string HizmetAdi { get; set; }
        public string IndirimAdi { get; set; }
        public decimal BrutIndirim { get; set; }
        public decimal KistDonemDusulenIndirim { get; set; }
        public decimal NetIndirim { get; set; }
        public DateTime IslemTarihi{ get; set; }
        public DateTime? IptalTarihi { get; set; }
        public string IptalNedeniAdi { get; set; }
        public string IptalNedeniAciklama { get; set; }
    }
}

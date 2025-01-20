using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Model.Entities.Irsaliye
{
    public class SatinAlmaIrsaliye:BaseEntity
    {
        public long KaydedenKullaniciId { get; set; }
        public long GuncelleyenKullaniciId { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public long FirmaId { get; set; }
        public int EvrakTuruId { get; set; }
        public string Konu { get; set; } = "Satınalma İrsaliyesi";
        public long? ProjeId { get; set; }
        public DateTime EvrakTarihi { get; set; }
        public string SeriNo { get; set; }
        public string SıraNo { get; set; }
        public long? PlasiyerId { get; set; }
        public string Aciklama { get; set; }
        public string Not { get; set; }
        public int OdemeSekliId { get; set; }
        public int TevkifatOraniId { get; set; }
        public int OfvOraniId { get; set; }
        public int DovizId { get; set; }
        public int Kur { get; set; }
        public int IskontoTuruId { get; set; }
        public int BirinciIskonto { get; set; }
        public int IkinciIskonto { get; set; }
        public int NakliyeSekli { get; set; }
        public int MuhasebelestirmeId { get; set; }
        public bool FaturaDurumu { get; set; }

        public Kullanici KaydedenKullanici { get; set; }
        public Kullanici GuncelleyenKullanici { get; set; }
        public Kullanici Plasiyer { get; set; }
        public Cari Firma { get; set; }

        //EvrakTuru,Proje,odemeSekli,TevkifatOrani,OfvOrani,Doviz,IskontoTuru,NakliyeSekli,Muhasebelestirme ilişlileri tanımlanacak
    }
}

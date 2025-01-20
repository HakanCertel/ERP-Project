using SenfoniYazilim.Erp.Model.Entities.Base;
using System;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class MakinaKapasiteKullanımBilgileri:BaseHareketEntity
    {
        public long MakinaId { get; set; }
        public int MrpBilgileriId { get; set; }
        public int MalzemeIhtiyacBilgiId { get; set; }
        public long TalepId { get; set; }
        public string TalepKodu { get; set; }
        public string TalepStatusu { get; set; }
        public long StokId { get; set; }
        public string IsEmriKodu { get; set; }
        public int PlanSira { get; set; }
        public DateTime IhtiyacTarihi { get; set; }
        public DateTime PlanlandigiTarihi { get; set; }
        public decimal PlanlananMiktar { get; set; }
        public decimal ToplamUretilenMiktar { get; set; }
        public decimal KalanMiktar { get; set; }
        public DateTime PlanlananBaslamaTarih { get; set; }
        public DateTime PlanlananBitisTarihi { get; set; }
        public bool Kapandi { get; set; }

        public Material Stok { get; set; }
    }
}

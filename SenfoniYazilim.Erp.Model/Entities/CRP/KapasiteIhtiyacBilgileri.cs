using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.CRP;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.Model.ProductionManagmentEntites.MrpEntites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class KapasiteIhtiyacBilgileri : BaseHareketEntity
    {
        public int MalzemeIhtiyacBilgiId { get; set; }

        public int MrpBilgileriId { get; set; }

        public long StokId { get; set; }

        public long? ReceteId { get; set; }//reçetesi bulunan bir bileşense , bu bileşenin receteId sini saklar

        public long BagliOlduguUstReceteId { get; set; }

        public long? BagliOlduguAnaReceteId { get; set; }//---

        public long? IstasyonId { get; set; }

        public long? OperasyonId { get; set; }

        public long? MakinaId { get; set; }

        public long? MakinaElemaniId { get; set; }

        public long? DepoId { get; set; }

        public long BirimId { get; set; }

        public decimal BirimIhtiyac { get; set; }

        public decimal ToplamIhtiyac { get; set; }

        public decimal BrutIhtiyac { get; set; }

        public decimal NetIhtiyac { get; set; }

        public decimal PlanlananMiktar { get; set; }

        public decimal Kalan { get; set; }

        //public decimal RezerveMiktar { get; set; } = 0;

        public int ReceteSeviyesi { get; set; }

        public int OperasyonSeviyesi { get; set; }

        public decimal OperasyonSuresi { get; set; }

        public decimal HazirlikSuresi { get; set; }

        public decimal DegisimSuresi { get; set; }//-----

        public decimal KapasiteIhtiyaci { get; set; }

        //public int? Sira { get; set; }

        //public bool Bolunen { get; set; }

        public bool  Planlandi { get; set; }

        //public string IsEmriKodu { get; set; }

        //public bool Uretim { get; set; }

        //public bool Kapandi { get; set; }

        //public bool IsTakenToProcess { get; set; }

        //[Column(TypeName ="date")]
        public DateTime TavsiyeEdilenUretimBaslamaTarihi { get; set; }

       // [Column(TypeName = "date")]
        public DateTime IhtiyacTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime PlanlandigiTarih { get; set; }

        [Column(TypeName = "date")]
        public DateTime TahminiTeslimTarihi { get; set; }


        public MalzemeIhtiyacBilgileri MalzemeIhtiyacBilgi { get; set; }

        public MrpBilgileri MrpBilgileri { get; set; }

        public Birim Birim { get; set; }

        public Recete Recete { get; set; }

        public Recete BagliOlduguUstRecete { get; set; }

        public Recete BagliOlduguAnaRecete { get; set; }//---

        public Material Stok { get; set; }

        public Istasyon Istasyon { get; set; }

        public Operasyon Operasyon { get; set; }

        public Makina Makina { get; set; }

        public WareHouse Depo { get; set; }

        //[InverseProperty("KapasiteIhtiyacKalemleri")]
        //public ICollection<PlanlanmisMalzemeKalemleri> PlanlanmisMalzemeKalemleri { get; set; }
    }
}

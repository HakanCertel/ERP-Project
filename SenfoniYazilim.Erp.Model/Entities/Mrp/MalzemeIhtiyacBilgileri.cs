using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.Model.ProductionManagmentEntites.MrpEntites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class MalzemeIhtiyacBilgileri:BaseHareketEntity
    {

        public int MrpBilgileriId { get; set; }

        public long StokId { get; set; }

        public long? ReceteId { get; set; }//reçetesi bulunan bir bileşense , bu bileşenin receteId sini saklar

        public long BagliOlduguUstReceteId { get; set; }

        public long? BagliOlduguAnaReceteId { get; set; }//---

        public long? IstasyonId { get; set; }

        public long? OperasyonId { get; set; }

        public long? MakinaId { get; set; }

        public long? MakinaElemaniId { get; set; }

        public long? PlanlandigiIstasyonId { get; set; }

        public long? PlanlandigiOperasyonId { get; set; }

        public long? PlanlandigiMakinaId { get; set; }

        public long? PlanlandigiMakinaElemaniId { get; set; }

        public long? DepoId { get; set; }

        public long BirimId { get; set; }

        public decimal BirimIhtiyac { get; set; }

        public Uretilebilir Uretilebilir { get; set; }// = Uretilebilir.Tuketim;

        public decimal FireMiktarı { get; set; }

        public decimal ToplamIhtiyac { get; set; }

        public decimal BrutIhtiyac { get; set; }

        public decimal NetIhtiyac { get; set; }

        public decimal PlanlananMiktar { get; set; }

        public decimal Kalan { get; set; }

        public int? ReservationId { get; set; }

        public decimal RezerveMiktar { get; set; } = 0;

        public int ReceteSeviyesi { get; set; }

        public int OperasyonSeviyesi { get; set; }

        public decimal? OperasyonSuresi { get; set; }

        public decimal? HazirlikSuresi { get; set; }

        public decimal? DegisimSuresi { get; set; }//-----

        public decimal? KapasiteIhtiyaci { get; set; }

        public int? Sira { get; set; }

        public bool Bolunen { get; set; }

        public bool  Planlandi { get; set; }

        public string IsEmriKodu { get; set; }

        public bool Uretim { get; set; }

        public bool Kapandi { get; set; }

        public bool IsTakenToProcess { get; set; }
        [Column(TypeName ="date")]
        public DateTime TavsiyeEdilenBaslamaTarihi { get; set; }
        [Column(TypeName = "date")]
        public DateTime TalepTarihi { get; set; }
        //[Column(TypeName = "date")]
        //public DateTime PlanBaslangicTarihi { get; set; }
        //[Column(TypeName = "date")]
        //public DateTime TeslimTarihi { get; set; }

        public MrpProccessStatus MrpProccessStatus { get; set; } = MrpProccessStatus.NoProccess;

        public int? PurchaseDemandItemId { get; set; }

        public MrpBilgileri MrpBilgileri { get; set; }

        //public Recete Recete { get; set; }

        public Recete BagliOlduguUstRecete { get; set; }

        public Recete BagliOlduguAnaRecete { get; set; }//---

        public Birim Birim { get; set; }

        public Material Stok { get; set; }

        public Istasyon Istasyon { get; set; }

        public Operasyon Operasyon { get; set; }

        //public Makina Makina { get; set; }

        //public Makina PlanlandigiMakina { get; set; }

       // public Material MakinaElemani { get; set; }//---

        //public Material PlanlandigiMakinaElemani { get; set; }

        public WareHouse Depo { get; set; }

        //public ReceteBilgileri ReceteBilgileri { get; set; }

        public RezervasyonBilgileri RezervasyonBilgileri { get; set; }

        //[InverseProperty("MalzemeIhtiyacBilgileri")]
        //public ICollection<KapasiteIhtiyacBilgileri> KapasiteIhtiyacBilgileri { get; set; }

    }
}

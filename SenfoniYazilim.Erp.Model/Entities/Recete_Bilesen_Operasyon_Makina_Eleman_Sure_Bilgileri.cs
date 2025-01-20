using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.ProductionManagmentEntites.MrpEntites;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Recete_Bilesen_Operasyon_Makina_Eleman_Sure_Bilgileri:BaseHareketEntity
    {
        public int MrpBilgileriId { get; set; }
        public long SiparisId { get; set; }
        public long İstasyonId { get; set; }
        public long OperasyonId { get; set; }
        public long? MakinaId { get; set; }

        public long StokId { get; set; }

        public long BagliOlduguUstReceteId { get; set; }

        public long BagliOlduguAnaReceteId { get; set; }//---

        public long MakinaElemaniId { get; set; }

        public decimal BirimIhtiyac { get; set; }

        public decimal ToplamIhtiyac { get; set; }

        public int ReceteSeviyesi { get; set; }

        public decimal? OperasyonSuresi { get; set; }

        public decimal? KapasiteIhtiyaci { get; set; }

        public decimal? HazirlikSuresi { get; set; }

        public decimal? DegisimSuresi { get; set; }//-----

        public bool Planlandi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TavsiyeEdilenUretimBaslamaTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IhtiyacTarihi { get; set; }

        public MrpBilgileri MrpBilgileri { get; set; }

        public Recete BagliOlduguUstRecete { get; set; }

        public Recete BagliOlduguAnaRecete { get; set; }//---

        public Material Stok { get; set; }

        public Istasyon Istasyon { get; set; }

        public Operasyon Operasyon { get; set; }

        public Makina Makina { get; set; }

        public Material MakinaElemani { get; set; }//---


        public Mrp Siapris { get; set; }
    }
}

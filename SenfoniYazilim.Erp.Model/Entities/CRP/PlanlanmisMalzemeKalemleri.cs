using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.Model.ProductionManagmentEntites.MrpEntites;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities.CRP
{
    public class PlanlanmisMalzemeKalemleri : BaseHareketEntity
    {
        public int MalzemeIhtiyacBilgiId { get; set; }

        public int MrpBilgileriId { get; set; }

        public int KapasiteIhtiyacKalemId { get; set; }

        public int? IsEmriId { get; set; }

        public string IsEmriKodu { get; set; }

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

        public decimal PlanlananMiktar { get; set; }

        public decimal UretilenMiktar { get; set; }

        public decimal Kalan { get; set; }

        public int ReceteSeviyesi { get; set; }

        public int OperasyonSeviyesi { get; set; }

        public decimal OperasyonSuresi { get; set; }

        public decimal HazirlikSuresi { get; set; }

        public decimal DegisimSuresi { get; set; }//-----

        public decimal KapasiteIhtiyaci { get; set; }

        public int Sira { get; set; }

        public bool PlanKesinlesti { get; set; }

        public IsEmriDurumu IsEmriDurumu { get; set; } = IsEmriDurumu.IslemYapilmadi;

        [Column(TypeName = "date")]
        public DateTime IhtiyacTarihi { get; set; }

        public DateTime PlanTarihi { get; set; }
        //public DateTime TahminiTeslimTarihi { get; set; }
        public DateTime TamamlanmaTarihi { get; set; }

        public MalzemeIhtiyacBilgileri MalzemeIhtiyacBilgi { get; set; }

        public MrpBilgileri MrpBilgileri { get; set; }

        public KapasiteIhtiyacBilgileri KapasiteIhtiyacKalem { get; set; }

        public Birim Birim { get; set; }

        public Material Stok { get; set; }

        public Istasyon Istasyon { get; set; }

        public Operasyon Operasyon { get; set; }

        public Makina Makina { get; set; }

        public Material MakinaElemani { get; set; }//---

        public WareHouse Depo { get; set; }

       // public CalismaEmri IsEmri { get; set; }
    }
}

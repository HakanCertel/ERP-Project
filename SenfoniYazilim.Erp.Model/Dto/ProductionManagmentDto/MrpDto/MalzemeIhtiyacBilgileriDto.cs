using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using DevExpress.DataAccess.ObjectBinding;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using SenfoniYazilim.Erp.Common.Enums;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class MalzemeIhtiyacBilgileriL: MalzemeIhtiyacBilgileri, IBaseHareketEntity,IBaseEntityFilter
    {
        public long MrpId { get; set; }
        public string MrpKod { get; set; }
        public MrpCreatingMethod MrpCreatingMethod { get; set; }
        public string AnaReceteKodu { get; set; }
        public string BagliOlduguUstReceteStokKodu { get; set; }
        public string BagliOlduguUstReceteStokAdi { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public string IstasyonKodu { get; set; }
        public string OperasyonKodu { get; set; }
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }
        public string MakinaElemaniKodu { get; set; }
        public string MakinaElemaniAdi { get; set; }
        public decimal? ToplamUretimSuresi { get; set; }
        public decimal KalanSure { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public decimal? ToplamStokMiktari { get; set; }
        public decimal? ToplamRezerveMiktar { get; set; }
        public decimal? AcikMiktar { get; set; }
        public string BirimAdi { get; set; }
        public decimal KayitMiktari { get; set; }
        public long? DemandId { get; set; }
        public string DemandCode { get; set; }
        public DemandStatus DemandStatu { get; set; }
        public long? CurrentId { get; set; }
        public string CurrentName { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public long? PersonelId { get; set; }
        public string PersonelName { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public bool Filter { get; set; }
    }
    [NotMapped]
    public class MrpMalzemeIhtiyacBilgileriL : MalzemeIhtiyacBilgileri, IBaseHareketEntity
    {
        public string MrpKodu { get; set; }
        public string BagliOlduguUstReceteKodu { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public decimal KalanSure { get; set; }
        public decimal PlanlanacakMiktar { get; set; }
        public decimal ToplamStokMiktari { get; set; }
        public decimal? ToplamRezerveMiktar { get; set; }
        public decimal? AcikMiktar { get; set; }
        public string BirimAdi { get; set; }
        public bool Filtrele { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
    [NotMapped]
    public class MrpMalzemeIhtiyacBilgileriBirlestirL : BaseEntity,IBaseHareketEntity
    {
        public long MrpId { get; set; }
        public string MrpKod { get; set; }
        public string AnaReceteKodu { get; set; }
        public string BagliOlduguUstReceteStokKodu { get; set; }
        public string BagliOlduguUstReceteStokAdi { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public string IstasyonKodu { get; set; }
        public string OperasyonKodu { get; set; }
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }
        public string MakinaElemaniKodu { get; set; }
        public string MakinaElemaniAdi { get; set; }
        public decimal? ToplamUretimSuresi { get; set; }
        public decimal KalanSure { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public decimal? ToplamStokMiktari { get; set; }
        public decimal? ToplamRezerveMiktar { get; set; }
        public decimal? AcikMiktar { get; set; }
        public int MrpBilgileriId { get; set; }
        public string BirimAdi { get; set; }
        public long StokId { get; set; }

        public long? ReceteId { get; set; }

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

        public string Birim { get; set; }

        public decimal BirimIhtiyac { get; set; }

        public decimal ToplamIhtiyac { get; set; }

        public decimal BrutIhtiyac { get; set; }

        public decimal NetIhtiyac { get; set; }

        public decimal KayitMiktari { get; set; }

        public decimal RezerveMiktar { get; set; } = 0;

        public int ReceteSeviyesi { get; set; }

        public int OperasyonSeviyesi { get; set; }

        public decimal? OperasyonSuresi { get; set; }

        public decimal? HazirlikSuresi { get; set; }

        public decimal? DegisimSuresi { get; set; }//-----

        public decimal? KapasiteIhtiyaci { get; set; }

        public int? Sira { get; set; }

        public bool Bolunen { get; set; }

        public bool Planlandi { get; set; }

        public bool Uretim { get; set; }

        public bool Kapandi { get; set; }
        public string IsEmriKodu { get; set; }
        [Column(TypeName = "date")]
        public DateTime TavsiyeEdilenUretimBaslamaTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime IhtiyacTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime PlanlandigiTarih { get; set; }

        [Column(TypeName = "date")]
        public DateTime TahminiTeslimTarihi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public bool Filter { get; set; }
    }

    [HighlightedClass]
    public class AnaMalzemeBilgileriR
    {
        public string MrpKod { get; set; }
        public string AnaReceteKodu { get; set; }
        public string BagliOlduguUstReceteStokKodu { get; set; }
        public string BagliOlduguUstReceteStokAdi { get; set; }
        public string IsEmriKodu { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public string IstasyonKodu { get; set; }
        public string OperasyonKodu { get; set; }
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }
        public string MakinaElemaniKodu { get; set; }
        public string MakinaElemaniAdi { get; set; }
        public decimal? ToplamUretimSuresi { get; set; }
        public decimal KalanSure { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public decimal? ToplamStokMiktari { get; set; }
        public decimal? ToplamRezerveMiktar { get; set; }
        public decimal? AcikMiktar { get; set; }
        public string BirimAdi { get; set; }
        public decimal BirimIhtiyac { get; set; }

        public decimal ToplamIhtiyac { get; set; }

        public decimal BrutIhtiyac { get; set; }

        public decimal NetIhtiyac { get; set; }

        public decimal KayitMiktari { get; set; }

        public decimal RezerveMiktar { get; set; } = 0;

        public int ReceteSeviyesi { get; set; }

        public int OperasyonSeviyesi { get; set; }

        public decimal? OperasyonSuresi { get; set; }

        public decimal? HazirlikSuresi { get; set; }

        public decimal? DegisimSuresi { get; set; }//-----

        public decimal? KapasiteIhtiyaci { get; set; }

        public int? Sira { get; set; }

        public bool Bolunen { get; set; }

        public bool Planlandi { get; set; }

        public bool Uretim { get; set; }

        public bool Kapandi { get; set; }

        [Column(TypeName = "date")]
        public DateTime TavsiyeEdilenUretimBaslamaTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime IhtiyacTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime PlanlandigiTarih { get; set; }

        [Column(TypeName = "date")]
        public DateTime TahminiTeslimTarihi { get; set; }

    }
    [HighlightedClass]
    public class MalzemeIhtiyacBilgileriR
    {
        public string MrpKod { get; set; }
        public string AnaReceteKodu { get; set; }
        public string BagliOlduguUstReceteStokKodu { get; set; }
        public string BagliOlduguUstReceteStokAdi { get; set; }
        public string IsEmriKodu { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public string IstasyonKodu { get; set; }
        public string OperasyonKodu { get; set; }
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }
        public string MakinaElemaniKodu { get; set; }
        public string MakinaElemaniAdi { get; set; }
        public decimal? ToplamUretimSuresi { get; set; }
        public decimal KalanSure { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public decimal? ToplamStokMiktari { get; set; }
        public decimal? ToplamRezerveMiktar { get; set; }
        public decimal? AcikMiktar { get; set; }
        public string Birim { get; set; }

        public decimal BirimIhtiyac { get; set; }

        public decimal ToplamIhtiyac { get; set; }

        public decimal BrutIhtiyac { get; set; }

        public decimal NetIhtiyac { get; set; }

        public decimal KayitMiktari { get; set; }

        public decimal RezerveMiktar { get; set; } = 0;

        public int ReceteSeviyesi { get; set; }

        public int OperasyonSeviyesi { get; set; }

        public decimal? OperasyonSuresi { get; set; }

        public decimal? HazirlikSuresi { get; set; }

        public decimal? DegisimSuresi { get; set; }//-----

        public decimal? KapasiteIhtiyaci { get; set; }

        public int? Sira { get; set; }

        public bool Bolunen { get; set; }

        public bool Planlandi { get; set; }

        public bool Uretim { get; set; }

        public bool Kapandi { get; set; }

        [Column(TypeName = "date")]
        public DateTime TavsiyeEdilenUretimBaslamaTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime IhtiyacTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime PlanlandigiTarih { get; set; }

        [Column(TypeName = "date")]
        public DateTime TahminiTeslimTarihi { get; set; }

    }
}

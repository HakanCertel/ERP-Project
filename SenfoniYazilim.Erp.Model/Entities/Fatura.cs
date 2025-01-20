using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Fatura: BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        [Column(TypeName ="date")]
        public DateTime PlanTarihi { get; set; }
        [Column(TypeName = "money")]
        public decimal PlanTutar { get; set; }
        [Column(TypeName = "money")]
        public decimal PlanIndirimTutar { get; set; }
        [Column(TypeName = "money")]
        public decimal PlanNetTutar { get; set; }
        [StringLength(200)]
        public string Aciklama { get; set; }
        public int? FaturaNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? TahakkukTarih { get; set; }
        [Column(TypeName = "money")]
        public decimal? TahakkukTutar { get; set; }
        [Column(TypeName = "money")]
        public decimal? TahakkukIndirimTutar { get; set; }
        [Column(TypeName = "money")]
        public decimal? TahakkukNetTutar { get; set; }
        public KdvSekli KdvSekli { get; set; }
        public byte? KdvOrani { get; set; }
        [Column(TypeName = "money")]
        public decimal? KdvHaricTutar { get; set; }
        [Column(TypeName = "money")]
        public decimal? KdvTutari { get; set; }
        [Column(TypeName = "money")]
        public decimal? ToplamTutar { get; set; }
        [StringLength(255)]
        public string FaturaAdres { get; set; }
        public long? FaturaAdresIlId { get; set; }
        public long? FaturaAdresiIlceId { get; set; }

        public Tahakkuk Tahakkuk { get; set; }
        public Il FatutraAdresiIl { get; set; }
        public Ilce FatutraAdresiIlce { get; set; }
    }
}

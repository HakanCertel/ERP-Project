using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Model.Entities.CRP
{
    public class CalismaEmri:BaseHareketEntity
    {
        public string Kod { get; set; }

        public int MalzemeIhtiyacBilgiId { get; set; }

        public long StokId { get; set; }

        public long? CurrentId { get; set; }

        public long? ReceteId { get; set; }//reçetesi bulunan bir bileşense , bu bileşenin receteId sini saklar

        public long BagliOlduguUstReceteId { get; set; }

        public long? BagliOlduguAnaReceteId { get; set; }//---

        public long? IstasyonId { get; set; }

        public long? OperasyonId { get; set; }

        public long? MakinaId { get; set; }

        public long? MakinaElemaniId { get; set; }

        public long? DepoId { get; set; }

        public long BirimId { get; set; }

        public decimal IsEmriMiktari { get; set; }

        public decimal UretilenMiktar { get; set; }

        public decimal Kalan { get; set; }

        [Column(TypeName = "date")]
        public DateTime IhtiyacTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime PlanlandigiTarih { get; set; }

        [Column(TypeName = "date")]
        public DateTime TahminiTeslimTarihi { get; set; }

        public DateTime KayitTarihi { get; set; }

        public DateTime IslemTarihi { get; set; }

        public long? DemandId { get; set; }

        public string DemandCode { get; set; }

        public long? UserId { get; set; }

        public MalzemeIhtiyacBilgileri MalzemeIhtiyacBilgi { get; set; }

        public Birim Birim { get; set; }

        public Material Stok { get; set; }

        public Istasyon Istasyon { get; set; }

        public Operasyon Operasyon { get; set; }

        public Makina Makina { get; set; }

        public Material MakinaElemani { get; set; }//---

        public WareHouse Depo { get; set; }

        public Kullanici User { get; set; }
    }
}

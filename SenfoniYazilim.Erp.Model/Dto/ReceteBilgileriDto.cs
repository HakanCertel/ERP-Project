using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class ReceteBilgileriL:ReceteBilgileri, IBaseHareketEntity
    {
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string StokBirim { get; set; }
        public string TuketimDepoAdi { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }

        public long BagliOlduguUstReceteId { get; set; }
        public long BagliOlduguAnaReceteId { get; set; }
        public int ReceteSeviyesi { get; set; }//****malzeme ihtiyaçlarını oluştururken yardımcı property
        public decimal ReceteOlusturulmaMiktari { get; set; }//****malzeme ihtiyaçlarını oluştururken yardımcı property
        public DateTime BitisTarihi { get; set; } = DateTime.Now;//****malzeme ihtiyaçlarını oluştururken yardımcı property
        public string OperasyonAdi { get; set; }//****malzeme ihtiyaçlarını oluştururken yardımcı property
        public decimal? OperasyonSuresi { get; set; }//****malzeme ihtiyaçlarını oluştururken yardımcı property
        public decimal? HazirlikSuresi { get; set; }//****malzeme ihtiyaçlarını oluştururken yardımcı property
        
    }
    [NotMapped]
    public class OperasyonaBagliTuketilecekReceteBilesenBilgileriL : BaseEntity, IBaseHareketEntity
    {
        public decimal Miktar { get; set; }
        public string Birim { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

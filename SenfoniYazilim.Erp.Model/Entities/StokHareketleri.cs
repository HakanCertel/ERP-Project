using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class StokHareketleri:BaseHareketEntity
    {
        public long StokId { get; set; }

        public long DepoId { get; set; }

        public long UnitId { get; set; }

        public long? FormId { get; set; }

        public string FormCode { get; set; }

        public int FormItemId { get; set; }

        public HareketTuru HareketTuru { get; set; }

        public string HareketCinsi { get; set; }

        public DateTime HareketTarihi { get; set; }

        public decimal IslemOncesiStokMiktari { get; set; }

        public decimal IslemMiktari { get; set; }

        public decimal IslemSonrasiStokMiktari { get; set; }


        public Material Stok { get; set; }
        public Birim Unit { get; set; }
        public WareHouse Depo { get; set; }
    }
}

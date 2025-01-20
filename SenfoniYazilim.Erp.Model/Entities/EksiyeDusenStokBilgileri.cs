using SenfoniYazilim.Erp.Model.Entities.Base;
using System;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class EksiyeDusenStokBilgileri:BaseHareketEntity
    {
        public long StokId { get; set; }

        public long DepoId { get; set; }

        public decimal IslemOncesiStokMiktari  { get; set; }

        public decimal IslemMiktari { get; set; }

        public string YapilanIslem { get; set; }

        public decimal? IslemSonrasiStokMiktari { get; set; }

        public DateTime IslemTarihi { get; set; }

        public Material Stok { get; set; }

        public WareHouse Depo { get; set; }
    }
}

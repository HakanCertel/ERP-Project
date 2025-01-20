using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.CRP;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;

namespace SenfoniYazilim.Erp.Model.Entities.ProductionManagmentEntities.UretimSonuKayitEntities
{
    public class UretimSonuKayit:BaseEntityDurum
    {
        public int IsEmriId { get; set; }

        public long UserId { get; set; }

        public long? UpdatingUserId { get; set; }

        public long DepoId { get; set; }

        public long StokId { get; set; }

        public long UnitId { get; set; }

        public long ReceteId { get; set; }

        public decimal IslemMiktari { get; set; }

        public decimal FireMiktari { get; set; }

        public TimeSpan BaslamaZamani { get; set; }

        public TimeSpan BitisZamani { get; set; }

        public DateTime IslemTarihi { get; set; }

        public DateTime EvrakTarihi { get; set; }

        public DateTime? GuncellemeTarihi { get; set; }


        public WorkOrders IsEmri { get; set; }

        public Kullanici User { get; set; }

        public Kullanici UpdatingUser { get; set; }

        public Material Stok { get; set; }

        public WareHouse Depo { get; set; }

        public Birim Unit { get; set; }

    }
}

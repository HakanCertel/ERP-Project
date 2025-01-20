using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.Model.ProductionManagmentEntites.MrpEntites;
using System;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class UretimSonuKayitBilgileri : BaseHareketEntity
    {
        public long UretimSonuKayitId { get; set; }

        public int MalzemeIhtiyacBilgileriId { get; set; }

        public long StokId { get; set; }

        public long DepoId { get; set; }

        public long BirimId { get; set; }

        public decimal BirimIhtiyac { get; set; }

        public decimal KayitMiktari { get; set; }

        public decimal FireMiktari { get; set; }

        public Material Stok { get; set; }

        public WareHouse Depo { get; set; }

        public Birim Birim { get; set; }

    }
}

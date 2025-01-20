using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class ReceteBilgileri:BaseHareketEntity
    {
        public long ReceteId { get; set; }
        public long StokId { get; set; }
        public decimal Miktar { get; set; }
        public decimal FireOrani { get; set; }
        public long? TuketimBirimId { get; set; }
        public string TuketimBirimAdi { get; set; }
        public long TuketimDepoId { get; set; }
        public Uretilebilir Uretilebilir { get; set; }
        public long? OperasyonId { get; set; }
        public int OperasyonBilgileriId { get; set; }

        public Recete Recete { get; set; }
        public Material Stok { get; set; }
        public WareHouse TuketimDepo { get; set; }

        public Birim TuketimBirim { get; set; }
    }
}

using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class IndiriminUygulanacagiHizmetBilgileri:BaseHareketEntity
    {
        public long IndirimId { get; set; }

        public long HizmetId { get; set; }

        public decimal IndirimTutari { get; set; }

        public byte IndirimOrani { get; set; }

        public long SubeId { get; set; }

        public long DonemId { get; set; }

        public Indirim Indirim { get; set; }

        public Sube Sube { get; set; }

        public Donem Donem { get; set; }

        public Hizmet Hizmet { get; set; }
    }
}

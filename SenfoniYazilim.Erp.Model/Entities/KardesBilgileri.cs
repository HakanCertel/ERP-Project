using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class KardesBilgileri:BaseHareketEntity
    {
        public long TahakkukId { get; set; }

        public long KardesTahakkukId { get; set; }

        public Tahakkuk KardesTahakkuk { get; set; }
    }
}

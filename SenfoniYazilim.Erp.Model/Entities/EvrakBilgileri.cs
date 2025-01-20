using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class EvrakBilgileri:BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public long EvrakId { get; set; }
        public Evrak Evrak { get; set; }
    }
}

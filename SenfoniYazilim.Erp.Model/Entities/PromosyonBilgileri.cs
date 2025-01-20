using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class PromosyonBilgileri:BaseHareketEntity
    {
        public long TahakkukId { get; set; }

        public long PromosyonId { get; set; }

        public Promosyon Promosyon { get; set; }
    }
}

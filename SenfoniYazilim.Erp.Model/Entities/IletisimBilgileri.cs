using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class IletisimBilgileri:BaseHareketEntity
    {
        public long TahakkukId { get; set; }

        public long IletisimId { get; set; }

        public long YakinlikId { get; set; }

        public bool Veli { get; set; }

        public AdresTuru? FaturaAdresi { get; set; }

        public Iletisim Iletisim { get; set; }

        public Yakinlik Yakinlik { get; set; }
    }
}

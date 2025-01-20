using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity
{
    public class Features:BaseHareketEntity
    {
        public long DefinationId { get; set; }
        public string Code { get; set; }
        public KartTuru KartTuru { get; set; }
        public string Description { get; set; }

        public Definations Defination { get; set; }
    }
}

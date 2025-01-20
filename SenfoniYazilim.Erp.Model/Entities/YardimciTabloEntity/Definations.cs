using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity
{
    public class Definations:BaseHareketEntity 
    {
        public string Code { get; set; }
        public KartTuru KartTuru { get; set; }
        public string Description { get; set; }
    }
}

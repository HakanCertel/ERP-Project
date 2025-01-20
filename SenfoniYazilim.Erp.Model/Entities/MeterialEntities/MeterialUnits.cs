using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;

namespace SenfoniYazilim.Erp.Model.Entities.MeterialEntities
{
    public class MeterialUnits:BaseHareketEntity
    {
        public long MaterialId { get; set; }
        public long UnitId { get; set; }
        public decimal ConversionRate { get; set; } = 1;

        public Material Material { get; set; }
        public Birim Unit { get; set; }
    }
}

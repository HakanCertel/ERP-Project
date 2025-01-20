using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.MeterialEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.MaterialDtos
{
    [NotMapped]
    public class MaterialUnitL:MeterialUnits,IBaseHareketEntity
    {
        public string MaterialUnitCode { get; set; }
        public string MaterialUnitName { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

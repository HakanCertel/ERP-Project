using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.PriceListEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.PriceListDto
{
    [NotMapped]
    public class PriceListItemsL:PriceListItems,IBaseHareketEntity
    {
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialUnitName { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string PriceListCode { get; set; }
        public string PriceListName { get; set; }
        public string PriceListDescription { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

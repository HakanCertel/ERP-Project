using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.CRP;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.CRPDto
{
    [NotMapped]
    public class WorkOrderMaterialItemsL:WorkOrderMaterialItems,IBaseHareketEntity
    {
        public string OwnerFormCode { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public decimal TotalRequestQty { get; set; }
        public decimal RemainingRequestQty { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

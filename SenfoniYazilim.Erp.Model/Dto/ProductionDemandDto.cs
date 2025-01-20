using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class ProductionDemandS:ProductionDemand
    {
        public string UserName { get; set; }
    }
    public class ProductionDemandL : BaseEntity
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public DateTime OperationDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool IsDone { get; set; }
        public bool IsCanceled { get; set; }
        public string ReasonOfCancel { get; set; }
        public string Description { get; set; }
    }
}

using SenfoniYazilim.Erp.Model.Entities.Base;
using System;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class ProductionDemand:BaseEntityDurum
    {
        public long UserId { get; set; }
        public DateTime OperationDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool IsDone{ get; set; }
        public bool IsCanceled { get; set; }
        public string ReasonOfCancel { get; set; }
        public string Description { get; set; }

        public Kullanici User { get; set; }
    }
}

using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class OrderDemandS : OrderDemand
    {
        public string CurrentCode { get; set; }
        public string CurrentName { get; set; }
        public string PlasiyerCode { get; set; }
        public string PlasiyerName { get; set; }
        public string UserName { get; set; }
    }
    public class OrderDemandL : BaseEntity
    {
        public long CurrentId { get; set; }
        public string CurrentCode { get; set; }
        public string CurrentName { get; set; }
        public long PlasiyerId { get; set; }
        public string PlasiyerCode { get; set; }
        public string PlasiyerName { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public DateTime OperationDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool Status { get; set; }//basenetitydurum classındaki durum property sine denk gelmektedir...
        public bool IsDone { get; set; }
        public bool IsCanceled { get; set; }
        public string ReasonOfCancel { get; set; }
        public string Description { get; set; }
    }
}

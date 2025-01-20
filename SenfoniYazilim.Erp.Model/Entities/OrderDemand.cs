using SenfoniYazilim.Erp.Model.Entities.Base;
using System;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class OrderDemand:BaseEntityDurum
    {
        public long CurrentId { get; set; }
        public long PlasiyerId { get; set; }
        public long UserId { get; set; }
        public DateTime OperationDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool IsDone { get; set; }
        public bool IsCanceled { get; set; }
        public string ReasonOfCancel { get; set; }
        public string Description { get; set; }

        public Kullanici User { get; set; }
        public Cari Current { get; set; }
        public Personel Plasiyer { get; set; }
    }
}

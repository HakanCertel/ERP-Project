using SenfoniYazilim.Erp.Model.Entities.Base;
using System;

namespace SenfoniYazilim.Erp.Model.Entities.Satınalma
{
    public class SatinalmaTalep:BaseEntityDurum
    {
        public long? ProjeId { get; set; }
        public long? PurchaseDemandResponsibilityId { get; set; }
        public long CreatorId { get; set; }
        public long UpdatingId { get; set; }
        public DateTime RecordDate { get; set; }
        public DateTime? UpdatingDate { get; set; }
        public DateTime DocumentDate { get; set; }
        public byte[] File { get; set; }
        public string DemandDescription { get; set; }
        public bool IsLock { get; set; }

        public Kullanici PurchaseDemandResponsibility { get; set; }
        public Kullanici Creator { get; set; }
        public Kullanici Updating { get; set; }
    }
}

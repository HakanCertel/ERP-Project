using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities.Satınalma.PurchaseSettingsEntites
{
    public class PurchaseSettings:BaseEntity
    {
        public bool IsOfferSubjectToApproval { get; set; } = false;
        public bool IsDemandSubjectToApproval { get; set; } = false;
        public bool IsProccessOrderFromDemand { get; set; } = false;
        public bool IsProccessOrderFromOffer { get; set; } = false;
        public bool IsProccessDirectlyOrderFromDemand { get; set; } = false;

    }
}

using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.WayBillEntities;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;

namespace SenfoniYazilim.Erp.Model.Entities.Satınalma
{
    public class PurchaseDemandItems:BaseHareketEntity
    {
        public long OwnerFormId { get; set; }
        public long MaterialId { get; set; }
        public long UnitId { get; set; }
        public long? PurchaseOfferId { get; set; }
        public int? PurchaseOfferItemId { get; set; }
        public long? PurchaseOrderId { get; set; }
        public int? PurchaseOrderItemId { get; set; }
        public long? DemandedCompanyId { get; set; }//OfferL ye ekle
        public int ConnectedItemsId { get; set; }//OfferL ye ekle
        public decimal DemandQty { get; set; }//OfferL ye Ekle
        public decimal ComfirmedQty { get; set; }//OfferL ye ekle
        public DateTime? DemandedDate { get; set; }//OfferL ye Ekle
        public byte[] DemandFile { get; set; }//OfferL ye Ekle
        public string DemandItemDescription { get; set; }
        public string DemandDescription { get; set; }
        public bool IsDemandItemCanceled { get; set; }
        public bool IsCreatedOrder { get; set; }
        public bool IsCreateOffer { get; set; }
        public bool IsTopDemand { get; set; }
        public bool IsTopDemandExisted { get; set; }
        public bool IsPurchaseDemandActive { get; set; } = true;
        public bool IsBlocked { get; set; }
        public long CreatorId { get; set; }
        public string PurchaseState { get; set; }
        public string DemandSource { get; set; }
        public MangerComfirmState OfferComfirmState { get; set; } = MangerComfirmState.NoProccess;
        public MangerComfirmState DemandComfirmState { get; set; } = MangerComfirmState.NoProccess;

        public KartTuru DataSourceCardType { get; set; } = KartTuru.Stok;
        public long? DataSourceFormId { get; set; }
        public int? DataSourceItemId { get; set; }

        public Material Material { get; set; }
        public Cari DemandedCompany { get; set; }
        public SatinalmaTalep OwnerForm { get; set; }
        public Birim Unit { get; set; }
        public PurchaseOffer PurchaseOffer { get; set; }
        public PurchaseOrderItems PurchaseOrderItem { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
    }
}

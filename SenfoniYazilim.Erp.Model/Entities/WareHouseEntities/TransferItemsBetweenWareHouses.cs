using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.WareHouseEntities;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class TransferItemsBetweenWareHouses:BaseHareketEntity
    {
        public long OwnerFormId { get; set; }
        public string OwnerFormCode { get; set; }
        public long? RelatedRecordId { get; set; }
        public string RelatedRecordName { get; set; }
        public int? RezerveRelatedItemId { get; set; }
        public KartTuru DemandSource { get; set; } = KartTuru.TransferDemandBetweenWarehouses;
        public string DemandSourceCode { get; set; }
        public long CreatorUserId { get; set; }
        public long? DemandingUserId { get; set; }
        public long MaterialId { get; set; }
        public long TransferWareHouseId { get; set; }
        public long TransferedWareHouseId { get; set; }
        public decimal DemandedQuantity { get; set; }
        public decimal ComfirmedQuantity { get; set; }
        public decimal TransferedQuantity { get; set; }
        public TransferStatu TransferStatu { get; set; }
        public string UnitCancel { get; set; }
        public long UnitId { get; set; }
        public DateTime? TransferDate{ get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime? DemandedDate { get; set; }
        public bool IsTransfered { get; set; }
        public TransferCreatingMethod TransferCreatingMethod { get; set; }
        public DescriptionOfTransferProccess DescriptionOfTransferProccess { get; set; }

        public Kullanici CreatorUser { get; set; }
        public Personel DemandingUser { get; set; }
        public Material Material { get; set; }
        public Birim Unit { get; set; }

        public TransferBetweenWarehouse OwnerForm { get; set; }
        public WareHouse TransferWareHouse { get; set; }
        public WareHouse TransferedWareHouse { get; set; }
    }
}

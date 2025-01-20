using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace SenfoniYazilim.Erp.Model.Entities.WareHouseEntities
{
    public class TransferBetweenWarehouse:BaseEntityDurum
    {
        [Required,ZorunluAlan("Talep Edilen Depo", "txtTransferWarehouse")]
        public long TransferWarehouseId { get; set; }
        [Required, ZorunluAlan("Talep Eden Depo", "txtTransferedWarehouse")]
        public long TransferedWarehouseId { get; set; }
        public long CreatorUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public long? UpdatingUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? DemandingUserId { get; set; }
        public DateTime? DemandedDate { get; set; }
        public DateTime DocumentDate { get; set; }
        public TransferCreatingMethod TransferCreatingMethod { get; set; } = TransferCreatingMethod.ChooseMaterial;
        public DescriptionOfTransferProccess DescriptionOfTransferProccess { get; set; } = DescriptionOfTransferProccess.TransferDemand;

        public WareHouse TransferWarehouse { get; set; }
        public WareHouse TransferedWarehouse { get; set; }
        public Kullanici CreatorUser { get; set; }
        public Kullanici UpdatingUser { get; set; }
        public Personel DemandingUser { get; set; }
    }
}

using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.WareHouseEntities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.WareHousesDto
{
    [NotMapped]
    public class TransferDemandWarehouseS:TransferBetweenWarehouse
    {
        public string TransferWarehouseCode { get; set; }
        public string TransferWarehouseName { get; set; }
        public string TransferedWarehouseCode { get; set; }
        public string TransferedWarehouseName { get; set; }
        public string DemandingUserName { get; set; }
        public string CreatorUserName { get; set; }
        public string UpdatingUserName { get; set; }
    }

    [NotMapped]
    public class TransferDemandWarehouseL : BaseEntityDurum
    {
        public long TransferWarehouseId { get; set; }
        public string TransferWarehouseName { get; set; }
        public long TransferedWarehouseId { get; set; }
        public string TransferedWarehouseName { get; set; }
        public DateTime DocumentDate { get; set; }
        public long? DemandingUserId { get; set; }
        public string DemandingUserName { get; set; }
        public DateTime? DemandedDate { get; set; }
        public long CreatorUserId { get; set; }
        public string CreatorUserName { get; set; }
        public DateTime CreateDate { get; set; }
        public long? UpdatingUserId { get; set; }
        public string UpdatingUserName { get; set; }
        public DateTime? UpdateDate { get; set; }
        public TransferCreatingMethod TransferCreatingMethod { get; set; }

    }
}

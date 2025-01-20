using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto.WareHousesDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.WareHouseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General.WarehouseBll
{
    public class TransferDemandWarehouseBll : BaseGenelBll<TransferBetweenWarehouse>, IBaseGenelBll, IBaseCommonBll
    {
        public TransferDemandWarehouseBll() : base(KartTuru.TransferDemandBetweenWarehouses) { }

        public TransferDemandWarehouseBll(Control ctrl) : base(ctrl, KartTuru.TransferDemandBetweenWarehouses) { }

        public override BaseEntity Single(Expression<Func<TransferBetweenWarehouse, bool>> filter)
        {
            return BaseSingle(filter, x => new TransferDemandWarehouseS
            {
                Id = x.Id,
                Kod = x.Kod,
                TransferWarehouseId=x.TransferWarehouseId,
                TransferWarehouseCode=x.TransferWarehouse.Kod,
                TransferWarehouseName=x.TransferWarehouse.WarehouseName,
                TransferedWarehouseId=x.TransferedWarehouseId,
                TransferedWarehouseCode=x.TransferedWarehouse.Kod,  
                TransferedWarehouseName=x.TransferedWarehouse.WarehouseName,
                DemandingUserId=x.DemandingUserId,
                DemandingUserName=x.DemandingUser.Adi+" " +x.DemandingUser.Soyadi,  
                CreatorUserId=x.CreatorUserId,
                CreatorUserName=x.CreatorUser.Adi+" "+x.DemandingUser.Soyadi,
                CreateDate=x.CreateDate,
                UpdatingUserId=x.UpdatingUserId,
                UpdatingUserName=x.UpdatingUser.Adi+" "+x.UpdatingUser.Soyadi,
                UpdateDate=x.UpdateDate,
                TransferCreatingMethod=x.TransferCreatingMethod,
                DescriptionOfTransferProccess=x.DescriptionOfTransferProccess,
                DemandedDate=x.DemandedDate,
                DocumentDate=x.DocumentDate,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<TransferBetweenWarehouse, bool>> filter)
        {
            return BaseList(filter, x => new TransferDemandWarehouseL
            {
                Id = x.Id,
                Kod = x.Kod,
                TransferWarehouseId = x.TransferWarehouseId,
                TransferWarehouseName = x.TransferWarehouse.WarehouseName,
                TransferedWarehouseId = x.TransferedWarehouseId,
                TransferedWarehouseName = x.TransferedWarehouse.WarehouseName,
                DemandingUserId = x.DemandingUserId,
                DemandingUserName = x.DemandingUser.Adi + " " + x.DemandingUser.Soyadi,
                CreatorUserId = x.CreatorUserId,
                CreatorUserName = x.CreatorUser.Adi + " " + x.DemandingUser.Soyadi,
                CreateDate = x.CreateDate,
                UpdatingUserId = x.UpdatingUserId,
                UpdatingUserName = x.UpdatingUser.Adi + " " + x.UpdatingUser.Soyadi,
                UpdateDate = x.UpdateDate,
                TransferCreatingMethod = x.TransferCreatingMethod,
                DemandedDate = x.DemandedDate,
                DocumentDate = x.DocumentDate,
                Durum = x.Durum
            }).ToList();
        }
    }
}

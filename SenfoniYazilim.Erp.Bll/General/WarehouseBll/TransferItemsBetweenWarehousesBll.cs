using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class TarnsferItemsBetweenWareHousesBll : BaseHareketBll<TransferItemsBetweenWareHouses, SenfoniErpContext>, IBaseHareketSelectBll<TransferItemsBetweenWareHouses>
    {
        public BaseHareketEntity Single(Expression<Func<TransferItemsBetweenWareHouses, bool>> filter)
        {
            return BaseSingle(filter, x => new TarnsferItemsBetweenWareHousesL
            {
                Id = x.Id,
                OwnerFormId=x.OwnerFormId,
                CreatorUserId=x.CreatorUserId,
                DemandingUserId=x.DemandingUserId,
                DemandingUserName=x.DemandingUser.Adi+" "+x.DemandingUser.Soyadi,
                TransferWareHouseId=x.TransferWareHouseId,
                TransferWareHouseCode=x.TransferWareHouse.Kod,
                TransferWareHouseName=x.TransferWareHouse.WarehouseName,
                TransferedWareHouseId=x.TransferedWareHouseId,
                TransferedWareHouseCode=x.TransferedWareHouse.Kod,
                TransferedWareHousename=x.TransferedWareHouse.WarehouseName,
                TransferDate=x.TransferDate,
                DocumentDate=x.DocumentDate,
                DemandedDate=x.DemandedDate,
                TransferStatu=x.TransferStatu,
                TransferCreatingMethod=x.TransferCreatingMethod,
            });
        }
        public IEnumerable<BaseHareketEntity> List(Expression<Func<TransferItemsBetweenWareHouses, bool>> filter)
        {
            var list= List(filter, x => new
            {
                mib = x,
                remainingQuantity=x.DemandedQuantity-x.TransferedQuantity,
                materialQuantity = x.Material.WareHouseStocks.Where(y => y.MaterialId == x.MaterialId && y.WareHouseId == x.TransferWareHouseId).Select(y => y.Quantity).FirstOrDefault(),
                totalRezerveQuantity= x.Material.RezervasyonBilgileri.Where(y => y.MaterialId == x.MaterialId&&y.WarehouseId==x.TransferWareHouseId).Select(y => y.RezervedQty).Sum(),
                itemRezervedQty = x.Material.RezervasyonBilgileri.Where(y => y.MaterialId == x.MaterialId&&y.OwnerFormItemId==x.RezerveRelatedItemId).Select(y => y.RezervedQty).FirstOrDefault(),
                //demandSourceDescription=x.DemandSource.toName(),
                //kod=x.DemandSource==KartTuru.TransferDemandBetweenWarehouses?x.OwnerForm.Kod:x.OwnerFormCode,
            }).Select( x => new TarnsferItemsBetweenWareHousesL
            {
                Id = x.mib.Id,
                OwnerFormId = x.mib.OwnerFormId,
                OwnerFormCode=x.mib.OwnerForm.Kod,
                CreatorUserId = x.mib.CreatorUserId,
                CreatorUserName=x.mib.CreatorUser.Adi+" "+x.mib.CreatorUser.Soyadi,
                MaterialId = x.mib.MaterialId,
                MaterialCode = x.mib.Material.Kod,
                MaterialName = x.mib.Material.StockName,
                MaterialUnitCode=x.mib.Material.Unit.Kod,
                UnitId=x.mib.UnitId,
                UnitCodeOfTransfer=x.mib.Unit.Kod,
                BirimAdi=x.mib.Unit.BirimAdi,
                TransferWareHouseId = x.mib.TransferWareHouseId,
                TransferWareHouseCode= x.mib.TransferWareHouse.Kod,
                TransferWareHouseName= x.mib.TransferWareHouse.WarehouseName,
                TransferedWareHouseId = x.mib.TransferedWareHouseId,
                TransferedWareHouseCode= x.mib.TransferedWareHouse.Kod,
                TransferedWareHousename= x.mib.TransferedWareHouse.WarehouseName,
                TransferDate= x.mib.TransferDate,
                TransferStatu=x.mib.TransferStatu,
                MaterialQuantity= x.materialQuantity,
                ItemRezervedQyt=x.itemRezervedQty,
                RezerveQuantity= x.totalRezerveQuantity,
                OpenQuantity = x.materialQuantity - x.totalRezerveQuantity,
                DemandedQuantity =x.mib.DemandedQuantity,
                ComfirmedQuantity=x.mib.ComfirmedQuantity,
                TransferedQuantity=x.mib.TransferedQuantity,
                RemainingQuantity=0,
                //RemainingMaterialQuantity=x.materialQuantity-x.remainingQuantity,
                DocumentDate=x.mib.DocumentDate,
                TransferCreatingMethod=x.mib.TransferCreatingMethod,
                DescriptionOfTransferProccess=x.mib.DescriptionOfTransferProccess,
                DemandedDate=x.mib.DemandedDate,
                DemandingUserId=x.mib.DemandingUserId,
                DemandingUserName=x.mib.DemandingUser.Adi+" "+x.mib.DemandingUser.Soyadi,
                IsActive=x.mib.IsActive,
                IsCancel=x.mib.IsCancel,
                IsComfirmed=x.mib.IsComfirmed,
                IsClosed=x.mib.IsClosed,
                RelatedRecordId=x.mib.RelatedRecordId,
                RelatedRecordName=x.mib.RelatedRecordName,
                RezerveRelatedItemId=x.mib.RezerveRelatedItemId,
                DemandSource=x.mib.DemandSource,
                DemandSourceCode=x.mib.DemandSourceCode,
                //RequestQuantity=x.mib.re
            }).ToList();


            return list;
        }
    }
}
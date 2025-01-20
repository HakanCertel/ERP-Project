using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.General.PurchaseBll
{
    public class PurchaseDemandItemsFormBll : BaseHareketBll<PurchaseDemandItems, SenfoniErpContext>, IBaseHareketSelectBll<PurchaseDemandItems>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<PurchaseDemandItems, bool>> filter)
        {
            return List(filter, x => new
            {
                Items = x,
                //materialRelatedCompany=GetAnySingleOrListBll.ListMaterialRelatedCompany(y=>y.CompanyId==x.DemandedCompanyId&&y.MaterialId==x.MaterialId)
                //.Select(y=> new
                //{
                //    maxOrderQty=y.MaxOrderQty,
                //    minOrderQty=y.MinOrderQty
                //}).FirstOrDefault(),
                comfirmedQty=x.IsComfirmed?x.ComfirmedQty:x.DemandQty,
                offerItemDesc = x.PurchaseOffer.PurchaseOfferItems.Where(y => y.Id == x.PurchaseOfferItemId).FirstOrDefault().OfferItemDescription,
                offerItemQty = x.PurchaseOffer.PurchaseOfferItems.Where(y => y.Id == x.PurchaseOfferItemId).FirstOrDefault().OfferQty,
                orderItemQty = x.PurchaseOrder.PurchaseOrderItems.Where(y => y.Id == x.PurchaseOrderItemId).FirstOrDefault().PurchaseOrderQty,
                orderItemDesc = x.PurchaseOrder.PurchaseOrderItems.Where(y => y.Id == x.PurchaseOrderItemId).FirstOrDefault().OrderItemDescription,
                purchaseOrderQty=x.PurchaseOrder.PurchaseOrderItems.Where(y=>y.Id==x.PurchaseOrderItemId).FirstOrDefault().PurchaseOrderQty
            }).Select( x => new PurchaseDemandItemsListFormL
            {
                Id = x.Items.Id,
                IsActive=x.Items.IsActive,
                IsClosed=x.Items.IsClosed,
                IsComfirmed=x.Items.IsComfirmed,
                IsCancel=x.Items.IsCancel,
                OwnerFormId = x.Items.OwnerFormId,
                MaterialId = x.Items.MaterialId,
                PurchaseOfferId=x.Items.PurchaseOfferId,
                PurchaseOrderId = x.Items.PurchaseOrderId,
                PurchaseOrderQty = x.Items.PurchaseOrderItem.PurchaseOrderQty,
                WayBillQty=x.Items.PurchaseOrderItem.WayBillQty,
                DemandedCompanyId = x.Items.DemandedCompanyId,
                PurchaseOfferItemId=x.Items.PurchaseOfferItemId,
                PurchaseOrderItemId = x.Items.PurchaseOrderItemId,
                ConnectedItemsId = x.Items.ConnectedItemsId,

                IsCreatedOrder=x.Items.IsCreatedOrder,
                IsTopDemandExisted = x.Items.IsTopDemandExisted,
                IsTopDemand=x.Items.IsTopDemand,
                IsPurchaseDemandActive = x.Items.IsPurchaseDemandActive,
                IsBlocked = x.Items.IsBlocked,
                IsCreateOffer=x.Items.IsCreateOffer,

                DemandQty = x.Items.DemandQty,
                ComfirmedQty =x.comfirmedQty,
                DemandedDate = x.Items.DemandedDate,
                DemandFile = x.Items.DemandFile,
                DemandDescription = x.Items.DemandDescription,
                DemandItemDescription = x.Items.DemandItemDescription,
                IsDemandItemCanceled=x.Items.IsDemandItemCanceled,
                DemandComfirmState=x.Items.DemandComfirmState,
                OfferComfirmState=x.Items.OfferComfirmState,

                PurchaseDemandItemId = x.Items.Id,
                PurchaseOfferDescription=x.Items.PurchaseOffer.OfferDescription,
                PurchaseOrderDescription=x.Items.PurchaseOrder.PurchaseOrderDescription,
                MaterialCode=x.Items.Material.Kod,
                MaterialName=x.Items.Material.StockName,
                UnitId=x.Items.UnitId,
                MaterialUnit=x.Items.Unit.Kod,
                DepoId=x.Items.Material.DepoId,
                DemandedCompanyName=x.Items.DemandedCompany.CariAdi,
                OrderedCompanyName=x.Items.PurchaseOrder.Company.CariAdi,
                PurchaseOfferItemDescription=x.offerItemDesc,
                PurchaseOrderItemDescription=x.orderItemDesc,
                StorageStockQty = x.Items.Material.WareHouseStocks.Where(y => y.WareHouseId == x.Items.Material.DepoId).Select(y => y.Quantity).FirstOrDefault(),
                TotalPurchaseOrderQty = x.purchaseOrderQty,
                //MaxPurchaseOrderQty = x.materialRelatedCompany==null?0:x.materialRelatedCompany.maxOrderQty,
                //MinPurchaseOrderQty =x.materialRelatedCompany==null? 0:x.materialRelatedCompany.minOrderQty,
                MaxStockQty = x.Items.Material.MaxStockQty,
                MinStockQty = x.Items.Material.MinStockQty,
                PurchaseOfferQty = x.offerItemQty,
                RemainingOrderQty = 0,
                CreatorId=x.Items.CreatorId,
                CreatorName = x.Items.OwnerForm.Creator.Adi,
                CreatedDate=x.Items.OwnerForm.RecordDate,
                UpdatingName = x.Items.OwnerForm.Updating.Adi,
                UpdatingDate = x.Items.OwnerForm.UpdatingDate,
                OfferedCompanyName = x.Items.PurchaseOrder.Company.CariAdi,

                DataSourceCardType=x.Items.DataSourceCardType,
                DataSourceFormId=x.Items.DataSourceFormId,
                DataSourceItemId=x.Items.DataSourceItemId,
            }).ToList();
        }
    }
}
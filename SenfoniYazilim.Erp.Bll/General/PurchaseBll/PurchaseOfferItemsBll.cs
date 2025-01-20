using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class PurchaseOfferItemsBll : BaseHareketBll<PurchaseOfferItems, SenfoniErpContext>, IBaseHareketSelectBll<PurchaseOfferItems>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<PurchaseOfferItems, bool>> filter)
        {
            return List(filter,x => new
            {
                offerItem =x,
                storageStockQty=x.Material.WareHouseStocks.Where(y => y.WareHouseId == x.Material.DepoId).Select(y => y.Quantity).FirstOrDefault(),
                maxOrderQty=x.OfferedCompany.CompanyRelatedMaterials.Where(y=>y.MaterialId==x.MaterialId).Select(y=>y.MaxOrderQty).FirstOrDefault(),
                minOrderQty=x.OfferedCompany.CompanyRelatedMaterials.Where(y=>y.MaterialId==x.MaterialId).Select(y=>y.MinOrderQty).FirstOrDefault(),
                netAmount =x.OfferQty*x.UnitPrice,
                discountAmount = (x.OfferQty * x.UnitPrice*x.DiscountRate/100),
                discountedTotalAmount= (x.OfferQty * x.UnitPrice)- (x.OfferQty * x.UnitPrice*x.DiscountRate/100),
                taxAmount = ((x.OfferQty * x.UnitPrice)- (x.OfferQty * x.UnitPrice * x.DiscountRate/100))* x.TaxRate.KdvOrani,
                //remainingQty=x.PurchaseDemandItem.ComfirmedQty-x.PurchaseOrderItem.Miktar
            }).Select(x=> new PurchaseOfferItemL
            {
                Id = x.offerItem.Id,
                OfferId=x.offerItem.OfferId,
                OfferedCompanyId=x.offerItem.OfferedCompanyId,
                OfferedCompanyName = x.offerItem.OfferedCompany.CariAdi,
                CompanyPriceListCost=x.offerItem.CompanyPriceListCost,
                TaxRateId=x.offerItem.TaxRateId,
                TaxCode =x.offerItem.TaxRate.Kod,
                TaxRateValue=x.offerItem.TaxRate.KdvOrani,
                TaxAmount=x.taxAmount,
                TaxAmountBasedLocalCurrency=0,
                CurrencyId=x.offerItem.CurrencyId,
                CurrencyCode=x.offerItem.Currency.Kod,
                CurrencyName=x.offerItem.Currency.DovizAdi,
                UnitPrice=x.offerItem.UnitPrice,
                NetAmount=x.offerItem.OfferQty*x.offerItem.UnitPrice,
                NetAmountBasedLocalCurrency=0,
                DiscountRate=x.offerItem.DiscountRate,
                DiscountAmount=x.discountAmount,
                DiscountedTotalAmount=x.discountedTotalAmount,
                TotalAmount=x.netAmount-x.discountAmount-x.taxAmount,
                RemainingOrderQty=87,//tabloya eklencek
                OfferQty=x.offerItem.OfferQty,
                UnitOfMaterialOfferedId=x.offerItem.UnitOfMaterialOfferedId,
                OfferItemDescription =x.offerItem.OfferItemDescription,
                ValidityEndDate=x.offerItem.ValidityEndDate,
                ValidityStartDate=x.offerItem.ValidityStartDate,
                DeliveryDate=x.offerItem.DeliveryDate,
                UnitCodeOfOffer=x.offerItem.UnitOfMaterialOffered.Kod,
                UnitNameOfOffer=x.offerItem.UnitOfMaterialOffered.BirimAdi,

                IsOfferComfirmed =x.offerItem.IsOfferComfirmed,
                IsCreatedOrder=x.offerItem.IsCreatedOrder,
                IsOfferCancel=x.offerItem.IsOfferCancel,
                IsOfferActive=x.offerItem.IsOfferActive,
                IsOfferClosed=x.offerItem.IsOfferClosed,
                IsOffferLocked=x.offerItem.IsOffferLocked,

                MaterialId = x.offerItem.MaterialId,
                MaterialCode = x.offerItem.Material.Kod,
                MaterialName = x.offerItem.Material.StockName,
                MaterialUnit = x.offerItem.Material.Unit.Kod,
                DepoId=x.offerItem.Material.DepoId,
                MaxStockQty=x.offerItem.Material.MaxStockQty,//99999999,//tabloya eklencek
                MinStockQty=x.offerItem.Material.MinStockQty,//11111111,//tabloya eklenecek
                StorageStockQty=x.storageStockQty,

                PurchaseDemandId = x.offerItem.PurchaseDemandId,
                PurchaseOrderId=x.offerItem.PurchaseOrderId,
                PurchaseDemandItemId=x.offerItem.PurchaseDemandItemId,
                PurchaseOrderItemId=x.offerItem.PurchaseOrderItemId,
                PurchaseOfferCreatingMethod=x.offerItem.PurchaseOfferCreatingMethod,
                DemandedCompanyId=x.offerItem.PurchaseDemandItem.DemandedCompanyId,//tabloya eklenecek yada değiştirilecek
                ConnectedItemsId =x.offerItem.PurchaseDemandItem.ConnectedItemsId,
                DemandQty=x.offerItem.PurchaseDemandItem.DemandQty,
                ComfirmedQty=x.offerItem.PurchaseDemandItem.ComfirmedQty,// tabloyada eklenecek
                DemandedDate=x.offerItem.PurchaseDemandItem.DemandedDate,//tabloya ekleneck
                PurchaseMainDescription=x.offerItem.PurchaseDemand.DemandDescription,
                PurchaseDemanItemDescription=x.offerItem.PurchaseDemandItem.DemandDescription,//tabloya eklenecek
                DemandFile=x.offerItem.PurchaseDemand.File,
                IsTopDemand =x.offerItem.PurchaseDemandItem.IsTopDemandExisted,

                MaxPurchaseOrderQty=x.maxOrderQty,//99999,//tabloya eklenecek
                MinPurchaseOrderQty=x.maxOrderQty,//11111,//tabloya eklencek

            }).ToList();
        }
        public IEnumerable<BaseEntity> TeklifAlinanFirmaList(Expression<Func<PurchaseOfferItems, bool>> filter)
        {
            return List(filter, x => new SatinalmaTeklifAlinanFirmalar
            {
                Id = x.Id,
                FirmaAdi=x.OfferedCompany.CariAdi,

            }).Distinct().ToList();
        }
    }
}
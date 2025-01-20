using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General.PurchaseBll
{
    public class PurchaseOrderItemsBll : BaseHareketBll<PurchaseOrderItems, SenfoniErpContext>, IBaseHareketSelectBll<PurchaseOrderItems>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<PurchaseOrderItems, bool>> filter)
        {
            return List(filter, x => new
            {
                orderItem = x,
                companyMaterial = x.OwnerForm.Company.CompanyRelatedMaterials.Where(y => y.MaterialId == x.MaterialId).Select(y => new
                {
                    materialCode=y.CompanyMaterialCode,
                    materialName=y.CompanyMaterialName,
                    materialUnit=y.CompanyMaterialUnit.BirimAdi,
                    maxOrderQty=y.MaxOrderQty,
                    minOrderQty=y.MinOrderQty
                }).FirstOrDefault(),
                //defaultUnitPrice=x.CompanyTokenOffer.CompanyPriceList
                //    .Where(y=>y.IsDefault).FirstOrDefault().CompanyPriceLists.PriceListItems.
                //    Where(y=>y.MaterialId==x.MaterialId).FirstOrDefault().ItemPrice,
                storageStockQty = x.Material.WareHouseStocks.Where(y => y.WareHouseId == x.Material.DepoId).Select(y => y.Quantity).FirstOrDefault(),
               // maxOrderQty = x.CompanyOrdered.CompanyRelatedMaterials.Where(y => y.MaterialId == x.MaterialId).Select(y => y.MaxOrderQty).FirstOrDefault(),
                //minOrderQty = x.CompanyOrdered.CompanyRelatedMaterials.Where(y => y.MaterialId == x.MaterialId).Select(y => y.MinOrderQty).FirstOrDefault(),
                netAmount = x.PurchaseOrderQty * x.UnitPrice,
                discountAmount = (x.PurchaseOrderQty * x.UnitPrice * x.DiscountRate/100),
                discountedTotalAmount = (x.PurchaseOrderQty * x.UnitPrice) - (x.PurchaseOrderQty * x.UnitPrice * x.DiscountRate/100),
                taxAmount = ((x.PurchaseOrderQty * x.UnitPrice) - (x.PurchaseOrderQty * x.UnitPrice * x.DiscountRate/100)) * x.TaxRate.KdvOrani,
                //remainingQty=x.PurchaseDemandItem.ComfirmedQty-x.PurchaseOrderItem.Miktar
            }).Select(x => new PurchaseOrderItemsL
            {
                Id = x.orderItem.Id,
                IsActive=x.orderItem.IsActive,
                IsCancel=x.orderItem.IsCancel,
                IsClosed=x.orderItem.IsClosed,
                IsComfirmed=x.orderItem.IsComfirmed,
                OwnerFormId = x.orderItem.OwnerFormId,
                OrderCreatorId=x.orderItem.OrderCreatorId,
                CompanyId=x.orderItem.OwnerForm.CompanyId,
                CompanyName=x.orderItem.OwnerForm.Company.CariAdi,
                CurrencyId =(long) x.orderItem.OwnerForm.CurrencyId,
                CurrencyCode = x.orderItem.OwnerForm.Currency.Kod,
                CurrencyName = x.orderItem.OwnerForm.Currency.DovizAdi,
                OrderItemDescription=x.orderItem.OrderItemDescription,
                UnitOfMaterialOrderedId = x.orderItem.UnitOfMaterialOrderedId,
                UnitCodeOfOrder=x.orderItem.UnitOfMaterialOrdered.BirimAdi,
                //DeliverCompanyId=x.orderItem.OwnerForm.DeliveryCompanyId,
                //DeliveryCompanyName=x.orderItem.OwnerForm.DeliveryCompany.CariAdi,
                PurchaseOrderQty=x.orderItem.PurchaseOrderQty,
                UnitPrice = x.orderItem.UnitPrice,
                NetAmount = x.orderItem.PurchaseOrderQty * x.orderItem.UnitPrice,
                NetAmountBasedLocalCurrency = 0,
                DiscountRate = x.orderItem.DiscountRate,
                DiscountAmount = x.discountAmount,
                DiscountedTotalAmount = x.discountedTotalAmount,
                TaxRateId = x.orderItem.TaxRateId,
                TaxRateValue = x.orderItem.TaxRate.KdvOrani,
                TaxCode = x.orderItem.TaxRate.Kod,
                TaxAmount = x.taxAmount,
                TaxAmountBasedLocalCurrency = 0,
                TotalAmount = x.netAmount - x.discountAmount - x.taxAmount,
                MaterialId = x.orderItem.MaterialId,
                MaterialCode = x.orderItem.Material.Kod,
                MaterialName = x.orderItem.Material.StockName,
                MaterialUnit = x.orderItem.Material.Unit.Kod,
                DeliveryDate = x.orderItem.DeliveryDate,
                DemandedDate = x.orderItem.DemandedDate,//tabloya ekleneck
                PurchaseOrderCreatingMethod = x.orderItem.PurchaseOrderCreatingMethod,
                OrderItemFile=x.orderItem.OrderItemFile,
                PurchaseDemandId = x.orderItem.PurchaseDemandId,
                PurchaseDemandItemId = x.orderItem.PurchaseDemandItemId,
                PurchaseOfferId = x.orderItem.PurchaseOfferId,
                PurchaseOfferItemId = x.orderItem.PurchaseOfferItemId,
                MaxStockQty = x.orderItem.Material.MaxStockQty,//99999999,//tabloya eklencek
                MinStockQty = x.orderItem.Material.MinStockQty,//11111111,//tabloya eklenecek
                StorageStockQty = x.storageStockQty,
                DepoId=x.orderItem.Material.DepoId,
                CompanyMaterialCod =x.companyMaterial.materialCode,
                CompanyMaterialName=x.companyMaterial.materialName,
                CompanyMaterialUnit=x.companyMaterial.materialUnit,
                DefaultUnitPrice =x.orderItem.DefaultUnitPrice,
                
                MaxPurchaseOrderQty = x.companyMaterial.maxOrderQty,//99999,//tabloya eklenecek
                MinPurchaseOrderQty = x.companyMaterial.maxOrderQty,//11111,//tabloya eklencek

                RemainingOrderQty = 87,//tabloya eklencek

                IsCreatedWayBill=x.orderItem.IsCreatedWayBill,
                PurchaseWayBillId=x.orderItem.PurchaseWayBillId,
                PurchaseWayBillItemId=x.orderItem.PurchaseWayBillItemId,
                WayBillQty=x.orderItem.WayBillQty,

            }).ToList();
        }
        public override bool Delete(IList<BaseHareketEntity> entities)
        {
            if (Messages.SilMesaj("Satınalma Sipariş Kalemleri") != DialogResult.Yes) return false;
            return base.Delete(entities);
        }
    }
}
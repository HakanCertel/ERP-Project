using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.SalesDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General.SalesBll
{
    public class SalesItemsBll : BaseHareketBll<SalesItems, SenfoniErpContext>, IBaseHareketSelectBll<SalesItems>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<SalesItems, bool>> filter)
        {
            return List(filter, x => new
            {
                salesItem = x,
                companyMaterial = x.Sales.Company.CompanyRelatedMaterials.Where(y => y.MaterialId == x.MaterialId).Select(y => new
                {
                    materialCode = y.CompanyMaterialCode,
                    materialName = y.CompanyMaterialName,
                    materialUnit = y.CompanyMaterialUnit.BirimAdi,
                    maxSalesQty = y.MaxOrderQty,
                    minSalesQty = y.MinOrderQty
                }).FirstOrDefault(),
                defaultUnitPrice = x.Sales.Company.CompanyPriceList
                    .Where(y => y.IsDefault).FirstOrDefault().CompanyPriceLists.PriceListItems.
                    Where(y => y.MaterialId == x.MaterialId).FirstOrDefault().ItemPrice,
                storageStockQty = x.Material.WareHouseStocks.Where(y => y.WareHouseId == x.Material.DepoId).Select(y => y.Quantity).FirstOrDefault(),
                netAmount = x.SalesQty * x.UnitPrice,
                discountAmount = (x.SalesQty * x.UnitPrice * x.DiscountRate / 100),
                discountedTotalAmount = (x.SalesQty * x.UnitPrice) - (x.SalesQty * x.UnitPrice * x.DiscountRate / 100),
                taxAmount = ((x.SalesQty * x.UnitPrice) - (x.SalesQty * x.UnitPrice * x.DiscountRate / 100)) * x.TaxRate.KdvOrani,
                //remainingQty=x.PurchaseDemandItem.ComfirmedQty-x.PurchaseOrderItem.Miktar
            }).Select(x => new SalesItemsL
            {
                Id = x.salesItem.Id,
                SalesId = x.salesItem.SalesId,
                SaleCode = x.salesItem.Sales.Kod,
                CreatorId = x.salesItem.CreatorId,
                SalesOfferId = x.salesItem.SalesOfferId,
                SalesOfferItemId = x.salesItem.SalesOfferItemId,
                PriceListId = x.salesItem.Sales.PriceListId,
                CompanySalesId = x.salesItem.Sales.CompanyId,
                CompanyName = x.salesItem.Sales.Company.CariAdi,
                DeliveryCompanyId = x.salesItem.Sales.DeliveryCompanyId,
                SalesQty = x.salesItem.SalesQty,
                SalesItemDescription = x.salesItem.SalesItemDescription,

                PurchaseDemandCode = x.salesItem.PurchaseDemandCode,
                PurchaseDemanItemId = x.salesItem.PurchaseDemanItemId,

                MaterialId = x.salesItem.MaterialId,
                MaterialCode = x.salesItem.Material.Kod,
                MaterialName = x.salesItem.Material.StockName,
                MaterialUnit = x.salesItem.Material.Unit.Kod,
                MaterialType = x.salesItem.Material.UrunCinsi,
                StorageStockQty = x.storageStockQty,
                DepoId = x.salesItem.Material.DepoId,
                CompanyMaterialCod = x.companyMaterial.materialCode,
                CompanyMaterialName = x.companyMaterial.materialName,
                CompanyMaterialUnit = x.companyMaterial.materialUnit,
                CurrencyId = (long)x.salesItem.Sales.CurrencyId,
                CurrencyCode = x.salesItem.Sales.Currency.Kod,
                CurrencyName = x.salesItem.Sales.Currency.DovizAdi,
                TaxRateId = x.salesItem.TaxRateId,
                TaxCode = x.salesItem.TaxRate.Kod,
                TaxRateValue = x.salesItem.TaxRate.KdvOrani,
                UnitOfMaterialSalesId = x.salesItem.UnitOfMaterialSalesId,
                UnitCodeOfMaterialSales = x.salesItem.UnitOfMaterialSales.Kod,
                DefaultUnitPrice = x.salesItem.DefaultUnitPrice,

                UnitPrice = x.salesItem.UnitPrice,
                DiscountRate = x.salesItem.DiscountRate,
                DeliveryDate = x.salesItem.DeliveryDate,
                DemandedDate = x.salesItem.DemandedDate,//tabloya ekleneck
                FirstPlanedDate = x.salesItem.FirstPlanedDate,
                FirstComletedDate=x.salesItem.FirstComletedDate,

                SalesItemFile = x.salesItem.SalesItemFile,
                IsActive=x.salesItem.IsActive,
                IsCancel=x.salesItem.IsCancel,
                IsClosed=x.salesItem.IsClosed,
                IsComfirmed=x.salesItem.IsComfirmed,
                MaxSalesQty = x.companyMaterial.maxSalesQty,//99999,//tabloya eklenecek
                MinSalesQty = x.companyMaterial.maxSalesQty,//11111,//tabloya eklencek

                NetAmount = x.netAmount,
                NetAmountBasedLocalCurrency = 0,
                DiscountAmount = x.discountAmount,
                DiscountedTotalAmount = x.discountedTotalAmount,
                TaxAmount = x.taxAmount,
                TaxAmountBasedLocalCurrency = 0,
                TotalAmount = x.netAmount - x.discountAmount - x.taxAmount,

                SaleProccessStatus= x.salesItem.SaleProccessStatus,
                ProccessComletedDate=x.salesItem.ProccessComletedDate,
                DispatchWayBillCode=x.salesItem.DispatchWayBillCode,
                DispatchWayBillItemId=x.salesItem.DispatchWayBillItemId,
                DispatchedQty=x.salesItem.DispatchedQty,
            }).ToList();
        }
        public override bool Delete(IList<BaseHareketEntity> entities)
        {
            if (Messages.SilMesaj("Satış Kalemleri") != DialogResult.Yes) return false;
            return base.Delete(entities);
        }
    }
}
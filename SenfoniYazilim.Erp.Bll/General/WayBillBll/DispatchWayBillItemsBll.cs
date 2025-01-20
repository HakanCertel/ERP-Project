using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.WayBillDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.WayBillEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.General.WayBillBll
{
    public class DispatchWayBillItemsBll : BaseHareketBll<DispatchWayBillItems, SenfoniErpContext>, IBaseHareketSelectBll<DispatchWayBillItems>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<DispatchWayBillItems, bool>> filter)
        {
            return List(filter, x => new
            {
                wayBillItem = x,
                companyMaterial = x.Company.CompanyRelatedMaterials.Where(y => y.MaterialId == x.MaterialId).Select(y => new
                {
                    materialCode = y.CompanyMaterialCode,
                    materialName = y.CompanyMaterialName,
                    materialUnit = y.CompanyMaterialUnit.BirimAdi,
                    maxOrderQty = y.MaxOrderQty,
                    minOrderQty = y.MinOrderQty
                }).FirstOrDefault(),
                defaultUnitPrice = x.Company.CompanyPriceList
                    .Where(y => y.IsDefault).FirstOrDefault().CompanyPriceLists.PriceListItems.
                    Where(y => y.MaterialId == x.MaterialId).FirstOrDefault().ItemPrice,
                netAmount = x.Quantity * x.UnitPrice,
                discountAmount = (x.Quantity * x.UnitPrice * x.DiscountRate),
                discountedTotalAmount = (x.Quantity * x.UnitPrice) - (x.Quantity * x.UnitPrice * x.DiscountRate),
                taxAmount = ((x.Quantity * x.UnitPrice) - (x.Quantity * x.UnitPrice * x.DiscountRate)) * x.TaxRate.KdvOrani,
                //remainingQty=x.PurchaseDemandItem.ComfirmedQty-x.PurchaseOrderItem.Miktar
            }).Select(x => new DispatchWayBillItemsL
            {
                Id = x.wayBillItem.Id,
                WayBillId = x.wayBillItem.WayBillId,
                CompanyId = x.wayBillItem.CompanyId,
                SaleItemId = x.wayBillItem.SaleItemId,
                Quantity = x.wayBillItem.Quantity,
                WayBillItemDescription = x.wayBillItem.WayBillItemDescription,
                MaterialId = x.wayBillItem.MaterialId,
                CurrencyId = x.wayBillItem.CurrencyId,
                TaxRateId = x.wayBillItem.TaxRateId,
                MaterialUnitOfProccessId = x.wayBillItem.MaterialUnitOfProccessId,
                UnitCodeOfProccess = x.wayBillItem.MaterialUnitOfProccess.Kod,
                UnitPrice = x.wayBillItem.UnitPrice,
                DiscountRate = x.wayBillItem.DiscountRate,
                DeliveryDate = x.wayBillItem.DeliveryDate,
                DemandedDate = x.wayBillItem.DemandedDate,//tabloya ekleneck
                WayBillCreatingMethod = x.wayBillItem.WayBillCreatingMethod,
                OrderItemFile = x.wayBillItem.OrderItemFile,
                IsActive=x.wayBillItem.IsActive,
                MaterialCode = x.wayBillItem.Material.Kod,
                MaterialName = x.wayBillItem.Material.StockName,
                MaterialUnit = x.wayBillItem.Material.Unit.Kod,

                CompanyMaterialCod = x.companyMaterial.materialCode,
                CompanyMaterialName = x.companyMaterial.materialName,
                CompanyMaterialUnit = x.companyMaterial.materialUnit,

                DefaultUnitPrice = x.wayBillItem.DefaultUnitPrice,

                TaxCode = x.wayBillItem.TaxRate.Kod,
                TaxRateValue = x.wayBillItem.TaxRate.KdvOrani,
                CurrencyCode = x.wayBillItem.Currency.Kod,
                CurrencyName = x.wayBillItem.Currency.DovizAdi,
                NetAmount = x.wayBillItem.Quantity * x.wayBillItem.UnitPrice,
                NetAmountBasedLocalCurrency = 0,
                DiscountAmount = x.discountAmount,
                DiscountedTotalAmount = x.discountedTotalAmount,
                TaxAmount = x.taxAmount,
                TaxAmountBasedLocalCurrency = 0,
                TotalAmount = x.netAmount - x.discountAmount - x.taxAmount,
                RemainingOrderQty = 87,//tabloya eklencek
            }).ToList();
        }
    }
}
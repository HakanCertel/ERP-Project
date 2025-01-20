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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General.SalesBll
{
    public class SalesOfferItemsBll : BaseHareketBll<SalesOfferItems, SenfoniErpContext>, IBaseHareketSelectBll<SalesOfferItems>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<SalesOfferItems, bool>> filter)
        {
            return List(filter, x => new
            {
                offerItem = x,
                companyMaterial = x.SalesOffer.Company.CompanyRelatedMaterials.Where(y => y.MaterialId == x.MaterialId).Select(y => new
                {
                    materialCode = y.CompanyMaterialCode,
                    materialName = y.CompanyMaterialName,
                    materialUnit = y.CompanyMaterialUnit.BirimAdi,
                    maxSalesQty = y.MaxOrderQty,
                    minSalesQty = y.MinOrderQty
                }).FirstOrDefault(),
                defaultUnitPrice = x.SalesOffer.Company.CompanyPriceList
                    .Where(y => y.IsDefault).FirstOrDefault().CompanyPriceLists.PriceListItems.
                    Where(y => y.MaterialId == x.MaterialId).FirstOrDefault().ItemPrice,
                storageStockQty = x.Material.WareHouseStocks.Where(y => y.WareHouseId == x.Material.DepoId).Select(y => y.Quantity).FirstOrDefault(),
                netAmount = x.SalesOfferQty * x.UnitPrice,
                discountAmount = (x.SalesOfferQty * x.UnitPrice * x.DiscountRate/100),
                discountedTotalAmount = (x.SalesOfferQty * x.UnitPrice) - (x.SalesOfferQty * x.UnitPrice * x.DiscountRate/100),
                taxAmount = ((x.SalesOfferQty * x.UnitPrice) - (x.SalesOfferQty * x.UnitPrice * x.DiscountRate/100)) * x.TaxRate.KdvOrani,
            }).Select(x => new SalesOfferItemsL
            {
                Id = x.offerItem.Id,
                SalesOfferId=x.offerItem.SalesOfferId,
                CreatorId=x.offerItem.CreatorId,
                OfferCode=x.offerItem.SalesOffer.Kod,
                CompanyOfferedId=x.offerItem.SalesOffer.CompanyId,
                CompanyName=x.offerItem.SalesOffer.Company.CariAdi,
                DeliveryCompanyId=x.offerItem.SalesOffer.DeliveryCompanyId,
                DeliveryCompanyName=x.offerItem.SalesOffer.DeliveryCompany.CariAdi,
                SalesOfferQty=x.offerItem.SalesOfferQty,
                OfferItemDescription=x.offerItem.OfferItemDescription,
                MaterialId = x.offerItem.MaterialId,
                MaterialCode = x.offerItem.Material.Kod,
                MaterialName = x.offerItem.Material.StockName,
                MaterialUnit = x.offerItem.Material.Unit.Kod,
                StorageStockQty = x.storageStockQty,
                DepoId = x.offerItem.Material.DepoId,
                CompanyMaterialCod = x.companyMaterial.materialCode,
                CompanyMaterialName = x.companyMaterial.materialName,
                CompanyMaterialUnit = x.companyMaterial.materialUnit,
                CurrencyId =(long) x.offerItem.SalesOffer.CurrencyId,
                CurrencyCode = x.offerItem.SalesOffer.Currency.Kod,
                CurrencyName = x.offerItem.SalesOffer.Currency.DovizAdi,
                TaxRateId = x.offerItem.TaxRateId,
                TaxCode = x.offerItem.TaxRate.Kod,
                TaxRateValue = x.offerItem.TaxRate.KdvOrani,
                UnitOfMaterialOfferId = x.offerItem.UnitOfMaterialOfferId,
                UnitCodeOfMaterialOffer=x.offerItem.UnitOfMaterialOffer.Kod,
                DefaultUnitPrice = x.offerItem.DefaultUnitPrice,

                PriceListId=x.offerItem.SalesOffer.PriceListId,
                UnitPrice = x.offerItem.UnitPrice,
                DiscountRate = x.offerItem.DiscountRate,
                DeliveryDate = x.offerItem.DeliveryDate,
                DemandedDate = x.offerItem.DemandedDate,

                OfferItemFile = x.offerItem.OfferItemFile,
                IsActive=x.offerItem.IsActive,
                IsCancel=x.offerItem.IsCancel,
                IsClosed=x.offerItem.IsClosed,
                IsComfirmed=x.offerItem.IsComfirmed,
                MaxSalesQty = x.companyMaterial.maxSalesQty,
                MinSalesQty = x.companyMaterial.maxSalesQty,

                NetAmount = x.netAmount,
                NetAmountBasedLocalCurrency = 0,
                DiscountAmount = x.discountAmount,
                DiscountedTotalAmount = x.discountedTotalAmount,
                TaxAmount = x.taxAmount,
                TaxAmountBasedLocalCurrency = 0,
                TotalAmount = x.netAmount - x.discountAmount - x.taxAmount,

                IsCreatedOrder=x.offerItem.IsCreatedOrder,

            }).ToList();
        }
        public override bool Delete(IList<BaseHareketEntity> entities)
        {
            if (Messages.SilMesaj("Teklif Kalemleri") != DialogResult.Yes) return false;
            return base.Delete(entities);
        }
    }
}
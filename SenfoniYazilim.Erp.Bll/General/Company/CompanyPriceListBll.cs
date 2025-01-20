using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.Company;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Bll.General.Company
{
    public class CompanyPriceListBll : BaseHareketBll<CompanyPriceList, SenfoniErpContext>, IBaseHareketSelectBll<CompanyPriceList>
    {
        public BaseHareketEntity Single(Expression<Func<CompanyPriceList, bool>> filter)
        {
            return BaseSingle(filter, x => new CompanyPriceListL
            {
                Id = x.Id,
                CompanyId = x.CompanyId,
                CompanyPriceListsId = x.CompanyPriceListsId,
                IsDefault = x.IsDefault,
                CompanyPriceListCode = x.CompanyPriceLists.Kod,
                CompanyPriceListName = x.CompanyPriceLists.ListName,
                CurrencyId = x.CompanyPriceLists.CurrencyTypeId,
                CompanyPriceListCurrencyCode = x.CompanyPriceLists.CurrencyType.Kod,
                CompanyPriceListCurrencyName = x.CompanyPriceLists.CurrencyType.DovizAdi,
                CompanyPriceListDescription = x.CompanyPriceLists.Description,
                CompanyPriceListValidityStart = x.CompanyPriceLists.ValidityStartDate,
                CompanyPriceListValidityEnd = x.CompanyPriceLists.VailidityEndDate

            });
        }
        public IEnumerable<BaseHareketEntity> List(Expression<Func<CompanyPriceList, bool>> filter)
        {
            return List(filter, x => new CompanyPriceListL
            {
                Id = x.Id,
                CompanyId=x.CompanyId,
                CompanyPriceListsId=x.CompanyPriceListsId,
                IsDefault=x.IsDefault,
                CompanyPriceListCode=x.CompanyPriceLists.Kod,
                CompanyPriceListName=x.CompanyPriceLists.ListName,
                CurrencyId=x.CompanyPriceLists.CurrencyTypeId,
                CompanyPriceListCurrencyCode=x.CompanyPriceLists.CurrencyType.Kod,
                CompanyPriceListCurrencyName=x.CompanyPriceLists.CurrencyType.DovizAdi,
                CompanyPriceListDescription=x.CompanyPriceLists.Description,
                CompanyPriceListValidityStart=x.CompanyPriceLists.ValidityStartDate,
                CompanyPriceListValidityEnd=x.CompanyPriceLists.VailidityEndDate,
                PriceListItems=x.CompanyPriceLists.PriceListItems
            }).ToList();
        }
    }
}
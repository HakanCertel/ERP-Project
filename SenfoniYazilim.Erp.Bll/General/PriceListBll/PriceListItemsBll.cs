using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.PriceListDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.PriceListEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.General.PriceListBll
{
    public class PriceListItemsBll : BaseHareketBll<PriceListItems, SenfoniErpContext>, IBaseHareketSelectBll<PriceListItems>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<PriceListItems, bool>> filter)
        {
            return List(filter, x => new PriceListItemsL
            {
                Id = x.Id,
                PriceListId=x.PriceListId,
                MaterialId=x.MaterialId,
                UnitId=x.UnitId,
                ItemPrice=x.ItemPrice,
                ValidityStartDate=x.ValidityStartDate,
                ValidityEndDate=x.ValidityEndDate,
                PriceListItemDescription=x.PriceListItemDescription,
                IsActive=x.IsActive,

                PriceListCode=x.PriceList.Kod,
                PriceListName=x.PriceList.ListName,
                PriceListDescription=x.PriceList.Description,
                MaterialCode=x.Material.Kod,
                MaterialName=x.Material.StockName,
                MaterialUnitName=x.Material.Unit.Kod,
                UnitCode=x.Unit.Kod,
                UnitName=x.Unit.BirimAdi,

            }).ToList();
        }
    }
}

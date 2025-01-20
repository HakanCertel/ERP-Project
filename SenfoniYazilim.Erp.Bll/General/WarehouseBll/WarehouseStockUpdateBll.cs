using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
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
    public class WarehouseStockUpdateBll : BaseHareketBll<WareHouseStockUpdate, SenfoniErpContext>, IBaseHareketSelectBll<WareHouseStockUpdate>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<WareHouseStockUpdate, bool>> filter)
        {
            return List(filter, x => new WareHouseStockUpdateL
            {
                Id = x.Id,
                WareHouseId = x.WareHouseId,
                MaterialId = x.MaterialId,
                MaterialCode = x.Material.Kod,
                MaterialName = x.Material.StockName,
                Quantity = x.Quantity,
                NewQuantity=x.NewQuantity,
                Unit = x.Material.Unit.Kod,
            }).ToList();
        }
    }
}

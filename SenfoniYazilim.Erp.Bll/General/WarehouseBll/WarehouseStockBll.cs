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
    public class WarehouseStockBll:BaseHareketBll<WareHouseStocks,SenfoniErpContext>, IBaseHareketSelectBll<WareHouseStocks>
    {
        public BaseHareketEntity Single(Expression<Func<WareHouseStocks, bool>> filter)
        {
            return BaseSingle(filter, x => new WareHouseStockL
            {
                Id = x.Id,
                MaterialId = x.MaterialId,
                MaterialCode = x.Material.Kod,
                MaterialName = x.Material.StockName,
                WareHouseId = x.WareHouseId,
                Quantity = x.Quantity,
                UnitId = x.UnitId,
                UnitCode=x.Unit.Kod,
                UnitName=x.Unit.BirimAdi,
            });
        }
        public IEnumerable<BaseHareketEntity> List(Expression<Func<WareHouseStocks, bool>> filter)
        {
            return List(filter, x => new WareHouseStockL
            {
                Id = x.Id,
                WareHouseId=x.WareHouseId,
                MaterialId=x.MaterialId,
                MaterialCode=x.Material.Kod,
                MaterialName=x.Material.StockName,
                MaterialType=x.Material.UrunCinsi,
                Quantity=x.Quantity,
                UnitId=x.UnitId,
                UnitCode=x.Unit.Kod,
                UnitName=x.Unit.BirimAdi,
            }).ToList();
        }
        public IEnumerable<BaseEntity> ListBaseEntity(Expression<Func<WareHouseStocks, bool>> filter)
        {
            return List(filter, x => new WareHouseStockBaseEntityL
            {
                Id = x.Id,
                WareHouseId = x.WareHouseId,
                MaterialId = x.MaterialId,
                MaterialCode = x.Material.Kod,
                MaterialName = x.Material.StockName,
                MaterialType = x.Material.UrunCinsi,
                Quantity = x.Quantity,
                UnitCode = x.Material.Unit.Kod
            }).ToList();
        }
    }
}


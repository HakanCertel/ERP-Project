using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;

namespace SenfoniYazilim.Erp.Bll.Functions
{
    public static class InsertOrUpdateAnyItems
    {
        public static bool InsertWarehouseStock(List<BaseHareketEntity> items) 
        {
            return InstanceBaseHareketEntityBll<WareHouseStocks, WarehouseStockBll>.InsertEntities(items);

        }
        public static bool UpdateWarehouseStock(List<BaseHareketEntity> items)
        {
            return InstanceBaseHareketEntityBll<WareHouseStocks, WarehouseStockBll>.UpdateEntities(items);
        }

    }
}

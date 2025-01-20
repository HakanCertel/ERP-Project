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

namespace SenfoniYazilim.Erp.Bll.General.PurchaseBll
{
    public class PurchaseDemandItemsTableBll : BaseHareketBll<PurchaseDemandItems, SenfoniErpContext>, IBaseHareketSelectBll<PurchaseDemandItems>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<PurchaseDemandItems, bool>> filter)
        {
            return List(filter, x => new PurchaseDemandItemsL
            {
                Id = x.Id,
                OwnerFormId=x.OwnerFormId,
                MaterialId=x.MaterialId,
                StockName =x.Material.StockName,
                StockCode =x.Material.Kod,
                UnitId=x.UnitId,
                UnitCode =x.Unit.Kod,
                DemandItemDescription=x.DemandItemDescription,
                DemandDescription =x.DemandDescription,
                DemandedDate =x.DemandedDate,
                DemandQty =x.DemandQty,
                DemandedCompanyId =x.DemandedCompanyId,
                CompanyName =x.DemandedCompany.CariAdi,
                DataSourceCardType=x.DataSourceCardType,
            }).ToList();
        }
        
    }
}
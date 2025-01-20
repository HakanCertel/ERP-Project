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
    public class PurchaseDemandItemsFeatureBll : BaseHareketBll<PurchaseDemandItemsFeature, SenfoniErpContext>, IBaseHareketSelectBll<PurchaseDemandItemsFeature>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<PurchaseDemandItemsFeature, bool>> filter)
        {
            return List(filter, x => new PurchaseDemandItemsFeatureL
            {
                Id = x.Id,
                BaseCard=x.BaseCard,
                OwnerFormId=x.OwnerFormId,
                MaterialId=x.MaterialId,
                FeatureDescription=x.FeatureDescription,
                MaterialCode=x.Material.Kod,
                MaterialName=x.Material.StockName,
                Document=x.Document,
            }).ToList();
        }
    }
}

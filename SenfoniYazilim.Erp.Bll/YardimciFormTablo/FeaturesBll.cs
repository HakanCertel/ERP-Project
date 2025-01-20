using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.YardimciFormTablo
{
    public class FeaturesBll : BaseHareketBll<Features, SenfoniErpContext>, IBaseHareketSelectBll<Features>

    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<Features, bool>> filter)
        {
            return List(filter, x => new FeatureL
            {
                Id = x.Id,
                DefinationId=x.DefinationId,
                Code = x.Code,
                KartTuru = x.KartTuru,
                Description = x.Description,
                IsActive = x.IsActive
            }).ToList();
        }
    }
}
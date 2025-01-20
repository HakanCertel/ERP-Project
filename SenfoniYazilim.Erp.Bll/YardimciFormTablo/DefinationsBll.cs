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
    public class DefinationsBll : BaseHareketBll<Definations, SenfoniErpContext>, IBaseHareketSelectBll<Definations>

    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<Definations, bool>> filter)
        {
            return List(filter, x => new DefinationItems
            {
                Id = x.Id,
                Code=x.Code,
                KartTuru=x.KartTuru,
                Description=x.Description,
                IsActive=x.IsActive
            }).ToList();
        }
        public IEnumerable<BaseHareketEntity> DefinationAndFeatureList(Expression<Func<Definations, bool>> filter)
        {
            return List(filter, x => new DefinationAndFeatureItems
            {
                DefinationId = x.Id,
                DefinationCode = x.Code,
                DefinationDescription = x.Description,
                KartTuru = x.KartTuru,
                IsActive = x.IsActive

            }).ToList();
        }
        
    }
}

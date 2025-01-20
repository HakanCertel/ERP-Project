using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Functions;
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
    public class RolYetkileriBll : BaseHareketBll<RolYetkileri, SenfoniErpContext>, IBaseHareketSelectBll<RolYetkileri>
    {
        public BaseHareketEntity Single(Expression<Func<RolYetkileri, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }
        public IEnumerable<BaseHareketEntity> List(Expression<Func<RolYetkileri, bool>> filter)
        {
            return List(filter, x => new RolYetkileriL
            {
                Id = x.Id,
                RolId=x.RolId,
                KartTuru=x.KartTuru,
                Gorebilir=x.Gorebilir,
                Ekleyebilir=x.Ekleyebilir,
                Degistirebilir=x.Degistirebilir,
                Silebilir=x.Silebilir,
            }).AsEnumerable().OrderBy(x=>x.KartTuru.toName()).ToList();
        }
    }
}

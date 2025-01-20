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
    public class KullaniciBirimYetkileriBll : BaseHareketBll<KullaniciBirimYetkileri, SenfoniErpContext>, IBaseHareketSelectBll<KullaniciBirimYetkileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<KullaniciBirimYetkileri, bool>> filter)
        {
            return List(filter, x => new KullaniciBirimYetkileriL
            {
                Id = x.Id,
                Kod=x.KartTuru==Common.Enums.KartTuru.Sube?x.Sube.Kod:x.Donem.Kod,
                KartTuru=x.KartTuru,
                SubeId=x.SubeId,
                SubeAdi=x.Sube.SubeAdi,
                DonemId=x.DonemId,
                DonemAdi=x.Donem.DonemAdi
            }).ToList();
        }
    }
}


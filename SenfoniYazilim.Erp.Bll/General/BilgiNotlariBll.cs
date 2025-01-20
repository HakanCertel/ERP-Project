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
    public class BilgiNotlariBll : BaseHareketBll<BilgiNotlari, SenfoniErpContext>, IBaseHareketSelectBll<BilgiNotlari>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<BilgiNotlari, bool>> filter)
        {
            return List(filter, x => new BilgiNotlariL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Tarih=x.Tarih,
                BilgiNotu=x.BilgiNotu
            }).ToList();
        }
    }
}

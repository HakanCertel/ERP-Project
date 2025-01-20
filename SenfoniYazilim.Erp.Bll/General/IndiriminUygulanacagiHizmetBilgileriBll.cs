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
    public class IndiriminUygulanacagiHizmetBilgileriBll:BaseHareketBll<IndiriminUygulanacagiHizmetBilgileri,SenfoniErpContext>, IBaseHareketSelectBll<IndiriminUygulanacagiHizmetBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<IndiriminUygulanacagiHizmetBilgileri, bool>> filter)
        {
            return List(filter,x=>  new IndiriminUygulanacagiHizmetBilgileriL
            {
                Id=x.Id,
                IndirimId=x.IndirimId,
                HizmetId=x.HizmetId,
                HizmetAdi=x.Hizmet.HizmetAdi,
                IndirimTutari=x.IndirimTutari,
                IndirimOrani=x.IndirimOrani,
                SubeId=x.SubeId,
                DonemId=x.DonemId
            }).ToList();
        }
    }
}

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
    public class ReceteOperasyonBilgileriBll:BaseHareketBll<ReceteOperasyonBilgileri, SenfoniErpContext>, IBaseHareketSelectBll<ReceteOperasyonBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<ReceteOperasyonBilgileri, bool>> filter)
        {
            return List(filter, x => new ReceteOperasyonBilgileriL
            {

                Id = x.Id,
                ReceteId = x.ReceteId,
                OperasyonId =x.OperasyonId,
                OperasyonKodu=x.Operasyon.Kod,
                OperasyonAdi=x.Operasyon.OperasyonAdi,
                OperasyonSirasi=x.OperasyonSirasi,
                Aciklama=x.Aciklama
            }).OrderBy(x=>x.OperasyonSirasi).ToList();
        }
    }
}


using SenfoniYazilim.Erp.Bll.Base;
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
    public class VardiyaBilgileriLastVersionBll : BaseHareketBll<VardiyaBilgileriLastVersion, SenfoniErpContext>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<VardiyaBilgileriLastVersion, bool>> filter)
        {
            return List(filter, x => new VardiyaBilgileriLastVersionL
            {
                Id = x.Id,
                VardiyaId = x.VardiyaId,
                KacinciVardiya=x.KacinciVardiya,
                Gun=x.Gun,
                MesaiBaslamaSaati=x.MesaiBaslamaSaati,
                MesaiBitisSaati=x.MesaiBitisSaati,
                MolaSuresi=x.MolaSuresi,
                BirimSure=x.BirimSure,
                Kapasite=x.Kapasite
            }).OrderBy(x=>x.KacinciVardiya).ThenBy(x=>x.Gun).ToList();
        }
    }
}

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
    public class ReceteOperasyonMakinaBilgileriBll:BaseHareketBll<ReceteOperasyonMakinaBilgileri, SenfoniErpContext>,
        IBaseHareketSelectBll<ReceteOperasyonMakinaBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<ReceteOperasyonMakinaBilgileri, bool>> filter)
        {
            return List(filter, x => new ReceteOperasyonMakinaBilgileriL
            {
                Id = x.Id,
                ReceteId=x.ReceteId,
                ReceteninBagliOlduguStokId=x.Recete.StokId,
                MakinaId=x.MakinaId,
                MakinaKodu=x.Makina.Kod,
                MakinaAdi=x.Makina.MakinaAdi,
                IstasyonId=x.IstasyonId,
                IstasyonKodu=x.Istasyon.Kod,
                IstasyonAdi=x.Istasyon.IstasyonAdi,
                OperasyonId=x.OperasyonId,
                OperasyonAdi=x.OperasyonAdi,
                MakinaHazirlikSuresi=x.MakinaHazirlikSuresi,
                OperasyonSuresi=x.OperasyonSuresi,
                VarsayilanMakina=x.VarsayilanMakina ,
                OperasyonSirasi=x.OperasyonSirasi,
            }).OrderBy(x=>x.VarsayilanMakina).ThenBy(x=>x.OperasyonSirasi).ToList();
        }
    }
}

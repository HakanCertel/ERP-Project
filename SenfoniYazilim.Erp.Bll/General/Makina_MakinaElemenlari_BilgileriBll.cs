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
    public class Makina_MakinaElemenlari_BilgileriBll:BaseHareketBll<Makina_MakinaElemenlari_Bilgileri,SenfoniErpContext>, IBaseHareketSelectBll<Makina_MakinaElemenlari_Bilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<Makina_MakinaElemenlari_Bilgileri, bool>> filter)
        {
            return List(filter, x => new Makina_MakinaElemenlari_BilgileriL
            {
                Id = x.Id,
                IstasyonId=x.IstasyonId,
                MakinaId=x.MakinaId,
                MakinaKodu=x.Makina.Kod,
                MakinaAdi=x.Makina.MakinaAdi,
                StokId=x.StokId,
                StokKodu=x.Stok.Kod,
                StokAdi=x.Stok.StockName,
                Aciklama=x.Aciklama
            }).ToList();
        }
        public IEnumerable<BaseEntity> ReceteMakinaElemeanlariList(Expression<Func<Makina_MakinaElemenlari_Bilgileri, bool>> filter)
        {
            return List(filter, x => new ReceteIstasyonMakinaElemanlariL
            {
                MakinaId = x.MakinaId,
                MakinaKodu = x.Makina.Kod,
                MakinaAdi = x.Makina.MakinaAdi,
                StokId = x.StokId,
                StokKodu = x.Stok.Kod,
                StokAdi = x.Stok.StockName,
                Aciklama=x.Aciklama
            }).ToList();
        }
    }
}

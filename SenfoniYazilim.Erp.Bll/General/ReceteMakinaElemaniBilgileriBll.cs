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
    public class ReceteMakinaElemaniBilgileriBll : BaseHareketBll<ReceteMakinaElemaniBilgileri, SenfoniErpContext>, IBaseHareketSelectBll<ReceteMakinaElemaniBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<ReceteMakinaElemaniBilgileri, bool>> filter)
        {
            return List(filter, x => new ReceteMakinaElemaniBilgileriL
            {
                Id = x.Id,
                ReceteId=x.ReceteId,
                MakinaId = x.MakinaId,
                MakinaKodu = x.Makina.Kod,
                MakinaAdi = x.Makina.MakinaAdi,
                StokId = x.StokId,
                StokKodu = x.Stok.Kod,
                StokAdi = x.Stok.StockName,
                DegisimSuresi=x.DegisimSuresi,
                Aciklama = x.Aciklama
            }).ToList();
        }
    }
}

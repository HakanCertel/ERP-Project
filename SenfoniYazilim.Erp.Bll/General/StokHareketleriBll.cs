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
    public class StokHareketleriBll : BaseHareketBll<StokHareketleri, SenfoniErpContext>, IBaseHareketSelectBll<StokHareketleri>
    {
        public BaseHareketEntity Single(Expression<Func<StokHareketleri, bool>> filter)
        {
            return BaseSingle(filter, x => new StokHareketleriL
            {
                Id = x.Id,
                StokId = x.StokId,
                StokKodu = x.Stok.Kod,
                StokAdi = x.Stok.StockName,
                UnitId=x.UnitId,
                Unitname=x.Unit.BirimAdi,
                IslemMiktari=x.IslemMiktari,
                IslemOncesiStokMiktari=x.IslemOncesiStokMiktari,
                IslemSonrasiStokMiktari=x.IslemSonrasiStokMiktari,
                FormItemId=x.FormItemId,
                HareketCinsi=x.HareketCinsi,
                HareketTarihi=x.HareketTarihi,
                HareketTuru=x.HareketTuru,
                DepoId = x.DepoId,
                DepoKodu=x.Depo.Kod,
                DepoAdi=x.Depo.WarehouseName,
            });
        }
        public IEnumerable<BaseHareketEntity> List(Expression<Func<StokHareketleri, bool>> filter)
        {
            return List(filter, x => new StokHareketleriL
            {
                Id = x.Id,
                FormId=x.FormId,
                FormCode=x.FormCode,
                FormItemId=x.FormItemId,
                StokId=x.StokId,
                StokKodu=x.Stok.Kod,
                StokAdi=x.Stok.StockName,
                UnitId=x.UnitId,
                UnitCode=x.Unit.Kod,
                Unitname=x.Unit.BirimAdi,
                DepoId=x.DepoId,
                DepoKodu=x.Depo.Kod,
                DepoAdi=x.Depo.WarehouseName,
                HareketTuru=x.HareketTuru,
                HareketCinsi=x.HareketCinsi,
                HareketTarihi=x.HareketTarihi,
                IslemOncesiStokMiktari=x.IslemOncesiStokMiktari,
                IslemMiktari=x.IslemMiktari,
                IslemSonrasiStokMiktari= x.IslemSonrasiStokMiktari,
            }).ToList();
        }
    }
}

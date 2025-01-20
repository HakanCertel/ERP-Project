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
    public class UretimSonuKayitBilgileriBll : BaseHareketBll<UretimSonuKayitBilgileri, SenfoniErpContext>, IBaseHareketSelectBll<UretimSonuKayitBilgileri>
    {
        public BaseHareketEntity Single(Expression<Func<UretimSonuKayitBilgileri, bool>> filter)
        {
            return BaseSingle(filter, x => new UretimSonuKayitBilgileriL
            {
                Id = x.Id,
                UretimSonuKayitId=x.UretimSonuKayitId,
                MalzemeIhtiyacBilgileriId=x.MalzemeIhtiyacBilgileriId,
                StokId = x.StokId,
                StokKodu = x.Stok.Kod,
                StokAdi = x.Stok.StockName,
                DepoId = x.DepoId,
                KayitMiktari = x.KayitMiktari,
                //Birim = x.Stok.Unit.Kod,
            });
        }
        public IEnumerable<BaseHareketEntity> List(Expression<Func<UretimSonuKayitBilgileri, bool>> filter)
        {
            return List(filter, x => new UretimSonuKayitBilgileriL
            {
                Id = x.Id,
                UretimSonuKayitId=x.UretimSonuKayitId,
                MalzemeIhtiyacBilgileriId=x.MalzemeIhtiyacBilgileriId, 
                StokId =x.StokId,
                StokKodu=x.Stok.Kod,
                StokAdi=x.Stok.StockName,
                DepoId =x.DepoId,
                DepoKodu=x.Depo.Kod,
                DepoAdi=x.Depo.WarehouseName,
                BirimId =x.BirimId,
                BirimKodu=x.Birim.Kod,
                BirimAdi=x.Birim.BirimAdi,
                BirimIhtiyac =x.BirimIhtiyac,
                KayitMiktari =x.KayitMiktari,
                FireMiktari=x.FireMiktari,
                ToplamMiktar=x.KayitMiktari+x.FireMiktari,
                Fark=0
            }).ToList();
        }
    }
}

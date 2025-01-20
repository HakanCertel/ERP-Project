using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
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
    public class ReceteBilgileriBll : BaseHareketBll<ReceteBilgileri, SenfoniErpContext>, IBaseHareketSelectBll<ReceteBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<ReceteBilgileri, bool>> filter)
        {
            return List(filter, x => new ReceteBilgileriL
            {
                Id = x.Id,
                ReceteId=x.ReceteId,
                StokId=x.StokId,
                StokKodu=x.Stok.Kod,
                StokAdi=x.Stok.StockName,
                StokBirim=x.Stok.Unit.Kod,
                TuketimBirimId=x.TuketimBirimId,
                TuketimBirimAdi=x.TuketimBirimAdi,
                Miktar=x.Miktar,
                FireOrani=x.FireOrani,
                TuketimDepoAdi = x.TuketimDepo.WarehouseName,
                TuketimDepoId = x.TuketimDepoId,
                Uretilebilir = x.Uretilebilir,
                OperasyonBilgileriId=x.OperasyonBilgileriId,
                OperasyonId=x.OperasyonId,
                BagliOlduguUstReceteId = x.Recete.Id,
                ReceteOlusturulmaMiktari = x.Recete.Miktar,
                ReceteSeviyesi = 0,
            }).ToList();
        }
        public IEnumerable<BaseEntity> ListReceteBilesenleri(Expression<Func<ReceteBilgileri, bool>> filter)
        {
            return List(filter, x => new OperasyonaBagliTuketilecekReceteBilesenBilgileriL
            {
                Id = x.Id,
                StokKodu = x.Stok.Kod,
                StokAdi = x.Stok.StockName,
                Miktar = x.Miktar,
                Birim = x.Stok.Unit.Kod,
            }).ToList();
        }
    }
}

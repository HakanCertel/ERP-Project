using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
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
    public class KardesBilgileriBll : BaseHareketBll<KardesBilgileri, SenfoniErpContext>, IBaseHareketSelectBll<KardesBilgileri>

    {
        public  IEnumerable<BaseHareketEntity> List(Expression<Func<KardesBilgileri, bool>> filter)
        {
            return List(filter,x=> new KardesBilgileriL
            {
                Id=x.Id,
                TahakkukId=x.TahakkukId,
                KardesTahakkukId=x.KardesTahakkukId,
                Adi=x.KardesTahakkuk.Ogrenci.Adi,
                Soyadi=x.KardesTahakkuk.Ogrenci.Soyadi,
                SinifAdi=x.KardesTahakkuk.Sinif.SinifAdi,
                KayitSekli=x.KardesTahakkuk.KayitSekli,
                KayitDurumu=x.KardesTahakkuk.KayitDurumu,
                IptalDurumu=x.KardesTahakkuk.Durum?IptalDurumu.DevamEdiyor:IptalDurumu.IptalEdildi,
                SubeAdi=x.KardesTahakkuk.Sube.SubeAdi,
                SubeId=x.KardesTahakkuk.SubeId,

            }).ToList();
        }
    }
}

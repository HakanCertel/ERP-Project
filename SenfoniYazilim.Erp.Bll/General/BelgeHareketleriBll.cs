﻿using SenfoniYazilim.Erp.Bll.Base;
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
    public class BelgeHareketleriBll : BaseHareketBll<MakbuzHareketleri, SenfoniErpContext>
    {
        public IEnumerable<BaseEntity> List(Expression<Func<MakbuzHareketleri, bool>> filter)
        {
            return List(filter, x => new BelgeHareketleriL
            {
                Id = x.Makbuz.Id,
                SubeId=x.Makbuz.SubeId,
                OgrenciNo=x.OdemeBilgileri.Tahakkuk.Ogrenci.Kod,
                Adi=x.OdemeBilgileri.Tahakkuk.Ogrenci.Adi,
                Soyadi=x.OdemeBilgileri.Tahakkuk.Ogrenci.Soyadi,
                SinifAdi=x.OdemeBilgileri.Tahakkuk.Sinif.SinifAdi,
                OgrenciSubeAdi=x.OdemeBilgileri.Tahakkuk.Sube.SubeAdi,
                OdemeBilgileriId=x.OdemeBilgileriId,
                OdemeTutariAdi=x.OdemeBilgileri.OdemeTuru.OdemeTuruAdi,
                GirisTarihi=x.OdemeBilgileri.GirisTarihi,
                Vade=x.OdemeBilgileri.Vade,
                HesabaGecisTarihi=x.OdemeBilgileri.HesabaGecisTarihi,
                Tutar=x.OdemeBilgileri.Tutar,
                IslemOncesiTutar=x.IslemOncesiTutar,
                IslemTutari=x.IslemTutari,
                AsilBorclu=x.OdemeBilgileri.AsilBorclu,
                Ciranta=x.OdemeBilgileri.Ciranta,
                BankaAdi=x.OdemeBilgileri.Banka.BankaAdi,
                BankaSubeAdi=x.OdemeBilgileri.BankaSube.SubeAdi,
                BelgeNo=x.OdemeBilgileri.BelgeNo,
                HesapNo=x.OdemeBilgileri.HesapNo,
                Tarih=x.Makbuz.Tarih,
                MakbuzNo=x.Makbuz.Kod,
                MakbuzTuru=x.Makbuz.MakbuzTuru,
                HesapTuru=x.Makbuz.HesapTuru,
                BelgeDurumu=x.BelgeDurumu
            }).OrderBy(x=>new {x.Tarih,x.MakbuzNo }).ToList();
        }
    }
}

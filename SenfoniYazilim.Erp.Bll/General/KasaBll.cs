﻿using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class KasaBll : BaseGenelBll<Kasa>, IBaseCommonBll
    {
        public KasaBll() : base(KartTuru.Kasa){}

        public KasaBll(Control ctrl) : base(ctrl, KartTuru.Kasa){}

        public override BaseEntity Single(Expression<Func<Kasa, bool>> filter)
        {
            return BaseSingle(filter, x => new KasaS
            {
                Id = x.Id,
                Kod = x.Kod,
                KasaAdi = x.KasaAdi,
                OzelKod1Id=x.OzelKod1Id,
                OzelKod1Adi=x.OzelKod1.OzelKodAdi,
                OzelKod2Id=x.OzelKod2Id,
                OzelKod2Adi=x.OzelKod2.OzelKodAdi,
                SubeId = x.SubeId,
                DonemId = x.DonemId,
                Aciklama = x.Aciklama,
                Durum = x.Durum

            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Kasa, bool>> filter)
        {
            return BaseList(filter, x => new KasaL
            {
                Id = x.Id,
                Kod = x.Kod,
                KasaAdi=x.KasaAdi,
                OzelKod1Adi=x.OzelKod1.OzelKodAdi,
                OzelKod2Adi=x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama

            }).OrderBy(x => x.Kod).ToList();
        }

    }
}

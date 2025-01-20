using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.YardimciFormTablo
{
    public class DovizBilgileriBll : BaseGenelBll<DovizBilgileri>, IBaseGenelBll, IBaseCommonBll
    {
        public DovizBilgileriBll() : base(KartTuru.Doviz) { }

        public DovizBilgileriBll(Control ctrl) : base(ctrl, KartTuru.Doviz) { }

        public override IEnumerable<BaseEntity> List(Expression<Func<DovizBilgileri, bool>> filter)
        {
            return BaseList(filter, x => new DovizBilgileriL
            {
                Id = x.Id,
                Kod = x.Kod,
                DovizAdi = x.DovizAdi,
                KayitKisiId=x.KayitKisiId,
                KayitKisiAdSoyad=x.KayitKisi.Adi,
                GuncelleyenKisiId=x.GuncelleyenKisiId,
                GuncelleyenKisiAdSoyad=x.GuncelleyenKisi.Adi,
                KayitTarihi=x.KayitTarihi,
                GuncellemeTarihi=x.GuncellemeTarihi,
                Aciklama = x.Aciklama

            }).ToList();
        }

    }
}
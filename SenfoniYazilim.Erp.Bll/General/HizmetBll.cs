using SenfoniYazilim.Erp.Bll.Base;
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
    public class HizmetBll : BaseGenelBll<Hizmet>, IBaseCommonBll
    {
        public HizmetBll() : base(KartTuru.Hizmet){}

        public HizmetBll(Control ctrl) : base(ctrl, KartTuru.Hizmet){}

        public override BaseEntity Single(Expression<Func<Hizmet, bool>> filter)
        {
            return BaseSingle(filter, x => new HizmetS
            {
                Id = x.Id,
                Kod = x.Kod,
                HizmetAdi=x.HizmetAdi,
                BaslamaTarihi=x.BaslamaTarihi,
                BitisTarihi=x.BitisTarihi,
                Ucret=x.Ucret,
                HizmetTuruId=x.HizmetTuruId,
                HizmetTuruAdi=x.HizmetTuru.HizmetTuruAdi,
                SubeId=x.SubeId,
                DonemId=x.DonemId,
                Aciklama = x.Aciklama,
                Durum = x.Durum

            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Hizmet, bool>> filter)
        {
            return BaseList(filter, x => new HizmetL
            {
                Id = x.Id,
                Kod = x.Kod,
                HizmetAdi=x.HizmetAdi,
                HizmetTuruId=x.HizmetTuruId,
                HizmetTuruAdi=x.HizmetTuru.HizmetTuruAdi,
                BaslamaTarihi=x.BaslamaTarihi,
                BitisTarihi=x.BitisTarihi,
                HizmetTipi=x.HizmetTuru.HizmetTipi,
                Ucret=x.Ucret,
                Aciklama = x.Aciklama

            }).OrderBy(x => x.Kod).ToList();
        }
    }
}

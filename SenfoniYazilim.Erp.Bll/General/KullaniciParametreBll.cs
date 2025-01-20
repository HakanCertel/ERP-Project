using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class KullaniciParametreBll : BaseGenelBll<KullaniciParametre>, IBaseGenelBll, IBaseCommonBll
    {
        public KullaniciParametreBll():base(KartTuru.KullaniciParametre){}
        public KullaniciParametreBll(Control ctrl):base(ctrl,KartTuru.KullaniciParametre){}

        public override BaseEntity Single(Expression<Func<KullaniciParametre, bool>> filter)
        {
            return BaseSingle(filter, x => new KullaniciParametreS
            {
                Id = x.Id,
                Kod = x.Kod,
                KullaniciId=x.KullaniciId,
                DefaultAvukatHesapId=x.DefaultAvukatHesapId,
                DefaultAvukatHesapAdi=x.DefaultAvukatHesap.AdiSoyadi,
                DefaultBankaHesapId=x.DefaultBankaHesapId,
                DefaultBankaHesapAdi=x.DefaultBankaHesap.HesapAdi,
                DefaultKasaHesapId=x.DefaultKasaHesapId,
                DefaultKasaHesapAdi=x.DefaultKasaHesap.KasaAdi,
                RaporlariOnayAlmadanKapat=x.RaporlariOnayAlmadanKapat,
                TabloViewCaptionForeColor=x.TabloViewCaptionForeColor,
                TabloColumnHeaderForeColor=x.TabloColumnHeaderForeColor,
                TabloBandCaptionForeColor=x.TabloBandCaptionForeColor,
                ArkaPlanResim=x.ArkaPlanResim
            });
        }
    }
}

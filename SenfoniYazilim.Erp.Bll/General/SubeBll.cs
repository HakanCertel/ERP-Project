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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class SubeBll : BaseGenelBll<Sube>, IBaseGenelBll, IBaseCommonBll
    {
        public SubeBll() : base(KartTuru.Sube){}

        public SubeBll(Control ctrl) : base(ctrl, KartTuru.Sube){}

        public override BaseEntity Single(Expression<Func<Sube, bool>> filter)
        {
            return BaseSingle(filter, x => new SubeS
            {
                Id = x.Id,
                Kod = x.Kod,
                SubeAdi=x.SubeAdi,
                Adres=x.Adres,
                AdresUlkeId=x.AdresUlkeId,
                AdresUlkeAdi=x.AdresUlke.CountryName,
                AdresIlId=x.AdresIlId,
                AdresIlAdi=x.AdresIl.IlAdi,
                AdresIlceId=x.AdresIlceId,
                AdresIlceAdi=x.AdresIlce.IlceAdi,
                Telefon=x.Telefon,
                Fax=x.Fax,
                IbanNo=x.IbanNo,
                GrupAdi=x.GrupAdi,
                SiraNo=x.SiraNo,
                Logo=x.Logo,
                Aciklama=x.Aciklama,
                Durum = x.Durum

            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Sube, bool>> filter)
        {
            return BaseList(filter, x => new SubeL
            {
                Id = x.Id,
                Kod = x.Kod,
                SubeAdi=x.SubeAdi,
                Adres=x.Adres,
                AdresIlAdi=x.AdresIl.IlAdi,
                AdresIlceAdi=x.AdresIlce.IlceAdi,
                Telefon=x.Telefon,
                Faks=x.Fax,
                IbanNo=x.IbanNo,
                GrupAdi=x.GrupAdi,
                SiraNo=x.SiraNo
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}

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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class KullaniciBll : BaseGenelBll<Kullanici>, IBaseGenelBll, IBaseCommonBll
    {
        public KullaniciBll() : base(KartTuru.Kullanici) { }

        public KullaniciBll(Control ctrl) : base(ctrl, KartTuru.Kullanici) { }

        public override BaseEntity Single(Expression<Func<Kullanici, bool>> filter)
        {
            return BaseSingle(filter, x => new KullaniciS
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi=x.Adi,
                Soyadi=x.Soyadi,
                Email=x.Email,
                RolId=x.RolId,
                RolAdi=x.Rol.RolAdi,
                KullaniciYetkisi=x.Rol.KullaniciYetkisi,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }
        public  BaseEntity SingleDetail(Expression<Func<Kullanici, bool>> filter)
        {
            return BaseSingle(filter, x => new KullaniciS
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                Email = x.Email,
                Sifre=x.Sifre,
                GizliKelime=x.GizliKelime,
                RolId = x.RolId,
                RolAdi = x.Rol.RolAdi,
                KullaniciYetkisi=x.Rol.KullaniciYetkisi,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Kullanici, bool>> filter)
        {
            return BaseList(filter, x => new KullaniciL
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi=x.Adi,
                Soyadi=x.Soyadi,
                Email=x.Email,
                RolAdi=x.Rol.RolAdi,
                Aciklama = x.Aciklama

            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
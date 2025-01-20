using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class CariBll : BaseGenelBll<Cari>, IBaseGenelBll, IBaseCommonBll
    {
        public CariBll() : base(KartTuru.Cari) { }

        public CariBll(Control ctrl) : base(ctrl, KartTuru.Cari) { }

        public override BaseEntity Single(Expression<Func<Cari, bool>> filter)
        {
            return BaseSingle(filter, x => new CariS
            {
                Id = x.Id,
                Kod = x.Kod,
                DefaultCurrencyId=x.DefaultCurrencyId,
                CariAdi = x.CariAdi,
                TcKimlikNo = x.TcKimlikNo,
                Telefon1 = x.Telefon1,
                Telefon2 = x.Telefon2,
                Telefon3 = x.Telefon3,
                Telefon4 = x.Telefon4,
                Fax = x.Fax,
                Web = x.Web,
                EMail = x.EMail,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                Adres = x.Adres,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                LegalEntity=x.LegalEntity,
                CustomerOrSuplier=x.CustomerOrSuplier,
                CompanyState=x.CompanyState,
                Location=x.Location,
                CurrencyCode=x.DefaultCurrency.Kod,
                CurrencyName=x.DefaultCurrency.DovizAdi,
                AddressItems=x.AddressItems,
                CompanyContactItems=x.CompanyContactItems,
                CompanyRelatedMaterials=x.CompanyRelatedMaterials,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Cari, bool>> filter)
        {
            return BaseList(filter, x => new CariL
            {
                Id = x.Id,
                Kod = x.Kod,
                CariAdi = x.CariAdi,
                TcKimlikNo = x.TcKimlikNo,
                Telefon1 = x.Telefon1,
                Telefon2 = x.Telefon2,
                Telefon3 = x.Telefon3,
                Telefon4 = x.Telefon4,
                Fax = x.Fax,
                Web = x.Web,
                EMail = x.EMail,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                Adres = x.Adres,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                LegalEntity=x.LegalEntity,
                CustomerOrSuplier=x.CustomerOrSuplier,
                CompanyState=x.CompanyState,
                Location=x.Location,
                CurrencyCode=x.DefaultCurrency.Kod,
                CurrencyName=x.DefaultCurrency.DovizAdi,
            }).OrderBy(x => x.Kod).ToList();
        }

        //Bu Metod CariEdit ve ListForm Dışında işlem yaparken adres contact malzeme bilgilerine ulaşabilmek için tanımlnamıştı
    
        public  IEnumerable<BaseEntity> ListCompanyOtherInformations(Expression<Func<Cari, bool>> filter)
        {
            return BaseList(filter, x => new CariL
            {
                Id = x.Id,
                Kod = x.Kod,
                CariAdi = x.CariAdi,
                TcKimlikNo = x.TcKimlikNo,
                Telefon1 = x.Telefon1,
                Telefon2 = x.Telefon2,
                Telefon3 = x.Telefon3,
                Telefon4 = x.Telefon4,
                Fax = x.Fax,
                Web = x.Web,
                EMail = x.EMail,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                Adres = x.Adres,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                LegalEntity = x.LegalEntity,
                CustomerOrSuplier = x.CustomerOrSuplier,
                CompanyState = x.CompanyState,
                Location = x.Location,
                CurrencyCode = x.DefaultCurrency.Kod,
                CurrencyName = x.DefaultCurrency.DovizAdi,
                AddressItems = x.AddressItems,
                CompanyContact=x.CompanyContactItems,
                CompanyRelatedMaterials=x.CompanyRelatedMaterials,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
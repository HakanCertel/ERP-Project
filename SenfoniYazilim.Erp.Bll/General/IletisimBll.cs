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
    public class IletisimBll : BaseGenelBll<Iletisim>, IBaseGenelBll, IBaseCommonBll
    {
        public IletisimBll() : base(KartTuru.Iletisim){}

        public IletisimBll(Control ctrl) : base(ctrl, KartTuru.Iletisim){}

        public override BaseEntity Single(Expression<Func<Iletisim, bool>> filter)
        {
            return BaseSingle(filter, x => new IletisimS
            {
                Id = x.Id,
                Kod = x.Kod,
                TcKimlikNo=x.TcKimlikNo,
                Adi=x.Adi,
                Soyadi=x.Soyadi,
                BabaAdi=x.BabaAdi,
                AnaAdi=x.AnaAdi,
                DogumYeri=x.DogumYeri,
                DogumTarihi=x.DogumTarihi,
                KanGrubu=x.KanGrubu,
                KimlikSeri=x.KimlikSeri,
                KimlikSiraNo=x.KimlikSiraNo,
                KimlikIlId=x.KimlikIlId,
                KimlikIlAdi=x.KimlikIl.IlAdi,
                KimlikIlceId=x.KimlikIlceId,
                KimlikIlceAdi=x.KimlikIlce.IlceAdi,
                KimlikMahalleKoy=x.KimlikMahalleKoy,
                KimlikCiltNo=x.KimlikCiltNo,
                KimlikAileSiraNo=x.KimlikAileSiraNo,
                KimlikBireySiraNo=x.KimlikBireySiraNo,
                KimlikVerildiğiYer=x.KimlikVerildiğiYer,
                KimlikVerilisNedeni=x.KimlikVerilisNedeni,
                KimlikKayitNo=x.KimlikKayitNo,
                KimlikVerilisTarihi=x.KimlikVerilisTarihi,
                EvTelefonu=x.EvTelefonu,
                IsTelefonu1=x.IsTelefonu1,
                IsTelefonu2=x.IsTelefonu2,
                Dahili1=x.Dahili1,
                Dahili2=x.Dahili2,
                CepTelefonu1=x.CepTelefonu1,
                CepTelefonu2=x.CepTelefonu2,
                Web=x.Web,
                EMail=x.EMail,
                EvAdres=x.EvAdres,
                EvAdresIlId=x.EvAdresIlId,
                EvAdresIlAdi=x.EvAdresIl.IlAdi,
                EvAdresiIlceId=x.EvAdresiIlceId,
                IsAdresi=x.IsAdresi,
                IsAdresIlId=x.IsAdresIlId,
                IsAdresIlAdi=x.IsAdresIl.IlAdi,
                IsAdresIlceId=x.IsAdresIlceId,
                IsAdresIlceAdi =x.IsAdresIlce.IlceAdi,
                MeslekAdi=x.Meslek.MeslekAdi,
                IsyeriAdi=x.Isyeri.IsyeriAdi,
                GorevAdi=x.Gorev.GorevAdi,
                IbanNo=x.IbanNo,
                KartNo=x.KartNo,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum

            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Iletisim, bool>> filter)
        {
            return BaseList(filter, x => new IletisimL
            {
                Id = x.Id,
                Kod = x.Kod,
                TcKimlikNo = x.TcKimlikNo,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                BabaAdi = x.BabaAdi,
                AnaAdi = x.AnaAdi,
                DogumYeri = x.DogumYeri,
                DogumTarihi = x.DogumTarihi,
                KanGrubu = x.KanGrubu,
                KimlikSeri = x.KimlikSeri,
                KimlikSiraNo = x.KimlikSiraNo,
                KimlikIlAdi = x.KimlikIl.IlAdi,
                KimlikIlceAdi = x.KimlikIlce.IlceAdi,
                KimlikMahalleKoy = x.KimlikMahalleKoy,
                KimlikCiltNo = x.KimlikCiltNo,
                KimlikAileSiraNo = x.KimlikAileSiraNo,
                KimlikBireySiraNo = x.KimlikBireySiraNo,
                KimlikVerildiğiYer = x.KimlikVerildiğiYer,
                KimlikVerilisNedeni = x.KimlikVerilisNedeni,
                KimlikKayitNo = x.KimlikKayitNo,
                KimlikVerilisTarihi = x.KimlikVerilisTarihi,
                EvTelefonu = x.EvTelefonu,
                IsTelefonu1 = x.IsTelefonu1,
                IsTelefonu2 = x.IsTelefonu2,
                Dahili1 = x.Dahili1,
                Dahili2 = x.Dahili2,
                CepTelefonu1 = x.CepTelefonu1,
                CepTelefonu2 = x.CepTelefonu2,
                Web = x.Web,
                EMail = x.EMail,
                EvAdres = x.EvAdres,
                EvAdresIlAdi = x.EvAdresIl.IlAdi,
                IsAdresi = x.IsAdresi,
                IsAdresIlAdi = x.IsAdresIl.IlAdi,
                IsAdresIlceAdi = x.IsAdresIlce.IlceAdi,
                MeslekAdi = x.Meslek.MeslekAdi,
                IsyeriAdi = x.Isyeri.IsyeriAdi,
                GorevAdi = x.Gorev.GorevAdi,
                IbanNo = x.IbanNo,
                KartNo = x.KartNo,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama

            }).OrderBy(x => x.Kod).ToList();
        }
    }
}

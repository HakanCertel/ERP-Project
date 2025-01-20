using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
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
    public class IletisimBilgileriBll : BaseHareketBll<IletisimBilgileri, SenfoniErpContext>, IBaseHareketSelectBll<IletisimBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<IletisimBilgileri, bool>> filter)
        {
            return List(filter, x => new IletisimBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                IletisimId=x.IletisimId,
                TcKimlikNo=x.Iletisim.TcKimlikNo,
                Adi=x.Iletisim.Adi,
                Soyadi=x.Iletisim.Soyadi,
                EvTel=x.Iletisim.EvTelefonu,
                IsTel1=x.Iletisim.IsTelefonu1,
                IsTel2=x.Iletisim.IsTelefonu2,
                CepTel1=x.Iletisim.CepTelefonu1,
                CepTel2=x.Iletisim.CepTelefonu2,
                EvAdres=x.Iletisim.EvAdres,
                EvAdresIlAdi=x.Iletisim.EvAdresIl.IlAdi,
                EvAdresIlceAdi=x.Iletisim.EvAdresIlce.IlceAdi,
                IsAdres=x.Iletisim.IsAdresi,
                IsAdresIlAdi=x.Iletisim.IsAdresIl.IlAdi,
                IsAdresIlceAdi=x.Iletisim.IsAdresIlce.IlceAdi,
                IsyeriAdi=x.Iletisim.Isyeri.IsyeriAdi,
                YakinlikId=x.YakinlikId,
                YakinlikAdi=x.Yakinlik.YakinlikAdi,
                MeslekAdi=x.Iletisim.Meslek.MeslekAdi,
                GorevAdi=x.Iletisim.Gorev.GorevAdi,
                Veli=x.Veli,
                FaturaAdresi=x.FaturaAdresi
            }).ToList();
        }
    }
}

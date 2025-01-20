using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
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
    public class EPosBilgileriBll:BaseHareketBll<EPosBilgileri, SenfoniErpContext>, IBaseHareketSelectBll<EPosBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<EPosBilgileri, bool>> filter)
        {
            var entities = List(filter, x => new EposBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                BankaId=x.BankaId,
                BankaAdi=x.Banka.BankaAdi,
                Adi=x.Adi,
                Soyadi=x.Soyadi,
                KartTuru=x.KartTuru,
                KartNo=x.KartNo,
                SonKullanmaTarihi=x.SonKullanmaTarihi,
                GuvenlikKodu=x.GuvenlikKodu
            }).ToList();

            
                foreach (EposBilgileriL entity in entities)
                {
                    var anahtar = entity.TahakkukId + "" + entity.BankaId;
                    entity.KartNo = entity.KartNo.Decrypt(anahtar);
                    entity.SonKullanmaTarihi = entity.SonKullanmaTarihi.Decrypt(anahtar);
                    entity.GuvenlikKodu = entity.GuvenlikKodu.Decrypt(anahtar);
                }
            
            return entities;
        }

        public override bool Insert(IList<BaseHareketEntity> entities)
        {
            foreach (EposBilgileriL entity in entities)
            {
                var anahtar = entity.TahakkukId + "" + entity.BankaId;
                entity.KartNo = entity.KartNo.Encrypt(anahtar);
                entity.SonKullanmaTarihi = entity.SonKullanmaTarihi.Encrypt(anahtar);
                entity.GuvenlikKodu = entity.GuvenlikKodu.Encrypt(anahtar);
            }

            return base.Insert(entities);
        }
        public override bool Update(IList<BaseHareketEntity> entities)
        {
            foreach (EposBilgileriL entity in entities)
            {
                var anahtar = entity.TahakkukId + "" + entity.BankaId;
                entity.KartNo = entity.KartNo.Encrypt(anahtar);
                entity.SonKullanmaTarihi = entity.SonKullanmaTarihi.Encrypt(anahtar);
                entity.GuvenlikKodu = entity.GuvenlikKodu.Encrypt(anahtar);
            }

            return base.Update(entities);
        }
    }
}

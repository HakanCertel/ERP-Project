using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.YardimciFormTablo
{
    public class EvrakTurleriBll : BaseHareketBll<EvrakTurleri, SenfoniErpContext>, IBaseHareketSelectBll<EvrakTurleri>

    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<EvrakTurleri, bool>> filter)
        {
            return List(filter, x => new EvrakTurleriL
            {
                Id = x.Id,
                KayitTarihi=x.KayitTarihi,
                KaydiGuncelleyen=x.KaydiGuncelleyen,
                KaydiOlusturan=x.KaydiOlusturan,
                GuncellemeTarihi=x.GuncellemeTarihi,
                EvrakTurKodu=x.EvrakTurKodu,
                EvrakTurAdi=x.EvrakTurAdi,
                EvrakTurTipi=x.EvrakTurTipi,
                StokEtkilenir=x.StokEtkilenir,
                Durum=x.Durum,
                EFaturaOlusturulamaz=x.EFaturaOlusturulamaz
            }).ToList();
        }
    }
}

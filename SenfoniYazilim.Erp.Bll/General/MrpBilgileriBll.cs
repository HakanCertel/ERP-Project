using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.ProductionManagmentEntites.MrpEntites;
using SenfoniYazilim.Erp.Model.ProductionMangmentDto.MrpDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class MrpBilgileriBll:BaseHareketBll<MrpBilgileri, SenfoniErpContext>, IBaseHareketSelectBll<MrpBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<MrpBilgileri, bool>> filter)
        {
            return List(filter, x => new MrpBilgileriL
            {
                Id = x.Id,
                MrpId=x.MrpId,
                ReceteId=x.ReceteId,
                DemandId=x.DemandId,
                DemanItemId=x.DemanItemId,
                DemandCode=x.DemandCode,
                DemandStatu=x.DemandStatu,
                DemandInformationId=x.DemandInformationId,
                StokId=x.StokId,
                StokKodu=x.Stok.Kod,
                StokAdi=x.Stok.StockName,
                BaslangicTarihi=x.BaslangicTarihi,
                BitisTarihi=x.BitisTarihi,
                Birim=x.Stok.Unit.Kod,
                Miktar=x.Miktar,
                Cinsi=x.Cinsi,
                CurrentId=x.CurrentId,
                PersonelId=x.PersonelId,
                UserId=x.UserId,
                IsTakenToProcess=x.IsTakenToProcess,
                MrpCreatingMethod=x.MrpCreatingMethod
            }).ToList();
        }
    }
}



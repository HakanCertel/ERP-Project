using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.WareHousesDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.WareHouseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.General.WarehouseBll
{
    public class WarehouseSettingsBll : BaseHareketBll<WarehouseSettings, SenfoniErpContext>, IBaseHareketSelectBll<WarehouseSettings>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<WarehouseSettings, bool>> filter)
        {
            return List(filter, x => new WarehouseSettingsL
            {
                Id = x.Id,
                WarehouseId=x.WarehouseId,
                UserId=x.UserId,
                KullaniciAdiSoyadi=x.User.Adi+" "+x.User.Soyadi,
                KullaniciYetkisi=x.KullaniciYetkisi,
                CanDemand=x.CanDemand,
                CanTransfer=x.CanTransfer,
            }).ToList();
        }
    }
}

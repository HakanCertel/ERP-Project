using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.MaterialDtos;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.MeterialEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Bll.General.MaterialBlls
{
    public class MaterialUnitsBll : BaseHareketBll<MeterialUnits, SenfoniErpContext>, IBaseHareketSelectBll<MeterialUnits>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<MeterialUnits, bool>> filter)
        {
            return List(filter, x => new MaterialUnitL
            {
                Id = x.Id,
                MaterialId = x.MaterialId,
                UnitId = x.UnitId,
                MaterialUnitCode = x.Material.Unit.Kod,
                MaterialUnitName = x.Material.Unit.BirimAdi,
                ConversionRate=x.ConversionRate,
                IsActive = x.IsActive,

            }).ToList();
        }
    }
}


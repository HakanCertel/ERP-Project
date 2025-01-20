using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.CRPDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.CRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Bll.General.CRP
{
    public class WorkOrderMaterialItemsBll : BaseHareketBll<WorkOrderMaterialItems, SenfoniErpContext>, IBaseHareketSelectBll<WorkOrderMaterialItems>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<WorkOrderMaterialItems, bool>> filter)
        {
            return List(filter, x => new WorkOrderMaterialItemsL
            {
                Id = x.Id,
                OwnerFormId=x.OwnerFormId,
                OwnerFormCode = x.OwnerForm.Kod,
                MrpBilgileriId = x.MrpBilgileriId,
                MalzemeIhtiyacBilgileriId = x.MalzemeIhtiyacBilgileriId,
                BagliOlduguReceteId = x.BagliOlduguReceteId,
                MaterialId = x.MaterialId,
                MaterialCode = x.Material.Kod,
                MaterialName = x.Material.StockName,
                WarehouseId = x.WarehouseId,
                WarehouseCode = x.Warehouse.Kod,
                WarehouseName = x.Warehouse.WarehouseName,
                UnitId = x.UnitId,
                UnitCode = x.Unit.Kod,
                UnitName=x.Unit.BirimAdi,
                UnitQty=x.UnitQty,
                WastageQty=x.WastageQty,
                TotalRequestQty=x.OwnerForm.IsEmriMiktari*x.UnitQty, 
                RemainingRequestQty=(x.OwnerForm.IsEmriMiktari-x.OwnerForm.UretilenMiktar)*x.UnitQty,

            }).ToList();

        }
    }
}


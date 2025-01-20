using SenfoniYazilim.Erp.Bll.Base;
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
    public class RezervasyonBilgileriBll : BaseHareketBll<RezervasyonBilgileri, SenfoniErpContext>
    {
        public BaseHareketEntity Single(Expression<Func<RezervasyonBilgileri, bool>> filter)
        {
            return BaseSingle(filter, x => new RezervasyonBilgileriL
            {
                Id=x.Id,
                MaterialId=x.MaterialId,
                MaterialCode=x.Material.Kod,
                MaterialName=x.Material.StockName,
                UserId=x.UserId,
                UserName=x.User.Adi,
                OwnerFromName=x.OwnerFromName,
                GrupId=x.GrupId,
                GrupAdi=x.GrupAdi,
                WarehouseId=x.WarehouseId,
                WarehouseCode=x.Warehouse.Kod,
                WarehouseName=x.Warehouse.WarehouseName,
                Description=x.Description,
                OwnerFormId=x.OwnerFormId,
                TotalMaterialQty = x.Material.WareHouseStocks.Where(y => y.MaterialId == x.MaterialId && y.WareHouseId == x.WarehouseId).Select(y => y.Quantity).Sum(),
                TotalRezervedQty=x.Material.RezervasyonBilgileri.Where(y=>y.MaterialId==x.MaterialId).Select(y=>y.RezervedQty).Sum(),
                Birim=x.Material.Unit.Kod,  
                RezervedQty=x.RezervedQty,
            });
        }
        public IEnumerable<BaseHareketEntity> List(Expression<Func<RezervasyonBilgileri, bool>> filter)
        {
            return List(filter, x => new
            {
                rezerve = x,
                totalRezervedQty = x.Material.RezervasyonBilgileri.GroupBy(y => y.MaterialId).DefaultIfEmpty().Select(y => new
                {
                    toplamRezervasyonMiktari = y.Select(z => z.RezervedQty).Sum(),
                }).FirstOrDefault(),
                totalMaterialQty = x.Material.WareHouseStocks.GroupBy(y => y.MaterialId).DefaultIfEmpty().Select(y => new
                {
                    toplamStokMiktari = y.Where(z => z.MaterialId == x.MaterialId).Select(z => z.Quantity).FirstOrDefault()
                }).FirstOrDefault(),
                
            }).Select(y => new RezervasyonBilgileriL
            {
                Id = y.rezerve.Id,
                UserId = y.rezerve.UserId,
                UpdatingUserId=y.rezerve.UpdatingUserId,
                UserName = y.rezerve.User.Kod,
                MaterialId = y.rezerve.MaterialId,
                MaterialCode = y.rezerve.Material.Kod,
                MaterialName = y.rezerve.Material.StockName,
                RezervedQty = y.rezerve.RezervedQty,
                TotalMaterialQty = y.totalMaterialQty.toplamStokMiktari,
                TotalRezervedQty=y.totalRezervedQty.toplamRezervasyonMiktari,
                OwnerFromName=y.rezerve.OwnerFromName,
                OwnerFormItemId=y.rezerve.OwnerFormItemId,
                OwnerFormId=y.rezerve.OwnerFormId,
                OpenQty=y.totalMaterialQty.toplamStokMiktari - y.totalRezervedQty.toplamRezervasyonMiktari,
                Description=y.rezerve.Description,
                WarehouseId=y.rezerve.WarehouseId,
                WarehouseCode=y.rezerve.Warehouse.Kod,
                WarehouseName=y.rezerve.Warehouse.WarehouseName,
                UnitId=y.rezerve.UnitId,
                Birim=y.rezerve.Birim,
                Grup=y.rezerve.Grup,
                GrupId=y.rezerve.GrupId,
                GrupAdi=y.rezerve.GrupAdi,
                
            }).ToList();
        }
    }
}

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

namespace SenfoniYazilim.Erp.Bll
{
    public class ProductionDemandInformationsBll : BaseHareketBll<ProductionDemandInformations, SenfoniErpContext>, IBaseHareketSelectBll<ProductionDemandInformations>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<ProductionDemandInformations, bool>> filter)
        {
            return List(filter, x => new ProductionDemandInformationsL
            {
                Id = x.Id,
                DemandId=x.DemandId,
                UserId=x.UserId,
                StockId=x.StockId,
                StockCode=x.Stock.Kod,
                StockName=x.Stock.StockName,
                Unit=x.Stock.Unit.Kod,
                Quantity=x.Quantity,
                Species=x.Species,
                OrderDate=x.OrderDate,
                DeliveryDate=x.DeliveryDate
            }).ToList();
        }
        public IEnumerable<BaseEntity> DemandInformationsList(Expression<Func<ProductionDemandInformations, bool>> filter)
        {
            return List(filter, x => new DemandInformationsMultiL
            {
                Id = x.Id,
                DemandId=x.DemandId,
                DemandCode=x.DemandCode,
                DemandStatus=x.DemandStatu,
                UserId=x.UserId,
                UserName=x.User.Adi,
                StockId = x.StockId,
                StockCode = x.Stock.Kod,
                StockName = x.Stock.StockName,
                Unit = x.Stock.Unit.Kod,
                Producible=x.Stock.Uretilebilir,
                Quantity = x.Quantity,
                Species = x.Species,
                OrderDate = x.OrderDate,
                DeliveryDate = x.DeliveryDate,
                CurrentId=x.CurrentId,
                CurrentName=x.Current.CariAdi,
                PlasiyerId=x.PersonelId,
                PlasiyerName=x.Personel.Adi,

            }).Where(x=>x.Producible).ToList();
        }
    }
}

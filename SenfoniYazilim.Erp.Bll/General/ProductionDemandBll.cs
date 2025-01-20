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
    public class ProductionDemandBll : BaseGenelBll<ProductionDemand>, IBaseGenelBll, IBaseCommonBll
    {
        public ProductionDemandBll() : base(KartTuru.ProductionDemand) { }

        public ProductionDemandBll(Control ctrl) : base(ctrl, KartTuru.ProductionDemand) { }

        public override BaseEntity Single(Expression<Func<ProductionDemand, bool>> filter)
        {
            return BaseSingle(filter, x => new ProductionDemandS
            {
                Id = x.Id,
                Kod = x.Kod,
                UserId = x.UserId,
                UserName = x.User.Adi,
                OperationDate = x.OperationDate,
                DeliveryDate = x.DeliveryDate,
                IsDone = x.IsDone,
                IsCanceled = x.IsCanceled,
                ReasonOfCancel = x.ReasonOfCancel,
                Description = x.Description,
                Durum = x.Durum
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<ProductionDemand, bool>> filter)
        {
            return BaseList(filter, x => new ProductionDemandL
            {
                Id = x.Id,
                Kod = x.Kod,
                UserId = x.UserId,
                UserName = x.User.Adi,
                OperationDate = x.OperationDate,
                DeliveryDate = x.DeliveryDate,
                IsCanceled = x.IsCanceled,
                IsDone = x.IsDone,
                ReasonOfCancel = x.ReasonOfCancel,
                Description = x.Description,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}


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
    public class OrderDemandBll : BaseGenelBll<OrderDemand>, IBaseGenelBll, IBaseCommonBll
    {
        public OrderDemandBll() : base(KartTuru.Order) { }

        public OrderDemandBll(Control ctrl) : base(ctrl, KartTuru.Order) { }

        public override BaseEntity Single(Expression<Func<OrderDemand, bool>> filter)
        {
            return BaseSingle(filter, x => new OrderDemandS
            {
                Id = x.Id,
                Kod = x.Kod,
                CurrentId=x.CurrentId,
                CurrentCode=x.Current.Kod,
                CurrentName=x.Current.CariAdi,
                PlasiyerId=x.PlasiyerId,
                PlasiyerCode=x.Plasiyer.Kod,
                PlasiyerName=x.Plasiyer.Adi,
                UserId=x.UserId,
                UserName=x.User.Adi,
                OperationDate=x.OperationDate,
                DeliveryDate=x.DeliveryDate,
                IsDone=x.IsDone,
                IsCanceled=x.IsCanceled,
                ReasonOfCancel=x.ReasonOfCancel,
                Description=x.Description,
                Durum = x.Durum
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<OrderDemand, bool>> filter)
        {
            return BaseList(filter, x => new OrderDemandL
            {
                Id = x.Id,
                Kod = x.Kod,
                CurrentId = x.CurrentId,
                CurrentCode = x.Current.Kod,
                CurrentName = x.Current.CariAdi,
                PlasiyerId = x.PlasiyerId,
                PlasiyerCode = x.Plasiyer.Kod,
                PlasiyerName = x.Plasiyer.Adi,
                UserId=x.UserId,
                UserName=x.User.Adi,
                OperationDate = x.OperationDate,
                DeliveryDate = x.DeliveryDate,
                IsCanceled=x.IsCanceled,
                IsDone=x.IsDone,
                ReasonOfCancel=x.ReasonOfCancel,
                Description = x.Description,
                Status = x.Durum
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}

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
    public class MakinaBll : BaseGenelBll<Makina>, IBaseGenelBll, IBaseCommonBll
    {
        public MakinaBll() : base(KartTuru.Makina){}

        public MakinaBll(Control ctrl) : base(ctrl, KartTuru.Makina){}

        public override BaseEntity Single(Expression<Func<Makina, bool>> filter)
        {
            return BaseSingle(filter, x => new MakinaS
            {
                Id=x.Id,
                Kod=x.Kod,
                MakinaAdi=x.MakinaAdi,
                MakinaTanimi=x.MakinaTanimi,
                OperasyonId=x.OperasyonId,
                OperasyonAdi=x.Operasyon.OperasyonAdi,
                Istasyon=x.Istasyon,
                Aciklama=x.Aciklama,
                IsCapacityBasedWorker=x.IsCapacityBasedWorker,
                Durum=x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Makina, bool>> filter)
        {
            return BaseList(filter,x=> new MakinaL
            {
                Id=x.Id,
                Kod=x.Kod,
                MakinaAdi=x.MakinaAdi,
                MakinaTanimi=x.MakinaTanimi,
                OperasyonAdi=x.Operasyon.OperasyonAdi,
                IsCapacityBasedWorker=x.IsCapacityBasedWorker,
                KapasiteBagi=x.IsCapacityBasedWorker?"Çalışana Bağlı":"Makineye Bağlı",
                Aciklama=x.Aciklama
            }).ToList();
        }
    }
}

using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class PurchaseDemandBll : BaseGenelBll<SatinalmaTalep>, IBaseGenelBll, IBaseCommonBll
    {
        public PurchaseDemandBll() : base(KartTuru.SatinalmaTalep) { }

        public PurchaseDemandBll(Control ctrl) : base(ctrl, KartTuru.SatinalmaTalep) { }

        public override IEnumerable<BaseEntity> List(Expression<Func<SatinalmaTalep, bool>> filter)
        {
            return BaseList(filter, x => new SatınalmaTalepL
            {
                Id = x.Id,
                ProjeId=x.ProjeId,
                PurchaseDemandResponsibilityId=x.PurchaseDemandResponsibilityId,
                Kod = x.Kod,
                RecordDate=x.RecordDate,
                CreatorName=x.Creator.Adi+" "+x.Creator.Soyadi,
                UpdatingDate=x.UpdatingDate,
                UpdatingName=x.Updating.Adi+" "+x.Updating.Soyadi,
                DocumentDate=x.DocumentDate,
                DemandDescription=x.DemandDescription,
                ResponsibilityName=x.PurchaseDemandResponsibility.Adi+" "+ x.PurchaseDemandResponsibility.Soyadi,
                File =x.File,
                Durum=x.Durum,
                IsLock=x.IsLock,
                
            }).ToList();
        }

    }
}
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
    public class PurchaseOfferBll : BaseGenelBll<PurchaseOffer>, IBaseGenelBll, IBaseCommonBll
    {
        public PurchaseOfferBll() : base(KartTuru.PurchaseOffer) { }

        public PurchaseOfferBll(Control ctrl) : base(ctrl, KartTuru.PurchaseOffer) { }

        public override BaseEntity Single(Expression<Func<PurchaseOffer, bool>> filter)
        {
            return BaseSingle(filter, x => new PurchaseOfferS
            {
                Id = x.Id,
                Kod = x.Kod,
                PurchaseOfferCreatingMethod=x.PurchaseOfferCreatingMethod,
                CompanyId=x.CompanyId,
                OfferedCompanyName=x.Company.CariAdi,
                OfferDescription = x.OfferDescription,
                ValidityStarDate=x.ValidityStarDate,
                ValidityEndDate=x.ValidityEndDate,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<PurchaseOffer, bool>> filter)
        {
            return BaseList(filter, x => new PurchaseOfferS
            {
                Id = x.Id,
                Kod = x.Kod,
                CompanyId=x.CompanyId,
                PurchaseOfferCreatingMethod=x.PurchaseOfferCreatingMethod,
                OfferedCompanyName=x.Company.CariAdi,
                OfferDescription = x.OfferDescription,
                ValidityStarDate=x.ValidityStarDate,
                ValidityEndDate=x.ValidityEndDate,
                Durum=x.Durum
            }).OrderBy(x => x.ValidityStarDate).ToList();
        }
    }
}


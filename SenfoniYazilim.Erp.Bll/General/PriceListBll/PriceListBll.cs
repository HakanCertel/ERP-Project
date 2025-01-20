using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto.PriceListDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.PriceListEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General.PriceListBll
{
    public class PriceListBll : BaseGenelBll<PriceList>, IBaseGenelBll, IBaseCommonBll
    {
        public PriceListBll() : base(KartTuru.PriceList) { }

        public PriceListBll(Control ctrl) : base(ctrl, KartTuru.PriceList) { }

        public override BaseEntity Single(Expression<Func<PriceList, bool>> filter)
        {
            return BaseSingle(filter, x => new PriceListS
            {
                Id = x.Id,
                Kod = x.Kod,
                CurrencyTypeId=x.CurrencyTypeId,
                ListName=x.ListName,
                ValidityStartDate=x.ValidityStartDate,
                VailidityEndDate=x.VailidityEndDate,
                Description=x.Description,
                CurrencyCode=x.CurrencyType.Kod,
                CurrencyName=x.CurrencyType.DovizAdi,
                Durum = x.Durum,
                IsComfirmed=x.IsComfirmed,
                IsLocked=x.IsLocked,
                CreatorUserId=x.CreatorUserId,
                CreatorUserName=x.CreatorUser.Adi,
                UpdatingUserId=x.UpdatingUserId,
                UpdatingUserName=x.UpdatingUser.Adi,
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<PriceList, bool>> filter)
        {
            return BaseList(filter, x => new PriceListL
            {
                Id = x.Id,
                Kod = x.Kod,
                ListName=x.ListName,
                ValidityStartDate=x.ValidityStartDate,
                VailidityEndDate=x.VailidityEndDate,
                Description=x.Description,
                CurrencyId=x.CurrencyTypeId,
                CurrencyCode=x.CurrencyType.Kod,
                CurrencyName=x.CurrencyType.DovizAdi,
                Durum=x.Durum,
                IsComfirmed=x.IsComfirmed,
                CreatorUserName=x.CreatorUser.Adi,
                UpdatingUserName=x.UpdatingUser.Adi
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}

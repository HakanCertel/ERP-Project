using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Bll.YardimciFormTablo
{
    public class AddressItemsBll : BaseHareketBll<AddressItems, SenfoniErpContext>, IBaseHareketSelectBll<AddressItems>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<AddressItems, bool>> filter)
        {
            return List(filter, x => new AddressItemsL
            {
                Id = x.Id,
                CompanyId=x.CompanyId,
                CountryId=x.CountryId,
                CityId=x.CityId,
                CountyId=x.CountyId,
                PostCode=x.PostCode,
                District=x.District,
                Street=x.Street,
                Number=x.Number,
                Build=x.Build,
                Floor=x.Floor,
                Apartment=x.Apartment,
                OpenAddress=x.OpenAddress,
                IsBranch=x.IsBranch,
                IsDefault=x.IsDefault,
                BranchName=x.BranchName,
                CityName=x.City.IlAdi,
                CountyName=x.County.IlceAdi,
                CountryName=x.Country.CountryName,
                EntireAddress=x.EntireAddress
            }).ToList();
        }
    }
}


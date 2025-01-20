using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.Company;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Company.CompanySetting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.General.Company
{
    public class CompanyRelatedMaterialsBll : BaseHareketBll<CompanyRelatedMaterials, SenfoniErpContext>, IBaseHareketSelectBll<CompanyRelatedMaterials>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<CompanyRelatedMaterials, bool>> filter)
        {
            return List(filter, x => new CompanyRelatedMaterialsL
            {
                Id = x.Id,
                MaterialId=x.MaterialId,
                CompanyId=x.CompanyId,
                CompanyMaterialUnitId=x.CompanyMaterialUnitId,
                PackagingId=x.PackagingId,
                MinOrderQty=x.MinOrderQty,
                MaxOrderQty=x.MaxOrderQty,
                ContractId=x.ContractId,
                UnitPrice=x.UnitPrice,
                DiscountRate=x.DiscountRate,
                DeliveryDate=x.DeliveryDate,
                BarcodeNumber=x.BarcodeNumber,
                CompanyMaterialCode=x.CompanyMaterialCode,
                CompanyMaterialName=x.CompanyMaterialName,
                IsActive=x.IsActive,
                MaterialCode=x.Material.Kod,
                MaterialName=x.Material.StockName,
                MaterialUnit=x.Material.Unit.Kod,
                CompanyMaterialUnitName=x.CompanyMaterialUnit.BirimAdi,
                PackagingDescription=x.Packaging.Description,
                
            }).ToList();
        }
    }
}
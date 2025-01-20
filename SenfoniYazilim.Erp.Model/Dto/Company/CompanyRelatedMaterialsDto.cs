using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.Company.CompanySetting;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.Company
{
    [NotMapped]
    public class CompanyRelatedMaterialsL : CompanyRelatedMaterials, IBaseHareketEntity
    {
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialUnit { get; set; }
        public string CompanyMaterialUnitName { get; set; }
        public string PackagingDescription { get; set; }
        public string ContractName { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

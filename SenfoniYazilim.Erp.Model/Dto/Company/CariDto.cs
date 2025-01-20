using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Company;
using SenfoniYazilim.Erp.Model.Entities.Company.CompanySetting;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class CariS:Cari
    {
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
    }

    public class CariL:BaseEntity
    {
        public string CariAdi { get; set; }

        public string TcKimlikNo { get; set; }

        public string Telefon1 { get; set; }

        public string Telefon2 { get; set; }

        public string Telefon3 { get; set; }

        public string Telefon4 { get; set; }

        public string Fax { get; set; }

        public string Web { get; set; }

        public string EMail { get; set; }

        public string VergiDairesi { get; set; }

        public string VergiNo { get; set; }

        public string Adres { get; set; }

        public string OzelKod1Adi { get; set; }

        public string OzelKod2Adi { get; set; }

        public string Aciklama { get; set; }

        public LegalEntity LegalEntity { get; set; }

        public CustomerOrSuplier CustomerOrSuplier { get; set; }

        public CompanyState CompanyState { get; set; }

        public Location Location { get; set; }

        public string CurrencyCode { get; set; }

        public string CurrencyName { get; set; }

        public ICollection<AddressItems> AddressItems { get; set; }

        public ICollection<CompanyContact> CompanyContact { get; set; }

        public ICollection<CompanyRelatedMaterials> CompanyRelatedMaterials { get; set; }

    }
}

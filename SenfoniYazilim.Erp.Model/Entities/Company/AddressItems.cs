using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;

namespace SenfoniYazilim.Erp.Model.Entities.Company
{
    public class AddressItems:BaseHareketEntity
    {
        public long CompanyId { get; set; }

        public long? CountryId { get; set; }
        public long? CityId { get; set; }
        public long? CountyId { get; set; }
        public string PostCode { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Build { get; set; }
        public string Floor { get; set; }
        public string Apartment { get; set; }
        public string OpenAddress { get; set; }
        public string BranchName { get; set; }
        public string EntireAddress { get; set; }
        public bool IsBranch { get; set; }
        public bool IsDefault { get; set; }

        public Il City { get; set; }
        public Ilce County { get; set; }
        public Cari Company { get; set; }
        public Country Country { get; set; }
    }
}

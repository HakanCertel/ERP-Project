using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.Company;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto
{
    [NotMapped]
    public class AddressItemsL:AddressItems, IBaseHareketEntity
    {
        public string CityName { get; set; }
        public string CountyName { get; set; }
        public string CountryName { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

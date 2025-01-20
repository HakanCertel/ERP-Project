using SenfoniYazilim.Erp.Model.Entities.Base;
using System.Collections.Generic;

namespace SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity
{
    public class Country:BaseEntityDurum
    {
        public string CountryName { get; set; }
        public string Description { get; set; }

        public ICollection<Il> Il { get; set; }
    }
}

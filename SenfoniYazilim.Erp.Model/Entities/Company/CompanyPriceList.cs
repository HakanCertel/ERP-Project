using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.PriceListEntities;
using System.Collections.Generic;

namespace SenfoniYazilim.Erp.Model.Entities.Company
{
    public class CompanyPriceList:BaseHareketEntity
    {
        public long CompanyId { get; set; }
        public long CompanyPriceListsId { get; set; }
        public bool IsDefault { get; set; }
        
        public Cari Company { get; set; }
        public PriceList CompanyPriceLists { get; set; }

    }
}

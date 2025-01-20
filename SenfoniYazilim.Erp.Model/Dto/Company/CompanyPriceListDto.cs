using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.Company;
using SenfoniYazilim.Erp.Model.Entities.PriceListEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.Company
{
    [NotMapped]
    public class CompanyPriceListL:CompanyPriceList,IBaseHareketEntity
    {
        public long? CurrencyId { get; set; }
        public string CompanyPriceListCode { get; set; }
        public string CompanyPriceListName { get; set; }
        public string CompanyPriceListDescription { get; set; }
        public string CompanyPriceListCurrencyCode { get; set; }
        public string CompanyPriceListCurrencyName { get; set; }
        public DateTime CompanyPriceListValidityStart { get; set; }
        public DateTime CompanyPriceListValidityEnd { get; set; }
        public ICollection<PriceListItems> PriceListItems { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

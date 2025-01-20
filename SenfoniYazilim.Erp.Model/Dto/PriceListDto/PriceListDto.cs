using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.PriceListEntities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.PriceListDto
{
    [NotMapped]
    public class PriceListS : PriceList
    {
        public string CreatorUserName { get; set; }
        public string UpdatingUserName { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
    }
    [NotMapped]
    public class PriceListL:BaseEntityDurum
    {
        public long? CurrencyId { get; set; }
        public string CreatorUserName { get; set; }
        public string UpdatingUserName { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public bool IsComfirmed { get; set; }
        public string ListName { get; set; }
        public DateTime ValidityStartDate { get; set; }
        public DateTime VailidityEndDate { get; set; }
        public string Description { get; set; }
    }
    
}

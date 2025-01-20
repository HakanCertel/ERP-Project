using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using System.Collections.Generic;

namespace SenfoniYazilim.Erp.Model.Entities.PriceListEntities
{
    public class PriceList:BaseEntityDurum
    {
        public long? CurrencyTypeId { get; set; }
        public long CreatorUserId { get; set; }
        public long? UpdatingUserId { get; set; }
        public string ListName { get; set; }
        public string Description { get; set; }
        public DateTime VailidityEndDate { get; set; }
        public DateTime ValidityStartDate { get; set; }
        public bool IsComfirmed { get; set; }
        public bool IsLocked { get; set; }

        public Material Material { get; set; }
        public Birim Unit { get; set; }
        public DovizBilgileri CurrencyType { get; set; }
        public Kullanici CreatorUser { get; set; }
        public Kullanici UpdatingUser { get; set; }

        public ICollection<PriceListItems> PriceListItems { get; set; }
    }
}

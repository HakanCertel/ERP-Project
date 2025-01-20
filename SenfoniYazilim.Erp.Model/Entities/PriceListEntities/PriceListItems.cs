using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;

namespace SenfoniYazilim.Erp.Model.Entities.PriceListEntities
{
    public class PriceListItems:BaseHareketEntity
    {
        public long PriceListId { get; set; }
        public long MaterialId { get; set; }
        public long UnitId { get; set; }
        public decimal ItemPrice { get; set; }
        public DateTime ValidityStartDate { get; set; }
        public DateTime ValidityEndDate { get; set; }
        public string PriceListItemDescription { get; set; }
        public Material Material { get; set; }
        public Birim Unit { get; set; }
        public PriceList PriceList { get; set; }
    }
}

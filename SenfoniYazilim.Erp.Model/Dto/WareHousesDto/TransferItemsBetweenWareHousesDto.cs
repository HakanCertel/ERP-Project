using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class TarnsferItemsBetweenWareHousesL : TransferItemsBetweenWareHouses, IBaseHareketEntity
    {
        public string DemandSourceDescription { get; set; }
        public string OwnerFormCode { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialUnitCode { get; set; }
        public string MaterialUnitName { get; set; }
        public string UnitCodeOfTransfer { get; set; }
        public string BirimAdi { get; set; }
        public string TransferWareHouseCode{ get; set; }
        public string TransferWareHouseName{ get; set; }
        public string TransferedWareHouseCode{ get; set; }
        public string TransferedWareHousename { get; set; }
        public decimal? MaterialQuantity { get; set; }
        public decimal RemainingMaterialQuantity { get; set; }
        public decimal? OpenQuantity { get; set; }
        public decimal ItemRezervedQyt { get; set; }
        public decimal? RezerveQuantity{ get; set; }
        public decimal RequestQuantity { get; set; }
        public decimal RemainingQuantity { get; set; }
        public string DemandingUserName { get; set; }
        public string CreatorUserName { get; set; }
        public RecordItemStatus RecordItemStatus { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

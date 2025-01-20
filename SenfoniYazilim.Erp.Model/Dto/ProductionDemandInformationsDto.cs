using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class ProductionDemandInformationsL : ProductionDemandInformations, IBaseHareketEntity
    {
        public string StockCode{ get; set; }
        public string StockName { get; set; }
        public string CurrentCode{ get; set; }
        public string CurrentName { get; set; }
        public string UserName { get; set; }
        public string PersonelNameAndLastName{ get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
    public class DemandInformationsMultiL : BaseEntity
    {
        public long DemandId { get; set; }
        public string DemandCode { get; set; }
        public DemandStatus DemandStatus { get; set; }
        public long StockId { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool Producible { get; set; }
        public string Species { get; set; }
        public long? CurrentId { get; set; }
        public string CurrentName { get; set; }
        public long? PlasiyerId { get; set; }
        public string PlasiyerName{ get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
    }
}
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class ProductionDemandInformations:BaseHareketEntity
    {
        public long DemandId { get; set; }
        public string DemandCode{ get; set; }
        public DemandStatus DemandStatu { get; set; }
        public long StockId { get; set; }
        public long? CurrentId { get; set; }
        public long UserId { get; set; }
        public long? PersonelId { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime DeliveryDate { get; set; }
        public string Species { get; set; }
        public bool IsTakenToProcess { get; set; }
        public bool IsProcessDone { get; set; }

        public Kullanici User { get; set; }
        public Cari Current { get; set; }
        public Personel Personel { get; set; }
        public Material Stock { get; set; }
    }
}

using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace SenfoniYazilim.Erp.Model.Entities.Satınalma
{
    public class PurchaseDemandItemsFeature:BaseHareketEntity
    {
        public KartTuru BaseCard { get; set; }

        public long OwnerFormId { get; set; }

        public long MaterialId { get; set; }

        [Required, StringLength(1000)]
        public string FeatureDescription { get; set; }

        public byte[] Document { get; set; }

        public Material Material { get; set; }
    }
}

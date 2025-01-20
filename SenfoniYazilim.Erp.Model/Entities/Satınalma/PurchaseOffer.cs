using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities.Satınalma
{
    public class PurchaseOffer:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        //[ZorunluAlan("Firma Adı", "txtOfferedCompanyName")]
        public long? CompanyId { get; set; }
        [StringLength(500)]
        public string OfferDescription { get; set; }
        public DateTime? ValidityStarDate { get; set; }
        public DateTime? ValidityEndDate { get; set; }
        public PurchaseOfferCreatingMethod PurchaseOfferCreatingMethod { get; set; } = PurchaseOfferCreatingMethod.ChoosePurchaseDemandItem;
        public Cari Company { get; set; }

        public ICollection<PurchaseOfferItems> PurchaseOfferItems { get; set; }
    }
}

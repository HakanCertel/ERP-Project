using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.Satınalma
{
    [NotMapped]
    public class PurchaseOfferS:PurchaseOffer
    {
        public string OfferedCompanyName { get; set; }
    }
}

using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity
{
    public class PaymentMethodItems:BaseHareketEntity
    {
        public int LanguageId { get; set; }
        public string PaymentMethodCode { get; set; }
        public string PaymentMetheodDescription { get; set; }
        public bool IsActive { get; set; }
        public Language Language { get; set; }
    }
}

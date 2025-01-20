using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto
{
    [NotMapped]
    public class PaymentMethodItemsL : PaymentMethodItems, IBaseHareketEntity
    {
        public string LanguageCode { get; set; }
        public string LanguageDescription { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

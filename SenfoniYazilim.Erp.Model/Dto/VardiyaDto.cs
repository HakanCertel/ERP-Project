using SenfoniYazilim.Erp.Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class VardiyaS:Vardiya
    {
        public decimal Saat { get; set; }
        public decimal Dakika { get; set; }
        public int Saniye { get; set; }
    }
}

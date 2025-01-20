using SenfoniYazilim.Erp.Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class KurumBilgileriS:KurumBilgileri
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
    }
}

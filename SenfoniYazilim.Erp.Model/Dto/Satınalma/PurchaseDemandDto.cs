using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.Satınalma
{
    [NotMapped]
    public class SatınalmaTalepL:SatinalmaTalep
    {
        public string ProjeAdi { get; set; }
        public string ResponsibilityName { get; set; }
        public string CreatorName { get; set; }
        public string UpdatingName { get; set; }
    }
}

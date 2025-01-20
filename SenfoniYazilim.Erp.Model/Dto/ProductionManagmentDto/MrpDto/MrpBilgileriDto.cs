using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.ProductionManagmentEntites.MrpEntites;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.ProductionMangmentDto.MrpDto
{
    [NotMapped]
    public class MrpBilgileriL:MrpBilgileri, IBaseHareketEntity
    {
        public string  StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string TalepKodu { get; set; }
        public string Birim { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class ReceteMakinaElemaniBilgileriL : ReceteMakinaElemaniBilgileri, IBaseHareketEntity
    {
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

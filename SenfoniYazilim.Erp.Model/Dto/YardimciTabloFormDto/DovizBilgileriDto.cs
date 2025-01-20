using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto
{
    [NotMapped]
    public class DovizBilgileriL: DovizBilgileri
    {
        public string KayitKisiAdSoyad { get; set; }
        public string GuncelleyenKisiAdSoyad { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

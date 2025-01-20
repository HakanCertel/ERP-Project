using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class MakinaKapasiteKullanımBilgileriL: MakinaKapasiteKullanımBilgileri, IBaseHareketEntity
    {
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public long? CariId { get; set; }
        public string CariAdi { get; set; }
        public long? PlasiyerId { get; set; }
        public string PlasiyerAdi { get; set; }
        public long KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }

    }
}

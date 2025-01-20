using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class ReceteS:Recete
    {
        public string StokAdi { get; set; }
        public long? MalzemeBirimId { get; set; }
        public string MalzemeBirimAdi { get; set; }
        public long MalzemeDepoId { get; set; }
        public string MalzemeDepoKodu { get; set; }
        public string MalzemeDepoAdi { get; set; }
        public UrunCinsi UrunCinsi { get; set; } = UrunCinsi.Mamul;
        public string ReceteBirimKodu { get; set; }
        public string ReceteBirimAdi { get; set; }
        public string ReceteDepoKodu { get; set; }
        public string ReceteDepoAdi { get; set; }
    }
    public class ReceteL : BaseEntityDurum
    {
        public string ReceteAdi { get; set; }
        public long StokId { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public long MalzemeDepoId { get; set; }
        public string MalzemeDepoAdi { get; set; }
        public string MalzemeBirimAdi { get; set; }
        public long ReceteDepoId { get; set; }
        public string ReceteDepoAdi { get; set; }
        public long? ReceteBirimId { get; set; }
        public string ReceteBirimAdi { get; set; }
        public decimal ReceteMiktar { get; set; }
        public UrunCinsi UrunCinsi { get; set; }
        public decimal Miktar { get; set; }
        public bool Varsayılan { get; set; }
    }
}

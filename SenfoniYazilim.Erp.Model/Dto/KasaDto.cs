using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class KasaS:Kasa
    {
        public string OzelKod1Adi { get; set; }

        public string OzelKod2Adi { get; set; }
    }

    public class KasaL:BaseEntity
    {
        public string KasaAdi { get; set; }

        public string OzelKod1Adi { get; set; }

        public string OzelKod2Adi { get; set; }

        public string Aciklama { get; set; }
    }
}

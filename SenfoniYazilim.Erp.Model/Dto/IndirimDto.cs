using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class IndirimS:Indirim
    {
        public string IndirimTuruAdi { get; set; }
    }

    public class IndirimL:BaseEntity
    {
        public string IndirimAdi { get; set; }

        public string Aciklama { get; set; }

        public string IndirimTuruAdi { get; set; }

        public long IndirimTuruId { get; set; }
    }
}

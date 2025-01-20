using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class SinifS:Sinif
    {        
        public string GrupAdi { get; set; }
    }

    public class SinifL : BaseEntity
    {
        public string SinifAdi { get; set; }

        public string GrupAdi { get; set; }

        public int HedefOgrenciSayisi { get; set; }

        public decimal HedefCiro { get; set; }

        public string Aciklama { get; set; }
    }
}

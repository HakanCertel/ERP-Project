using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class MakinaS:Makina
    {
        public string OperasyonAdi { get; set; }
    }

    public class MakinaL : BaseEntity
    {
        public string MakinaAdi { get; set; }

        public string MakinaTanimi { get; set; }

        public string OperasyonAdi { get; set; }

        public string Aciklama { get; set; }

        public bool IsCapacityBasedWorker { get; set; }

        public string KapasiteBagi { get; set; }

    }
}

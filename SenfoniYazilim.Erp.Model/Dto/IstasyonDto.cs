using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class IstasyonS:Istasyon
    {
        public string VardiyaSistemAdi { get; set; }
    }
    public class IstasyonL : BaseEntity
    {
        public string IstasyonAdi { get; set; }
        public long VardiyaId { get; set; }
        public string VardiyaSistemAdi { get; set; }
        public int? VardiyaSayisi { get; set; }
        public decimal? Kapasite { get; set; }

    }
}

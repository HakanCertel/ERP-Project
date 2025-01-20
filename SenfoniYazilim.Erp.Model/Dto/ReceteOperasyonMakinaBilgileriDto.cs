using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class ReceteOperasyonMakinaBilgileriL : ReceteOperasyonMakinaBilgileri, IBaseHareketEntity
    {
        public long ReceteninBagliOlduguStokId { get; set; }
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }
        public string IstasyonKodu { get; set; }//-----
        public string IstasyonAdi { get; set; }//------

        public bool Insert { get; set;}
        public bool Update { get; set;}
        public bool Delete { get; set;}
    }
    
}

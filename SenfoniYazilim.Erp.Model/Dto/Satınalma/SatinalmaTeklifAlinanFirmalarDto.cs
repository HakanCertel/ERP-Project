using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;

namespace SenfoniYazilim.Erp.Model.Dto.Satınalma
{
    public  class SatinalmaTeklifAlinanFirmalar:BaseEntity,IBaseHareketEntity
    {
        public string FirmaAdi { get; set; }

        public bool Insert { get ; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

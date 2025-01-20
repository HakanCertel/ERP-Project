using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;

namespace SenfoniYazilim.Erp.Model.Dto
{
    public class TarihL : Tarih, IBaseHareketEntity
    {

        public bool Insert { get ; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

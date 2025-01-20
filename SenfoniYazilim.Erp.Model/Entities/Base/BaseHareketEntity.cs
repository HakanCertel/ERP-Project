using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;

namespace SenfoniYazilim.Erp.Model.Entities.Base
{
    public class BaseHareketEntity:IBaseEntity
    {        
        public int Id { get; set; }
        public bool IsClosed { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsCancel { get; set; }
        public bool IsComfirmed { get; set; }
    }
}

using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class VardiyaBilgileriLastVersion:BaseHareketEntity
    {
        public long VardiyaId { get; set; }
        public int KacinciVardiya { get; set; }
        public DaysOfWeek Gun { get; set; }
        public TimeSpan MesaiBaslamaSaati { get; set; }
        public TimeSpan MesaiBitisSaati { get; set; }
        public int MolaSuresi { get; set; }
        public UnitOfDate BirimSure { get; set; }
        public decimal Kapasite { get; set; }
        
        public Vardiya Vardiya{ get; set; }
    }
}

using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class ReceteOperasyonBilgileri:BaseHareketEntity
    {
        public long ReceteId { get; set; }
        public long OperasyonId { get; set; }
        public int OperasyonSirasi { get; set; }
        public string Aciklama { get; set; }

        public Recete Recete { get; set; }
        public Operasyon Operasyon { get; set; }
    }
}

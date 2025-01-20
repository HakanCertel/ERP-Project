using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class ReceteOperasyonMakinaBilgileri:BaseHareketEntity
    {
        public long ReceteId { get; set; }

        public long MakinaId { get; set; }

        public long IstasyonId { get; set; }//----

        public long OperasyonId { get; set; }//----

        public string OperasyonAdi { get; set; }

        public decimal? MakinaHazirlikSuresi { get; set; }

        public decimal OperasyonSuresi { get; set; }

        public bool VarsayilanMakina { get; set; }

        public int OperasyonSirasi { get; set; }

        public Recete Recete { get; set; }

        public Makina Makina { get; set; }

        public Istasyon Istasyon { get; set; }//---

        public Operasyon Operasyon { get; set; }//----

    }
}

using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Istasyon_Makina_Personel_Bilgileri:BaseHareketEntity
    {
        public long IstasyonId { get; set; }
        public long? OperasyonId { get; set; }
        public long? MakinaId { get; set; }
        public long PersonelId { get; set; }
        public string Aciklama { get; set; }

        public Istasyon Istasyon { get; set; }
        public Operasyon Operasyon { get; set; }
        public Makina Makina { get; set; }
        public Personel Personel { get; set; }
    }
}

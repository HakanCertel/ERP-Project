using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Makina_MakinaElemenlari_Bilgileri:BaseHareketEntity
    {
        public long IstasyonId { get; set; }
        public long StokId { get; set; }
        public long MakinaId { get; set; }
        public string Aciklama { get; set; }

        public Istasyon Istasyon { get; set; }
        public Material Stok { get; set; }
        public Makina Makina { get; set; }
    }
}

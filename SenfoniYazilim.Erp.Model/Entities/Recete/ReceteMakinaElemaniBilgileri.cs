using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class ReceteMakinaElemaniBilgileri : BaseHareketEntity
    {
        public long ReceteId { get; set; }
        public long StokId { get; set; }
        public long MakinaId { get; set; }
        public decimal? DegisimSuresi { get; set; }
        public bool VarsayilanEleman { get; set; }
        public string Aciklama { get; set; }

        public Recete Recete { get; set; }
        public Material Stok { get; set; }
        public Makina Makina { get; set; }
    }
}

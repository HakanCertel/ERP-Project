using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Dto
{
    public class ReceteIstasyonMakinaElemanlariL:BaseEntity
    {
        public long MakinaId { get; set; }
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }
        public long StokId { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string Aciklama { get; set; }
    }
}

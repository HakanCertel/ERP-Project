using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class BaglantiAyarlari:BaseEntity
    {
        public string Server { get; set; }
        public YetkilendirmeTuru YetkilendirmeTuru { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}

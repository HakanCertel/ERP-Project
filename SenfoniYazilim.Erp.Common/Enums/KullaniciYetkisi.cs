using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum KullaniciYetkisi:byte
    {
        [Description("Yönetici")]
        Yonetici=1,
        [Description("Kullanıcı")]
        Kullanici=2
    }
}

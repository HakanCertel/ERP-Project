using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum KayitDurumu:byte
    {
        [Description("On Kayıt")]
        OnKayit = 1,
        [Description("Kesin Kayıt")]
        KesinKayit = 2,
        [Description("Kayıtsız")]
        Kayitsiz = 3
    }
}

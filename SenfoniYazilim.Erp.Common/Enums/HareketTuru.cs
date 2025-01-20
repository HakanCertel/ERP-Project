using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum HareketTuru:byte
    {
        [Description("Hepsi")]
        Hepsi = 0,
        [Description("Giriş")]
        Giris=1,
        [Description("Çıkış")]
        Cikis =2
    }
}

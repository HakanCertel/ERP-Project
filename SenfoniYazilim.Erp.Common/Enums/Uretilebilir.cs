using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum Uretilebilir:byte
    {        
        [Description("Üretim")]
        Uretim=2,
        [Description("Tüketim")]
        Tuketim=3,
        [Description("Ana Kod")]
        AnaKod = 1,
    }
}

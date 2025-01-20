using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum EPosKartTuru:byte
    {
        [Description("Visa")]
        Visa=1,
        [Description("Master")]
        Master =2,
        [Description("American Express")]
        AmericanExpress =3
    }
}

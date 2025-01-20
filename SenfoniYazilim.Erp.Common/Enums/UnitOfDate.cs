using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum UnitOfDate:byte
    {
        [Description("Saniye")]
        Second=1,
        [Description("Dakika")]
        Minute=2,
        [Description("Saat")]
        Hour =3,
        [Description("Gun")]
        Day =4,
    }
}

using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum Location:byte
    {
        [Description("Yurt İçi")]
        Local=1,
        [Description("Yurt Dışı")]
        Foreing=2
    }
}

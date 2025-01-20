using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum YetkilendirmeTuru:byte
    {
        [Description("Sql Server Yetkilendirme")]
        SqlServer=1,
        [Description("Windows Yetkilendirme")]
        Windows=2
    }
}

using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum IskontoTuru:byte
    {
        [Description("Yüzdesel")]
        Yuzdesel=1,
        [Description("Rakamsal")]
        Rakamsal = 2
    }
}

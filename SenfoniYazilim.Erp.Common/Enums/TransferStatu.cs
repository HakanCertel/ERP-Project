using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum TransferStatu:byte
    {
        [Description("Açık")]
        Acik =1,
        [Description("Üretim")]
        Uretim =2,
    }
}

using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum LegalEntity:byte
    {
        [Description("Tüzel Kişi")]
        LegalEntity =1,
        [Description("Gerçek Kişi")]
        RealPerson=2
    }
}

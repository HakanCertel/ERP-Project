using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum CompanyState:byte
    {
        [Description("Potansiyel")]
        Potential=1,
        [Description("Aktif")]
        Active=2,
    }
}

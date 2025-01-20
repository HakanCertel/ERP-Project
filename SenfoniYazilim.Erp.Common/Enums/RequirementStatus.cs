using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum RequirementStatus:byte
    {
        [Description("Üretim Planla")]
        ProductionPrograming=1,
        [Description("Hammadde Planla")]
        MaterialPrograming = 2,
        [Description("Malzeme Planla")]
        MainProductPrograming = 3,
    }
}

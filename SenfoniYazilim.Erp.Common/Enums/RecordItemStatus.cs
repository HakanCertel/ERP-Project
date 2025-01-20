using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum RecordItemStatus:byte
    {
        [Description("İşlem Yapılmadı")]
        NoProccess=1,
        [Description("İptal Edildi")]
        Canceled=2,
        [Description("Onaylandı")]
        Comfirmed=3
    }
}

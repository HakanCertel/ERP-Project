using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum WayBillCreatingMethod:byte
    {
        [Description("Doğrudan Malzeme Seçim Yöntemi")]
        ChooseMaterial = 1,
        [Description("Sipariş Seçim Yöntemi")]
        ChooseOrderItem = 2,
    }
}

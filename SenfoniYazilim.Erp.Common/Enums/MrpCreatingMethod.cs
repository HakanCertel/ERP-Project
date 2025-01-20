using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum MrpCreatingMethod:byte
    {
        [Description("Doğrudan Malzeme Seçim Yöntemi")]
        ChooseMaterial = 1,
        [Description("Açık Sipariş Seçim Yöntemi")]
        ChooseOrderItem = 2,
        [Description("Satış Tahmini Seçim Yöntemi")]
        ChooseSaleGuess = 3,
        [Description("Minimum Stok Miktarı Seçim Yöntemi")]
        ChooseMinStockQty = 4
    }
}

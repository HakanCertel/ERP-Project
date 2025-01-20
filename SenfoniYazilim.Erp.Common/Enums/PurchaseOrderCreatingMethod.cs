using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum PurchaseOrderCreatingMethod:byte
    {
        [Description("Doğrudan Malzeme Seçim Yöntemi")]
        ChooseMaterial = 1,
        [Description("Açık Satınalma Talep Kalemi Seçim Yöntemi")]
        ChoosePurchaseDemandItem = 2,
        [Description("Teklif Kalemlerin Seçim Yöntemi")]
        ChoosePurchaseOfferItem = 3,
        [Description("Minimum Stok Miktarı Seçim Yöntemi")]
        ChooseMinStockQty = 4
    }
}

using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum PurchaseOfferCreatingMethod:byte
    {
        [Description("Doğrudan Malzeme Seçim Yöntemi")]
        ChooseMaterial =1,
        [Description("Açık Satınalma Talep Kalemi Seçim Yöntemi")]
        ChoosePurchaseDemandItem =2,
        [Description("Minimum Stok Miktarı Seçim Yöntemi")]
        ChooseMinStockQty =3
    }
}

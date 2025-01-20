using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum SaleCreatingMethod:byte
    {
        [Description("Doğrudan Malzeme Seçim Yöntemi")]
        ChooseMaterial = 1,
        [Description("Açık Teklif Kalemi Seçim Yöntemi")]
        ChooseOfferItem = 2,
    }
}

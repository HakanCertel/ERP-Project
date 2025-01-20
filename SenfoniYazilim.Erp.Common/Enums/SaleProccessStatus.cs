using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum SaleProccessStatus:byte
    {
        [Description("Üretim Talep Oluşturuldu")]
        CreatedProductionDemand=1,
        [Description("Planlandı")]
        Planed=2,
        [Description("Üretildi")]
        Produced=3,
        [Description("İşlem Yapılmadı")]
        NoProccess=4,
        [Description("Satınalam Talep Oluşturuldu")]
        CreatedPurchaseDemand=5,
        [Description("Satınalma Sipariş Oluşturuldu")]
        CreatedPurchaseOrder=6,
        [Description("İrsaliye Oluşturuldu")]
        CreatedDispatchWayBill=7,
        [Description("Kısmi İrsaliye Oluşturuldu")]
        CreatedSemiWayBill=8
    }
}

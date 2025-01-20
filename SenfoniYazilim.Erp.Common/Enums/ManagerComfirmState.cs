using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum MangerComfirmState:byte
    {
        [Description("Onaylandı")]
        Comfirmed = 1,
        [Description("Reddedildi")]
        Canceled = 2,
        [Description("Onaya Gönderildi")]
        Sended = 3,
        [Description("İşlem Yapılmadı")]
        NoProccess = 4,
    }
}

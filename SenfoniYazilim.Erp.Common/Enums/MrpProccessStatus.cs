using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum MrpProccessStatus:byte
    {
        [Description("Kapasite Planına Alındı")]
        SendToCrp=1,
        [Description("Üretim Planına Alındı")]
        GotToProductionPlanning=2,
        [Description("İş Emri Oluşturuldu")]
        CreatedWorkOrder=3,
        [Description("Satınalma Talep oluşturuldu")]
        CreatedPurchaseDemand=4,
        [Description("İşlem Yapılmadı")]
        NoProccess=5
    }
}

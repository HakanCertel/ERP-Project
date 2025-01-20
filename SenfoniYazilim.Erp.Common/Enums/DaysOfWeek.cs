using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Common.Enums
{
    
    public enum DaysOfWeek:byte
    {
        [Description("Pazar")]
        Sunday=0,
        [Description("Pazartesi")]
        Monday=1,
        [Description("Salı")]
        Tuesday =2,
        [Description("Çarşamba")]
        Wednesday =3,
        [Description("Perşembe")]
        Thursday =4,
        [Description("Cuma")]
        Friday =5,
        [Description("Cumartesi")]
        Saturday = 6
    }
}

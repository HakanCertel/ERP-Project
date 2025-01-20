using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum MakbuzHesapTuru:byte
    {
        [Description("Avukat")]
        Avukat =1,
        [Description("Banka")]
        Banka =2,
        [Description("Cari")]
        Cari =3,
        [Description("Epos")]
        EPos =4,
        [Description("İade")]
        Iade =5,
        [Description("Kasa")]
        Kasa =6,
        [Description("Mahsup")]
        Mahsup =7,
        [Description("Ots")]
        Ots =8,
        [Description("Pos")]
        Pos =9,
        [Description("Şüpheli")]
        Supheli =10,
        [Description("Transfer")]
        Transfer =11
    }
}

using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum BankaHesapTuru:byte
    {
        [Description("Vadesiz Mevduat Hesabı")]
        VadesizMevduatHesabi=1,
        [Description("Vadeli Mevduat Hesabı")]
        VadeliMevduatHesabi =2,
        [Description("Vadesiz Mevduat Hesabı")]
        KrediHesabi =3,
        [Description("EPos Bloke Hesabı")]
        EPosBlokeHesabi =4,
        [Description("Ots Bloke Hesabı")]
        OtsBlokeHesabi =5,
        [Description("Pos Bloke Hesabı")]
        PosBlokeHesabi =6,
        [Description("Bloke Çözüm esabı")]
        BlokeCozumHesabi =7,
    }
}

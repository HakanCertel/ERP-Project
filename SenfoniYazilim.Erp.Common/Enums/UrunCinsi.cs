using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum UrunCinsi:byte
    {
        [Description("Mamül")]
        Mamul=1,
        [Description("Yarı Mamül")]
        YariMamul =2,
        [Description("Hammadde")]
        Hammadde =3,
        [Description("Ticari Mal")]
        TicariMal =4,
        [Description("Sarf Malzeme")]
        SarfMalzeme =5,
        [Description("Yardımcı Malzeme")]
        YardimciMalzeme = 6,
        [Description("Pasif Malzeme")]
        PasifMalzeme = 7,
        [Description("Kullanım Dışı Malzeme")]
        KullanimDisiMalzeme = 8,
    }
}

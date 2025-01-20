using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum YazdirmaYonu:byte
    {
        [Description("Dikey")]
        Dikey=1,
        [Description("Yatay")]
        Yatay =2,
        [Description("Otomatik")]
        Ototmatik =3
    }
}

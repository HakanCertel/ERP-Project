using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum SonrakiDonemKayitDurumu:byte
    {
        [Description("Kayıt Yenilenecek")]
        KayitYenilenecek=1,
        [Description("Şartlı Kayıt Yenilenecek")]
        SartliKayitYenilenecek =2,
        [Description("Kayıt Yenilemeyecek")]
        KayitYenilemeyecek =3,
        [Description("Kurum Tarafından Kayıt Yenilenmeyecek")]
        KurumTarafindanKaydiYenilenmeyecek =4
    }
}

using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public  enum IsEmriDurumu:byte
    {
        [Description("İşlem Yapılmadı")]
        IslemYapilmadi=1,
        [Description("İş Emri Oluşturuldu")]
        IsEmriOlusturuldu=2
    }
}

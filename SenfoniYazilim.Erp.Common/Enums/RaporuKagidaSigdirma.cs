using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum RaporuKagidaSigdirma:byte
    {
        [Description("Sütunları Daraltarak Sığdır")]
        SutunlariDaraltarakSigdir=1,
        [Description("Yazı Boyutunu küçülterek Sığdır")]
        YaziBoyutunuKuculterekSigdir =2,
        [Description("İşlem Yapma")]
        IslemYapma =3
    }
}

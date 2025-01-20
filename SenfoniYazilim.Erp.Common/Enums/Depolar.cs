using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum Depolar:byte
    {
        [Description("Merkez Depo")]
        MerkezDepo=1,
        [Description("Fabrika Depo")]
        FabrikaDepo =2,
        [Description("Şube Depo")]
        SubeDepo =3,
        [Description("Üretim Depo")]
        UretimDepo = 3
    }
}

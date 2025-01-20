using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum TransferCreatingMethod:byte
    {
        [Description("Doğrudan Malzeme Seçim Yöntemi")]
        ChooseMaterial = 1,
        [Description("İhtiyaçtan Seçim Yöntemi")]
        ChooseRequestItem = 2,
    }
}

using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum DescriptionOfTransferProccess:byte
    {
        [Description("Talep")]
        TransferDemand=1,
        [Description("Onaylandı")]
        TransferComfrim=2,
        [Description("Transfer Gerçekleşti")]
        Transfer=3
    }
}

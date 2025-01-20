using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    public enum CustomerOrSuplier:byte
    {
        [Description("Müşteri")]
        Customer=1,
        [Description("Tedarikci")]
        Suplier=2,
        [Description("Müşteri ve Tedarikci")]
        CustomerAndSuplier=3,
        [Description("Alt Müşteri")]
        SubCustomer=4,
        [Description("Alt Tedarikci")]
        SubSublier=5,
        [Description("Alt Müşteri ve Tedarikci")]
        SubCustomerAndSuplier=6
    }
}

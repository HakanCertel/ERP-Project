using DevExpress.XtraPrinting;

namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    public partial class RaporOnizlem : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RaporOnizlem(params object[] prm)
        {
            InitializeComponent();

            RaporGosterici.PrintingSystem = (PrintingSystemBase)prm[0];
            //Text = $"{Text} ( {prm[1].ToString()} )";
        }

       
    }
}
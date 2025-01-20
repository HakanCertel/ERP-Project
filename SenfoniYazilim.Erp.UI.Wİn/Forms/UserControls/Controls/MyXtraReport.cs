using DevExpress.XtraReports.UI;
using System.ComponentModel;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public partial class MyXtraReport : XtraReport
    {
        public MyXtraReport()
        {
            //InitializeComponent();
        }

        public string Baslik { get; set; }
    }
}

using SenfoniYazilim.Erp.UI.Wİn.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    public class MyHyperlinkLabelControl : HyperlinkLabelControl, IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MyHyperlinkLabelControl()
        {
            Cursor = Cursors.Hand;
            LinkBehavior = LinkBehavior.NeverUnderline;
        }
        public string StatusBarAciklama { get; set; }
    }
}

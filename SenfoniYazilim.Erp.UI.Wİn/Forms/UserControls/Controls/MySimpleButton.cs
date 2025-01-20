using SenfoniYazilim.Erp.UI.Wİn.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    public class MySimpleButton : SimpleButton, IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MySimpleButton()
        {
            Appearance.ForeColor = Color.Maroon;
        }

        public string StatusBarAciklama { get ; set; } 
    }
}

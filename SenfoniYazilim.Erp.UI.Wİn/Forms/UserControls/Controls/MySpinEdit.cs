using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using SenfoniYazilim.Erp.UI.Wİn.Interfaces;
using System.ComponentModel;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    public class MySpinEdit:SpinEdit,IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "d";
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get ; set ; }
    }
}

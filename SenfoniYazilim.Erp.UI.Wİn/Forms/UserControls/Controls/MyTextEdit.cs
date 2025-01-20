
using SenfoniYazilim.Erp.UI.Wİn.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    public class MyTextEdit : TextEdit, IStatusBarAciklama
    {
        [ToolboxItem(true) ]
        public MyTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 50;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get ; set ; }
        public long Id { get; set; }
    }
}

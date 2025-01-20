using SenfoniYazilim.Erp.UI.Wİn.Interfaces;
using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    public class MyChekedComboBoxEdit : CheckedComboBoxEdit, IStatusBarKisaYol
    {
        [ToolboxItem(true)]
        public MyChekedComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
    
    }
}

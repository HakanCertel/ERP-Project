using SenfoniYazilim.Erp.UI.Wİn.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;
using System.Drawing;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    public class MyLookUpEdit:LookUpEdit,IStatusBarKisaYol
    {
        [ToolboxItem(true)]
        public MyLookUpEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.HeaderClickMode = HeaderClickMode.AutoSearch;
            Properties.ShowFooter = false;
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; } = "Seçim Yap";
    }
}

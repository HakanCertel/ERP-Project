using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    public class MyKodTextEdit:MyTextEdit
    {
        [ToolboxItem(true)]
        public MyKodTextEdit()
        {
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.MaxLength = 20;
            StatusBarAciklama = "Kod Giriniz.";
        }
    }
}

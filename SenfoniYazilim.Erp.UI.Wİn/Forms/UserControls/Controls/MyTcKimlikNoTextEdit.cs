using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    public class MyTcKimlikNoTextEdit:MyTextEdit
    {
        [ToolboxItem(true)]
        public MyTcKimlikNoTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d?\d? \d?\d?\d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "TC Kimlik No Giriniz.";
        }
    }
}

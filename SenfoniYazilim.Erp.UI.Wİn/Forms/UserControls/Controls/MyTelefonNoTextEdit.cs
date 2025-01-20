using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    public class MyTelefonNoTextEdit:MyTextEdit
    {
        [ToolboxItem(true)]
        public MyTelefonNoTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            Properties.Mask.EditMask = @"0(\d?\d?\d?) \d?\d?\d? \d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "Telefon Numarası Giriniz.";
        }
    }
}

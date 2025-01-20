using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    public class MyEmailTextEdit:MyTextEdit
    {
        [ToolboxItem(true)]
        public MyEmailTextEdit()
        {
            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            Properties.Mask.EditMask = @"((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_-])+)+";
            Properties.Mask.AutoComplete = AutoCompleteType.Strong;
            StatusBarAciklama = "Email Adresi Giriniz.";
        }
    }
}

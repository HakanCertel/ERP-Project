using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using SenfoniYazilim.Erp.UI.Wİn.Interfaces;
using System.ComponentModel;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    public class MyCalcEdit:CalcEdit,IStatusBarKisaYol
    {
        [ToolboxItem(true)]
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "n2";//burada n2 deki 2, virgülden sonra iki değerin gösterileceğini belirtir...
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get ; set ; }
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; } = "Hesap Makinası";
    }
}

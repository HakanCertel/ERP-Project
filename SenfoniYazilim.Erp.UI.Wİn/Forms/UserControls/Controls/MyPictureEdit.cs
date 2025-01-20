using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Interfaces;
using System.ComponentModel;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    public class MyPictureEdit:PictureEdit,IStatusBarKisaYol
    {
        [ToolboxItem(true)]
        public MyPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.ForeColor = Color.Maroon;
            Properties.NullText = "Resim Yok";
            Properties.SizeMode = PictureSizeMode.Stretch;
            Properties.ShowMenu = false;//bu satır bu kontrolün üstüne sağtuş yapıldığında bir menü gelir, bunun gelmemesi için false yapıldı
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
    }
}

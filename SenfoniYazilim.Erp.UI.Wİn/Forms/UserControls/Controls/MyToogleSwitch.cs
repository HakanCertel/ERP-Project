using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Drawing;
using SenfoniYazilim.Erp.UI.Wİn.Interfaces;
using System.ComponentModel;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    public class MyToogleSwitch:ToggleSwitch,IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MyToogleSwitch()
        {
            Name = "tglDurum";
            Properties.OffText = "Pasif";
            Properties.OnText = "Aktif";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; } = "Kartın Kullanım Durumunu Seçiniz.";
    }
}

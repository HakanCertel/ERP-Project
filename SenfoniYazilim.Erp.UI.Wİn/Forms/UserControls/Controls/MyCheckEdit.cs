using SenfoniYazilim.Erp.UI.Wİn.Interfaces;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    public class MyCheckEdit:CheckEdit,IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MyCheckEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.Transparent;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get ; set; }
    }
}

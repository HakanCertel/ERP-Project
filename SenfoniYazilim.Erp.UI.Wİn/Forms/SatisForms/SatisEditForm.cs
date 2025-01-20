using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Common.Enums;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SatisForms
{
    public partial class SatisEditForm : BaseEditForm
    {
        public SatisEditForm()
        {
            InitializeComponent();

            BaseKartTuru = KartTuru.Satis;
            EventsLoad();
        }

        public override void Yukle()
        {
            TabloYukle();
        }
        
    }
}
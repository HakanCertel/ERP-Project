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
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.KdvOranlariForms;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.EvrakTurleriForms
{
    public partial class KdvListForm : BaseListForm
    {
        public KdvListForm()
        {
            InitializeComponent();

            Bll = new KdvBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Kdv;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<KdvEditForm>();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KdvBll)Bll).List(FilterFunctions.Filter<Kdv>(AktifKartlariGoster));
        }
    }
}
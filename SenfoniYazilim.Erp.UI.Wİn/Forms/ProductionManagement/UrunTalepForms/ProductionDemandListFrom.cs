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
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities;
using DevExpress.XtraBars;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UrunTalepForms
{
    public partial class ProductionDemandListFrom : BaseListForm
    {
        public ProductionDemandListFrom()
        {
            InitializeComponent();

            InitializeComponent();
            Bll = new ProductionDemandBll();
            HideItems = new BarItem[] { btnAktifPasifKartlar };
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.ProductionDemand;
            FormShow = new ShowEditForms<ProductionDemandEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((ProductionDemandBll)Bll).List(null/*FilterFunctions.Filter<ProductionDemand>(AktifKartlariGoster)*/);
        }
    }
}
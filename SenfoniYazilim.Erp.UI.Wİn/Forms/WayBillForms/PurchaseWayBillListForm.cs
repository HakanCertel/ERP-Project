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
using SenfoniYazilim.Erp.Bll.General.WayBillBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.WayBillEntities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.WayBillForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SaleWayBillForms
{
    public partial class PurchaseWayBillListForm : BaseListForm
    {
        public PurchaseWayBillListForm()
        {
            InitializeComponent();

            Bll = new PurchaseWayBillBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.PurchaseWayBill;
            FormShow = new ShowEditForms<PurchaseWayBillEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PurchaseWayBillBll)Bll).List(FilterFunctions.Filter<PurchaseWayBill>(AktifKartlariGoster));
        }
    }
}
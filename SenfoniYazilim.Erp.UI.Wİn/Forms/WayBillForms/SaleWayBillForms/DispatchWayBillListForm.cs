using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General.WayBillBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.WayBillEntities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.WayBillForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SaleWayBillForms
{
    public partial class DispatchWayBillListForm : BaseListForm
    {
        public DispatchWayBillListForm()
        {
            InitializeComponent();

            Bll = new DispatchWayBillBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.DispatchWayBill;
            FormShow = new ShowEditForms<DispatchWayBillEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((DispatchWayBillBll)Bll).List(FilterFunctions.Filter<DispatchWayBill>(AktifKartlariGoster));
        }
    }
}
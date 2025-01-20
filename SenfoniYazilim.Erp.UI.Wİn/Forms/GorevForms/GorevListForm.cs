using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.GorevForms
{
    public partial class GorevListForm : BaseListForm
    {
        public GorevListForm()
        {
            InitializeComponent();

            Bll = new GorevBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            BaseKartTuru =KartTuru.Gorev;
            FormShow = new ShowEditForms<GorevEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((GorevBll)Bll).List(FilterFunctions.Filter<Gorev>(AktifKartlariGoster));
        }
    }
}
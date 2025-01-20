using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.AvukatForms
{
    public partial class AvukatListForm : BaseListForm
    {
        public AvukatListForm()
        {
            InitializeComponent();

            Bll = new AvukatBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Avukat;
            FormShow = new ShowEditForms<AvukatEditForm>();
            Navigator = longNavigator.Navigator;

        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((AvukatBll)Bll).List(FilterFunctions.Filter<Avukat>(AktifKartlariGoster));
        }

    }
}
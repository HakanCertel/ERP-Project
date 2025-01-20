using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.MeslekForms
{
    public partial class MeslekListForm : BaseListForm
    {
        public MeslekListForm()
        {
            InitializeComponent();

            Bll = new MeslekBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            BaseKartTuru = KartTuru.Meslek;
            FormShow = new ShowEditForms<MeslekEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MeslekBll)Bll).List(FilterFunctions.Filter<Meslek>(AktifKartlariGoster));
        }
    }
}
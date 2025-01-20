using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.HizmetTuruForms
{
    public partial class HizmetTuruListForm : BaseListForm
    {
        public HizmetTuruListForm()
        {
            InitializeComponent();

            Bll = new HizmetTuruBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.HizmetTuru;
            FormShow = new ShowEditForms<HizmetTuruEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((HizmetTuruBll)Bll).List(FilterFunctions.Filter<HizmetTuru>(AktifKartlariGoster));
        }

    }
}
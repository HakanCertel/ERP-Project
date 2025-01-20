using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.IsyeriForms
{
    public partial class IsyeriListForm :BaseListForm
    {
        public IsyeriListForm()
        {
            InitializeComponent();

            Bll = new IsyeriBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            BaseKartTuru = KartTuru.Isyeri;
            FormShow = new ShowEditForms<IsyeriEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IsyeriBll)Bll).List(FilterFunctions.Filter<Isyeri>(AktifKartlariGoster));
        }
    }
}
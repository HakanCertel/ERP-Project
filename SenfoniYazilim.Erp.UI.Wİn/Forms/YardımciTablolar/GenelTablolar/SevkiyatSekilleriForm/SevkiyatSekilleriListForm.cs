using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.SevkiyatSekilleriForm
{
    public partial class SevkiyatSekilleriListForm : BaseListForm
    {
        public SevkiyatSekilleriListForm()
        {
            InitializeComponent();

            Bll = new SevkiyatSekliBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            BaseKartTuru = KartTuru.SevkiyatSekli;
            FormShow = new ShowEditForms<SevkiyatSekilleriEditForm>();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SevkiyatSekliBll)Bll).List(FilterFunctions.Filter<SevkiyatSekilleri>(AktifKartlariGoster));
        }
    }
}
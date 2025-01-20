using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.DovizForms
{
    public partial class DovizListForm : BaseListForm
    {
        public DovizListForm()
        {
            InitializeComponent();

            Bll = new DovizBilgileriBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Doviz;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<DovizEditForm>();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((DovizBilgileriBll)Bll).List(FilterFunctions.Filter<DovizBilgileri>(AktifKartlariGoster));
        }
    }
}
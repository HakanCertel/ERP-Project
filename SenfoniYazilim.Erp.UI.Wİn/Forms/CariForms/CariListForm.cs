using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms
{
    public partial class CariListForm : BaseListForm
    {
        public CariListForm()
        {
            InitializeComponent();

            Bll = new CariBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Cari;
            FormShow = new ShowEditForms<CariEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((CariBll)Bll).List(x=>x.Durum==AktifKartlariGoster);
        }
    }
}
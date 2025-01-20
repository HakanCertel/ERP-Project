using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ServisForms
{
    public partial class ServisListForm : BaseListForm
    {
        public ServisListForm()
        {
            InitializeComponent();

            Bll = new ServisBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Servis;
            FormShow = new ShowEditForms<ServisEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((ServisBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}
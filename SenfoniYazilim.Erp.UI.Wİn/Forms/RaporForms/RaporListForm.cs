using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.RaporForms
{
    public partial class RaporListForm : BaseListForm
    {
        private readonly KartTuru _raporTuru;
        private readonly RaporBolumTuru _raporBolumTuru;
        private readonly byte[] _dosya;

        public RaporListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new RaporBll();

            _raporTuru = (KartTuru)prm[0];
            _raporBolumTuru = (RaporBolumTuru)prm[1];
            _dosya = (byte[])prm[2];
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            BaseKartTuru = KartTuru.Rapor;
            FormShow = new ShowEditForms<RaporEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((RaporBll)Bll).List(FilterFunctions.Filter<Rapor>(AktifKartlariGoster));
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<RaporEditForm>.ShowDialogForm(KartTuru.Rapor, id, _raporTuru, _raporBolumTuru,_dosya);
            ShowEditFormDefault(result);
        }
    }
}
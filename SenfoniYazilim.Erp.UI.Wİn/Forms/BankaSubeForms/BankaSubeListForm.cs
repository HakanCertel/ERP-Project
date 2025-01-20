using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BankaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Dto;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.BankaSubeForms
{
    public partial class BankaSubeListForm :BaseListForm
    {
        private readonly long _bankaId;
        private readonly string _bankaAdi;

        public BankaSubeListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new BankaSubeBll();
            _bankaId = (long)prm[0];
            _bankaAdi = prm[1].ToString();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.BankaSube;
            //FormShow = new ShowEditForms<EditForm>();
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_bankaAdi} )";// bu ifade bir edit form açılırken formun başlığına parantez içinde il adını yazmaya yarar
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaSubeBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.BankaId == _bankaId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<BankaSubeEditForm>.ShowDialogForm(KartTuru.BankaSube, id, _bankaId, _bankaAdi);
            ShowEditFormDefault(result);
        }
    }
}
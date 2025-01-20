using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IlceForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.IlForms
{
    public partial class IlListForm : BaseListForm
    {
        public long _countryId;
        public readonly string _countryName;

        public IlListForm()
        {
            InitializeComponent();

            Bll = new IlBll();

            btnBagliKarlar.Caption = "İlçe Kartları";
        }
        public IlListForm(params object[] prm):this()
        {
            _countryId = (long)prm[0];
            _countryName = prm[0].ToString();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Il;
            FormShow = new ShowEditForms<IlEditForm>();
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ({_countryName})";
            if(IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKarlar };
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlBll)Bll).List(x=>x.Durum==AktifKartlariGoster&&x.CountryId==_countryId);
        }

        protected override void BaglıKartAc()
        {
            //Yetki Kontrolü
            var entity = tablo.GetRow<Il>();
            if (entity == null) return;
            ShowListForms<IlceListForm>.ShowListForm(KartTuru.Ilce,entity.Id,entity.IlAdi);
        }
        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<IlEditForm>.ShowDialogForm(KartTuru.Il, id, _countryId, _countryName);
            ShowEditFormDefault(result);
        }
    }
}

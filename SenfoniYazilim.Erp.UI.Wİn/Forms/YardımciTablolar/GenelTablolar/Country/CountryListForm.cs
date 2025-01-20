using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IlceForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.IlForms
{
    public partial class CountryListForm : BaseListForm
    {
        public CountryListForm()
        {
            InitializeComponent();
            Bll = new CountryBll();
            btnBagliKarlar.Caption = "Şehir Kartları";
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Country;
            FormShow = new ShowEditForms<CountryEditForm>();
            Navigator = longNavigator.Navigator;
            if(IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKarlar };
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((CountryBll)Bll).List(FilterFunctions.Filter<Country>(AktifKartlariGoster));
        }

        protected override void BaglıKartAc()
        {
            //Yetki Kontrolü
            var entity = tablo.GetRow<Country>();
            if (entity == null) return;
            ShowListForms<IlListForm>.ShowListForm(KartTuru.Il,entity.Id,entity.CountryName);
        }
    }
}
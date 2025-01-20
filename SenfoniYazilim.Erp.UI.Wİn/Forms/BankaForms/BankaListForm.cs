using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BankaSubeForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.BankaForms
{
    public partial class BankaListForm : BaseListForm
    {
        public BankaListForm()
        {
            InitializeComponent();

            Bll = new BankaBll();

            btnBagliKarlar.Caption = "Şube Kartları";

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Banka;
            FormShow = new ShowEditForms<BankaEditForm>();
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKarlar };

        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaBll)Bll).List(FilterFunctions.Filter<Banka>(AktifKartlariGoster));
        }

        protected override void BaglıKartAc()
        {
            //Yetki Kontrolü
            var entity = Tablo.GetRow<BankaL>();
            if (entity == null) return;
            ShowListForms<BankaSubeListForm>.ShowListForm(KartTuru.Banka, entity.Id, entity.BankaAdi);
        }
    }
}
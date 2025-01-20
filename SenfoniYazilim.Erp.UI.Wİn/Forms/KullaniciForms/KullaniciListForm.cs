using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.KullaniciForms
{
    public partial class KullaniciListForm : BaseListForm
    {
        private Expression<Func<Kullanici, bool>> _filtre ;

        public KullaniciListForm()
        {
            InitializeComponent();

            Bll = new KullaniciBll();

            _filtre = x => x.Durum == AktifKartlariGoster;

        }
        public KullaniciListForm(params object[] prm):this()
        {
            ShowItems = new DevExpress.XtraBars.BarItem[] { btnSec };
            EklenebilecekEntityVar = true;
                _filtre = x => x.Durum && !ListeDisiTutulacakKayitlar.Contains(x.Id);
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Kullanici;
            FormShow = new ShowEditForms<KullaniciEditForm>();
            Navigator = longNavigator.Navigator;
           
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KullaniciBll)Bll).List(_filtre/*FilterFunctions.Filter<Kullanici>(AktifKartlariGoster)*/);
        }
    }
}
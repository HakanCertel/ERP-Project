using System;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.Model.Entities;
using System.Linq.Expressions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SubeForms
{
    public partial class SubeListForm : BaseListForm
    {
        private readonly Expression<Func<Sube,bool>> _filter;
        public SubeListForm()
        {
            InitializeComponent();

            Bll = new SubeBll();

            _filter = x => x.Durum == AktifKartlariGoster;
        }
        public SubeListForm(params object[] prm):this()
        {
            if ((bool)prm[0])
                _filter = x => x.Durum == AktifKartlariGoster && x.Id != AnaForm.SubeId;
            else if(!(bool)prm[0])
                _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Sube;
            FormShow = new ShowEditForms<SubeEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list = ((SubeBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }
    }
}
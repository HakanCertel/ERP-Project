using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General.PriceListBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System.Linq.Expressions;
using System;
using SenfoniYazilim.Erp.Model.Entities.PriceListEntities;
using SenfoniYazilim.Erp.Common.Message;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PriceListForms
{
    public partial class PriceListListForm : BaseListForm
    {

        private readonly Expression<Func<PriceList, bool>> _filter;

        public PriceListListForm()
        {
            InitializeComponent();

            Bll = new PriceListBll();

            _filter = x => x.Durum == AktifKartlariGoster;

        }

        public PriceListListForm(params object[] prm):this()
        {
            if (prm[0] != null)
                _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;//&&x.IsComfirmed;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.PriceList;
            FormShow = new ShowEditForms<PriceListEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list = ((PriceListBll)Bll).List(_filter);

            Tablo.GridControl.DataSource = list;
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }
    }
}
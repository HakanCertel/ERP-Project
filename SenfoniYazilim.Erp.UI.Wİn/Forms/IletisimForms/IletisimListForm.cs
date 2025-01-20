using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.IletisimForms
{
    public partial class IletisimListForm : BaseListForm
    {
        private readonly Expression<Func<Iletisim, bool>> _filter;

        public IletisimListForm()
        {
            InitializeComponent();

            Bll = new IletisimBll();

            _filter = x => x.Durum == AktifKartlariGoster;
        }

        public IletisimListForm(params object[] prm):this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Iletisim;
            FormShow = new ShowEditForms<IletisimEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            var list = ((IletisimBll)Bll).List(_filter);

            Tablo.GridControl.DataSource = list;
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");


            //Tablo.GridControl.DataSource = ((IletisimBll)Bll).List(FilterFunctions.Filter<Iletisim>(AktifKartlariGoster));
        }
    }
}
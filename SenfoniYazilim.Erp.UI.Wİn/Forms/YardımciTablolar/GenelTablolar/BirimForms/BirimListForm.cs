using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System.Linq.Expressions;
using System;
using System.Linq;
using SenfoniYazilim.Erp.Common.Message;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımcıTablolar.GenelTablolar.BirimForms
{
    public partial class BirimListForm : BaseListForm
    {
        private readonly Expression<Func<Birim, bool>> _filter;

        public BirimListForm()
        {
            InitializeComponent();

            Bll = new BirimBll();

            _filter = x => x.Durum == AktifKartlariGoster;
        }
        public BirimListForm(params object[] prm):this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            BaseKartTuru = KartTuru.Gorev;
            FormShow = new ShowEditForms<BirimEditForm>();
        }
        protected override void Listele()
        {
            var list=((BirimBll)Bll).List(_filter);

            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;

            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }
    }
}
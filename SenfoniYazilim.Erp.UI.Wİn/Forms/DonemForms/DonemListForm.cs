using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using System;
using System.Linq;
using System.Linq.Expressions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.DonemForms
{
    public partial class DonemListForm : BaseListForm
    {
        private readonly Expression<Func<Donem, bool>> _filter;

        public DonemListForm()
        {
            InitializeComponent();

            Bll = new DonemBll();

            _filter = x => x.Durum == AktifKartlariGoster;

            ShowItems = new DevExpress.XtraBars.BarItem[] { btnParametreler };
        }
        public DonemListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Donem;
            FormShow = new ShowEditForms<DonemEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list = ((DonemBll)Bll).List(_filter);

            Tablo.GridControl.DataSource = list;
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }
        protected override void BaglıKartAc()
        {
            //Yetki Kontrolü
            var entity = Tablo.GetRow<Donem>();
            if (entity == null) return;
            ShowEditForms<DonemParametreEditForm>.ShowDialogForm(null, entity.Id);
        }
    }
}
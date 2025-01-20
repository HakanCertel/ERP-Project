using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.OperasyonForms
{
    public partial class OperasyonListForm : BaseListForm
    {
        private readonly Expression<Func<Operasyon, bool>> _filter;

        public OperasyonListForm()
        {
            InitializeComponent();


            Bll = new OperasyonBll();
            ShowItems = new DevExpress.XtraBars.BarItem[] { btnIceriVeriAktar };
            _filter = x => x.Durum == AktifKartlariGoster;
        }

        public OperasyonListForm(params object[] prm):this()
        {
            if ((bool)prm[0])
                _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) &&  x.Durum == AktifKartlariGoster;
        }
        protected override void DegiskenleriDoldur()
        {
            BaseKartTuru = KartTuru.Operasyon;
            Tablo = tablo;
            FormShow = new ShowEditForms<OperasyonEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list = ((OperasyonBll)Bll).List(_filter);

            Tablo.GridControl.DataSource = list;
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }
        protected override void VeriAktar()
        {
            var list = new List<Operasyon>();
            Expression<Func<Operasyon, bool>> filter;
            filter = x => x.Id != 0;
            ShowVeriAktarListForms<VeriAktarimListForm, Operasyon, OperasyonBll>.ShowDialogListForm(KartTuru.Operasyon, filter, new OperasyonBll());
        }
    }
}
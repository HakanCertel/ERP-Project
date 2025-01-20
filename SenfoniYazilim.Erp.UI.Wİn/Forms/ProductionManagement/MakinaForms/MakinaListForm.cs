using System;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System.Linq.Expressions;
using SenfoniYazilim.Erp.Model.Entities;
using System.Linq;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using System.Collections.Generic;
using DevExpress.XtraBars;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.MakinaForms
{
    public partial class MakinaListForm : BaseListForm
    {
        private readonly Expression<Func<Makina, bool>> _filter;

        public MakinaListForm()
        {
            InitializeComponent();

            Bll = new MakinaBll();
            ShowItems = new BarItem[] { btnIceriVeriAktar };

            _filter = x => x.Durum == AktifKartlariGoster;
        }
        public MakinaListForm(params object[] prm):this()
        {
            var sdlvkn = (bool)prm[0];
            if((bool)prm[0])
                _filter= x => ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
            else
                _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            BaseKartTuru = KartTuru.Makina;
            Tablo = tablo;
            //if (_tabloCaption != null)
            //{
            //    Tablo.ViewCaption.ToLower();
            //    Tablo.ViewCaption = _tabloCaption;                
            //}
            FormShow = new ShowEditForms<MakinaEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            
            var list= ((MakinaBll)Bll).List(_filter);

            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
            
        }

        protected override void VeriAktar()
        {
            var list = new List<Makina>();
            Expression<Func<Makina, bool>> filter;
            filter = x => x.Id != 0;
            ShowVeriAktarListForms<VeriAktarimListForm, Makina, MakinaBll>.ShowDialogListForm(KartTuru.Makina, filter, new MakinaBll());
        }
    }
}
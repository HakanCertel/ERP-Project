using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SenfoniYazilim.Erp.Common.Message;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms
{
    public partial class ReceteListForm : BaseListForm
    {
        private readonly Expression<Func<Recete, bool>> _filter;

        public ReceteListForm()
        {
            InitializeComponent();

            Bll = new ReceteBll();
            ShowItems = new BarItem[] { btnIceriVeriAktar };
            _filter = x => x.Durum == AktifKartlariGoster;
        }
        public ReceteListForm(params object[] prm):this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Recete;
            FormShow = new ShowEditForms<ReceteEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list= ((ReceteBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;

            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }

        protected override void VeriAktar()
        {
            var list = new List<Recete>();
            Expression<Func<Recete, bool>> filter;
            filter = null;
            ShowVeriAktarListForms<VeriAktarimListForm, Recete, ReceteBll>.ShowDialogListForm(KartTuru.Recete, filter, new ReceteBll());
        }
        protected override void ShowEditForm(long id)
        {
            if (id < 0)
            {
                //base.ShowEditForm(id);
                ShowEditForms<ReceteEditForm>.ShowForm(KartTuru.Recete, -1);
            }
            else
            {
            var entity = Tablo.GetRow<ReceteL>(false);
            if (entity == null) return;
            if(entity.Id>0)
                ShowEditForms<ReceteEditForm>.ShowForm(KartTuru.Recete, entity.Id);
            }
        }
    }
}
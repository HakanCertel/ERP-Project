using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.TahakkukForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.OgrenciForms
{
    public partial class PersonelListForm : BaseListForm
    {
        private readonly Expression<Func<Personel, bool>> _filter;
        private readonly string _tabloCaption;
        public PersonelListForm()
        {
            InitializeComponent();

            Bll = new PersonelBll();
            _filter = x => x.Durum == AktifKartlariGoster;
            //ShowItems = new BarItem[] { btnTahakkukYap };
        }
        public PersonelListForm(params object[] prm):this()
        {
            if (prm[0] != null)
                _tabloCaption = prm[0].ToString();
            //if(prm[1]!=null)
            //    _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Personel;
            FormShow = new ShowEditForms<PersonelEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            var list = ((PersonelBll)Bll).List(_filter);
            Tablo.ViewCaption = _tabloCaption ?? "Personel Kartları";
            Tablo.GridControl.DataSource = list;//((PersonelBll)Bll).List(FilterFunctions.Filter<Personel>(AktifKartlariGoster));
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }

        protected override void TahakkukYap()
        {
            var entity = Tablo.GetRow<PersonelL>().EntityCovert<Personel>();

            if (entity == null) return;

            using (var bll = new TahakkukBll())
            {
                var tahakkuk = bll.SingleSummary(x => x.OgrenciId == entity.Id && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

                if (tahakkuk != null)
                    ShowEditForms<TahakkukEditForm>.ShowDialogForm(KartTuru.Tahakkuk, tahakkuk.Id, null);
                else
                    ShowEditForms<TahakkukEditForm>.ShowDialogForm(KartTuru.Tahakkuk, -1, entity);
            }
        }
    }
}
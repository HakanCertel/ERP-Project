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

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms
{
    public partial class StokListForm : BaseListForm
    {
        private readonly Expression<Func<Material, bool>> _filter;
        private readonly string _tabloCaption;//bu değişken parametre Olarak Makina_MakinaElemanlariBilgileriTable'den
        //parametre olarak gönderilerek hangi makina için mekina elemanı seçimi yapıldığını belirtebilmek için kullanılmaktadır.

        public StokListForm()
        {
            InitializeComponent();
            Bll = new MaterialBll();
            ShowItems = new DevExpress.XtraBars.BarItem[] { btnIceriVeriAktar };
            _filter = x => x.Durum == AktifKartlariGoster;
        }

        public StokListForm(params object[] prm):this()
        {
            if (prm.Length > 1)
            {
                _tabloCaption = prm[1].ToString();
            }
            //else if((bool)prm[0])
            //    _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster&&x.Uretilebilir;
            //if(ListeDisiTutulacakKayitlar != null )
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            var definations = Erp.Bll.Functions.GetAnySingleOrListBll.ListDefinations(x=>x.KartTuru==KartTuru.Stok).ToList();
            int count = 0;
            string feature = "FeatureDescription";
            if(definations.Count>0)
                foreach (var item in definations)
                {
                    count++;
                    tablo.Columns[feature + count].Caption = item.Description;
                    tablo.Columns[feature + count].Visible = item.IsActive;
                    tablo.Columns[feature + count].OptionsColumn.ShowInCustomizationForm = item.IsActive;

                }

            BaseKartTuru = KartTuru.Stok;
            FormShow = new ShowEditForms<StokEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            if (_tabloCaption != null)
                Tablo.ViewCaption = _tabloCaption;
            var list = ((MaterialBll)Bll).List(_filter);

            Tablo.GridControl.DataSource = list;
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
           
        }

        protected override void VeriAktar()
        {
            var list = new List<Material>();
            Expression<Func<Material, bool>> filter;
            filter = x => x.Id != 0;
             ShowVeriAktarListForms<VeriAktarimListForm, Material,MaterialBll>.ShowDialogListForm(KartTuru.Stok,filter, new MaterialBll());
        }
    }
}
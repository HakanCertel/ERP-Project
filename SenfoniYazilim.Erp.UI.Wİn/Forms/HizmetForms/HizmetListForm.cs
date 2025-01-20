using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraPrinting.Native;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.HizmetForms
{
    public partial class HizmetListForm : BaseListForm
    {
        private readonly Expression<Func<Hizmet, bool>> _filter;

        public HizmetListForm()
        {
            InitializeComponent();

            Bll = new HizmetBll();

            _filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }

        public HizmetListForm(params object[] prm):this()
        {
            if(prm[0]!=null)/*parametre ile ilgili null kıntrolü yapılmasının sebebi parametre gönderilmemesi
                durumunda hataya neden olmamak içindir..*/
            {
                var panelGoster = (bool)prm[0];

                ustPanel.Visible = DateTime.Now.Date > AnaForm.DonemParametreleri.EgitimBaslamaTarihi && panelGoster;
            }
            _filter =x=>!ListeDisiTutulacakKayitlar.Contains(x.Id)&& x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId&&x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Hizmet;
            FormShow = new ShowEditForms<HizmetEditForm>();
            Navigator = longNavigator.Navigator;
            TarihAyarla(); 
        }

        protected override void Listele()
        {
            var list = ((HizmetBll)Bll).List(_filter);

            Tablo.GridControl.DataSource = list;
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }

        private  void TarihAyarla()
        {
            txtxHizmetBaslamaTarihi.Properties.MinValue = AnaForm.DonemParametreleri.GünTarihininOncesineHizmetBaslamaTarihiGirilebilir 
                ? AnaForm.DonemParametreleri.EgitimBaslamaTarihi 
                : DateTime.Now.Date < AnaForm.DonemParametreleri.EgitimBaslamaTarihi 
                ? AnaForm.DonemParametreleri.EgitimBaslamaTarihi 
                : DateTime.Now.Date;
            txtxHizmetBaslamaTarihi.Properties.MaxValue = AnaForm.DonemParametreleri.GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir 
                ? AnaForm.DonemParametreleri.DonemBitisTarihi 
                : DateTime.Now.Date < AnaForm.DonemParametreleri.EgitimBaslamaTarihi 
                ? AnaForm.DonemParametreleri.EgitimBaslamaTarihi 
                : DateTime.Now.Date > AnaForm.DonemParametreleri.DonemBitisTarihi 
                ? AnaForm.DonemParametreleri.DonemBitisTarihi 
                : DateTime.Now.Date;
            txtxHizmetBaslamaTarihi.DateTime = DateTime.Now.Date <= AnaForm.DonemParametreleri.EgitimBaslamaTarihi 
                ? AnaForm.DonemParametreleri.EgitimBaslamaTarihi 
                : DateTime.Now.Date > AnaForm.DonemParametreleri.EgitimBaslamaTarihi && DateTime.Now.Date <= AnaForm.DonemParametreleri.DonemBitisTarihi 
                ? DateTime.Now.Date 
                : DateTime.Now.Date > AnaForm.DonemParametreleri.DonemBitisTarihi 
                ? AnaForm.DonemParametreleri.DonemBitisTarihi 
                : DateTime.Now.Date;
        }

        protected override void SelectEntity()
        {
            base.SelectEntity();
            if(MultiSelect)
                SelectedEntities.ForEach(x => ((HizmetL)x).BaslamaTarihi = txtxHizmetBaslamaTarihi.DateTime.Date);
        }

    }
}
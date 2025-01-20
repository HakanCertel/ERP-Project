using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaSiparisForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using System;
using System.Linq.Expressions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.SatinalmaSiparisForms
{
    public partial class PurchaseOrderListForm : BaseListForm
    {
        private Expression<Func<PurchaseOrder, bool>> _filter;

        public PurchaseOrderListForm()
        {
            InitializeComponent();
            Bll = new PurchaseOrderBll();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnSil, btnChangeBaseStatus };

            if (AnaForm.KullaniciYetkisi == KullaniciYetkisi.Yonetici)
                _filter = x => x.Durum == AktifKartlariGoster;
            else
                _filter = x => x.Durum == AktifKartlariGoster && x.OrderCreatorId == AnaForm.KullaniciId;
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.PurchaseOrder;
            FormShow = new ShowEditForms<PurchaseOrderEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PurchaseOrderBll)Bll).List(_filter);
        }
    }
}
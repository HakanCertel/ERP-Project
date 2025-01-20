using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General.WayBillBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.WayBillEntities;
using SenfoniYazilim.Erp.Bll.General.SalesBll;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Model.Dto.SalesDto;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using System.Linq.Expressions;
using System;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SaleWayBillForms
{
    public partial class SalesOfferListForm : BaseListForm
    {
        private Expression<Func<SalesOffer, bool>> _filter;

        public SalesOfferListForm()
        {
            InitializeComponent();

            Bll = new SalesOfferBll();

            HideItems = new DevExpress.XtraBars.BarItem[] { btnChangeBaseStatus,btnSil };

            if (AnaForm.KullaniciYetkisi == KullaniciYetkisi.Yonetici)
                _filter = x => x.Durum == AktifKartlariGoster;
            else
                _filter = x => x.Durum == AktifKartlariGoster && x.CreatorId == AnaForm.KullaniciId;
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.SalesOffer;
            FormShow = new ShowEditForms<SalesOfferEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SalesOfferBll)Bll).List(_filter);
        }
        protected override void EntityDelete()
        {
            var entity = Tablo.GetRow<SalesOfferL>();
            if (entity == null) return;
            var items = GetAnySingleOrListBll.ListSalesOfferItems(x => x.SalesOfferId == entity.Id);
            if (GetAnySingleOrListBll.DeleteSalesOfferItems(items))
                base.EntityDelete();
        }
        protected override bool SelectedEntityActiveOrPasive()
        {
            var entity = Tablo.GetRow<SalesOfferL>().EntityCovert<SalesOffer>();
            if (entity == null) return false;

            var offer =(SalesOffer) ((SalesOfferBll)Bll).Single(x => x.Id == entity.Id);
            offer.Durum = false;
            ((SalesOfferBll)Bll).Update(entity);

            var items = GetAnySingleOrListBll.ListSalesOfferItems(x => x.SalesOfferId == entity.Id);
            items.ForEach(x => { x.IsActive = !x.IsActive; });

            return InstanceBaseHareketEntityBll<SalesOfferItems, SalesOfferItemsBll>.UpdateEntities(items);
        }
    }
}
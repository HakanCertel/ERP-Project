using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Bll.General.SalesBll;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using System.Linq.Expressions;
using System;
using SenfoniYazilim.Erp.Model.Dto.SalesDto;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Common.Message;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SaleWayBillForms
{
    public partial class SalesListForm : BaseListForm
    {
        private Expression<Func<Sales, bool>> _filter;

        public SalesListForm()
        {
            InitializeComponent();

            Bll = new SalesBll();

            if (AnaForm.KullaniciYetkisi == KullaniciYetkisi.Yonetici)
                _filter = x => x.Durum == AktifKartlariGoster;
            else
                _filter = x => x.Durum == AktifKartlariGoster && x.CreatorId == AnaForm.KullaniciId;
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Sales;
            FormShow = new ShowEditForms<SalesEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SalesBll)Bll).List(_filter);
        }

        //protected override void EntityDelete()
        //{
        //    var entity = Tablo.GetRow<SalesL>();
        //    if (entity == null) return;
        //    var items = GetAnySingleOrListBll.ListSalesItems(x => x.SalesId == entity.Id);
        //    if (InstanceBaseHareketEntityBll<SalesItems,SalesItemsBll>.DeleteEntites(items))
        //        base.EntityDelete();
        //}
    }
}
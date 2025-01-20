using System;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using System.Linq.Expressions;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.Common.Enums;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaTeklifForms
{
    public partial class PurchaseOfferListForm : BaseListForm
    {
        private readonly Expression<Func<PurchaseDemandItems, bool>> _filter;

        public PurchaseOfferListForm()
        {
            InitializeComponent();

            Bll = new PurchaseOfferBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.PurchaseDemandItems;
            Navigator = longNavigator.Navigator;
            //HareketRowsSelected = new SelectRowFunctionsBaseHareketEntity(Tablo);
            FormShow = new ShowEditForms<PurchaseOfferEditForm>();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PurchaseOfferBll)Bll).List(FilterFunctions.Filter<PurchaseOffer>(AktifKartlariGoster));
        }
    }
}
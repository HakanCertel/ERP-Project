using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Bll.General;
using System.Windows.Forms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using System.Collections.Generic;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.Linq;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using System;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using SenfoniYazilim.Erp.Common.Message;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms
{
    public partial class PurchaseDemandItemsManagerComfirmListForm : BaseListForm
    {

        public PurchaseDemandItemsManagerComfirmListForm()
        {
            InitializeComponent();

            Bll = new PurchaseDemandItemsFormBll();
            MultiSelect = true;
            ShowItems = new BarItem[] { btnComfirm };
            HideItems = new BarItem[] {btnActive,btnCancel,btnCloseItem, btnYeni, btnSec,btnDuzelt,btnSil,btnKaydet,btnIceriVeriAktar };
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.PurchaseDemandItems;
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PurchaseDemandItemsFormBll)Bll)
                .List(x=>x.IsPurchaseDemandActive==AktifKartlariGoster&&x.DemandComfirmState==MangerComfirmState.Sended);
        }

        protected override void EntityDelete(){}

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            //se.SagMenuGoster(null);
        }
        protected override void ChangeStatus(ItemStatus status)
        {
            var onaylanacakKalemler = new List<BaseHareketEntity>();
            if (HareketRowsSelected.SelectedRowCount == 0)
            {
                Messages.KartSecmemeUyariMesaji();
                return;
            }
            HareketRowsSelected.GetSelectedRows().EntityListConvert<EntirePurchaseDemandItems>().ToList().ForEach(x =>
            {
                x.DemandComfirmState = MangerComfirmState.Comfirmed;
                x.IsComfirmed = true;
                onaylanacakKalemler.Add(x);
            });

            ((PurchaseDemandItemsFormBll)Bll).Update(onaylanacakKalemler);
            //base.ChangeStatus(status);
            Tablo.RowFocus(Tablo.FocusedRowHandle);
            HareketRowsSelected.ClearSelection();
            Listele();
        }

        protected override void Tablo_DoubleClick(object sender, EventArgs e){}
    }
}
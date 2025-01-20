using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Common.Enums;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using System.Linq.Expressions;
using System;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using System.Linq;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaSiparisForms;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.SatinalmaSiparisForms
{
    public partial class PurchaseOrderItemsListForm : BaseListForm
    {
        private readonly Expression<Func<PurchaseOrderItems, bool>> _filter;

        public PurchaseOrderItemsListForm()
        {
            InitializeComponent();

            Bll = new PurchaseOrderItemsBll();
            HideItems = new BarItem[] { btnSil,btnChangeBaseStatus,btnCancel,btnCloseItem,btnCreateOrder};
            //ShowItems = new BarItem[] { btnCreateOrder,btnChangeBaseStatus };
            if (AnaForm.KullaniciYetkisi == KullaniciYetkisi.Yonetici)
                _filter = x => x.IsActive == AktifKartlariGoster;
            else
                _filter = x => x.IsActive == AktifKartlariGoster && x.OrderCreatorId == AnaForm.KullaniciId;
        }
        public PurchaseOrderItemsListForm(params object[] prm):this()
        {
            _filter = x => x.IsActive == !AktifKartlariGoster && !ListeDisiTutulacakKayitlar.Contains(x.Id);
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.PurchaseOrder;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<PurchaseOrderEditForm>();

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PurchaseOrderItemsBll)Bll).List(_filter);
        }

        protected override void ShowEditForm(long id)
        {
            if (HareketRowsSelected.SelectedRowCount == 0 && id == -1)
            {
                base.ShowEditForm(id);
                return;
            }
            if (HareketRowsSelected.SelectedRowCount > 1)
            {
                Messages.BilgiMesaji("Lütfen Tek Bir Satır Seçerek , Tekrar Deneyiniz .");
                HareketRowsSelected.ClearSelection();
                return;
            }

            var focusedEntity = HareketRowsSelected.GetSelectedRows().EntityListConvert<PurchaseOrderItemsL>().FirstOrDefault(); //Tablo.GetRow<TumSatinalmaTalepKalemleri>();
            HareketRowsSelected.ClearSelection();
            var result = ShowEditForms<PurchaseOrderEditForm>.ShowDialogForm(BaseKartTuru, focusedEntity.OwnerFormId, focusedEntity.Id);
            ShowEditFormDefault(result);
        }

        //protected override void EntityDelete()
        //{
        //    var selectedEntities = HareketRowsSelected.GetSelectedRows().EntityListConvert<PurchaseOrderItemsL>().ToList();

        //    if (selectedEntities == null)
        //    {
        //        Messages.KartSecmemeUyariMesaji();
        //        return;
        //    }

        //    //if (!DeleteConfirm(selectedEntities.Any(x => x.ManagerComfirmState != YoneticiOnayDurum.IslemYapilmadi), selectedEntities.Any(x => x.OfferComfirmState != YoneticiOnayDurum.IslemYapilmadi), selectedEntities.Any(x => x.PurchaseOrderId != null))) return;

        //    var deletingEntity = new List<BaseHareketEntity>();

        //    selectedEntities.ForEach(x =>
        //    {
        //        deletingEntity.Add(x);
        //    });

        //    ((PurchaseOrderItemsBll)Bll).Delete(deletingEntity);
        //    //Tablo.DeleteSelectedRows();
        //    //Tablo.RowFocus(Tablo.FocusedRowHandle);
        //    Listele();
        //    HareketRowsSelected.ClearSelection();
        //}

        //protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        //{
        //    e.SagMenuGoster(popupMenuSatinalmaTalepKalemleri);
        //}
    }
}
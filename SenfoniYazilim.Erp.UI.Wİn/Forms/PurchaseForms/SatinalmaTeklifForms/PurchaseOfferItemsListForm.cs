using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
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
using System.Windows.Forms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.Collections.Generic;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaTeklifForms;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaSiparisForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.SatinalmaTeklifForms
{
    public partial class PurchaseOfferItemsListForm : BaseListForm
    {
        private readonly Expression<Func<PurchaseOfferItems, bool>> _filter;

        public PurchaseOfferItemsListForm()
        {
            InitializeComponent();

            Bll = new PurchaseOfferItemsBll();
            HideItems = new BarItem[] { btnTalepBirlestir,btnTeklifTopla};
            ShowItems = new BarItem[] { btnCreateOrder,btnChangeBaseStatus };
            _filter = x => x.IsOfferActive == AktifKartlariGoster && !x.IsCreatedOrder;
        }
        
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.PurchaseOffer;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<PurchaseOfferEditForm>();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PurchaseOfferItemsBll)Bll).List(_filter);
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

            var focusedEntity = HareketRowsSelected.GetSelectedRows().EntityListConvert<PurchaseOfferItemL>().FirstOrDefault(); //Tablo.GetRow<TumSatinalmaTalepKalemleri>();
            HareketRowsSelected.ClearSelection();
            if (focusedEntity == null) return;
            var result =ShowEditForms<PurchaseOfferEditForm>.ShowDialogForm(BaseKartTuru,focusedEntity.OfferId,focusedEntity.Id);
            ShowEditFormDefault(result);
        }

        protected override void CreateOrder()
        {

            var entities = HareketRowsSelected.GetSelectedRows().Cast<PurchaseOfferItemL>()
                .Where(x => !x.IsCreatedOrder).ToList();

            if (entities.Count == 0)
            {
                Messages.KartSecmemeUyariMesaji();
                return;
            }

            ShowEditForms<PurchaseOrderEditForm>.ShowDialogForm(IslemTuru.EntityInsert, entities.Cast<BaseHareketEntity>().ToList(), PurchaseOrderCreatingMethod.ChoosePurchaseOfferItem);

            HareketRowsSelected.ClearSelection();
        }
        protected override void EntityDelete()
        {
            var selectedEntities = HareketRowsSelected.GetSelectedRows().EntityListConvert<PurchaseOfferItemL>().Where(x=>!x.IsCreatedOrder).ToList();

            if (selectedEntities == null) return;

            //if (!DeleteConfirm(selectedEntities.Any(x => x.ManagerComfirmState != YoneticiOnayDurum.IslemYapilmadi), selectedEntities.Any(x => x.OfferComfirmState != YoneticiOnayDurum.IslemYapilmadi), selectedEntities.Any(x => x.PurchaseOrderId != null))) return;

            var deletingEntity = new List<BaseHareketEntity>();

            selectedEntities.ForEach(x =>
            {
                deletingEntity.Add(x);
            });

            ((PurchaseOfferItemsBll)Bll).Delete(deletingEntity);
            //Tablo.DeleteSelectedRows();
            //Tablo.RowFocus(Tablo.FocusedRowHandle);
            Listele();
            HareketRowsSelected.ClearSelection();
        }

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            e.SagMenuGoster(popupMenuSatinalmaTalepKalemleri);
        }
    }
}
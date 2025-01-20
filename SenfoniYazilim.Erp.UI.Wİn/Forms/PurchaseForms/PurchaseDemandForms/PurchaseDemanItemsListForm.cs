using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Common.Enums;
using System.Windows.Forms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using System.Collections.Generic;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.Linq;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Common.Message;
using System;
using System.Linq.Expressions;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Model.Entities.Satınalma.PurchaseSettingsEntites;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaTeklifForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaSiparisForms;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.PurchaseDemandForms
{
    public partial class PurchaseDemanItemsListForm : BaseListForm
    {
        private readonly Expression<Func<PurchaseDemandItems, bool>> _filter;

        private readonly PurchaseSettings _setting;

        public PurchaseDemanItemsListForm()
        {
            InitializeComponent();
            
            Bll = new PurchaseDemandItemsFormBll();

            HideItems = new BarItem[] {btnCloseItem,btnCancel,btnSil};
            ShowItems = new BarItem[] { btnDetail };

            _setting = GetAnySingleOrListBll.GetPurchaseSettings(x => x.Id == 1);

            if (AnaForm.KullaniciYetkisi == KullaniciYetkisi.Yonetici)
                _filter = x => x.IsActive == AktifKartlariGoster && !x.IsTopDemandExisted;
            else
                _filter = x => x.IsActive == AktifKartlariGoster && !x.IsTopDemandExisted && x.CreatorId== AnaForm.KullaniciId;
        }

        public PurchaseDemanItemsListForm(params object[] prm):this(){}

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.PurchaseDemandItems;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<PurchaseDemanEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PurchaseDemandItemsFormBll)Bll).List(_filter);//&&!x.UstTalepOlusturuldu);
        }

        protected override void EntityDelete()
        {
            #region Comment
           // var selectedEntities = HareketRowsSelected.GetSelectedRows().EntityListConvert<EntirePurchaseDemandItems>().ToList();// Tablo.GetRow<TumSatinalmaTalepKalemleri>();

           // if (selectedEntities == null) return;

           //// if (!DeleteConfirm(selectedEntities.Any(x => x.DemandComfirmState != MangerComfirmState.NoProccess), selectedEntities.Any(x => x.OfferComfirmState != MangerComfirmState.NoProccess), selectedEntities.Any(x => x.PurchaseOrderId != null))) return;

           // var deletingEntity = new List<BaseHareketEntity>();

           // selectedEntities.ForEach(x =>
           // {
           //     deletingEntity.Add(x);
           // });

           // ((PurchaseDemandItemsFormBll)Bll).Delete(deletingEntity);

           // //Tablo.DeleteSelectedRows();
           // Tablo.RowFocus(Tablo.FocusedRowHandle);
           // Listele();
           // HareketRowsSelected.ClearSelection();
            #endregion
        }

        //protected override void Tablo_DoubleClick(object sender, EventArgs e){}

        protected override void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            var row = Tablo.GetRow<PurchaseDemandItemsListFormL>(false);
            if (row == null) return;

            btnTalepBirlestir.Caption = row.IsTopDemand ? "Talep Boz" : "Talep Birleştir";
          
            e.SagMenuGoster(popupMenuSatinalmaTalepKalemleri);

        }

        protected override void Tablo_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            var entity = Tablo.GetRow<PurchaseDemandItemsListFormL>(false);
            if (entity == null) return;
            btnDetail.Enabled = entity.IsTopDemand;
            btnTeklifTopla.Enabled = !entity.IsTopDemandExisted;
            btnYoneticiOnayinaGonder.Enabled= !entity.IsTopDemandExisted;
            btnTalepBirlestir.Enabled= !entity.IsTopDemandExisted;
            btnChangeBaseStatus.Enabled= !entity.IsTopDemandExisted;
            btnCreateOrder.Enabled= !entity.IsTopDemandExisted;
        }

        protected override void SendManagerComfirm()
        {
            int rowHandle;
            var updateEntities = new List<BaseHareketEntity>();
            var entities = HareketRowsSelected.GetSelectedRows().Cast< PurchaseDemandItemsListFormL>()
                .Where(x=>x.DemandComfirmState== MangerComfirmState.NoProccess).ToList();

            if (entities.Count == 0)
            {
                Messages.BilgiMesaji("Onaya Gönderilebilecek Talep Kalemi Bulunamamıştır .");
                return;
            }
            entities.Cast<PurchaseDemandItemsListFormL>().ForEach(x=> 
            {
                switch (x.DemandComfirmState)
                {
                    case MangerComfirmState.Canceled:
                    case MangerComfirmState.NoProccess:
                        x.DemandComfirmState=MangerComfirmState.Sended;
                        updateEntities.Add(x);
                        break;
                }
            });
            
            ((PurchaseDemandItemsFormBll)Bll).Update(updateEntities);
            rowHandle = Tablo.FocusedRowHandle;
            HareketRowsSelected.ClearSelection();
            Listele();
            Tablo.RowFocus(rowHandle);
        }

        protected override void CancelManagerComfirm()
        {
            int rowHandle;
            var updateEntities = new List<BaseHareketEntity>();
            var entities = HareketRowsSelected.GetSelectedRows().Cast< PurchaseDemandItemsListFormL>()
                .Where(x=>x.DemandComfirmState==MangerComfirmState.Comfirmed||x.DemandComfirmState==MangerComfirmState.Sended).ToList();//.EntityListConvert<PurchaseDemandItemsListFormL>().ToList();

            if (entities.Count == 0)
            {
                Messages.BilgiMesaji("İptal Edilecek Talep Kalemi Bulunamamıştır .");
                return;
            }
            entities.Cast<PurchaseDemandItemsListFormL>().ForEach(x =>
            {
                switch (x.DemandComfirmState)
                {
                    case MangerComfirmState.Sended:
                    case MangerComfirmState.Comfirmed:
                        x.DemandComfirmState =MangerComfirmState.NoProccess ;
                        updateEntities.Add(x);
                        break;
                }
            });

            ((PurchaseDemandItemsFormBll)Bll).Update(updateEntities);
            rowHandle = Tablo.FocusedRowHandle;
            HareketRowsSelected.ClearSelection();
            Listele();
            Tablo.RowFocus(rowHandle);
        }

        protected override void TeklifTopla()
        {
            var entities = HareketRowsSelected.GetSelectedRows().Cast<PurchaseDemandItemsListFormL>()
                .Where(x=>!x.IsCreatedOrder||!x.IsCreateOffer).ToList();

            if (entities.Count == 0)
            {
                Messages.KartSecmemeUyariMesaji();
                return;
            }
            
            ShowEditForms<PurchaseOfferEditForm>.ShowDialogForm(IslemTuru.EntityInsert, entities.Cast<BaseHareketEntity>().ToList(), PurchaseOfferCreatingMethod.ChoosePurchaseDemandItem);

            HareketRowsSelected.ClearSelection();
        }

        protected override void CreateOrder()
        {

            var entities = HareketRowsSelected.GetSelectedRows().Cast<PurchaseDemandItemsListFormL>()
                .Where(x => !x.IsCreatedOrder).ToList();

            if (entities.Count == 0)
            {
                Messages.KartSecmemeUyariMesaji();
                return;
            }

            ShowEditForms<PurchaseOrderEditForm>.ShowDialogForm(IslemTuru.EntityInsert, entities.Cast<BaseHareketEntity>().ToList(), PurchaseOrderCreatingMethod.ChoosePurchaseDemandItem);

            HareketRowsSelected.ClearSelection();
        }

        protected override void DetailList()
        {
            var entity = Tablo.GetRow<PurchaseDemandItemsListFormL>(false);
            if (entity == null) return;
            Tablo.GridControl.DataSource = ((PurchaseDemandItemsFormBll)Bll).List(x => x.ConnectedItemsId == entity.Id);
        }

        protected override bool ItemBirlestir()
        {
            var selectedRows = HareketRowsSelected.GetSelectedRows().EntityListConvert<PurchaseDemandItemsListFormL>();
            var selectedEntity = HareketRowsSelected.GetSelectedRows().FirstOrDefault().EntityCovert<PurchaseDemandItemsListFormL>();
            var accepted = HareketRowsSelected.GetSelectedRows().Count != HareketRowsSelected.GetSelectedRows().Cast<PurchaseDemandItemsListFormL>().Select(x => x.MaterialId = selectedEntity.MaterialId).Count();

            if (HareketRowsSelected.GetSelectedRows().Count == 0) return false;

            if (accepted)
            {
                Messages.HataMesaji("Stok kalemleri içinde aynı olmayan stoklar mevcut. Birleştirme işlemi yapılamaz!");
                return false;
            }
            
            else if (HareketRowsSelected.SelectedRowCount < 2)
            {
                Messages.HataMesaji("Birleştirme işlemi için birden fazla kayıt seçilmeli!");
                return false;
            }
            var newRow = new PurchaseDemandItems
            {
                OwnerFormId = selectedEntity.OwnerFormId,
                MaterialId = selectedEntity.MaterialId,
                DemandQty = selectedRows.Sum(x => x.DemandQty),
                DemandedDate = ((PurchaseDemandItemsFormBll)Bll).List(x => x.Id != 0).EntityListConvert<PurchaseDemandItems>().Min(x => x.DemandedDate),
                IsTopDemand = true
            };
            if (((PurchaseDemandItemsFormBll)Bll).InsertSingle(newRow)) Messages.BilgiMesaji($"{selectedRows.Count()} Adet kayıt birleştirildi");

            var connectedItemId = ((PurchaseDemandItemsFormBll)Bll).List(x => x.Id != 0).Max(x => x.Id);
            
            var connectedItems = new List<BaseHareketEntity>();
            selectedRows.ForEach(x =>
            {
                x.ConnectedItemsId = connectedItemId;
                x.IsTopDemandExisted = true;
                connectedItems.Add(x);
            });

            ((PurchaseDemandItemsFormBll)Bll).Update(connectedItems);
            HareketRowsSelected.ClearSelection();
            return true;
        }

        protected override bool ItemBoz()
        {
            var selectedRow = Tablo.GetRow<PurchaseDemandItemsListFormL>(false);

            if (selectedRow == null) return false;

            var connectedItems = ((PurchaseDemandItemsFormBll)Bll).List(x => x.Id == selectedRow.ConnectedItemsId).EntityListConvert<PurchaseDemandItemsListFormL>();
            var updateItems = new List<BaseHareketEntity>();
            connectedItems.ForEach(x =>
            {
                x.ConnectedItemsId = 0;
                x.IsTopDemandExisted = false;
                updateItems.Add(x);
            });
            if (!((PurchaseDemandItemsFormBll)Bll).Update(updateItems)){ return false;}

            updateItems.Clear();

            updateItems.Add(selectedRow);
            ((PurchaseDemandItemsFormBll)Bll).Delete(updateItems);
            HareketRowsSelected.ClearSelection();
            Messages.BilgiMesaji("İşlem Başarıyla gerçekleştirilmiştir");
            return true;
        }
       
        protected override void ShowEditForm(long id)
        {
            if (HareketRowsSelected.SelectedRowCount == 0 && id == -1)
            {
                base.ShowEditForm(id);
                return;
            }
            if (HareketRowsSelected.SelectedRowCount > 1 || HareketRowsSelected.SelectedRowCount == 0)
            {
                Messages.BilgiMesaji("Lütfen Tek Bir Satır Seçerek , Tekrar Deneyiniz .");
                HareketRowsSelected.ClearSelection();
                return;
            }

            var focusedEntity = HareketRowsSelected.GetSelectedRows().EntityListConvert<PurchaseDemandItemsListFormL>().FirstOrDefault(); //Tablo.GetRow<TumSatinalmaTalepKalemleri>();
            HareketRowsSelected.ClearSelection();
            if (focusedEntity == null) return;
            var result = ShowEditForms<PurchaseDemanEditForm>.ShowDialogForm(BaseKartTuru, focusedEntity.OwnerFormId, focusedEntity.Id);
            ShowEditFormDefault(result);
        }


    }
}
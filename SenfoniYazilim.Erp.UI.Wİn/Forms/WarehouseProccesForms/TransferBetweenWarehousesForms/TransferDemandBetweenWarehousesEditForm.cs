using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraEditors;
using System;
using SenfoniYazilim.Erp.Bll.General.WarehouseBll;
using SenfoniYazilim.Erp.Model.Dto.WareHousesDto;
using SenfoniYazilim.Erp.Model.Entities.WareHouseEntities;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using System.Linq;
using SenfoniYazilim.Erp.Model.Dto;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Model.Dto.CRPDto;
using SenfoniYazilim.Erp.Bll.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.TransferBetweenWarehousesForms
{
    public partial class TransferDemandBetweenWarehousesEditForm : BaseEditForm
    {
        private readonly WorkOrdersL _wo;

        public TransferDemandBetweenWarehousesEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new TransferDemandWarehouseBll();
            BaseKartTuru = KartTuru.TransferDemandBetweenWarehouses;
            EventsLoad();

            txtTransferCreatingMethod.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<TransferCreatingMethod>());
            
        }

        public TransferDemandBetweenWarehousesEditForm(params object[] prm):this()
        {
            if(prm[0]!=null)
                _wo = (WorkOrdersL)prm[0];
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new TransferDemandWarehouseS() : ((TransferDemandWarehouseBll)Bll).Single(FilterFunctions.Filter<TransferBetweenWarehouse>(Id));

            if (((TransferDemandWarehouseS)OldEntity).DescriptionOfTransferProccess == DescriptionOfTransferProccess.Transfer)
            {
                txtTransfer.Enabled = false;
                btnGerial.Visibility = BarItemVisibility.Never;
                btnSil.Visibility = BarItemVisibility.Never;
                btnKaydet.Visibility = BarItemVisibility.Never;
            }

            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityUpdate)
            {
                Id = BaseIslemTuru.IdOlustur(OldEntity);
                OldEntity.Kod = ((TransferDemandWarehouseBll)Bll).YeniKodVer("WTD");
                ((TransferBetweenWarehouse)OldEntity).CreateDate = DateTime.Now;
                ((TransferBetweenWarehouse)OldEntity).CreatorUserId = AnaForm.KullaniciId;
                ((TransferBetweenWarehouse)OldEntity).DescriptionOfTransferProccess = DescriptionOfTransferProccess.TransferDemand;
                txtDocumentDate.EditValue = DateTime.Now;
                txtTransferCreatingMethod.SelectedIndex = 0;
                txtTransferDepoAdi.Focus();
            }

            EnabledIsFalesOrTrue(BaseIslemTuru == IslemTuru.EntityInsert);

            TabloYukle();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (TransferDemandWarehouseS)OldEntity;

            txtTransferWarehouse.Id = entity.TransferWarehouseId;
            txtTransferWarehouse.Text = entity.TransferWarehouseCode;
            txtTransferDepoAdi.Text = entity.TransferWarehouseName;
            txtTransferedWarehouse.Id = entity.TransferedWarehouseId;
            txtTransferedWarehouse.Text =entity.TransferedWarehouseCode;
            txtTransferEdilenDepoAdi.Text = entity.TransferedWarehouseName;
            txtDocumentDate.DateTime = entity.DocumentDate;
            txtTransferCreatingMethod.Text = entity.TransferCreatingMethod.toName();
            txtDemandingUser.Id = entity.DemandingUserId;
            txtDemandingUser.Text = entity.DemandingUserName;
            txtDemandedDate.EditValue = entity.DemandedDate;
            tglState.IsOn = entity.Durum;
            txtTransfer.Checked = entity.DescriptionOfTransferProccess == DescriptionOfTransferProccess.Transfer;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new TransferBetweenWarehouse
            {
                Id = Id,
                Kod = OldEntity.Kod,
                TransferWarehouseId = (long)txtTransferWarehouse.Id,
                TransferedWarehouseId = (long)txtTransferedWarehouse.Id,
                CreateDate=((TransferBetweenWarehouse)OldEntity).CreateDate,
                CreatorUserId=((TransferBetweenWarehouse)OldEntity).CreatorUserId,
                DescriptionOfTransferProccess=((TransferBetweenWarehouse)OldEntity).DescriptionOfTransferProccess,
                DemandingUserId=txtDemandingUser.Id,
                DocumentDate=(DateTime)txtDocumentDate.EditValue,
                TransferCreatingMethod=txtTransferCreatingMethod.Text.GetEnum<TransferCreatingMethod>(),
                UpdatingUserId=((TransferBetweenWarehouse)OldEntity).UpdatingUserId,
                Durum=tglState.IsOn
            };
            if (txtTransfer.Checked)
                ((TransferBetweenWarehouse)CurrentEntity).DescriptionOfTransferProccess = DescriptionOfTransferProccess.Transfer;
            else
                ((TransferBetweenWarehouse)CurrentEntity).DescriptionOfTransferProccess = DescriptionOfTransferProccess.TransferDemand;

            if (txtDemandedDate.EditValue != null)
                ((TransferBetweenWarehouse)CurrentEntity).DemandedDate = (DateTime)txtDemandedDate.EditValue;
            if (((TransferBetweenWarehouse)OldEntity).UpdateDate != null)
                ((TransferBetweenWarehouse)CurrentEntity).UpdateDate = ((TransferBetweenWarehouse)OldEntity).UpdateDate;

            ButonEnabledDurumu();
        }

        protected internal override void ButonEnabledDurumu()
        {
            bool TableValueChanged()
            {
                if (transferDemandBetweenWarehouseTable.TableValueChanged) return true;

                return false;
            }

            if (!IsLoaded) return;

            Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, TableValueChanged());
        }

        protected override void TabloYukle()
        {
            transferDemandBetweenWarehouseTable.OwnerForm = this;
            transferDemandBetweenWarehouseTable._demandSourceCode = OldEntity.Kod;
            if (_wo != null)
            {
                transferDemandBetweenWarehouseTable._demandSourceCode = _wo.Kod;
                transferDemandBetweenWarehouseTable._wo = _wo;
                transferDemandBetweenWarehouseTable._transferMethod = TransferCreatingMethod.ChooseRequestItem;
                var material=GetAnySingleOrListBll.GetMaterial(x => x.Id == _wo.StokId);
                txtTransferWarehouse.Id = material.DepoId;
                txtTransferWarehouse.Text = material.DepoKodu;
                txtTransferDepoAdi.Text = material.DepoAdi;
                txtTransferedWarehouse.Id = _wo.DepoId;
                txtTransferedWarehouse.Text = _wo.DepoKodu;
                txtTransferEdilenDepoAdi.Text = _wo.DepoAdi;
                txtTransferCreatingMethod.Text = TransferCreatingMethod.ChooseRequestItem.toName();
                txtDemandedDate.EditValue = _wo.PlanlandigiTarih;
            }
            transferDemandBetweenWarehouseTable.Yukle();
        }

        protected override bool EntityInsert()
        {
            if (transferDemandBetweenWarehouseTable.HatalıGiriş()) return false;

            var entities = transferDemandBetweenWarehouseTable.Tablo.DataController.ListSource.Cast<TarnsferItemsBetweenWareHousesL>().ToList();

            if (entities.Count != 0)
                entities.ForEach(x =>
                {
                    x.TransferWareHouseId = (long)txtTransferWarehouse.Id;
                    x.TransferedWareHouseId = (long)txtTransferedWarehouse.Id;
                    x.DemandingUserId = txtDemandingUser.Id;
                    x.IsTransfered = txtTransfer.Checked;
                    x.IsClosed = x.DemandedQuantity <= x.TransferedQuantity;
                });

            var result = ((TransferDemandWarehouseBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod) && transferDemandBetweenWarehouseTable.Kaydet();

            if (result&&txtTransfer.Checked)
            {
                transferDemandBetweenWarehouseTable.Listele();

                var whmList = transferDemandBetweenWarehouseTable.TranferItem().Cast<WareHouseStockL>().ToList(); ;

                var insert =Erp.Bll.Functions.GetAnySingleOrListBll.UpdateWarehouseStock(whmList);

                if (insert)
                    transferDemandBetweenWarehouseTable.InsertStockMoving();
            }

            return result;
        }
        protected override bool EntityUpdate()
        {
            if (transferDemandBetweenWarehouseTable.HatalıGiriş()) return false;

            ((TransferBetweenWarehouse)CurrentEntity).UpdateDate = DateTime.Now;

            ((TransferBetweenWarehouse)CurrentEntity).UpdatingUserId = AnaForm.KullaniciId;

            var entities = transferDemandBetweenWarehouseTable.Tablo.DataController.ListSource.Cast<TarnsferItemsBetweenWareHousesL>().ToList();

            if (entities.Count != 0)
                entities.ForEach(x =>
                {
                    x.TransferWareHouseId = (long)txtTransferWarehouse.Id;
                    x.TransferedWareHouseId = (long)txtTransferedWarehouse.Id;
                    x.DemandingUserId = txtDemandingUser.Id;
                    x.IsTransfered = txtTransfer.Checked;
                    x.IsClosed = x.DemandedQuantity <= x.TransferedQuantity;
                });
            var result = ((TransferDemandWarehouseBll)Bll).Update(OldEntity, CurrentEntity) && transferDemandBetweenWarehouseTable.Kaydet();

            if (result && txtTransfer.Checked)
            {
                transferDemandBetweenWarehouseTable.Listele();
                var whmList = transferDemandBetweenWarehouseTable.TranferItem().Cast<WareHouseStockL>().ToList(); ;

                var insert = Erp.Bll.Functions.GetAnySingleOrListBll.UpdateWarehouseStock(whmList);

                if (insert)
                    transferDemandBetweenWarehouseTable.InsertStockMoving();
            }
            return result;
        }

        protected override void EntityDelete()
        {
            transferDemandBetweenWarehouseTable.TopluHareketSil();

            var result = transferDemandBetweenWarehouseTable.Kaydet();

            if (result)
                result=((TransferDemandWarehouseBll)Bll).Delete(OldEntity);

            RefreshYapilacak = true;
            Close();
        }

        protected override void BagliTabloYukle()
        {
           
            if (transferDemandBetweenWarehouseTable.OwnerForm == null)
            {
                transferDemandBetweenWarehouseTable.OwnerForm = this;
                transferDemandBetweenWarehouseTable.Yukle();
            }

        }
       
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtTransferWarehouse)
                    sec.Sec(txtTransferWarehouse, txtTransferDepoAdi);
                else if (sender == txtTransferedWarehouse)
                    sec.Sec(txtTransferedWarehouse, txtTransferEdilenDepoAdi);
                else if (sender == txtDemandingUser)
                    sec.Sec(txtDemandingUser);
            }
            transferDemandBetweenWarehouseTable.SutunGizleGoster();
            var whSetting = Erp.Bll.Functions.GetAnySingleOrListBll
                .GetWarehouseSetting(x => x.WarehouseId == txtTransferWarehouse.Id && x.UserId == AnaForm.KullaniciId);
            if (whSetting != null)
            {
                txtTransfer.Enabled = whSetting.CanTransfer || whSetting.KullaniciYetkisi == KullaniciYetkisi.Yonetici;
                txtTransfer.Checked = !whSetting.CanTransfer ? false : txtTransfer.Checked;
            }
        }

        private bool HataliGiris()
        {
            if (txtTransferWarehouse.Id == null)
            {
                Messages.HataMesaji("Lütfen Transfer Depo Alanına Geçerli Bir Değer Giriniz .");
                txtTransferWarehouse.Focus();
                return true;
            }
            if (txtTransferedWarehouse.Id == null)
            {
                Messages.HataMesaji("Lütfen Transfer Edilen Depo Alanına Geçerli Bir Değer Giriniz .");
                txtTransferedWarehouse.Focus();
                return true;
            }
            return false;
        }
       
        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            if (sender is MyComboBoxEdit||sender is MyCheckEdit)
            {
                transferDemandBetweenWarehouseTable.SutunGizleGoster();
                transferDemandBetweenWarehouseTable.Tablo.DataController
                    .ListSource.Cast<TarnsferItemsBetweenWareHousesL>()
                    .ToList().ForEach(x => 
                    {
                        x.TransferedQuantity =txtTransfer.Checked? x.DemandedQuantity:0;

                    });
            }
            base.Control_EditValueChanged(sender, e);
        }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            base.BaseEditForm_Shown(sender, e);
            if (BaseIslemTuru != IslemTuru.EntityUpdate) return;
            transferDemandBetweenWarehouseTable.Tablo.Focus();
            transferDemandBetweenWarehouseTable.Tablo.RowFocus("Id", SelectedItemId);
        }
    }
}
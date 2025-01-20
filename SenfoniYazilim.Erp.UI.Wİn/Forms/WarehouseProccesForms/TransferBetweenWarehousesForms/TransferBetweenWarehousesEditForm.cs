using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraEditors;
using System;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.TransferBetweenWarehousesForms
{
    public partial class TransferBetweenWarehousesEditForm : BaseEditForm
    {

        protected internal TarnsferItemsBetweenWareHousesL _kayitBilgileriL;

        public TransferBetweenWarehousesEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new TarnsferItemsBetweenWareHousesBll();
            BaseKartTuru = KartTuru.DepolarArasiTransfer;
            EventsLoad();

            txtTransferStatu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<TransferStatu>().Cast<object>().ToList());
            txtTransferStatu.SelectedIndex = 0;
        }
        public override void Yukle()
        {
            Id = Id < 0 ? IslemTuru.EntityInsert.IdOlustur(null):Id;
            txtTransferStatu.Enabled = BaseIslemTuru == IslemTuru.EntityInsert;
            NesneyiKontrollereBagla();

            BagliTabloYukle();
        }
        protected override void NesneyiKontrollereBagla()
        {
            OldEntity = new BaseEntity
            {
                Id = 0,
                Kod = ""
            };
            CurrentEntity = OldEntity;

            _kayitBilgileriL = (TarnsferItemsBetweenWareHousesL)((TarnsferItemsBetweenWareHousesBll)Bll).Single(x => x.OwnerFormId == Id);

            if (_kayitBilgileriL == null) return;

            txtTransferDepo.Id = _kayitBilgileriL.TransferWareHouseId;
            txtTransferDepo.Text = _kayitBilgileriL.TransferWareHouseCode;
            txtTransferDepoAdi.Text = _kayitBilgileriL.TransferWareHouseName;
            txtTransferEdilenDepo.Id = _kayitBilgileriL.TransferedWareHouseId;
            txtTransferEdilenDepo.Text = _kayitBilgileriL.TransferedWareHouseCode;
            txtTransferEdilenDepoAdi.Text = _kayitBilgileriL.TransferedWareHousename;
            txtTransferStatu.Text = _kayitBilgileriL.TransferStatu.toName();

        }
        protected override bool EntityInsert()
        {
            if (BagliTabloHataliGirisKontrol()) return false;

            var result1 = BagliTabloKaydet();
            if (result1 && !KayitSonrasiFormuKapat)
                depolarArasiTransferBilgileriTable.Yukle();

            return result1;
        }
        protected override bool EntityUpdate()
        {
            if (BagliTabloHataliGirisKontrol()) return false;

            var result1 = BagliTabloKaydet();
            if (result1 && !KayitSonrasiFormuKapat)
                depolarArasiTransferBilgileriTable.Yukle();

            return result1;
        }
        protected override void EntityDelete()
        {
           var source= depolarArasiTransferBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().ToList();
            source.ForEach(x =>
            {
                x.Delete = true;
            });
            var result1 = BagliTabloKaydet();
            if (result1 && !KayitSonrasiFormuKapat)
                depolarArasiTransferBilgileriTable.Yukle();

        }
        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);
            }
            if (depolarArasiTransferBilgileriTable.OwnerForm == null)
            {
                depolarArasiTransferBilgileriTable.OwnerForm = this;
                depolarArasiTransferBilgileriTable.Yukle();
            }

        }
        protected override bool BagliTabloKaydet()
        {
            if (!depolarArasiTransferBilgileriTable.Kaydet()) return false;

            return true;
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (depolarArasiTransferBilgileriTable.TableValueChanged) return true;

                return false;
            }

            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial, OldEntity, CurrentEntity, TableValueChanged());
        }
        protected override bool BagliTabloHataliGirisKontrol()
        {
            if (HataliGiris()) return true;

            if (depolarArasiTransferBilgileriTable != null && depolarArasiTransferBilgileriTable.HatalıGiriş())
            {
                KayitSonrasiFormuKapat = false;
                depolarArasiTransferBilgileriTable.Focus();
                return true;
            }
            return false;
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtTransferDepo)
                    sec.Sec(txtTransferDepo, txtTransferDepoAdi);
                if (sender == txtTransferEdilenDepo)
                    sec.Sec(txtTransferEdilenDepo, txtTransferEdilenDepoAdi);
            }
        }
        private bool HataliGiris()
        {
            if (txtTransferDepo.Id == null)
            {
                Messages.HataMesaji("Lütfen Transfer Depo Alanına Geçerli Bir Değer Giriniz .");
                txtTransferDepo.Focus();
                return true;
            }
            if (txtTransferEdilenDepo.Id == null)
            {
                Messages.HataMesaji("Lütfen Transfer Edilen Depo Alanına Geçerli Bir Değer Giriniz .");
                txtTransferEdilenDepo.Focus();
                return true;
            }
            return false;
        }
        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            if (sender is MyComboBoxEdit)
                depolarArasiTransferBilgileriTable.SutunGizleGoster();
        }
    }
}
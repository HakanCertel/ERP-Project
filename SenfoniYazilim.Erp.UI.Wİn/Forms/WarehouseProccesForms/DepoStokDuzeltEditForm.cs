using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using DevExpress.XtraLayout.Utils;
using SenfoniYazilim.Erp.Model.Entities;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms
{
    public partial class DepoStokDuzeltEditForm : BaseEditForm
    {
        protected internal  bool _multipleUpdate;
        protected internal  WareHouseStockL _depoStokL;

        public DepoStokDuzeltEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new WarehouseStockUpdateBll();
            BaseKartTuru = KartTuru.DepoStokDuzelt;
            EventsLoad();
            KayitSonrasiFormuKapat = false;

            HideItems = new BarItem[] { btnYeni, btnGerial, btnYazdir };

            _multipleUpdate = (bool)prm[0];
            _depoStokL = (WareHouseStockL)prm[1] ?? null;

        }
        public override void Yukle()
        {
            NesneyiKontrollereBagla();
            BagliTabloYukle();
            ControlEnableState(_multipleUpdate);
            OldEntity = new WareHouse();
            CurrentEntity = new WareHouse();
            if (!_multipleUpdate) return;
            
            layoutControlTablo.Visibility = LayoutVisibility.Always;
        }
        protected override void NesneyiKontrollereBagla()
        {
            WareHouseS depo;
            using (var bll = new WareHouseBll())
            {
                depo = bll.Single(x => x.Id == Id).EntityCovert<WareHouseS>();
            }
            txtDepo.Text =depo.Kod ;
            txtDepoAdi.Text = depo.WarehouseName;

            if (_multipleUpdate) return;

            txtStokKodu.Id = _depoStokL.MaterialId;
            txtStokKodu.Text = _depoStokL.MaterialCode;
            txtStokAdi.Text = _depoStokL.MaterialName;
            txtMevcutMiktar.EditValue = _depoStokL.Quantity;
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtDepo)
                {
                    sec.Sec(txtDepo,txtDepoAdi);
                    depoStokDuzeltTable.OwnerForm = this;
                    depoStokDuzeltTable.OwnerForm.Id = (long)txtDepo.Id;
                    depoStokDuzeltTable.Yukle();
                }

            }
        }
        protected override void BagliTabloYukle()
        {
            if (depoStokDuzeltTable.OwnerForm == null)
            {
                depoStokDuzeltTable.OwnerForm = this;
                depoStokDuzeltTable.Yukle();
            }
        }
        private  void ControlEnableState(bool multiple)
        {
            txtDepo.ControlEnabledChanged(false);
            txtDepoAdi.ControlEnabledChanged(false);
            txtStokKodu.ControlEnabledChanged(!multiple);
            txtStokAdi.ControlEnabledChanged(!multiple);
            txtMevcutMiktar.ControlEnabledChanged(!multiple);
            txtYeniMiktar.ControlEnabledChanged(!multiple);
        }
    }
}
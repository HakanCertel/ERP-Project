using System.Data;
using System.Linq;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities;
using System.Windows.Forms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Common.Message;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms
{
    public partial class DepoStokEditForm : BaseEditForm
    {
        private readonly IBaseEntity _depo;

        public DepoStokEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new WarehouseStockBll();
            EventsLoad();
            KayitSonrasiFormuKapat = false;

            btnStokDuzelt.CreatDropDownMenu(new BarItem[] { btnCokluStokDuzelt });

            HideItems = new BarItem[] {btnYeni,btnGerial };
            ShowItems = new BarItem[] { btnYazdir,btnStokDuzelt };

            _depo = (WareHouse)prm[0];

        }
        public  override void Yukle()
        {
            BagliTabloYukle();            
            txtDepoAdi.Text = ((WareHouse)_depo).WarehouseName;
            txtDepoAdi.Id = ((WareHouse)_depo).Id;
            Id= ((WareHouse)_depo).Id;
            txtDepoAdi.Focus();
        }

        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (depoStokTable.TableValueChanged) return true;

                return false;
            }
            CurrentEntity = new WareHouse();
            OldEntity = new WareHouse();
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial, OldEntity, CurrentEntity, TableValueChanged());
        }

        protected override bool EntityInsert()
        {
            var result = depoStokTable.Kaydet();

            if (result && !KayitSonrasiFormuKapat)
                BagliTabloYukle();

            return result;
        }
        protected override bool EntityUpdate()
        {
            var result = depoStokTable.Kaydet();

            if (result && !KayitSonrasiFormuKapat)
                BagliTabloYukle();

            return result;
        }
        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Delete || x.Update || x.Insert);
            }

            if (depoStokTable.OwnerForm == null)
            {
                depoStokTable.OwnerForm = this;
                depoStokTable.Yukle();
            }
            if (TableValueChanged(depoStokTable))
            {
                var rowHandle = depoStokTable.Tablo.FocusedRowHandle;
                depoStokTable.Yukle();
                depoStokTable.Tablo.FocusedRowHandle = rowHandle;
            }
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec=new SelectFunctions())
            {
                if (sender == txtDepoAdi)
                {
                    sec.Sec(txtDepoAdi);
                    depoStokTable.OwnerForm.Id =(long)txtDepoAdi.Id;
                    depoStokTable.Yukle();
                }
                    
            }
        }
        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.Button_ItemClick(sender, e);

            Cursor.Current = Cursors.WaitCursor;
            var entity = depoStokTable.Tablo.GetRow<WareHouseStockL>();

            if (e.Item == btnStokDuzelt)
            {
                if (entity == null)
                {
                    Messages.BilgiMesaji("Lütfen Bir Stok Seçiniz .");
                    depoStokTable.Tablo.Focus();
                    return;
                }
                   
                ShowEditForms<DepoStokDuzeltEditForm>.ShowDialogForm(txtDepoAdi.Id, false,entity);
            }
            else if (e.Item == btnCokluStokDuzelt)
            {
                ShowEditForms<DepoStokDuzeltEditForm>.ShowDialogForm(txtDepoAdi.Id, true,null);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
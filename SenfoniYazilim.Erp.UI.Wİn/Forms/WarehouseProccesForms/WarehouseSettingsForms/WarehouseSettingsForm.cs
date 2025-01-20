using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Bll.General.WarehouseBll;
using System.Linq;
using SenfoniYazilim.Erp.Model.Entities.Base;
using DevExpress.XtraEditors;
using System;
using SenfoniYazilim.Erp.Model.Dto.WareHousesDto;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.WarehouseSettingsForms
{
    public partial class WarehouseSettingsForm : BaseEditForm
    {
        //private readonly long _depoId;
        public WarehouseSettingsForm()
        {
            InitializeComponent();

            //_depoId = (long)prm[0];

            DataLayoutControl = myDataLayoutControl;
            Bll = new WarehouseSettingsBll();
            BaseKartTuru = KartTuru.Depo;
            EventsLoad();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnSil, btnYeni, btnGerial };
        }

        public  override void Yukle()
        {
            var depo=Erp.Bll.Functions.GetAnySingleOrListBll.ListWarehouses().FirstOrDefault();
            Id = depo.Id;
            txtWarehouseCode.Id = Id;
            txtWarehouseCode.Text = depo.Kod;
            txtWarehouseName.Text = depo.WarehouseName;
            TabloYukle();
            OldEntity = new BaseEntity();
            OldEntity.Id = Id;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new BaseEntity
            {
                Id =Convert.ToInt64( txtWarehouseCode.Id),
            };

            ButonEnabledDurumu();
        }
        protected override void TabloYukle()
        {
            if (warehouseSettingsTable.OwnerForm == null)
            {
                warehouseSettingsTable.OwnerForm = this;
                warehouseSettingsTable.Yukle();
            }
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {

                if (warehouseSettingsTable.TableValueChanged) return true;

                return false;
            }

            Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial, OldEntity, CurrentEntity, TableValueChanged());
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtWarehouseCode)
                {
                    sec.Sec(txtWarehouseCode, txtWarehouseName);
                    Id =(long)txtWarehouseCode.Id;
                    warehouseSettingsTable.Yukle();
                }
        }

        protected override bool EntityInsert()
        {
            //AnaFormda Bu form Çağırılırken Id =-1 olduğu için form açıldığında herzaman IslemTuru
            //EntityInsert olacağı için Update e ihtiyaç yoktur...
            //return base.EntityInsert();
            return warehouseSettingsTable.Kaydet();
        }
    }
}
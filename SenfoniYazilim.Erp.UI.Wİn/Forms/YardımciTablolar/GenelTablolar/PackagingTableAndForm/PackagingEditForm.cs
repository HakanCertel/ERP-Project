using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.PackagingTableAndForm
{
    public partial class PackagingEditForm : BaseEditForm
    {

        public PackagingEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            HideItems = new DevExpress.XtraBars.BarItem[] { btnYeni, btnGerial,btnSil };
            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = new BaseEntity();
            CurrentEntity = new BaseEntity();
            
            TabloYukle();
        }
        protected override void GuncelNesneOlustur()
        {
            ButonEnabledDurumu();
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, packagingEditFormTable.TableValueChanged);
        }
        protected override bool EntityInsert()
        {
            //if (!packagingEditFormTable.HatalıGiriş()) return false;
            return packagingEditFormTable.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            //if (!packagingEditFormTable.HatalıGiriş()) return false;
            return packagingEditFormTable.Kaydet();
        }
        protected override void TabloYukle()
        {

            packagingEditFormTable.OwnerForm = this;
            packagingEditFormTable.Yukle();

        }
       
    }
}
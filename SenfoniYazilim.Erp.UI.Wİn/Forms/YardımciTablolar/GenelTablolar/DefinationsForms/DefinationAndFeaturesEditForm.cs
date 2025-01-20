using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.DefinationsForms
{
    public partial class DefinationAndFeaturesEditForm : BaseEditForm
    {
        protected internal KartTuru _kartTuru;
        protected internal Material _material;

        public DefinationAndFeaturesEditForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new DefinationsBll();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnSil, btnGerial, btnYeni, btnYazdir };
            EventsLoad();

            KayitSonrasiFormuKapat = false;

            _kartTuru = (KartTuru)prm[0];

            if (prm[1] != null)
                _material = (Material)prm[1];
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
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, definationAndFeatureEditTable.TableValueChanged);
        }
        protected override bool EntityInsert()
        {
            if (definationAndFeatureEditTable.HatalıGiriş()) return false;
            return definationAndFeatureEditTable.Kaydet();
            
        }
        protected override bool EntityUpdate()
        {
            if (definationAndFeatureEditTable.HatalıGiriş()) return false;
            return definationAndFeatureEditTable.Kaydet();
        }
        protected override void TabloYukle()
        {
            definationAndFeatureEditTable.OwnerForm = this;
            definationAndFeatureEditTable.Yukle();
        }
       
    }
}
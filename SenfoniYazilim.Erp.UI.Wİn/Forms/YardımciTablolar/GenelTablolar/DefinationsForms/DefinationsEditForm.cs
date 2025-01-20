using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.DefinationsForms
{
    public partial class DefinationsEditForm : BaseEditForm
    {
        protected internal KartTuru _kartTuru;

        public DefinationsEditForm(params object[] prm)
        {
            InitializeComponent();

            //DataLayoutControl = myDataLayoutControl;
            Bll = new DefinationsBll();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnSil, btnGerial, btnYeni, btnYazdir };
            EventsLoad();
            KayitSonrasiFormuKapat = false;
            _kartTuru = (KartTuru)prm[0];
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
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, definationsTable.TableValueChanged);
        }
        protected override bool EntityInsert()
        {
            if (definationsTable.HatalıGiriş()) return false;
            return definationsTable.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            if (definationsTable.HatalıGiriş()) return false;
            return definationsTable.Kaydet();
        }
        protected override void TabloYukle()
        {
            definationsTable.OwnerForm = this;
            definationsTable.Yukle();
        }
    }
}
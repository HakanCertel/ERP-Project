using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Common.Enums;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.EvrakTurleriForms
{
    public partial class EvrakTurleriEditForm : BaseEditForm
    {
        public EvrakTurleriEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            HideItems = new BarItem[] { btnSil, btnYeni, btnGerial };
            
            BaseKartTuru = KartTuru.Evrak;
            EventsLoad();
            TabloYukle();
        }
        public override void Yukle()
        {
            evrakTurleriEditTablo.Yukle();
        }
        protected override void TabloYukle()
        {
            evrakTurleriEditTablo.OwnerForm = this;
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (evrakTurleriEditTablo.TableValueChanged) return true;

                return false;
            }
            CurrentEntity = new BaseEntity();
            OldEntity = new BaseEntity();
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial, OldEntity, CurrentEntity, TableValueChanged());
        }
        protected override bool EntityInsert()
        {
            if (evrakTurleriEditTablo.HatalıGiriş()) return false;
            return evrakTurleriEditTablo.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            if (evrakTurleriEditTablo.HatalıGiriş()) return false;
            return evrakTurleriEditTablo.Kaydet();
        }
        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
            RefreshYapilacak = true;
        }
    }
}
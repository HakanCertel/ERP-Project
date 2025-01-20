using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.Base;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System.Linq;
using System;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.FeaturesForms
{
    public partial class FeaturesEditForm : BaseEditForm
    {
        protected internal KartTuru _kartTuru;
        protected internal IEnumerable<Definations> _source;

        public FeaturesEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new FeaturesBll();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnSil, btnGerial, btnYeni, btnYazdir };
            EventsLoad();
            KayitSonrasiFormuKapat = false;
            _kartTuru = (KartTuru)prm[0];
        }

        public override void Yukle()
        {
            OldEntity = new BaseEntity();
            CurrentEntity = new BaseEntity();

            _source=Erp.Bll.Functions.GetAnySingleOrListBll.ListDefinations().ToList();

            txtDefination.Properties.DataSource = _source;
            txtDefination.Properties.ValueMember = "Id";
            txtDefination.Properties.DisplayMember = "Description";
            TabloYukle();
        }
        protected override void GuncelNesneOlustur()
        {
            ButonEnabledDurumu();
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, featuresTable.TableValueChanged);
        }
        protected override bool EntityInsert()
        {
            if (featuresTable.HatalıGiriş()) return false;
            return featuresTable.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            if (featuresTable.HatalıGiriş()) return false;
            return featuresTable.Kaydet();
        }
        protected override void TabloYukle()
        {
            featuresTable.OwnerForm = this;
            featuresTable.Yukle();
        }
        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            base.Control_EditValueChanged(sender, e);
            if(sender is MyLookUpEdit)
            {
                featuresTable.Listele();
            }
        }

    }
}
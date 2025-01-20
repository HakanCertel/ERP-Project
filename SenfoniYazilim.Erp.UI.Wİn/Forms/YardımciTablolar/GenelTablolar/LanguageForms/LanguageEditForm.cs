using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.LanguageForms
{
    public partial class LanguageEditForm : BaseEditForm
    {
        public LanguageEditForm()
        {
            InitializeComponent();
            Bll = new LanguageBll();
            DataLayoutControl = myDataLayoutControl;
            HideItems = new DevExpress.XtraBars.BarItem[] {btnSil,btnGerial,btnYeni,btnYazdir };
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
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, languageEditFormTable.TableValueChanged);
        }
        protected override bool EntityInsert()
        {
            if (!languageEditFormTable.HatalıGiriş()) return false;
            return languageEditFormTable.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            if (!languageEditFormTable.HatalıGiriş()) return false;
            return languageEditFormTable.Kaydet();
        }
        protected override void TabloYukle()
        {
            languageEditFormTable.OwnerForm = this;
            languageEditFormTable.Yukle();
        }
    }
}
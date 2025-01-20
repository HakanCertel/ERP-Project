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
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    public partial class TatilParametreEditForm : BaseEditForm
    {
        public TatilParametreEditForm()
        {
            InitializeComponent();

            Bll = new TatilBilgileriBll();
            DataLayoutControl = myDataLayoutControl;
            HideItems = new BarItem[] { btnSil, btnYeni, btnGerial };
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
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, tatilBilgileriTable.TableValueChanged);
        }
        protected override bool EntityInsert()
        {
            return tatilBilgileriTable.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            return tatilBilgileriTable.Kaydet();
        }
        protected override void TabloYukle()
        {
            tatilBilgileriTable.OwnerForm = this;
            tatilBilgileriTable.Yukle();
        }
    }
}
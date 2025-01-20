using System;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.KullaniciForms
{
    public partial class KullaniciBirimYetkileriEditForm : BaseEditForm
    {
        public KullaniciBirimYetkileriEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            EventsLoad();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnYeni, btnSil, btnGerial, btnKaydet };
            TabloYukle();
        }
        public override void Yukle()
        {
            subeTable.Yukle();
            donemTable.Yukle();
        }
        protected internal override void ButonEnabledDurumu(){}

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            kullaniciTable.Tablo.Focus();
        }

        protected override void TabloYukle()
        {
            kullaniciTable.OwnerForm = this;
            subeTable.OwnerForm = this;
            donemTable.OwnerForm = this;
            kullaniciTable.Yukle();
        }
    }
}
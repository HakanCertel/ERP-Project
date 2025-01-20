using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using DevExpress.XtraEditors;
using System;
using System.Configuration;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    public partial class BaglantiAyarlariEditForm : BaseEditForm
    {
        public BaglantiAyarlariEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            HideItems = new DevExpress.XtraBars.BarItem[] { btnSil, btnYeni };
            EventsLoad();

            txtYetkilendirmeTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YetkilendirmeTuru>());
        }
        public override void Yukle()
        {
            OldEntity = new BaglantiAyarlari
            {
                Server = ConfigurationManager.AppSettings["Server"],
                YetkilendirmeTuru = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>(),
                KullaniciAdi = ConfigurationManager.AppSettings["KullaniciAdi"],
                Sifre = ConfigurationManager.AppSettings["Sifre"]?.GetEnum<YetkilendirmeTuru>()==YetkilendirmeTuru.SqlServer?"Burası Şifre Alanıdır":""
            };

            NesneyiKontrollereBagla();
        }
        protected override void NesneyiKontrollereBagla()
        {
            txtServer.Text = ConfigurationManager.AppSettings["Server"];
            txtYetkilendirmeTuru.Text = ConfigurationManager.AppSettings["YetkilendirmeTuru"];
            txtKullaniciAdi.Text = ConfigurationManager.AppSettings["KullaniciAdi"];
            txtSifre.Text = ConfigurationManager.AppSettings["Sifre"]?.GetEnum<YetkilendirmeTuru>() == YetkilendirmeTuru.SqlServer ? "Burası Şifre Alanıdır" : "";
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new BaglantiAyarlari
            {
                Server = txtServer.Text,
                YetkilendirmeTuru = txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>(),
                KullaniciAdi=txtKullaniciAdi.Text,
                Sifre=txtSifre.Text
            };

            ButonEnabledDurumu();
        }
        protected override bool EntityUpdate()
        {
            var list = Erp.Bll.Functions.GeneralFunctions.DegisenAlanlarıGetir(OldEntity, CurrentEntity).ToList();

            list.ForEach(x =>
            {
                switch (x)
                {
                    case "Server":
                        Functions.GeneralFunctions.AppSettingsWrite(x, txtServer.Text);
                        break;
                    case "YetkilendirmeTuru":
                        Functions.GeneralFunctions.AppSettingsWrite(x, txtYetkilendirmeTuru.Text);
                        break;
                    case "KullaniciAdi":
                        Functions.GeneralFunctions.AppSettingsWrite(x, txtKullaniciAdi.Text);
                        break;
                    case "Sifre":
                        Functions.GeneralFunctions.AppSettingsWrite(x, txtSifre.Text);
                        break;
                }
            });

            return true;
        }
        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edit)) return;
            var yetkilendirmeTuru = txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>();

            txtKullaniciAdi.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtSifre.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtKullaniciAdi.Focus();

            if (yetkilendirmeTuru != YetkilendirmeTuru.Windows) return;

            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }
    }
}
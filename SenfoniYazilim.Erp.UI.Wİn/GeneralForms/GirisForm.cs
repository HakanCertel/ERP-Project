using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.KullaniciForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    public partial class GirisForm : XtraForm
    {
        private Point _mouseLocation;
        private List<Kurum> _source;

        public GirisForm()
        {
            InitializeComponent();
            EventsLoad();
        }
        private void EventsLoad()
        {
            //Control Event
            foreach (Control control in Controls)
            {
                if (!(control is MyDataLayoutControl)) continue;
                control.MouseDown += Control_MouseDown;
                control.MouseMove += Control_MouseMove;

                foreach (Control ctrl in control.Controls)
                {
                    ctrl.KeyDown += Control_KeyDown;

                    switch (ctrl)
                    {
                        case MySimpleButton btn:
                            btn.Click += Control_Click;
                            break;
                        case MyHyperlinkLabelControl hyp:
                            hyp.Click += Control_Click;
                            break;
                    }
                }
            }
            //Form Events
            Shown += GirisForm_Shown;
            Load += GirisForm_Load;
        }
        private void Yukle()
        {
            txtVersion.Text = $"Versiyon : {Assembly.GetExecutingAssembly().GetName().Version}";

            var server = ConfigurationManager.AppSettings["Server"];
            var yetkilendirmeTuru = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>();
            var kullaniciAdi = ConfigurationManager.AppSettings["KullaniciAdi"].ConvertToSecureString(); 
            var sifre = ConfigurationManager.AppSettings["Sifre"].ConvertToSecureString();

            if (!Functions.GeneralFunctions.BaglantiKontrol(server, kullaniciAdi,sifre,yetkilendirmeTuru))
            {
                txtKurum.Properties.DataSource = null;

                if (ShowEditForms<BaglantiAyarlariEditForm>.ShowDialogForm(IslemTuru.EntityUpdate))
                    Yukle();
                return;
            }

            Functions.GeneralFunctions.CreateConnectionString("Senfoni_Erp_Yonetim", server,kullaniciAdi,sifre,yetkilendirmeTuru);
            using (var bll=new KurumBll())
            {
                _source = bll.List(null).Cast<Kurum>().ToList();

                txtKurum.Properties.DataSource = _source;
                txtKurum.Properties.ValueMember = "Kod";
                txtKurum.Properties.DisplayMember = "KurumAdi";
                txtKurum.ItemIndex = 0;
            }
        }
        private void CreatConnection()
        {
            if (txtKurum.Text == "")
            {
                Messages.HataMesaji("Kurum Seçimi Yapmalısınız .");
                return;
            }

            var kurum = _source[txtKurum.ItemIndex];
            var kod = kurum.Kod;
            var server = kurum.Server;
            var yetkilendirmeTuru = kurum.YetkilendirmeTuru;
            var kullaniciAdi = kurum.KullaniciAdi;
            var sifre = kurum.Sifre;

            if (!Functions.GeneralFunctions.BaglantiKontrol(server, kullaniciAdi.ConvertToSecureString(), sifre.ConvertToSecureString(), yetkilendirmeTuru)) return;

            Functions.GeneralFunctions.CreateConnectionString(kod, server, kullaniciAdi.ConvertToSecureString(), sifre.ConvertToSecureString(), yetkilendirmeTuru);
        }

        private void Giris()
        {
            CreatConnection();

            using (var kullaniciBll=new KullaniciBll())
            {
                var kullanici = (KullaniciS)kullaniciBll.SingleDetail(x => x.Kod == txtKullaniciAdi.Text);

                if (kullanici == null || txtSifre.Text != kullanici.Sifre)
                {
                    Messages.HataMesaji("Kullanıcı Adı Veya Şifre Hatalıdır. Lütfen Kontrol Edip ,Tekrar Deneyiniz .");
                    return;
                }
                using (var parametreBll=new KullaniciParametreBll())
                {
                    var entity = (KullaniciParametreS)parametreBll.Single(x => x.KullaniciId == kullanici.Id);
                    AnaForm.KullaniciParametreleri = entity ?? new KullaniciParametreS();

                    AnaForm.KurumAdi = txtKurum.Text;
                    AnaForm.KullaniciId = kullanici.Id;
                    AnaForm.KullaniciAdi = kullanici.Adi;
                    AnaForm.KullaniciRolId = kullanici.RolId;
                    AnaForm.KullaniciRolAdi = kullanici.RolAdi;
                    AnaForm.KullaniciYetkisi = kullanici.KullaniciYetkisi;

                    Hide();

                    ShowRibbonForms<AnaForm>.ShowForm(false);
                }
            }
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            var position = MousePosition;
            position.Offset(_mouseLocation.X, _mouseLocation.Y);
            Location = position;
        }
        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void Control_Click(object sender, EventArgs e)
        {
            switch (sender)
            {
                case MySimpleButton button:
                    if (button == btnGiris)
                        Giris();
                    else if (button == btnVazgec)
                        Close();
                    break;
                case MyHyperlinkLabelControl hyp:
                    if (hyp == btnBaglantiAyarlari)
                    {
                        if (ShowEditForms<BaglantiAyarlariEditForm>.ShowDialogForm(IslemTuru.EntityUpdate))
                            Yukle();
                    }
                    else if (hyp == btnSifremiUnuttum)
                    {
                        CreatConnection();
                        ShowEditForms<SifremiUnuttumEditForm>.ShowDialogForm(IslemTuru.EntityUpdate, txtKullaniciAdi.Text);
                    }
                    break;
            }
        }
        private void GirisForm_Shown(object sender, EventArgs e)
        {
            txtKullaniciAdi.Focus();
        }
        private void GirisForm_Load(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Baslatiliyor));
            Yukle();
            SplashScreenManager.CloseForm();
        }

    }
}
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraEditors;
using System.Security;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.KullaniciForms
{
    public partial class KullaniciEditForm : BaseEditForm
    {
        private string _sifre;
        private string _gizliKelime;
        private SecureString _secureSifre;
        private SecureString _secureGizliKelime;
        private bool _tekrarGonder;

        public KullaniciEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Kullanici;
            ShowItems = new DevExpress.XtraBars.BarItem[] { btnSifreSifirla };
            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new KullaniciS() : ((KullaniciBll)Bll).Single(FilterFunctions.Filter<Kullanici>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKullaniciAdi.Text = "Yeni Kullanıcı";
            btnSifreSifirla.Enabled = false;
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KullaniciS)OldEntity;

            txtKullaniciAdi.Text = entity.Kod;
            txtAdi.Text = entity.Adi;
            txtSoyadi.Text = entity.Soyadi;
            txtEmail.Text = entity.Email;
            txtRol.Id = entity.RolId;
            txtRol.Text = entity.RolAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Kullanici
            {
                Id = Id,
                Kod = txtKullaniciAdi.Text,
                Adi = txtAdi.Text,
                Soyadi=txtSoyadi.Text,
                Email=txtEmail.Text,
                Sifre="123",//_sifre,
                GizliKelime="GizliKelime",//_gizliKelime,
                RolId=(long)txtRol.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            SifreUret();
            var result = base.EntityInsert();
            if (result)
                txtKullaniciAdi.Text.SifreMailiGonder(txtRol.Text, txtEmail.Text, _secureSifre,_secureGizliKelime);
            return result;
        }
        protected override bool EntityUpdate()
        {
            var result = base.EntityUpdate();
            if (_tekrarGonder)
                txtKullaniciAdi.Text.SifreMailiGonder(txtRol.Text, txtEmail.Text, _secureSifre, _secureGizliKelime);
            return result;
        }
        protected override void SifreSifirla()
        {
            if (Messages.EmailGonderimOnayi() != System.Windows.Forms.DialogResult.Yes) return;
            _tekrarGonder = true;
            SifreUret();
            btnKaydet.PerformClick();
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtRol)
                    sec.Sec(txtRol);
            }
        }
        private void SifreUret()
        {
            var result = GeneralFunctions.SifreUret();

            _sifre = result.sifre;
            _gizliKelime = result.gizliKelime;
            _secureSifre = result.secureSifre;
            _secureGizliKelime = result.secureGizliKelime;
            GuncelNesneOlustur();
        }
    }
}
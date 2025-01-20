using System.Windows.Forms;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using DevExpress.XtraBars;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.KullaniciForms
{
    public partial class SifreDegistirEditForm : BaseEditForm
    {
        public SifreDegistirEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciBll(myDataLayoutControl);
            HideItems = new BarItem[] { btnYeni, btnSil, btnGerial };
            EventsLoad();
        }

        private void SifreDegistir()
        {
            if (Messages.KayitMesaj() != System.Windows.Forms.DialogResult.Yes) return;

            var entity = ((KullaniciBll)Bll).SingleDetail(x => x.Id == AnaForm.KullaniciId).EntityCovert<Kullanici>();
            if (entity == null) return;

            if (HataliGiris()) return;

            if (entity.Sifre == txtEskiSifre.Text)
            {
                var currentEntity = new Kullanici
                {
                    Id=entity.Id,
                    Kod=entity.Kod,
                    Adi=entity.Adi,
                    Soyadi=entity.Soyadi,
                    RolId=entity.RolId,
                    Sifre=txtYeniSifre.Text,
                    Email=entity.Email, 
                    GizliKelime=string.IsNullOrEmpty(txtGizliKelime.Text)?entity.GizliKelime:txtGizliKelime.Text,
                    Aciklama=entity.Aciklama,
                    Durum=entity.Durum
                };

                if (!((KullaniciBll)Bll).Update(entity, currentEntity)) return;
                Messages.BilgiMesaji("Şifre Değiştirme İşlemi Gerçekleşmiştir .");
                Close();
            }
            else
            {
                Messages.HataMesaji("Girilen Eski Şifre Bilgisi Hatalıdır. Lütfen Kontrol Edip Tekrar Deneyiniz .");
                txtEskiSifre.Focus();
            }
        }
        private bool HataliGiris()
        {
            if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
            {
                Messages.HataMesaji("Yeni Şifre, Yeni Şifre Tekrarıyla Uyuşmuyor.");
                txtYeniSifre.Focus();
                return true;
            }
            if (txtYeniSifre.Text.Length < 8)
            {
                Messages.HataMesaji("Girilen Yeni Şifre En Az 8 Karakter Olmalıdır");
                txtYeniSifre.Focus();
                return true;
            }
            if (!string.IsNullOrEmpty(txtGizliKelime.Text) && txtGizliKelime.Text.Length < 10)
            {
                Messages.HataMesaji("Girilen Gizli Kelimenin Uzunluğu En Az 10 Karakter Olmalıdır");
                txtGizliKelime.Focus();
                return true;
            }
            return false;
        }
        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnKaydet)
                SifreDegistir();
            else if (e.Item == btnCikis)
                Close();
        }
        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }
    }
}
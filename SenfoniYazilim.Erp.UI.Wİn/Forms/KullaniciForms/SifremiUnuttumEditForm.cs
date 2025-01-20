using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraBars;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.KullaniciForms
{
    public partial class SifremiUnuttumEditForm : BaseEditForm
    {
        private readonly string _kullaniciAdi;
        public SifremiUnuttumEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciBll(myDataLayoutControl);
            HideItems = new BarItem[] { btnYeni, btnSil,btnKaydet,btnGerial };
            ShowItems = new BarItem[] { btnSifreSifirla };
            EventsLoad();

            _kullaniciAdi = prm[0].ToString();
        }
        public override void Yukle()
        {
            txtKullaniciAdi.Text = _kullaniciAdi;
        }
        protected override void SifreSifirla()
        {
            if (Messages.EmailGonderimOnayi() != System.Windows.Forms.DialogResult.Yes) return;

            var entity = ((KullaniciBll)Bll).SingleDetail(x => x.Kod == txtKullaniciAdi.Text).EntityCovert<KullaniciS>();
            if (entity == null)
            {
                Messages.HataMesaji("Veritabanında Kayıtlı Böyle Bir Kullanıcı Bulunmamaktdır .");
                return;
            }

            if (txtAdi.Text == entity.Adi && txtSoyadi.Text == entity.Soyadi && txtEmail.Text == entity.Email && txtGizliKelime.Text == entity.GizliKelime)
            {
                var result = Functions.GeneralFunctions.SifreUret();

                var currentEntity = new Kullanici
                {
                    Id = entity.Id,
                    Kod = entity.Kod,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    Email = entity.Email,
                    RolId = entity.RolId,
                    Durum = entity.Durum,
                    Sifre = entity.Sifre,
                    GizliKelime = entity.GizliKelime
                };

                if (!((KullaniciBll)Bll).Update(entity, currentEntity)) return;

                var sonuc = txtKullaniciAdi.Text.SifreMailiGonder(entity.RolAdi, entity.Email, result.secureSifre, result.secureGizliKelime);

                if (sonuc)
                {
                    Messages.BilgiMesaji("Şifre Sıfırlama İşlemi Başarılı Birşekilde Gerçekleşmiştir .");
                    return;
                }
                else
                    Messages.HataMesaji("Şifre Sıfırlama İşlemi Başarılı Bir Şekilde Gerçekleşti Ancak E-Mail Gönderilemedi. Lütfen Tekrar Deneyiniz.");
            }
            else
                Messages.HataMesaji("Girilen Bilgiler Mevcut Bilgilerle Uyuşmuyor. Lütfen Kontrol Edip Tekrar Deneyiniz .");
        }
    }
}
using System;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using System.Security;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Bll.Functions;

namespace SenfoniYazilim.Erp.UI.Yonetim.Forms.GenelForms
{
    public partial class KurumEditForm : BaseEditForm
    {
        private readonly string _server;
        private readonly SecureString _kullaniciAdi;
        private readonly SecureString _sifre;

        public KurumEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KurumBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Kurum;
            EventsLoad();

            txtYetkilendirmeTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YetkilendirmeTuru>());

            _server = prm[0].ToString();
            _kullaniciAdi = (SecureString)prm[1];
            _sifre = (SecureString)prm[2];
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Kurum() : ((KurumBll)Bll).Single(FilterFunctions.Filter<Kurum>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = "Yeni_Kurum";
            txtKod.Enabled = true;
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Kurum)OldEntity;

            txtKod.Text = entity.Kod;
            txtKurumAdi.Text = entity.KurumAdi;
            txtServer.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _server : entity.Server;
            txtYetkilendirmeTuru.SelectedItem = entity.YetkilendirmeTuru.toName();
            txtKullaniciAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _kullaniciAdi.ConvertToUnSecureString() : entity.KullaniciAdi.Decrypt(entity.Id + entity.Kod);
            txtSifre.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _sifre.ConvertToUnSecureString() : entity.Sifre.Decrypt(entity.Id + entity.Kod);

        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Kurum
            {
                Id = Id,
                Kod = txtKod.Text,
                KurumAdi = txtKurumAdi.Text,
                Server = txtServer.Text,
                YetkilendirmeTuru = txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>(),
            };

            ((Kurum)CurrentEntity).KullaniciAdi = txtKullaniciAdi.Text.Encrypt(CurrentEntity.Id + CurrentEntity.Kod);
            ((Kurum)CurrentEntity).Sifre = txtSifre.Text.Encrypt(CurrentEntity.Id + CurrentEntity.Kod);

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
           if (!SenfoniYazilim.Erp.UI.Wİn.Functions.GeneralFunctions.BaglantiKontrol(txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>())) return false;
            SenfoniYazilim.Erp.UI.Wİn.Functions.GeneralFunctions.CreateConnectionString(txtKod.Text, txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());

            if(!Functions.GeneralFunctions.CreateDatabase<SenfoniErpContext>("Lütfen Bekleyiniz", "Kurum Veri Tabanı Olşturuluyor", "Kurum VeriTabanı Oluşturulacaktır. Onaylıyor Musunuz ?", "Kurum Veritabanı Başarılı Bir Şekilde Oluşturuldu ."))return false;

            //!!!!!!!!!!!!!!!!!!!!initial catalog tanımını yap!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            SenfoniYazilim.Erp.UI.Wİn.Functions.GeneralFunctions.CreateConnectionString("Senfoni_Erp_Yonetim", txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());
            return base.EntityInsert();
        }
        protected override bool EntityUpdate()
        {
            if (!SenfoniYazilim.Erp.UI.Wİn.Functions.GeneralFunctions.BaglantiKontrol(txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>())) return false;

            //!!!!!!!!!!!!!!!!!!!!initial catalog tanımını yap!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            SenfoniYazilim.Erp.UI.Wİn.Functions.GeneralFunctions.CreateConnectionString("Senfoni_Erp_Yonetim", txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());
            return base.EntityUpdate();
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
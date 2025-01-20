using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraBars;

namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    public partial class EMailParametreEditForm : BaseEditForm
    {
        public EMailParametreEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new MailParametreBll(myDataLayoutControl);
            HideItems = new BarItem[] { btnYeni, btnSil };
            txtSslKullan.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = ((MailParametreBll)Bll).Single(null) ?? new MailParametre();
            ((MailParametre)OldEntity).Sifre = "Bu Email Şifresidir";

            BaseIslemTuru = OldEntity.Id == 0 ? IslemTuru.EntityInsert : IslemTuru.EntityUpdate;
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            txtKod.Text = "E-Mail";
            txtEMail.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MailParametre)OldEntity;
            Id = entity.Id;
            txtKod.Text = entity.Kod;
            txtEMail.Text = entity.EMail;
            txtSifre.Text =BaseIslemTuru==IslemTuru.EntityInsert?null: entity.Sifre;
            txtPortNo.Value = entity.PortNo;
            txtHost.Text = entity.Host;
            txtSslKullan.SelectedItem = entity.SslKullan.toName();

        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new MailParametre
            {
                Id = Id,
                Kod = txtKod.Text,
                EMail = txtEMail.Text,
                Sifre=string.IsNullOrWhiteSpace(txtSifre.Text)?null:txtSifre.Text,
                PortNo=(int)txtPortNo.Value,
                Host=txtHost.Text,
                SslKullan=txtSslKullan.Text.GetEnum<EvetHayir>()
            };

            ButonEnabledDurumu();
        }
    }
}
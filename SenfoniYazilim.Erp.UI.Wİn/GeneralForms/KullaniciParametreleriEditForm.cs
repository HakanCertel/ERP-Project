using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Drawing;

namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    public partial class KullaniciParametreleriEditForm : BaseEditForm
    {

        private readonly long _kullaniciId;
        public KullaniciParametreleriEditForm(params object[] prm)
        {
            InitializeComponent();

            _kullaniciId = (long)prm[0];

            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciParametreBll();
            EventsLoad();

            HideItems = new BarItem[] { btnYeni, btnSil,btnYeni };
        }
        public  override void Yukle()
        {
            OldEntity = ((KullaniciParametreBll)Bll).Single(x=>x.KullaniciId==_kullaniciId)??new KullaniciParametreS();
            BaseIslemTuru = OldEntity.Id == 0 ? IslemTuru.EntityInsert : IslemTuru.EntityUpdate;
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KullaniciParametreS)OldEntity;

            Id = entity.Id;
            txtDefaultAvukatHesap.Id = entity.DefaultAvukatHesapId;
            txtDefaultAvukatHesap.Text = entity.DefaultAvukatHesapAdi;
            txtDefaultBankaHesap.Id = entity.DefaultBankaHesapId;
            txtDefaultBankaHesap.Text = entity.DefaultBankaHesapAdi;
            txtDefaultKasaHesap.Id = entity.DefaultKasaHesapId;
            txtDefaultKasaHesap.Text = entity.DefaultKasaHesapAdi;
            txtRaporlariOnayAlmadanKapat.Checked = entity.RaporlariOnayAlmadanKapat;
            txtTableViewCaptionForeColor.Color = Color.FromArgb(entity.TabloViewCaptionForeColor);
            txtTableColumnHeaderForeColor.Color = Color.FromArgb(entity.TabloColumnHeaderForeColor);
            txtTableBandCaptionForeColor.Color = Color.FromArgb(entity.TabloBandCaptionForeColor);
            imgArkaPlanResim.EditValue = entity.ArkaPlanResim;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new KullaniciParametre
            {
                Id = Id,
                Kod = "Param-001",
                KullaniciId = AnaForm.KullaniciId,
                DefaultAvukatHesapId = txtDefaultAvukatHesap.Id,
                DefaultBankaHesapId = txtDefaultBankaHesap.Id,
                DefaultKasaHesapId = txtDefaultKasaHesap.Id,
                RaporlariOnayAlmadanKapat = txtRaporlariOnayAlmadanKapat.Checked,
                TabloViewCaptionForeColor = txtTableViewCaptionForeColor.Color.ToArgb(),
                TabloColumnHeaderForeColor=txtTableColumnHeaderForeColor.Color.ToArgb(),
                TabloBandCaptionForeColor=txtTableBandCaptionForeColor.Color.ToArgb(),
                ArkaPlanResim=(byte[])imgArkaPlanResim.EditValue
            };

            ButonEnabledDurumu();
        }

        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new KullaniciParametreS
            {
                DefaultAvukatHesapId = txtDefaultAvukatHesap.Id,
                DefaultAvukatHesapAdi=txtDefaultAvukatHesap.Text,
                DefaultBankaHesapId = txtDefaultBankaHesap.Id,
                DefaultBankaHesapAdi=txtDefaultBankaHesap.Text,
                DefaultKasaHesapId = txtDefaultKasaHesap.Id,
                DefaultKasaHesapAdi=txtDefaultKasaHesap.Text,
                RaporlariOnayAlmadanKapat = txtRaporlariOnayAlmadanKapat.Checked,
                TabloViewCaptionForeColor = txtTableViewCaptionForeColor.Color.ToArgb(),
                TabloColumnHeaderForeColor = txtTableColumnHeaderForeColor.Color.ToArgb(),
                TabloBandCaptionForeColor = txtTableBandCaptionForeColor.Color.ToArgb(),
                ArkaPlanResim = (byte[])imgArkaPlanResim.EditValue
            };

            return entity;
        }

        protected override bool EntityInsert()
        {
            var result= base.EntityInsert();

            if (!result) return false;

            ReturnEntity();
            return true;
        }
        protected override bool EntityUpdate()
        {
            var result= base.EntityUpdate();

            if (!result) return false;

            ReturnEntity();
            return true;
        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is MyButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtDefaultAvukatHesap)
                    sec.Sec(txtDefaultAvukatHesap);
                else if (sender == txtDefaultBankaHesap)
                    sec.Sec(txtDefaultBankaHesap);
                else if (sender == txtDefaultKasaHesap)
                    sec.Sec(txtDefaultKasaHesap);
            }
        }
    }
}
using System;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using DevExpress.XtraEditors;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.HizmetForms
{
    public partial class HizmetEditForm : BaseEditForm
    {
        public HizmetEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new HizmetBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Hizmet;
            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new HizmetS (): ((HizmetBll)Bll).Single(FilterFunctions.Filter<Hizmet>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((HizmetBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtBaslangicTarihi.DateTime = txtBaslangicTarihi.Properties.MinValue;
            txtBitisTarihi.DateTime = txtBitisTarihi.Properties.MaxValue;
            txtHizmetAdi.Focus();

        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (HizmetS)OldEntity;
            txtKod.Text = entity.Kod;
            txtHizmetAdi.Text = entity.HizmetAdi;
            txtHizmetTuru.Id = entity.HizmetTuruId;
            txtHizmetTuru.Text = entity.HizmetTuruAdi;
            txtBaslangicTarihi.DateTime = entity.BaslamaTarihi;
            txtBitisTarihi.DateTime = entity.BitisTarihi;
            txtUcret.Value = entity.Ucret;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Hizmet
            {
                Id=Id,
                Kod =txtKod.Text,
                HizmetAdi=txtHizmetAdi.Text,
                HizmetTuruId=(long)txtHizmetTuru.Id,
                BaslamaTarihi=txtBaslangicTarihi.DateTime.Date,
                BitisTarihi=txtBitisTarihi.DateTime.Date,
                Ucret=txtUcret.Value,
                Aciklama=txtAciklama.Text,
                SubeId=AnaForm.SubeId,
                DonemId=AnaForm.DonemId,
                Durum=tglDurum.IsOn
            };
        }

        protected override bool EntityInsert()
        {
            return ((HizmetBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override bool EntityUpdate()
        {
            return ((HizmetBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtHizmetTuru)
                    sec.Sec(txtHizmetTuru);
        }

        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            base.Control_EditValueChanged(sender, e);

            txtBaslangicTarihi.Properties.MinValue = AnaForm.DonemParametreleri.EgitimBaslamaTarihi;
            txtBaslangicTarihi.Properties.MaxValue = AnaForm.DonemParametreleri.DonemBitisTarihi;
            txtBitisTarihi.Properties.MinValue = txtBaslangicTarihi.DateTime.Date;
            txtBitisTarihi.Properties.MaxValue = AnaForm.DonemParametreleri.DonemBitisTarihi;
        }
    }
}
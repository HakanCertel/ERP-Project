using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using System;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.SevkiyatSekilleriForm
{
    public partial class SevkiyatSekilleriEditForm : BaseEditForm
    {
        public SevkiyatSekilleriEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new SevkiyatSekliBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.SevkiyatSekli;

            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SevkiyatSekilleri() : ((SevkiyatSekliBll)Bll).Single(FilterFunctions.Filter<SevkiyatSekilleri>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SevkiyatSekliBll)Bll).YeniKodVer("SVK");
            txtSevkiyatSekli.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SevkiyatSekilleri)OldEntity;

            txtKod.Text = entity.Kod;
            txtSevkiyatSekli.Text = entity.SevkiyatSekli;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            DateTime? date = null;
            CurrentEntity = new SevkiyatSekilleri
            {
                Id = Id,
                Kod = txtKod.Text,
                SevkiyatSekli = txtSevkiyatSekli.Text,
                KayitTarihi = IslemTuru.EntityInsert == BaseIslemTuru ? DateTime.Now : ((SevkiyatSekilleri)OldEntity).KayitTarihi,
                KaydiOlusturan = IslemTuru.EntityInsert == BaseIslemTuru ? AnaForm.KullaniciAdi: ((SevkiyatSekilleri)OldEntity).KaydiOlusturan,
                GuncellemeTarihi= IslemTuru.EntityInsert != BaseIslemTuru?DateTime.Now: date,
                KaydiGuncelleyen= IslemTuru.EntityInsert != BaseIslemTuru ?AnaForm.KullaniciAdi:null,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}
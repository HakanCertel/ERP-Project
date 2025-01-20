using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.DovizForms
{
    public partial class DovizEditForm : BaseEditForm
    {
        public DovizEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new DovizBilgileriBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Doviz;
            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new DovizBilgileri() : ((DovizBilgileriBll)Bll).Single(FilterFunctions.Filter<DovizBilgileri>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (DovizBilgileri)OldEntity;

            txtKod.Text = entity.Kod;
            txtDovizAdi.Text = entity.DovizAdi;
            txtAciklama.Text = entity.Aciklama;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new DovizBilgileri
            {
                Id = Id,
                Kod = txtKod.Text,
                DovizAdi=txtDovizAdi.Text,
                Aciklama = txtAciklama.Text,
                KayitTarihi = IslemTuru.EntityInsert == BaseIslemTuru ? DateTime.Now : ((DovizBilgileri)OldEntity).KayitTarihi,
                KayitKisiId= IslemTuru.EntityInsert == BaseIslemTuru ? AnaForm.KullaniciId : ((DovizBilgileri)OldEntity).KayitKisiId,
                GuncellemeTarihi = ((DovizBilgileri)OldEntity).GuncellemeTarihi,
                GuncelleyenKisiId = ((DovizBilgileri)OldEntity).GuncelleyenKisiId,
                Durum = ((DovizBilgileri)OldEntity).Durum,
            };

            ButonEnabledDurumu();
        }
    }
}
using System;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.MakinaForms
{
    public partial class MakinaEditForm : BaseEditForm
    {
        public MakinaEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new MakinaBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Makina;
            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new MakinaS() : ((MakinaBll)Bll).Single(FilterFunctions.Filter<Makina>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MakinaBll)Bll).YeniKodVer();
            txtKod.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MakinaS)OldEntity;

            txtKod.Text = entity.Kod;
            txtMakinaAdi.Text = entity.MakinaAdi;
            txtMakinaTanimi.Text = entity.MakinaTanimi;
            txtOperasyon.Id = entity.OperasyonId;
            txtOperasyon.Text = entity.OperasyonAdi;
            txtIstasyon.Text = entity.Istasyon;
            txtAciklama.Text = entity.Aciklama;
            tglCapacity.IsOn = entity.IsCapacityBasedWorker;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Makina
            {
                Id = Id,
                Kod = txtKod.Text,
                MakinaAdi = txtMakinaAdi.Text,
                MakinaTanimi = txtMakinaTanimi.Text,
                OperasyonId = ((Makina)OldEntity).OperasyonId,
                Istasyon = txtIstasyon.Text,
                Aciklama=txtAciklama.Text,
                IsCapacityBasedWorker=tglCapacity.IsOn,
                Durum=tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtOperasyon)
                    sec.Sec(txtOperasyon);
            }
        }

    }
}
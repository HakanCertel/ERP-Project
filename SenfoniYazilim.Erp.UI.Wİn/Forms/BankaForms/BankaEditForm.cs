﻿using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraEditors;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.BankaForms
{
    public partial class BankaEditForm : BaseEditForm
    {
        public BankaEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BankaBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Banka;
            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new BankaS() : ((BankaBll)Bll).Single(FilterFunctions.Filter<Banka>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BankaBll)Bll).YeniKodVer();
            txtBankaAdi.Focus();
        }

        //üsteki metodla alınan veriyi kontrollere bağlamak için aşağıdaki metod oluşturulacaktır..
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (BankaS)OldEntity;

            txtKod.Text = entity.Kod;
            txtBankaAdi.Text = entity.BankaAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Banka
            {
                Id = Id,
                Kod = txtKod.Text,
                BankaAdi = txtBankaAdi.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };

            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Banka);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Banka);
        }
    }
}
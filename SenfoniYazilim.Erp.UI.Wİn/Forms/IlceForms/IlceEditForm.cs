﻿using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.IlceForms
{
    public partial class IlceEditForm : BaseEditForm
    {
        private readonly long _ilId;
        private readonly string  _ilAdi;

        public IlceEditForm(params object[] prm)
        {
            InitializeComponent();

            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IlceBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Ilce;
            EventsLoad();

        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Ilce() : ((IlceBll)Bll).Single(FilterFunctions.Filter<Ilce>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ( {_ilAdi} )";

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IlceBll)Bll).YeniKodVer(x=>x.IlId==_ilId);
            txtIlceAdi.Focus();
        }

        //üsteki metodla alınan veriyi kontrollere bağlamak için aşağıdaki metod oluşturulacaktır..
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Ilce)OldEntity;

            txtKod.Text = entity.Kod;
            txtIlceAdi.Text = entity.IlceAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Ilce
            {
                Id = Id,
                Kod = txtKod.Text,
                IlceAdi = txtIlceAdi.Text,
                IlId = _ilId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((IlceBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlId == _ilId);
        }

        protected override bool EntityUpdate()
        {
            return ((IlceBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlId == _ilId);
        }
    }
}
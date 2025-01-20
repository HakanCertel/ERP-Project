using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ServisForms
{
    public partial class ServisEditForm : BaseEditForm
    {
        public ServisEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new ServisBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Servis;

            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Servis() : ((ServisBll)Bll).Single(FilterFunctions.Filter<Servis>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ServisBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtServisYeriAdi.Focus();
        }

        //üsteki metodla alınan veriyi kontrollere bağlamak için aşağıdaki metod oluşturulacaktır..
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Servis)OldEntity;

            txtKod.Text = entity.Kod;
            txtServisYeriAdi.Text = entity.ServisYeriAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Servis
            {
                Id = Id,
                Kod = txtKod.Text,
                ServisYeriAdi = txtServisYeriAdi.Text,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((ServisBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override bool EntityUpdate()
        {
            return ((ServisBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

    }
}
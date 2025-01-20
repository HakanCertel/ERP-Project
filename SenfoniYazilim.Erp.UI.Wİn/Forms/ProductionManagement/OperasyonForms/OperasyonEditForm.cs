using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.OperasyonForms
{
    public partial class OperasyonEditForm : BaseEditForm
    {
        public OperasyonEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new OperasyonBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Operasyon;
            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Operasyon() : ((OperasyonBll)Bll).Single(FilterFunctions.Filter<Operasyon>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((OperasyonBll)Bll).YeniKodVer();
            txtKod.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Operasyon)OldEntity;

            txtKod.Text = entity.Kod;
            txtOperasyonAdi.Text = entity.OperasyonAdi;
            txtAciklama.Text = entity.Aciklama;
            txtDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Operasyon
            {
                Id=Id,
                Kod=txtKod.Text,
                OperasyonAdi=txtOperasyonAdi.Text,
                Aciklama=txtAciklama.Text,
                Durum=txtDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}
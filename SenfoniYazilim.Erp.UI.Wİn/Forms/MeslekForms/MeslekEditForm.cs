using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.MeslekForms
{
    public partial class MeslekEditForm : BaseEditForm
    {
        public MeslekEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BaseKartTuru =KartTuru.Meslek;
            Bll = new MeslekBll(myDataLayoutControl);
            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Meslek() : ((MeslekBll)Bll).Single(FilterFunctions.Filter<Meslek>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MeslekBll)Bll).YeniKodVer();
            txtMeslekAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Meslek)OldEntity;

            txtKod.Text = entity.Kod;
            txtMeslekAdi.Text = entity.MeslekAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Meslek
            {
                Id=Id,
                Kod=txtKod.Text,
                MeslekAdi=txtMeslekAdi.Text,
                Aciklama=txtAciklama.Text,
                Durum=tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}
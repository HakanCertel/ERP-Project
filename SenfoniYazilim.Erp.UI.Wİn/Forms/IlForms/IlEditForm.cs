using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.IlForms
{
    public partial class IlEditForm : BaseEditForm
    {
        public long _countryId;
        public readonly string _countryName;

        public IlEditForm(params object[] prm)
        {
            InitializeComponent();

            _countryId = (long)prm[0];
            _countryName = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IlBll(myDataLayoutControl);
            BaseKartTuru = Common.Enums.KartTuru.Il;
            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new Il() : ((IlBll)Bll).Single(FilterFunctions.Filter<Il>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ( {_countryName} )";

            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IlBll)Bll).YeniKodVer(x=>x.CountryId==_countryId);
            txtIlAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Il)OldEntity;
            txtKod.Text = entity.Kod;
            txtIlAdi.Text = entity.IlAdi;
            txtxAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Il
            {
                Id = Id,
                Kod=txtKod.Text,
                CountryId=_countryId,
                IlAdi=txtIlAdi.Text,
                Aciklama=txtxAciklama.Text,
                Durum=tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((IlBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.CountryId == _countryId);
        }

        protected override bool EntityUpdate()
        {
            return ((IlBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.CountryId == _countryId);
        }
    }
}
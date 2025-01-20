using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.IlForms
{
    public partial class CountryEditForm : BaseEditForm
    {
        public CountryEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new CountryBll(myDataLayoutControl);
            BaseKartTuru = Common.Enums.KartTuru.Il;
            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new Country() : ((CountryBll)Bll).Single(FilterFunctions.Filter<Country>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtCode.Text = ((CountryBll)Bll).YeniKodVer("CRY");
            txtCountryName.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Country)OldEntity;
            txtCode.Text = entity.Kod;
            txtCountryName.Text = entity.CountryName;
            txtDescription.Text = entity.Description;
            tglState.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Country
            {
                Id = Id,
                Kod=txtCode.Text,
                CountryName=txtCountryName.Text,
                Description=txtDescription.Text,
                Durum=tglState.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}
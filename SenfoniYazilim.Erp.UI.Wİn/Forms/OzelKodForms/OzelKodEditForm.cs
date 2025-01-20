using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.OzelKodForms
{
    public partial class OzelKodEditForm : BaseEditForm
    {
        private readonly OzelKodTuru _ozelKodTuru;

        private readonly KartTuru _ozelKodKartTur;

        public OzelKodEditForm(params object[] prm)
        {
            InitializeComponent();

            _ozelKodTuru =(OzelKodTuru) prm[0];
            _ozelKodKartTur = (KartTuru)prm[1];

            DataLayoutControl = myDataLayoutControl;
            Bll = new OzelKodBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.OzelKod;
            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new OzelKod() : ((OzelKodBll)Bll).Single(FilterFunctions.Filter<OzelKod>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((OzelKodBll)Bll).YeniKodVer(x => x.KodTuru==_ozelKodTuru&& x.KartTuru==_ozelKodKartTur);
            txtOzelKodAdi.Focus();
        }

        //üsteki metodla alınan veriyi kontrollere bağlamak için aşağıdaki metod oluşturulacaktır..
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OzelKod)OldEntity;

            txtKod.Text = entity.Kod;
            txtOzelKodAdi.Text = entity.OzelKodAdi;
            txtAciklama.Text = entity.Aciklama;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new OzelKod
            {
                Id = Id,
                Kod = txtKod.Text,
                OzelKodAdi = txtOzelKodAdi.Text,
                KodTuru = _ozelKodTuru,
                KartTuru=_ozelKodKartTur,
                Aciklama = txtAciklama.Text,
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((OzelKodBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KodTuru == _ozelKodTuru && x.KartTuru == _ozelKodKartTur);
        }

        protected override bool EntityUpdate()
        {
            return ((OzelKodBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KodTuru == _ozelKodTuru&&x.KartTuru==_ozelKodKartTur);
        }

    }
}
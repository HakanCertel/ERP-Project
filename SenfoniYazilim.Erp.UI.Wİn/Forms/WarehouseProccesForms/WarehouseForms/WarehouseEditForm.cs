using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.WarehouseForms
{
    public partial class WarehouseEditForm : BaseEditForm
    {
        //private readonly long _depoId;
        public WarehouseEditForm()
        {
            InitializeComponent();

            //_depoId = (long)prm[0];

            DataLayoutControl = myDataLayoutControl;
            Bll = new WareHouseBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Depo;
            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new WareHouse() : ((WareHouseBll)Bll).Single(FilterFunctions.Filter<WareHouse>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((WareHouseBll)Bll).YeniKodVer();
            txtKod.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (WareHouse)OldEntity;

            txtKod.Text = entity.Kod;
            txtDepoAdi.Text = entity.WarehouseName;
            txtAciklama.Text = entity.Description;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new WareHouse
            {
                Id = Id,
                Kod=txtKod.Text,
                WarehouseName=txtDepoAdi.Text,
                Description=txtAciklama.Text,
                Durum=tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }       

    }
}
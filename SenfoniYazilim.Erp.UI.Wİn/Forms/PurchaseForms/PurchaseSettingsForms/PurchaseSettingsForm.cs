using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using SenfoniYazilim.Erp.Model.Entities.Satınalma.PurchaseSettingsEntites;
using System.Linq;
using System;
using SenfoniYazilim.Erp.Model.Entities.Base;
using DevExpress.XtraBars;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.PurchaseSettingsForms
{
    public partial class PurchaseSettingsForm : BaseEditForm
    {
        public PurchaseSettingsForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new PurchaseSettingsBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.PurchaseSettings;

            EventsLoad();
            HideItems = new BarItem[] { btnYeni, btnGerial, btnSil };
        }
        public override void Yukle()
        {
            OldEntity=((PurchaseSettingsBll)Bll).Single( x => x.Id==1);
            if (OldEntity == null)
            {
                //OldEntity.Kod = ((PurchaseSettingsBll)Bll).YeniKodVer("STG");
                OldEntity = new PurchaseSettings
                {
                    Id = 1,
                    Kod = ((PurchaseSettingsBll)Bll).YeniKodVer("STG")
                };
                BaseIslemTuru = IslemTuru.EntityInsert;
            }
            else
                BaseIslemTuru = IslemTuru.EntityUpdate;
            NesneyiKontrollereBagla();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (PurchaseSettings)OldEntity;

            txtIsDemandSubjectToApproval.Checked = entity.IsDemandSubjectToApproval;
            txtIsOfferSubjectToApproval.Checked = entity.IsOfferSubjectToApproval;
            txtIsProccessDirectlyOrderFromDemand.Checked = entity.IsProccessDirectlyOrderFromDemand;
            txtIsProccessOrderFromDemand.Checked = entity.IsProccessOrderFromDemand;
            txtIsProccessOrderFromOffer.Checked = entity.IsProccessOrderFromOffer;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new PurchaseSettings()
            {
                Id=OldEntity.Id,
                Kod=OldEntity.Kod,
                IsOfferSubjectToApproval = txtIsOfferSubjectToApproval.Checked,
                IsDemandSubjectToApproval = txtIsDemandSubjectToApproval.Checked,
                IsProccessOrderFromDemand = txtIsProccessOrderFromDemand.Checked,
                IsProccessOrderFromOffer = txtIsProccessOrderFromOffer.Checked,
                IsProccessDirectlyOrderFromDemand = txtIsProccessDirectlyOrderFromDemand.Checked
            };

            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return base.EntityInsert();
        }
        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            base.Control_EditValueChanged(sender, e);
        }
    }
}
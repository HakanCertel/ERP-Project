using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using System;
using SenfoniYazilim.Erp.Common.Functions;
using System.Linq;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaTeklifForms
{
    public partial class PurchaseOfferEditForm : BaseEditForm
    {
        private readonly PurchaseOfferCreatingMethod _offerMethod=PurchaseOfferCreatingMethod.ChooseMaterial;

        public PurchaseOfferEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new PurchaseOfferBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.PurchaseOffer;

            EventsLoad();

            txtOfferCreatingMethod.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<PurchaseOfferCreatingMethod>());
        }
        public PurchaseOfferEditForm(params object[] prm):this()
        {
            if (prm != null)
                _offerMethod =(PurchaseOfferCreatingMethod)prm[0];
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new PurchaseOfferS() : ((PurchaseOfferBll)Bll).Single(FilterFunctions.Filter<Model.Entities.Satınalma.PurchaseOffer>(Id));

            NesneyiKontrollereBagla();

            if (SelectedEntities != null)
                tglIsMultipleCompany.IsOn = true;
            if (BaseIslemTuru == IslemTuru.EntityInsert)
            {
                Id = BaseIslemTuru.IdOlustur(OldEntity);
                txtKod.Text = ((PurchaseOfferBll)Bll).YeniKodVer("STK");
                txtOfferedCompanyName.Focus();
            }
            TabloYukle();
            //purchaseOfferEditFormTable.AddExternalRow();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (PurchaseOfferS)OldEntity;
            txtKod.Text = entity.Kod; 
            txtOfferCreatingMethod.Text =entity.PurchaseOfferCreatingMethod.toName();
            txtOfferedCompanyName.Id = entity.CompanyId;
            txtOfferedCompanyName.Text = entity.OfferedCompanyName;
            txtPurchaseOfferedDescription.Text = entity.OfferDescription;
            txtValidityStartDate.DateTime = entity.ValidityStarDate==null ? DateTime.Now: Convert.ToDateTime( entity.ValidityStarDate);
            txtValidityEndDate.DateTime =entity.ValidityEndDate==null? DateTime.Now: Convert.ToDateTime(entity.ValidityEndDate);
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new PurchaseOffer
            {
                Id = Id,
                Kod = txtKod.Text,//BaseIslemTuru==IslemTuru.EntityInsert?_offerCode:OldEntity.Kod,
                PurchaseOfferCreatingMethod = txtOfferCreatingMethod.Text.GetEnum<PurchaseOfferCreatingMethod>(),
                CompanyId =txtOfferedCompanyName.Id,
                ValidityStarDate = txtValidityStartDate.DateTime,
                ValidityEndDate = txtValidityEndDate.DateTime,
                OfferDescription = txtPurchaseOfferedDescription.Text,
                Durum = tglDurum.IsOn,
            };

            ButonEnabledDurumu();
        }

        protected internal override void ButonEnabledDurumu()
        {
            bool TableValueChanged()
            {
                if (purchaseOfferEditFormTable.TableValueChanged) return true;

                return false;
            }
            if (!IsLoaded) return;
           Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, TableValueChanged());
        }

        protected override void TabloYukle()
        {
            purchaseOfferEditFormTable.OwnerForm = this;
            purchaseOfferEditFormTable._offerMethod = _offerMethod;
            purchaseOfferEditFormTable.Yukle();
           // purchaseOfferEditFormTable.Tablo.RowFocus("Id", SelectedItemId);
        }

        protected override bool EntityInsert()
        {
            if (purchaseOfferEditFormTable.HatalıGiriş()) return false;

            var result = ((PurchaseOfferBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod) && purchaseOfferEditFormTable.Kaydet();

            if (result&&_offerMethod==PurchaseOfferCreatingMethod.ChoosePurchaseDemandItem)
            {
                SelectedEntities?.Cast<PurchaseDemandItemsListFormL>().ToList().ForEach(x =>
                {
                    x.IsCreateOffer = true;
                });

                InstanceBaseHareketEntityBll<PurchaseDemandItems, PurchaseDemandItemsTableBll>
                    .InsertEntities(SelectedEntities?.Cast<BaseHareketEntity>().ToList());
            }
            return result;
        }

        protected override bool EntityUpdate()
        {
            if (purchaseOfferEditFormTable.HatalıGiriş()) return false;

            var result = ((PurchaseOfferBll)Bll).Update(OldEntity, CurrentEntity) && purchaseOfferEditFormTable.Kaydet();

            return result;
        }

        protected override void EntityDelete()
        {
            purchaseOfferEditFormTable.TopluHareketSil();

            var result = ((PurchaseOfferBll)Bll).Delete(OldEntity) && purchaseOfferEditFormTable.Kaydet();

            RefreshYapilacak = true;
            Close();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtOfferedCompanyName)
                    sec.Sec(txtOfferedCompanyName);
        }

        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;

            if (sender != tglIsMultipleCompany) return;

            txtOfferedCompanyName.Enabled = false;
            txtOfferedCompanyName.Text = "";
            txtOfferedCompanyName.Id = null;
            purchaseOfferEditFormTable.SutunGizleGoster();

            base.Control_EditValueChanged(sender, e);
        }

    }
}
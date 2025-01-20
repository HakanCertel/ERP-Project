using System;
using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General.PriceListBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.PriceListEntities;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto.PriceListDto;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.Bll.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PriceListForms
{
    public partial class PriceListEditForm : BaseEditForm
    {
        public PriceListEditForm()
        {
            InitializeComponent();
            
            DataLayoutControl = myDataLayoutControl;
            Bll = new PriceListBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.PriceList;
            EventsLoad();


            KayitSonrasiFormuKapat = false;

        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new PriceListS() : ((PriceListBll)Bll).Single(FilterFunctions.Filter<PriceList>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();
            //EnabledIsFaleOrTrue(false);

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtCode.Text = ((PriceListBll)Bll).YeniKodVer("PRL");
            txtValidityStartDate.EditValue = DateTime.Now;
            txtCurrencyType.Properties.Items.AddRange(GetAnySingleOrListBll.ListCurrencyItems(null).Select(x => x.Kod).ToList());
            txtValidityEndDate.EditValue = new DateTime(2050, 12, 31);
            txtCurrencyType.EditValue = GetAnySingleOrListBll.ListCurrencyItems(null).Select(x=>x.Kod).FirstOrDefault();
            priceListEditTable.Tablo.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (PriceListS)OldEntity;

            txtCode.Text = entity.Kod;
            txtListName.Text = entity.ListName;
            txtValidityStartDate.EditValue = entity.ValidityStartDate;
            txtValidityEndDate.EditValue = entity.VailidityEndDate;
            txtDescription.Text = entity.Description;
            txtCurrencyType.EditValue = entity.CurrencyCode;
            tglState.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            var currencyId = GetAnySingleOrListBll.ListCurrencyItems(x => x.Kod == txtCurrencyType.Text).FirstOrDefault().Id;

            CurrentEntity = new PriceList
            {
                Id = Id,
                CurrencyTypeId=currencyId,
                Kod=txtCode.Text,
                ListName=txtListName.Text,
                ValidityStartDate=(DateTime)txtValidityStartDate.EditValue,
                VailidityEndDate=(DateTime)txtValidityEndDate.EditValue,
                Description=txtDescription.Text,
                Durum=tglState.IsOn,
                CreatorUserId=BaseIslemTuru==IslemTuru.EntityInsert?AnaForm.KullaniciId:((PriceList)OldEntity).CreatorUserId,
                UpdatingUserId=AnaForm.KullaniciId
            };

            ButonEnabledDurumu();
        }

        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;
            Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, priceListEditTable.TableValueChanged);
        }

        protected override void TabloYukle()
        {
            priceListEditTable.OwnerForm = this;
            priceListEditTable.Yukle();
        }

        protected override bool EntityInsert()
        {

            if (priceListEditTable.HatalıGiriş()) return false;

            var result = ((PriceListBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod) && priceListEditTable.Kaydet();

            if (result && !KayitSonrasiFormuKapat)
                priceListEditTable.Yukle();
            return result;
        }

        protected override bool EntityUpdate()
        {
            if (priceListEditTable.HatalıGiriş()) return false;

            var result = ((PriceListBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod) && priceListEditTable.Kaydet();

            return result;
        }

        protected override void EntityDelete()
        {
            priceListEditTable.TopluHareketSil();

            if (!priceListEditTable.Kaydet()) return;

            base.EntityDelete();
        }
    }
}
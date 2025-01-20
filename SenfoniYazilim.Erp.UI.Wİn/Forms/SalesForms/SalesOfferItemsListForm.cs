using System;
using System.Collections.Generic;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using System.Linq.Expressions;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using SenfoniYazilim.Erp.Bll.General.SalesBll;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Model.Dto.SalesDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SaleWayBillForms
{
    public partial class SalesOfferItemsListForm : BaseListForm
    {
        private readonly long _companyId;

        private readonly long? _currencyId;

        private Expression<Func<SalesOfferItems, bool>> _filter;

        private Expression<Func<SalesOfferItemsL, bool>> _sourceFilter;

        public SalesOfferItemsListForm()
        {
            InitializeComponent();

            Bll = new SalesOfferItemsBll();

            HideItems = new BarItem[] { btnTalepBirlestir, btnTeklifTopla,btnCancel, btnChangeBaseStatus,btnCloseItem,btnSil };
            ShowItems = new BarItem[] { btnCreateOrder };

            if (AnaForm.KullaniciYetkisi == KullaniciYetkisi.Yonetici)
                _filter = x => x.IsActive == AktifKartlariGoster;
            else
                _filter = x => x.IsActive == AktifKartlariGoster && x.CreatorId == AnaForm.KullaniciId;
        }
        public SalesOfferItemsListForm(params object[] prm):this()
        {
            _companyId = (long)prm[0];
            _currencyId = (long?)prm[1];

            if (AnaForm.KullaniciYetkisi == KullaniciYetkisi.Yonetici)
                _filter = x => x.IsActive == AktifKartlariGoster&&x.IsComfirmed&&x.CompanyOfferedId==_companyId&&!x.IsCreatedOrder;
            else
                _filter = x => x.IsActive == AktifKartlariGoster && x.CreatorId == AnaForm.KullaniciId;
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.SalesOffer;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<SalesOfferEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SalesOfferItemsBll)Bll).List(_filter);
        }

        protected override void EntityDelete()
        {
            var selectedEntities = HareketRowsSelected.GetSelectedRows().EntityListConvert<SalesOfferItemsL>().ToList();

            if (selectedEntities.Count == 0) { Messages.KartSecmemeUyariMesaji();return; }

            //if (!DeleteConfirm(selectedEntities.Any(x => x.ManagerComfirmState != YoneticiOnayDurum.IslemYapilmadi), selectedEntities.Any(x => x.OfferComfirmState != YoneticiOnayDurum.IslemYapilmadi), selectedEntities.Any(x => x.PurchaseOrderId != null))) return;

            var deletingEntity = new List<BaseHareketEntity>();

            selectedEntities.ForEach(x =>
            {
                deletingEntity.Add(x);
            });

            ((SalesOfferItemsBll)Bll).Delete(deletingEntity);

            Listele();
            HareketRowsSelected.ClearSelection();
        }

        protected override void ShowEditForm(long id)
        {
            if (HareketRowsSelected.SelectedRowCount == 0 && id == -1)
            {
                base.ShowEditForm(id);
                //Messages.KartSecmemeUyariMesaji();
                return;
            }
            if (HareketRowsSelected.SelectedRowCount > 1||HareketRowsSelected.SelectedRowCount==0)
            {
                Messages.BilgiMesaji("Lütfen Tek Bir Satır Seçerek , Tekrar Deneyiniz .");
                HareketRowsSelected.ClearSelection();
                return;
            }

            var focusedEntity = HareketRowsSelected.GetSelectedRows().EntityListConvert<SalesOfferItemsL>().FirstOrDefault(); //Tablo.GetRow<TumSatinalmaTalepKalemleri>();
            HareketRowsSelected.ClearSelection();
            var result = ShowEditForms<SalesOfferEditForm>.ShowDialogForm(BaseKartTuru, focusedEntity.SalesOfferId, focusedEntity.Id);
            ShowEditFormDefault(result);
        }

        protected override void FormCaptionAyarla(bool _switch = false)
        {
            if (AktifKartlariGoster)
            {
                btnAktifPasifKartlar.Caption = "Pasif Kartlar";
                btnChangeBaseStatus.Caption = "Pasif";
                Tablo.ViewCaption = Text;
               // _filter = x => x.IsActive == AktifKartlariGoster && !x.IsClosed && !x.IsCancel;
                Listele();
            }
            else
            {
                btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                btnChangeBaseStatus.Caption = "Aktif";
                Tablo.ViewCaption = Text + "- Pasif Kartlar";
                //_filter = x => x.IsActive == AktifKartlariGoster || x.IsClosed || x.IsCancel;
                Listele();
            }
            SutunGizleGoster();
        }

        protected override void CreateOrder()
        {

            var entities = HareketRowsSelected.GetSelectedRows().Cast<SalesOfferItemsL>()
                .Where(x => !x.IsCreatedOrder && x.IsActive).ToList();
            if (entities.Count == 0)
            {
                Messages.KartSecmemeUyariMesaji();
                return;
            }

            var saleOfferItem = entities.FirstOrDefault();

            if (entities.Any(x => x.SalesOfferId !=saleOfferItem.SalesOfferId))
            {
                Messages.HataMesaji("Farklı Tekliflere Ait Kalemler Mevcut. Seçmiş Olduğunuz Tüm Kalemlerin Tek Bir Teklife Ait Olduğundan Emin Olunuz !");
                HareketRowsSelected.ClearSelection();
                return;
            }

            var saleOffer=GetAnySingleOrListBll.GetSaleOffer(x => x.Id == saleOfferItem.SalesOfferId);

            ShowEditForms<SalesEditForm>.ShowDialogForm(IslemTuru.EntityInsert, entities.Cast<BaseHareketEntity>().ToList(),saleOffer);

            HareketRowsSelected.ClearSelection();
        }

        protected override void Tablo_DoubleClick(object sender, EventArgs e)
        {
            //base.Tablo_DoubleClick(sender, e);
            var offerItem = Tablo.GetRow<SalesOfferItemsL>();
            _sourceFilter = x => x.CompanyOfferedId==offerItem.CompanyOfferedId;
            offerItem.FiltreleDataSource<SalesOfferItemsL>(true, Tablo, _sourceFilter);
            _filter = null;
        }

    }
}
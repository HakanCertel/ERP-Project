using System;
using System.Collections.Generic;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using System.Linq.Expressions;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using SenfoniYazilim.Erp.Bll.General.SalesBll;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Model.Dto.SalesDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.PurchaseDemandForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SaleWayBillForms
{
    public partial class SalesItemsListForm : BaseListForm
    {
        private  Expression<Func<SalesItems, bool>> _filter;

        private Expression<Func<SalesItemsL, bool>> _sourceFilter;

        public SalesItemsListForm()
        {
            InitializeComponent();

            Bll = new SalesItemsBll();

            BaseKartTuru = KartTuru.SalesItems;

            HideItems = new BarItem[] { btnTalepBirlestir, btnTeklifTopla,btnChangeBaseStatus,btnCancel,btnCloseItem };
            ShowItems = new BarItem[] { btnCreateOrder,btnProductionDeman,btnCreatePurchaseDemand };

            if (AnaForm.KullaniciYetkisi == KullaniciYetkisi.Yonetici)
                _filter = x => x.IsActive == AktifKartlariGoster;
            else
                _filter = x => x.IsActive == AktifKartlariGoster && x.CreatorId == AnaForm.KullaniciId;
        }
        public SalesItemsListForm(params object[] prm):this()
        {
            //if(ListeDisiTutulacakKayitlar!=null)
                _filter= x => x.IsActive == AktifKartlariGoster&&!ListeDisiTutulacakKayitlar.Contains(x.Id)&&x.SaleProccessStatus==SaleProccessStatus.CreatedProductionDemand;
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.SalesItems;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<SalesEditForm>();
        }
        protected override void Listele()
        {
            var list= ((SalesItemsBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = ((SalesItemsBll)Bll).List(_filter);
        }

        protected override void EntityDelete()
        {
            var selectedEntities = HareketRowsSelected.GetSelectedRows().EntityListConvert<SalesItemsL>().ToList();

            if (selectedEntities.Count == 0) { Messages.KartSecmemeUyariMesaji();return; }

            var deletingEntity = new List<BaseHareketEntity>();

            selectedEntities.ForEach(x =>
            {
                deletingEntity.Add(x);
            });

            ((SalesItemsBll)Bll).Delete(deletingEntity);

            Listele();
            HareketRowsSelected.ClearSelection();
        }

        protected override void ShowEditForm(long id)
        {
            if (HareketRowsSelected.SelectedRowCount == 0 && id == -1)
            {
                base.ShowEditForm(id);
                return;
            }
            if (HareketRowsSelected.SelectedRowCount > 1||HareketRowsSelected.SelectedRowCount==0)
            {
                Messages.BilgiMesaji("Lütfen Tek Bir Satır Seçerek , Tekrar Deneyiniz .");
                HareketRowsSelected.ClearSelection();
                return;
            }

            var focusedEntity = HareketRowsSelected.GetSelectedRows().Cast<SalesItemsL>().FirstOrDefault(); //Tablo.GetRow<TumSatinalmaTalepKalemleri>();
            HareketRowsSelected.ClearSelection();
            var result = ShowEditForms<SalesEditForm>.ShowDialogForm(BaseKartTuru, focusedEntity.SalesId, focusedEntity.Id);
            ShowEditFormDefault(result);
        }

        protected override void ProductionDemand()
        {
            var selectedEntites = HareketRowsSelected.GetSelectedRows().Cast<SalesItemsL>()
                .Where(x=>x.IsActive&&x.SaleProccessStatus==SaleProccessStatus.NoProccess).ToList();

            if (selectedEntites.Count == 0) return;

            selectedEntites.ForEach(x =>
            {
                x.SaleProccessStatus = SaleProccessStatus.CreatedProductionDemand;
            });

            ((SalesItemsBll)Bll).Update(selectedEntites.Cast<BaseHareketEntity>().ToList());

            HareketRowsSelected.ClearSelection();
        }

        protected override void CreatePurchaseDemand()
        {
            var entities = HareketRowsSelected.GetSelectedRows().Cast<SalesItemsL>()
                .Where(x => x.SaleProccessStatus==SaleProccessStatus.NoProccess && x.IsActive).ToList();

            if (entities.Count == 0)
            {
                Messages.KartSecmemeUyariMesaji();
                HareketRowsSelected.ClearSelection();
                return;
            }

            ShowEditForms<PurchaseDemanEditForm>.ShowDialogForm(IslemTuru.EntityInsert, BaseKartTuru,entities.Cast<BaseHareketEntity>().ToList(), null);

            HareketRowsSelected.ClearSelection();
        }

        protected override void FormCaptionAyarla(bool _switch = false)
        {
            if (AktifKartlariGoster)
            {
                btnAktifPasifKartlar.Caption = "Pasif Kartlar";
                btnChangeBaseStatus.Caption = "Pasif";
                Tablo.ViewCaption = Text;
                _filter = x => x.IsActive == AktifKartlariGoster && !x.IsClosed && !x.IsCancel;
                Listele();
            }
            else
            {
                btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                btnChangeBaseStatus.Caption = "Aktif";
                Tablo.ViewCaption = Text + "- Pasif Kartlar";
                _filter = x => x.IsActive == AktifKartlariGoster || x.IsClosed || x.IsCancel;
                Listele();
            }
            SutunGizleGoster();
        }

        protected override void Tablo_DoubleClick(object sender, EventArgs e)
        {
            //base.Tablo_DoubleClick(sender, e);
            var saleItem = Tablo.GetRow<SalesItemsL>();
            _sourceFilter = x => x.CompanySalesId == saleItem.CompanySalesId;
            saleItem.FiltreleDataSource<SalesItemsL>(true, Tablo, _sourceFilter);
        }

    }
}
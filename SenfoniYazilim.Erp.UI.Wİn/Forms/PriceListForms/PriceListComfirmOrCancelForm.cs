using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General.PriceListBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System.Linq.Expressions;
using System;
using SenfoniYazilim.Erp.Model.Entities.PriceListEntities;
using SenfoniYazilim.Erp.Common.Message;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.Collections.Generic;
using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.Bll.Functions.Converts;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PriceListForms
{
    public partial class PriceListComfirmOrCancelForm : BaseListForm
    {

        private readonly Expression<Func<PriceList, bool>> _filter;

        public PriceListComfirmOrCancelForm()
        {
            InitializeComponent();

            Bll = new PriceListBll();
            ComfirmModeSwitch = true;

            HideItems = new DevExpress.XtraBars.BarItem[] {btnYeni,btnSil,btnDuzelt };
            ShowItems = new DevExpress.XtraBars.BarItem[] { btnSec };
            btnAktifPasifKartlar.Caption = "Onaysız Kartlar";
            _filter = x => x.Durum == AktifKartlariGoster;

        }

        public PriceListComfirmOrCancelForm(params object[] prm):this()
        {
            if(prm[0]!= null)
                _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id)&&x.Durum == AktifKartlariGoster&&!x.IsComfirmed;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.PriceList;
            FormShow = new ShowEditForms<PriceListEditForm>();
            RowSelect = new SelectRowFunctions(Tablo);
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            RowSelect.ClearSelection();
            Tablo.GridControl.DataSource = ((PriceListBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.IsComfirmed == IsComfirmed);
        }
        protected override void SelectEntity()
        {
            SelectedEntities = new List<BaseEntity>();
            SelectedEntities = RowSelect.GetSelectedRows();
            if (SelectedEntities == null) return;
            SelectedEntities.EntityListConvert<PriceList>().ForEach(x =>
            {
                var oldEntity = new PriceList
                {
                    Id=x.Id,
                    Kod=x.Kod,
                    CurrencyTypeId=x.CurrencyTypeId,
                    ListName=x.ListName,
                    Description=x.Description,
                    UpdatingUserId=AnaForm.KullaniciId,
                    ValidityStartDate=x.ValidityStartDate,
                    VailidityEndDate=x.VailidityEndDate,
                    CreatorUserId=x.CreatorUserId,
                    IsComfirmed=x.IsComfirmed,
                    IsLocked=x.IsLocked,
                    Durum=x.Durum
                };
                x.IsComfirmed = !IsComfirmed;
                x.IsLocked = x.IsComfirmed;
                PriceList currentEntity =x.EntityCovert<PriceList>();
                ((PriceListBll)Bll).Update(oldEntity, currentEntity);
                Listele();
            });

        }
    }
}
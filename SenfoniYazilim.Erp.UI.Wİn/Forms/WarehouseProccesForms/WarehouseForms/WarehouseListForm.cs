using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.WarehouseForms
{
    public partial class WarehouseListForm : BaseListForm
    {
        public WarehouseListForm()
        {
            InitializeComponent();

            Bll = new WareHouseBll();
            ShowItems = new BarItem[] {btnTahakkukYap,btnIceriVeriAktar};
            btnTahakkukYap.Caption = "Depo Stok";
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            BaseKartTuru = KartTuru.Depo;
            FormShow = new ShowEditForms<WarehouseEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((WareHouseBll)Bll).List(FilterFunctions.Filter<WareHouse>(AktifKartlariGoster));
        }

        protected override void TahakkukYap()
        {
            var entity = Tablo.GetRow<WareHouse>().EntityCovert<WareHouse>();

            if (entity == null) return;
            
            using (var bll = new WarehouseStockBll())
            {
                var depo = bll.List(x => x.WareHouseId == entity.Id );
                
                if (depo != null)
                    ShowEditForms<DepoStokEditForm>.ShowDialogForm(KartTuru.Stok, entity.Id, entity);
                else
                    ShowEditForms<DepoStokEditForm>.ShowDialogForm(KartTuru.Stok, -1, entity);
            }
        }

        protected override void VeriAktar()
        {
            var list = new List<WareHouseStocks>();
            Expression<Func<WareHouseStocks, bool>> filter;
            filter = x => x.Id != 0;
            ShowVeriAktarEditForms<VeriAktarimListForm, WareHouseStocks, WarehouseStockBll>.ShowDialogListForm(KartTuru.Depo, filter, new WarehouseStockBll());
        }

    }
}
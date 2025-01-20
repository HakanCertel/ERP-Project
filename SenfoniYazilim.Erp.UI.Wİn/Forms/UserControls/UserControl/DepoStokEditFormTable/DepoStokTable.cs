using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.DepoStokEditFormTable
{
    public partial class DepoStokTable : BaseTablo
    {
        public DepoStokTable()
        {
            InitializeComponent();
            Bll = new WarehouseStockBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((WarehouseStockBll)Bll).List(x => x.WareHouseId == OwnerForm.Id).toBindingList<WareHouseStockL>();
        }

        protected override void HareketEkle()
        {
            var source = Tablo.DataController.ListSource;

            ListeDisiTutulacakKayitlar = source.Cast<WareHouseStockL>().Where(x => !x.Delete).Select(x => x.MaterialId).ToList();

            var entities = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<MaterialL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new WareHouseStockL
                {
                    WareHouseId=OwnerForm.Id,
                    MaterialId=entity.Id,
                    MaterialCode=entity.Kod,
                    MaterialName=entity.StockName,
                    MaterialType=entity.UrunCinsi,
                    Quantity=0,
                    UnitId=(long)entity.UnitId,
                    UnitCode=entity.UnitCode,
                    UnitName=entity.UnitName,
                    Insert=true
                };

                source.Add(row);
            }

            Tablo.Focus();
            Tablo.RefreshDataSource();
            Tablo.FocusedRowHandle = Tablo.DataRowCount - 1;
            Tablo.FocusedColumn = colMaterialCode;
            ButtonEnabledDurum(true);
        }
    }
}

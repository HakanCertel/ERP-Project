using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.DepoStokEditFormTable
{
    public partial class DepoStokDuzeltTable : BaseTablo
    {
        public DepoStokDuzeltTable()
        {
            InitializeComponent();
            Bll = new WarehouseStockUpdateBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((WarehouseStockUpdateBll)Bll).List(null);
        }
        protected override void HareketEkle()
        {
            var source = Tablo.DataController.ListSource;

            ListeDisiTutulacakKayitlar = source.Cast<WareHouseStockUpdateL>().Where(x => !x.Delete).Select(x => x.MaterialId).ToList();

            var entities = ShowListForms<DepoStokListForm>.ShowDialogListForm(KartTuru.DepoStokDuzelt, ListeDisiTutulacakKayitlar, true, OwnerForm.Id).EntityListConvert<WareHouseStockL>(true,false);

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new WareHouseStockUpdateL
                {
                    WareHouseId = OwnerForm.Id,
                    MaterialId = entity.Id,
                    MaterialCode = entity.MaterialCode,
                    MaterialName = entity.MaterialName,
                    Quantity  = entity.Quantity,
                    Unit = entity.UnitCode,
                    Insert = true
                };

                source.Add(row);
            }

            Tablo.Focus();
            Tablo.RefreshDataSource();
            Tablo.FocusedRowHandle = Tablo.DataRowCount - 1;
            Tablo.FocusedColumn = colStokKodu;
            ButtonEnabledDurum(true);
        }
    }
}

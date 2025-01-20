using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Model.Dto.CRPDto;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Bll.General.CRP;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Model.Dto;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.CRPForms.IsEmriForms.IsEmriTables
{
    public partial class WorkOrderMaterialTable : BaseTablo
    {
        protected internal WorkOrdersL _workOrder;

        public WorkOrderMaterialTable()
        {
            InitializeComponent();

            Bll = new WorkOrderMaterialItemsBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new BarItem[] { btnKartDuzenle };
        }
        protected internal override void Yukle()
        {
            base.Yukle();
            repositoryItemLookUpDepo.DataSource = GetAnySingleOrListBll.ListWarehouses();
            repositoryItemLookUpDepo.ValueMember = "Id";
            repositoryItemLookUpDepo.DisplayMember = "Kod";
            repositoryItemLookUpUnit.DataSource = GetAnySingleOrListBll.ListUnitItems();
            repositoryItemLookUpUnit.ValueMember = "Id";
            repositoryItemLookUpUnit.DisplayMember = "BirimAdi";
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((WorkOrderMaterialItemsBll)Bll).List(x => x.OwnerFormId == _workOrder.Id).toBindingList<WorkOrderMaterialItemsL>();
        }
        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;

            ListeDisiTutulacakKayitlar = source.Cast<WorkOrderMaterialItemsL>().Where(x => !x.Delete).Select(x => x.MaterialId).ToList();

            var entities = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<MaterialL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new WorkOrderMaterialItemsL
                {
                    OwnerFormId=_workOrder.Id,
                    MalzemeIhtiyacBilgileriId=_workOrder.MalzemeIhtiyacBilgiId,
                    MrpBilgileriId=_workOrder.MrpBilgileriId,
                    MaterialId=entity.Id,
                    MaterialCode=entity.Kod,
                    MaterialName=entity.StockName,
                    UnitId=(long)entity.UnitId,
                    UnitCode=entity.UnitCode,
                    WarehouseId=entity.DepoId,
                    WarehouseName=entity.DepoAdi,
                    Insert = true
                };

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colUnitQty;

            ButtonEnabledDurum(true);
        }
    }
}

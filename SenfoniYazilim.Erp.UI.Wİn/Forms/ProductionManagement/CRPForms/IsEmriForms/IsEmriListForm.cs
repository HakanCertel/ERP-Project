using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General.CRP;
using SenfoniYazilim.Erp.Common.Enums;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.Model.Dto.CRPDto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.TransferBetweenWarehousesForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.CRPForms.IsEmriForms
{
    public partial class IsEmriListForm : BaseListForm
    {
        private BaseEditForm _ownerForm;

        public IsEmriListForm()
        {
            InitializeComponent();

            Bll = new WorkOrdersBll();

            HideItems = new BarItem[] {btnSil,btnCancel,btnActive, };
            ShowItems = new BarItem[] { btnTransferDemand};
        }
        protected override void DegiskenleriDoldur()
        {
            //_ownerForm = new BaseEditForm();

            Tablo = tablo;
            BaseKartTuru = KartTuru.IsEmri;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<IsEmriEditForm>();

            btnTransferDemand.Enabled = false;

            tabPane.SelectedPageChanged += TabPane_SelectedPageChanged;
        }


        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((WorkOrdersBll)Bll).List(x=>x.IsActive==AktifKartlariGoster);
        }

        private void TabPane_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (!TabloLoaded) return;

            var entity = Tablo.GetRow<WorkOrdersL>();
            if (entity == null) return;

            btnTransferDemand.Enabled = false;

            if (e.Page == pageBagliMalzemeler)
            {
                btnTransferDemand.Enabled = true;

                if(_ownerForm==null)
                    _ownerForm=new BaseEditForm();

                workOrderMaterialTable.OwnerForm = _ownerForm;
                workOrderMaterialTable._workOrder = entity;
                workOrderMaterialTable.Yukle();
            }
        }
        protected override void PerformProccess()
        {
            //base.PerformProccess();
            var entity = Tablo.GetRow<WorkOrdersL>();
            if (entity == null) return;
            ShowEditForms<TransferDemandBetweenWarehousesEditForm>.ShowDialogForm(IslemTuru.EntityInsert, entity); ;
        }

    }
}
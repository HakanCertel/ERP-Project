using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.TransferBetweenWarehousesForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.TransferBetweenWarehousesForms
{
    public partial class TransferBetweenWarehousesListFrom : BaseListForm
    {
        public TransferBetweenWarehousesListFrom()
        {
            InitializeComponent();

            Bll = new TarnsferItemsBetweenWareHousesBll();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnSil };
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            BaseKartTuru = KartTuru.DepolarArasiTransfer;
            FormShow = new ShowEditForms<TransferBetweenWarehousesEditForm>();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((TarnsferItemsBetweenWareHousesBll)Bll).List(x => x.Id!=0).toBindingList<TarnsferItemsBetweenWareHousesL>();
        }
        protected override void ShowEditForm(long id)
        {
            long _id;

            if (id < 0)
                _id = id;
            else
                _id = Tablo.GetRow<TarnsferItemsBetweenWareHousesL>().OwnerFormId;

            var result = FormShow.ShowDialogForm(BaseKartTuru, _id);

            ShowEditFormDefault(result);
        }
    }
}
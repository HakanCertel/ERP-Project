using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms
{
    public partial class DATStokListForm : BaseListForm
    {
        private readonly long _depoId;

        public DATStokListForm(params object[] prm)
        {
            InitializeComponent();
           
            Bll = new WarehouseStockBll();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnSil,btnYeni,btnDuzelt,btnKaydet};

            _depoId = (long)prm[0];
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Stok;
            FormShow = new ShowEditForms<StokEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            var list = ((WarehouseStockBll)Bll).ListBaseEntity(x=> ListeDisiTutulacakKayitlar.Contains(x.Id)&&x.WareHouseId==_depoId);

            Tablo.GridControl.DataSource = list;
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }
    }
}
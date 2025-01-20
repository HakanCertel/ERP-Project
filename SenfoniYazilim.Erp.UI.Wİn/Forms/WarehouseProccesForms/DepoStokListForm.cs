using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Message;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms
{
    public partial class DepoStokListForm : BaseListForm
    {
        private readonly long _depoId;

        public DepoStokListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new WarehouseStockBll();
            HideItems = new BarItem[]
            {
                btnYeni,btnSil,btnKaydet,
                btnDuzelt, barDelete, barDeleteAciklama, barYeni, barYeniAciklama, barDuzelt, barDuzeltAciklama
            };
            _depoId = (long)prm[0];
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {

            var list = ((WarehouseStockBll)Bll).ListBaseEntity(x =>!ListeDisiTutulacakKayitlar.Contains(x.MaterialId)&& x.WareHouseId == _depoId);

            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");

        }
    }
}
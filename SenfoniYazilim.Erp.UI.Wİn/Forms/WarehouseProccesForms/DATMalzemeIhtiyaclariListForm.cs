using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using DevExpress.XtraBars;
using System;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms
{
    public partial class DATMalzemeIhtiyaclariListForm : BaseListForm
    {
        public DATMalzemeIhtiyaclariListForm(params object[] prm)
        {
            InitializeComponent();

            Bll= new MalzemeIhtiyacBilgileriBll();
            HideItems = new BarItem[] { btnYeni,btnDuzelt, btnSil, btnTahakkukYap, btnKaydet, btnUretimSonuKaydi };
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Mrp;
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            var list = ((MalzemeIhtiyacBilgileriBll)Bll).BirlestirList(x => !ListeDisiTutulacakKayitlar.Contains(x.StokId) && x.NetIhtiyac>0&&x.ReceteSeviyesi!=0);

            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }

        //protected override void Tablo_DoubleClick(object sender, EventArgs e){}
    }
}
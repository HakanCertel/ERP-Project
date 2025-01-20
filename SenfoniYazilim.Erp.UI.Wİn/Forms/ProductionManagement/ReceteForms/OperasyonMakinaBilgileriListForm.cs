using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using DevExpress.XtraBars;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms
{
    public partial class OperasyonMakinaBilgileriListForm : BaseListForm
    {
        public OperasyonMakinaBilgileriListForm()
        {
            InitializeComponent();

            Bll = new IstasyonOperasyonBilgileriBll();
            HideItems = new BarItem[] {btnYeni,btnSil,btnDuzelt,btnYeni,btnFiltrele,btnYazdir,btnGonder };
        }
        public OperasyonMakinaBilgileriListForm(params object[] prm):this()
        {
                
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            
        }
        protected override void Listele()
        {
            var list = ((IstasyonOperasyonBilgileriBll)Bll).ReceteList(x => ListeDisiTutulacakKayitlar.Contains(x.OperasyonId) && x.Id != 0);

            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }

    }
}
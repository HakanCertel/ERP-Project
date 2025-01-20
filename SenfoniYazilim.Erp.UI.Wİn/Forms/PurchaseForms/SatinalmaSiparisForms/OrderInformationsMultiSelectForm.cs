using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Common.Message;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SiparisForms
{
    public partial class OrderInformationsMultiSelectForm : BaseListForm
    {
        private readonly bool _isTakenToProcess;

        public OrderInformationsMultiSelectForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new ProductionDemandInformationsBll();
            HideItems = new BarItem[]
            {
                btnYeni,btnSil,btnKaydet,
                btnDuzelt, barDelete, barDeleteAciklama, barYeni, barYeniAciklama, barDuzelt, barDuzeltAciklama
            };

            _isTakenToProcess = (bool)prm[0];
        }
        protected override void DegiskenleriDoldur()
        {   
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {

            var list = ((ProductionDemandInformationsBll)Bll).DemandInformationsList(x => !ListeDisiTutulacakKayitlar.Contains(x.StockId) && x.IsTakenToProcess == _isTakenToProcess);

            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");

        }
    }
}
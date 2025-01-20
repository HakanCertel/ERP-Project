using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Message;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms
{
    public partial class OperasyonaBagliTuketilecekReceteBilesenleriList : BaseListForm
    {
        public OperasyonaBagliTuketilecekReceteBilesenleriList()
        {
            InitializeComponent();

            Bll = new ReceteBilgileriBll();
            HideItems = new BarItem[]
            {
                btnYeni,btnSil,btnKaydet,
                btnDuzelt, barDelete, barDeleteAciklama, barYeni, barYeniAciklama, barDuzelt, barDuzeltAciklama
            };
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {

            var list = ((ReceteBilgileriBll)Bll).ListReceteBilesenleri(x => ListeDisiTutulacakKayitlar.Contains(x.Id));

            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");

        }
    }
}
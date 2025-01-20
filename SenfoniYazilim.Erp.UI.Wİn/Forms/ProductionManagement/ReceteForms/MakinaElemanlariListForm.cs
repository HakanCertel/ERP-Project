using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using DevExpress.XtraBars;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms
{
    public partial class MakinaElemanlariListForm : BaseListForm
    {
        public MakinaElemanlariListForm()
        {
            InitializeComponent();
            Bll = new Makina_MakinaElemenlari_BilgileriBll();
            HideItems = new BarItem[] { btnYeni, btnSil, btnDuzelt, btnYeni, btnFiltrele, btnYazdir, btnGonder };
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {
            var list = ((Makina_MakinaElemenlari_BilgileriBll)Bll).ReceteMakinaElemeanlariList(x => ListeDisiTutulacakKayitlar.Contains(x.MakinaId) && ListeDisiTutulacakKayitlar.Contains(x.MakinaId) && x.Id != 0);

            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }

    }
}
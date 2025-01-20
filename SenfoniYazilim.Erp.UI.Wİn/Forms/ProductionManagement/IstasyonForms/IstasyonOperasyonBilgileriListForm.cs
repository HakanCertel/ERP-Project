using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.IstasyonForms
{
    public partial class IstasyonOperasyonBilgileriListForm : BaseListForm
    {
        private readonly long _istasyond;
        private readonly string _formTabloCaption;

        public IstasyonOperasyonBilgileriListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new IstasyonOperasyonBilgileriBll();
            HideItems = new BarItem[]
            {
                btnYeni,btnSil,btnKaydet,
                btnDuzelt, barDelete, barDeleteAciklama, barYeni, barYeniAciklama, barDuzelt, barDuzeltAciklama
            };
            _istasyond = (long)prm[0];
            _formTabloCaption = prm[1].ToString();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Tablo.ViewCaption = _formTabloCaption + " İstasyonuna Ait " + Tablo.ViewCaption;
            Navigator = longNavigator.Navigator;
            Text= Tablo.ViewCaption;
        }
        protected override void Listele()
        {

            var list = ((IstasyonOperasyonBilgileriBll)Bll).OperasyonMakinaList(x=>x.IstasyonId==_istasyond);

            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");

        }
    }
}
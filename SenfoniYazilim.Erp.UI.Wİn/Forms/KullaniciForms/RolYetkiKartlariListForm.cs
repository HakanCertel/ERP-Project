using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.KullaniciForms
{
    public partial class RolYetkiKartlariListForm : BaseListForm
    {
        public RolYetkiKartlariListForm()
        {
            InitializeComponent();

            HideItems = new BarItem[] 
            {
                btnYeni, btnSil, btnDuzelt, btnKolonlar, barYeni, barYeniAciklama, barDelete, barDeleteAciklama,
                barDuzelt, barDuzeltAciklama, barKolonlar, barKolonlarAciklama
            };
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Yetki;
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            var enumList = Enum.GetValues(typeof(KartTuru)).Cast<KartTuru>().ToList();
            var liste = new List<RolYetki>();

            enumList.ForEach(x =>
            {
                var entity = new RolYetki
                {
                    KartTuru = x
                };
                liste.Add(entity);
            });
            var list = liste.Where(x=>!ListeDisiTutulacakKayitlar.Contains((long)x.KartTuru)).OrderBy(x=>x.KartTuru.toName());

            Tablo.GridControl.DataSource = list;
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");

            //Tablo.GridControl.DataSource = ((AileBilgiBll)Bll).List(FilterFunctions.Filter<AileBilgi>(AktifKartlariGoster));
        }
    }
}
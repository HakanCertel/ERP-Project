using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.MrpForms
{
    public partial class MrpRezervasyonSecimList : BaseListForm
    {
        private readonly List<MrpMalzemeIhtiyacBilgileriL> _source;

        public MrpRezervasyonSecimList()
        {
            InitializeComponent();
            Bll = new RezervasyonBilgileriBll();
            HideItems = new BarItem[] { btnYeni, btnSil, btnDuzelt, btnYeni, btnFiltrele, btnYazdir };
        }
        public MrpRezervasyonSecimList(params object[] prm):this()
        {
            _source = (List<MrpMalzemeIhtiyacBilgileriL>)prm[0];
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            ListeDisiTutulacakKayitlar = _source.Select(x => x.StokId).ToList();

            var list = ((RezervasyonBilgileriBll)Bll).List(x => ListeDisiTutulacakKayitlar.Contains(x.MaterialId) && x.Id != 0).Cast<RezervasyonBilgileriL>().ToList();
            foreach (var item in list)
            {
                var entity=_source.Where(x => x.StokId == item.MaterialId).FirstOrDefault();
                if (entity == null) continue;
                item.OwnerFromCode = entity.MrpKodu;
                //item.BagliOlduguUrunKodu = entity.BagliOlduguUstReceteKodu;
                //item.BagliOlduguUrunAdi = entity.BagliOlduguUstReceteKodu;
                
            }
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }
    }
}
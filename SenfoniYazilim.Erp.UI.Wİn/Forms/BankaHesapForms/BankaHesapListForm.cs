using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.BankaHesapForms
{
    public partial class BankaHesapListForm : BaseListForm
    {
        private readonly Expression<Func<BankaHesap, bool>> _filter;
        private readonly BankaHesapTuru _hesapTuru = BankaHesapTuru.VadesizMevduatHesabi;
        private readonly long _bankId;
        public BankaHesapListForm()
        {
            InitializeComponent();

            Bll = new BankaHesapBll();

            _filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId;
        }

        public BankaHesapListForm(params object[] prm) : this()
        {
            if (prm[0].GetType() == typeof(BankaHesapTuru))
            {
                _hesapTuru = (BankaHesapTuru)prm[0];
                _filter = x => x.Durum == AktifKartlariGoster && x.Id == _bankId;
            }
            else if (prm[0].GetType() == typeof(long))
            {
                _bankId = (long)prm[0];
                _filter = x => x.Durum == AktifKartlariGoster && x.HesapTuru == _hesapTuru && x.SubeId == AnaForm.SubeId;
            }
            else if (prm[0].GetType() == typeof(OdemeTipi))
            {
                var odemeTipi = (OdemeTipi)prm[0];

                switch (odemeTipi)
                {
                    case OdemeTipi.EPos:
                        _hesapTuru = BankaHesapTuru.EPosBlokeHesabi;
                        break;
                    case OdemeTipi.Ots:
                        _hesapTuru = BankaHesapTuru.OtsBlokeHesabi;
                        break;
                    case OdemeTipi.Pos:
                        _hesapTuru = BankaHesapTuru.PosBlokeHesabi;
                        break;
                }
                _filter = x => x.Durum == AktifKartlariGoster && x.HesapTuru == _hesapTuru && x.SubeId == AnaForm.SubeId;
            }
            //_filter = x => x.Durum == AktifKartlariGoster &&x.HesapTuru==_hesapTuru&& x.SubeId == AnaForm.SubeId;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.BankaHesap;
            FormShow = new ShowEditForms<BankaHesapEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaHesapBll)Bll).List(_filter);
        }
    }
}
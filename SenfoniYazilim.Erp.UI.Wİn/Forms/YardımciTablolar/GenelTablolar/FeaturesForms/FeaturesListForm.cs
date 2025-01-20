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
using System.Linq.Expressions;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Common.Enums;
using DevExpress.XtraBars;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.FeaturesForms
{
    public partial class FeaturesListForm : BaseListForm
    {
        private readonly Expression<Func<Features, bool>> _filter;

        private KartTuru _kartTuru;
        public int _definationId { get; set; }

        public FeaturesListForm()
        {
            InitializeComponent();
            Bll = new FeaturesBll();
            HideItems = new BarItem[] { btnSil,btnYeni,btnDuzelt,btnChangeBaseStatus,btnGonder
                                        ,btnCloseItem,btnCancel,btnActive,btnYazdir };
            ShowItems = new BarItem[] { btnSec };
            _filter = x => x.IsActive;
        }
        public FeaturesListForm(params object[] prm):this()
        {
            if (prm[0] != null && prm[1] != null)
            {
                _kartTuru = (KartTuru)prm[1];
                _definationId = (int)prm[0];
                _filter = x => x.KartTuru == _kartTuru && x.DefinationId == _definationId && x.IsActive;

            }
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Country;
            //FormShow = new ShowEditForms<CountryEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            var list = ((FeaturesBll)Bll).List(_filter);

            Tablo.GridControl.DataSource = list;
        }
    }
}
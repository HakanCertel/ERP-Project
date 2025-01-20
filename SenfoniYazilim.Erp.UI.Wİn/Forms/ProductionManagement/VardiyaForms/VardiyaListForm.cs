using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.VardiyaForms
{
    public partial class VardiyaListForm : BaseListForm
    {
        public VardiyaListForm()
        {
            InitializeComponent();

            Bll = new VardiyaBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            BaseKartTuru = KartTuru.Vardiya;
            FormShow = new ShowEditForms<VardiyaLastVersionEditFrom>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((VardiyaBll)Bll).List(FilterFunctions.Filter<Vardiya>(AktifKartlariGoster));
        }
    }
}
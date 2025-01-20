using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.RezervasyonForms
{
    public partial class RezervasyonListForm : BaseListForm
    {
        public RezervasyonListForm()
        {
            InitializeComponent();
            Bll = new RezervasyonBilgileriBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            //FormShow =new ShowEditForms<RezervasyonEditForm>();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((RezervasyonBilgileriBll)Bll).List(null);
        }
        protected override void ShowEditForm(long id)
        {
            //base.ShowEditForm(id);
        }
    }
}
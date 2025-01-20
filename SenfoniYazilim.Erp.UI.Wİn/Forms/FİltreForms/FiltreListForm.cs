using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraGrid;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.FİltreForms
{
    public partial class FiltreListForm : BaseListForm
    {
        private readonly KartTuru _filtreKartTuru;//
        private readonly GridControl _filtreGrid;

        public FiltreListForm(params object[] prm)
        {
            
            InitializeComponent();
            Bll = new FiltreBll();

            _filtreKartTuru =(KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];

            HideItems = new DevExpress.XtraBars.BarItem[] {btnFiltrele,btnKolonlar,btnYazdir,btnGonder,barFiltrele,barFiltreleAciklama,barKolonlar,barKolonlarAciklama,barYazdir,barYazdirAciklama,barGonder,barGonderAciklama };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Filtre;
            //FormShow = new ShowEditForms<OkulEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((FiltreBll)Bll).List(x=> x.KartTuru==_filtreKartTuru);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<FiltreEditForm>.ShowDialogForm(KartTuru.Filtre, id,_filtreKartTuru, _filtreGrid);
            ShowEditFormDefault(result);
        }
    }
}
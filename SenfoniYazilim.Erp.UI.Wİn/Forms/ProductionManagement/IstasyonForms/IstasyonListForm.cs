using DevExpress.XtraGrid.Views.Base;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.IstasyonForms
{
    public partial class IstasyonListForm : BaseListForm
    {
        public IstasyonListForm()
        {
            InitializeComponent();

            Bll = new IstasyonBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Istasyon;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<IstasyonEditForm>();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IstasyonBll)Bll).List(FilterFunctions.Filter<Istasyon>(AktifKartlariGoster));
        }
        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);
            //aşağıdaki yapı BaseList deki cellvaluechanged olayına tetiklemekte ve bu olay MalzemeihtiyaçListForm da
            //BasehareketEntity olarak tanımlanmış olan tablo bilgisi için düzenlenmiştir fakat burada işlem yaptığımız
            //BaseEntity türüdür ve tür dönüşümü sağlanamamaktadır...bu yüzden deüzeltene kadar iptal edilmiştir..
            TabloLoaded = false;

            if (e.FocusedColumn==colVardiyaSistemAdi)
                e.FocusedColumn.Sec(tablo, null, repositoryButtonVardiya, colVardiyaId);
        }
    }
}
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.Bll.General.ProductionManangmentBll.UretimSonuKayitSurecBll;
using SenfoniYazilim.Erp.Model.Dto.ProductionManagmentDto.UretimSonuKayitDto;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.CRPForms.IsEmriForms;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms
{
    public partial class UretimSonuKayitListForm : BaseListForm
    {
        public UretimSonuKayitListForm()
        {
            InitializeComponent();

            Bll = new UretimSonuKayitBll();

           // HideItems = new BarItem[] { btnYeni};
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            BaseKartTuru = KartTuru.UretimSonuKayit;
            FormShow = new ShowEditForms<UretimSonuKayitEditForm>();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((UretimSonuKayitBll)Bll).List(null).EntityListConvert<UretimSonuKayitL>();
        }
    }
}
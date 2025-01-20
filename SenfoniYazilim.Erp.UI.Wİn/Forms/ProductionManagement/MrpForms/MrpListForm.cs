using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.ProductionManagmentEntites.MrpEntites;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms
{
    public partial class MrpListForm : BaseListForm
    {
        public MrpListForm()
        {
            InitializeComponent();
            Bll = new MrpBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Mrp;
            FormShow = new ShowEditForms<MrpEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MrpBll)Bll).List(FilterFunctions.Filter<Mrp>(AktifKartlariGoster));
        }

        protected override void ShowEditForm(long id)
        {
            //base.ShowEditForm(id);
            if (id < 0)
            {
                ShowEditForms<MrpEditForm>.ShowForm(KartTuru.Mrp, id);
                return;
            }
            else
            {
                var entity = Tablo.GetRow<Mrp>();
                if (entity == null) return;
                ShowEditForms<MrpEditForm>.ShowForm(KartTuru.Mrp, entity.Id);
            }
        }
    }
}
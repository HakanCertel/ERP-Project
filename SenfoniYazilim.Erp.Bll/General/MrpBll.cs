using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.ProductionManagmentEntites.MrpEntites;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class MrpBll : BaseGenelBll<Mrp>, IBaseCommonBll, IBaseGenelBll
    {
        public MrpBll() : base(KartTuru.Mrp){}

        public MrpBll(Control ctrl) : base(ctrl, KartTuru.Mrp){}
    }
}

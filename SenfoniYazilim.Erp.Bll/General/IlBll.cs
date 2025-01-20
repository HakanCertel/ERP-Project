using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Model.Entities;
using System.Windows.Forms;
using SenfoniYazilim.Erp.Common.Enums;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class IlBll:BaseGenelBll<Il>,IBaseGenelBll,IBaseCommonBll
    {
        public IlBll():base(KartTuru.Il) { }
        public IlBll(Control ctrl):base(ctrl,KartTuru.Il) { }
    }
}

using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class RolBll : BaseGenelBll<Rol>, IBaseGenelBll, IBaseCommonBll
    {
        public RolBll() : base(KartTuru.Rol) { }

        public RolBll(Control ctrl) : base(ctrl,KartTuru.Rol) { }
    }
}
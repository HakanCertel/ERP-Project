using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class VardiyaLastVersionBll : BaseGenelBll<VardiyaLastVersion>, IBaseGenelBll, IBaseCommonBll
    {
        public VardiyaLastVersionBll() : base(KartTuru.Vardiya) { }

        public VardiyaLastVersionBll(Control ctrl) : base(ctrl, KartTuru.Vardiya) { }

    }
}

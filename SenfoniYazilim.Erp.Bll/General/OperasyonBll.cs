using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class OperasyonBll : BaseGenelBll<Operasyon>, IBaseGenelBll, IBaseCommonBll
    {
        public OperasyonBll() : base(KartTuru.Operasyon){}

        public OperasyonBll(Control ctrl) : base(ctrl, KartTuru.Operasyon){}
    }
}

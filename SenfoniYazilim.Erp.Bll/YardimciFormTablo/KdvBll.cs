using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.YardimciFormTablo
{
    public class KdvBll : BaseGenelBll<Kdv>, IBaseGenelBll, IBaseCommonBll
    {
        public KdvBll() : base(KartTuru.Kdv) { }

        public KdvBll(Control ctrl) : base(ctrl, KartTuru.Kdv) { }
    }
}

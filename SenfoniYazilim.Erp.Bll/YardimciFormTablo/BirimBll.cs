using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.YardimciFormTablo
{
    public class BirimBll : BaseGenelBll<Birim>, IBaseGenelBll, IBaseCommonBll
    {
        public BirimBll() : base(KartTuru.Birim) { }

        public BirimBll(Control ctrl) : base(ctrl, KartTuru.Birim) { }
    }
}

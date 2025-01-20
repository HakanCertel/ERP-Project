using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class YabanciDilBll : BaseGenelBll<YabanciDil>, IBaseGenelBll, IBaseCommonBll
    {
        public YabanciDilBll() : base(KartTuru.YabanciDil){ }

        public YabanciDilBll(Control ctrl) : base(ctrl, KartTuru.YabanciDil){ }
    }
}

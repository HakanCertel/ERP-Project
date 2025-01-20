using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class KontenjanBll : BaseGenelBll<Kontenjan>, IBaseGenelBll, IBaseCommonBll
    {
        public KontenjanBll() : base(KartTuru.Kontenjan){ }

        public KontenjanBll(Control ctrl) : base(ctrl,KartTuru.Kontenjan){ }
    }
}

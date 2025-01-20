using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class EvrakBll : BaseGenelBll<Evrak>, IBaseGenelBll, IBaseCommonBll
    {
        public EvrakBll() : base(KartTuru.Evrak) { }

        public EvrakBll(Control ctrl) : base(ctrl,KartTuru.Evrak) { }

    }
}

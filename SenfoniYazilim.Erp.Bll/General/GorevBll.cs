using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class GorevBll : BaseGenelBll<Gorev>, IBaseGenelBll, IBaseCommonBll
    {
        public GorevBll() : base(KartTuru.Gorev){}

        public GorevBll(Control ctrl) : base(ctrl, KartTuru.Gorev){}
    }
}

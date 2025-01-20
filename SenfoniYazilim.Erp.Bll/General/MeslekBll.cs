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
    public class MeslekBll : BaseGenelBll<Meslek>, IBaseGenelBll, IBaseCommonBll
    {
        public MeslekBll() : base(KartTuru.Meslek){ }

        public MeslekBll(Control ctrl) : base(ctrl, KartTuru.Meslek){}
    }
}

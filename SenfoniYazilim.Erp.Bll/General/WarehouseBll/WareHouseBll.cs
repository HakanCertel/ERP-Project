using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class WareHouseBll : BaseGenelBll<WareHouse>, IBaseGenelBll, IBaseCommonBll
    {
        public WareHouseBll() : base(KartTuru.Depo){}

        public WareHouseBll(Control ctrl) : base(ctrl, KartTuru.Depo){}
        
    }
}

using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class BankaSubeBll : BaseGenelBll<BankaSube>,IBaseCommonBll
    {
        public BankaSubeBll() : base(KartTuru.BankaSube){}

        public BankaSubeBll(Control ctrl) : base(ctrl, KartTuru.BankaSube){}
    }
}

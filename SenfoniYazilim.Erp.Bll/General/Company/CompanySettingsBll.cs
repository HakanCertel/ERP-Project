using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Company.CompanySetting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General.Company
{
    public class CompanySettingsBll : BaseGenelBll<CompanySettings>, IBaseGenelBll, IBaseCommonBll
    {
        public CompanySettingsBll() : base(KartTuru.Cari) { }

        public CompanySettingsBll(Control ctrl) : base(ctrl, KartTuru.Cari) { }
    }
}

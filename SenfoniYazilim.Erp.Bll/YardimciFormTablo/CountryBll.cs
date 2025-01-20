using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.YardimciFormTablo
{
    public class CountryBll : BaseGenelBll<Country>, IBaseGenelBll, IBaseCommonBll
    {
        public CountryBll() : base(KartTuru.Country) { }
        public CountryBll(Control ctrl) : base(ctrl, KartTuru.Country) { }
    }
}

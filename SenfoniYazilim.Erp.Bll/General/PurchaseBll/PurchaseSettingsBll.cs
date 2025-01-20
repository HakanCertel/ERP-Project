using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Satınalma.PurchaseSettingsEntites;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General.PurchaseBll
{
    public class PurchaseSettingsBll : BaseGenelBll<PurchaseSettings>, IBaseGenelBll, IBaseCommonBll
    {
        public PurchaseSettingsBll():base(KartTuru.PurchaseSettings){}

        public PurchaseSettingsBll(Control ctrl):base(ctrl,KartTuru.PurchaseSettings) { }
    }
}

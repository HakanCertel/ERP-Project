using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.YardimciFormTablo
{
    public class SevkiyatSekliBll : BaseGenelBll<SevkiyatSekilleri>, IBaseGenelBll, IBaseCommonBll
    {
        public SevkiyatSekliBll() : base(KartTuru.SevkiyatSekli) { }

        public SevkiyatSekliBll(Control ctrl) : base(ctrl, KartTuru.SevkiyatSekli) { }
    }
}

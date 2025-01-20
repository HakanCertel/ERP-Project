using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Model.Entities;
using System.Windows.Forms;
using SenfoniYazilim.Erp.Common.Enums;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class IlceBll:BaseGenelBll<Ilce>, IBaseCommonBll
    {
        public IlceBll():base(KartTuru.Ilce) { }
        public IlceBll(Control ctrl) : base(ctrl,KartTuru.Ilce) { }
    }
}

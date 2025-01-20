using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class IndirimTuruBll : BaseGenelBll<IndirimTuru>, IBaseGenelBll, IBaseCommonBll
    {
        public IndirimTuruBll() : base(KartTuru.IndirimTuru){}

        public IndirimTuruBll(Control ctrl) : base(ctrl, KartTuru.IndirimTuru){}
    }
}

using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class ServisBll : BaseGenelBll<Servis>, IBaseGenelBll
    {
        public ServisBll() : base(KartTuru.Servis){}

        public ServisBll(Control ctrl) : base(ctrl, KartTuru.Servis){}
    }
}

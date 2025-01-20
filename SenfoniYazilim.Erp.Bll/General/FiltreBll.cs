using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Model.Entities;
using System.Windows.Forms;
using SenfoniYazilim.Erp.Common.Enums;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class FiltreBll : BaseGenelBll<Filtre>, IBaseCommonBll
    {
        public FiltreBll(): base(KartTuru.Filtre){ }
        public FiltreBll(Control ctrl) : base(ctrl, KartTuru.Filtre) { }
    }
}

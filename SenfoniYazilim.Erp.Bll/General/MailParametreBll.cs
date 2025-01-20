using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Model.Entities;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class MailParametreBll : BaseGenelBll<MailParametre>, IBaseGenelBll, IBaseCommonBll
    {
        public MailParametreBll() { }

        public MailParametreBll(Control ctrl) : base(ctrl) { }
    }
}
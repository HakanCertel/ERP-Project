using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class KurumBilgileriBll : BaseGenelBll<KurumBilgileri>, IBaseGenelBll, IBaseCommonBll
    {

        public KurumBilgileriBll(Control ctrl) : base(ctrl) { }

        public override BaseEntity Single(Expression<Func<KurumBilgileri, bool>> filter)
        {
            return BaseSingle(filter, x => new KurumBilgileriS
            {
                Id = x.Id,
                Kod = x.Kod,
                KurumAdi=x.KurumAdi,
                VergiDairesi=x.VergiDairesi,
                VergiNo=x.VergiNo,
                IlId=x.IlId,
                IlAdi=x.Il.IlAdi,
                IlceId=x.IlceId,
                IlceAdi=x.Ilce.IlceAdi,
            });
        }
    }
}

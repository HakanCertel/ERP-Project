using SenfoniYazilim.Erp.Model.Entities.Base;
using System.Collections.Generic;

namespace SenfoniYazilim.Erp.Bll.Interfaces
{
    public interface IBaseHareketGenelBll
    {
        bool Insert(IList<BaseHareketEntity> entities);
        bool Update(IList<BaseHareketEntity> entities);
        bool Delete(IList<BaseHareketEntity> entities);
    }
}

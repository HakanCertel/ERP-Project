using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.Interfaces
{
    public interface IBaseGenelBll
    {
        bool Insert(BaseEntity entity);
        bool Update(BaseEntity oldEntity, BaseEntity currentEntity);
        bool Update(BaseEntity currentEntity);
        string YeniKodVer();
    }
}

using SenfoniYazilim.Dal.Interfaces;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.Base
{
    public class BaseHareketBll<T, TContext> : IBaseBll,IBaseHareketGenelBll where T : BaseHareketEntity where TContext : DbContext
    {
        private IUnitOfWork<T> _uow;

        public  TResult BaseSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Find(filter, selector);
        }
        public IQueryable<TResult> List<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Select(filter, selector);
        }

        public virtual bool InsertSingle(BaseHareketEntity entity)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            _uow.Rep.Insert(entity.EntityCovert<T>());
            return _uow.Save();
        }

        public virtual bool Insert(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            _uow.Rep.Insert(entities.EntityListConvert<T>());
            return _uow.Save();
        }

        public virtual bool Update(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            _uow.Rep.Update(entities.EntityListConvert<T>());
            return _uow.Save();
        }
        //silme işlemi gerçekleştirilirken bir mesaj box açılacak ve bu mesaj box, silinmek istenen entity nin hangisi olduğunu
        //bulup mesaj box a o entity nin adını yazmak için KartTuru adında, common dll sinde bir Enum tanımlayacağız.
        public virtual bool Delete(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            _uow.Rep.Delete(entities.EntityListConvert<T>());
            return _uow.Save();
        }
        //public int Count(Expression<Func<T, bool>> filter)
        //{
        //    GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
        //    return _uow.Rep.Count(filter);
        //}
        public string BaseYeniKodVer(KartTuru kartTuru, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.YeniKodVer(kartTuru, filter, where);
        }
        public string BaseYeniKodVer(string kodTanimlayici, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.YeniKodVer(kodTanimlayici,filter,where);
        }
        #region IDisposable Support

        public void Dispose()
        {
            _uow?.Dispose();

        }
        #endregion

    }
}

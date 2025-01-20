using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.Functions
{
    public  class InstanceBaseEntityBll<T> where T : BaseEntity 
    {
        public static TResult SingleBaseEntity<TResult,TBll>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector) where TBll : BaseGenelBll<T>
        {
            using (var bll = (TBll)Activator.CreateInstance(typeof(TBll)))
            {
                //var sdlk = (TResult)bll.Single(filter);
                var entity= bll.SingleWithSelector(filter, selector);
                return entity;
            }
        }
        public static IEnumerable<T> ListBaseEntity<TBll>(Expression<Func<T, bool>> filter) where TBll : BaseGenelBll<T>
        {
            using (var bll = (TBll)Activator.CreateInstance(typeof(TBll)))
            {
                var entities= bll.List(filter)?.ToList()?.EntityListConvert<T>();
                return entities;
            }
        }
    }
    public class InstanceBaseHareketEntityBll<T, TBll> where T : BaseHareketEntity where TBll : BaseHareketBll<T, SenfoniErpContext>
    {
        public static TResult SingleBaseHareketEntity<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            using (var bll = (TBll)Activator.CreateInstance(typeof(TBll)))
            {
                return (TResult)bll.BaseSingle(filter, selector);
            }
        }
        public static IEnumerable<TResult> ListBaseHareketEntity<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            using (var bll = (TBll)Activator.CreateInstance(typeof(TBll)))
            {
                return bll.List(filter, selector)?.Cast<T>()?.EntityListConvert<TResult>();
            }
        }
        public static bool InsertEntities(List<BaseHareketEntity> items)
        {
            using (var bll = (TBll)Activator.CreateInstance(typeof(TBll)))
            {
                return bll.Insert(items);
            }
        }
        public static bool UpdateEntities(List<BaseHareketEntity> items)
        {
            using (var bll = (TBll)Activator.CreateInstance(typeof(TBll)))
            {
                return bll.Update(items);
            }
        }
        public static bool DeleteEntites(List<BaseHareketEntity> items)
        {
            using (var bll = (TBll)Activator.CreateInstance(typeof(TBll)))
            {
                return bll.Delete(items);
            }
        }
        //public static int Count(Expression<Func<T,bool>> filter)
        //{
        //    using (var bll = (TBll)Activator.CreateInstance(typeof(TBll)))
        //    {
        //        return bll.Count(filter);
        //    }
        //}
    }
    
}

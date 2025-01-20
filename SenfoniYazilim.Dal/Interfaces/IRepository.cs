using SenfoniYazilim.Erp.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SenfoniYazilim.Dal.Interfaces
{
    public interface IRepository<T>:IDisposable where T:class
    {
        void Insert(T entity);
        void Insert(IEnumerable<T> entities);//bu liste olarak gelebilecek olan kayıtları kaydetmek için kullanılır..
        void Update(T entity);
        void Update(T entity, IEnumerable<string> fields);//bu update işlemini,değişen alan isimleri gönderilerek, sadece değişen alnlar üzerinden gerçekleştirecektir
        void Update(IEnumerable<T> entities);//birden fazla veri gönderilerek güncelleme işlemi yapar..
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        //Expression<Func<T, bool>> filter ifadesi T türünde bir sorgu göndereceğiz ve eğer bu doğru ise,
        //yapılan sorgulamaya bağlı bir değer döndürür, 
        //hangi tipte veri döndereceğini ise Expression<Func<T,TResult>> selector ifadesi ile
        //T tipinde bir değer gönderilmiş olur ve TResult tipinde bir değer dönderilmiş olur ve ismide
        //selector olacaktır...
        TResult Find<TResult>(Expression<Func<T, bool>> filter,Expression<Func<T,TResult>> selector);
        Task< TResult> FindAsync<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);

        //IQueryable bize bir değer döndürmez, sadece string tipinde bir sorgu döndürür,bu sorgu alınır ve toList
        //ile bir değere dönüştürülür...
        IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);
        Task<IList<TResult>> SelectAsync<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);

        int Count(Expression<Func<T,bool>> filter=null);

        string YeniKodVer(KartTuru kartTuru, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null);
        string YeniKodVer(string kodTanimlayici, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null);

    }
}

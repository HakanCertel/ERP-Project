using SenfoniYazilim.Dal.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Dal.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //readonly olarak değişkenlere değer atanamaz sadece okunabilirdir,
        //iki şekide değer atanabilir;birincisi değişken oluşturulurken,ikincisi
        //sınıfa ait contsractor da değer atanabilir..
        private readonly DbContext _context;//_context database imizi temsil etmeketedir.
        private readonly DbSet<T> _dbSet;//_dbSet tablolarımızı temsil eden bir değişkendir..
        public Repository(DbContext context)
        {
            if (context == null) return;
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Insert(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Insert(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Update(T entity, IEnumerable<string> fields)
        {
            _dbSet.Attach(entity);//verilen entity yani tablo ile işlem yapacağımızı belirtmiş oluruz.
            var entry = _context.Entry(entity);
            //bize parametre olarak gönderilen fields lar arasında dolaşılarak sadece gönderilmiş olan
            //alanlarla ilgili değişiklikler yapılacak..
            foreach (var field in fields)
            {
                entry.Property(field).IsModified = true;
            }
        }
        public void Update(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {                
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Delete(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }
        }

        public TResult Find<TResult>(Expression<Func<T, bool>> filter,Expression<Func<T,TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector).FirstOrDefault() :_dbSet.Where(filter).Select(selector).FirstOrDefault();
        }
        //bu metod birdeğer değil ,bir sql kodu dödürecektir. bu ise rapor hazırlarken dödürülen bu koda müdahale ederek sorgular
        //istediğimiz şekilde güncellememize olanak verecektir...
        public IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter,Expression<Func<T,TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector) : _dbSet.Where(filter).Select(selector);
        }

        public int Count(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _dbSet.Count() : _dbSet.Count(filter);
        }

        public string YeniKodVer(KartTuru kartTuru, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null)
        {
            string Kod()//bu metod işlem yaptığımız tabloda veri yoksa bu metod çalışarak ilk kodu verecektir.....
            {
                string kod = null;
                var kodDizi = kartTuru.toName().Split(' ');//bu ifade,string ifade içinde, diziyi herboşluk sonrası kaç adet ifade olamasına göre ayıracak

                for (int i = 0; i < kodDizi.Length-1; i++)
                {
                    kod += kodDizi[i];

                    if (i + 1 < kodDizi.Length - 1)
                        kod += " ";
                }

                return kod += "-0001";
            }

            string YeniKodVer(string kod)
            {
                var sayisalDegerler = "";

                foreach (var karakter in kod)
                {
                    if (char.IsDigit(karakter))
                        sayisalDegerler += karakter;
                    else
                        sayisalDegerler = "";
                }

                var artisSonrasiDeger = (int.Parse(sayisalDegerler) + 1).ToString();
                var fark = kod.Length - artisSonrasiDeger.Length;
                if (fark < 0)
                    fark = 0;

                var yeniDeger = kod.Substring(0, fark);
                yeniDeger += artisSonrasiDeger;
                return yeniDeger;

            }

            var maxKod = where == null ? _dbSet.Max(filter) : _dbSet.Where(where).Max(filter);
            return maxKod == null ? Kod() : YeniKodVer(maxKod);
        }

        public string YeniKodVer(string kodTanimlayici, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null)
        {
            string Kod()//bu metod işlem yaptığımız tabloda veri yoksa bu metod çalışarak ilk kodu verecektir.....
            {
                string kod = null;
                var kodDizi = kodTanimlayici.Split(' ');//bu ifade,string ifade içinde, diziyi herboşluk sonrası kaç adet ifade olamasına göre ayıracak

                for (int i = 0; i < kodDizi.Length; i++)
                {
                    kod += kodDizi[i];

                    if (i + 1 < kodDizi.Length - 1)
                        kod += " ";
                }

                return kod += "000000001";
            }

            string YeniKodVer(string kod)
            {
                var sayisalDegerler = "";

                foreach (var karakter in kod)
                {
                    if (char.IsDigit(karakter))
                        sayisalDegerler += karakter;
                    else
                        sayisalDegerler = "";
                }

                var artisSonrasiDeger = (int.Parse(sayisalDegerler) + 1).ToString();
                var fark = kod.Length - artisSonrasiDeger.Length;
                if (fark < 0)
                    fark = 0;

                var yeniDeger = kod.Substring(0, fark);
                yeniDeger += artisSonrasiDeger;
                return yeniDeger;

            }

            var maxKod = where == null ? _dbSet.Max(filter) : _dbSet.Where(where).Max(filter);
            return maxKod == null ? Kod() : YeniKodVer(maxKod);
        }

        public System.Threading.Tasks.Task<TResult> FindAsync<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<IList<TResult>> SelectAsync<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            throw new NotImplementedException();
        }

        #region Dispose

        private bool _disposedValue = false; // Artık çağrıları algılama

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        #endregion
    }
}

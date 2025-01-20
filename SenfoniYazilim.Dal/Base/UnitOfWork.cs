using SenfoniYazilim.Dal.Interfaces;
using SenfoniYazilim.Erp.Common.Message;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;

namespace SenfoniYazilim.Dal.Base
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DbContext _context;
        public UnitOfWork(DbContext context)
        {
            if (context == null) return;
            _context = context;
        }
        public IRepository<T> Rep => new Repository<T>(_context);

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                var sqlEx = (SqlException)ex.InnerException?.InnerException;
                if (sqlEx == null)
                {
                    Messages.HataMesaji(ex.Message);
                    return false;
                }
                switch (sqlEx.Number)
                {
                    case 208:
                        Messages.HataMesaji("İşlem Yapmak İstediğiniz Tablo Veritabanında Bulunamadı.");
                        break;
                    case 547:
                        Messages.HataMesaji(sqlEx.Message/*"Seçilen Kartın İşlem Görmüş Hareketleri Var, Kart Silinemez."*/);
                        break;
                    case 2601:
                    case 2627:
                        Messages.HataMesaji("Girmiş olduğunuz Id Daha Önce Kullanılmıştır.");
                        break;
                    case 4060:
                        Messages.HataMesaji("İşlem Yapmak İstediğiniz Veritabanı Sunucuda Bulunamadı.");
                        break;
                    case 18456:
                        Messages.HataMesaji("Server'a bağlanılmak İstenen Kullanıcı Adı ve Şifre Hatalıdır.");
                        break;
                    default:
                        Messages.HataMesaji(sqlEx.Message);
                        break;
                }
                return false;


            }
            catch (DbEntityValidationException ex)
            {
                foreach (var item in ex.EntityValidationErrors)
                {
                    var strg = "entitiy of type" + item.Entry.Entity.GetType().Name + ", in state " + item.Entry.State + "has the fallowing validation error";
                    Messages.HataMesaji(strg);
                    foreach (var ve in item.ValidationErrors)
                    {
                        var strg1 = "propert" + ve.PropertyName + "error" + ve.ErrorMessage;
                        Messages.HataMesaji(strg1);
                    }

                }
                
            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }
            return true;
        }

        #region Dispose
        private bool _disposedValue = false; 

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

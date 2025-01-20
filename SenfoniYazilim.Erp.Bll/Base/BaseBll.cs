using SenfoniYazilim.Dal.Interfaces;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.Base
{
    public class BaseBll<T,TContext> : IBaseBll where T:BaseEntity where TContext:DbContext
    {
        private readonly Control _ctrl;
        private IUnitOfWork<T> _uow;
        private bool Validation(IslemTuru islemTuru,BaseEntity oldEntity,BaseEntity currentEntity,Expression<Func<T,bool>> filter)
        {
            
            var errorControl = GetValidationErrorControl();
            
            if (errorControl == null) return true;            
            _ctrl.Controls[errorControl].Focus();
            return false;
            
            string GetValidationErrorControl()
            {
                string MukerrerKod()
                {
                    foreach (var property in typeof(T).GetPropertyAtributesFromType<Kod>())
                    {
                        if (property.Attribute == null) { continue; }
                        if ((islemTuru == IslemTuru.EntityInsert || oldEntity.Kod == currentEntity.Kod) && islemTuru == IslemTuru.EntityUpdate) { continue; }
                        if (_uow.Rep.Count(filter) < 1) { continue; }

                        Messages.MukerrerKayitHataMesaji(property.Attribute.Description);
                        return property.Attribute.ControlName;
                    }

                    return null;
                }

                string HataliGiris()
                {
                    foreach (var property in typeof(T).GetPropertyAtributesFromType<ZorunluAlan>())
                    {
                        if (property.Attribute == null) continue;

                        var value = property.Property.GetValue(currentEntity);

                        if (property.Property.PropertyType == typeof(long))
                            if ((long)value == 0) value = null;
                        if (!string.IsNullOrEmpty(value?.ToString())) continue;

                        Messages.HataliVeriMesaji(property.Attribute.Description);
                        
                        return property.Attribute.ControlName;
                    }

                    return null;
                }

                return HataliGiris() ?? MukerrerKod();
            }

        }

        // erişim belirleyicisinin protected olarak tanımlanma nedeni,bu constractor lara sadece,
        //bu sınıfı inherit eden sınıflar tarafından erişilmesi istenmektedir..
        protected BaseBll() { }

        protected BaseBll(Control ctrl )
        {
            _ctrl = ctrl;
        }
        // TResult T tipinde bir değer alacak ve geriye TResult döndürecek yani bu da T tipinde bir değer olacak
        //ve T de sınıf oluşturulurken jenerik tipin bir BaseEntity olacağı belirtildiği için,nihayetinde
        //TResult bir BaseEntity olacak..
        protected TResult BaseSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            //burada UnitOfWork e ait bir _uow değişkeni oluşturuldu fakat, bunun bir instance si oluşturulmadığı yani new lenmediği
            //için _uow.rep.Find ile bir işlem yapılamayacak hata oluşacaktır.UnitOfWor ün bir örneğini oluşturmak için aşağıdaki kod
            //yazılmalıdır.önce generalfunction adında bir sınıf oluşturulacak,
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Find(filter, selector);
        }

        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<T,bool>> filter,Expression<Func<T,TResult>> selector)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Select(filter, selector);
        }

        protected bool BaseInsert(BaseEntity entity,Expression<Func<T,bool>> filter)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            if (!Validation(IslemTuru.EntityInsert, null, entity, filter)) return false;
            _uow.Rep.Insert(entity.EntityCovert<T>());
            return _uow.Save();
        }
        protected  bool BaseInsert(IList<BaseEntity> entities)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            _uow.Rep.Insert(entities.EntityListConvert<T>());
            return _uow.Save();
        }
        protected bool BaseUpdate(BaseEntity oldEntity,BaseEntity currentEntity,Expression<Func<T,bool>> filter)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            if (!Validation(IslemTuru.EntityUpdate, oldEntity, currentEntity, filter)) return false;
            var degisenAlanlar = oldEntity.DegisenAlanlarıGetir(currentEntity);
            _uow.Rep.Update(currentEntity.EntityCovert<T>(), degisenAlanlar);
            if (degisenAlanlar.Count == 0) return true;
            return _uow.Save();
        }
        protected bool BaseUpdate( BaseEntity currentEntity)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            _uow.Rep.Update(currentEntity.EntityCovert<T>());
            return _uow.Save();
        }
        //silme işlemi gerçekleştirilirken bir mesaj box açılacak ve bu mesaj box, silinmek istenen entity nin hangisi olduğunu
        //bulup mesaj box a o entity nin adını yazmak için KartTuru adında, common dll sinde bir Enum tanımlayacağız.
        protected bool BaseDelete(BaseEntity entity,KartTuru kartTuru,bool mesajVer = true)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            if(mesajVer)
                if(Messages.SilMesaj(kartTuru.toName())!=DialogResult.Yes) return false;
            _uow.Rep.Delete(entity.EntityCovert<T>());
            return _uow.Save();
        }
        protected int BaseCount(Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Count(filter);
        }
        protected string BaseYeniKodVer(KartTuru kartTuru,Expression<Func<T,string>> filter,Expression<Func<T,bool>> where=null)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.YeniKodVer(kartTuru,filter,where) ;
        }
        protected string BaseYeniKodVer(string kodTanimlayici, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.YeniKodVer(kodTanimlayici, filter, where);
        }


        #region IDisposable Support

        public void Dispose()
        {
            _ctrl?.Dispose();//değişkenden sonraki soru işareti null değilse demektir...
            _uow?.Dispose();

        }
        #endregion



    }
}

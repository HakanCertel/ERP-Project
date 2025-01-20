using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.Base
{
    public class BaseGenelBll<T>:BaseBll<T,SenfoniErpContext> where T: BaseEntity
    {
        private KartTuru _kartTuru;
        private string _kodTanimlayici;

        public BaseGenelBll() { }
        public BaseGenelBll(Control ctrl) : base(ctrl) { }

        public BaseGenelBll(KartTuru kartTuru){ _kartTuru = kartTuru; }
        public BaseGenelBll(Control ctrl, KartTuru kartTuru) : base(ctrl) { _kartTuru = kartTuru; }

        //şimdi burada miras olarak almış olduğumuz BaseBll deki metodları burada da tanımlayacağız.
        //ilk olarak BaseSingle metoduna benser metod oluşturacağız. BaseSingle TResult yani BaseEntity
        //tipinde bir değer dönderdiği için şuan oluşturacağımız metodda baseenttiy dönderecek bir metod olamalı..
        
        public virtual BaseEntity Single(Expression<Func<T, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }

        public virtual IEnumerable<BaseEntity> List(Expression<Func<T, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        }

        public bool Insert(BaseEntity entity, Expression<Func<T, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }
        public bool Insert(IList<BaseEntity> entities)
        {
            return BaseInsert(entities);
        }
        public bool Update(BaseEntity currentEntity)
        {
            return BaseUpdate(currentEntity);
        }
        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);
        }

        public virtual bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, _kartTuru);
        }
        public int Count(Expression<Func<T, bool>> filter)
        {
            return BaseCount(filter);
        }
        public string YeniKodVer()
        {
            return BaseYeniKodVer(_kartTuru, x => x.Kod);
        }

        public string YeniKodVer(Expression<Func<T, bool>> filter)
        {
            return BaseYeniKodVer(_kartTuru, x => x.Kod, filter);
        }
        public string YeniKodVer(string kodTanimlayici)
        {
            return BaseYeniKodVer(kodTanimlayici, x => x.Kod);
        }

        public virtual  TResult SingleWithSelector<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return BaseSingle(filter, selector);
        }
    }
}

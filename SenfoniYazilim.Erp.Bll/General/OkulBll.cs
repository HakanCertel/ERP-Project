using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    //general klasörü altında BaseBll i inherite edceğimiz bütün entity yani tablolarımızı kapsayacak
    //bll sınıflarımızı oluşturacağız..
    public class OkulBll : BaseGenelBll<Okul>,IBaseGenelBll,IBaseCommonBll
    {

        public OkulBll():base(KartTuru.Okul) { }
        public OkulBll(Control ctrl) : base(ctrl,KartTuru.Okul) { }

        //şimdi burada miras olarak almış olduğumuz BaseBll deki metodları burada da tanımlayacağız.
        //ilk olarak BaseSingle metoduna benser metod oluşturacağız. BaseSingle TResult yani BaseEntity
        //tipinde bir değer dönderdiği için şuan oluşturacağımız metodda baseenttiy dönderecek bir metod olamalı..
        public override BaseEntity Single(Expression<Func<Okul, bool>> filter)
        {
            return BaseSingle(filter, x => new OkulS
            {
                Id = x.Id,
                Kod = x.Kod,
                OkulAdi = x.OkulAdi,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum

            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Okul, bool>> filter)
        {
            return BaseList(filter, x => new OkulL
            {
                Id = x.Id,
                Kod = x.Kod,
                OkulAdi = x.OkulAdi,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,
                Aciklama = x.Aciklama

            }).OrderBy(x => x.Kod).ToList();
        }

    }
}

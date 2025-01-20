using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SenfoniYazilim.Erp.Bll.Functions.Converts
{
    public static class Converts
    {
        //oluşturulacak metod extention metod olması gerekiyor. bunun için üç şartımız var.1-oluşturulan sınıf static olmalı
        //2-metudun static olmalı 3-metoda vermiş olduğumuz ilk değişkeninde this ile tanımlanmış olmalı..
        public static TTarget EntityCovert<TTarget>(this IBaseEntity kaynak)
        {
            if (kaynak == null) return default(TTarget);
            var hedef = Activator.CreateInstance<TTarget>();
            //burada hem hedef hemde source propertilerine ulaşmamız gerekiyor.bunun için reflection kullanacağız..
            var kaynakProp = kaynak.GetType().GetProperties();
            // hedef jenerik olduğu için bunun Propertylerine typeof ile ulaşırız..
            var hedefProp = typeof(TTarget).GetProperties();
            foreach (var kp in kaynakProp)
            {
                if (typeof(TTarget).GetProperty(kp.Name) == null) continue;
                var value = kp.GetValue(kaynak);
                var hp = hedefProp.FirstOrDefault(x => x.Name == kp.Name);
                if (hp != null)
                    //**************************************************************
                    //**************************************************************

                        //50. video dakika 12:24 anlaşılmayan şy için tekrar izle..

                    //***************************************************************
                    //***************************************************************
                    hp.SetValue(hedef, ReferenceEquals(value, "") ? null : value);
            }
            return hedef;
        }

        public static IEnumerable<TTarget> EntityListConvert<TTarget>(this IEnumerable<IBaseEntity> source)
        {
            return source?.Select(x=> x.EntityCovert<TTarget>()).ToList();
        }

        public static TTarget EntityCovert<TTarget>(this IBaseEntity kaynak,bool longToInt,bool intToLong)
        {
            if (kaynak == null) return default(TTarget);
            var hedef = Activator.CreateInstance<TTarget>();
            //burada hem hedef hemde source propertilerine ulaşmamız gerekiyor.bunun için reflection kullanacağız..
            var kaynakProp = kaynak.GetType().GetProperties();
            // hedef jenerik olduğu için bunun Propertylerine typeof ile ulaşırız..
            var hedefProp = typeof(TTarget).GetProperties();
            foreach (var kp in kaynakProp)
            {
                object value;

                if (kp.Name == "Id"&&longToInt)
                    value = Convert.ToInt32(kp.GetValue(kaynak));
                else if (kp.Name == "Id" && intToLong)
                    value = Convert.ToInt64(kp.GetValue(kaynak));
                else
                    value = kp.GetValue(kaynak);

                var hp = hedefProp.FirstOrDefault(x => x.Name == kp.Name);
                
                //if (hp == null||hp.Name == "Id") continue;

                if (hp != null)
                    hp.SetValue(hedef, ReferenceEquals(value, "") ? null : value);
            }
            return hedef;
        }

        public static IEnumerable<TTarget> EntityListConvert<TTarget>(this IEnumerable<IBaseEntity> source,bool longToInt,bool intToLong)
        {
            return source?.Select(x => x.EntityCovert<TTarget>(longToInt, intToLong)).ToList();
        }

        
    }
}

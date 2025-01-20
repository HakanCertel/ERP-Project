using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;

namespace SenfoniYazilim.Erp.Common.Functions
{
    //buradaki metodlar extension metod şeklinde olacağı için sınıfımızı statik olarak tanımlıyoruz..
    public static class EnumFunctions
    {
        //bu metod bir enum alacak ve bu enum ın attributelerini dolaşcak ve bizim seçmiş olduğumuz Enum hangisi ise
        //bu enum ın description attribute sindeki value değerini geri döndürecek..
        private static T GetAttrubute<T>(this Enum value) where T : Attribute
        {
            if (value == null) return null;

            //burada value dediğimiz bir enum sınıfı olarak oluşturulan
            //->KartTuru sınıfındaki her bir üye(okul,il,ilçe).GetType ile bu value nin sınıfına girer,getmember ile de bu sınıf için de
            //enum ımızı bulp string e dönüştürüp bu değeri memberInfo ya Aktarırız..
            var memberInfo = value.GetType().GetMember(value.ToString());
            
            //burada memberInfo bir dizi gibi görünür fakat için de bir üye vardır.
            //GetCustomAttributes ile bu enum a ait tüm Attribute leri attributes değişkenine aktarmış oluruz.
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);

            // ve metodumuz geriye bir değer döndüren bir metod olduğu için 
            return (T)attributes[0];    
        }

        public static string toName(this Enum value)
        {
            if (value == null) return null;

            //burada value ya ait, GetAttribute ile , attribut ler arasında dolaş ve Description attribute sini attribute değişkenine ata
            var attribute = value.GetAttrubute<DescriptionAttribute>();

            return attribute == null ? value.ToString() : attribute.Description; 
        }

        public static ICollection GetEnumDescriptionList<T>()
        {
            return typeof(T).GetMembers()
                .SelectMany(x => x.GetCustomAttributes(typeof(DescriptionAttribute), true)
                .Cast<DescriptionAttribute>())
                .Select(x => x.Description).ToList();
        }

        public static T GetEnum<T>(this string description)
        {
            if (Enum.IsDefined(typeof(T), description))
                return (T)Enum.Parse(typeof(T), description);

            var enumNames = Enum.GetNames(typeof(T));

            foreach (var e in enumNames.Select(x=> Enum.Parse(typeof(T),x)).Where(y=> description==toName((Enum)y)))
            {
                return (T)e;
            }

            return default(T);
        }
    }
}

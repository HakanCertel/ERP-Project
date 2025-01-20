using SenfoniYazilim.Dal.Base;
using SenfoniYazilim.Dal.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Security;
using DevExpress.Utils.Extensions;
using System.Linq;
using System.Runtime.InteropServices;

namespace SenfoniYazilim.Erp.Bll.Functions
{
    public static class  GeneralFunctions
    {
        //bu metodumuzu extension olarak tanımlayacağız(extension metodun tanımlanma koşulları converts.cs de mevcut)
        public static IList<string> DegisenAlanlarıGetir<T>(this T oldEntity,T currentEntity)
        {
            IList<string> alanlar = new List<string>();
            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                //Veri aktarım işlemi sırasında örneğin recete kayıtları aktarılırken oldEntity ReceteL
                //currentEntity ise Recete olduğu için uyuşmazlıktan kaynaklanan hatayı atlamaka için
                //aşağıdaki kontrol oluşturulmuştur..
                if (oldEntity.GetType().GetProperty(prop.Name)==null) continue;
                //aşağıdaki iki soru işareti, '??', null değerler karşılaştırılamayacağı için oldEntity ile gelen değer null
                //ise deyip ,daha sonraki ifade ile birlikte, boş bir sitringe dönüştürülür...
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;

                var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                //bazı veriler,resim gibi, byte dizisi şeklinde tanımlanır ve karşılaştırma yapacağımız alanlar içerisinde böyle
                //bir verinin olup olmadığını kontrol etmek için aşağıdaki kontrol yazılmıştır..çünki sayısal veriler
                //uzunlukları ile karşılaştırılabilirler...
                if (prop.PropertyType == typeof(byte[]))
                {
                    //şimdi burada ise örneğin öğreci veirisi güncellenecek ve boş olan resim alanına bir resim atanacak.
                    //bu durumda eski değer empy iken yeni değer bir byte dizisi olmuş olacak ve bunları karşılaştırabilmek içinn
                    //aynı tipte olmaları gerekir..
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                        oldValue = new byte[] { 0 };
                    if (string.IsNullOrEmpty(currentValue.ToString()))
                        currentValue = new byte[] { 0 };
                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                        alanlar.Add(prop.Name);
                }
                else if (prop.PropertyType == typeof(SecureString))
                {
                    var oldStr = ((SecureString)oldValue).ConvertToUnSecureString();
                    var curStr= ((SecureString)currentValue).ConvertToUnSecureString();

                    if (!curStr.Equals(oldStr))
                        alanlar.Add(prop.Name);
                }
                else if (!currentValue.Equals(oldValue))
                    alanlar.Add(prop.Name);
            }
            return alanlar;
        }
        public static   string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SenfoniErpContext"].ConnectionString;
        }
        // bu metodda bir context oluşturmak istiyoruz. bu işlemi metod işlemi tanımlanırken where TContext:DbContext, new()
        // şeklinde bir tanımlamayla yapabiliriz fakat parametreli bir instance oluşturup connectionstring i de götürmesini 
        //istediğimiz için aşağıfaki gibi yapacağız..
        private static TContext CreatContext<TContext>() where TContext : DbContext
        {
            return(TContext) Activator.CreateInstance(typeof(TContext), GetConnectionString());
        }
        // aşağıda UnitOfWork ün bir örneğini oluşturabilmek için son halinin bir referansının alınması gerekmekte.
        //bunun için ref IUnitOfWork deriz.
        public static void CreatUnitOfWork<T,TContext>(ref IUnitOfWork<T> uow) where T:class,IBaseEntity where TContext:DbContext
        {
            //UnitOfWork e ait son güncel örneği oluşturmak istediğimiz için daha önce oluşturlmuş olan bir örnek varsa
            //bunu dispose etmemiz gerekmekte..
            uow?.Dispose();
            uow = new UnitOfWork<T>(CreatContext<TContext>());
        }
        public static SecureString ConvertToSecureString(this string value)
        {
            var secureString = new SecureString();
            if (value == null) return null;
            if (value.Length > 0)
                value.ToCharArray().ToList().ForEach(x => secureString.AppendChar(x));
            secureString.MakeReadOnly();

            return secureString;
        }
        public static string ConvertToUnSecureString(this SecureString value)
        {
            var result = Marshal.SecureStringToBSTR(value);
            return Marshal.PtrToStringAuto(result);
        }
    }
}

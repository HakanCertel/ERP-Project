using System;

namespace SenfoniYazilim.Dal.Interfaces
{
    //bu interface repository'ye gelen talepleri birden fazla işlemi tek seferde veri tabanına göndermek için kullanılacak
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        IRepository<T> Rep {get;}
        // Save bloğu bize yapılamak istenilen işlemelerin,Insert-Update-delete, yapılıp yapılmadığı ile ilgili
        //geriye true veya false bir değer dönderecek
        bool Save();
    }
}

using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace SenfoniYazilim.Erp.Data.Contexts
{
    public class BaseDbContext<TContext,TConfiguration>:DbContext 
        where TContext:DbContext 
        where TConfiguration:DbMigrationsConfiguration<TContext>, new()
    {
        private static string _nameOrConnectionString=typeof(TContext).Name;
        public BaseDbContext():base(_nameOrConnectionString) { }

        public BaseDbContext(string connectionString):base(connectionString)
        {
            //databaseli kod, oluşturmuş olduğumuz Entitylerdebir güncelleme yaptığımızda
            //bunu gidip database'e uygulamak için kullanılır...
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TContext,TConfiguration>());
            _nameOrConnectionString = connectionString;
            Database.CommandTimeout = 99999;
        }
    }
}

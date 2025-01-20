using SenfoniYazilim.Erp.Data.SenfoniYonetimMigration;
using SenfoniYazilim.Erp.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SenfoniYazilim.Erp.Data.Contexts
{
    public class SenfoniErpYonetimContext : BaseDbContext<SenfoniErpYonetimContext , Configuration>
    {
        public SenfoniErpYonetimContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public SenfoniErpYonetimContext(string connectionString):base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<Kurum> Kurum { get; set; }
    }
}

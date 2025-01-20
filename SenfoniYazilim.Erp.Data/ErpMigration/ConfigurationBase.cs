using SenfoniYazilim.Erp.Data.Contexts;
using System.Data.Entity.Migrations;

namespace SenfoniYazilim.Erp.Data.ErpMigration
{
    public class ConfigurationBase: DbMigrationsConfiguration<SenfoniErpContext>
    {
        public ConfigurationBase()
        {
            AutomaticMigrationsEnabled = true;//migration işlemlerini otomatik yapmaya yarar..
            AutomaticMigrationDataLossAllowed = true;//migration işlemi yaparken veri kaybı olması durumuna izin veriş oluyoruz..
        }
    }
}

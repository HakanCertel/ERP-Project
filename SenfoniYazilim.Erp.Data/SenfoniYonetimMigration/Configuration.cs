using SenfoniYazilim.Erp.Data.Contexts;
using System.Data.Entity.Migrations;

namespace SenfoniYazilim.Erp.Data.SenfoniYonetimMigration
{
    public class Configuration : DbMigrationsConfiguration<SenfoniErpYonetimContext>
    {
        public Configuration()
        {

            AutomaticMigrationsEnabled = true;//migration işlemlerini otomatik yapmaya yarar..
            AutomaticMigrationDataLossAllowed = true;//migration işlemi yaparken veri kaybı olması durumuna izin veriş oluyoruz..
        }
    }
}

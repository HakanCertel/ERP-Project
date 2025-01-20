using System.Data.Entity;
using System.Data.SqlClient;
using System.Windows.Forms;
using SenfoniYazilim.Erp.Common.Message;
using DevExpress.XtraSplashScreen;
using SenfoniYazilim.Erp.UI.Yonetim.Forms.GenelForms;

namespace SenfoniYazilim.Erp.UI.Yonetim.Functions
{
    public class GeneralFunctions
    {
        protected internal static bool CreateDatabase<TContext>(string splashCaption,string splashDescription,string onayMesaj,string bilgiMesaj) where TContext : DbContext, new()
        {
            using (var con=new TContext())
            {
                con.Database.Connection.ConnectionString = Bll.Functions.GeneralFunctions.GetConnectionString();

                if (con.Database.Exists()) return true;

                if (Messages.EvetSeciliEvetHayir(onayMesaj, "Onay") != DialogResult.Yes) return false;

                var splashForm = new SplashScreenManager(Form.ActiveForm, typeof(BekleForm), true, true);
                SplashBaslat(splashForm);

                splashForm.SetWaitFormCaption(splashCaption);
                splashForm.SetWaitFormDescription(splashDescription);

                try
                {
                    if (con.Database.CreateIfNotExists())
                    {
                        SplashDurdur(splashForm);
                        Messages.BilgiMesaji(bilgiMesaj);
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    SplashDurdur(splashForm);

                    switch (ex.Number)
                    {
                        case 5170:
                            Messages.HataMesaji("Veritabanı Dosyalarının Yükleneceği Klasörde Aynı İsimde Bir Dosya Var. Lütfen Kontrol Ediniz .\n\n" + ex.Message);
                            break;
                        default:
                            Messages.HataMesaji(ex.Message);
                            break;
                    }
                }

                return false;
            }
        }

        private static void SplashBaslat(SplashScreenManager manager)
        {
            if (manager.IsSplashFormVisible)
            {
                manager.CloseWaitForm();
                manager.ShowWaitForm();
            }
            else
                manager.ShowWaitForm();
        }
        public static void SplashDurdur(SplashScreenManager manager)
        {
            if (manager.IsSplashFormVisible)            
                manager.CloseWaitForm();
        }

        protected internal static bool DeletDatabase<TContext>() where TContext : DbContext, new()
        {
            using (var con=new TContext())
            {
                con.Database.Connection.ConnectionString = Bll.Functions.GeneralFunctions.GetConnectionString();

                if (Messages.HayirSeciliEvetHayir("Kuruma Ait Veritabanı Silinecektir,Onaylıyor musunuz?", "Onay") != DialogResult.Yes) return false;
                if (Messages.HayirSeciliEvetHayir("Kuruma Ait Veritabanı Silinecektir,Onaylıyor musunuz?", "Tekrar Onay") != DialogResult.Yes) return false;

                try
                {
                    if (con.Database.Delete())
                    {
                        Messages.BilgiMesaji("Kurum Veritabanı Silme İşlemi Tamamlanmıştır.");
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 3702:
                            Messages.HataMesaji("Veritabnı Kullanımda Olduğu İçin Silinemedi.Lütfen Veritabanına Yapılan Tüm Bağlantıları Kapattıktan Sonra Tekrar Deneyiniz.");
                            break;
                        default:
                            Messages.HataMesaji(ex.Message);
                            break;
                    }
                }
                return false;
            }
        }
    }
}

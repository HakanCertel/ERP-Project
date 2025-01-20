using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors.Controls;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Functions.GeneralFunctions.EncryptConfigFile(AppDomain.CurrentDomain.SetupInformation.ApplicationName, "connectionStrings", "appSettings");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
            //UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2013 Blue");
            Application.Run(new GirisForm());
            /////Glass Oceans,Office 2016 Colorful,Caramel,Visual Studio 2013 Blue
        }
    }
}

using System;
using System.Reflection;
using DevExpress.XtraSplashScreen;

namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    public partial class Baslatiliyor : SplashScreen
    {
        public Baslatiliyor()
        {
            InitializeComponent();
            lblVersion.Text = $"Versiyon : {Assembly.GetExecutingAssembly().GetName().Version}";
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}
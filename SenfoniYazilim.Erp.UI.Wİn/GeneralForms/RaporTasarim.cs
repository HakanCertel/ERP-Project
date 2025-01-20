using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.RaporForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UserDesigner;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    public partial class RaporTasarim : RibbonForm,ICommandHandler
    {
        private readonly Rapor _rapor;

        public RaporTasarim(params object[] prm)
        {
            InitializeComponent();
            _rapor = (Rapor)prm[0];
            Yukle();
        }

        protected internal void Yukle()
        {
            var stream = new MemoryStream(_rapor.Dosya);
            var rapor = stream.StreamToReport();
            reportDesigner.AddCommandHandler(this);//bu metod rapor tasırımdaki butonların aktif 
            //hale gelmesini sağlayacaktır. AddCommandHandler metodu ICommandHandler tipinde bir inter
            //face alacağı için RaporTasarım Formumuzu ICommenHandler den implemente etmemiz gerkmektedir.
            reportDesigner.OpenReport(rapor);
            /*aşağıdaki üç metod rapor açıldığında rapor sayfası ile ilgili kapama, sayfayı taşıma ve dock işlemleri yapmamızı 
             engellemek için false yapılmıştır.*/
            reportDesigner.XtraTabbedMdiManager.View.DocumentProperties.AllowClose = false;
            reportDesigner.XtraTabbedMdiManager.View.DocumentProperties.AllowDock = false;
            reportDesigner.XtraTabbedMdiManager.View.DocumentProperties.AllowFloat = false;
            reportDesigner.ActiveDesignPanel.Report.DisplayName = _rapor.RaporAdi;
        }

        private void Kaydet()
        {
            _rapor.Dosya = reportDesigner.ActiveDesignPanel.Report.RaportToStream().GetBuffer();
            var result = ShowEditForms<RaporEditForm>.ShowDialogForm(Common.Enums.KartTuru.Rapor, _rapor.Id, _rapor.RaporTuru, _rapor.RaporBolumTuru, _rapor.Dosya);
            if (result <= 0) return;

            reportDesigner.ActiveDesignPanel.ReportState = ReportState.Saved;/*Bu ayarın Yapılma Sebebi form kapatılırken
            takrar formu kaydetmek istiyormusunuz diye sormasını engellemektir.*/
            DialogResult = DialogResult.OK;
            Tag = result;
            Close();
        }
        private void FarkliKaydet()
        {
            _rapor.Id = 0;
            var result = ShowEditForms<RaporEditForm>.ShowDialogForm(Common.Enums.KartTuru.Rapor, _rapor.Id, _rapor.RaporTuru, _rapor.RaporBolumTuru, _rapor.Dosya);
            if (result <= 0) return;

            reportDesigner.ActiveDesignPanel.ReportState = ReportState.Saved;/*Bu ayarın Yapılma Sebebi form kapatılırken
            takrar formu kaydetmek istiyormusunuz diye sormasını engellemektir.*/
            DialogResult = DialogResult.OK;
            Tag = result;
            Close();

        }

        public bool CanHandleCommand(ReportCommand command, ref bool useNextHandler)
        {
            useNextHandler = !(command == ReportCommand.SaveFile || command == ReportCommand.SaveFileAs || command == ReportCommand.Closing);
            return !useNextHandler;
        }

        public void HandleCommand(ReportCommand command, object[] args)
        {
            if (command == ReportCommand.SaveFile)
                Kaydet();
            else if (command == ReportCommand.SaveFileAs)
                FarkliKaydet();
            else if(command==ReportCommand.Closing)
                if (reportDesigner.ActiveDesignPanel.ReportState == ReportState.Changed)
                {
                    var result = Messages.KapanisMesaj();
                    switch (result)
                    {
                        case DialogResult.Yes:
                            Kaydet();
                            break;
                        case DialogResult.No:
                            reportDesigner.ActiveDesignPanel.ReportState = ReportState.Closing;
                            Close();
                            break;
                        case DialogResult.Cancel:
                            var eventArgs = args.Cast<CancelEventArgs>().FirstOrDefault();
                            if (eventArgs != null)
                                eventArgs.Cancel = true;
                            break;
                    }
                }
        }

    }
}
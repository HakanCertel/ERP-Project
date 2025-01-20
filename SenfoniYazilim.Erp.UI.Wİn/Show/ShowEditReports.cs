using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using System;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Show
{
    //BaseEditForm Yerine BaseRepor adında bir form düzenleyeceğiz ve TForm Bu form Biçimine Shaip Olacak.
    public  class ShowEditReports<TForm> where TForm:BaseEditForm
    {
        public static void ShowEditReport(KartTuru kartTuru)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));

            frm.MdiParent = Form.ActiveForm;
            frm.Yukle();
            frm.Show();
        }
    }
}

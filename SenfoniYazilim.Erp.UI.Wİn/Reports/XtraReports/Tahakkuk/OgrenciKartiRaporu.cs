using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;

namespace SenfoniYazilim.Erp.UI.Wİn.Reports.XtraReports.Tahakkuk
{
    // bu rapor MyXtraReport u miras olarak alacaktır bu yüzden MyXtraReport un Designer.cs si silinir ve constructur
    // daki initiliazition() metodu silinir hata almamak için.
    public partial class OgrenciKartiRaporu : MyXtraReport
    {
        public OgrenciKartiRaporu()
        {
            InitializeComponent();
        }

    }
}

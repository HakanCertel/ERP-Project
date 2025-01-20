using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using DevExpress.XtraGrid.Views.Base;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.SatinalmaFormTables
{
    public partial class SatinalmaTeklifAlinanFirmalarTable : BaseTablo
    {
        public SatinalmaTeklifAlinanFirmalarTable()
        {
            InitializeComponent();

            Bll = new PurchaseOfferItemsBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((PurchaseOfferItemsBll)Bll).TeklifAlinanFirmaList(x => x.OfferId == OwnerForm.Id);
        }
        protected override void HareketEkle()
        {
            var source = Tablo.DataController.ListSource;

            ListeDisiTutulacakKayitlar = source.Cast<SatinalmaTeklifAlinanFirmalar>().Where(x => !x.Delete).Select(x => x.Id).ToList();

            var firmalar = ShowListForms<CariListForm>.ShowDialogListForm(KartTuru.Cari ,true).EntityListConvert<Cari>();

            if (firmalar == null) return;

            foreach (var firma in firmalar)
            {
                var row = new SatinalmaTeklifAlinanFirmalar
                {
                    Id=firma.Id,
                    FirmaAdi=firma.CariAdi
                };
                source.Add(row);
            }
            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colFirmaAdi       ;

            ButtonEnabledDurum(true);
        }
        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colFirmaAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemButtonFirma, colId);
        }
    }
}

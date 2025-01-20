using System;
using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.PackagingTableAndForm
{
    public partial class PackagingEditFormTable : BaseTablo
    {

        public PackagingEditFormTable()
        {
            InitializeComponent();
            Bll = new PackagingBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((PackagingBll)Bll).List(null, x => new PackagingL
            {
                Id = x.Id,
                Description=x.Description,
                IsActive = x.IsActive
            }).ToList().toBindingList<PackagingL>();
        }
        protected override void HareketEkle()
        {
            var source = Tablo.DataController.ListSource;

            var row = new PackagingL
            {
                Insert = true
            };

            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colPackagingDescription;

            ButtonEnabledDurum(true);
        }
        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var source = Tablo.DataController.ListSource.Cast<PackagingL>().ToList();
            var selectedRow = Tablo.GetRow<PackagingL>();
            var rowHandle = Tablo.FocusedRowHandle;
            if (selectedRow == null) return;
            if (Tablo.FocusedColumn == colIsActive)
            {
                selectedRow.IsActive = !selectedRow.IsActive;
                Tablo.SetFocusedRowCellValue(colIsActive, selectedRow.IsActive);
            }
            
            if (!selectedRow.Insert)
                selectedRow.Update = true;
            ButtonEnabledDurum(true);
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }
    }
}

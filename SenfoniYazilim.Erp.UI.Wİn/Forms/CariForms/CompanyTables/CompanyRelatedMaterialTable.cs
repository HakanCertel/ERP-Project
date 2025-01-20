using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.General.Company;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.Model.Dto.Company;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Model.Dto;
using DevExpress.XtraGrid.Views.Base;
using SenfoniYazilim.Erp.Bll.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms.CompanyTables
{
    public partial class CompanyRelatedMaterialTable : BaseTablo
    {
        private readonly List<Birim> _units;
        private readonly List<Packaging> _packagingItems;

        public CompanyRelatedMaterialTable()
        {
            InitializeComponent();
            Bll = new CompanyRelatedMaterialsBll();
            Tablo = tablo;
            EventsLoad();
            _units = GetAnySingleOrListBll.ListUnitItems();
            _packagingItems = GetAnySingleOrListBll.ListPackagingItems();

            repositoryItemComboBoxUnit.Items.AddRange(_units.Select(x=>x.BirimAdi).ToList());
            repositoryItemComboBoxPackaging.Items.AddRange(_packagingItems.Select(x => x.Description).ToList());
        }
        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((CompanyRelatedMaterialsBll)Bll).List(x => x.CompanyId == OwnerForm.Id).toBindingList<CompanyRelatedMaterialsL>();
        }

        protected override void HareketEkle()
        {
            var source = Tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<CompanyRelatedMaterialsL>().Where(x => !x.Delete).Select(x => x.MaterialId).ToList();

            var entities= ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, ListeDisiTutulacakKayitlar, true, true).EntityListConvert<MaterialL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new CompanyRelatedMaterialsL
                {
                    CompanyId = OwnerForm.Id,
                    MaterialId = entity.Id,
                    MaterialCode = entity.Kod,
                    MaterialName = entity.StockName,
                    MaterialUnit = entity.UnitCode,
                    Insert = true
                };

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colCompanyMaterialCode;

            ButtonEnabledDurum(true);
        }

        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }
       
        protected override void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_isLoaded) return;
            var entity = Tablo.GetRow<CompanyRelatedMaterialsL>(false);
            if (entity == null) return;
            var selectedValue = ((ComboBoxEdit)sender).EditValue.ToString();

            if (((ComboBoxEdit)sender).Properties.Name == repositoryItemComboBoxUnit.Name)
                entity.CompanyMaterialUnitId = _units.Where(x => x.BirimAdi == selectedValue).Select(x => x.Id).FirstOrDefault();

            else if (((ComboBoxEdit)sender).Properties.Name == repositoryItemComboBoxPackaging.Name)
                entity.PackagingId = _packagingItems.Where(x => x.Description == selectedValue).Select(x => x.Id).FirstOrDefault();

            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);

        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            var entity = Tablo.GetRow<CompanyRelatedMaterialsL>(false);
            if (entity == null) return;

            if(e.FocusedColumn==colMaterialCode)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemButtonMaterialCode, colMaterialId);
        }
    }
}

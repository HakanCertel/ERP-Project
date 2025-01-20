using System;
using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Common.Message;
using DevExpress.XtraGrid.Views.Base;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms.CompanyTables
{
    public partial class AddressItemsTable : BaseTablo
    {
        public AddressItemsTable()
        {
            InitializeComponent();
            Bll = new AddressItemsBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((AddressItemsBll)Bll).List(x => x.CompanyId == OwnerForm.Id).toBindingList<AddressItemsL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;

            var row = new AddressItemsL
            {
                CompanyId=OwnerForm.Id,
                Insert = true
            };

            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colEntireAddress;

            ButtonEnabledDurum(true);
        }

        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var source = Tablo.DataController.ListSource.Cast<AddressItemsL>().ToList();
            var selectedRow = Tablo.GetRow<AddressItemsL>();

            if (selectedRow == null) return;
            if (Tablo.FocusedColumn == colIsDefault&&!selectedRow.IsDefault)
            {
                var row=source.Where(x => x.IsDefault)?.FirstOrDefault();
                if (row != null)
                {
                    row.IsDefault = false;
                    row.Update = row.Insert?false:true;
                }
                //Tablo.SetFocusedRowCellValue(colIsDefault, selectedRow.IsDefault);
            }
            else if (Tablo.FocusedColumn == colIsBranch)
            {
                selectedRow.IsBranch = !selectedRow.IsBranch;
                Tablo.SetFocusedRowCellValue(colIsBranch, selectedRow.IsBranch);

                colBranchName.OptionsColumn.AllowEdit = selectedRow.IsBranch;

                if (!selectedRow.IsBranch)
                    selectedRow.BranchName = null;
            }
            if (!selectedRow.Insert)
                selectedRow.Update = true;

            ButtonEnabledDurum(true);
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }

        protected internal override bool HatalıGiriş()
        {
            var source = Tablo.DataController.ListSource.Cast<AddressItemsL>().Where(x => !x.Delete);
            //if (source.Count() == 0) return true;

            if (Tablo.FocusedColumn == colIsDefault)
            {
                if (!source.Any(x => x.IsDefault) || source.Count() == 0)
                {
                    Messages.BilgiMesaji("Varsayılan Olarak Bir Kayıt Seçmelisiniz.");
                    tablo.FocusedColumn = colIsDefault;
                    return false;
                }
            }

            if (!TableValueChanged) return false;

            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<AddressItemsL>(i);
                if (entity.PostCode == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colPostCode;
                    tablo.SetColumnError(colPostCode, "Posta Kodu Alanına bir değer girmelisiniz .");
                }
            }
                return false;
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);
            var entity = Tablo.GetRow<AddressItemsL>(false);
            if (entity == null) return;

            if (e.FocusedColumn == colCountryName)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemButtonCountry, colCountryId);
            else if (e.FocusedColumn == colCityName)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemButtonIlAdi,colCityId,entity);
            else if (e.FocusedColumn == colCountyName&&entity.CityId!=null)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemButtonIlceAdi, colCountyId, colCityId, colCityName);
            
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            var entity = tablo.GetRow<AddressItemsL>();
            if (e.Column == colCountryName)
            {
                entity.CityName = null;
                entity.CountyName = null;
            }
            else if (e.Column == colCityName)
            {
                entity.CountyName = null;
            }
            
            entity.EntireAddress = entity.District + entity.Street + " " + entity.Number + " " + entity.Build + " "
                + entity.Apartment + " " + entity.CountyName + " /" + entity.CityName + " /" + entity.CountryName + entity.OpenAddress+" Posta Kodu: " + entity.PostCode;
        }
    }
}

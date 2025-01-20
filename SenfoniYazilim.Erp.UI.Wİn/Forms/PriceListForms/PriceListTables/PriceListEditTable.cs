using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.General.PriceListBll;
using SenfoniYazilim.Erp.Model.Entities.PriceListEntities;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto.PriceListDto;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using DevExpress.XtraGrid.Views.Base;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.Bll.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PriceListForms.PriceListTables
{
    public partial class PriceListEditTable : BaseTablo
    {
        private  List<Birim> _unit;
        private long _priceListId;
        private string _priceListCode;
        private string _prefix;

        protected internal long CurrenyId;

        public PriceListEditTable()
        {
            InitializeComponent();
            Bll = new PriceListItemsBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            base.Yukle();
            _unit = GetAnySingleOrListBll.ListUnitItems();
            repositoryItemComboBoxUnitCode.Items.AddRange(_unit.Select(x => x.BirimAdi).ToList());
        }
        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((PriceListItemsBll)Bll).List(x => x.PriceListId == OwnerForm.Id).toBindingList<PriceListItemsL>();
        }

        protected override void HareketEkle()
        {
            var source = Tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<PriceListItemsL>().Where(x => !x.Delete).Select(x => x.MaterialId).ToList();

            var entities = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, ListeDisiTutulacakKayitlar, true, true).EntityListConvert<MaterialL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new PriceListItemsL
                {
                    PriceListId = OwnerForm.Id,
                    MaterialId = entity.Id,
                    MaterialCode = entity.Kod,
                    MaterialName = entity.StockName,
                    ValidityStartDate = (DateTime)((PriceListEditForm)OwnerForm).txtValidityStartDate.EditValue,
                    ValidityEndDate = (DateTime)((PriceListEditForm)OwnerForm).txtValidityEndDate.EditValue,
                    Insert = true
                };

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colUnitCode;

            ButtonEnabledDurum(true);
        }

        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            base.CheckEdit_CheckedChanged(sender, e);
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }
        //protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        //{
        //    insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        //}

        protected override void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_isLoaded) return;
            var entity = Tablo.GetRow<PriceListItemsL>(false);
            if (entity == null) return;
            var selectedValue = ((ComboBoxEdit)sender).EditValue.ToString();

            if (((ComboBoxEdit)sender).Properties.Name == repositoryItemComboBoxUnitCode.Name)
                entity.UnitId = GetAnySingleOrListBll.ListUnitItems().Where(x => x.BirimAdi == selectedValue).Select(x => x.Id).FirstOrDefault();

            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);

        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            var entity = Tablo.GetRow<PriceListItems>(false);
            if (entity == null) return;

            if (e.FocusedColumn == colMaterialCode)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemButtonMaterialCode, colMaterialId);
        }

        protected internal override bool HatalıGiriş()
        {
           
            if (!TableValueChanged) return false;

            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<PriceListItemsL>(i);

                if (entity.ItemPrice == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colItemPrice;
                    tablo.SetColumnError(colItemPrice, "Fiyat Alanına bir değer girmelisiniz .");
                }
                if (entity.MaterialCode == "")
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colMaterialCode;
                    tablo.SetColumnError(colMaterialCode, "Malzeme Kodu Alanına Geçerli Bir Değer Girmelisiniz .");
                }
                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }
            return false;
        }

        protected internal bool TopluHareketSil()
        {
            if (Messages.SilMesaj("Fiyat Listesi") != System.Windows.Forms.DialogResult.Yes) return false;

            if (((PriceListEditForm)OwnerForm).BaseIslemTuru != IslemTuru.EntityInsert)
            {
                var source = tablo.DataController.ListSource.Cast<PriceListItemsL>();
                if (source.Count() == 0) return true;
                source.ForEach(x =>
                {
                        x.Delete = true;
                        ButtonEnabledDurum(true);
                });

                //tablo.RefreshDataSource();
                
                return true;
            }
            return true;
        }
        



    }
}

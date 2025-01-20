using System;
using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.General.Company;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto.Company;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.PriceListForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto.PriceListDto;
using SenfoniYazilim.Erp.Bll.Functions.Converts;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms.CompanyTables
{
    public partial class CompanyPriceListTable : BaseTablo
    {
        public CompanyPriceListTable()
        {
            InitializeComponent();

            Bll = new CompanyPriceListBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((CompanyPriceListBll)Bll).List(x => x.CompanyId == OwnerForm.Id).toBindingList<CompanyPriceListL>();
        }

        protected override void HareketEkle()
        {
            var source = Tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<CompanyPriceListL>().Where(x => !x.Delete).Select(x => x.CompanyPriceListsId).ToList();

            var entities = ShowListForms<PriceListListForm>.ShowDialogListForm(KartTuru.PriceList, ListeDisiTutulacakKayitlar, true, true).EntityListConvert<PriceListL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new CompanyPriceListL
                {
                    CompanyId = OwnerForm.Id,
                    CompanyPriceListsId=entity.Id,
                    CompanyPriceListCode=entity.Kod,
                    CompanyPriceListName=entity.ListName,
                    CurrencyId=entity.CurrencyId,
                    CompanyPriceListCurrencyCode=entity.CurrencyCode,
                    CompanyPriceListCurrencyName=entity.CurrencyName,
                    CompanyPriceListDescription=entity.Description,
                    CompanyPriceListValidityStart=entity.ValidityStartDate,
                    CompanyPriceListValidityEnd=entity.VailidityEndDate,
                    Insert = true
                };

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colCompanyPriceListCode;

            ButtonEnabledDurum(true);
        }
        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var entity = Tablo.GetRow<CompanyPriceListL>();

            if (entity == null) return;

            if (!entity.IsDefault)
            {
                var defaultRow = Tablo.DataController.ListSource.Cast<CompanyPriceListL>().Where(x => x.IsDefault).FirstOrDefault();
                if (defaultRow != null)
                {
                    defaultRow.IsDefault = false;
                    defaultRow.Update = defaultRow.Insert ? false : true;
                }
            }
            if (!entity.Insert)
                entity.Update = true;

            //Tablo.RefreshData();
            ButtonEnabledDurum(true);

            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);

        }
    }
}

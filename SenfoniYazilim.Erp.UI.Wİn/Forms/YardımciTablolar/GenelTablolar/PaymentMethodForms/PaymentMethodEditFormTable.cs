using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using System.Linq.Expressions;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.PaymentMethodForms
{
    public partial class PaymentMethodEditFormTable : BaseTablo
    {
        private Expression<Func<PaymentMethodItems, bool>> _filter=null;

        public PaymentMethodEditFormTable()
        {
            InitializeComponent();
            Bll = new PaymentMethodItemsBll();
            Tablo = tablo;
            EventsLoad();
            //_filter = ((PaymentMethodEditForm)OwnerForm).filter;
        }
        protected internal override void Listele()
        {
            _filter = null;// ((PaymentMethodEditForm)OwnerForm).filter;
            Tablo.GridControl.DataSource = ((PaymentMethodItemsBll)Bll).List(_filter, x => new PaymentMethodItemsL
            {
                Id = x.Id,
                PaymentMethodCode = x.PaymentMethodCode,
                PaymentMetheodDescription = x.PaymentMetheodDescription,
                LanguageId = x.LanguageId,
                LanguageDescription=x.Language.LanguageDescription,
                IsActive = x.IsActive
            }).ToList().toBindingList<PaymentMethodItemsL>();
        }
        protected override void HareketEkle()
        {
            var index = ((PaymentMethodEditForm)OwnerForm).txtLanguage.ItemIndex;
            var langId = ((PaymentMethodEditForm)OwnerForm)._source[index].Id;
            var source = tablo.DataController.ListSource;
            var row = new PaymentMethodItemsL
            {
                LanguageId = langId,
                Insert = true
            };

            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colPaymentMethodCode;

            ButtonEnabledDurum(true);
        }
        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var source = Tablo.DataController.ListSource.Cast<PaymentMethodItemsL>().ToList();
            var selectedRow = Tablo.GetRow<PaymentMethodItemsL>();
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

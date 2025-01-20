using System;
using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.Common.Message;
using DevExpress.XtraGrid.Views.Base;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.LanguageForms
{
    public partial class LanguageEditFormTable : BaseTablo
    {
        public LanguageEditFormTable()
        {
            InitializeComponent();
            Bll = new LanguageBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((LanguageBll)Bll).List(null, x => new LanguageItems
            {
                Id = x.Id,
                LanguageCode = x.LanguageCode,
                LanguageDescription = x.LanguageDescription,
                LocalEquivalent=x.LocalEquivalent,
                DefaultLanguage=x.DefaultLanguage,
                IsActive=x.IsActive
            }).ToList().toBindingList<LanguageItems>();
        }
        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var row = new LanguageItems
            {
                Insert = true
            };

            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colLanguageCode;

            ButtonEnabledDurum(true);
        }

        //protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        //{
        //    var source = Tablo.DataController.ListSource.Cast<LanguageItems>().ToList();
        //    var selectedRow = Tablo.GetRow<LanguageItems>();
        //    var rowHandle = Tablo.FocusedRowHandle;
        //    if (selectedRow == null) return;
        //    if (Tablo.FocusedColumn == colDefaultLanguage)
        //    {
        //        selectedRow.DefaultLanguage = !selectedRow.DefaultLanguage;
        //        Tablo.SetFocusedRowCellValue(colDefaultLanguage, selectedRow.DefaultLanguage);
        //    }
        //    else if (Tablo.FocusedColumn == colIsActive)
        //    {
        //        selectedRow.DefaultLanguage = !selectedRow.DefaultLanguage;
        //        Tablo.SetFocusedRowCellValue(colDefaultLanguage, selectedRow.DefaultLanguage);
        //    }
        //    if (!selectedRow.Insert)
        //        selectedRow.Update = true;
        //    ButtonEnabledDurum(true);
        //    insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        //}
       
        protected internal override bool HatalıGiriş()
        {
            var source = Tablo.DataController.ListSource.Cast<LanguageItems>().Where(x=>!x.Delete);
            if (source.Count() == 0) return true;
            if (Tablo.FocusedColumn == colDefaultLanguage)
            {
                if (!source.Any(x => x.DefaultLanguage)||source.Where(x=>x.DefaultLanguage).Count()>1)
                {
                    Messages.BilgiMesaji("Varsayılan Olarak Bir Dil Seçmelisiniz.");
                    return true;
                }
            }
            
            return false;
        }
    }
}

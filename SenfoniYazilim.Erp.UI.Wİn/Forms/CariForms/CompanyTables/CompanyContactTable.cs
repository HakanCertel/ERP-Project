using System;
using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.General.Company;
using SenfoniYazilim.Erp.Model.Dto.Company;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Common.Message;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms.CompanyTables
{
    public partial class CompanyContactTable : BaseTablo
    {
        public CompanyContactTable()
        {
            InitializeComponent();
            Bll = new CompanyContactBll();
            Tablo = tablo;
            EventsLoad();

            repositoryItemTextEMail.Mask.EditMask = @"((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_-])+)+";
            repositoryItemTextPhone.Mask.EditMask = @"0(\d?\d?\d?) \d?\d?\d? \d?\d? \d?\d?";
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((CompanyContactBll)Bll).List(x=>x.CompanyId==OwnerForm.Id, x => new CompanyContactL
            {
                Id = x.Id,
                CompanyId = x.CompanyId,
                ContactFullName = x.ContactFullName,
                ContactPhoneNumber = x.ContactPhoneNumber,
                ContactEMail = x.ContactEMail,
                IsDefault = x.IsDefault
            }).ToList().toBindingList<CompanyContactL>();
        }
        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var row = new CompanyContactL
            {
                CompanyId=OwnerForm.Id,
                Insert = true
            };

            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colContactFullName;

            ButtonEnabledDurum(true);
        }
        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var source = Tablo.DataController.ListSource.Cast<CompanyContactL>().ToList();
            var selectedRow = Tablo.GetRow<CompanyContactL>();
            if (selectedRow == null) return;
            if (!selectedRow.IsDefault)
            {
                var row = source.Where(x => x.IsDefault)?.FirstOrDefault();
                if (row != null)
                {
                    row.Update = row.Insert ? false:true;
                    row.IsDefault = false;
                }
            }
            if (!selectedRow.Insert)
                selectedRow.Update = true;
            ButtonEnabledDurum(true);
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }

        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();
            var isDefault = Tablo.DataController.ListSource.Cast<CompanyContactL>().Any(x=>x.IsDefault);
            if (!isDefault)
            {
                Messages.BilgiMesaji("Varsayılan Olarak Bir Kayıt Seçmelisiniz.");
                tablo.FocusedColumn = colIsDefault;
                return false;
            }
            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<CompanyContactL>(i);

                if (entitiy.ContactFullName == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colContactFullName;
                    tablo.SetColumnError(colContactFullName, "Ad ve Soyad Alanına Geçerli Bir Değer Giriniz .");
                }
                

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            var source = Tablo.DataController.ListSource.Cast<CompanyContactL>().Where(x => !x.Delete);
            if (source.Count() == 0) return true;
            if (Tablo.FocusedColumn == colIsDefault)
            {
                if (source.Where(x => x.IsDefault).Count() > 1)
                {
                    Messages.BilgiMesaji("Varsayılan Olarak Bir Kayıt Seçmelisiniz.");
                    return true;
                }
            }

            return false;
        }

    }
}

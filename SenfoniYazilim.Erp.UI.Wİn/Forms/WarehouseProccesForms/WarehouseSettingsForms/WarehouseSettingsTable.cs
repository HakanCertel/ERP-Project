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
using SenfoniYazilim.Erp.Bll.General.WarehouseBll;
using SenfoniYazilim.Erp.Model.Dto.WareHousesDto;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.KullaniciForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Model.Dto;
using DevExpress.XtraGrid.Views.Base;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.WarehouseSettingsForms
{
    public partial class WarehouseSettingsTable : BaseTablo
    {
        public WarehouseSettingsTable()
        {
            InitializeComponent();

            Bll = new WarehouseSettingsBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((WarehouseSettingsBll)Bll).List(x => x.WarehouseId == OwnerForm.Id).toBindingList<WarehouseSettingsL>();
        }
        protected override void HareketEkle()
        {
            //base.HareketEkle();
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<WarehouseSettingsL>().ToList().Where(x => !x.Delete).Select(x => x.UserId).ToList();
            var entities= ShowListForms<KullaniciListForm>.ShowDialogListForm(KartTuru.Kullanici, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<KullaniciL>();

            if (entities == null) return;
            foreach (var entity in entities)
            {
                var setting = new WarehouseSettingsL
                {
                    WarehouseId = OwnerForm.Id,
                    UserId = entity.Id,
                    KullaniciAdiSoyadi = entity.Adi + " " + entity.Soyadi,
                    KullaniciYetkisi = KullaniciYetkisi.Kullanici,
                    Insert = true
                };
                source.Add(setting);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            Tablo.FocusedColumn = colKullaniciYetkisi;

            ButtonEnabledDurum(true);
        }
        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var entity = Tablo.GetRow<WarehouseSettingsL>(false);
            if (entity == null) return;
            if (e.Column == colKullaniciYetkisi)
            {
                entity.CanDemand = entity.KullaniciYetkisi == KullaniciYetkisi.Yonetici;
                entity.CanTransfer = entity.KullaniciYetkisi == KullaniciYetkisi.Yonetici;
            }
            base.Tablo_CellValueChanged(sender, e);
        }
    }
}

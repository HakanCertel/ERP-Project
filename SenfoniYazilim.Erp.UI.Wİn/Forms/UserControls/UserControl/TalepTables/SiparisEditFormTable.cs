using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.Bll;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SiparisForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.SiparisTables
{
    public partial class SiparisEditFormTable : BaseTablo
    {
        public SiparisEditFormTable()
        {
            InitializeComponent();

            Bll = new ProductionDemandInformationsBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((ProductionDemandInformationsBll)Bll).List(x => x.DemandId == OwnerForm.Id).toBindingList<ProductionDemandInformationsL>();
        }
        //protected override void HareketEkle()
        //{
        //    var editForm = (SiparisEditForm)OwnerForm;

        //    repositoryItemDate.MinValue = ((SiparisEditForm)OwnerForm).txtIslemTarihi.DateTime;

        //    if (editForm.HataliGirisKontrol()) return;

        //    var source = tablo.DataController.ListSource;
        //    ListeDisiTutulacakKayitlar = source.Cast<ProductionDemandInformationsL>().ToList().Where(x => !x.Delete).Select(x => x.StockId).ToList();
        //    var entitiesStok = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<MaterialL>();

        //    if (entitiesStok == null) return;
        //    foreach (var entityStk in entitiesStok)
        //    {
        //        var row = new ProductionDemandInformationsL
        //        {
        //            UserId=AnaForm.KullaniciId,
        //            DemandId = OwnerForm.Id,
        //            DemandCode=editForm.txtKod.Text,
        //            DemandStatu=ProductionDemandStatus.OrderDeman,
        //            CurrentId=editForm.txtCari.Id,
        //            PersonelId=editForm.txtPlasiyer.Id,
        //            StockId = entityStk.Id,
        //            StockCode = entityStk.Kod,
        //            StockName = entityStk.StockName,
        //            Unit= entityStk.Unit,
        //            OrderDate = DateTime.Now,
        //            Insert = true
        //        };

        //        var teslimTarihi = editForm.txtTeslimTarihi.DateTime;
        //        var bitisTarihi= BitisTarihi(DateTime.Now, 10);

        //        if (teslimTarihi > bitisTarihi)
        //            row.DeliveryDate = teslimTarihi;
        //        else
        //            row.DeliveryDate = bitisTarihi;

        //        source.Add(row);
        //    }

        //    tablo.Focus();
        //    tablo.RefreshDataSource();
        //    tablo.FocusedRowHandle = tablo.DataRowCount - 1;
        //    tablo.FocusedColumn = colStockCode;

        //    ButtonEnabledDurum(true);
        //}

        private DateTime BitisTarihi(DateTime baslamaTarihi, int eklenecekGunSayisi)
        {
            var _bitisTarihi = new DateTime();
            int toplamTatilSayisi = 0;

            for (int i = 1; i <= eklenecekGunSayisi; i++)
            {
                if (baslamaTarihi.AddDays(i).DayOfWeek == DayOfWeek.Sunday)
                {
                    toplamTatilSayisi++;
                }
            }
            _bitisTarihi = baslamaTarihi.AddDays(toplamTatilSayisi + eklenecekGunSayisi);
            return _bitisTarihi;
        }
        //protected internal bool TopluHareketSil()
        //{
        //    if (Messages.SilMesaj("Sipariş Kartı") != System.Windows.Forms.DialogResult.Yes) return false;

        //    if (((SiparisEditForm)OwnerForm).BaseIslemTuru != IslemTuru.EntityInsert)
        //    {
        //        var source = tablo.DataController.ListSource.Cast<ProductionDemandInformationsL>();

        //        source.ForEach(x =>
        //        {
        //                x.Delete = true;
        //                ButtonEnabledDurum(true);
        //        });

        //        tablo.RefreshDataSource();

        //        return Kaydet();
        //    }
        //    return true;
        //}
        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<ProductionDemandInformationsL>(i);
                if (entity.Quantity <= 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colQuantity;
                    tablo.SetColumnError(colQuantity, "Sipariş İçin Girilecek Miktar Sıfıra Eşit Yada Sıfırdan Küçük Olamaz.");
                }
                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }
            return false;
        }
    }
}

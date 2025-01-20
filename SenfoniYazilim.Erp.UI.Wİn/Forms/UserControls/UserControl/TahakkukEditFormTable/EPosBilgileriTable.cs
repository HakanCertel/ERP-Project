using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraGrid.Views.Base;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class EPosBilgileriTable : BaseTablo
    {
        public EPosBilgileriTable()
        {
            InitializeComponent();

            Bll = new EPosBilgileriBll();
            Tablo = tablo;
            EventsLoad();

            repositoryKartTuru.Items.AddEnum<EPosKartTuru>();
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((EPosBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).toBindingList<EposBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;

            var row = new EposBilgileriL
            {
                TahakkukId = OwnerForm.Id,
                Insert = true
            };

            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colAdi;

            ButtonEnabledDurum(true);
            //bir tabloya row eklemenin başka bir yolu ise aşğıda yazılmış olan kodlar gibidir fakat zor olanıdır bu yöntem.
            //var row1 = new IndiriminUygulanacagiHizmetBilgileriL();
            //tablo.AddNewRow();
            //tablo.SetFocusedRowCellValue(colHizmetAdi, row1.HizmetAdi);
            //tablo.SetFocusedRowCellValue(colIndirimTutari, row1.IndirimTutari);
        }
        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<EposBilgileriL>(i);
                if (string.IsNullOrEmpty(entitiy.Adi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colAdi;
                    tablo.SetColumnError(colAdi, "Kart Sahibinin Adı Alanına Geçerli Bir Değer Giriniz .");
                }
                if (string.IsNullOrEmpty(entitiy.Soyadi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colSoyadi;
                    tablo.SetColumnError(colSoyadi, "Kart Sahibinin Soyadı Alanına Geçerli Bir Değer Giriniz .");
                }

                if (string.IsNullOrEmpty(entitiy.BankaAdi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colBankaAdi;
                    tablo.SetColumnError(colBankaAdi, "Banka Adı Alanına Geçerli Bir Değer Giriniz .");
                }

                if (string.IsNullOrEmpty(entitiy.KartNo))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colKartNo;
                    tablo.SetColumnError(colKartNo, "Kart Numarası Alanına Geçerli Bir Değer Giriniz .");
                }

                if (string.IsNullOrEmpty(entitiy.SonKullanmaTarihi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colSonKullanmaTarihi;
                    tablo.SetColumnError(colSonKullanmaTarihi, "Son Kullanma Tarihi Alanına Geçerli Bir Değer Giriniz .");
                }

                if (string.IsNullOrEmpty(entitiy.GuvenlikKodu))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colGuvenlikKodu;
                    tablo.SetColumnError(colGuvenlikKodu, "Güvenlik Kodu Alanına Geçerli Bir Değer Giriniz .");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }
            return false;
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);
            
            if (e.FocusedColumn == colBankaAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryBanka, colBankaId);
        }
    }
}

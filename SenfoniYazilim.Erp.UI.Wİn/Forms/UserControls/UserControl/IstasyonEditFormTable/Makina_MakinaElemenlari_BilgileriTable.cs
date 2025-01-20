using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IstasyonForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.MakinaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraGrid.Views.Base;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.IstasyonEditFormTable
{
    public partial class Makina_MakinaElemenlari_BilgileriTable : BaseTablo
    {
        public Makina_MakinaElemenlari_BilgileriTable()
        {
            InitializeComponent();

            Bll = new Makina_MakinaElemenlari_BilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((Makina_MakinaElemenlari_BilgileriBll)Bll).List(x => x.IstasyonId == OwnerForm.Id).toBindingList<Makina_MakinaElemenlari_BilgileriL>(); ;
        }
        protected override void HareketEkle()
        {
            var source = Tablo.DataController.ListSource;
            void StokSec(MakinaL entityMk, string formCaption)
            {
                /*ListeDisiTutulacakKayitlar = null;*/source.Cast<Makina_MakinaElemenlari_BilgileriL>().Where(x => !x.Delete).Select(x => x.StokId).ToList();
                var entitiesStok = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, ListeDisiTutulacakKayitlar, true, true, formCaption).EntityListConvert<MaterialL>();

                if (entitiesStok == null) return;
                foreach (var entityStk in entitiesStok)
                {
                    var row = new Makina_MakinaElemenlari_BilgileriL
                    {
                        IstasyonId = OwnerForm.Id,
                        MakinaId = entityMk.Id,
                        MakinaKodu = entityMk.Kod,
                        MakinaAdi = entityMk.MakinaAdi,
                        StokId = entityStk.Id,
                        StokKodu = entityStk.Kod,
                        StokAdi= entityStk.StockName,
                        Insert = true
                    };
                    source.Add( row);
                }
            }

            ListeDisiTutulacakKayitlar = source.Cast<Makina_MakinaElemenlari_BilgileriL>().Where(x => !x.Delete).Select(x => x.MakinaId).ToList();
            ListeDisiTutulacakKayitlar = ((IstasyonEditForm)OwnerForm).istasyonOperasyonBilgileriTable.Tablo.DataController.ListSource
                            .Cast<IstasyonOperasyonBilgileriL>().Select(x => x.MakinaId).ToList();
            //listeliKayıtlar.ForEach(x => { ListeDisiTutulacakKayitlar.Add(x); });
            var entitiesMakina = ShowListForms<MakinaListForm>.ShowDialogListForm(KartTuru.Makina, ListeDisiTutulacakKayitlar, true,true).EntityListConvert<MakinaL>();

            if (entitiesMakina == null) return;

            foreach (var entityMk in entitiesMakina)
            {
                var formCaption = entityMk?.MakinaAdi + " İçin Seçilebilecek Stok Kartları Listesi";
                StokSec(entityMk, formCaption);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colMakinaKodu;

            ButtonEnabledDurum(true);
        }
        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<Makina_MakinaElemenlari_BilgileriL>(i);

                if (entitiy.MakinaKodu != null && entitiy.StokKodu == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colStokKodu;
                    tablo.SetColumnError(colStokKodu, "Stok Kodu Alanına Geçerli Bir Değer Giriniz .");
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

            if (e.FocusedColumn == colMakinaKodu)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemMakina, colMakinaId, colMakinaAdi);
            if (e.FocusedColumn == colStokKodu)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemStok, colStokId, colStokAdi);

        }

    }
}

using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IstasyonForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.MakinaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.OgrenciForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraGrid.Views.Base;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.IstasyonEditFormTable
{
    public partial class Istasyon_Makina_Personel_BilgileriTable : BaseTablo
    {
        public Istasyon_Makina_Personel_BilgileriTable()
        {
            InitializeComponent();

            Bll = new Istasyon_Makina_Personel_BilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((Istasyon_Makina_Personel_BilgileriBll)Bll).List(x => x.IstasyonId == OwnerForm.Id).toBindingList<Istasyon_Makina_Personel_BilgileriL>(); ;
        }
        protected override void HareketEkle()
        {
            var source = Tablo.DataController.ListSource;
            void PersonelSec(MakinaL entityMk, string formCaption)
            {
                //ListeDisiTutulacakKayitlar = source.Cast<Istasyon_Makina_Personel_BilgileriL>().Where(x => !x.Delete).Select(x => x.PersonelId).ToList();
                var entitiesPersonel = ShowListForms<PersonelListForm>.ShowDialogListForm(KartTuru.Personel, true,formCaption).EntityListConvert<PersonelL>();

                if (entitiesPersonel == null) return;
                foreach (var entityPer in entitiesPersonel)
                {
                    var row = new Istasyon_Makina_Personel_BilgileriL
                    {
                        IstasyonId = OwnerForm.Id,
                        //OperasyonKodu = entityOp.Kod,
                        //OperasyonAdi = entityOp.OperasyonAdi,
                        MakinaId = entityMk?.Id,
                        MakinaKodu = entityMk!=null?entityMk.Kod:"Genel Personel",
                        MakinaAdi = entityMk != null ? entityMk.MakinaAdi:"Genel Personel",
                        PersonelId = entityPer.Id,
                        PersonelAdiSoyadi = entityPer.Adi + " " + entityPer.Soyadi,
                        Insert = true
                    };
                    if (entityMk != null)
                        row.OperasyonId = ((IstasyonEditForm)OwnerForm).istasyonOperasyonBilgileriTable.Tablo.DataController.ListSource
                            .Cast<IstasyonOperasyonBilgileriL>().Where(x => x.MakinaId == entityMk?.Id).Select(x => x.OperasyonId).FirstOrDefault();

                    source.Add(row);
                }
            }

            if (Messages.EvetSeciliEvetHayir("Makina Seçimine Bağlı Bir Personel Seçimi mi Yapacaksınız ? ", "Seçim") == System.Windows.Forms.DialogResult.Yes)
            {
                //ListeDisiTutulacakKayitlar = source.Cast<Istasyon_Makina_Personel_BilgileriL>().Where(x => !x.Delete).Select(x => x.MakinaId ?? 0).ToList();
                ListeDisiTutulacakKayitlar = ((IstasyonEditForm)OwnerForm).istasyonOperasyonBilgileriTable.Tablo.DataController.ListSource
                                .Cast<IstasyonOperasyonBilgileriL>().Select(x => x.MakinaId).ToList();
                //listeliKayıtlar.ForEach(x => { ListeDisiTutulacakKayitlar.Add(x); });
                var entitiesMakina = ShowListForms<MakinaListForm>.ShowDialogListForm(KartTuru.Makina, ListeDisiTutulacakKayitlar, true,true).EntityListConvert<MakinaL>();

                if (entitiesMakina == null) return;

                foreach (var entityMk in entitiesMakina)
                {
                    var formCaption = entityMk?.MakinaAdi + " İçin Seçilebilecek Personel Kartları Listesi";
                    PersonelSec(entityMk, formCaption);
                }
            }
            else { 
                
                PersonelSec(null, null);
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
                var entitiy = tablo.GetRow<Istasyon_Makina_Personel_BilgileriL>(i);

                if (entitiy.MakinaKodu != null&&entitiy.PersonelAdiSoyadi==null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colPersonelAdiSoyadi;
                    tablo.SetColumnError(colPersonelAdiSoyadi, "Personel Alanına Geçerli Bir Değer Giriniz .");
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
            if (e.FocusedColumn == colPersonelAdiSoyadi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemPersonel, colPersonelId, colPersonelAdiSoyadi);

        }
    }
}

using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.OperasyonForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Model.Entities;
using DevExpress.XtraGrid.Views.Base;
using SenfoniYazilim.Erp.UI.Wİn.Forms.MakinaForms;
using SenfoniYazilim.Erp.Common.Message;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.IstasyonEditFormTable
{
    public partial class IstasyonOperasyonBilgileriTable : BaseTablo
    {
        public IstasyonOperasyonBilgileriTable()
        {
            InitializeComponent();

            Bll = new IstasyonOperasyonBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((IstasyonOperasyonBilgileriBll)Bll).List(x => x.IstasyonId == OwnerForm.Id).toBindingList<IstasyonOperasyonBilgileriL>(); ;
        }

        protected override void HareketEkle()
        {
            var source = Tablo.DataController.ListSource;

            //ListeDisiTutulacakKayitlar = source.Cast<IstasyonOperasyonBilgileriL>().Where(x => !x.Delete).Select(x => x.OperasyonId).ToList();

            var entitiesOperasyon = ShowListForms<OperasyonListForm>.ShowDialogListForm(KartTuru.Operasyon, true).EntityListConvert<Operasyon>();
            
            if (entitiesOperasyon == null) return;

            foreach (var entityOp in entitiesOperasyon)
            {
                var formCaption = entityOp.OperasyonAdi + " Operasyonu İçin Seçilebilecek Makina Kartları Listesi";
                //ListeDisiTutulacakKayitlar = ((IstasyonOperasyonBilgileriBll)Bll).List(x => x.IstasyonId != OwnerForm.Id).Cast<IstasyonOperasyonBilgileri>().Select(x => x.MakinaId).ToList();
                ListeDisiTutulacakKayitlar = source.Cast<IstasyonOperasyonBilgileriL>().Where(x => !x.Delete).Select(x => x.MakinaId).ToList();

                var entitiesMakina = ShowListForms<MakinaListForm>.ShowDialogListForm(KartTuru.Makina, ListeDisiTutulacakKayitlar,true,false).EntityListConvert<MakinaL>();

                if (entitiesMakina == null) continue;
                foreach (var entityMk in entitiesMakina)
                {
                    var row = new IstasyonOperasyonBilgileriL
                    {
                        IstasyonId = OwnerForm.Id,
                        OperasyonId = entityOp.Id,
                        OperasyonKodu = entityOp.Kod,
                        OperasyonAdi = entityOp.OperasyonAdi,
                        MakinaId= entityMk.Id,
                        MakinaKodu= entityMk.Kod,
                        MakinaAdi= entityMk.MakinaAdi,
                        Insert = true
                    };
                    source.Add(row);
                }          
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colOperasyonKodu;

            ButtonEnabledDurum(true);
        }

        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<IstasyonOperasyonBilgileriL>(i);

                if (entitiy.OperasyonKodu == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colOperasyonKodu;
                    tablo.SetColumnError(colOperasyonKodu, "Operasyon Alanına Geçerli Bir Değer Giriniz .");
                }
                if (entitiy.MakinaKodu == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colMakinaKodu;
                    tablo.SetColumnError(colMakinaKodu, "Makina Alanına Geçerli Bir Değer Giriniz .");
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

            if (e.FocusedColumn == colOperasyonKodu)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemOperasyon, colOperasyonId,colOperasyonAdi);
            if (e.FocusedColumn == colMakinaKodu)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemMakina, colMakinaId,colMakinaAdi);

        }
    }
}

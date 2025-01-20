using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.RaporForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Reports.XtraReports.Tahakkuk;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    public partial class RaporSecim : BaseListForm
    {
        private readonly OgrenciR _ogrenciBilgileri;
        private readonly IEnumerable<IletisimBilgileriR> _iletisimBilgileri;
        private readonly IEnumerable<HizmetBilgileriR> _hizmetBilgileri;
        private readonly IEnumerable<IndirimBilgileriR> _indirimBilgileri;
        private readonly IEnumerable<OdemeBilgileriR> _odemeBilgileri;
        private readonly IEnumerable<GeriOdemeBilgileriR> _geriOdemeBilgileri;
        public RaporSecim(params object[] prm)
        {
            InitializeComponent();
            Bll = new RaporBll();

            ShowItems = new BarItem[] { btnRaporYeni, btnBaskiOnizleme };
            HideItems = new BarItem[] { btnYeni, btnSec, btnFiltrele, btnKolonlar, barFiltrele, barFiltreleAciklama, barKolonlar, barKolonlarAciklama };

            btnDuzelt.CreatDropDownMenu(new BarItem[] { btnTasarimDegistir });
            btnYazdir.CreatDropDownMenu(new BarItem[] { btnTabloYazdir });

            txtYaziciAdi.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());
            txtYaziciAdi.EditValue = GeneralFunctions.DefaultYazici();
            txtYazdirmaSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YazdirmaSekli>());
            txtYazdirmaSekli.SelectedItem = YazdirmaSekli.TekTekYazdir.toName();

            _ogrenciBilgileri = (OgrenciR)prm[0];
            _iletisimBilgileri = (IEnumerable<IletisimBilgileriR>)prm[1];
            _hizmetBilgileri = (IEnumerable<HizmetBilgileriR>)prm[2];
            _indirimBilgileri = (IEnumerable < IndirimBilgileriR >)prm[3];
            _odemeBilgileri = (IEnumerable<OdemeBilgileriR>)prm[4];
            _geriOdemeBilgileri= (IEnumerable<GeriOdemeBilgileriR>)prm[5];
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = smallNavigator.Navigator;
            BaseKartTuru = KartTuru.Rapor;
        }

        protected override void Listele()
        {
            RowSelect?.ClearSelection(); 
            Tablo.GridControl.DataSource = ((RaporBll)Bll).List(FilterFunctions.Filter<Rapor>(AktifKartlariGoster));
        }

        protected override void Duzelt()
        {
            if (Messages.RaporuTasarimaGonderMesaj() != DialogResult.Yes) return;

            Cursor.Current = Cursors.WaitCursor;

            var row = tablo.GetRow<RaporL>();
            if (row == null) return;

            var entity = ((RaporBll)Bll).Single(x => x.Id == row.Id);
            var result = ShowRibbonForms<RaporTasarim>.ShowDialogForm(KartTuru.RaporTasarım, entity);
            ShowEditFormDefault(result);

            Cursor.Current = DefaultCursor;
        }

        protected override void ShowEditForm(long id)
        {
            var row = tablo.GetRow<Rapor>();
            if (row == null) return;

            var entity =(Rapor)((RaporBll)Bll).Single(x => x.Id == row.Id);

            var result = ShowEditForms<RaporEditForm>.ShowDialogForm(KartTuru.Rapor, id, entity.RaporTuru,entity.RaporBolumTuru,entity.Dosya);
            ShowEditFormDefault(result);
        }

        private IList<MyXtraReport> RaporHazirla()
        {
            var raporlar = new List<MyXtraReport>();
            var topluRapor = new MyXtraReport();
            topluRapor.CreateDocument();
            topluRapor.Baslik = "Toplu Rapor";
            topluRapor.PrintingSystem.ContinuousPageNumbering = false;

            foreach (var row in RowSelect.GetSelectedRows())
            {
                var entity = (Rapor)((RaporBll)Bll).Single(x => x.Id == row.Id);
                var rapor = entity.Dosya.ByteToStream().StreamToReport();
                //raporlara DataSource Atamak için Kullanılacak Metod aşğıdaki gibi kodlanacaktır.
                RaporDataSource(rapor);
                rapor.CreateDocument();

                switch (txtYazdirmaSekli.Text.GetEnum<YazdirmaSekli>())
                {
                    case YazdirmaSekli.TekTekYazdir:
                        raporlar.Add(rapor);
                        break;
                    case YazdirmaSekli.TopluYazdir:
                        topluRapor.Pages.AddRange(rapor.Pages);
                        break;
                }
            }

            if (topluRapor.Pages.Count == 0) return raporlar;

            raporlar.Add(topluRapor);

            return raporlar;
        }

        //aşağıdaki metodda parametre olarak IReport gönderilmesinin sebebi bu parametre
        // MyXtraReport yada XtraReport olabilir fakat bu iki nesnede IReport dan implemente
        //edildiği için IRepor kullanılmıştır.
        private void RaporDataSource(IReport rapor)
        {
            switch (rapor)
            {
                case OgrenciKartiRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    rpr.Iletisim_Bilgileri.DataSource = _iletisimBilgileri;
                    rpr.Hizmet_Bilgileri.DataSource = _hizmetBilgileri;
                    rpr.Indirim_Bilgileri.DataSource = _indirimBilgileri.GroupBy(x => new { x.IndirimAdi, x.IptalTarihi, x.IslemTarihi })
                        .Select(x => new
                        {
                            /*Key anahtar sözcüğü yukarıda yapmış olduğumuz gruplama alanlarına ulaş
                             bilmek için kullanmamız gereken bir anahtar sözcüktür. kullanmazsak 
                             bu alanlara ulaşılamaz.*/
                            x.Key.IndirimAdi,
                            x.Key.IptalTarihi,
                            x.Key.IslemTarihi,
                            BrutIndirim=x.Sum(y=>y.BrutIndirim),
                            KistDonemDusulenIndirim=x.Sum(y=>y.KistDonemDusulenIndirim),
                            NetIndirim=x.Sum(y=>y.NetIndirim)
                        });
                    rpr.Odeme_Bilgileri.DataSource = _odemeBilgileri;
                    rpr.GeriOdeme_Bilgileri.DataSource = _geriOdemeBilgileri;
                    break;
            }
        }

        protected override void Yazdir()
        {
            if (Messages.EvetSeciliEvetHayir("Rapor Yazdırılmak Üzere Seçmiş olduğunuz Yazıcıya gönderilecektir. Onaylıyor musunuz?", "Onay") != DialogResult.Yes) return;
            var raporlar = RaporHazirla();

            for (int i = 0; i < txtYazdirilacakAdet.Value; i++)
            {
                raporlar.ForEach(x => x.Print(txtYaziciAdi.Text));
            }
        }

        protected override void BaskiOnizleme()
        {
            var raporlar = RaporHazirla();
            raporlar.ForEach(x => ShowRibbonForms<RaporOnizlem>.ShowForm(false, x.PrintingSystem, x.Baslik));
        }
        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.Button_ItemClick(sender, e);

            void RaporOlustur(KartTuru raporTuru, RaporBolumTuru raporBolumTuru,XtraReport rapor)
            {
                if (Messages.RaporuTasarimaGonderMesaj() != DialogResult.Yes) return;

                Cursor.Current = Cursors.WaitCursor;

                var entity = new Rapor
                {
                    Kod = ((RaporBll)Bll).YeniKodVer(x => x.RaporTuru == raporTuru),
                    RaporTuru = raporTuru,
                    RaporBolumTuru = raporBolumTuru,
                    RaporAdi = raporTuru.toName(),
                    Dosya = rapor.RaportToStream().GetBuffer(),
                    Durum=true
                };

                var result = ShowRibbonForms<RaporTasarim>.ShowDialogForm(KartTuru.RaporTasarım, entity);
                ShowEditFormDefault(result);

                Cursor.Current = Cursors.Default;
            }
            if (e.Item == btnRaporYeni)
            {
                var link = (BarSubItemLink)e.Item.Links[0];//link bir BarItemLink dir fakat bizim gönder butonumuz
                //BarSubItem olduğu için link imizi BarSubItemLink e kast edeceğiz.
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnOgrenciKarti)
                RaporOlustur(KartTuru.OgrenciKartiRaporu, RaporBolumTuru.TahakkukRaporlari, new OgrenciKartiRaporu());
        }
    }
}
using SenfoniYazilim.Erp.Bll.Functions.Converts;
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
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Reports.XtraReports.MalzemeIhtiyacPlanlama;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.MrpForms
{
    public partial class IsEmriRaporSecimListForm : BaseListForm
    {
        private readonly OgrenciR _ogrenciBilgileri;
        private readonly IEnumerable<IletisimBilgileriR> _iletisimBilgileri;
        private readonly IEnumerable<HizmetBilgileriR> _hizmetBilgileri;
        private readonly IEnumerable<IndirimBilgileriR> _indirimBilgileri;
        private readonly IEnumerable<OdemeBilgileriR> _odemeBilgileri;
        private readonly IEnumerable<GeriOdemeBilgileriR> _geriOdemeBilgileri;
        public IsEmriRaporSecimListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new MalzemeIhtiyacBilgileriBll();

            ShowItems = new BarItem[] { btnRaporYeni, btnBaskiOnizleme };
            HideItems = new BarItem[] { btnYeni, btnSec, btnFiltrele, btnKolonlar, barFiltrele, barFiltreleAciklama, barKolonlar, barKolonlarAciklama ,btnIndirimTalep};

            btnDuzelt.CreatDropDownMenu(new BarItem[] { btnTasarimDegistir });
            btnYazdir.CreatDropDownMenu(new BarItem[] { btnTabloYazdir });

            txtYaziciAdi.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());
            txtYaziciAdi.EditValue = GeneralFunctions.DefaultYazici();
            txtYazdirmaSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YazdirmaSekli>());
            txtYazdirmaSekli.SelectedItem = YazdirmaSekli.TekTekYazdir.toName();

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
            Tablo.GridControl.DataSource = ((MalzemeIhtiyacBilgileriBll)Bll).BirlestirList(x=>x.Planlandi&&!x.Kapandi).EntityListConvert<MrpMalzemeIhtiyacBilgileriBirlestirL>();
            //var source= ((MalzemeIhtiyacBilgileriBll)Bll).BirlestirList(x => x.Planlandi && !x.Kapandi);
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

            var entity = (Rapor)((RaporBll)Bll).Single(x => x.Id == row.Id);

            var result = ShowEditForms<RaporEditForm>.ShowDialogForm(KartTuru.Rapor, id, entity.RaporTuru, entity.RaporBolumTuru, entity.Dosya);
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
                //var entity = (Rapor)((RaporBll)Bll).Single(x => x.Id == row.Id);
                var rapor = new IsEmriRaporu(); /*entity.Dosya.ByteToStream().StreamToReport();*/
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
            var source = Tablo.DataController.ListSource.Cast<MrpMalzemeIhtiyacBilgileriBirlestirL>();
            foreach (var item in source)
            {
                var slk= ((MalzemeIhtiyacBilgileriBll)Bll).List(x => x.MrpBilgileriId == item.MrpBilgileriId && x.BagliOlduguUstReceteId == item.BagliOlduguUstReceteId).Cast<MalzemeIhtiyacBilgileriL>();
                ((IsEmriRaporu) rapor).MalzemeIhtiyac_Bilgileri.DataSource = ((MalzemeIhtiyacBilgileriBll)Bll).List(x => x.MrpBilgileriId == item.MrpBilgileriId && x.BagliOlduguUstReceteId == item.BagliOlduguUstReceteId).Cast<MalzemeIhtiyacBilgileriL>();
                var sdlkj=
                ((IsEmriRaporu)rapor).AnaMalzeme_Bilgileri.DataSource = ((MalzemeIhtiyacBilgileriBll)Bll).List(x => x.MrpBilgileriId == item.MrpBilgileriId && x.BagliOlduguUstReceteId == item.BagliOlduguUstReceteId).Cast<MalzemeIhtiyacBilgileriL>().FirstOrDefault();

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

            void RaporOlustur(KartTuru raporTuru, RaporBolumTuru raporBolumTuru, XtraReport rapor)
            {
                if (Messages.RaporuTasarimaGonderMesaj() != DialogResult.Yes) return;

                Cursor.Current = Cursors.WaitCursor;

                using (var bll=new RaporBll())
                {
                    var entity = new Rapor
                    {
                        Kod = bll.YeniKodVer(x => x.RaporTuru == raporTuru),
                        RaporTuru = raporTuru,
                        RaporBolumTuru = raporBolumTuru,
                        RaporAdi = raporTuru.toName(),
                        Dosya = rapor.RaportToStream().GetBuffer(),
                        Durum = true
                    };
                    var result = ShowRibbonForms<RaporTasarim>.ShowDialogForm(KartTuru.RaporTasarım, entity);
                    ShowEditFormDefault(result);
                }

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
            else if (e.Item == btnIsEmriRaporu)
                RaporOlustur(KartTuru.IsEmriRaporu, RaporBolumTuru.UretimRaporlari, new IsEmriRaporu());
        }
    }
}
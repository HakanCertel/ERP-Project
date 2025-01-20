using DevExpress.XtraBars;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IlForms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IptalNedeniForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.MeslekForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IsyeriForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.GorevForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IndirimTuruForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.EvrakForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ServisForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.HizmetTuruForms;
using System;
using System.Windows.Forms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.HizmetForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.KasaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BankaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.AvukatForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BankaHesapForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IletisimForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.OgrenciForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IndirimForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.TahakkukForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.MakbuzForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.FaturaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.OperasyonForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.MakinaForms;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Dto;
using DevExpress.XtraTabbedMdi;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SubeForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IstasyonForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.RezervasyonForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms;
using System.Collections.Generic;
using SenfoniYazilim.Erp.Bll.General;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.KullaniciForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.VardiyaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UrunTalepForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.YardımcıTablolar.GenelTablolar.BirimForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.EvrakTurleriForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.SevkiyatSekilleriForm;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.DovizForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaTeklifForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.LanguageForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.PaymentMethodForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.PackagingTableAndForm;
using SenfoniYazilim.Erp.UI.Wİn.Forms.PriceListForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.PurchaseDemandForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.SatinalmaTeklifForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaSiparisForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.SatinalmaSiparisForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.PurchaseSettingsForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SaleWayBillForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.WarehouseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.TransferBetweenWarehousesForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.MrpForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.CRPForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.CRPForms.IsEmriForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.WarehouseSettingsForms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Drawing;
using DevExpress.CodeParser;
using SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.DefinationsForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.FeaturesForms;

namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string KurumAdi;
        public static long KullaniciId ;
        public static string KullaniciAdi;
        public static long KullaniciRolId;
        public static string KullaniciRolAdi;
        public static KullaniciYetkisi KullaniciYetkisi;
        public static long DonemId;
        public static string DonemAdi = "Dönem Bilgisi Bekleniyor ...";
        public static long SubeId;
        public static string SubeAdi = "Şube Bilgisi Bekleniyor ...";
        public static List<long> YetkiliOlunanSubeler;
        public static DonemParametre DonemParametreleri;
        public static KullaniciParametreS KullaniciParametreleri=new KullaniciParametreS() ;
        public static IEnumerable<RolYetkileriL> RolYetkileri;

        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();//AnaForm açılırken ıtemClik eventlerini hazırlaması için...

            imgArkaPlanResim.EditValue = KullaniciParametreleri.ArkaPlanResim;
        }

        //Ana formumuzda bir adet ribon kontrol olacak ve foreach ile ribon kontroldeki item lara
        //ulaşacağız..ve bu riboncontrol deki ıtem lar BarButtonItem lar olacak genellikle...
        private void EventsLoad()
        {
            Load += AnaForm_Load;
            //Shown += AnaForm_Shown;
            FormClosing += AnaForm_FormClosing;
            KeyDown += Control_KeyDown;
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn://BarButtonItem lara ulaşmaya çalıştığımız için böyle tanımlandı..
                        btn.ItemClick += Butonlar_ItemClick;
                        break;
                }
            }

            foreach (Control control in Controls)
                control.KeyDown += Control_KeyDown;

            xtraTabbedMdiManager.PageAdded += XtraTabbedMdiManager_PageAdded;
            xtraTabbedMdiManager.PageRemoved += XtraTabbedMdiManager_PageRemoved;
        }



        private void SubeDonemSecimi(bool subeSecimButonunaBasildi)
        {
            ShowEditForms<SubeDonemSecimEditForm>.ShowDialogForm(null, KullaniciId, subeSecimButonunaBasildi, SubeId, DonemId);
            barDonemBilgisi.Caption = DonemAdi;
            btnSube.Caption = SubeAdi;
        }
        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close(); 
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            barKullaniciBilgisi.Caption = $"{KullaniciAdi} ( {KullaniciRolAdi} )";
            barKurumBilgisi.Caption = KurumAdi;

            SubeDonemSecimi(false);
            if (DonemParametreleri == null)
            {
                Messages.HataMesaji("Dönem Parametreleri Girilmemiş. Lütfen Sistem Yöneticinize Başvurunuz .");
                Application.ExitThread();
                return;
            }
            if (!DonemParametreleri.YetkiKontroluAnlikYapilacak)
                using (var bll = new RolYetkileriBll())
                    RolYetkileri = bll.List(x => x.RolId == KullaniciRolId).Cast<RolYetkileriL>();
            imgArkaPlanResim.SendToBack();
        }
        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Messages.HayirSeciliEvetHayir("Programdan Çıkmak İstiyor Musunuz ?", "Çıkış Onay") == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }
        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnIlKartlari)
                ShowListForms<IlListForm>.ShowListForm(KartTuru.Il);
            else if (e.Item == btnIptalNedeniKartlari)
                ShowListForms<IptalNedeniListForm>.ShowListForm(KartTuru.IptalNedeni);
            else if (e.Item == btnMeslekKartlari)
                ShowListForms<MeslekListForm>.ShowListForm(KartTuru.Meslek);
            else if (e.Item == btnIsyeriKartlari)
                ShowListForms<IsyeriListForm>.ShowListForm(KartTuru.Isyeri);
            else if (e.Item == btnGorevKartlari)
                ShowListForms<GorevListForm>.ShowListForm(KartTuru.Gorev);
            else if (e.Item == btnIndirimTuruKarti)
                ShowListForms<IndirimTuruListForm>.ShowListForm(KartTuru.IndirimTuru);
            else if (e.Item == btnEvrakKarlari)
                ShowListForms<EvrakListForm>.ShowListForm(KartTuru.Evrak);
            else if (e.Item == btnServisYeriKartlari)
                ShowListForms<ServisListForm>.ShowListForm(KartTuru.Servis);
            else if (e.Item == btnHizmetTuruKartlari)
                ShowListForms<HizmetTuruListForm>.ShowListForm(KartTuru.HizmetTuru);
            else if (e.Item == btnHizmetKartlari)
                ShowListForms<HizmetListForm>.ShowListForm(KartTuru.Kullanici);
            else if (e.Item == btnUserCards)
                ShowListForms<KullaniciListForm>.ShowListForm(KartTuru.Hizmet);
            
            else if (e.Item == btnKasaKartlari)
                ShowListForms<KasaListForm>.ShowListForm(KartTuru.Kasa);
            else if (e.Item == btnBankaKartlari)
                ShowListForms<BankaListForm>.ShowListForm(KartTuru.Banka);
            else if (e.Item == btnAvukatKarti)
                ShowListForms<AvukatListForm>.ShowListForm(KartTuru.Avukat);
            else if (e.Item == btnCariKartlari)
                ShowListForms<CariListForm>.ShowListForm(KartTuru.Cari);
            else if (e.Item == btnBankaHesapKartlari)
                ShowListForms<BankaHesapListForm>.ShowListForm(KartTuru.BankaHesap);
            else if (e.Item == btnIletisimKartlari)
                ShowListForms<IletisimListForm>.ShowListForm(KartTuru.Iletisim);
            else if (e.Item == btnOgrenciKartlari)
                ShowListForms<PersonelListForm>.ShowListForm(KartTuru.Ogrenci);
            else if (e.Item == btnIndirimKartlari)
                ShowListForms<IndirimListForm>.ShowListForm(KartTuru.Indirim);
            else if (e.Item == btnTahakkukKartlari)
                ShowListForms<TahakkukListForm>.ShowListForm(KartTuru.Tahakkuk);
            else if (e.Item == btnMakbuzKartlari)
                ShowListForms<MakbuzListForm>.ShowListForm(KartTuru.Makbuz);
            else if (e.Item == btnFaturaPlaniKartlari)
                ShowListForms<FaturaPlaniListForm>.ShowListForm(KartTuru.Fatura);
            else if (e.Item == btnSubeKartlari)
                ShowListForms<SubeListForm>.ShowListForm(KartTuru.Sube);
            else if (e.Item == btnFaturaTahakkukKarti)
                ShowEditForms<FaturaTahakkukEditForm>.ShowDialogForm(KartTuru.Fatura);
            else if (e.Item == btnStokKartlari)
                ShowListForms<StokListForm>.ShowListForm(KartTuru.Stok);
            else if (e.Item == btnReceteKartlari)
                ShowListForms<ReceteListForm>.ShowListForm(KartTuru.Recete);
            else if (e.Item == btnMrpKartlari)
                ShowListForms<MrpListForm>.ShowListForm(KartTuru.Mrp);
            //else if (e.Item == btnSiparisKartlari)
            //    ShowListForms<SiparisListForm>.ShowListForm(KartTuru.Order);
            
            else if (e.Item == btnIstasyonKartlari)
                ShowListForms<IstasyonListForm>.ShowListForm(KartTuru.Istasyon);
            else if (e.Item == btnVardiyaKartlari)
                ShowListForms<VardiyaListForm>.ShowListForm(KartTuru.Vardiya);
            else if (e.Item == btnRezervasyonBilgileri)
                ShowListForms<RezervasyonListForm>.ShowHareketListForm(KartTuru.Rezerve);
            else if (e.Item == btnRezervasyonKarti)
            {
                var formShow = new ShowEditForms<RezervasyonEditForm>();

                var entity = formShow.ShowDialogForm(KartTuru.Rezerve, -1);
            }
            else if (e.Item == btnUretimSonuKayitlari)
                ShowListForms<UretimSonuKayitListForm>.ShowListForm(KartTuru.UretimSonuKayit);
            else if (e.Item == btnStokHareketleri)
                ShowListForms<StokHareketleriListForm>.ShowListForm(KartTuru.StokHareket);
            else if (e.Item == btnDepolarArasiTransfer)
                ShowListForms<TransferBetweenWarehousesListFrom>.ShowListForm(KartTuru.DepolarArasiTransfer);
            else if (e.Item == btnProductionDemandCards)
                ShowListForms<ProductionDemandListFrom>.ShowListForm(KartTuru.ProductionDemand);
           
            #region ProductionManagment
                else if (e.Item == btnMrpList)
                    ShowListForms<MalzemeIhtiyaclarıListForm>.ShowHareketListForm(KartTuru.Mrp);
                else if(e.Item==btnIsEmri)
                    ShowListForms<IsEmriListForm>.ShowHareketListForm(KartTuru.IsEmri);
                else if (e.Item == btnOperasyonKartlari)
                    ShowListForms<OperasyonListForm>.ShowListForm(KartTuru.Operasyon);
                else if (e.Item ==btnCrp)
                    ShowEditForms<MalzemeIhtiyacPlanlamaEditForm>.ShowForm(KartTuru.Crp,-1);
                else if (e.Item == btnMakinaKartlari)
                    ShowListForms<MakinaListForm>.ShowListForm(KartTuru.Makina);
                else if (e.Item == btnMrpRequirmentItems)
                    ShowListForms<MalzemeIhtiyacKalemleriListForm>.ShowHareketListForm(KartTuru.Mrp);
                else if(e.Item==btnCrpList)
                    ShowListForms<KapasiteIhtiyacListForm>.ShowHareketListForm(KartTuru.Crp);
            #endregion

            #region Sales
            else if (e.Item == btnSalesOfferCards)
                    ShowListForms<SalesOfferListForm>.ShowListForm(KartTuru.SalesOffer);
                else if (e.Item == btnSalesOfferItemsList)
                    ShowListForms<SalesOfferItemsListForm>.ShowHareketListForm(KartTuru.SalesOfferItems);
                else if (e.Item == btnSaleCards)
                    ShowListForms<SalesListForm>.ShowListForm(KartTuru.Sales);
                else if (e.Item == btnSaleItems)
                    ShowListForms<SalesItemsListForm>.ShowHareketListForm(KartTuru.SalesItems);
            #endregion

            #region PurchaseForms

                else if (e.Item == btnSatinalmaTalep)
                    ShowEditForms<PurchaseDemanEditForm>.ShowDialogForm();
                else if (e.Item == btnPurchaseSettings)
                    ShowEditForms<PurchaseSettingsForm>.ShowDialogForm();
                else if (e.Item == btnSatinalmaTalepKartlari)
                    ShowListForms<PurchaseDemandListForm>.ShowListForm(KartTuru.SatinalmaTalep);
                else if (e.Item == btnTumSatinalmaTalepKalemleri)
                    ShowListForms<PurchaseDemanItemsListForm>.ShowHareketListForm(KartTuru.PurchaseDemandItems);
                else if (e.Item == btnOnayBekleyenSatinalmaTalepKalemler)
                    ShowListForms<PurchaseDemandItemsManagerComfirmListForm>.ShowHareketListForm(KartTuru.PurchaseDemandItems);
                else if (e.Item == btnPurchaseOfferCards)
                        ShowListForms<PurchaseOfferListForm>.ShowListForm(KartTuru.PurchaseOffer);
                else if (e.Item == btnPurchaseOfferItems)
                       ShowListForms<PurchaseOfferItemsListForm>.ShowHareketListForm(KartTuru.PurchaseOffer);
                else if (e.Item == btnNewCreateOrder)
                    ShowEditForms<PurchaseOrderEditForm>.ShowDialogForm();
                else if (e.Item == btnPurchaseOrderCards)
                    ShowListForms<PurchaseOrderListForm>.ShowListForm(KartTuru.PurchaseOrder);
                else if (e.Item == btnPurchaseOrderItems)
                    ShowListForms<PurchaseOrderItemsListForm>.ShowHareketListForm(KartTuru.PurchaseOrder);
            #endregion
            
            #region YardımcıFormlar
            else if (e.Item == btnBirim)
                    ShowListForms<BirimListForm>.ShowListForm(KartTuru.Birim);
                else if (e.Item == btnSevkiyatSekli)
                    ShowListForms<SevkiyatSekilleriListForm>.ShowListForm(KartTuru.SevkiyatSekli);
                else if (e.Item == btnDovizBilgileri)
                    ShowListForms<DovizListForm>.ShowListForm(KartTuru.Doviz);
                else if (e.Item == btnKdvKartlari)
                    ShowListForms<KdvListForm>.ShowListForm(KartTuru.Kdv);
                else if (e.Item == btnCountry)
                    ShowListForms<CountryListForm>.ShowListForm(KartTuru.Country);
                else if (e.Item == btnTatilParametreleri)
                        ShowEditForms<TatilParametreEditForm>.ShowDialogForm();
                else if (e.Item == btnLanguageCards)
                    ShowEditForms<LanguageEditForm>.ShowDialogForm();
                else if (e.Item == btnMaterialDefinations)
                    ShowEditForms<DefinationsEditForm>.ShowDialogForm(KartTuru.Stok,KartTuru.Stok);
                else if (e.Item == btnMaterialFeatures)
                    ShowEditForms<FeaturesEditForm>.ShowDialogForm(KartTuru.Stok, KartTuru.Stok);
                else if (e.Item == btnPackaging)
                    ShowEditForms<PackagingEditForm>.ShowDialogForm();
                else if (e.Item == btnPaymentMethod)
                    ShowEditForms<PaymentMethodEditForm>.ShowDialogForm();
                else if (e.Item == btnEvrakTurleri)
                        ShowEditForms<EvrakTurleriEditForm>.ShowDialogForm();
            #endregion
            
            #region WayBill
            else if (e.Item == btnPurchaseWayBillCards)
                    ShowListForms<PurchaseWayBillListForm>.ShowListForm(KartTuru.PurchaseWayBill);
            else if (e.Item == btnDispatchWayBill)
                ShowListForms<DispatchWayBillListForm>.ShowListForm(KartTuru.DispatchWayBill);
            #endregion

            #region WarehouseProccessForms
            else if (e.Item == btnDepoKartlari)
                ShowListForms<WarehouseListForm>.ShowListForm(KartTuru.Depo);
            if (e.Item==btnTransferDemand)
                    ShowEditForms<TransferDemandBetweenWarehousesEditForm>.ShowDialogForm(KartTuru.TransferDemandBetweenWarehouses,-1,null);
            else if (e.Item == btnWarehouseSettings)
                ShowEditForms<WarehouseSettingsForm>.ShowDialogForm(KartTuru.Depo,-1,1);
            else if (e.Item == btnTransferDemandCards)
                    ShowListForms<TransferDemandBetweenWarehousesListFrom>.ShowListForm(KartTuru.TransferDemandBetweenWarehouses);
                else if (e.Item == btnTransferDemandItems)
                    ShowListForms<TransferDemandItemsListForm>.ShowHareketListForm(KartTuru.TransferDemandBetweenWarehouses);
            #endregion

            else if (e.Item == btnPriceListCards)
                ShowListForms<PriceListListForm>.ShowListForm(KartTuru.PriceList);
            else if (e.Item == btnPriceListComfirm)
                ShowListForms<PriceListComfirmOrCancelForm>.ShowListForm(KartTuru.PriceList);
            else if (e.Item == btnKullaniciParametreleri)
            {
                var entity = ShowEditForms<KullaniciParametreleriEditForm>.ShowDialogEditForm<KullaniciParametreS>(KullaniciId);
                if (entity == null) return;

                KullaniciParametreleri = entity;
                imgArkaPlanResim.EditValue = entity.ArkaPlanResim;
            }
            else if (e.Item == btnSube)
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i] is GirisForm || Application.OpenForms[i] is AnaForm) continue;
                    Application.OpenForms[i].Close();
                    i--;
                }

                SubeDonemSecimi(true);
            }
            else if (e.Item == btnSifreDegistir)
                ShowEditForms<SifreDegistirEditForm>.ShowDialogForm(IslemTuru.EntityUpdate);
            Cursor.Current = Cursors.Default;
        }

        private void XtraTabbedMdiManager_PageRemoved(object sender, MdiTabPageEventArgs e)
        {
            imgArkaPlanResim.SendToBack();
        }

        private void XtraTabbedMdiManager_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (((XtraTabbedMdiManager)sender).Pages.Count == 0)
                imgArkaPlanResim.BringToFront();
        }

     
        //private void AnaForm_Shown(object sender, EventArgs e)
        //{
        //    var elementFormCaption = SkinManager.GetSkinElement(SkinProductId.Ribbon, UserLookAndFeel.Default, "FormCaption");
        //    var elementTabHeaderBackground = SkinManager.GetSkinElement(SkinProductId.Ribbon, UserLookAndFeel.Default, "TabHeaderBackground");
        //    var elementTabPanel = SkinManager.GetSkinElement(SkinProductId.Ribbon, UserLookAndFeel.Default, "TabPanel");
        //    elementFormCaption.Color.BackColor = Color.Maroon;
        //    elementFormCaption.Color.SolidImageCenterColor = Color.Maroon;
        //    //elementFormCaption.Image.Image =  
        //    elementTabHeaderBackground.Color.SolidImageCenterColor = Color.Maroon;
        //    elementTabPanel.Color.SolidImageCenterColor = Color.Maroon;
        //}
    }
}
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SenfoniYazilim.Erp.Data.ErpMigration;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Company;
using SenfoniYazilim.Erp.Model.Entities.Company.CompanySetting;
using SenfoniYazilim.Erp.Model.Entities.CRP;
using SenfoniYazilim.Erp.Model.Entities.PriceListEntities;
using SenfoniYazilim.Erp.Model.Entities.ProductionManagmentEntities.UretimSonuKayitEntities;
using SenfoniYazilim.Erp.Model.Entities.WayBillEntities;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using SenfoniYazilim.Erp.Model.Entities.Sat�nalma;
using SenfoniYazilim.Erp.Model.Entities.Sat�nalma.PurchaseSettingsEntites;
using SenfoniYazilim.Erp.Model.Entities.WareHouseEntities;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.Model.ProductionManagmentEntites.MrpEntites;
using SenfoniYazilim.Erp.Model.Entities.MeterialEntities;

namespace SenfoniYazilim.Erp.Data.Contexts
{
    //Tconfiguration, migration i�lemlerimizi hangi konfigurasyon 
    //ayarlar�na g�re yapca��m�z� belirlemek i�in kullan�lmaktad�r,bunlar atomatik migration olabilir,
    //migration i�lemleri yap�l�rken veri kayb�n� onlemek i�in olabilir...
    public class SenfoniErpContext : BaseDbContext<SenfoniErpContext,ConfigurationBase>
    {
        // <connectionStrings>
        // <add name = "ErpContetx" connectionString="data source=(LocalDb)\MSSQLLocalDB;initial catalog=SenfoniYazilim.Erp.Data.Contexts.ErpContetx;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
        // </connectionStrings>
        public SenfoniErpContext()
        {
            //lazyloadingenabled metodu veritaban�ndaki herhangi ibir tablo/entity den veri �ekece�imiz
            //zaman ili�kili oldu�u tablolar�nda verilerini �ekmesini engeller...
            Configuration.LazyLoadingEnabled = false;
        }

        public SenfoniErpContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //PlularizingTableNameConvention Entitylerimiz tablolara d�n��t�r�l�rken �o�ul isimler olarak
            //d�n��t�r�l�r. bunu devre d��� b�rak�p verdi�imiz isimde tablolar� olu�turur...
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //bire �ok ili�kili tablaolarda bir veri silindi�inde ili�kili veriler silinir.
            //OneToManyCascadeDeleteConvention bu devre d��� b�rak�larak bu durum engellenmi� olur...
            //bu gerekli bir �eydir fakat burada yapm�� oldu�umuz database olu�turma ayarlar� oldu�u i�in,
            //�zel olarak bunu engellemek istedi�imiz bire �ok i�i�kili tablolar i�in aktif hale getirece�iz..
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();//�oka �ok ili�kilerde..
            /*A�a��daki kodlar �rne�in IlListForm dan bir ili silmeye kalkt���m�zda ve o ile ba�l� 
             il�eler tan�mlanm��sa e�er silme i�lemi ger�ekle�tirilemez. il i silfi�imizde il�elerin de 
             silinmesini istiyorsak e�er a�a��daki kodu yazmal�y�z. Ayr�ca Il  Entity sinde 
             
            [InverseProperty("Il")]
             public ICollection<Ilce> Ilce { get; set; }  �ekl,inde bir property olu�turmam�z gerekmektedir.
             ki ilin il�elerle bire �ok ili�kisinin oldu�unu belirtmi� olal�m.ve InversPropery("Il") attribute
             si ilede her iki tabloda birbiriyle ili�ki tan�mlam�� olaca��m�z i�in olu�abilcek hatay�
             �nlemi� olaca��z*/
            modelBuilder.Entity<Il>().HasMany(x => x.Ilce).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Banka>().HasMany(x => x.BankaSube).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Indirim>().HasMany(x => x.IndiriminUygulanacagiHizmetBilgileri).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<MrpBilgileri>().HasMany(x => x.MalzemeIhtiyacBilgileri).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Recete>().HasMany(x => x.ReceteBilgileri).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Mrp>().HasMany(x => x.MrpBilgileri).WithRequired().WillCascadeOnDelete(true);
            //modelBuilder.Entity<MalzemeIhtiyacBilgileri>().HasMany(x => x.KapasiteIhtiyacBilgileri).WithRequired().WillCascadeOnDelete(true);
            //modelBuilder.Entity<KapasiteIhtiyacBilgileri>().HasMany(x => x.PlanlanmisMalzemeKalemleri).WithRequired().WillCascadeOnDelete(true);
            //modelBuilder.Entity<WorkOrder>().Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }

        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Okul> Okul { get; set; }
        public DbSet<Filtre> Filtre { get; set; }
        public DbSet<AileBilgi> AileBilgi { get; set; }
        public DbSet<IptalNedeni> IptalNedeni { get; set; }
        public DbSet<YabanciDil> YabanciDil { get; set; }
        public DbSet<Tesvik> Tesvik { get; set; }
        public DbSet<Kontenjan> Kontenjan { get; set; }
        public DbSet<Rehber> Rehber { get; set; }
        public DbSet<SinifGrup> SinifGrup { get; set; }
        public DbSet<Meslek> Meslek { get; set; }
        public DbSet<Yakinlik> Yakinlik { get; set; }
        public DbSet<Isyeri> Isyeri { get; set; }
        public DbSet<Gorev> Gorev { get; set; }
        public DbSet<IndirimTuru> IndirimTuru { get; set; }
        public DbSet<Evrak> Evrak { get; set; }
        public DbSet<Donem> Donem { get; set; }
        public DbSet<Sube> Sube { get; set; }
        public DbSet<Promosyon> Promosyon { get; set; }
        public DbSet<Servis> Servis { get; set; }
        public DbSet<Sinif> Sinif { get; set; }
        public DbSet<HizmetTuru> HizmetTuru { get; set; }
        public DbSet<Hizmet> Hizmet { get; set; }
        public DbSet<OzelKod> OzelKod { get; set; }
        public DbSet<Kasa> Kasa { get; set; }
        public DbSet<Banka> Banka { get; set; }
        public DbSet<BankaSube> BankaSube { get; set; }
        public DbSet<Avukat> Avukat { get; set; }
        public DbSet<OdemeTuru> OdemeTuru { get; set; }
        public DbSet<BankaHesap> BankaHesap { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Personel> Ogrenci { get; set; }
        public DbSet<Indirim> Indirim { get; set; }
        public DbSet<IndiriminUygulanacagiHizmetBilgileri> IndiriminUygulanacagiHizmetBilgileri { get; set; }
        public DbSet<Tahakkuk> Tahakkuk { get; set; }
        public DbSet<KardesBilgileri> KardesBilgileri { get; set; }
        public DbSet<AileBilgileri> AileBilgileri { get; set; }
        public DbSet<SinavBilgileri> SinavBilgileri { get; set; }
        public DbSet<EvrakBilgileri> EvrakBilgileri { get; set; }
        public DbSet<PromosyonBilgileri> PromosyonBilgileri { get; set; }
        public DbSet<IletisimBilgileri> IletisimBilgileri { get; set; }
        public DbSet<EPosBilgileri> EPosBilgileri { get; set; }
        public DbSet<BilgiNotlari> BilgiNotlari { get; set; }
        public DbSet<HizmetBilgileri> HizmetBilgileri { get; set; }
        public DbSet<IndirimBilgileri> IndirimBilgileri { get; set; }
        public DbSet<OdemeBilgileri> OdemeBilgileri { get; set; }
        public DbSet<GeriOdemeBilgileri> GeriOdemeBilgileri { get; set; }
        public DbSet<Makbuz> Makbuz { get; set; }
        public DbSet<MakbuzHareketleri> MakbuzHareketleri { get; set; }
        public DbSet<Fatura> Fatura { get; set; }
       
        #region Material
            public DbSet<Material> Material { get; set; }
            public DbSet<MeterialUnits> MeterialUnits { get; set; }
            public DbSet<StokHareketleri> StokHareketleri { get; set; }
        #endregion
        
        #region Company

        public DbSet<Cari> Cari { get; set; }
            public DbSet<AddressItems> AddressItems { get; set; }
            public DbSet<CompanyRelatedMaterials> CompanyRelatedMaterials { get; set; }
            public DbSet<CompanyPriceList> CompanyPriceList { get; set; }
        #endregion
        
        #region ProductionManagment
            public DbSet<Recete> Recete { get; set; }
            public DbSet<ReceteBilgileri> ReceteBilgileri { get; set; }
            public DbSet<Mrp> Mrp { get; set; }
            public DbSet<MrpBilgileri> MrpBilgileri { get; set; }
            public DbSet<MalzemeIhtiyacBilgileri> MalzemeIhtiyacBilgileri { get; set; }
            public DbSet<Makina> Makina { get; set; }
            public DbSet<ReceteOperasyonBilgileri> ReceteOperasyonBilgileri { get; set; }
            public DbSet<ReceteOperasyonMakinaBilgileri> ReceteOperasyonMakinaBilgileri { get; set; }
            public DbSet<Vardiya> Vardiya { get; set; }
            public DbSet<Istasyon> Istasyon { get; set; }
            public DbSet<IstasyonOperasyonBilgileri> IstasyonOperasyonBilgileri { get; set; }
            public DbSet<Istasyon_Makina_Personel_Bilgileri> Istasyon_Makina_Personel_Bilgileri { get; set; }
            public DbSet<Makina_MakinaElemenlari_Bilgileri> Makina_MakinaElemenlari_Bilgileri { get; set; }
            public DbSet<ReceteMakinaElemaniBilgileri> ReceteMakinaElemaniBilgileri { get; set; }
            public DbSet<EksiyeDusenStokBilgileri> EksiyeDusenStokBilgileri { get; set; }
            public DbSet<UretimSonuKayitBilgileri> UretimSonuKayitBilgileri { get; set; }
            public DbSet<UretimSonuKayit> UretimSonuKayit { get; set; }
            public DbSet<VardiyaLastVersion> VardiyaLastVersion { get; set; }
            public DbSet<VardiyaBilgileriLastVersion> VardiyaBilgileriLastVersion { get; set; }
            public DbSet<TatilBilgileri> TatilBilgileri { get; set; }
            public DbSet<ProductionDemand> ProductionDemand { get; set; }
            public DbSet<KapasiteIhtiyacBilgileri> KapasiteIhtiyacBilgileri { get; set; }
            public DbSet<PlanlanmisMalzemeKalemleri> PlanlanmisMalzemeKalemleri { get; set; }
            public DbSet<CalismaEmri> CalismaEmri { get; set; }
            public DbSet<WorkOrders> WorkOrders { get; set; }
            public DbSet<WorkOrderMaterialItems> WorkOrderMaterialItems { get; set; }
        #endregion

        public DbSet<Rapor> Rapor { get; set; }
        public DbSet<Operasyon> Operasyon { get; set; }
        public DbSet<DonemParametre> DonemParametreleri { get; set; }
        public DbSet<KullaniciParametre> KullaniciParametre { get; set; }
        public DbSet<Tarih> Tarih { get; set; }
        public DbSet<MailParametre> MailParametre { get; set; }
        public DbSet<KurumBilgileri> KurumBilgileri { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolYetkileri> RolYetkileri { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<KullaniciBirimYetkileri> KullaniciBirimYetkileri { get; set; }
        public DbSet<OrderDemand> OrderDemand { get; set; }
        public DbSet<ProductionDemandInformations> ProductionDemandInformations { get; set; }

        #region Sales
            public DbSet<SalesOffer> SalesOffer { get; set; }
            public DbSet<SalesOfferItems> SalesOfferItems { get; set; }
            public DbSet<Sales> Sales{ get; set; }
            public DbSet<SalesItems> SalesItems { get; set; }
        #endregion
        
        #region Purchase
            public DbSet<SatinalmaTalep> PurchaseDemand { get; set; }
            public DbSet<PurchaseDemandItems> PurchaseDemandItems { get; set; }
            public DbSet<PurchaseOfferItems> SatinalmaTeklifKalemleri { get; set; }
            public DbSet<PurchaseOffer> SatinalmaTeklif { get; set; }
            public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
            public DbSet<PurchaseOrderItems> PurchaseOrderItems { get; set; }
            public DbSet<PurchaseSettings> PurchaseSettings { get; set; }
        #endregion
        
        #region WayBill
            public DbSet<PurchaseWayBill> PurchaseWayBill { get; set; }
            public DbSet<PurchaseWayBillItems> PurchaseWayBillItems { get; set; }
            public DbSet<DispatchWayBill> DispatchWayBill { get; set; }
            public DbSet<DispatchWayBillItems> DispatchWayBillItems { get; set; }
        #endregion

        #region WarehouseProccess
        public DbSet<WareHouse> WareHouse { get; set; }
            public DbSet<WareHouseStocks> WareHouseStocks { get; set; }
            public DbSet<TransferBetweenWarehouse> TransferDemandWarehouse { get; set; }
            public DbSet<TransferItemsBetweenWareHouses> TarnsferItemsBetweenWareHouses { get; set; }
            public DbSet<WareHouseStockUpdate> DepoStokDuzelt { get; set; }
            public DbSet<WarehouseSettings> WarehouseSettings { get; set; }
        #endregion

        #region HelperTableAndForm
            public DbSet<SevkiyatSekilleri> SevkiyatSekilleri { get; set; }
            public DbSet<EvrakTurleri> EvrakTurleri { get; set; }
            public DbSet<Birim> Birim { get; set; }
            public DbSet<DovizBilgileri> DovizBilgileri { get; set; }
            public DbSet<Kdv> Kdv { get; set; }
            public DbSet<PaymentMethodItems> PaymentMethodItems { get; set; }
            public DbSet<Language> Language { get; set; }
            public DbSet<Country> Country { get; set; }
            public DbSet<Packaging> Packaging { get; set; }
            public DbSet<Definations> Definations { get; set; }
            public DbSet<Features> Features { get; set; }
        #endregion

        public DbSet<PriceList> PriceList { get; set; }
        public DbSet<PriceListItems> PriceListItems { get; set; }
        //public DbSet<MakinaKapasiteKullan�mBilgileri> MakinaKapasiteKullan�mBilgileri { get; set; }

        //public DbSet<denemeTablosu> MyProperty { get; set; }
    }
}
using System.ComponentModel;

namespace SenfoniYazilim.Erp.Common.Enums
{
    //Kart türümüzün index değerini veritabanına kaydedeceğiz, otomatik olarak kart türümüz int olarak gelir, bunu biz byte yapmak istiyoruz
    //bunun için ise KartTuru:byte diyerek byte çeviririz..
    public enum KartTuru:byte
    {
        [Description("Okul Kartı")]//mesaj box da çıkacak olan kart türü adını bu attribute aracılığıyla atayacağız.
        //Ve bu decription ları okuyabilmek için common dll inde enumfunction adında bir sınıf tanımlayıp,gerekli metodları,
        //bu sınıfda oluşturacağız....
        Okul=1,
        [Description("İl Kartı")]
        Il=2,
        [Description("İlçe Kartı")]
        Ilce=3,
        [Description("Filtre Kartı")]
        Filtre =4,
        [Description("Aile Bilgi Kartı")]
        AileBilgi=5,
        [Description("İptal Nedeni Kartı")]
        IptalNedeni=6,
        [Description("Yabancı Dil Kartı")]
        YabanciDil=7,
        [Description("Teşvik Kartı")]
        Tesvik=8,
        [Description("Kontenjan Kartı")]
        Kontenjan=9,
        [Description("Rehber Kartı")]
        Rehber=10,
        [Description("Sınıf Grup Kartı")]
        SinifGrup=11,
        [Description("Meslek Kartı")]
        Meslek=12,
        [Description("Yakınlık Kartı")]
        Yakinlik=13,
        [Description("İşyeri Kartı")]
        Isyeri=14,
        [Description("Görev Kartı")]
        Gorev=15,
        [Description("İndirim Türü Kartı")]
        IndirimTuru = 16,
        [Description("Evrak Kartı")]
        Evrak=17,
        [Description("Promosyon Kartı")]
        Promosyon=18,
        [Description("Servis Kartı")]
        Servis=19,
        [Description("Sınıf Kartı")]
        Sinif=20,
        [Description("Hizmet Türü Kartı")]
        HizmetTuru=21,
        [Description("Hizmet Kartı")]
        Hizmet=22,
        [Description("Özel Kod Kartı")]
        OzelKod=23,
        [Description("Kasa Kartı")]
        Kasa=24,
        [Description("Banka Kartı")]
        Banka=25,
        [Description("Banka Şube Kartı")]
        BankaSube=26,
        [Description("Avukat Kartı")]
        Avukat=27,
        [Description("Cari Kartı")]
        Cari=28,
        [Description("Ödeme Türü Kartı")]
        OdemeTuru=29,
        [Description("Banka Hesap Kartı")]
        BankaHesap=30,
        [Description("İletişim Kartı")]
        Iletisim=31,
        [Description("Öğrenci Kartı")]
        Ogrenci=32,
        [Description("İndirim Kartı")]
        Indirim=33,
        [Description("Tahakkuk Kartı")]
        Tahakkuk=34,
        [Description("Makbuz Kartı")]
        Makbuz=35,
        [Description("Belge Seçim Kartı")]
        BelgeSecim=36,
        [Description("Belge Hareketleri")]
        BelgeHareketleri=37,
        [Description("Rapor Kartı")]
        Rapor=38,
        [Description("Rapor Tasarım")]
        RaporTasarım = 39,
        [Description("Fatura Kartı")]
        Fatura = 40,
        [Description("Stok Kartı")]
        Stok=41,
        [Description("Reçete Kartı")]
        Recete = 42,
        [Description("Mrp Kartı")]
        Mrp=43,
        [Description("Öğrenci Kartı Raporu")]
        OgrenciKartiRaporu = 44,
        [Description("Operasyon Kartı")]
        Operasyon = 45,
        [Description("Makina Kartı")]
        Makina = 46,
        [Description("Depo Kartı")]
        Depo = 47,
        [Description("Vardiya Sistem Kartı")]
        Vardiya = 48,
        [Description("Kullanıcı Parametre Kartı")]
        KullaniciParametre = 49,
        [Description("Şube Kartı")]
        Sube = 50,
        [Description("Kurum Kartı")]
        Kurum = 51,
        [Description("İstasyon Kartı")]
        Istasyon = 52,
        [Description("Personel Kartı")]
        Personel = 53,
        [Description("Rezervasyon Kartı")]
        Rezerve = 54,
        [Description("İş Emri Kartı")]
        IsEmri = 55,
        [Description("Uretim Sonu Kayıt Kartı")]
        UretimSonuKayit = 56,
        [Description("Stok Hareket Kartları")]
        StokHareket = 57,
        [Description("Depolar Arası Transfer Kartı")]
        DepolarArasiTransfer = 58,
        [Description("İş Emri Raporu")]
        IsEmriRaporu = 59,
        [Description("Donem Kartı")]
        Donem = 60,
        [Description("Rol Kartı")]
        Rol = 61,
        [Description("Yetki Kartı")]
        Yetki = 62,
        [Description("Kullanıcı Kartı")]
        Kullanici = 63,
        [Description("Sipariş Kartı")]
        Order = 64,
        [Description("Stok Duzeltme Kartı")]
        DepoStokDuzelt = 65,
        [Description("Ürün Talep Kartı")]
        ProductionDemand = 66,
        [Description("Döviz")]
        Doviz = 67,
        [Description("Satış")]
        Satis = 68,
        [Description("Birim")]
        Birim = 69,
        [Description("Sevkiyat Şekli")]
        SevkiyatSekli = 70,
        [Description("Satınalma Talep")]
        SatinalmaTalep = 71,
        [Description("Satınalma Talep Kalemleri")]
        PurchaseDemandItems = 72,
        [Description("Kdv")]
        Kdv = 73,
        [Description("Satınalma Teklif")]
        PurchaseOffer = 74,
        [Description("Satınalma Siparişi")]
        PurchaseOrder = 75,
        [Description("Ülke")]
        Country=76,
        [Description("Fiyat Listesi")]
        PriceList=77,
        [Description("Satınalma Süreç Ayarlar")]
        PurchaseSettings = 78,
        [Description("Satınalma İrsaliyesi")]
        PurchaseWayBill = 79,
        [Description("Satış Teklifi")]
        SalesOffer = 80,
        [Description("Satış Teklif Kalemleri")]
        SalesOfferItems = 81,
        [Description("Satış")]
        Sales= 82,
        [Description("Satış Kalemleri")]
        SalesItems = 83,
        [Description("DepolarArası Transfer Talep Kartı")]
        TransferDemandBetweenWarehouses = 84,
        [Description("Kulanıcı Kartı")]
        User=85,
        [Description("Kapasite İhtiyaç Planlama Kartı")]
        Crp = 86,
        [Description("Depo Ayarları")]
        WarehouseSettings=87,
        [Description("Sevk İrsaliye Kartı")]
        DispatchWayBill=88,
        [Description("Sevk İrsaliye Kalemleri Listesi")]
        DispatchWayBillItems=89,
        [Description("Satınalma İrsaliye Kalemleri Listesi")]
        PurchaseWayBillItems = 91,
        [Description("Malzeme İhtiyaç Planlama")]
        MaterialRequirmentPlaning = 92,
        [Description("Özellik")]
        Feature = 93,
    }
}

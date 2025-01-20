using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Common.Message
{
    public class Messages
    {
        public static void HataMesaji(string hataMesaji)
        {
            XtraMessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void UyariMesaji(string uyariMesaji)
        {
            XtraMessageBox.Show(uyariMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void BilgiMesaji(string bilgiMesaji)
        {
            XtraMessageBox.Show(bilgiMesaji, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult EvetSeciliEvetHayir(string mesaj,string baslik)
        {
           return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
        }

        public static DialogResult HayirSeciliEvetHayir(string mesaj,string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult SilMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} silinecektir.Onaylıyor musunuz?", "Silme Onayı");// $ işaret süslü parantez içindeki deişkeni kullanıldığı yerde sitrin ifadeye ekler.. 
        }
        public static DialogResult SilMesajIptal(string kartAdi)
        {
            return EvetSeciliEvetHayirIptal($"Seçtiğiniz {kartAdi} silinecektir.Onaylıyor musunuz?", "Silme Onayı");// $ işaret süslü parantez içindeki deişkeni kullanıldığı yerde sitrin ifadeye ekler.. 
        }
        public static DialogResult KapatMesajIptal(string kartAdi)
        {
            return EvetSeciliEvetHayirIptal($"Seçtiğiniz {kartAdi} Kapatılacaktır.Onaylıyor musunuz?", "Kapatma Onayı");// $ işaret süslü parantez içindeki deişkeni kullanıldığı yerde sitrin ifadeye ekler.. 
        }
        public static DialogResult EvetSeciliEvetHayirIptal(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult KapanisMesaj()
        {            
            return EvetSeciliEvetHayir(" Yapılan Değişiklikler Kaydedilecektir, Onaylıyor musunuz ?", "Çıkış Onay");
        }

        public static DialogResult KayitMesaj()
        {
            return EvetSeciliEvetHayirIptal("Yapılan Değişiklikler Kayıt Edilsin Mi?", "Kayıt Onay");
        }

        public static void KartSecmemeUyariMesaji()
        {
            UyariMesaji("Lütfen Bir Kart Seçiniz.");
        }

        public static void MukerrerKayitHataMesaji(string alanAdi)
        {
            HataMesaji($"Girmiş Olduğunuz {alanAdi} Daha Önce Kullanılmıştır.");
        }

        public static void HataliVeriMesaji(string alanAdi)
        {
            HataMesaji($"{alanAdi} Alanına Geçerli Bir Değer Girmelisiniz .");
        }

        public static DialogResult TabloExporMesaj(string dosyaFormati)
        {
            return EvetSeciliEvetHayir($"İlgili Tablo {dosyaFormati} Olarak Dışarı Aktarılacaktır. Onaylıyor Musunuz ?","Aktarım Onay" );
        }

        public static void KartBulunamadiMesaji(string kartTuru)
        {
            UyariMesaji($"İşlem Yapılabilecek {kartTuru} Bulunamadı .");
        }
        public static void KayıtSilinemezMesaji(string uyari= "Hareket Görmüş Kayıt Silinemez !")
        {
            UyariMesaji(uyari);
        }
        public static void TabloEksikBilgiMesaji(string tabloAdi)
        {
            UyariMesaji($"{tabloAdi}nda Eksik Bilgi Girişi Var. Lütfen Kontrol Ediniz .");
        }

        public static void IptalHareketSilinemezMesaji()
        {
            HataMesaji("İptal Edilen Hareketler Silinemez .");
        }

        public static DialogResult IptalMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} İptal Edilecektir.Onaylıyor musunuz?", "Iptal Onayı");// $ işaret süslü parantez içindeki deişkeni kullanıldığı yerde sitrin ifadeye ekler.. 
        }

        public static DialogResult IptalGerialMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} Kartına Uygulanan İptal İşlemi Geri Alınacaktır . Onaylıyor musunuz?", "Iptal Geri Al Onayı");// $ işaret süslü parantez içindeki deişkeni kullanıldığı yerde sitrin ifadeye ekler.. 
        }

        public static void SecimHataMesaji(string alanAdi)
        {
            HataMesaji($"{alanAdi} Seçimi Yapmalısınız .");
        }

        public static void OdemeBelgesiSilinemezMesaji(bool dahaSonra)
        {
            UyariMesaji(dahaSonra
                ?"Ödeme Belgesinin Daha Sonra İşlem Görmüş Hareketleri Var. Odeme Belgesi Silinemez."
                : "Ödeme Belgesinin İşlem Görmüş Hareketleri Var. Odeme Belgesi Silinemez."
                );
        }

        public static DialogResult RaporuTasarimaGonderMesaj()
        {
            return HayirSeciliEvetHayir("Rapor Tasarım Görünümünde Açılacaktır . Onaylıyor musunuz?", "Onay");// $ işaret süslü parantez içindeki deişkeni kullanıldığı yerde sitrin ifadeye ekler.. 
        }

        public static void TopluHareketSilMesaj(string bilgiMesaji)
        {
            XtraMessageBox.Show(bilgiMesaji+" Silinemedi .", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult EmailGonderimOnayi()
        {
            return HayirSeciliEvetHayir(" Kullanıcı Şifresi Sıfırlanarak, Kullanıcı Bilgileri İçeren Yeni Bir Email Gönderilecektir , Onaylıyor Musunuz? ", "Onay");
        }
        public static DialogResult RaporuKapatmaMesaj()
        {
            return HayirSeciliEvetHayir("Rapor Kapatılacaktır . Onaylıyor musunuz?", "Onay");// $ işaret süslü parantez içindeki deişkeni kullanıldığı yerde sitrin ifadeye ekler.. 
        }
    }
}

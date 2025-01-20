using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Properties;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Model.Dto;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Linq.Expressions;
using DevExpress.XtraVerticalGrid;
using System.Security.Cryptography;
using System.Text;
using System.Net.Mail;
using System.Net;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using static System.Windows.Forms.Form;
using DevExpress.XtraGrid;
using DevExpress.XtraSplashScreen;

namespace SenfoniYazilim.Erp.UI.Wİn.Functions
{
    public static class GeneralFunctions
    {
        private static GridView _tablo;
        private static MalzemeIhtiyacBilgileriL _mib;
        private static IList<MalzemeIhtiyacBilgileriL> _rvbIcinElemanList=new List<MalzemeIhtiyacBilgileriL>();
        private static IList _source;
        private static bool _uretimSonuKaydiMi;

        public static void SplashBaslat(SplashScreenManager manager)
        {
            if (manager.IsSplashFormVisible)
            {
                manager.CloseWaitForm();
                manager.ShowWaitForm();
            }
            else
                manager.ShowWaitForm();
        }
        public static void SplashDurdur(SplashScreenManager manager)
        {
            if (manager.IsSplashFormVisible)
                manager.CloseWaitForm();
        }
        public  static long GetRowId(this GridView tablo)
        {
            if (tablo.FocusedRowHandle>-1)
                return Convert.ToInt64(tablo.GetFocusedRowCellValue("Id"));
            else
                Messages.KartSecmemeUyariMesaji();
            return -1;
        }
        /// <summary>
        /// proje3 , video 22, dakika 32 iletişim bilgileri tablosu işlemleri
        /// </summary>
        /// <param name="tablo"></param>
        /// <param name="idColumn"></param>
        /// <returns></returns>
        public static long GetRowCellId(this GridView tablo,GridColumn idColumn)
        {
            var value = tablo.GetRowCellValue(tablo.FocusedRowHandle, idColumn);
            //if (value == null)
            //    return -1;
            //else
            //    return (long)value;
            return (long?)value ?? -1;
        }

        public static long GetRowCellId(this GridView tablo, GridColumn idColumn,string invalidVariant=null)
        {
            var value =Convert.ToInt32( tablo.GetRowCellValue(tablo.FocusedRowHandle, idColumn));
            if ((long)value > 0)
                return (long)value;
            else
                return -1;
            //return (long)value;
        }

        public static T GetRow<T>(this GridView tablo,bool mesajVer=true)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(tablo.FocusedRowHandle);

            if (mesajVer)
                Messages.KartSecmemeUyariMesaji();
            return default(T);
        }

        public static T GetRow<T>(this GridView tablo, int rowHandle)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(rowHandle);
            //Messages.KartSecmemeUyariMesaji();
            return default(T);
        }
        
        private static VeriDegisimYeri VeriDegisimYeriGetir<T>(T oldEntity, T currentEntity) 
        {
            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                
                //aşağıdaki iki soru işareti, '??', null değerler karşılaştırılamayacağı için oldEntity ile gelen değer null
                //ise deyip ,daha sonraki ifade ile birlikte, boş bir sitringe dönüştürülür...
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;

                var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                //bazı veriler,resim gibi, byte dizisi şeklinde tanımlanır ve karşılaştırma yapacağımız alanlar içerisinde böyle
                //bir verinin olup olmadığını kontrol etmek için aşağıdaki kontrol yazılmıştır..çünki sayısal veriler
                //uzunlukları ile karşılaştırılabilirler...
                if (prop.PropertyType == typeof(byte[]))
                {
                    //şimdi burada ise örneğin öğreci veirisi güncellenecek ve boş olan resim alanına bir resim atanacak.
                    //bu durumda eski değer empy iken yeni değer bir byte dizisi olmuş olacak ve bunları karşılaştırabilmek içinn
                    //aynı tipte olmaları gerekir..
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                        oldValue = new byte[] { 0 };
                    if (string.IsNullOrEmpty(currentValue.ToString()))
                        currentValue = new byte[] { 0 };
                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                        return VeriDegisimYeri.Alan;
                }
                else if (prop.PropertyType == typeof(SecureString))
                {
                    var oldStr = ((SecureString)oldValue).ConvertToUnSecureString();
                    var curStr = ((SecureString)currentValue).ConvertToUnSecureString();

                    if (!curStr.Equals(oldStr))
                        return VeriDegisimYeri.Alan;
                }
                else if (!currentValue.Equals(oldValue))
                    return VeriDegisimYeri.Alan;
            }
            return VeriDegisimYeri.VeriDegisimiYok;
        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet,BarButtonItem btnGeriAl,BarButtonItem btnSil, T oldEntity,T currentEntity)
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
            var buttonEnabledDurum = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnabledDurum;
            btnGeriAl.Enabled = buttonEnabledDurum;
            btnYeni.Enabled = !buttonEnabledDurum;
            btnSil.Enabled = !buttonEnabledDurum;
        }

        public static void ButtonEnabledDurumu(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil)
        {            
            btnKaydet.Enabled = false;
            btnGeriAl.Enabled = false;
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T oldEntity, T currentEntity,bool tableValueChanged)
        {
            var veriDegisimYeri =tableValueChanged?VeriDegisimYeri.Tablo: VeriDegisimYeriGetir(oldEntity, currentEntity);
            var buttonEnabledDurum = veriDegisimYeri == VeriDegisimYeri.Alan||veriDegisimYeri==VeriDegisimYeri.Tablo;

            btnKaydet.Enabled = buttonEnabledDurum;
            btnGeriAl.Enabled = buttonEnabledDurum;
            btnYeni.Enabled = !buttonEnabledDurum;
            btnSil.Enabled = !buttonEnabledDurum;
        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnKaydet, BarButtonItem btnFarkliKaydet, BarButtonItem btnSil,IslemTuru islemTuru, T oldEntity, T currentEntity)
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
            var buttonEnabledDurum = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnabledDurum;
            btnFarkliKaydet.Enabled = islemTuru!=IslemTuru.EntityInsert;
            btnSil.Enabled =! buttonEnabledDurum;
        }
        public static void ButtonEnabledDurumu(BarButtonItem btnKaydet, BarButtonItem btnGeriAl,bool tableValueChanged)
        {
            var buttonEnabledDurum = tableValueChanged;

            btnKaydet.Enabled = buttonEnabledDurum;
            btnGeriAl.Enabled = buttonEnabledDurum;
        }
        //aşağıdaki metod extention bir metoddur. yani bu metoda IslemTuru Aracılığıyla ulaşacağız BaseEditForm yüklenirken çalıştırılacak
        //bir metod olacaktır...
        public static DaysOfWeek GetEnumOfDayOfWeek(this DayOfWeek dayOfWeek)
        {
            if (dayOfWeek == DayOfWeek.Monday)
                return DaysOfWeek.Monday;
            else if (dayOfWeek == DayOfWeek.Saturday)
                return DaysOfWeek.Saturday;
            else if (dayOfWeek == DayOfWeek.Sunday)
                return DaysOfWeek.Sunday;
            else if (dayOfWeek == DayOfWeek.Thursday)
                return DaysOfWeek.Thursday;
            else if (dayOfWeek == DayOfWeek.Tuesday)
                return DaysOfWeek.Tuesday;
            else if (dayOfWeek == DayOfWeek.Wednesday)
                return DaysOfWeek.Wednesday;
            else //if (dayOfWeek == DayOfWeek.Saturday)
                return DaysOfWeek.Friday;
        }
        public static DateTime ChangeTime(this DateTime dateTime, int hours, int minutes, int seconds, int milliseconds)
        {
            return new DateTime(
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                hours,
                minutes,
                seconds,
                milliseconds,
                dateTime.Kind);
        }
        public static long IdOlustur(this IslemTuru islemTuru,BaseEntity selectedEntity)
        {
            string SifirEkle(string deger)
            {
                if (deger.Length == 1)
                    return "0" + deger;
                return deger;
            }

            string UcBasamakYap(string deger)
            {
                switch (deger.Length)
                {
                    case 1:
                        return "00" + deger;
                    case 2:
                        return "0" + deger;
                }
                return deger;
            }

            string Id()
            {
                var yil = SifirEkle(DateTime.Now.Date.Year.ToString());
                var ay = SifirEkle(DateTime.Now.Date.Month.ToString());
                var gun = SifirEkle(DateTime.Now.Date.Day.ToString());
                var saat = SifirEkle(DateTime.Now.Hour.ToString());
                var dakika = SifirEkle(DateTime.Now.Minute.ToString());
                var saniye = SifirEkle(DateTime.Now.Date.Second.ToString());
                var milisaniye = UcBasamakYap(DateTime.Now.Millisecond.ToString());
                var random = SifirEkle(new Random().Next(0, 99).ToString());

                return yil + ay + gun + saat + dakika + saniye + milisaniye + random;
            }

            var id = Id();

            return islemTuru == IslemTuru.EntityUpdate ? selectedEntity.Id : long.Parse(Id()); 
        }

        public static void ControlEnabledChanged(this MyButtonEdit baseEdit, Control prmEdit)
        {
            switch (prmEdit)
            {
                case MyButtonEdit edt:
                    edt.Enabled = baseEdit.Id.HasValue&&baseEdit.Id>0;//BaseEdit ıd sinde bir değer varsa true yoksa false Yap...
                    edt.Id = null;
                    edt.EditValue = null;
                    break;
                case MyTextEdit edt:
                    edt.Enabled = baseEdit.Id.HasValue && baseEdit.Id > 0;//BaseEdit ıd sinde bir değer varsa true yoksa false Yap...
                    edt.EditValue = null;
                    break;
                case PropertyGridControl pGrd:
                    pGrd.Enabled = baseEdit.Id.HasValue && baseEdit.Id > 0;//BaseEdit ıd sinde bir değer varsa true yoksa false Yap...
                    if (!pGrd.Enabled)
                        pGrd.SelectedObject = null;
                    break;
            }
        }

        public static void ControlEnabledChanged(this BaseEdit baseEdit, Control prmEdit, bool enabled)
        {
            prmEdit.Enabled = enabled;
            if (prmEdit is MyCheckEdit)
                ((MyCheckEdit)prmEdit).Checked = true;
        }


        public static void ControlEnabledChanged(this BaseEdit baseEdit,bool enabled)
        {
            baseEdit.Enabled = enabled;
        }
        public static void EnabledFalse(Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = false;
            }
        }
        public static void RowFocus(this GridView tablo,string aranacakKolon,object aranacakDeger)
        {
            var rowHandle = 0;

            for (int i = 0; i < tablo.RowCount; i++)
            {
                var bulunanDeger = tablo.GetRowCellValue(i, aranacakKolon);

                if (aranacakDeger.Equals(bulunanDeger))//metodda aranacakDeğer parametresi bir nesne olarak tanımlandığı için Equals()
                    rowHandle = i;                      // metodu kullanılmıştır..
            }

            tablo.Focus();

            tablo.FocusedRowHandle = rowHandle;
        }

        public static void RowFocus(this GridView tablo,int rowhandle)
        {
            if (rowhandle <= 0) return;
            if (rowhandle == tablo.RowCount - 1)
                tablo.FocusedRowHandle = rowhandle;
            else
                tablo.FocusedRowHandle = rowhandle - 1;
        }
        
        public static void FillLookUpEdit<T>(this MyLookUpEdit lookUpEdit, IEnumerable<T> _source,string valueMember ,string disPlayMember) where T :IBaseEntity
        {
            var list = _source?.Cast<T>()?.ToList();
            lookUpEdit.Properties.DataSource = list;
            lookUpEdit.Properties.ValueMember = valueMember;
            lookUpEdit.Properties.DisplayMember = disPlayMember;
            lookUpEdit.ItemIndex = 0;
        }
        public static void SagMenuGoster(this MouseEventArgs e, PopupMenu sagMenu)
        {
            if (e.Button != MouseButtons.Right) return;
            sagMenu.ShowPopup(Control.MousePosition);
        }

        public static List<string> YazicilariListele()
        {
            return PrinterSettings.InstalledPrinters.Cast<string>().ToList();
        }

        public static string DefaultYazici()
        {
            var setting = new PrinterSettings();
            return setting.PrinterName;
        }

        public static void ShowPopupMenu(this MouseEventArgs e,PopupMenu popupMenu)
        {
            if (e.Button != MouseButtons.Right) return;
            popupMenu.ShowPopup(Control.MousePosition);
        }

        public static byte[] ResimYukle()
        {
            var dialog = new OpenFileDialog
            {
                Title="Resim Seç",
                Filter= "Resim Dosyaları(*.bmp,*.gif,*.jpg,*.png)|*.bmp; *.gif; *.jpg; *.png|Bmp Dosyaları|*.bmp|Gif Dosyaları|*.gif|Jpg Dosyaları|*.jpg|Png Dosyaları|*.png",
                InitialDirectory=@"C:\",
            }; 
            byte[] Resim()
            {
                using (var stream = new MemoryStream())
                {
                    Image.FromFile(dialog.FileName).Save(stream, ImageFormat.Png);
                    return stream.ToArray();
                }
            }

            return dialog.ShowDialog() != DialogResult.OK ? null : Resim();
        }
        
        public static BindingList<T> toBindingList<T>(this IEnumerable<BaseHareketEntity> list)
        {
            return new BindingList<T>((IList<T>)list);
        }

        public static BaseTablo AddTable(this BaseTablo tablo,BaseEditForm frm)
        {
            tablo.Dock = DockStyle.Fill;
            tablo.OwnerForm = frm;
            return tablo;
        }

        public static void LayoutControlInsert(this LayoutGroup grup,Control control,int columnIndex,int rowIndex,int columnSpan,int rowSpan)
        {
            var item = new LayoutControlItem
            {
                Control=control,
                Parent=grup
            };

            item.OptionsTableLayoutItem.ColumnIndex = columnIndex;
            item.OptionsTableLayoutItem.ColumnSpan = columnIndex;
            item.OptionsTableLayoutItem.RowIndex = rowIndex;
            item.OptionsTableLayoutItem.RowSpan = rowSpan;
        }

        public static void RowCellEnabled(this GridView tablo)
        {
            var rowHandle = tablo.FocusedRowHandle;

            tablo.FocusedRowHandle = 0;
            tablo.ClearSelection();

            tablo.FocusedRowHandle = rowHandle;
        }

        public static void CreatDropDownMenu(this BarButtonItem baseButton,BarItem[] buttonItems)
        {
            baseButton.ButtonStyle = BarButtonStyle.CheckDropDown;
            var popupMenu = new PopupMenu();
            buttonItems.ForEach(x => x.Visibility = BarItemVisibility.Always);
            popupMenu.ItemLinks.AddRange(buttonItems);
            baseButton.DropDownControl = popupMenu;
        }

        public static MyXtraReport StreamToReport(this MemoryStream stream)
        {
            return (MyXtraReport)XtraReport.FromStream(stream, true);
        }

        public static MemoryStream ByteToStream(this byte[] report)
        {
            return new MemoryStream(report);
        }

        public static MemoryStream RaportToStream(this XtraReport rapor)
        {
            var stream = new MemoryStream();
            rapor.SaveLayout(stream);
            return stream;
        }

        public static DateTime BaslamaTarihiHesapla(this ReceteBilgileriL rbl,DateTime baslamaTarihi,DateTime bitisTarihi,decimal opSure,decimal hazSure)
        {
            var eklenecekGunSayisi = (double)(opSure + hazSure);
            var tarih = baslamaTarihi.AddDays(eklenecekGunSayisi);
            var tarih2 = (double)(bitisTarihi - tarih).Days;
            var _baslamaTarihi = baslamaTarihi.AddDays(tarih2);
            return _baslamaTarihi;
        }
        public static DateTime BaslamaTarihiHesapla(this BaseHareketEntity rbl, DateTime bitisTarihi,decimal miktar)
        {
            var receteEntity = (ReceteBilgileriL)rbl;

            using (var bll=new ReceteBilgileriBll())
            {
                var anaRecete = GetAnySingleOrListBll.GetRecete(x => x.Id == receteEntity.ReceteId);//bll.List(x => x.StokId == receteEntity.StokId && x.Uretilebilir == Uretilebilir.AnaKod).Cast<ReceteBilgileriL>().FirstOrDefault();
                if (anaRecete == null || anaRecete.ReceteOperasyonBilgileri==null)
                    return bitisTarihi;
                var receteOperasyonSuresi = anaRecete?.ReceteOperasyonMakinaBilgileri?.Sum(x=>x.OperasyonSuresi);
                var receteOpersyonHazirlikSuresi= anaRecete.ReceteOperasyonMakinaBilgileri?.Sum(x=>x.MakinaHazirlikSuresi);
                var eklenecekGunSayisi = (double)(receteOperasyonSuresi * miktar / anaRecete.Miktar+Convert.ToDecimal( receteOpersyonHazirlikSuresi)) / 540;
                var _baslamaTarihi = new DateTime();
                int toplamTatilSayisi = 0;

                for (int i = 1; i <= eklenecekGunSayisi; i++)
                {
                    if (bitisTarihi.AddDays(-i).DayOfWeek == DayOfWeek.Sunday)
                        toplamTatilSayisi++;
                }
                _baslamaTarihi = bitisTarihi.AddDays(-(toplamTatilSayisi + eklenecekGunSayisi));
                return _baslamaTarihi;
            }
        }

        public static DateTime BaslamaTarihiHesapla(this decimal kapasiteIhtiyaci, DateTime bitisTarihi)
        {
            var eklenecekGunSayisi = (double)kapasiteIhtiyaci / 540;
            var _baslamaTarihi = new DateTime();
            int toplamTatilSayisi = 0;

            for (int i = 1; i <= eklenecekGunSayisi; i++)
            {
                if (bitisTarihi.AddDays(-i).DayOfWeek == DayOfWeek.Sunday)
                    toplamTatilSayisi++;
            }
            _baslamaTarihi = bitisTarihi.AddDays(-(toplamTatilSayisi + eklenecekGunSayisi));
            return _baslamaTarihi;
        }
        public static DateTime BitisTarihiHesapla(this decimal kapasiteIhtiyaci, DateTime baslamaTarihi)
        {
            var eklenecekGunSayisi = (double)kapasiteIhtiyaci / 540;
            var _baslamaTarihi = new DateTime();
            int toplamTatilSayisi = 0;
            
            for (int i = 1; i >=(int)eklenecekGunSayisi; i++)
            {
                if ((int)eklenecekGunSayisi <= 1) continue;
                if (baslamaTarihi.AddDays(i).DayOfWeek == DayOfWeek.Sunday)
                    toplamTatilSayisi++;
            }
            _baslamaTarihi = baslamaTarihi.AddDays((toplamTatilSayisi + eklenecekGunSayisi));
            return _baslamaTarihi;
        }
        public static decimal KapasiteHesaplaDakika(DateTime baslamaTarihi, DateTime bitisTarihi, long vardiyaId)
        {
            decimal eklenecekDakika = 0;
            var donguSayisi = (bitisTarihi.Date - baslamaTarihi.Date).Days;

            for (int i = 0; i < donguSayisi; i++)
            {
                var currentDay = baslamaTarihi.AddDays(i).Date;
                var resmiTatil = SingleTatilBilgileri(currentDay);
                var vardiyaList = ListVardiyaBilgileri(vardiyaId)?.Where(x => x.Gun.ToString() == currentDay.DayOfWeek.ToString());

                if (resmiTatil != null && resmiTatil.ZamanDilimi == SliceOfDay.Tam) continue;

                else if(resmiTatil != null && resmiTatil.ZamanDilimi == SliceOfDay.Yarim)
                {
                    if (vardiyaList == null) continue;
                    eklenecekDakika += vardiyaList.Sum(x => x.Kapasite);
                }
                else if(vardiyaList!=null)
                    eklenecekDakika += vardiyaList.Sum(x => x.Kapasite);

            }

            return eklenecekDakika ;

        }
        public static bool HataliGirisKontrol(this BaseEdit baseEdit, Control prmEdit, bool yarim, object value)
        {
            switch (prmEdit)
            {

                case TimeEdit edt:
                    var deger = DateTime.Parse(value.ToString()).ToShortTimeString();
                    if (!yarim && (value == null||deger=="00:00"))
                    {
                        Messages.HataMesaji($"{edt.Name.Remove(0,3)} Alanına Geçerli Bir Değer Girmelisiniz !");
                        edt.Focus();
                        return true;
                    }
                    break;

                case MySpinEdit edt:
                   
                    if (!yarim &&  !((decimal)value>=0))
                    {
                        Messages.HataMesaji($"{edt.Text} Alanına Geçerli Bir Değer Girmelisiniz !");
                        edt.Focus();
                        return true;
                    }
                    break;                
            }
            return false;
        }
        public static void AppSettingsWrite(string key,string value)
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        public static void CreateConnectionString(string initialCatalog,string server,SecureString kullaniciAdi,SecureString sifre,YetkilendirmeTuru yetkilendirmeTuru)
        {
            SqlConnectionStringBuilder builder = null;

            switch (yetkilendirmeTuru)
            {
                case YetkilendirmeTuru.SqlServer:
                    builder = new SqlConnectionStringBuilder
                    {
                        DataSource = server,
                        UserID = kullaniciAdi.ConvertToUnSecureString(),
                        Password = sifre.ConvertToUnSecureString(),
                        InitialCatalog= initialCatalog,
                        MultipleActiveResultSets= true/* normal Database çalışma Mantığı her bir connectionstring server a 
                        bağlanıldığında connection açılıyor, açılan bu connection dan birtane işlem yapılıyor ve tekrar kapatılıyor
                        ancak MultipleActiveResultSets(MARS) true yaptığımızda bir connectionstring den birden çok sorgulama işlemi
                        yapılabilmektedir ve biz tek bir connectionstring ile çalışıp onun initialcatolg yada ilgili başka alanlarını
                        değiştirerek server yada veritabanı bağlantıları sağlayacağımız için bu yapı true olarak belirlenir.*/
                    };
                    break;
                case YetkilendirmeTuru.Windows:
                    builder = new SqlConnectionStringBuilder
                    {
                        DataSource = server,
                        InitialCatalog = initialCatalog,
                        IntegratedSecurity=true,
                        MultipleActiveResultSets=true
                    };
                    break;
            }

            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.ConnectionStrings.ConnectionStrings["SenfoniErpContext"].ConnectionString = builder?.ConnectionString;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
            Settings.Default.Reset();
            Settings.Default.Save();
        }
        
        public static bool BaglantiKontrol(string server,SecureString kullaniciAdi,SecureString sifre,YetkilendirmeTuru yetkilendirmeTuru,bool genelMesajVer=false)
        {
            CreateConnectionString("", server, kullaniciAdi, sifre, yetkilendirmeTuru);

            using (var con = new SqlConnection(Bll.Functions.GeneralFunctions.GetConnectionString()))
            {
                try
                {
                    if (con.ConnectionString == "") return false;
                    con.Open();
                    return true;
                }
                catch (SqlException ex)
                {
                    if (genelMesajVer)
                    { 
                        Messages.HataMesaji("Server Bağlantı Ayarlarınız Hatalıdır, Lütfen Kontrol Ediniz .");
                        return false;
                    }
                    switch (ex.Number)
                    {
                        case 18456:
                            Messages.HataMesaji("Server Kullanıcı Adı veya Şifresi Hatalıdır .");                            
                            break;
                        default:
                            Messages.HataMesaji(ex.Message);
                            break;
                    }
                }
                return false;
            }
        }
        public static string Md5Sifrele (this string value)
        {
            var md5 = new MD5CryptoServiceProvider();
            var ba = Encoding.UTF8.GetBytes(value);
            ba = md5.ComputeHash(ba);

            var md5Sifrele = BitConverter.ToString(ba).Replace("-", "");

            return md5Sifrele;
        }
        public static (SecureString secureSifre,SecureString secureGizliKelime,string sifre,string gizliKelime) SifreUret()
        {
            string RandomDegerUret(int minValue,int count)
            {
                var random = new Random();
                const string karakterTablosu = "0123456789ABCDEFGHIJKLMNOPQRSTUVXWYZabcdefghijklmnopqrstuvxwyz";
                string sonuc = null;

                for (int i = 0; i < count; i++)
                    sonuc += karakterTablosu[random.Next(minValue, karakterTablosu.Length - 1)].ToString();

                return sonuc;
            }

            var secureSifre = RandomDegerUret(0, 8).ConvertToSecureString();
            var secureGizliKelime= RandomDegerUret(9, 10).ConvertToSecureString();
            var sifre = secureSifre.ConvertToUnSecureString().Md5Sifrele();
            var gizliKelime = secureGizliKelime.ConvertToUnSecureString().Md5Sifrele();

            return (secureSifre, secureGizliKelime,sifre, gizliKelime);
        }
        public static bool SifreMailiGonder(this string kullaniciAdi,string rol,string email,SecureString secureSifre,SecureString secureGizliKelime)
        {
            using (var bll=new MailParametreBll())
            {
                var entity = (MailParametre)bll.Single(null);
                if (entity == null)
                {
                    Messages.HataMesaji("Email Gönderilemedi. Kurumun Email Parametreleri Girilmemiş. Lütfen Kontrol Edip Tekrar Deneyiniz .");
                    return false;
                }
                var client = new SmtpClient
                {
                    Port = entity.PortNo,
                    Host = entity.Host,
                    EnableSsl = entity.SslKullan == EvetHayir.Evet,
                    UseDefaultCredentials = true,
                    Credentials = new NetworkCredential(entity.EMail, entity.Sifre.ConvertToSecureString())
                };

                var message = new MailMessage
                {
                    From=new MailAddress(entity.EMail,"Senfoni Yazılım"),
                    To = {email},
                    Subject="Senfoni Yazılım ERP Kullanıcı Bilgileri ",
                    IsBodyHtml=true,
                    Body="Senfoni ERP Programına Giriş İçin Gereken Kullanıcı Adı,  Şifre ve Gizli Kelime Bilgileri Aşaıdaki Gibidir.<br/>"+
                            "Lütfen Programa Giriş Yaptıktan Sonra Bu Bilgileri Değiştiriniz.<br/><br/><br/>"+
                            $"<b>Kullanıcı Adı :<b/> {kullaniciAdi}<br/>"+
                            $"<b>Yetki Türü :<b/> {rol}<br/>" +
                            $"<b>Şifre :<b/> {secureSifre.ConvertToUnSecureString()}<br/>" +
                            $"<b>Gizli Kelime :<b/> {secureGizliKelime.ConvertToUnSecureString()}<br/>" 
                };
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    client.Send(message);
                    Cursor.Current = Cursors.Default;
                    return true;
                }
                catch (Exception ex)
                {
                    Messages.HataMesaji(ex.Message);
                    return false;
                }
            }
        }
        public static bool YetkiKontrolu(this KartTuru kartTuru,YetkiTuru yetkiTuru)
        {
            if (AnaForm.KullaniciId == 0) return true;

            RolYetkileri yetkiler;
            using (var bll=new RolYetkileriBll())
                yetkiler = AnaForm.DonemParametreleri.YetkiKontroluAnlikYapilacak ? bll.Single(x => x.RolId == AnaForm.KullaniciRolId && x.KartTuru == kartTuru).EntityCovert<RolYetkileri>() : AnaForm.RolYetkileri.FirstOrDefault(x => x.KartTuru==kartTuru);
            var result = false;
            switch (yetkiTuru)
            {
                case YetkiTuru.Gorebilir:
                    result = yetkiler?.Gorebilir == 1;
                    break;
                case YetkiTuru.Ekleyebilir:
                    result = yetkiler?.Ekleyebilir == 1;
                    break;
                case YetkiTuru.Silebilir:
                    result = yetkiler?.Silebilir == 1;
                    break;
                case YetkiTuru.Degistirebilir:
                    result = yetkiler?.Degistirebilir == 1;
                    break;
            }
            if (!result)
                Messages.HataMesaji("Bu İşlem İçin Yetkiniz Bulunmamaktadır.");

            return result;
        }
        public static bool EditFormYetkiKontrolu(long id, KartTuru kartTuru)
        {
            var islemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;

            switch (islemTuru)
            {
                case IslemTuru.EntityInsert when !kartTuru.YetkiKontrolu(YetkiTuru.Ekleyebilir):
                    return false;
                case IslemTuru.EntityUpdate when !kartTuru.YetkiKontrolu(YetkiTuru.Degistirebilir):
                    return false;
            }
            return true;
        }

        public static void EncryptConfigFile(string configFileName,params string[] sectionName)
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(configFileName);
            foreach (var x in sectionName)
            {
                var section = configuration.GetSection(x);
                if (section.SectionInformation.IsProtected) return;
                else
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                section.SectionInformation.ForceSave = true;
                configuration.Save();
            }
        }
        public static List<MalzemeIhtiyacBilgileriL> MrpCalistir(this MalzemeIhtiyacBilgileriL mib, GridView tablo,IList source,bool uretimSonuKaydimi)
        {
            _tablo = tablo;
            _mib = mib;
            _source = source;

            //if (_mib.OperasyonSeviyesi > 0)
            //{
            //    //_mib.NetIhtiyac = _mib.NetIhtiyac - _mib.RezerveMiktar;
            //    _mib.KapasiteIhtiyaci = _mib.NetIhtiyac * _mib.OperasyonSuresi + _mib.HazirlikSuresi;
            //    _mib.TavsiyeEdilenUretimBaslamaTarihi = _mib.KapasiteIhtiyaci?.BaslamaTarihiHesapla(_mib.IhtiyacTarihi)??DateTime.Now;
            //    _mib.PlanlandigiTarih = _mib.TavsiyeEdilenUretimBaslamaTarihi;
            //    _mib.TahminiTeslimTarihi =_mib.KapasiteIhtiyaci!=null? Convert.ToDateTime(_mib.KapasiteIhtiyaci?.BitisTarihiHesapla(_mib.PlanlandigiTarih)):_mib.PlanlandigiTarih;
            //    _mib.Update = true;
            //    return null;
            //}

            var mibList=Mrp(_mib)?.Cast<MalzemeIhtiyacBilgileriL>().ToList();

            if (mibList!=null)
                 _tablo.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(mibList);

            return mibList;;
        }
        public static bool UretimSonuBagliIslemler(this List<MalzemeIhtiyacBilgileriL> mibL)
        {
            using (var bll = new WarehouseStockBll())
            {
                var eksiHareketEntities = new List<BaseHareketEntity>();

                foreach (var mib in mibL)
                {
                    if (mib.DepoId == null)
                    {
                        Messages.HataMesaji($"{_mib.StokAdi} Recetesine Ait Depo Bilgisi Tanımlanmamış Bir veya Daha Fazla Bileşen Mevcuttur./n/n" +
                            $"Lütfen İlgili Bileşen veya Bileşenlerin Depo Tanımlarını Oluşturduktan Sonra Uretim Sonu Kayıt İşlemini Yapınız .");
                        return false ;
                    }

                    var entity = SingleDepoStok(mib.StokId, mib.DepoId);//(DepoStokL)bll.Single(y => y.DepoId == x.DepoId && y.StokId == x.StokId);

                    if (entity == null)
                    {
                        Messages.HataMesaji($"{mib.DepoAdi}' da {mib.StokKodu} Kodlu Kaleme Ait Stok Bulunamadı./n/n Lütfen Depo Stok Bilgilerinizi Gözden Geçiriniz .");
                        return false;
                    }
                    //if (entity.Miktar < mib.KayitMiktari && mib.Uretim)
                    //{
                    //    Messages.HataMesaji($"{mib.StokKodu} Kodlu Kaleme Ait Stok Miktarı Yetersizdir, Üretim Sonu Kayıt İşlemi Gerçekleştirilemez .");
                    //    return false;
                    //}
                }

                if (!mibL.KaydetUretimSonuBilgileri())
                {
                    Messages.HataMesaji("Uretim Sonu Kayıt İşlemi Esnasında Bir Hata Oluştu, Kayıt Bilgileri İlgili Tabloya Aktarılamadı. .");
                    return false;
                }
                foreach (var mib in mibL)
                {
                    var depoStokEntity = SingleDepoStok(mib.StokId, mib.DepoId);

                    if (depoStokEntity.Quantity < mib.KayitMiktari &&!mib.Filter)
                    {
                        var eksiEntity = new EksiyeDusenStokBilgileri
                        {
                            Id = 0,
                            DepoId = depoStokEntity.WareHouseId,
                            StokId = depoStokEntity.MaterialId,
                            IslemOncesiStokMiktari = depoStokEntity.Quantity,
                            IslemMiktari = mib.KayitMiktari,
                            IslemSonrasiStokMiktari=depoStokEntity.Quantity-mib.KayitMiktari,
                            YapilanIslem = "Uretim Sonu Kayıt İşlemi",
                            IslemTarihi = DateTime.Now
                        };
                        eksiHareketEntities.Add(eksiEntity);
                    }

                    var hareketCinsi = $"{mib.StokKodu} Stok Kodlu,{mib.StokAdi} Ürününe Ait Üretim Sonu Kaydı";
                    mib.KaydetStokHareketi(mib.StokId, mib.DepoId.Value, mib.Id, mib.KayitMiktari,mib.Filter? "Giriş":"Çıkış", hareketCinsi);

                    depoStokEntity.Quantity =mib.Filter? depoStokEntity.Quantity + mib.KayitMiktari
                        : depoStokEntity.Quantity - mib.KayitMiktari;
                    //StokHareket Kayıt işlemi depo stok güncelleme işleminden önce yapılmalıdır,
                    //çünki işlemöncesistokmiktari property si güncelleme işleminden önce DepoStok'dan çekilip atamsı yapılmalıdır.

                    depoStokEntity.UpdateDepoStok();

                    if (mib.RezerveMiktar > 0&&!mib.Filter)
                        RezerVasyonGuncelle(mib);
                }

                EksiKaydet(eksiHareketEntities);

                return true;
                void EksiKaydet(List<BaseHareketEntity> _eksihareketEntities)
                {
                    using (var eksiBll = new EksiyeDusenStokBilgileriBll())
                    {
                        eksiBll.Insert(_eksihareketEntities);
                    }
                }
                void RezerVasyonGuncelle(MalzemeIhtiyacBilgileriL mib)
                {
                    var insert = new List<BaseHareketEntity>();

                    using (var rvbbll=new RezervasyonBilgileriBll())
                    {
                        var entity = (RezervasyonBilgileriL)rvbbll.Single(x => x.OwnerFormId ==mib.Id);

                        if (entity == null) return;

                        entity.RezervedQty = entity.RezervedQty - mib.KayitMiktari;

                        insert.Add(entity);

                        if (entity.RezervedQty > 0)
                            rvbbll.Update(insert);
                        else
                            rvbbll.Delete(insert);
                    }
                }
            }
        }
        public static bool KaydetUretimSonuBilgileri(this IList malzemeIhtiyacBilgileri)
        {
            using (var bll=new UretimSonuKayitBilgileriBll())
            {
                var uretimSonuKayitBilgileri = malzemeIhtiyacBilgileri.Cast<MalzemeIhtiyacBilgileriL>().EntityListConvert<UretimSonuKayitBilgileri>(true,false);

                var id= IslemTuru.EntityInsert.IdOlustur(null);

                uretimSonuKayitBilgileri.ForEach(x =>
                {
                    x.UretimSonuKayitId = id;
                    //x.AnaKod = malzemeIhtiyacBilgileri.Cast<MalzemeIhtiyacBilgileriL>().Any(y => y.Filter && y.Id == x.Id);
                    x.MalzemeIhtiyacBilgileriId = x.Id;
                    x.Id = 0;
                    //x.KayitTarihi = DateTime.Now;
                    //x.IsEmriKodu= malzemeIhtiyacBilgileri.Cast<MalzemeIhtiyacBilgileriL>().Where(y => y.Filter).FirstOrDefault()?.IsEmriKodu;
                });
                var insert = uretimSonuKayitBilgileri.Cast<BaseHareketEntity>().ToList();

                return bll.Insert(insert);
            }
        }
        private static List<BaseHareketEntity> Mrp(MalzemeIhtiyacBilgileriL mib)
        {
            var mrpBilgileriId = mib.MrpBilgileriId;
            var list = new List<BaseHareketEntity>();            
            
            Cursor.Current = Cursors.WaitCursor;

            var yigin = new StackFunction(50, 500);

            void ListeleDoldur(MalzemeIhtiyacBilgileriL row, decimal aktarilanMiktar, int mrpBilgiId, DateTime baslamaTarihi)
            {
                var mrpReceteBilgileri = row.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(false,_tablo, x => x.MrpBilgileriId == row.MrpBilgileriId && x.BagliOlduguUstReceteStokKodu == row.StokKodu);

                mrpReceteBilgileri?.ForEach(x =>
                {
                    x.ReceteSeviyesi = x.ReceteSeviyesi;
                    x.TalepTarihi = baslamaTarihi;                        
                });
                if (mrpReceteBilgileri == null) return;

                foreach (var mrpMib in mrpReceteBilgileri)
                {
                    list.AddRange(mrpMib.Uret(mrpBilgiId, aktarilanMiktar, baslamaTarihi,row));

                    if (mrpMib.OperasyonSeviyesi > 0) continue;

                    if (mrpMib.Uretim)
                    {
                        yigin.PushEntity(mrpMib);
                        yigin.PushIndex();
                    }
                }

                while (!yigin.EmptyIndex())
                {
                    yigin.PopIndex();
                    var altEntity = (MalzemeIhtiyacBilgileriL)yigin.PopEntity();
                    if (altEntity == null) continue;
                    aktarilanMiktar = altEntity.BirimIhtiyac * aktarilanMiktar;

                    var rowKapasiteIhtiyaci = aktarilanMiktar * altEntity.OperasyonSuresi / altEntity.BagliOlduguUstReceteId.ReceteIdIleReceteAnaRow().Miktar + altEntity.HazirlikSuresi ?? 0;
                    var altEntityBaslamaTarihi = rowKapasiteIhtiyaci.BaslamaTarihiHesapla(baslamaTarihi);

                    ListeleDoldur(altEntity, /*altEntity.BirimIhtiyac * */aktarilanMiktar, mrpBilgiId, altEntityBaslamaTarihi/*baslamaTarihi*/);
                }
            }

            var source = mib.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(true, _tablo, x => x.MrpBilgileriId == mib.MrpBilgileriId && x.BagliOlduguUstReceteStokKodu == mib.StokKodu);
            var anaRow = mib;

            var yeniIhtiyacMiktari = mib.BrutIhtiyac - mib.RezerveMiktar;
            if (anaRow == null) return null;

            if (source ==null|| source.Count <= 0) return null;

            foreach (var rowMib in source)
            {
                list.AddRange(rowMib.Uret(mrpBilgileriId, yeniIhtiyacMiktari, mib.TalepTarihi, anaRow));
                //if (rowMib.OperasyonSeviyesi > 0) continue;

                if (rowMib.Uretim&&rowMib!=anaRow)
                {
                    var rowKapasiteIhtiyaci =Convert.ToDecimal( yeniIhtiyacMiktari * rowMib.OperasyonSuresi);// / anaRow.StokId.StokIdIleReceteAnaRow().Miktar + rowMib.HazirlikSuresi??0;

                    var baslamaTarihi = rowKapasiteIhtiyaci.BaslamaTarihiHesapla(rowMib.TalepTarihi);
                    var aktarilanMiktar = yeniIhtiyacMiktari * rowMib.BirimIhtiyac / anaRow.StokId.StokIdIleReceteAnaRow().Miktar;

                    ListeleDoldur(rowMib, aktarilanMiktar, mrpBilgileriId, baslamaTarihi);
                }
            }
            
            Cursor.Current = Cursors.Default;
            return list;
        }

        private static List<MalzemeIhtiyacBilgileriL> Uret(this MalzemeIhtiyacBilgileriL rowMib, int mrpBilgiId, decimal aktarilanMiktar, DateTime siparisTeslimTarihi, MalzemeIhtiyacBilgileriL anaMibRow)
        {
            List<MalzemeIhtiyacBilgileriL> mibList = new List<MalzemeIhtiyacBilgileriL>();
            List<long?> opList;
            DateTime referansBitisTarihi = new DateTime();
            long? operasyonId = null;
            int operasyonSayisi = 0;

            var mibEntity = new MalzemeIhtiyacBilgileriL();

            var anaRowKapasiteIhtiyaci = aktarilanMiktar * (anaMibRow.OperasyonSuresi??0) + (rowMib.HazirlikSuresi ?? 0);
            var _anaKodBaslamaTarihi = anaRowKapasiteIhtiyaci.BaslamaTarihiHesapla(siparisTeslimTarihi);

            var receteAnaKod = GetAnySingleOrListBll.GetRecete(x => x.StokId == rowMib.StokId && x.Varsayılan); //row.StokId.StokIdIleReceteAnaRow();
            var receteMakineOperasyonBilgileri = receteAnaKod?.ReceteOperasyonMakinaBilgileri
                .Where(x => x.VarsayilanMakina).ToList();

            opList = _tablo.DataController.ListSource.Cast<MalzemeIhtiyacBilgileriL>().Where(x=>x.MrpBilgileriId==anaMibRow.MrpBilgileriId&&x.StokId==anaMibRow.StokId).Select(x => x.OperasyonId).ToList();
            referansBitisTarihi = rowMib==anaMibRow ? siparisTeslimTarihi : _anaKodBaslamaTarihi;

            //if (opList != null&&rowMib==anaMibRow)
            //{
            //    var opSay = opList.Count;
            //    operasyonSayisi = opSay == 0 ? 1 : opList.Count;
            //}
            //else
            //    operasyonSayisi = 1;

            //for (int i = 0; i < operasyonSayisi; i++)
            //{
            //    if (opList != null)
            //        operasyonId = opList[i];
                mibEntity = rowMib;
                mibEntity.Id = rowMib.Id;
                mibEntity.MrpBilgileriId = mrpBilgiId;
                mibEntity.StokId = rowMib.StokId;
                mibEntity.StokKodu = rowMib.StokKodu;
                mibEntity.StokAdi = rowMib.StokAdi;
                mibEntity.DepoId = rowMib.DepoId;
                mibEntity.BagliOlduguUstReceteId = rowMib.BagliOlduguUstReceteId;
                mibEntity.BagliOlduguUstReceteStokAdi = rowMib.BagliOlduguUstReceteStokAdi;
                mibEntity.BagliOlduguUstReceteStokKodu = rowMib.BagliOlduguUstReceteStokKodu;
                mibEntity.BagliOlduguAnaReceteId = anaMibRow.BagliOlduguAnaReceteId;
                mibEntity.AnaReceteKodu = rowMib.AnaReceteKodu;
                mibEntity.BirimAdi = rowMib.BirimAdi;
                mibEntity.BirimIhtiyac = rowMib.BirimIhtiyac;
                mibEntity.ToplamIhtiyac = rowMib.ToplamIhtiyac; //== anaMibRow ? anaMibRow.ToplamIhtiyac: anaMibRow.ToplamIhtiyac * rowMib.BirimIhtiyac / anaMibRow.StokId.StokIdIleReceteAnaRow().Miktar;
            mibEntity.BrutIhtiyac = rowMib == anaMibRow ? rowMib.BrutIhtiyac : aktarilanMiktar * rowMib.BirimIhtiyac; // anaMibRow.StokId.StokIdIleReceteAnaRow().ReceteOlusturulmaMiktari;
            mibEntity.NetIhtiyac = rowMib == anaMibRow ? rowMib.BrutIhtiyac - rowMib.RezerveMiktar : aktarilanMiktar * rowMib.BirimIhtiyac;// rowMib.BrutIhtiyac - rowMib.RezerveMiktar;
                mibEntity.RezerveMiktar = rowMib.RezerveMiktar;
                mibEntity.ReceteSeviyesi = rowMib.ReceteSeviyesi;
                mibEntity.OperasyonSuresi = rowMib == anaMibRow ? rowMib.OperasyonSuresi : null;
                mibEntity.HazirlikSuresi = rowMib == anaMibRow ? rowMib.HazirlikSuresi : null;
                mibEntity.Uretim = rowMib.Uretim;
                mibEntity.Kapandi = mibEntity.NetIhtiyac <= 0;
                    //TavsiyeEdilenUretimBaslamaTarihi = row.Uretilebilir == Uretilebilir.AnaKod ? _anaKodBaslamaTarihi
                    //                : row.Uretilebilir == Uretilebilir.Uretim ? row.BaslamaTarihiHesapla(_anaKodBaslamaTarihi, aktarilanMiktar * row.Miktar / row.ReceteOlusturulmaMiktari)
                    //                : _anaKodBaslamaTarihi,
                    //IhtiyacTarihi = row.Uretilebilir == Uretilebilir.AnaKod ? siparisTeslimTarihi : _anaKodBaslamaTarihi,
                mibEntity.Insert = anaMibRow.Insert;
                mibEntity.Update = anaMibRow.Update;
                mibEntity.Delete= anaMibRow.Delete;
                if (receteMakineOperasyonBilgileri != null)
                {
                    mibEntity.TalepTarihi = referansBitisTarihi;
                    mibEntity.KapasiteIhtiyaci = GetAnySingleOrListBll
                        .GetRecete(x=>x.StokId==mibEntity.StokId&&x.Varsayılan)?
                        .ReceteOperasyonMakinaBilgileri?.Where(x => x.VarsayilanMakina)?
                        .FirstOrDefault()?.OperasyonSuresi * mibEntity.NetIhtiyac;
                    mibEntity.TavsiyeEdilenBaslamaTarihi = mibEntity.KapasiteIhtiyaci != null ? Convert.ToDateTime(mibEntity.KapasiteIhtiyaci?.BaslamaTarihiHesapla(rowMib.TalepTarihi)) : mibEntity.TalepTarihi;
                    referansBitisTarihi = mibEntity.TavsiyeEdilenBaslamaTarihi;
                }
                else
                {
                    //mibEntity.ToplamIhtiyac = _source.Where(x => x.StokId == row.StokId && mrpBilgiId == x.MrpBilgileriId && x.BagliOlduguAnaReceteId == row.ReceteId)
                    //    .FirstOrDefault().ToplamIhtiyac;
                    //mibEntity.NetIhtiyac= mibEntity.NetIhtiyac-_source.Where(x => x.StokId == row.StokId && mrpBilgiId == x.MrpBilgileriId && x.BagliOlduguAnaReceteId == row.ReceteId)
                    //    .FirstOrDefault().RezerveMiktar;
                    mibEntity.TalepTarihi = referansBitisTarihi;
                    mibEntity.TavsiyeEdilenBaslamaTarihi = referansBitisTarihi;
                }
                //mibEntity.PlanBaslangicTarihi = mibEntity.TavsiyeEdilenBaslamaTarihi;
                //mibEntity.TeslimTarihi = mibEntity.TalepTarihi;

                mibList.Add(mibEntity);
            //}

            return mibList;
        }
        public static ReceteBilgileriL ListReceteBilgileri(long stokId)
        {
            using (var bll = new ReceteBilgileriBll())
            {
                var anaRow = (ReceteBilgileriL)bll.List(x => x.StokId == stokId && x.Uretilebilir == Uretilebilir.AnaKod).FirstOrDefault();
                return anaRow;
            }
        }

        public static MalzemeIhtiyacBilgileriL MibOlustur(MalzemeIhtiyacBilgileriL selectedRowMib, MalzemeIhtiyacBilgileriL mibListAnaRow, ReceteBilgileriL selectedRowRecete, ReceteBilgileriL item)
        {
            var recete = GetAnySingleOrListBll.GetRecete(x => x.StokId == item.StokId && x.Varsayılan);
            var mib = new MalzemeIhtiyacBilgileriL
            {
                Id = item.Update ? selectedRowMib.Id : 0,
                MrpBilgileriId = mibListAnaRow.MrpBilgileriId,
                ReceteId =recete.Id,
                MrpKod = mibListAnaRow.MrpKod,
                AnaReceteKodu = mibListAnaRow.AnaReceteKodu,
                BagliOlduguUstReceteId = mibListAnaRow.StokId.StokIdIleReceteAnaRow().ReceteId,
                BagliOlduguAnaReceteId = mibListAnaRow.BagliOlduguAnaReceteId,
                BagliOlduguUstReceteStokKodu = mibListAnaRow.StokId.StokIdIleReceteAnaRow().StokKodu,
                BagliOlduguUstReceteStokAdi = mibListAnaRow.StokId.StokIdIleReceteAnaRow().StokAdi,
                StokId = item.StokId,
                StokKodu = item.StokKodu,
                StokAdi = item.StokAdi,
                BirimAdi = item.TuketimBirimAdi,
                BirimIhtiyac = item.Miktar,
                BrutIhtiyac = mibListAnaRow.NetIhtiyac * item.Miktar / mibListAnaRow.StokId.StokIdIleReceteAnaRow().Miktar,
                ToplamIhtiyac = mibListAnaRow.ToplamIhtiyac * item.Miktar / mibListAnaRow.StokId.StokIdIleReceteAnaRow().Miktar,
                DepoId = item.TuketimDepoId,
                //Id=x.mib.MrpBilgileri.MrpId,
                IstasyonId = recete?.ReceteOperasyonMakinaBilgileri?.Where(x => x.VarsayilanMakina).Select(x => x.IstasyonId).FirstOrDefault(),
                OperasyonId = recete?.ReceteOperasyonMakinaBilgileri?.Where(x => x.VarsayilanMakina).Select(x => x.OperasyonId).FirstOrDefault(),
                MakinaId = recete?.ReceteOperasyonMakinaBilgileri?.Where(x => x.VarsayilanMakina).Select(x => x.MakinaId).FirstOrDefault(),
                MakinaElemaniId = recete?.ReceteMakinaElemaniBilgileri.Where(x => x.VarsayilanEleman).Select(x => x.MakinaId).FirstOrDefault(),
                RezerveMiktar = item.Update ? selectedRowMib.RezerveMiktar : 0,
                //NetIhtiyac = selectedRow != null ? sourceRow.NetIhtiyac*item.Miktar- selectedRow.RezerveMiktar: sourceRow.NetIhtiyac * item.Miktar,
                ToplamStokMiktari = selectedRowMib?.ToplamStokMiktari,
                ToplamRezerveMiktar = selectedRowMib?.ToplamRezerveMiktar,
                AcikMiktar = selectedRowMib?.AcikMiktar,
                ReceteSeviyesi = mibListAnaRow.ReceteSeviyesi + 1,
                Uretim = item.Uretilebilir == Uretilebilir.Uretim,
                OperasyonSuresi = recete?.ReceteOperasyonMakinaBilgileri?.Where(x => x.VarsayilanMakina).Select(x => x.OperasyonSuresi).FirstOrDefault(),
                HazirlikSuresi= recete?.ReceteOperasyonMakinaBilgileri?.Where(x => x.VarsayilanMakina).Select(x => x.MakinaHazirlikSuresi).FirstOrDefault(),
                Filter = item.Uretilebilir == Uretilebilir.Uretim,
                Insert = item.Insert,
                Update = item.Update,
                //OperasyonSeviyesi = mibListAnaRow.OperasyonSeviyesi,
                //ToplamUretimSuresi = mibListAnaRow.KapasiteIhtiyaci,
            };
            mib.NetIhtiyac = mib.BrutIhtiyac - mib.RezerveMiktar;
            //mib.TavsiyeEdilenUretimBaslamaTarihi = selectedRowRecete != null ? mib.NetIhtiyac.BaslamaTarihiHesapla(mibListAnaRow.TavsiyeEdilenUretimBaslamaTarihi ?? DateTime.Now)
            //    :mibListAnaRow.IhtiyacTarihi;
            mib.TalepTarihi = mibListAnaRow.TavsiyeEdilenBaslamaTarihi;
            mib.KapasiteIhtiyaci = mib.NetIhtiyac * Convert.ToDecimal(mib.OperasyonSuresi) + Convert.ToDecimal(mib.HazirlikSuresi);
            return mib;
        }

        public static void KaydetStokHareketi(this IBaseEntity baseEntity,long stokId,long depoId, int bagliOlduguKayitId, decimal islemMiktari, string hareketTuru,string hareketCinsi)
        {
            using (var bll = new StokHareketleriBll())
            {
                var list = new List<BaseHareketEntity>();

                var stokHareketi = new StokHareketleri
                {
                    Id=0,
                    StokId=stokId,
                    DepoId=depoId,
                    FormItemId=bagliOlduguKayitId,
                    HareketTuru=hareketTuru.GetEnum<HareketTuru>(),
                    HareketCinsi= hareketCinsi,
                    IslemMiktari=islemMiktari,
                    HareketTarihi=DateTime.Now,
                };
                stokHareketi.IslemOncesiStokMiktari=SingleDepoStok(stokHareketi.StokId, stokHareketi.DepoId).Quantity;
                stokHareketi.IslemSonrasiStokMiktari = hareketTuru=="Giriş"? stokHareketi.IslemOncesiStokMiktari + islemMiktari
                    : stokHareketi.IslemOncesiStokMiktari - islemMiktari;
                list.Add(stokHareketi);
                bll.Insert(list);
            }
        }
        public static void GuncelleStokHareket(int id,decimal islemMiktari)
        {
            using (var bll = new StokHareketleriBll())
            {
                var list = new List<BaseHareketEntity>();

                var stokHareket =(StokHareketleriL) bll.Single(x => x.FormItemId == id);

                stokHareket.IslemMiktari = islemMiktari;
                stokHareket.IslemSonrasiStokMiktari =stokHareket.HareketTuru==HareketTuru.Giris? stokHareket.IslemOncesiStokMiktari + islemMiktari
                    : stokHareket.IslemOncesiStokMiktari - islemMiktari;

                list.Add(stokHareket);
                if (islemMiktari == 0)
                    bll.Delete(list);
                bll.Update(list);
            }
        }
        public static void RezervasyonBilgisiAl(this MalzemeIhtiyacBilgileriL mib)
        {

            bool AyniRow()
            {
                if (_rvbIcinElemanList == null) return false;
                return _rvbIcinElemanList.Contains(mib);
            }
            if (AyniRow())
            {
                _rvbIcinElemanList.FirstOrDefault(x => x.Id == mib.Id).RezerveMiktar = mib.RezerveMiktar;
                return;
            }
            _rvbIcinElemanList.Add(mib);
        }

        public static bool RezervasyonBilgisiOlustur(/*this List<MalzemeIhtiyacBilgileriL> mibList*/)
        {
            var list = new List<RezervasyonBilgileriL>();

            using (var bll = new RezervasyonBilgileriBll())
            {
                var rezervasyonBilgileri = bll.List(x => x.Id != 0).Cast<RezervasyonBilgileriL>().ToList();

                foreach (var mib in _rvbIcinElemanList)
                {
                    var enty = rezervasyonBilgileri.Where(x => x.OwnerFormItemId == mib.Id).FirstOrDefault();
                    if (enty == null)
                        enty = new RezervasyonBilgileriL
                        {
                            UserId = AnaForm.KullaniciId,
                            UpdatingUserId=AnaForm.KullaniciId,
                            OwnerFormItemId = mib.Id,
                            OwnerFromName = "MalzemeIhtiyacBilgileri",
                            MaterialId = mib.StokId,
                            //SiparisId = mib.MrpId,
                            UnitId=mib.BirimId,
                            Birim = mib.BirimAdi,
                            WarehouseId = (long)mib.DepoId,
                            GrupAdi = "Üretim",
                            RezervedQty = mib.RezerveMiktar,
                            Description = "Malzeme İhtiyaç İşlemleri Esnasında Oluşturulmuş Bir Kayıttır",
                            Insert = true
                        };
                    else if (mib.RezerveMiktar == 0)
                    {
                        enty.Delete = true;
                    }
                    else
                    {
                        enty.RezervedQty = mib.RezerveMiktar;
                        enty.Update = true;
                    }

                    list.Add(enty);
                }
            }
            //var insert = list.Cast<BaseHareketEntity>().ToList();
            var don=list.RezervasyonKaydet();
            _rvbIcinElemanList.Clear();
            return don;
        }
        private static bool RezervasyonKaydet(this IList<RezervasyonBilgileriL> rvbList)
        {
            
            if (rvbList.Any())
            {
                var insert = rvbList.Cast<IBaseHareketEntity>().Where(x => x.Insert).Cast<BaseHareketEntity>().ToList();
                var update = rvbList.Cast<IBaseHareketEntity>().Where(x => x.Update).Cast<BaseHareketEntity>().ToList();
                var delete = rvbList.Cast<IBaseHareketEntity>().Where(x => x.Delete).Cast<BaseHareketEntity>().ToList();
                bool result = false;
                using (var bll = new RezervasyonBilgileriBll())
                {
                    if (insert.Any())
                    {
                        result = bll.Insert(insert);
                        if (!result)
                        {
                            Messages.HataMesaji("Rezervasyon Bilgileri Kaydedilemedi !");
                            return false;
                        }
                       
                    }
                            
                    if (update.Any())
                        if (!bll.Update(update))
                        {
                            Messages.HataMesaji("Rezervasyon Bilgileri Güncellenemedi !");
                            return false;
                        }
                           
                    if (delete.Any())
                        if (!bll.Delete(delete))
                        {
                            Messages.HataMesaji("Rezervasyon Bilgileri Güncellenemedi !");
                            return false;
                        }
                    if (result)
                    {
                        var list = new List<MalzemeIhtiyacBilgileriL>();

                        insert.Cast<RezervasyonBilgileri>().ToList().ForEach(x =>
                        {
                            var mib=GetAnySingleOrListBll.GetMalzemeIhtiyacBilgileri(y => y.Id == x.OwnerFormItemId);
                            var rvb = GetAnySingleOrListBll.RezervasyonBilgisi(y=>y.OwnerFormItemId==x.OwnerFormItemId);
                            mib.ReservationId = rvb.Id;
                            list.Add(mib);
                        });

                        InstanceBaseHareketEntityBll<MalzemeIhtiyacBilgileri, MalzemeIhtiyacBilgileriBll>
                            .UpdateEntities(list.Cast<BaseHareketEntity>().ToList());
                    }
                    return true;  
                }
            }
            return false;
        }

        public static void GuncelleRezervasyonBilgisi(this int malzemeIhtiyacBilgisiId,decimal kayitMiktari)
        {
            var updateList = new List<BaseHareketEntity>();

            using (var bll=new RezervasyonBilgileriBll())
            {
                var rzb =(RezervasyonBilgileriL) bll.Single(x => x.OwnerFormId == malzemeIhtiyacBilgisiId);
                rzb.RezervedQty = kayitMiktari;
                updateList.Add(rzb);

                if (kayitMiktari == 0)
                    bll.Delete(updateList);
                bll.Update(updateList);
            }
        }
        public static RezervasyonBilgileriL RezervasyonBilgisi(long stokId,long? depoId)
        {
            using (var bll = new RezervasyonBilgileriBll())
            {
                return (RezervasyonBilgileriL)bll.Single(x => x.MaterialId==stokId&&x.WarehouseId==depoId);
            }
        }
        public static MaterialS SingleStok(this long stokId)
        {
            using (var bll = new MaterialBll())
            {
                return (MaterialS)bll.Single(x => x.Id == stokId);
            }
        }
        public static WareHouseStockL SingleDepoStok(long stokId, long? depoId)
        {
            using (var bll = new WarehouseStockBll())
            {
                var entity = (WareHouseStockL)bll.Single(y => y.WareHouseId == depoId && y.MaterialId == stokId);

                if (entity == null)
                    return null;
                return entity;

            }
        }
        public static void UpdateDepoStok(this WareHouseStockL depoStokL)
        {
            using (var bll = new WarehouseStockBll())
            {
                var list = new List<BaseHareketEntity>();
                list.Add(depoStokL);
                bll.Update(list);
            }
        }
        public static IList ListDepoStok(Expression<Func<WareHouseStocks, bool>> filter)
        {
            using (var bll = new WarehouseStockBll())
            {
                return bll.List(filter).ToList();
            }
        }
        public static void UpdateDepoStok(this List<BaseHareketEntity> depoStokL)
        {
            using (var bll = new WarehouseStockBll())
            {
                bll.Update(depoStokL);
            }
        }
        public static IstasyonS SingleIstasyon(long istasyonId)
        {
            using (var bll=new IstasyonBll())
            {
                return bll.Single(x => x.Id == istasyonId).EntityCovert<IstasyonS>();
            }
        }
        public static Vardiya SingleVardiya(long vardiyaId)
        {
            using (var bll=new VardiyaBll())
            {
                return bll.Single(x => x.Id == vardiyaId).EntityCovert<Vardiya>();
            }
        }
        public static TatilBilgileri SingleTatilBilgileri(DateTime tarih)
        {
            using (var bll = new TatilBilgileriBll())
            {
                return bll.BaseSingle<TatilBilgileri>(x=>x.Tarih==tarih,x=>x);
            }
        }
        public static List<VardiyaBilgileriLastVersionL> ListVardiyaBilgileri(long vardiyaId)
        {
            using (var bll = new VardiyaBilgileriLastVersionBll())
            {
                return bll.List(x => x.VardiyaId == vardiyaId)?.Cast< VardiyaBilgileriLastVersionL>().ToList();
            }
        }
        public static DemandInformationsMultiL TalepBilgi(long TalepId)
        {
            using (var bll = new ProductionDemandInformationsBll())
            {
                return bll.DemandInformationsList(x => x.DemandId == TalepId).SingleOrDefault().EntityCovert<DemandInformationsMultiL>();
            }
        }
        public static IList ListKdv(Expression<Func<Kdv, bool>> filter)
        {
            using (var bll = new KdvBll())
            {
                return bll.List(filter).ToList();
            }
        }
        public static IList ListDovizBilgileri(Expression<Func<DovizBilgileri, bool>> filter)
        {
            using (var bll = new DovizBilgileriBll())
            {
                return bll.List(filter).ToList();
            }
        }
        public static bool UpdateProductionDemandInformations(long demandId,bool isTakenToProcess,bool isProcessDone)
        {
            using (var bll=new ProductionDemandInformationsBll())
            {
                var id = Convert.ToInt32(demandId);
                var updates = bll.List(x => x.Id == id, x => x).ToList();
                updates.Cast<ProductionDemandInformations>().ForEach(x =>
                {
                    x.IsTakenToProcess = isTakenToProcess;
                    x.IsProcessDone = isProcessDone;
                });
                var update = updates.Cast<BaseHareketEntity>().ToList();
                return bll.Update(update);
            }
        }

    }
}

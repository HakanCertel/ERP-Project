using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IndirimForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IptalNedeniForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.TahakkukForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting.Native;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class IndirimBilgileriTable : BaseTablo
    {
        public IndirimBilgileriTable()
        {
            InitializeComponent();

            Bll = new IndirimBilgileriBll();
            Tablo = tablo;
            EventsLoad();

            ShowItems = new BarItem[] { btnIptalEt, btnIptalGeriAl };
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((IndirimBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).toBindingList<IndirimBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var indirimList = ShowListForms<IndirimListForm>.ShowDialogListForm(KartTuru.Indirim, true).EntityListConvert<IndirimL>();

            if (indirimList == null) return;

            using (var iuhBll = new IndiriminUygulanacagiHizmetBilgileriBll())
            {
                bool HizmetAlindi(long hizmetId)
                {
                    /*aşağıda aktif tahakkuk editformdaki tahakkuku yapılan öğrencinin hangi hizmetleri aldığı
                     na ve bu hizmetlerin toplam bedeline ulaşılması gerekmektedir. bu işlemi yapabilmek için 
                     basetablo da tanımlamış olduğumuz OwnerForm tipimiz vardı. tahakkuk editform yüklendiğinde
                     hizmet bilgileri formuda yükleneceği için ve OwnerForm bu tablo için TahakkukEditForm 
                     olacağından TahakkukEditForm üzerinden HizmetBilileri tablosuna ulaşıp hangi hizmetlerin 
                     alındığına yönelik listeye ulaşılabilir.*/
                    var hizmetToplami = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>()
                        .Where(x => x.HizmetId == hizmetId && !x.IptalEdildi && !x.Delete).Sum(x => x.BrutUcret);

                    var indirimToplami = tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                        .Where(x => x.HizmetId == hizmetId && !x.ManuelGirilenTutar && !x.Delete&&!x.IptalEdildi).Sum(x => x.BrutIndirim);

                    return hizmetToplami == 0 ? false : hizmetToplami - indirimToplami > 0;
                }

                bool AyniHizmetKartinaAyniIndirimUygulandi(IndiriminUygulanacagiHizmetBilgileriL hizmet)
                {
                    return tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                         .Any(x => x.HizmetId == hizmet.HizmetId && x.IndirimId == hizmet.IndirimId && !x.ManuelGirilenTutar && !x.IptalEdildi && !x.Delete);
                }
                var source = tablo.DataController.ListSource;
                var sabitTutrarliIndirimGirildi = false;
                var eklenenKayitSayisi = 0;

                foreach (var indirim in indirimList)
                {
                    var hizmetList = iuhBll.List(x => x.IndirimId == indirim.Id && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId)
                        .Cast<IndiriminUygulanacagiHizmetBilgileriL>();

                    foreach (var hizmet in hizmetList)
                    {
                        if (!HizmetAlindi(hizmet.HizmetId)) continue;
                        if (AyniHizmetKartinaAyniIndirimUygulandi(hizmet)) continue;

                        if (!sabitTutrarliIndirimGirildi)
                            sabitTutrarliIndirimGirildi = hizmet.IndirimTutari > 0;

                        //var indirimTutarlari = IndirimHesapla(hizmet.IndirimId, hizmet.HizmetId);
                        var (brutIndirim, kistDonemDusulenIndirim) = IndirimHesapla(hizmet.IndirimId, hizmet.HizmetId);

                        var row = new IndirimBilgileriL
                        {
                            TahakkukId = OwnerForm.Id,
                            IndirimId = indirim.Id,
                            IndirimAdi = indirim.IndirimAdi,
                            HizmetId = hizmet.HizmetId,
                            HizmetAdi = hizmet.HizmetAdi,
                            IslemTarihi = DateTime.Now.Date,                            
                            //BrutIndirim = indirimTutarlari.brutIndirim,
                            BrutIndirim = brutIndirim,
                            //KistDonemDusulenIndirim=indirimTutarlari.kistDonemDusulenIndirim,
                            KistDonemDusulenIndirim = kistDonemDusulenIndirim,
                            //NetIndirim=indirimTutarlari.brutIndirim-indirimTutarlari.kistDonemDusulenIndirim,
                            NetIndirim = brutIndirim - kistDonemDusulenIndirim,
                            OranliIndirim = hizmet.IndirimOrani > 0,
                            ManuelGirilenTutar = hizmet.IndirimOrani == 0 && hizmet.IndirimTutari == 0,
                            Insert = true
                        };

                        source.Add(row);
                        eklenenKayitSayisi++;

                        if (hizmet.IndirimOrani == 0 && hizmet.IndirimTutari == 0)
                            tablo.FocusedColumn = colBrutIndirim;
                    }
                }

                if (eklenenKayitSayisi == 0) return;
                if (sabitTutrarliIndirimGirildi)
                    TopluIndirimHesapla();
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);

            ButtonEnabledDurum(true);
            //bir tabloya row eklemenin başka bir yolu ise aşğıda yazılmış olan kodlar gibidir fakat zor olanıdır bu yöntem.
            //var row1 = new IndiriminUygulanacagiHizmetBilgileriL();
            //tablo.AddNewRow();
            //tablo.SetFocusedRowCellValue(colHizmetAdi, row1.HizmetAdi);
            //tablo.SetFocusedRowCellValue(colIndirimTutari, row1.IndirimTutari);
        }
        /*bir c# projesinde bir metoddan birden fazla değer dönderecek bir fonksiyon yazılmak isteniyorsa
         nuget packaget den value Tuple yazılarak ilgili uzantı indirlmeli ve  dahasonra ilgili fonksiyon
         yazılmalıdır...*/
        private (decimal brutIndirim, decimal kistDonemDusulenIndirim) IndirimHesapla(long indirimId, long hizmetId)
        {
            decimal HizmetToplamiAl(bool iptalEdildi)
            {
                var hizmetToplami = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource
                    .Cast<HizmetBilgileriL>().Where(x => x.HizmetId == hizmetId && x.IptalEdildi == iptalEdildi && !x.Delete).Sum(x => x.BrutUcret);
                var indirimToplami = tablo.DataController.ListSource
                    .Cast<IndirimBilgileriL>().Where(x => x.HizmetId == hizmetId && !x.ManuelGirilenTutar && x.IptalEdildi == iptalEdildi && !x.Delete)
                    .Sum(x => x.BrutIndirim);

                return hizmetToplami == 0 ? 0 : hizmetToplami - indirimToplami;
            }
            using (var bll = new IndiriminUygulanacagiHizmetBilgileriBll())
            {
                var hizmetSource = bll.List(x => x.IndirimId == indirimId && x.HizmetId == hizmetId)
                    .Cast<IndiriminUygulanacagiHizmetBilgileriL>().FirstOrDefault();
                if (hizmetSource == null) return (0, 0);

                var egitimBitisTarihi = AnaForm.DonemParametreleri.DonemBitisTarihi;
                var hizmetEntity = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource
                    .Cast<HizmetBilgileriL>().First(x => x.HizmetId == hizmetId && !x.Delete);
                var indirimEntity = tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                    .FirstOrDefault(x => x.IndirimId == indirimId && x.HizmetId == hizmetId && !x.Delete);
                var hizmetToplami = hizmetEntity.IptalEdildi ? HizmetToplamiAl(true) : HizmetToplamiAl(false);
                var toplamGunSayisi = hizmetEntity.EgitimDonemiGunSayisi;
                var hizmetGunSayisi = indirimEntity?.IptalTarihi == null ? (int)(egitimBitisTarihi - hizmetEntity.BaslamaTarihi).TotalDays + 1
                    : (int)(indirimEntity.IptalTarihi - hizmetEntity.BaslamaTarihi).Value.TotalDays + 1;
                var brutIndirim = hizmetSource.IndirimTutari > 0 ? hizmetSource.IndirimTutari : hizmetToplami * hizmetSource.IndirimOrani / 100;

                var gunlukIndirim = brutIndirim / toplamGunSayisi;

                var kistDonemDusulenIndirim = (toplamGunSayisi - hizmetGunSayisi) * gunlukIndirim;

                brutIndirim = Math.Round(brutIndirim, AnaForm.DonemParametreleri.IndirimTahakkukKurusKullan ? 2 : 0);
                kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.DonemParametreleri.IndirimTahakkukKurusKullan ? 2 : 0);

                return (brutIndirim, kistDonemDusulenIndirim);
            }
        }

        protected internal void TopluIndirimHesapla()
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>().ToList();

            source.ForEach(x =>
            {
                if (!x.OranliIndirim || x.ManuelGirilenTutar || x.Delete) return;
                x.BrutIndirim = 0;
                x.KistDonemDusulenIndirim = 0;
            });

            source.ForEach(x =>
            {
                if (x.ManuelGirilenTutar || x.Delete) return;

                var (brutIndirim, kistDonemDusulenIndirim) = IndirimHesapla(x.IndirimId, x.HizmetId);

                x.BrutIndirim = brutIndirim;
                x.KistDonemDusulenIndirim = kistDonemDusulenIndirim;
                x.NetIndirim = brutIndirim - kistDonemDusulenIndirim;

                if (!x.Insert) x.Update = true;
            });

            tablo.UpdateSummary();
        }

        protected override void HareketSil()
        {
            if (tablo.DataRowCount == 0) return;
            //if (tablo.FocusedRowHandle < 0) return;

            if (Messages.SilMesaj("İndirim Bilgisi") != DialogResult.Yes) return;

            var entity = tablo.GetRow<IndirimBilgileriL>();
            if (entity.IptalEdildi)
            {
                Messages.IptalHareketSilinemezMesaji();
                return;
            }

            entity.Delete = true;
            tablo.RefreshDataSource();
            TopluIndirimHesapla();
            ButtonEnabledDurum(true);
        }

        protected internal void TopluHareketSil(long hizmetId)
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>();
            if (source == null) return;

            var silinenKayitVarmi = false;

            source.ForEach(x =>
            {
                if (x.IptalEdildi || x.HizmetId != hizmetId) return;
                x.Delete = true;
                silinenKayitVarmi = true;
            });

            if (!silinenKayitVarmi) return;
            tablo.RefreshDataSource();
            ButtonEnabledDurum(true);
        }

        protected override void IptalEt()
        {
            var indirimEntity = tablo.GetRow<IndirimBilgileriL>();
            if (indirimEntity == null || indirimEntity.IptalEdildi || indirimEntity.Insert) return;
            if (Messages.IptalMesaj("İndirim Bilgisi") != DialogResult.Yes) return;

            var hizmetEntity = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>().FirstOrDefault(x => !x.IptalEdildi && x.HizmetId == indirimEntity.HizmetId);
            if (hizmetEntity == null) return;

            var gunlukIndirim = indirimEntity.BrutIndirim / hizmetEntity.EgitimDonemiGunSayisi;
            var alinanHizmetGunSayisi = (int)(DateTime.Now.Date - hizmetEntity.BaslamaTarihi).TotalDays + 1;
            var brutIndirim = gunlukIndirim * alinanHizmetGunSayisi;
            var kistDonemDusulenIndirim = indirimEntity.BrutIndirim - brutIndirim;
            kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.DonemParametreleri.IndirimTahakkukKurusKullan ? 2 : 0);

            var iptalNedeni = (IptalNedeni)ShowListForms<IptalNedeniListForm>.ShowDialogListForm(KartTuru.IptalNedeni, -1);

            if (iptalNedeni != null)
            {
                indirimEntity.IptalNedeniId = iptalNedeni.Id;
                indirimEntity.IptalNedeniAdi = iptalNedeni.IptalNedeniAdi;
            }

            indirimEntity.IndirimAdi = $"{indirimEntity.IndirimAdi } -( *** İptal Edildi ***)";
            if (!indirimEntity.ManuelGirilenTutar)
                indirimEntity.KistDonemDusulenIndirim = kistDonemDusulenIndirim > 0 ? kistDonemDusulenIndirim : 0;
            indirimEntity.NetIndirim = indirimEntity.BrutIndirim - indirimEntity.KistDonemDusulenIndirim;
            indirimEntity.IptalTarihi = DateTime.Now.Date;
            indirimEntity.IptalEdildi = true;
            indirimEntity.Update = true;

            TopluIndirimHesapla();
            tablo.UpdateSummary();
            tablo.RowCellEnabled();/* bu extension metodu iptal işlemi gerçekleştikten donra iptal
            açıklama kolonuna odaklanarak veri girilebilir yani alowedit özelliği açılarak direkt veri girile
            bilir olamasını sağlamaktır.*/
            tablo.FocusedColumn = colIptalAciklama;
            ButtonEnabledDurum(true);
        }

        protected internal void TopluIptalEt(HizmetBilgileriL hizmetEntity)
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>();
            if (source == null) return;

            source.ForEach(x =>
            {
                if (x.HizmetId != hizmetEntity.HizmetId || x.IptalEdildi) return;

                var gunlukIndirim = x.BrutIndirim / hizmetEntity.EgitimDonemiGunSayisi;
                var alinanHizmetGunSayisi = (int)(DateTime.Now.Date - hizmetEntity.BaslamaTarihi).TotalDays + 1;
                var brutIndirim = gunlukIndirim * alinanHizmetGunSayisi;
                var kistDonemDusulenIndirim = x.BrutIndirim - brutIndirim;
                kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.DonemParametreleri.IndirimTahakkukKurusKullan ? 2 : 0);

                x.IndirimAdi = $"{x.IndirimAdi } -( *** İptal Edildi ***)";
                if (!x.ManuelGirilenTutar) x.KistDonemDusulenIndirim = kistDonemDusulenIndirim > 0 ? kistDonemDusulenIndirim : 0;
                x.NetIndirim = x.BrutIndirim - x.KistDonemDusulenIndirim;
                x.IptalTarihi = DateTime.Now.Date;
                x.IptalEdildi = true;
                x.HizmetHareketId = hizmetEntity.Id;
                x.IptalNedeniId = hizmetEntity.IptalNedeniId;
                x.IptalNedeniAdi = hizmetEntity.IptalNedeniAdi;
                if(!x.Insert) x.Update = true;

            });

            TopluIndirimHesapla();
            tablo.UpdateSummary();
        }

        protected override void IptalGeriAl()
        {
            bool HizmetAlindi(long hizmetId)
            {
                return ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>()
                    .Any(x => x.HizmetId == hizmetId && !x.IptalEdildi);
            }

            bool AyniIndirimAlindi(long indirimId,long hizmetId)
            {
                return tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                    .Any(x => x.IndirimId == indirimId && x.HizmetId == hizmetId && !x.IptalEdildi && !x.Delete);
            }
            var indirimEntity = tablo.GetRow<IndirimBilgileriL>();
            if (indirimEntity == null || !indirimEntity.IptalEdildi ) return;
           // if (Messages.IptalMesaj("İndirim Bilgisi") != DialogResult.Yes) return;

            if (Messages.IptalGerialMesaj(indirimEntity.IndirimAdi) != DialogResult.Yes) return;

            if (indirimEntity.HizmetHareketId == null && !HizmetAlindi(indirimEntity.HizmetId))
            {
                Messages.HataMesaji("İndirim Uygulandığı Hizmet Kartı İptal Edilmiş. İptal Edilen Hizmet Kartı Geri Alınmadan Yada Yeni Bir Hizmet Alınmadan İşlem Geri Alınamaz.");
                return;
            }
            if (indirimEntity.HizmetHareketId != null)
            {
                Messages.HataMesaji("İptal Edilen İndirim Hizmet Hareketleri Tablosundan Geri Alınabilir .");
                return;
            }

            if (AyniIndirimAlindi(indirimEntity.IndirimId, indirimEntity.HizmetId))
            {
                Messages.HataMesaji("İptal İşleminin Geri Alınması Durumunda Aynı İndirimden Birden Fazla Alım Durumu Oluşuyor.");
                return;
            }

            indirimEntity.IndirimAdi.Remove(indirimEntity.IndirimAdi.Length - 27, 27);
            indirimEntity.IptalEdildi = false;
            indirimEntity.IptalTarihi = null;
            indirimEntity.IptalNedeniId = null;
            indirimEntity.IptalNedeniAdi = null;
            indirimEntity.IptalAciklama = null;
            indirimEntity.HizmetHareketId = null;
            indirimEntity.Update = true;

            TopluIndirimHesapla();
            tablo.RefreshDataSource();
            tablo.UpdateSummary();
            tablo.RowCellEnabled();
            ButtonEnabledDurum(true);
        }

        protected internal void TopluIptalGerial(int hizmetHareketId)
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Where(x => x.HizmetHareketId == hizmetHareketId);

            source.ForEach(x =>
            {
                x.IndirimAdi.Remove(x.IndirimAdi.Length-20,20);
                x.IptalEdildi = false;
                x.IptalTarihi = null;
                x.IptalNedeniId = null;
                x.IptalNedeniAdi = null;
                x.IptalAciklama = null;
                x.HizmetHareketId = null;
                x.Update = true;
            });

            TopluIndirimHesapla();
            tablo.RefreshDataSource();
            tablo.UpdateSummary();
        }

        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<IndirimBilgileriL>();

            colIptalTarihi.OptionsColumn.AllowEdit = entity.IptalEdildi && entity.HizmetHareketId == null;
            colIptalNedeniAdi.OptionsColumn.AllowEdit = entity.IptalEdildi && entity.HizmetHareketId == null;
            colIptalAciklama.OptionsColumn.AllowEdit = entity.IptalEdildi && entity.HizmetHareketId == null;

            if (entity.Insert)
            {
                colBrutIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar && !entity.IptalEdildi;
                colKistDonemDusulenIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar && entity.IptalEdildi;
            }
            else
            {
                colBrutIndirim.OptionsColumn.AllowEdit = false;
                colKistDonemDusulenIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar;
            }
        }

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            base.Tablo_MouseUp(sender, e);

            var entity = (IndirimBilgileriL)tablo.GetRow(tablo.FocusedRowHandle);
            if (entity == null) return;

            btnHareketSil.Enabled = !entity.IptalEdildi;
            btnIptalEt.Enabled = !entity.IptalEdildi && !entity.Insert;
            btnIptalGeriAl.Enabled = entity.IptalEdildi;
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colIptalNedeniAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryIptalNedeni, colIptalNedeniId);
            else if (e.FocusedColumn == colIptalTarihi)
            {
                var entity = tablo.GetRow<IndirimBilgileriL>();

                if (entity.IptalTarihi == null) return;

                repositoryIptalTarihi.MinValue = AnaForm.DonemParametreleri.GünTarihininOncesineIptalTarihiGirilebilir ? entity.IslemTarihi : DateTime.Now.Date;
                repositoryIptalTarihi.MaxValue = AnaForm.DonemParametreleri.GünTarihininSonrasinaIptalTarihiGirilebilir ? AnaForm.DonemParametreleri.DonemBitisTarihi.AddDays(-1) : DateTime.Now.Date;

            }
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            if (e.Column == colIptalTarihi)
                TopluIndirimHesapla();
            else if(e.Column==colBrutIndirim||e.Column==colKistDonemDusulenIndirim)
            {
                var entity = tablo.GetRow<IndirimBilgileriL>();
                entity.NetIndirim = entity.BrutIndirim - entity.KistDonemDusulenIndirim;
            }
        }
    }
}

using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.HizmetForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IptalNedeniForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ServisForms;
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
    public partial class HizmetBilgileriTable : BaseTablo
    {
        public HizmetBilgileriTable()
        {
            InitializeComponent();

            Bll = new HizmetBilgileriBll();
            Tablo = tablo;
            EventsLoad();

            ShowItems = new BarItem[] { btnIptalEt, btnIptalGeriAl };
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((HizmetBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).toBindingList<HizmetBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<HizmetBilgileriL>().Where(x =>!x.IptalEdildi&& !x.Delete).Select(x => x.HizmetId).ToList();

            var entities = ShowListForms<HizmetListForm>.ShowDialogListForm(KartTuru.Hizmet, ListeDisiTutulacakKayitlar, true, true).EntityListConvert<HizmetL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                Servis servis = null;
                if (entity.HizmetTipi == HizmetTipi.Servis)
                {
                    servis = (Servis)ShowListForms<ServisListForm>.ShowDialogListForm(KartTuru.Servis, -1);
                    if (servis == null) continue;
                }
                var row = new HizmetBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    HizmetId=entity.Id,
                    HizmetAdi=entity.HizmetAdi,
                    HizmetTuruId=entity.HizmetTuruId,
                    HizmetTipi=entity.HizmetTipi,
                    IslemTarihi=DateTime.Now,
                    BaslamaTarihi=entity.BaslamaTarihi,
                    BrutUcret=entity.Ucret,
                    KistDonemDusulenUcret=0,
                    IptalEdildi=false,
                    Insert = true
                };

                if (servis != null)
                {
                    row.ServisId = servis.Id;
                    row.ServisYeriAdi = servis.ServisYeriAdi;
                    row.BrutUcret = entity.Ucret;
                }

                UcretHesapla(row);

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colHizmetAdi;

            ButtonEnabledDurum(true);
            //bir tabloya row eklemenin başka bir yolu ise aşğıda yazılmış olan kodlar gibidir fakat zor olanıdır bu yöntem.
            //var row1 = new IndiriminUygulanacagiHizmetBilgileriL();
            //tablo.AddNewRow();
            //tablo.SetFocusedRowCellValue(colHizmetAdi, row1.HizmetAdi);
            //tablo.SetFocusedRowCellValue(colIndirimTutari, row1.IndirimTutari);
        }

        protected internal override bool HatalıGiriş()
        {
            bool IndirimToplamiHizmetToplamindanBuyuk(long hizmetId)
            {
                var hizmetToplami = tablo.DataController.ListSource.Cast<HizmetBilgileriL>().Where(x => x.HizmetId == hizmetId && !x.Delete).Sum(x => x.BrutUcret - x.KistDonemDusulenUcret);
                var indirimToplami = ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                    .Where(x => x.HizmetId == hizmetId && !x.Delete).Sum(x => x.BrutIndirim - x.KistDonemDusulenIndirim);
                return  indirimToplami> hizmetToplami;
            }

            if (!TableValueChanged) return false;

            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<HizmetBilgileriL>(i);

                if (entity.IptalEdildi&&entity.HizmetTipi == HizmetTipi.Egitim&&AnaForm.DonemParametreleri.GittigiOkulZorunlu&&entity.GittigiOkulId==null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colGittigiOkulAdi;
                    tablo.SetColumnError(colGittigiOkulAdi, "Gittiği Okul Adı Alanına Geçerli Bir Değer Giriniz .");
                }
                if(entity.IptalEdildi&&entity.IptalNedeniId==null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colIptalNedeniAdi;
                    tablo.SetColumnError(colIptalNedeniAdi, "Iptal Nedeni Alanına Geçerli Bir Değer Giriniz .");
                }
                if (tablo.HasColumnErrors)
                {
                    Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                    return true;
                }
                if (IndirimToplamiHizmetToplamindanBuyuk(entity.HizmetId))
                {
                    tablo.FocusedRowHandle = i;
                    Messages.HataMesaji($"{entity.HizmetAdi} Kartına Uygulanan İndirimlerin Toplamı Kartın Toplam Tutarını Aşmaktadır .");
                    return true;
                }
            }

            return false;
        }

        private void UcretHesapla(HizmetBilgileriL entity)
        {
            var egitimBaslamaTarihi = AnaForm.DonemParametreleri.EgitimBaslamaTarihi;
            var egitimBitisTarihi = AnaForm.DonemParametreleri.DonemBitisTarihi;

            var toplamGunSayisi = (int)(egitimBitisTarihi - egitimBaslamaTarihi).TotalDays + 1;

            var gunlukUcret = entity.BrutUcret / toplamGunSayisi;
            var alinanHizmetGunSayisi = entity.IptalTarihi==null ? (int)(egitimBitisTarihi - entity.BaslamaTarihi).TotalDays + 1
                : (int)(entity.IptalTarihi - entity.BaslamaTarihi).Value.TotalDays + 1;
            var odenecekUcret = alinanHizmetGunSayisi > 0 ? gunlukUcret * alinanHizmetGunSayisi : 0;
            var kistDonemDusulecekUcret = entity.BrutUcret - odenecekUcret;
            kistDonemDusulecekUcret = Math.Round(kistDonemDusulecekUcret, AnaForm.DonemParametreleri.HizmetTahakkukKurusKullan ? 2 : 0);

            if (entity.BaslamaTarihi > egitimBaslamaTarihi || entity.IptalEdildi)
                entity.KistDonemDusulenUcret = kistDonemDusulecekUcret;
            else
                entity.KistDonemDusulenUcret = 0;

            entity.NetUcret = entity.BrutUcret - entity.KistDonemDusulenUcret;
            entity.EgitimDonemiGunSayisi = toplamGunSayisi;
            entity.AlinanHizmetGunSayisi = alinanHizmetGunSayisi;
            entity.GunlukUcret = gunlukUcret;
        }

        protected override void IptalEt()
        {
            var entity = tablo.GetRow<HizmetBilgileriL>();
            if (entity == null || entity.IptalEdildi || entity.Insert) return;
            if (Messages.IptalMesaj("Hizmet Bilgisi") != DialogResult.Yes) return;

            var iptalNedeni =(IptalNedeni) ShowListForms<IptalNedeniListForm>.ShowDialogListForm(KartTuru.IptalNedeni, -1);

            if (iptalNedeni != null)
            {
                entity.IptalNedeniId = iptalNedeni.Id;
                entity.IptalNedeniAdi = iptalNedeni.IptalNedeniAdi;
            }


            entity.IptalTarihi = DateTime.Now.Date;
            entity.HizmetAdi = $"{entity.HizmetAdi} -( *** İptal Edildi ***)";
            entity.IptalEdildi = true;
            entity.Update = true;

            UcretHesapla(entity);

            ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.TopluIptalEt(entity);
            tablo.UpdateSummary();
            tablo.RowCellEnabled();
            tablo.FocusedColumn = colIptalAciklama;
            ButtonEnabledDurum(true);

        }

        protected override void IptalGeriAl()
        {
            bool AyniHizmetAlindi(long hizmetId)
            {
                return tablo.DataController.ListSource.Cast<HizmetBilgileriL>().Any(x => x.HizmetId == hizmetId && !x.IptalEdildi && !x.Delete);
            }
            var entity = tablo.GetRow<HizmetBilgileriL>();
            if (entity == null) return;

            if (Messages.IptalGerialMesaj(entity.HizmetAdi) != DialogResult.Yes) return;

            if (AyniHizmetAlindi(entity.HizmetId))
            {
                Messages.HataMesaji("İptal İşleminin Geri Alınması Durumunda Aynı Hizmetten Birden Fazla Alım Durumu Oluşuyor.");
                return;
            }

            entity.HizmetAdi.Remove(entity.HizmetAdi.Length - 27, 27);
            entity.IptalEdildi = false;
            entity.IptalTarihi = null;
            entity.IptalNedeniId = null;
            entity.IptalNedeniAdi = null;
            entity.GittigiOkulId = null;
            entity.GittigiOkulAgi = null;
            entity.IptalAciklama = null;
            entity.Update = true;

            ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.TopluIptalGerial(entity.Id);
            UcretHesapla(entity);
            tablo.UpdateSummary();
            tablo.RowCellEnabled();
            ButtonEnabledDurum(true);

        }

        protected internal override void SutunGizleGoster()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<HizmetBilgileriL>();

            if (entity.HizmetTipi == HizmetTipi.Servis)
            {
                colServisYeriAdi.Visible = true;
                colServisYeriAdi.VisibleIndex = 1;
            }
            else
                colServisYeriAdi.Visible = false;
        }

        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<HizmetBilgileriL>();

            colIptalTarihi.OptionsColumn.AllowEdit = entity.IptalEdildi;
            colIptalNedeniAdi.OptionsColumn.AllowEdit= entity.IptalEdildi;
            colIptalAciklama.OptionsColumn.AllowEdit= entity.IptalEdildi;
            colGittigiOkulAdi.OptionsColumn.AllowEdit= entity.IptalEdildi;

            if(entity.HizmetTipi!=HizmetTipi.Egitim)
                colGittigiOkulAdi.OptionsColumn.AllowEdit = false;
        }

        protected override void HareketSil()
        {
            bool HizmetKartinaAitIptalEdilmisHareketVarmi(long hizmetId)
            {
                var count = tablo.DataController.ListSource.Cast<HizmetBilgileriL>().Count(x => x.HizmetId == hizmetId);
                return count < 2 && ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                    .Any(x => x.HizmetId == hizmetId && x.IptalEdildi);
            }

            if (tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("Hareket Bilgisi") != DialogResult.Yes) return;

            var entity = tablo.GetRow<HizmetBilgileriL>();
            if (entity.IptalEdildi)
            {
                Messages.IptalHareketSilinemezMesaji();
                return;
            }
            if (HizmetKartinaAitIptalEdilmisHareketVarmi(entity.HizmetId))
            {
                Messages.HataMesaji("Bu Hizmet Kartına Ait İptal Edilmiş İndirim Hareketleri Bulunmaktadır.Hizmet Kartı Silinemez .");
                return;
            }
            
            ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.TopluHareketSil(entity.HizmetId);

            entity.Delete = true;
            tablo.RefreshDataSource();
            ButtonEnabledDurum(true);
        }

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            base.Tablo_MouseUp(sender, e);

            var entity =(HizmetBilgileriL) tablo.GetRow(tablo.FocusedRowHandle);
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

            else if (e.FocusedColumn == colGittigiOkulAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryGittigiOkul, colGittigiOkulId);

            else if (e.FocusedColumn == colIptalTarihi)
            {
                var entity = tablo.GetRow<HizmetBilgileriL>();

                if (entity.IptalTarihi == null) return;
                repositoryIptalTarihi.MinValue = AnaForm.DonemParametreleri.GünTarihininOncesineIptalTarihiGirilebilir ? entity.BaslamaTarihi : DateTime.Now.Date;
                repositoryIptalTarihi.MaxValue = AnaForm.DonemParametreleri.GünTarihininSonrasinaIptalTarihiGirilebilir ? AnaForm.DonemParametreleri.DonemBitisTarihi.AddDays(-1) : DateTime.Now.Date;

            }
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            var entity = tablo.GetRow<HizmetBilgileriL>();

            if(e.Column==colIptalNedeniAdi)
            {
                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                    .Where(x => x.IptalEdildi && x.HizmetHareketId == entity.Id).ForEach(x=>x.IptalNedeniId=entity.IptalNedeniId);
                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                    .Where(x => x.IptalEdildi && x.HizmetHareketId == entity.Id).ForEach(x => x.IptalNedeniAdi = entity.IptalNedeniAdi);
            }
            else if (e.Column == colIptalAciklama)
            {
                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                    .Where(x => x.IptalEdildi && x.HizmetHareketId == entity.Id).ForEach(x => x.IptalAciklama = entity.IptalAciklama);
            }
            else if(e.Column==colIptalTarihi)
            {
                UcretHesapla(entity);
                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                   .Where(x => x.IptalEdildi && x.HizmetHareketId == entity.Id).ForEach(x => x.IptalTarihi= entity.IptalTarihi);

                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.TopluIndirimHesapla();
            }
        }
    }
}

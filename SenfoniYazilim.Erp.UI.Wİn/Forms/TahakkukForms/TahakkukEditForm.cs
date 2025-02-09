﻿using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.TahakkukEditFormTable;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.TahakkukForms
{
    public partial class TahakkukEditForm : BaseEditForm
    {
        private readonly Personel _ogrenci;
        private BaseTablo _kardesBilgilerTable;
        private BaseTablo _aileBilgileriTable;
        private BaseTablo _sinavBilgileriTable;
        private BaseTablo _evrakBilgileriTable;
        private BaseTablo _promosyonBilgileriTable;
        private BaseTablo _iletisimBilgileriTable;
        private BaseTablo _ePosBilgileriTable;
        private BaseTablo _bilgiNotlariTable;

        public TahakkukEditForm()
        {
            InitializeComponent();

            DataLayoutControls = new[] { DataLayoutGenel,DataLayoutGenelBilgiler };
            Bll = new TahakkukBll(DataLayoutGenelBilgiler);
            BaseKartTuru = KartTuru.Tahakkuk;
            EventsLoad();

            ShowItems = new BarItem[] { btnYazdir };

            HideItems = new BarItem[] { btnYeni };

            txtKayitDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitDurumu>());
            txtKayitSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitSekli>());
            txtSonrakiDonemKAyitDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<SonrakiDonemKayitDurumu>());
            txtKayitTarihi.Properties.MinValue = AnaForm.DonemParametreleri.DonemBaslamaTarihi;
            txtKayitTarihi.Properties.MaxValue = AnaForm.DonemParametreleri.DonemBitisTarihi;

            btnYazdir.Caption = "Kayıt Evrakları";

            KayitSonrasiFormuKapat = false; 
        }

        public TahakkukEditForm(params object[] prm):this()
        {
            if (prm[0] is Personel ogr)
                //_ogrenci = (Ogrenci)prm[0];
                _ogrenci = ogr;
            else if (prm[0] is bool yesNo)
                FarkliSubeIslemi = yesNo;
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new TahakkukS() : ((TahakkukBll)Bll).Single(FilterFunctions.Filter<Tahakkuk>(Id));
            NesneyiKontrollereBagla();
            BagliTabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((TahakkukBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtOkulNo.Focus();

        }

        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
               return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);
            }
            if (_kardesBilgilerTable != null&&TableValueChanged(_kardesBilgilerTable))
                _kardesBilgilerTable.Yukle();
            if (_aileBilgileriTable != null && TableValueChanged(_aileBilgileriTable))
                _aileBilgileriTable.Yukle();
            if (_sinavBilgileriTable != null && TableValueChanged(_sinavBilgileriTable))
                _sinavBilgileriTable.Yukle();
            if (_evrakBilgileriTable != null && TableValueChanged(_evrakBilgileriTable))
                _evrakBilgileriTable.Yukle();
            if (_promosyonBilgileriTable != null && TableValueChanged(_promosyonBilgileriTable))
                _promosyonBilgileriTable.Yukle();
            if (_iletisimBilgileriTable != null && TableValueChanged(_iletisimBilgileriTable))
                _iletisimBilgileriTable.Yukle();
            if (_ePosBilgileriTable != null && TableValueChanged(_ePosBilgileriTable))
                _ePosBilgileriTable.Yukle();
            if (_bilgiNotlariTable != null && TableValueChanged(_bilgiNotlariTable))
                _bilgiNotlariTable.Yukle();
            if (hizmetBilgileriTable.OwnerForm == null)
            {
                hizmetBilgileriTable.OwnerForm = this;
                hizmetBilgileriTable.Yukle();
            }
            if (indirimBilgileriTable.OwnerForm == null)
            {
                indirimBilgileriTable.OwnerForm = this;
                indirimBilgileriTable.Yukle();
            }
            if (odemeBilgileriTable.OwnerForm == null)
            {
                odemeBilgileriTable.OwnerForm = this;
                odemeBilgileriTable.Yukle();
                odemeBilgileriTable.insUpNavigator.Navigator.TextLocation = NavigatorButtonsTextLocation.Begin;
                odemeBilgileriTable.insUpNavigator.Navigator.TextStringFormat = "Taksit ( {0} / {1})";
                odemeBilgileriTable.insUpNavigator.Navigator.Appearance.ForeColor = SystemColors.HotTrack;
            }
            if (geriOdemeBilgileriTable.OwnerForm == null)
            {
                geriOdemeBilgileriTable.OwnerForm = this;
                geriOdemeBilgileriTable.Yukle();
            }

            if (TableValueChanged(hizmetBilgileriTable))
            {
                var rowHandle = hizmetBilgileriTable.Tablo.FocusedRowHandle;
                hizmetBilgileriTable.Yukle();
                hizmetBilgileriTable.Tablo.FocusedRowHandle = rowHandle;
            }
            if (TableValueChanged(indirimBilgileriTable))
            {
                var rowHandle = indirimBilgileriTable.Tablo.FocusedRowHandle;
                indirimBilgileriTable.Yukle();
                indirimBilgileriTable.Tablo.FocusedRowHandle = rowHandle;
            }
            if (TableValueChanged(odemeBilgileriTable))
            {
                var rowHandle = odemeBilgileriTable.Tablo.FocusedRowHandle;
                odemeBilgileriTable.Yukle();
                odemeBilgileriTable.Tablo.FocusedRowHandle = rowHandle;
            }
            if (TableValueChanged(geriOdemeBilgileriTable))
            {
                var rowHandle = geriOdemeBilgileriTable.Tablo.FocusedRowHandle;
                geriOdemeBilgileriTable.Yukle();
                geriOdemeBilgileriTable.Tablo.FocusedRowHandle = rowHandle;
            }

            Toplamlar();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (TahakkukS)OldEntity;
            txtKod.Text = entity.Kod;
            txtTcKimlikNo.Text =BaseIslemTuru==IslemTuru.EntityInsert?_ogrenci.TcKimlikNo: entity.TcKimlikNo;
            txtAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.Adi : entity.Adi;
            txtOkulNo.Text = entity.OgrenciNo;
            txtSoyadi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.Soyadi : entity.Soyadi;
            txtBabaAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.BabaAdi : entity.BabaAdi;
            txtAnaAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.AnaAdi : entity.AnaAdi;
            txtDurum.Text = entity.Durum ? IptalDurumu.DevamEdiyor.toName() : IptalDurumu.IptalEdildi.toName();
            txtKayitTarihi.DateTime = entity.KayitTarihi;
            txtKayitSekli.SelectedItem = entity.KayitSekli.toName();
            txtKayitDurumu.SelectedItem = entity.KayitDurumu.toName();
            txtSinifAdi.Id = entity.SinifId;
            txtSinifAdi.Text = entity.SinifAdi;
            txtGeldigiOkul.Id = entity.GeldigiOkulId;
            txtGeldigiOkul.Text = entity.GeldigiOkulAdi;
            txtKontenjanTuru.Id = entity.KontenjanId;
            txtKontenjanTuru.Text = entity.KontenjanAdi;
            txtYabanciDil.Id = entity.YabanciDilId;
            txtYabanciDil.Text = entity.YabanciDilAdi;
            txtSinifOgretmeni.Id = entity.RehberId;
            txtSinifOgretmeni.Text = entity.RehberAdi;
            txtTesvikDurumu.Id = entity.TesvikId;
            txtTesvikDurumu.Text = entity.TesvikAdi;
            txtSonrakiDonemKAyitDurumu.Text = entity.SonrakiDonemKayitDurumu.toName();
            txtSonrakiDonemKayitDurumuAciklama.Text = entity.SonrakiDonemKayitDurumuAciklama;
            txtOzelKod1.Id = entity.OzelKod1Id;
                txtOzelKod1.Text = entity.OzelKod1Adi;
                txtOzelKod2.Id = entity.OzelKod2Id;
                txtOzelKod2.Text = entity.OzelKod2Adi;
                txtOzelKod3.Id = entity.OzelKod3Id;
                txtOzelKod3.Text = entity.OzelKod3Adi;
                txtOzelKod4.Id = entity.OzelKod4Id;
                txtOzelKod4.Text = entity.OzelKod4Adi;
                txtOzelKod5.Id = entity.OzelKod5Id;
                txtOzelKod5.Text = entity.OzelKod5Adi;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Tahakkuk
            {
                Id = Id,
                Kod = txtKod.Text,
                OgrenciId = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.Id : ((TahakkukS)OldEntity).OgrenciId,
                OgrenciNo = txtOkulNo.Text,
                KayitTarihi = txtKayitTarihi.DateTime.Date,
                KayitSekli = txtKayitSekli.Text.GetEnum<KayitSekli>(),
                SinifId = Convert.ToInt64(txtSinifAdi.Id),
                KayitDurumu = txtKayitDurumu.Text.GetEnum<KayitDurumu>(),
                YabanciDilId = txtYabanciDil.Id,
                GeldigiOkulId = txtGeldigiOkul.Id,
                KontenjanId = txtKontenjanTuru.Id,
                TesvikId = txtTesvikDurumu.Id,
                RehberId = txtSinifOgretmeni.Id,
                SonrakiDonemKayitDurumu = txtSonrakiDonemKAyitDurumu.Text.GetEnum<SonrakiDonemKayitDurumu>(),
                SonrakiDonemKayitDurumuAciklama=txtSonrakiDonemKayitDurumuAciklama.Text,
                OzelKod1Id=txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                OzelKod3Id = txtOzelKod3.Id,
                OzelKod4Id = txtOzelKod4.Id,
                OzelKod5Id = txtOzelKod5.Id,
                Durum=txtDurum.Text.GetEnum<IptalDurumu>()==IptalDurumu.DevamEdiyor,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
            };
        }

        protected override bool EntityInsert()
        {
            if (!DurumKontrol()) return false;
            if (BagliTabloHataliGirisKontrol()) return false;

            var result = ((TahakkukBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId)&&BagliTabloKaydet();

            if (result&&!KayitSonrasiFormuKapat)
                BagliTabloYukle();

            return result;
        }

        protected override bool EntityUpdate()
        {
            if (!DurumKontrol()) return false; 
            if (BagliTabloHataliGirisKontrol()) return false;

            var result = ((TahakkukBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId)&&BagliTabloKaydet();

            if (result&&!KayitSonrasiFormuKapat)
                BagliTabloYukle();

            return result;
        }

        protected override bool BagliTabloHataliGirisKontrol()
        {
            if (_sinavBilgileriTable != null && _sinavBilgileriTable.HatalıGiriş())
            {
                tabUst.SelectedPage = pageAileSinavBilgileri;
                _sinavBilgileriTable.Tablo.GridControl.Focus();
                return true;
            }
            if (_iletisimBilgileriTable != null && _iletisimBilgileriTable.HatalıGiriş())
            {
                tabUst.SelectedPage = pageIletisimBilgileri;
                _iletisimBilgileriTable.Tablo.GridControl.Focus();
                return true;
            }
            if (_ePosBilgileriTable != null && _ePosBilgileriTable.HatalıGiriş())
            {
                tabUst.SelectedPage = PageEPosBilgileri;
                _ePosBilgileriTable.Tablo.GridControl.Focus();
                return true;
            }
            if (_bilgiNotlariTable != null && _bilgiNotlariTable.HatalıGiriş())
            {
                tabUst.SelectedPage = pageNotlar;
                _bilgiNotlariTable.Tablo.GridControl.Focus();
                return true;
            }
            if (hizmetBilgileriTable.HatalıGiriş())
            {
                tabAlt.SelectedPage = pageHizmetBilgileri;
                hizmetBilgileriTable.Tablo.GridControl.Focus();
                return true;
            }
            if (hizmetBilgileriTable.HatalıGiriş())
            {
                tabAlt.SelectedPage = pageOdemeBilgileri;
                odemeBilgileriTable.Tablo.GridControl.Focus();
                return true;
            }           

            if (geriOdemeBilgileriTable.HatalıGiriş())
            {
                tabAlt.SelectedPage = pageGeriOdemeBilgileri;
                geriOdemeBilgileriTable.Tablo.GridControl.Focus();
                return true;
            }

            return false;
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtSinifAdi)
                    sec.Sec(txtSinifAdi);
                else if (sender == txtYabanciDil)
                    sec.Sec(txtYabanciDil);
                else if (sender == txtGeldigiOkul)
                    sec.Sec(txtGeldigiOkul);
                else if (sender == txtKontenjanTuru)
                    sec.Sec(txtKontenjanTuru);
                else if (sender == txtTesvikDurumu)
                    sec.Sec(txtTesvikDurumu);
                else if (sender == txtSinifOgretmeni)
                    sec.Sec(txtSinifOgretmeni);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Tahakkuk);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Tahakkuk);
                else if (sender == txtOzelKod3)
                    sec.Sec(txtOzelKod3, KartTuru.Tahakkuk);
                else if (sender == txtOzelKod4)
                    sec.Sec(txtOzelKod4, KartTuru.Tahakkuk);
                else if (sender == txtOzelKod5)
                    sec.Sec(txtOzelKod5, KartTuru.Tahakkuk);
        }

        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (_kardesBilgilerTable != null&& _kardesBilgilerTable.TableValueChanged) return true;
                if (_aileBilgileriTable != null && _aileBilgileriTable.TableValueChanged) return true;
                if (_sinavBilgileriTable != null && _sinavBilgileriTable.TableValueChanged) return true;
                if (_evrakBilgileriTable != null && _evrakBilgileriTable.TableValueChanged) return true;
                if (_promosyonBilgileriTable != null && _promosyonBilgileriTable.TableValueChanged) return true;
                if (_iletisimBilgileriTable != null && _iletisimBilgileriTable.TableValueChanged) return true;
                if (_ePosBilgileriTable != null && _ePosBilgileriTable.TableValueChanged) return true;
                if (_bilgiNotlariTable != null && _bilgiNotlariTable.TableValueChanged) return true;
                if (hizmetBilgileriTable.TableValueChanged) return true;
                if (indirimBilgileriTable.TableValueChanged) return true;
                if (odemeBilgileriTable.TableValueChanged) return true;
                if (geriOdemeBilgileriTable.TableValueChanged) return true;

                return false;
            }

            if (hizmetBilgileriTable.TableValueChanged || indirimBilgileriTable.TableValueChanged || odemeBilgileriTable.TableValueChanged || geriOdemeBilgileriTable.TableValueChanged)
                Toplamlar();

            if (FarkliSubeIslemi)
                GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial);
            else
                GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial, OldEntity, CurrentEntity, TableValueChanged());
        }

        protected override bool BagliTabloKaydet()
        {
            if (_kardesBilgilerTable != null && !_kardesBilgilerTable.Kaydet()) return false;
            if (_aileBilgileriTable != null && !_aileBilgileriTable.Kaydet()) return false;
            if (_sinavBilgileriTable != null && !_sinavBilgileriTable.Kaydet()) return false;
            if (_evrakBilgileriTable != null && !_evrakBilgileriTable.Kaydet()) return false;
            if (_promosyonBilgileriTable != null && !_promosyonBilgileriTable.Kaydet()) return false;
            if (_iletisimBilgileriTable != null && !_iletisimBilgileriTable.Kaydet()) return false;
            if (_ePosBilgileriTable != null && !_ePosBilgileriTable.Kaydet()) return false;
            if (_bilgiNotlariTable != null && !_bilgiNotlariTable.Kaydet()) return false;
            if (!hizmetBilgileriTable.Kaydet()) return false;
            if (!indirimBilgileriTable.Kaydet()) return false;
            if (!odemeBilgileriTable.Kaydet()) return false;
            if (!geriOdemeBilgileriTable.Kaydet()) return false;

            return true;
        }

        private void Toplamlar()
        {
            var hizmetBilgileriToplami = hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>()
                .Where(x => !x.Delete).Sum(x => x.BrutUcret - x.KistDonemDusulenUcret);
            var indirimBilgileriToplami = indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                .Where(x => !x.Delete).Sum(x => x.BrutIndirim - x.KistDonemDusulenIndirim);
            var odemeBilgileriToplami = odemeBilgileriTable.Tablo.DataController.ListSource.Cast<OdemeBilgileriL>()
                .Where(x => !x.Delete).Sum(x => x.Tutar);
            var geriIadelerToplami = odemeBilgileriTable.Tablo.DataController.ListSource.Cast<OdemeBilgileriL>()
                .Where(x => !x.Delete).Sum(x => x.Iade);
            var geriOdemelerToplami = geriOdemeBilgileriTable.Tablo.DataController.ListSource.Cast<GeriOdemeBilgileriL>()
                .Where(x => !x.Delete).Sum(x => x.Tutar);

            txtHizmetBilgileriToplami.Value = hizmetBilgileriToplami;
            txtIndirimBilgileriToplami.Value = indirimBilgileriToplami;
            txtOdemeBilgileriToplami.Value = odemeBilgileriToplami;
            txtGeriIadelerToplami.Value = geriIadelerToplami;
            txtGeriOdemelerToplami.Value = geriOdemelerToplami;

            txtFark.Value =hizmetBilgileriToplami-indirimBilgileriToplami- (odemeBilgileriToplami - (geriIadelerToplami + geriOdemelerToplami));

            txtFark.Properties.Appearance.BackColor = txtFark.Value == 0 ? Color.GreenYellow: Color.IndianRed;
        }

        private bool DurumKontrol()
        {
            if (txtFark.Value != 0)
            {
                Messages.HataMesaji("Ücret Toplamları farkı sıfır (0) olmalıdır.");
                return false;
            }
            var source = hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>();
            if (!source.Any(x => !x.Delete && !x.IptalEdildi && x.HizmetTipi != HizmetTipi.Egitim))
            {
                Messages.UyariMesaji("Eğitim Hizmeti Alınmadığı için Tahakkuk Pasif Duruma Alınacaktır.");
                txtDurum.Text = IptalDurumu.IptalEdildi.toName();
            }
            else
                txtDurum.Text = IptalDurumu.DevamEdiyor.toName();

            return true;
        }

        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page == pageGenelBilgiler)
            {
                txtOkulNo.Focus();
                txtOkulNo.SelectAll();
            }

            else if (e.Page == pageKardesBilgileri)
            {
                if (pageKardesBilgileri.Controls.Count == 0)
                {
                    _kardesBilgilerTable = new KardesBilgileriTable().AddTable(this);
                    pageKardesBilgileri.Controls.Add(_kardesBilgilerTable);
                    _kardesBilgilerTable.Yukle();
                }

                _kardesBilgilerTable.Tablo.GridControl.Focus();
                //pageKardesBilgileri.Controls[0].Focus();
            }

            

            //else if (e.Page == pageEvrakPromosyonBilgileri)
            //{
            //    if (layoutControlEvrakPromosyonBilgileri.Count == 0)
            //    {
            //        _evrakBilgileriTable = new EvrakBilgileriTable().AddTable(this);
            //        //pageAileSinavBilgileri.Controls.Add(_aileBilgileriTable);
            //        layoutControlEvrakPromosyonBilgileri.LayoutControlInsert(_evrakBilgileriTable, 0, 0, 0, 0);
            //        _evrakBilgileriTable.Yukle();

            //        _promosyonBilgileriTable = new PromosyonBilgileriTable().AddTable(this);
            //        layoutControlEvrakPromosyonBilgileri.LayoutControlInsert(_promosyonBilgileriTable, 1, 0, 0, 0);
            //        _promosyonBilgileriTable.Yukle();
            //    }

            //    _evrakBilgileriTable.Tablo.GridControl.Focus();
            //}

            else if (e.Page == pageIletisimBilgileri)
            {
                if (pageIletisimBilgileri.Controls.Count == 0)
                {
                    _iletisimBilgileriTable = new IletisimBilgileriTable().AddTable(this);
                    pageIletisimBilgileri.Controls.Add(_iletisimBilgileriTable);
                    _iletisimBilgileriTable.Yukle();
                }

                _iletisimBilgileriTable.Tablo.GridControl.Focus();
            }
            else if (e.Page == PageEPosBilgileri)
            {
                if (PageEPosBilgileri.Controls.Count == 0)
                {
                    _ePosBilgileriTable = new EPosBilgileriTable().AddTable(this);
                    PageEPosBilgileri.Controls.Add(_ePosBilgileriTable);
                    _ePosBilgileriTable.Yukle();
                }

                _ePosBilgileriTable.Tablo.GridControl.Focus();
            }

            else if (e.Page == pageNotlar)
            {
                if (pageNotlar.Controls.Count == 0)
                {
                    _bilgiNotlariTable = new BilgiNotlariTable().AddTable(this);
                    pageNotlar.Controls.Add(_bilgiNotlariTable);
                    _bilgiNotlariTable.Yukle();
                }

                _bilgiNotlariTable.Tablo.GridControl.Focus();
            }
            else if (e.Page == pageHizmetBilgileri)
                hizmetBilgileriTable.Tablo.GridControl.Focus();

            else if (e.Page == pageIndirimBilgileri)
                indirimBilgileriTable.Tablo.GridControl.Focus();

            else if (e.Page == pageOdemeBilgileri)
                odemeBilgileriTable.Tablo.GridControl.Focus();

            else if (e.Page == pageGeriOdemeBilgileri)
                geriOdemeBilgileriTable.Tablo.GridControl.Focus();
        }

        protected override void Yazdir()
        {
            if (pageIletisimBilgileri.Controls.Count == 0)
            {
                _iletisimBilgileriTable = new IletisimBilgileriTable().AddTable(this);
                pageIletisimBilgileri.Controls.Add(_iletisimBilgileriTable);
                _iletisimBilgileriTable.Yukle();
            }

            if (PageEPosBilgileri.Controls.Count == 0)
            {
                _ePosBilgileriTable = new EPosBilgileriTable().AddTable(this);
                PageEPosBilgileri.Controls.Add(_ePosBilgileriTable);
                _ePosBilgileriTable.Yukle();
            }

            var ogrenciBilgileri = ((TahakkukBll)Bll).SingleDetail(x => x.Id == Id);
            var iletisimBilgileri = _iletisimBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<IletisimBilgileriR>();
            var hizmetBilgileri = hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<HizmetBilgileriR>();
            var indirimBilgileri = indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<IndirimBilgileriR>();
            var odemeBilgileri = odemeBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<OdemeBilgileriR>();
            var geriOdemeBilgileri = geriOdemeBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<GeriOdemeBilgileriR>();
            //var eposBilgileri= _ePosBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<EPosBilgileriR>();

            ShowListForms<RaporSecim>.ShowDialogListForm(KartTuru.Rapor, true, ogrenciBilgileri, iletisimBilgileri, hizmetBilgileri, indirimBilgileri, odemeBilgileri, geriOdemeBilgileri);
        }
    }
}
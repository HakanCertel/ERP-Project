﻿using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using System;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.MakbuzForms
{
    public partial class MakbuzEditForm : BaseEditForm
    {
        protected internal readonly MakbuzTuru _makbuzTuru;
        private readonly MakbuzHesapTuru _hesapTuru;

        public MakbuzEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new MakbuzBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Makbuz;
            EventsLoad();

            HideItems = new BarItem[] { btnYeni };
            ShowItems = new BarItem[] { btnYazdir };

            KayitSonrasiFormuKapat = false;

            _makbuzTuru = (MakbuzTuru)prm[0];
            _hesapTuru = (MakbuzHesapTuru)prm[1];
            FarkliSubeIslemi = prm.Length > 2 && prm[2].GetType() == typeof(bool);
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new MakbuzS() : ((MakbuzBll)Bll).Single(FilterFunctions.Filter<Makbuz>(Id));
            AlanIslemleri();
            NesneyiKontrollereBagla();
            TabloYukle();
            MakbuzTuruEnabled();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtMakbuzNo.Text = ((MakbuzBll)Bll).YeniKodVer(x =>x.DonemId==AnaForm.DonemId &&x.SubeId == AnaForm.SubeId);
            txtTarih.DateTime = DateTime.Now.Date;
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MakbuzS)OldEntity;

            txtMakbuzNo.Text = entity.Kod;
            txtTarih.DateTime = entity.Tarih;
            txtHesapTuru.SelectedItem = _hesapTuru.toName();

            if (BaseIslemTuru == IslemTuru.EntityInsert)
            {
                switch (_hesapTuru)
                {
                    case MakbuzHesapTuru.Kasa when AnaForm.KullaniciParametreleri.DefaultKasaHesapId!=null:
                        txtHesap.Id = AnaForm.KullaniciParametreleri.DefaultKasaHesapId;
                        txtHesap.Text = AnaForm.KullaniciParametreleri.DefaultKasaHesapAdi;
                        break;
                    case MakbuzHesapTuru.Banka when AnaForm.KullaniciParametreleri.DefaultBankaHesapId != null:
                        txtHesap.Id = AnaForm.KullaniciParametreleri.DefaultBankaHesapId;
                        txtHesap.Text = AnaForm.KullaniciParametreleri.DefaultBankaHesapAdi;
                        break;
                    case MakbuzHesapTuru.Avukat when AnaForm.KullaniciParametreleri.DefaultAvukatHesapId != null:
                        txtHesap.Id = AnaForm.KullaniciParametreleri.DefaultAvukatHesapId;
                        txtHesap.Text = AnaForm.KullaniciParametreleri.DefaultAvukatHesapAdi;
                        break;
                    case MakbuzHesapTuru.Transfer when _makbuzTuru==MakbuzTuru.GelenBelgeyiOnaylama:
                        txtHesap.Id = AnaForm.SubeId;
                        txtHesap.Text = AnaForm.SubeAdi;
                        break;
                }
            }
            else
            {
                txtHesap.Id = entity.AvukatHesapId ?? entity.BankaHesapId ?? entity.CariHesapId ?? entity.KasaHesapId ?? entity.SubeHesapId;
                txtHesap.Text = entity.HesapAdi;
            }
        }

        protected override void GuncelNesneOlustur()
        {
            var hesapTuru = txtHesapTuru.Text.GetEnum<MakbuzHesapTuru>();
            CurrentEntity = new Makbuz//*****
            {
                Id = Id,
                Kod = txtMakbuzNo.Text,
                Tarih = txtTarih.DateTime.Date,
                MakbuzTuru = _makbuzTuru,
                HesapTuru = hesapTuru,
                AvukatHesapId = hesapTuru == MakbuzHesapTuru.Avukat ? txtHesap.Id : null,
                BankaHesapId = hesapTuru == MakbuzHesapTuru.Banka || hesapTuru == MakbuzHesapTuru.EPos || hesapTuru == MakbuzHesapTuru.Ots
                           || hesapTuru == MakbuzHesapTuru.Pos ? txtHesap.Id : null,
                CariHesapId = hesapTuru == MakbuzHesapTuru.Cari ? txtHesap.Id:null,
                KasaHesapId=hesapTuru==MakbuzHesapTuru.Kasa?txtHesap.Id:null,
                SubeHesapId=hesapTuru==MakbuzHesapTuru.Transfer?txtHesap.Id:null,
                HareketSayisi=makbuzHareketleriTable.Tablo.DataRowCount,
                MakbuzToplami=decimal.Parse(makbuzHareketleriTable.colIslemTutari.SummaryText),
                DonemId=AnaForm.DonemId,
                SubeId = AnaForm.SubeId
            };

            ButonEnabledDurumu();
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            if (FarkliSubeIslemi)
                GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial);
            else
                GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial, OldEntity, CurrentEntity,makbuzHareketleriTable.TableValueChanged);
        }

        protected override bool EntityInsert()
        {
            GuncelNesneOlustur();
            if (HataliGiris()) return false;
            if (makbuzHareketleriTable.HatalıGiriş()) return false;

            var result = ((MakbuzBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && makbuzHareketleriTable.Kaydet();

            if (result && !KayitSonrasiFormuKapat)
                makbuzHareketleriTable.Yukle();

            return result;
        }

        protected override bool EntityUpdate()
        {
            GuncelNesneOlustur();
            if (HataliGiris()) return false;
            if (makbuzHareketleriTable.HatalıGiriş()) return false;

            var result = ((MakbuzBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);// && BagliTabloKaydet();

            if (result && !KayitSonrasiFormuKapat)
                makbuzHareketleriTable.Yukle();

            return result;
        }

        protected override void EntityDelete()
        {
            if (!makbuzHareketleriTable.TopluHareketSil()) return;
            if (((IBaseCommonBll)Bll).Delete(OldEntity)) return;
            RefreshYapilacak = true;
            Close();
        }

        protected internal bool HataliGiris()
        {
            if (!txtHesap.Visible || txtHesap.Id != null) return false;
            Messages.SecimHataMesaji("Hesap");
            txtHesap.Focus();
            return true;
        }

        private void AlanIslemleri()
        {
            Text = $"{Text} - {_makbuzTuru.toName()}";
            txtTarih.Properties.MinValue = AnaForm.DonemParametreleri.GünTarihininOncesineMakbuzTarihiGirilebilir ? AnaForm.DonemParametreleri.DonemBaslamaTarihi : DateTime.Now.Date;
            txtTarih.Properties.MaxValue= AnaForm.DonemParametreleri.GünTarihininSonrasinaMakbuzTarihiGirilebilir ? AnaForm.DonemParametreleri.DonemBitisTarihi : DateTime.Now.Date;


            switch (_makbuzTuru)
            {
                case MakbuzTuru.BlokeyeAlma:
                case MakbuzTuru.BlokeCozumu:
                    txtHesapTuru.Properties.Items.AddRange(Enum.GetValues(typeof(MakbuzHesapTuru))
                        .Cast<MakbuzHesapTuru>()
                        .Where(x=> x==MakbuzHesapTuru.EPos|| x == MakbuzHesapTuru.Pos|| x == MakbuzHesapTuru.Ots)
                        .Select(x=>x.toName()).ToList());
                    break;
                case MakbuzTuru.PortfoyeGeriIade:
                case MakbuzTuru.PortfoyeKarsiliksizIade:
                    txtHesapTuru.Properties.Items.AddRange(Enum.GetValues(typeof(MakbuzHesapTuru))
                        .Cast<MakbuzHesapTuru>()
                        .Where(x => x == MakbuzHesapTuru.Avukat || x == MakbuzHesapTuru.Banka || x == MakbuzHesapTuru.Cari)
                        .Select(x => x.toName()).ToList());
                    break;
                case MakbuzTuru.OdenmisOlarakIsaretleme:
                case MakbuzTuru.KarsiliksizOlarakIsaretleme:
                case MakbuzTuru.TahsiliImkansizHaleGelme:
                case MakbuzTuru.MusteriyeGeriIade:
                    txtHesapTuru.Properties.Items.Add(_hesapTuru.toName());
                    layoutHesapAdi.Visibility = LayoutVisibility.Never;
                    break;
                default:
                    txtHesapTuru.Properties.Items.Add(_hesapTuru.toName());
                    break;
            }
        }

        protected internal void MakbuzTuruEnabled()
        {
            switch (_makbuzTuru)
            {
                case MakbuzTuru.BlokeyeAlma:
                case MakbuzTuru.BlokeCozumu:
                case MakbuzTuru.PortfoyeGeriIade:
                case MakbuzTuru.PortfoyeKarsiliksizIade:
                case MakbuzTuru.AvukataGonderme:
                case MakbuzTuru.AvukatYoluylaTahsilEtme:
                case MakbuzTuru.BankayaTahsileGonderme:
                case MakbuzTuru.BankaYoluylaTahsilEtme:
                case MakbuzTuru.BaskaSubeyeGonderme:
                case MakbuzTuru.CiroEtme:
                    txtHesap.Enabled = makbuzHareketleriTable.Tablo.DataRowCount == 0;
                    txtHesapTuru.Enabled= makbuzHareketleriTable.Tablo.DataRowCount == 0;
                    break;
                case MakbuzTuru.GelenBelgeyiOnaylama:
                    txtHesapTuru.Enabled = false;
                    txtHesap.Enabled = false;
                    break;
            }
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                switch (txtHesapTuru.Text.GetEnum<MakbuzHesapTuru>())
                {
                    case MakbuzHesapTuru.Avukat:
                        sec.Sec(txtHesap, KartTuru.Avukat);
                        break;
                    case MakbuzHesapTuru.Banka:
                        sec.Sec(txtHesap, KartTuru.Banka);//, BankaHesapTuru.VadesizMevduatHesabi);
                        break;
                    case MakbuzHesapTuru.Cari:
                    case MakbuzHesapTuru.Mahsup:
                        sec.Sec(txtHesap, KartTuru.Cari);
                        break;
                    case MakbuzHesapTuru.EPos:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.EPosBlokeHesabi);
                        break;
                    case MakbuzHesapTuru.Ots:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.OtsBlokeHesabi);
                        break;
                    case MakbuzHesapTuru.Pos:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.PosBlokeHesabi);
                        break;
                    case MakbuzHesapTuru.Kasa:
                        sec.Sec(txtHesap, KartTuru.Kasa);
                        break;
                        //case MakbuzHesapTuru.Sube:
                        //    sec.Sec(txtHesap, KartTuru.Sube);
                        //    break;

                }
            }
        }

        protected override void TabloYukle()
        {
            makbuzHareketleriTable.OwnerForm = this;
            makbuzHareketleriTable.Yukle();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtHesapTuru) return;
            txtHesap.Id = null;
            txtHesap.Text = null;
            txtHesap.Focus();
        }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            if (layoutHesapAdi.Visible && txtHesap.Id == null)
                txtHesap.Focus();
            else
                makbuzHareketleriTable.Tablo.GridControl.Focus();

        }
    }
}
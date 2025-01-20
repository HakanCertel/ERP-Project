using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.TahakkukForms
{
    public partial class TopluOdemePlaniEditForm : BaseEditForm
    {
        private readonly IList _source;
        private readonly long _tahakkukId;
        private readonly decimal _bakiye;
        private readonly DateTime _kayitTarihi;
        private readonly int _dahaOnceGirilenTaksitSayisi;

        private OdemeTipi _odemeTipi;
        private byte _blokeGunSayisi;

        public TopluOdemePlaniEditForm(params object[] prm)//IList source,long tahakkukId,decimal bakiye,DateTime kayitTarihi,int dahaOnceGirilenTaksitSayisi)
        {
            InitializeComponent();

            _source =(IList) prm[0];
            _tahakkukId =(long) prm[1];
            _bakiye = (decimal)prm[2];
            _kayitTarihi =(DateTime) prm[3];
            _dahaOnceGirilenTaksitSayisi = (int)prm[4];

            DataLayoutControl = myDataLayoutControl;
            EventsLoad();
            ShowItems = new BarItem[] { btnTaksitOlustur};
            HideItems = new BarItem[] {btnYeni,btnKaydet,btnFarkliKaydet,btnGerial,btnSil };
        }

        public  override void Yukle()
        {
            ControlEnableChange(OdemeTipi.Acik);
            txtIlkTaksitTarihi.DateTime = _kayitTarihi;
            txtIlkTaksitTarihi.Properties.MinValue = _kayitTarihi;
            txtIlkTaksitTarihi.Properties.MaxValue = AnaForm.DonemParametreleri.MaksimumTaksitTarihi;
            txtSabitTaksit.Value = 0;
            txtBakiye.Value = _bakiye;
            txtTaksitSayisi.Properties.MinValue = 1;
            txtTaksitSayisi.Properties.MaxValue = AnaForm.DonemParametreleri.MaksimumTaksitSayisi - _dahaOnceGirilenTaksitSayisi;


            if (AnaForm.DonemParametreleri.MaksimumTaksitSayisi - _dahaOnceGirilenTaksitSayisi > 0)
                ShowDialog();
            else
                Messages.HataMesaji("Maksimum Taksit Sayısı Aşılıyor .");
        }

        private void ControlEnableChange(OdemeTipi odemeTipi)
        {
            txtBankaHesapAdi.Enabled = odemeTipi == OdemeTipi.EPos || odemeTipi == OdemeTipi.Ots || odemeTipi == OdemeTipi.Pos;
            txtAsilBorclu.Enabled = odemeTipi == OdemeTipi.Cek || odemeTipi == OdemeTipi.Senet;
            txtCiranta.Enabled = odemeTipi == OdemeTipi.Cek || odemeTipi == OdemeTipi.Senet;
            txtBanka.Enabled = odemeTipi == OdemeTipi.Cek;
            txtBankaSube.Enabled = odemeTipi == OdemeTipi.Cek;
            txtHesapNo.Enabled = odemeTipi == OdemeTipi.Cek;
            txtIlkBelgeNo.Enabled = odemeTipi == OdemeTipi.Cek;
            txtBanka.ControlEnabledChanged(txtBankaSube);
        }

        private bool HataliGirs()
        {
            if (txtIlkTaksitTarihi.DateTime.Date.AddMonths((int)txtTaksitSayisi.Value-1) > AnaForm.DonemParametreleri.MaksimumTaksitTarihi)
            {
                Messages.HataMesaji("Maksimum Taksit Tarihi Aşılıyor .");
                return true;
            }

            if (txtOdemeTuru.Id == null)
            {
                Messages.HataMesaji("Odeme Türü Seçimi Yapmalısınız .");
                txtOdemeTuru.Focus();
                return true;
            }

            if ((_odemeTipi == OdemeTipi.EPos || _odemeTipi == OdemeTipi.Ots || _odemeTipi == OdemeTipi.Pos) && txtBankaHesapAdi.Id == null)
            {
                Messages.SecimHataMesaji("Banka Hesap");
                txtBankaHesapAdi.Focus();
                return true;
            }

            if (txtSabitTaksit.Value == 0 && txtBakiye.Value == 0 || txtSabitTaksit.Value > 0 && txtBakiye.Value > 0)
            {
                Messages.HataMesaji("Sabit Taksit Veya Bakiye Alanlarından Sadece Birisinin Değeri Sıfıra Eşit Veya Sıfırdan Büyük Olmalı .");
                txtSabitTaksit.Focus();
                return true;
            }

            if ((_odemeTipi == OdemeTipi.Senet || _odemeTipi == OdemeTipi.Cek) && string.IsNullOrEmpty(txtAsilBorclu.Text))
            {
                Messages.HataliVeriMesaji("Asıl Borçlu");
                txtAsilBorclu.Focus();
                return true;
            }

            switch (_odemeTipi)
            {

                case OdemeTipi.Cek when txtBanka.Id == null:
                    Messages.SecimHataMesaji("Banka");
                    txtBanka.Focus();
                    return true;
                case OdemeTipi.Cek when txtBankaSube.Id == null:
                    Messages.SecimHataMesaji("Banka Şube");
                    txtBankaSube.Focus();
                    return true;
                case OdemeTipi.Cek when txtIlkBelgeNo.Value==0:
                    Messages.HataliVeriMesaji("İlk Belge No");
                    txtIlkBelgeNo.Focus();
                    return true;
            }
            return false;
        }

        protected override void RunMrp()
        {
            if (HataliGirs()) return;
            txtOdemeTuru.Focus();

            var tutar = txtSabitTaksit.Value > 0 ? txtSabitTaksit.Value 
                : Math.Round(txtBakiye.Value / txtTaksitSayisi.Value, AnaForm.DonemParametreleri.OdemePlaniKurusKullan ? 2 : 0);

            decimal toplamGirilenTutar = 0;
            for (int i = 0; i < txtTaksitSayisi.Value; i++)
            {
                var taksit = new OdemeBilgileriL
                {
                    Id = 0,
                    TahakkukId = _tahakkukId,
                    OdemeTipi = _odemeTipi,
                    OdemeTuruId = (long)txtOdemeTuru.Id,
                    OdemeTuruAdi = txtOdemeTuru.Text,
                    GirisTarihi = DateTime.Now.Date,
                    Vade = txtIlkTaksitTarihi.DateTime.Date.AddMonths(i),
                    HesabaGecisTarihi = txtIlkTaksitTarihi.DateTime.Date.AddMonths(i),
                    Tutar = i == txtTaksitSayisi.Value - 1 && txtSabitTaksit.Value == 0 ? txtBakiye.Value - toplamGirilenTutar : tutar,
                    BelgeDurumu=BelgeDurumu.Portfoyde,
                    Insert=true
                };

                taksit.TutarYazi = taksit.Tutar.ToString();
                taksit.VadeYazi = taksit.Vade.ToString();
                taksit.Kalan = taksit.Tutar;
                toplamGirilenTutar += taksit.Tutar;

                switch (_odemeTipi)
                {
                    case OdemeTipi.EPos:
                    case OdemeTipi.Ots:
                    case OdemeTipi.Pos:
                        taksit.BankaHesapId = txtBankaHesapAdi.Id;
                        taksit.BankaHesapAdi = txtBankaHesapAdi.Text;
                        taksit.BlokeGunSayisi = _blokeGunSayisi;
                        taksit.HesabaGecisTarihi = taksit.Vade.Date.AddDays(_blokeGunSayisi);
                        break;
                    case OdemeTipi.Senet:
                        taksit.AsilBorclu = txtAsilBorclu.Text;
                        taksit.Ciranta = txtCiranta.Text;
                        break;
                    case OdemeTipi.Cek:
                        taksit.AsilBorclu = txtAsilBorclu.Text;
                        taksit.Ciranta = txtCiranta.Text;
                        taksit.BankaId = txtBanka.Id;
                        taksit.BankaAdi = txtBanka.Text;
                        taksit.BankaSubeId = txtBankaSube.Id;
                        taksit.BankaSubeAdi = txtBankaSube.Text;
                        taksit.HesapNo = txtHesapNo.Text;
                        taksit.BelgeNo = ((int)txtIlkBelgeNo.Value+i).ToString();
                        break;
                }

                _source.Add(taksit);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        protected override void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (sender == txtOdemeTuru)
            {
                //_odemeTipi = txtOdemeTuru.Id == null ? OdemeTipi.Acik : (OdemeTipi)Enum.Parse(typeof(OdemeTipi), txtOdemeTuru.Tag.ToString());
                _odemeTipi = txtOdemeTuru.Id == null ? OdemeTipi.Acik : txtOdemeTuru.Tag.ToString().GetEnum<OdemeTipi>();
                ControlEnableChange(_odemeTipi);
                txtBankaHesapAdi.Id = null;
                txtBankaHesapAdi.Text = null;
            }

            else if (sender == txtBankaHesapAdi)
            {
                _blokeGunSayisi = Convert.ToByte(txtBankaHesapAdi.Tag);
            }

            else if (sender == txtBanka)
            {
                txtBankaSube.Text = null;
                txtBankaSube.Id = null;
            }
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtOdemeTuru)
                    sec.Sec(txtOdemeTuru);
                //else if (sender == txtBanka)
                //    sec.Sec(txtBanka, _odemeTipi);
                else if (sender == txtBanka)
                    sec.Sec(txtBanka);
                else if (sender == txtBankaSube)
                    sec.Sec(txtBankaSube, txtBanka);
                else if (sender == txtBankaHesapAdi)
                    sec.Sec(txtBankaHesapAdi,_odemeTipi);
            }                
        }

        protected override void Control_EnabledChanged(object sender, EventArgs e)
        {
            if (sender != txtBanka) return;
            txtBanka.ControlEnabledChanged(txtBankaSube);
        }

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
            if (DialogResult != DialogResult.Cancel) return;
            if (Messages.HayirSeciliEvetHayir("Taksit Oluşturma Ekranı Kapatılacaktır, Onaylıyor musunuz ?", "Kapatma Onayı") == DialogResult.No)
                e.Cancel = true;
        }
    }
}
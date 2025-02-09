﻿using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraBars;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;

namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    public partial class SubeDonemSecimEditForm : BaseEditForm
    {
        private readonly long _kullaniciId;
        private readonly bool _subeSecimButonunaBasildi;
        private readonly long _seciliGelecekSubeId;
        private readonly long _seciliGelecekDonemId;
        private  bool _girisButonunaBasildi;
        private List<long> _yetkiliOlunanSubelerId;


        public SubeDonemSecimEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            HideItems = new BarItem[] { btnSil, btnYeni,btnKaydet,btnGerial };
            ShowItems = new BarItem[] { btnGiris };
            subeNavigator.Navigator.NavigatableControl = subeGrid;
            donemNavigator.Navigator.NavigatableControl = donemGrid;

            _kullaniciId = (long)prm[0];
            _subeSecimButonunaBasildi = (bool)prm[1];
            _seciliGelecekSubeId = (long)prm[2];
            _seciliGelecekDonemId = (long)prm[3];

            EventsLoad();
        }
        public override void Yukle()
        {
            using (var bll= new KullaniciBirimYetkileriBll())
            {
                var yetkiler = bll.List(x => x.KullaniciId == _kullaniciId).Cast<KullaniciBirimYetkileriL>().ToList();

                _yetkiliOlunanSubelerId = yetkiler.Where(x => x.SubeId > 0).Select(x => x.SubeId.Value).ToList();

                var subeSource = yetkiler.Where(x => x.SubeId > 0).ToList();
                var donemSource = yetkiler.Where(x => x.DonemId > 0).ToList();

                if (subeSource.Count == 0)
                {
                    Messages.HataMesaji("Hiçbir Şubede Yetkilendirilmediğiniz İçin Giriş Yapamazsınız .");
                    Application.ExitThread();
                }
                if (donemSource.Count == 0)
                {
                    Messages.HataMesaji("Hiçbir Dönemde Yetkilendirilmediğiniz İçin Giriş Yapamazsınız .");
                    Application.ExitThread();
                }

                subeGrid.DataSource = subeSource;
                donemGrid.DataSource = donemSource;

                if (!_subeSecimButonunaBasildi) return;
                subeTablo.RowFocus("SubeId", _seciliGelecekSubeId);
                donemTablo.RowFocus("DonemId", _seciliGelecekDonemId);
            }
        }
        public override void Giris()
        {
            var sube = subeTablo.GetRow<KullaniciBirimYetkileriL>();
            var donem = donemTablo.GetRow<KullaniciBirimYetkileriL>();

            using (var bll=new DonemParametreBll())
            {
                var entity = (DonemParametre)bll.Single(x => x.SubeId == sube.SubeId && x.DonemId == donem.DonemId);
                if (entity == null)
                {
                    Messages.HataMesaji("Şube ye Ait Dönem Parametreleri Oluşturulmadığı İçin Giriş Yapılamaz. Lütfen Sistem Yöneticinize Başvurunuz .");
                    return;
                }
                AnaForm.DonemParametreleri = entity;
                AnaForm.YetkiliOlunanSubeler = _yetkiliOlunanSubelerId;
                AnaForm.SubeId = sube.SubeId.Value;
                AnaForm.SubeAdi = sube.SubeAdi;
                AnaForm.DonemId = donem.DonemId.Value;
                AnaForm.DonemAdi = donem.DonemAdi;
            }

            _girisButonunaBasildi = true;
            Close();
        }
        protected override void Control_KeyDown(object sender, KeyEventArgs e)
        {
            base.Control_KeyDown(sender, e);

            if (e.KeyCode != Keys.Enter && e.KeyCode == Keys.Tab && e.KeyCode == Keys.Right && e.KeyCode == Keys.Left) return;

            if (sender == subeGrid)
                donemGrid.Focus();
            else
                subeGrid.Focus();
            
        }
        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
        }
        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.BaseEditForm_FormClosing(sender, e);

            if (_girisButonunaBasildi || _subeSecimButonunaBasildi) return;

            if (Messages.HayirSeciliEvetHayir("Programdan Çıkmak Mı İstiyorsunuz ?", "Çıkış Onay") == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }
    }
}
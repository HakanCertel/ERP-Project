using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using SenfoniYazilim.Erp.Common.Enums;
using System.Security;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SubeForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.DonemForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.KullaniciForms;

namespace SenfoniYazilim.Erp.UI.Yonetim.Forms.GenelForms
{
    public partial class AnaForm : RibbonForm
    {
        private readonly string _server;
        private readonly SecureString _kullaniciAdi;
        private readonly SecureString _serverSifre;
        private readonly  YetkilendirmeTuru _yetkilendirmeTuru;
        private readonly KurumBll _bll;

        public AnaForm(params object[] prm)
        {
            InitializeComponent();

            longNavigator.Navigator.NavigatableControl = tablo.GridControl;
            EventsLoad();
            ButonEnabledDurum();

            _server = prm[0].ToString();
            _kullaniciAdi = (SecureString)prm[1];
            _serverSifre = (SecureString)prm[2];
            _yetkilendirmeTuru = (YetkilendirmeTuru)prm[3];
            _bll = new KurumBll();
        }

        private void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;
            //Tablo Events
            tablo.DoubleClick += Tablo_DoubleClick;
            tablo.KeyDown += Tablo_KeyDown;
            tablo.MouseUp += Tablo_MouseUp;
            tablo.RowCountChanged += Tablo_RowCountChanged;
            //Form Events
            FormClosing += AnaForm_FormClosing;
            Load += AnaForm_Load;
        }

        protected internal void Listele()
        {
            tablo.GridControl.DataSource = _bll.List(null);
        }
        protected virtual void ShowEditForm(long id)
        {
            GeneralFunctions.CreateConnectionString("Senfoni_Erp_Yonetim", _server, _kullaniciAdi, _serverSifre, _yetkilendirmeTuru);
            var result = ShowEditForms<KurumEditForm>.ShowDialogForm(id, _server, _kullaniciAdi, _serverSifre); ;
            if (result <= 0) return;
            Listele();
            tablo.RowFocus("Id", result);
        }
        private void ButonEnabledDurum()
        {
            foreach (BarItem button in ribbonControl.Items)
            {
                if (!(button is BarButtonItem item)) continue;
                if (item != btnYeni)
                    item.Enabled = tablo.DataRowCount > 0;
            }
        }
        private void EntityDelete(BaseEntity entity)
        {
            GeneralFunctions.CreateConnectionString(entity.Kod, _server, _kullaniciAdi, _serverSifre, _yetkilendirmeTuru);
            if (!Functions.GeneralFunctions.DeletDatabase<SenfoniErpYonetimContext>()) return;

            GeneralFunctions.CreateConnectionString("Senfoni_Erp_Yonetim", _server, _kullaniciAdi, _serverSifre, _yetkilendirmeTuru);
            _bll.Delete(entity);
            tablo.DeleteSelectedRows();
            tablo.RowFocus(tablo.FocusedRowHandle);
        }
        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnYeni || e.Item == btnDuzelt)
            {
                if (e.Item == btnYeni)
                    ShowEditForm(-1);
                else if (e.Item == btnDuzelt)
                    ShowEditForm(tablo.GetRowId());
            }
            else
            {
                var entity = tablo.GetRow<Kurum>();
                if (entity == null) return;

                GeneralFunctions.CreateConnectionString(entity.Kod, _server, _kullaniciAdi, _serverSifre, _yetkilendirmeTuru);

                if (e.Item == btnSil)
                    EntityDelete(entity);
                else if (e.Item == btnEmailParametreleri)
                    ShowEditForms<EMailParametreEditForm>.ShowDialogForm();
                else if (e.Item == btnSubeKartlari)
                    ShowListForms<SubeListForm>.ShowDialogListForm();
                else if (e.Item == btnDonemKartlari)
                    ShowListForms<DonemListForm>.ShowDialogListForm();
                else if (e.Item == btnKurumBilgileri)
                    ShowEditForms<KurumBilgileriEditForm>.ShowDialogForm(null,entity.Kod,entity.KurumAdi);
                else if (e.Item == btnRolKartlari)
                    ShowListForms<RolListForm>.ShowDialogListForm();
                else if (e.Item == btnKullaniciKartlari)
                    ShowListForms<KullaniciListForm>.ShowDialogListForm();
                else if (e.Item == btnKullaniciBirimYetkileri)
                    ShowEditForms<KullaniciBirimYetkileriEditForm>.ShowDialogForm();
            }

            Cursor.Current = Cursors.Default;
        }
        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            if (tablo.FocusedRowHandle < 0) return;
            ShowEditForm(tablo.GetRowId());
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            if (tablo.FocusedRowHandle < 0) return;

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ShowEditForm(tablo.GetRowId());
                    break;

                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            e.SagMenuGoster(sagMenu);
        }

        private void Tablo_RowCountChanged(object sender, EventArgs e)
        {
            ButonEnabledDurum();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Messages.HayirSeciliEvetHayir("Programdan Çıkmak İstiyor Musunuz ?", "Çıkış Onay") == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Listele();
            tablo.Focus();
            Cursor.Current = Cursors.Default;
        }
    }
}
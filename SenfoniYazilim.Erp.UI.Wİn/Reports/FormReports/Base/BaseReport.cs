using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.FİltreForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.RaporForms;
using System.IO;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using DevExpress.XtraGrid.Views.Base;
using SenfoniYazilim.Erp.Model.Dto;
using DevExpress.XtraEditors.Controls;
using SenfoniYazilim.Erp.Common.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Reports.FormReports.Base
{
    public partial class BaseReport : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private long _filtreId;
        private long _raporSablonId;
        private RaporBolumTuru _raporBolumTuru = RaporBolumTuru.GenelRaporlar;
        protected KartTuru RaporTuru;
        protected ControlNavigator Navigator;
        protected GridView Tablo;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected MyChekedComboBoxEdit Subeler;
        protected MyChekedComboBoxEdit KayitSekilleri;
        protected MyChekedComboBoxEdit KayitDurumlari;
        protected MyDataLayoutControl DataLayoutControl;

        public BaseReport()
        {
            InitializeComponent();
        }

        protected internal void Yukle()
        {
            DediskenleriDoldur();
            EventLoad();

            Navigator.NavigatableControl = Tablo.GridControl;

            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }

        protected virtual void DediskenleriDoldur() {}

        private void EventLoad()
        {
           foreach(BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            //Table  Events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Control_KeyDown;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.ColumnFilterChanged += Tablo_ColumnFilterChanged;
            Tablo.FilterEditorCreated += Tablo_FilterEditorCreated;
            Tablo.CustomDrawFooterCell += Tablo_CustomDrawFooterCell;
            Tablo.CustomDrawRowFooterCell += Tablo_CustomDrawRowFooterCell;
            Tablo.CustomSummaryCalculate += Tablo_CustomSummaryCalculate;
            Tablo.MasterRowGetRelationCount += Tablo_MasterRowGetRelationCount;
            Tablo.MasterRowGetRelationName += Tablo_MasterRowGetRelationName;
            Tablo.MasterRowGetChildList += Tablo_MasterRowGetChildList;
            //Form Events
            FormClosing += BaseReport_FormClosing;

            void ControlEvents(Control control)
            {
                control.KeyDown += Control_KeyDown;

                if(control is SimpleButton btn)
                    btn.Click += Control_Click;
            }

            foreach (Control ctrl in DataLayoutControl.Controls)
                ControlEvents(ctrl);
        }

        protected void SubeKartlariYukle()
        {
            using (var bll = new SubeBll())
            {
                var entities = bll.List(x => AnaForm.YetkiliOlunanSubeler.Contains(x.Id));

                foreach (SubeL entity in entities)
                {
                    var item = new CheckedListBoxItem
                    {
                        CheckState = entity.Id == AnaForm.SubeId ? CheckState.Checked : CheckState.Unchecked,
                        Description = entity.SubeAdi,
                        Value = entity.Id
                    };

                    Subeler.Properties.Items.Add(item);
                }
            }
        }

        protected void KayitSekliYukle()
        {
            var enums = Enum.GetValues(typeof(KayitSekli));

            foreach (KayitSekli entity in enums)
            {
                var item = new CheckedListBoxItem
                {
                    CheckState=CheckState.Checked,
                    Description=entity.toName(),
                    Value=entity
                };
                KayitSekilleri.Properties.Items.Add(item);
            }
        }
        protected void KayitDurumuYukle()
        {
            var enums = Enum.GetValues(typeof(KayitDurumu));

            foreach (KayitDurumu entity in enums)
            {
                var item = new CheckedListBoxItem
                {
                    CheckState =entity==KayitDurumu.KesinKayit? CheckState.Checked: CheckState.Unchecked,
                    Description = entity.toName(),
                    Value = entity
                };
                KayitDurumlari.Properties.Items.Add(item);
            }
        }
        private void FiltreSec()
        {
            var entity = (Filtre)ShowListForms<FiltreListForm>.ShowDialogListForm(KartTuru.Filtre, _filtreId, RaporTuru, Tablo.GridControl);

            if (entity == null) return;

            _filtreId = entity.Id;

            Tablo.ActiveFilterString = entity.FiltreMetni;
        }
        private void RaporSablonuSec()
        {
            var entity = (Rapor)ShowListForms<RaporListForm>.ShowDialogListForm(KartTuru.Rapor, _raporSablonId, RaporTuru, _raporBolumTuru,SablonDosyasiOlustur());

            if (entity == null) return;

            _raporSablonId = entity.Id;

            using (var bll=new RaporBll())
            {
                var stream = ((Rapor)bll.Single(x=>x.Id==entity.Id)).Dosya.ByteToStream();
                Tablo.RestoreLayoutFromStream(stream);
                Tablo.Focus();

            }
        }
        private byte[] SablonDosyasiOlustur()
        {
            var stream = new MemoryStream();
            Tablo.SaveLayoutToStream(stream);

            return stream.GetBuffer();
        }
        protected virtual void Listele()
        {
            Tablo.ExpandAllGroups();
        }
        protected virtual void ShowEditForm() {}

        protected virtual void BelgeHareketleri() {}

        protected virtual void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnGonder)
            {
                var link = (BarSubItemLink)e.Item.Links[0];//link bir BarItemLink dir fakat bizim gönder butonumuz
                //BarSubItem olduğu için link imizi BarSubItemLink e kast edeceğiz.
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnStandartExcelDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.ExcelStandart, e.Item.Caption, Text);
            else if (e.Item == btnFormatliExcelDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatli, e.Item.Caption, Text);
            else if (e.Item == btnFormatsizExcelDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatsiz, e.Item.Caption, Text);
            else if (e.Item == btnWordDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.WordDosyası, e.Item.Caption);
            else if (e.Item == btnPdfDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.PdfDosyası, e.Item.Caption);
            else if (e.Item == btnTxtDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.TxtDosyası, e.Item.Caption);
            else if (e.Item == btnFiltrele)
                FiltreSec();
            else if (e.Item == btnKolonlar)
            {
                if (Tablo.CustomizationForm == null)
                    Tablo.ShowCustomization();
                else
                    Tablo.HideCustomization();
            }
            //else if (e.Item == btnYazdir)
            //    Yazdir();
            else if (e.Item == btnRaporSablonlari)
            {
                RaporSablonuSec();
            }

            else if (e.Item == btnKartAc)
                ShowEditForm();
            else if (e.Item == btnGruplamaPaneli)
                Tablo.OptionsView.ShowGroupPanel = !Tablo.OptionsView.ShowGroupPanel;
            else if (e.Item == btnTumGruplariGenislet)
                Tablo.ExpandAllGroups();

            else if (e.Item == btnTumGruplariDaralt)
                Tablo.CollapseAllGroups();
            else if (e.Item == btnTumDetaylariGenislet)
                for (int i = 0; i < Tablo.DataRowCount; i++)
                    Tablo.SetMasterRowExpanded(i, true);
            else if (e.Item == btnTumDetaylariDaralt)
                for (int i = 0; i < Tablo.DataRowCount; i++)
                    Tablo.CollapseAllDetails();
            
            else if (e.Item == btnBelgeHareketleri)
                BelgeHareketleri();
            else if (e.Item == btnCikis)
                Close();

            Cursor.Current = DefaultCursor;
        }

        protected virtual void Tablo_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ShowEditForm();
            Cursor.Current = DefaultCursor;
        }
        protected virtual void Control_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.F7:
                    Subeler.Focus();
                    break;
            }
        }
        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            btnKartAc.Enabled = Tablo.DataRowCount > 0;
            btnTumGruplariDaralt.Enabled = Tablo.DataRowCount > 0;
            btnTumGruplariGenislet.Enabled = Tablo.DataRowCount > 0;
            btnTumDetaylariDaralt.Enabled = Tablo.DataRowCount > 0;
            btnTumGruplariGenislet.Enabled = Tablo.DataRowCount > 0;
            btnBelgeHareketleri.Enabled = Tablo.DataRowCount > 0;

            e.SagMenuGoster(sagMenu);
        }
        private void Tablo_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tablo.ActiveFilterString))
                _filtreId = 0;
        }
        private void Tablo_FilterEditorCreated(object sender, FilterControlEventArgs e)
        {
            if (!KartTuru.Filtre.YetkiKontrolu(YetkiTuru.Degistirebilir)) return;
            e.ShowFilterEditor = false;
            ShowEditForms<FiltreEditForm>.ShowDialogForm(KartTuru.Filtre, _filtreId, RaporTuru, Tablo.GridControl);
        }
        private void Tablo_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (!Tablo.OptionsView.ShowFooter) return;
            if (e.Column.Summary.Count > 0 && e.Column.ColumnEdit !=null )
                e.Appearance.TextOptions.HAlignment = e.Column.ColumnEdit.Appearance.HAlignment;
        }
        private void Tablo_CustomDrawRowFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.Summary.Count > 0 && e.Column.ColumnEdit!=null)
                e.Appearance.TextOptions.HAlignment = e.Column.ColumnEdit.Appearance.HAlignment;
        }
        protected virtual void Tablo_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e) {}
        protected virtual void Tablo_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e) {}
        protected virtual void Tablo_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e) {}
        protected virtual void Tablo_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e) {}
        
        private void BaseReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AnaForm.KullaniciParametreleri.RaporlariOnayAlmadanKapat)
                if (Messages.RaporuKapatmaMesaj() != DialogResult.Yes)
                    e.Cancel = true;
        }
        private void Control_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Listele();
            Tablo.Focus();

            Cursor.Current = Cursors.Default;
        }

       
    }
}
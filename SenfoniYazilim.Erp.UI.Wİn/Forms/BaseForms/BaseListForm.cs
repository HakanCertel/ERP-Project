using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.UI.Wİn.Show.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using DevExpress.XtraGrid.Views.Grid;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.FİltreForms;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using System.Collections.Generic;
using SenfoniYazilim.Erp.Common.Message;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms
{
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private long _filtreId;
        private bool _formSablonKayitEdilecek;
        private bool _tabloSablonKayitEdilecek;
        protected IBaseFormShow FormShow;
        protected KartTuru BaseKartTuru;
        protected bool AktifKartlariGoster = true;
        protected bool  IsComfirmed= false;
        protected bool ComfirmModeSwitch;
        protected internal bool IsBaseHareketEntity=false;
        protected IBaseBll Bll;
        protected ControlNavigator Navigator;
        protected internal BarItem[] ShowItems;
        protected internal BarItem[] HideItems;
        protected internal GridView Tablo;
        protected internal bool AktifPasifButonGoster = false;//bu 
        protected internal bool MultiSelect;
        protected internal long? SeciliGelecekId;
        protected internal BaseEntity SelectedEntity;
        protected internal int? SeciliGelecekHareketId;
        protected internal BaseHareketEntity SelectedHareketEntity;
        protected internal IList<long> ListeDisiTutulacakKayitlar;
        protected internal SelectRowFunctions RowSelect;
        protected internal SelectRowFunctionsBaseHareketEntity HareketRowsSelected;
        protected internal bool EklenebilecekEntityVar=false;
        protected internal IList<BaseEntity> SelectedEntities;
        protected internal IList<BaseHareketEntity> HareketSelectedEntities;
        protected internal IList<BaseHareketEntity> SelectedBaseHareketEntities;
        protected internal IList<object> SendEntities;
        protected internal Type TypeofEntity;
        protected internal Type TypeofBll;
        protected internal object bll;
        protected bool TabloLoaded=false;
        protected bool KayitSonrasiFormuKapat = true;
        
        public BaseListForm()
        {
            InitializeComponent();
        }
        private void EventsLoad()
        {            
            //Button Events
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarItem button:
                        button.ItemClick += Button_ItemClick;
                        break;
                }
            }

            //Table  Events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.ColumnWidthChanged += Tablo_ColumnWidthChanged;
            Tablo.ColumnPositionChanged += Tablo_ColumnPositionChanged;
            Tablo.EndSorting += Tablo_EndSorting;
            Tablo.FilterEditorCreated += Tablo_FilterEditorCreated;
            Tablo.ColumnFilterChanged += Tablo_ColumnFilterChanged;
            Tablo.CustomDrawFooterCell += Tablo_CustomDrawFooterCell;
            Tablo.FocusedRowObjectChanged += Tablo_FocusedRowObjectChanged;
            Tablo.RowDeleted += Tablo_RowDeleted;
            Tablo.CellValueChanged += Tablo_CellValueChanged;
            Tablo.FocusedColumnChanged += Tablo_FocusedColumnChanged;
            //Form Events

            Shown += BaseListForm_Shown;
            Load += BaseListForm_Load;
            FormClosing += BaseListForm_FormClosing;
            LocationChanged += BaseListForm_LocationChanged;
            SizeChanged += BaseListForm_SizeChanged;
        }

        protected virtual void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            if (!TabloLoaded) return;
        }

        protected virtual void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!TabloLoaded) return;

            var entity = Tablo.GetRow<IBaseHareketEntity>();

            if (!entity.Insert)
                entity.Update = true;
        }

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
            else if (e.Item == btnIceriVeriAktar)
            {
                var link = (BarSubItemLink)e.Item.Links[0];//link bir BarItemLink dir fakat bizim gönder butonumuz
                //BarSubItem olduğu için link imizi BarSubItemLink e kast edeceğiz.
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnExcelIleVeriAktar)
                VeriAktar();
            else if (e.Item == btnYeni)
            {
                if (!BaseKartTuru.YetkiKontrolu(YetkiTuru.Ekleyebilir)) return;
                ShowEditForm(-1);
            }
            else if (e.Item == btnDuzelt)
            {
                //ShowEditForm((long)Tablo.GetFocusedRowCellValue("Id"));
                ShowEditForm(Tablo.GetRowId());
            }
            else if (e.Item == btnSil)
            {
                if (!BaseKartTuru.YetkiKontrolu(YetkiTuru.Silebilir)) return;
                EntityDelete();
            }
            else if (e.Item == btnSec)
            {
                //yetki kontrolü
                SelectEntity();
            }
            else if (e.Item == btnYenile)
                Listele();
            else if (e.Item == btnFiltrele)
                FiltreSec();
            else if (e.Item == btnKolonlar)
            {
                if (Tablo.CustomizationForm == null)
                    Tablo.ShowCustomization();
                else
                    Tablo.HideCustomization();
            }
            else if (e.Item == btnTahakkukYap)
                TahakkukYap();
            else if (e.Item == btnBagliKarlar)
                BaglıKartAc();
            else if (e.Item == btnParametreler)
                BaglıKartAc();
            else if (e.Item == btnKaydet)
                Kaydet();
            else if (e.Item == btnYazdir)
                Yazdir();
            else if (e.Item == btnBaskiOnizleme)
                BaskiOnizleme();
            else if (e.Item == btnTasarimDegistir)
                Duzelt();
            else if (e.Item == btnCikis)
                Close();
            else if (e.Item == btnTalepBirlestir)
                if (btnTalepBirlestir.Caption == "Talep Birleştir") ItemBirlestir(); else ItemBoz();
            else if (e.Item == btnYoneticiOnayinaGonder)
                SendManagerComfirm();
            else if (e.Item == btnTeklifTopla)
                TeklifTopla();
            else if (e.Item == btnComfirm)
                ChangeStatus(ItemStatus.Comfirmed);
            else if (e.Item == btnCancel)
                ChangeStatus(ItemStatus.Cancel);
            else if (e.Item == btnCloseItem)
                ChangeStatus(ItemStatus.Closed);
            else if (e.Item == btnActive)
                ChangeStatus(ItemStatus.Active);
            else if (e.Item == btnTransfer)
                PerformProccess();
            else if (e.Item == btnTransferDemand)
                PerformProccess();
            else if (e.Item == btnChangeBaseStatus)
                SelectedEntityActiveOrPasive();
            else if (e.Item == btnCancelManagerComfirm)
                CancelManagerComfirm();
            else if (e.Item == btnDetail)
                DetailList();
            else if (e.Item == btnCreateOrder)
                CreateOrder();
            else if (e.Item == btnCreatePurchaseDemand)
                CreatePurchaseDemand();
            else if (e.Item == btnProductionDeman)
                ProductionDemand();
            else if (e.Item == btnCreateCrp)
                SendToCrp();
            else if (e.Item == btnAktifPasifKartlar)
            {
                SituationSwich(ComfirmModeSwitch);
                //AktifKartlariGoster = !AktifKartlariGoster;
                //FormCaptionAyarla(ComfirmModeSwitch);
            }
            else if (e.Item == btnBelgeHareketleri)
                BelgeHareketleri();
            else if (e.Item == btnUretimSonuKaydi)
            {
                if (UretimSonuKaydi())
                {
                    TabloLoaded = false;
                    Listele();
                    TabloLoaded = true;
                }
            }
                
            Cursor.Current = DefaultCursor;
        }


        protected virtual void Tablo_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IslemTuruSec();
            Cursor.Current = DefaultCursor;
        }
        protected virtual void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    IslemTuruSec();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        protected virtual void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            e.SagMenuGoster(sagMenu);
        }

        private void Tablo_ColumnWidthChanged(object sender, ColumnEventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void Tablo_ColumnPositionChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void Tablo_EndSorting(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void Tablo_FilterEditorCreated(object sender, FilterControlEventArgs e)
        {
            if (!KartTuru.Filtre.YetkiKontrolu(YetkiTuru.Degistirebilir)) return;
            e.ShowFilterEditor = false;
            ShowEditForms<FiltreEditForm>.ShowDialogForm(KartTuru.Filtre, _filtreId, BaseKartTuru, Tablo.GridControl);
        }

        private void Tablo_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tablo.ActiveFilterString))
                _filtreId = 0;
        }

        private void Tablo_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (!Tablo.OptionsView.ShowFooter) return;
            if (e.Column.Summary.Count > 0)
                e.Appearance.TextOptions.HAlignment = e.Column.ColumnEdit.Appearance.HAlignment;
        }

        protected virtual void Tablo_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            SutunGizleGoster();
        }

        protected virtual void Tablo_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            SutunGizleGoster();
        }

        private void BaseListForm_SizeChanged(object sender, EventArgs e)
        {
            if(!IsMdiChild)
                _formSablonKayitEdilecek = true;
        }

        private void BaseListForm_LocationChanged(object sender, EventArgs e)
        {
            if(!IsMdiChild)
                _formSablonKayitEdilecek = true;
        }

        protected virtual void BaseListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }

        private void BaseListForm_Load(object sender, EventArgs e)
        {
            SablonYukle();
            if(!IsMdiChild)
                HideItems = new BarItem[] { btnSil, btnChangeBaseStatus, btnActive, btnCancel, btnCloseItem
                                            ,btnIceriVeriAktar };
            HideItems = new BarItem[] { btnSil,btnChangeBaseStatus };

        }

        private void BaseListForm_Shown(object sender, EventArgs e)
        {
            Tablo.Focus();
            ButonGizleGoster();
            SutunGizleGoster();

            if (IsMdiChild || SeciliGelecekId == null) return;//!SeciliGelecekId.HasValue
            Tablo.RowFocus("Id",SeciliGelecekId);
        }

        protected virtual void SutunGizleGoster(){}

        protected virtual void DegiskenleriDoldur() { }

        protected virtual void Listele() { }

        protected virtual  void DetailList(){}

        protected virtual void CreateOrder() { }

        protected virtual void CreatePurchaseDemand() { }

        protected virtual void PerformProccess(){}

        protected virtual void TahakkukYap() { }

        protected virtual void BelgeHareketleri() { }

        protected virtual void Duzelt() { }

        protected virtual void BaglıKartAc() { }


        protected virtual void VeriAktar() { }

        protected virtual bool UretimSonuKaydi() { return false; }

        protected virtual bool ItemBirlestir() { return false; }

        protected virtual bool ItemBoz() { return false; }

        protected virtual void SendManagerComfirm(){}

        protected virtual void TeklifTopla(){ }

        protected virtual void BaskiOnizleme() { }

        protected virtual void CancelManagerComfirm() { }

        protected virtual bool Kaydet() { return true; }

        protected virtual void ProductionDemand(){}

        protected virtual void SendToCrp(){}

        protected virtual void ChangeStatus(ItemStatus status)
        {
            var entities=HareketRowsSelected?.GetSelectedRows().Cast<BaseHareketEntity>().ToList();

            if (entities.Count == 0) return;
            switch (status)
            {
                case ItemStatus.Active:
                        entities.ForEach(x =>{x.IsActive = !x.IsActive;});
                    break;
                case ItemStatus.Cancel:
                    entities.ForEach(x => { x.IsCancel = !x.IsCancel; });
                    break;
                case ItemStatus.Closed:
                    entities.ForEach(x => { x.IsClosed = !x.IsClosed; });
                    break;
                case ItemStatus.Comfirmed:
                    entities.ForEach(x => { x.IsComfirmed = !x.IsComfirmed; });
                    break;
            }
            if (((IBaseHareketGenelBll)Bll).Update(entities))
            {
                Messages.BilgiMesaji("İşlem Başarılı");
                HareketRowsSelected.ClearSelection();
                Listele();
            }
            else
                Messages.BilgiMesaji("İşlem Başarısız! Tekrar Deneyiniz.");
        }

        protected virtual bool SelectedEntityActiveOrPasive()
        {
            var entity = Tablo.GetRow<BaseEntityDurum>();
            if (entity == null) return false;
            entity.Durum = !entity.Durum;
            var result=((IBaseGenelBll)Bll).Update(entity);
            Tablo.DeleteSelectedRows();
            Tablo.RowFocus(Tablo.FocusedRowHandle);
            return result;
        }

        protected virtual void Yazdir()
        {
            TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, AnaForm.SubeAdi);
        }

        protected internal void Yukle()
        {
            DegiskenleriDoldur();
            EventsLoad();

            Tablo.OptionsSelection.MultiSelect = MultiSelect;

            Navigator.NavigatableControl = Tablo.GridControl;//bu bize oluşturmuş olduğumuz Navigator un şu gridcontrol ün navigator usun demektir..
            Navigator.TextLocation = NavigatorButtonsTextLocation.Begin;
            Navigator.TextStringFormat = "Kayıtlar( {0} / {1} ) ";
            
            Cursor.Current = Cursors.WaitCursor;
            Listele();
            Cursor.Current = DefaultCursor;

            TabloLoaded = true;

            Tablo.Appearance.ViewCaption.ForeColor = Color.FromArgb(AnaForm.KullaniciParametreleri.TabloViewCaptionForeColor);
            Tablo.Appearance.HeaderPanel.ForeColor = Color.FromArgb(AnaForm.KullaniciParametreleri.TabloColumnHeaderForeColor);
        }

        protected virtual void ShowEditForm(long id)
        {
            var result = FormShow.ShowDialogForm(BaseKartTuru, id);
            ShowEditFormDefault(result);
        }
        private void SituationSwich(bool _switch)
        {
            if (_switch)
                IsComfirmed = !IsComfirmed;
            else
                AktifKartlariGoster = !AktifKartlariGoster;
            FormCaptionAyarla(_switch);
        }
        protected void ShowEditFormDefault(long id)
        {
            if (id < 0) return;
            AktifKartlariGoster = true;
            FormCaptionAyarla();
            Tablo.RowFocus("Id", id);
        }
        protected virtual void SelectEntity()
        {
            if (MultiSelect)
            {
                if (RowSelect?.SelectedRowCount == 0)
                {
                    Messages.KartSecmemeUyariMesaji();
                    return;
                }
                if (!IsBaseHareketEntity)
                {
                    SelectedEntities = new List<BaseEntity>();
                    SelectedEntities = RowSelect.GetSelectedRows();
                }
                else
                {
                    HareketSelectedEntities = new List<BaseHareketEntity>();
                    HareketSelectedEntities = HareketRowsSelected.GetSelectedRows();
                }
                    
            }
            else if(!IsBaseHareketEntity)
                SelectedEntity =Tablo.GetRow<BaseEntity>();
            else if(IsBaseHareketEntity)
                SelectedHareketEntity = Tablo.GetRow<BaseHareketEntity>();

            DialogResult = DialogResult.OK;
            Close();
        }

        protected virtual void EntityDelete()
        {
            var entity = Tablo.GetRow<BaseEntity>();
            if (entity == null) return;
            if (!((IBaseCommonBll)Bll).Delete(entity)) return;
            Tablo.DeleteSelectedRows();
            Tablo.RowFocus(Tablo.FocusedRowHandle);
        }

        protected virtual void ButonGizleGoster()
        {
            btnSec.Visibility = AktifPasifButonGoster ? BarItemVisibility.Never : IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnter.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            btnAktifPasifKartlar.Visibility = AktifPasifButonGoster ? BarItemVisibility.Always:!IsMdiChild?BarItemVisibility.Never:BarItemVisibility.Always;
            btnChangeBaseStatus.Visibility = !IsBaseHareketEntity ? BarItemVisibility.Always : BarItemVisibility.Never; ;

            btnActive.Visibility = IsBaseHareketEntity ? BarItemVisibility.Always : BarItemVisibility.Never; ;
            btnCancel.Visibility = IsBaseHareketEntity ? BarItemVisibility.Always : BarItemVisibility.Never; ;
            btnCloseItem.Visibility = IsBaseHareketEntity ? BarItemVisibility.Always : BarItemVisibility.Never; ;
            btnActive.Visibility = IsBaseHareketEntity ? BarItemVisibility.Always : BarItemVisibility.Never; ;

            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);// burada ShowItems? ifadesi ShowItem dizisi boşmu
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);                                                                //değilse devamındaki işlei yap demek..
        }

        private void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
                Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);
            if (_tabloSablonKayitEdilecek)
                Tablo.TabloSablonKaydet(IsMdiChild ? Name + " Tablosu" : Name + " TablosuMDI");
        }

        private void SablonYukle()
        {
            if (IsMdiChild)
                Tablo.TabloSablonYukle(Name + " Tablosu");
            else
            {
                Name.FormSablonYukle(this);
                Tablo.TabloSablonYukle(Name + " TablosuMDI");
            }
        }

        private void FiltreSec()
        {
            if (!KartTuru.Filtre.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

            var entity =(Filtre) ShowListForms<FiltreListForm>.ShowDialogListForm(KartTuru.Filtre, _filtreId, BaseKartTuru, Tablo.GridControl);

            if (entity == null) return;

            _filtreId = entity.Id;

            Tablo.ActiveFilterString = entity.FiltreMetni;
        }

        protected virtual void FormCaptionAyarla(bool _switch=false)
        {
            if (btnAktifPasifKartlar == null)
            {
                Listele();
                return;
            }
            if (!_switch)
            {
                if (AktifKartlariGoster)
                {
                    btnAktifPasifKartlar.Caption = "Pasif Kartlar";
                    btnChangeBaseStatus.Caption = "Pasif";
                    Tablo.ViewCaption = Text;
                }
                else
                {
                    btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                    btnChangeBaseStatus.Caption = "Aktif";
                    Tablo.ViewCaption = Text + "- Pasif Kartlar";
                }
            }
            else
            {
                if (IsComfirmed)
                {
                    btnAktifPasifKartlar.Caption = "Onaysız Kartlar";
                    btnChangeBaseStatus.Caption = "Pasif";
                    Tablo.ViewCaption = Text;
                }
                else
                {
                    btnAktifPasifKartlar.Caption = "Onaylı Kartlar";
                    btnChangeBaseStatus.Caption = "Aktif";
                    Tablo.ViewCaption = Text + "- Onaysız Kartlar";
                }
                btnSec.Caption = !IsComfirmed ? "Onayla" : "Onayı Kaldır";

            }

            Listele();
        }

        protected virtual void IslemTuruSec()
        {
            if (!IsMdiChild)
            {
                //güncellenecek
                SelectEntity();
            }
            else
                btnDuzelt.PerformClick();
        }

    }
}
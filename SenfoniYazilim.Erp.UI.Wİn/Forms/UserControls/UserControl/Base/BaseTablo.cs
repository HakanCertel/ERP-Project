using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.UI.Wİn.Interfaces;
using System.Linq;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using SenfoniYazilim.Erp.Model.Entities;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base
{
    public partial class BaseTablo : XtraUserControl
    {
        protected bool _isLoaded;
        protected internal bool TabloSablonKaydedilecek;
        protected internal bool TableValueChanged;
        protected internal GridView Tablo;
        protected internal BaseEditForm OwnerForm;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected IBaseBll Bll;
        protected IList<long> ListeDisiTutulacakKayitlar;
        protected  SelectRowFunctionsBaseHareketEntity HareketRowsSelected;

        public BaseTablo()
        {
            InitializeComponent();
        }
        
        protected void EventsLoad()
        {            
            //Button Events
            foreach (BarItem button in barManager.Items)
                button.ItemClick += Button_ItemClick;
            
            foreach (GridColumn column in Tablo.Columns)
            {
                if (column.ColumnEdit == null) continue;
                var type = column.ColumnEdit.GetType();

                if (type == typeof(RepositoryItemImageComboBox))
                {
                    ((RepositoryItemComboBox)column.ColumnEdit).SelectedValueChanged += ImageComboBox_SelectedValueChanged;
                }
                if (type==typeof(RepositoryItemCheckEdit))
                    ((RepositoryItemCheckEdit)column.ColumnEdit).CheckedChanged += CheckEdit_CheckedChanged;
                if (type == typeof(RepositoryItemComboBox))
                    ((RepositoryItemComboBox)column.ColumnEdit).SelectedValueChanged += ComboBox_SelectedValueChanged;
                if (type == typeof(RepositoryItemLookUpEdit))
                    ((RepositoryItemLookUpEdit)column.ColumnEdit).EditValueChanged += LookUpEdit_EditValueChanged; ;
            }
            //Navigator events
            insUpNavigator.Navigator.ButtonClick += Navigator_ButtonClick;

            //Tablo Events
            Tablo.CellValueChanged += Tablo_CellValueChanged;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.GotFocus += Tablo_GotFocus;
            Tablo.LostFocus += Tablo_LostFocus;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.FocusedColumnChanged += Tablo_FocusedColumnChanged;
            Tablo.ColumnPositionChanged += Tablo_SablonChanged;
            Tablo.ColumnWidthChanged+= Tablo_SablonChanged;
            Tablo.EndSorting+= Tablo_SablonChanged;
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.FocusedRowObjectChanged += Tablo_FocusedRowObjectChanged;
            Tablo.RowCountChanged += Tablo_RowCountChanged;
            Tablo.RowStyle += Tablo_RowStyle;
            Tablo.FocusedRowChanged += Tablo_FocusedRowChanged;
            
            void ControlEvents(Control control)
            {
                switch (control)
                {
                    case MySimpleButton edt:
                        edt.Click += SimpleButton_Click;
                        break;
                }
            }
            if (panelButtons == null) return;
            foreach (Control ctrl in panelButtons.Controls)
                ControlEvents(ctrl);
            

        }

        protected virtual void AsagiTasi(){}

        protected virtual void YukariTasi(){}

        protected virtual void Tablo_RowStyle(object sender, RowStyleEventArgs e) { }

        protected void ButtonEnabledDurum(bool durum)
        {
            TableValueChanged = durum;
            OwnerForm.ButonEnabledDurumu();
        }

        protected internal virtual void Yukle()
        {
            _isLoaded = true;
            TableValueChanged = false;
            OwnerForm.ButonEnabledDurumu();
            insUpNavigator.Navigator.NavigatableControl = Tablo.GridControl;
            insUpNavigator.Navigator.TextLocation = NavigatorButtonsTextLocation.Begin;
            insUpNavigator.Navigator.TextStringFormat = "Kayıt ( {0} / {1})";
            insUpNavigator.Navigator.Appearance.ForeColor = SystemColors.HotTrack;
            SablonYukle();
            Listele();
            ButonGizleGoster();
            Tablo_LostFocus(Tablo, EventArgs.Empty);
        }

        protected internal virtual bool Kaydet()
        {
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            var source = Tablo.DataController.ListSource;

            var insert = source.Cast<IBaseHareketEntity>().Where(x => x.Insert && !x.Delete).Cast<BaseHareketEntity>().ToList();
            var update = source.Cast<BaseHareketEntity>().Where(x =>((IBaseHareketEntity) x).Update && !((IBaseHareketEntity)x).Delete).ToList();
            var delete = source.Cast<IBaseHareketEntity>().Where(x => x.Delete && !x.Insert).Cast<BaseHareketEntity>().ToList();

            if (insert.Any())
                if (!((IBaseHareketGenelBll)Bll).Insert(insert))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Eklenemedi");
                    return false;
                }

            if (update.Any())
                if (!((IBaseHareketGenelBll)Bll).Update(update))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Güncellenemedi");
                    return false;
                }
            if (delete.Any())
                if (!((IBaseHareketGenelBll)Bll).Delete(delete))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Silinemedi");
                    return false;
                }
            ButtonEnabledDurum(false);

            return true;
        }

        protected internal virtual void Listele() { }

        protected internal virtual bool HatalıGiriş() { return false; }

        protected virtual void HareketEkle() { }

        protected internal virtual bool TopluHareketSil() { return false; }

        protected internal virtual void AddExternalRow() { }

        protected virtual void HareketSil()
        {
            if (Tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("İşlem Satırı") != DialogResult.Yes) return;

            var entity = Tablo.GetRow<IBaseHareketEntity>();
            entity.Delete = true;
            Tablo.RefreshDataSource();
            ButtonEnabledDurum(true);
        }

        protected virtual void OpenEntity() { }

        protected internal virtual void SutunGizleGoster() { }

        protected internal virtual IList<BaseHareketEntity> TranferItem() { return null; }

        protected internal virtual bool InsertStockMoving() { return false; }

        protected virtual void RowCellAllowEdit() { }

        protected virtual void IptalEt() { }

        protected virtual void IptalGeriAl() { }

        protected virtual void TumunuSec() { }

        protected virtual void TumSecimleriKaldir() { }

        protected virtual void BelgeHareketleri() { }

        protected virtual void FiltreTemizle(){}

        protected virtual void Filtrele(){}

        protected virtual void Bol() { }

        protected virtual void Birlestir() { }

        protected virtual void CopyValueToDownCells() { }

        protected internal void SablonKaydet()
        {
            Tablo.TabloSablonKaydet(Tablo.ViewCaption);
        }

        protected internal void SablonYukle()
        {
            Tablo.TabloSablonYukle(Tablo.ViewCaption);
        }

        private void ButonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);// burada ShowItems? ifadesi ShowItem dizisi boşmu
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);                                                                //değilse devamındaki işlei yap demek..
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnHareketEkle)
                HareketEkle();
            else if (e.Item == btnHareketSil)
                HareketSil();
            else if (e.Item == btnKartDuzenle)
                OpenEntity();
            else if (e.Item == btnIptalEt)
                IptalEt();
            else if (e.Item == btnIptalGeriAl)
                IptalGeriAl();
            else if(e.Item==btnBelgeHareketleri)
                BelgeHareketleri();
            else if (e.Item == btnTumunuSec)
                TumunuSec();
            else if (e.Item == btnTumSecimleriKaldir)
                TumSecimleriKaldir();
            else if (e.Item == btnMalzemeIhtiyacBirlestir)
                Birlestir();
            else if (e.Item == btnMalzemeIhtiyacBol)
                Bol();
            Cursor.Current = DefaultCursor;
        }

        private void Navigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button == insUpNavigator.Navigator.Buttons.Append)
                HareketEkle();
            else if (e.Button == insUpNavigator.Navigator.Buttons.Remove)
                HareketSil();

            if (e.Button == insUpNavigator.Navigator.Buttons.Append || e.Button == insUpNavigator.Navigator.Buttons.Remove)
                e.Handled = true;
        }

        protected virtual void ComboBox_SelectedValueChanged(object sender, EventArgs e){}

        protected virtual void ImageComboBox_SelectedValueChanged(object sender, EventArgs e){}

        protected virtual void LookUpEdit_EditValueChanged(object sender, EventArgs e) { }

        protected virtual void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isLoaded) return;
            var entity = Tablo.GetRow<IBaseHareketEntity>();

            if (entity == null) return;

            if (!entity.Insert)
                entity.Update = true;

            ButtonEnabledDurum(true);
        }

        private void SimpleButton_Click(object sender, EventArgs e)
        {
            MySimpleButton btn = sender as MySimpleButton;
            if (btn == btnAsagiTasi)
                AsagiTasi();
            else if (btn == btnYukariTasi)
                YukariTasi();
        }

        protected virtual void Tablo_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!_isLoaded) return;

            var entity = Tablo.GetRow<IBaseHareketEntity>();
            if (entity == null) return;
            if (!entity.Insert)
                entity.Update = true;
            ButtonEnabledDurum(true);

            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }

        protected virtual void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            if (popupMenu == null) return;
            if (e.Button != MouseButtons.Right) return;

            btnHareketSil.Enabled = Tablo.RowCount > 0;
            btnKartDuzenle.Enabled = Tablo.RowCount > 0;
            btnHareketEkle.Enabled = Tablo.RowCount > 0;
            btnIptalEt.Enabled = Tablo.RowCount > 0;
            btnIptalGeriAl.Enabled = Tablo.RowCount > 0;

            e.SagMenuGoster(popupMenu);
        }

        private void Tablo_LostFocus(object sender, EventArgs e)
        {
            OwnerForm.statusBarKısaYol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKısaYolAciklama.Visibility = BarItemVisibility.Never;            
        }

        private void Tablo_GotFocus(object sender, EventArgs e)
        {
            OwnerForm.statusBarKısaYol.Visibility = BarItemVisibility.Always;
            OwnerForm.statusBarKısaYolAciklama.Visibility = BarItemVisibility.Always;

            OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarAciklama;
            OwnerForm.statusBarKısaYol.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYol;
            OwnerForm.statusBarKısaYolAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYolAciklama;
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (Tablo.IsEditorFocused)/*Burada IsEditorFocused property si ile, eğer biz bir tabloda 
                        edit edilebilir bir kolona tıkladıysak bu değeer true olacaktır ve edit edilebilir kolon
                        dan çıkmadan Escapae yapıldıldıüında üzerinde çalışıyor olduğumuz edit form dan çıkılamayacaktır
                        bu yüzden önce edit edilebilit kolondan çıkmamız gerekir*/
                        insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.CancelEdit);
                    else
                        OwnerForm.Close();
                    break;
                case Keys.Tab:
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
                    break;
                case Keys.Insert when e.Shift:
                    HareketEkle();
                    break;
                case Keys.S when e.Shift:
                    CopyValueToDownCells();
                    break;
                case Keys.Delete when e.Modifiers == Keys.Shift: /*e.Shift: burada when den sonra direkt
                    e.Shift yazmamamızın sebebi SelectRepositoryFunnction sınıfında Tablolar üzerindeki 
                    button edit lere tıklandığında Key_Down olayında benzer bir yapı tanımlandığı için
                    çakışma olacağı için bu çakışmayı önlemek adına e.Modifiers==Keys.Shift ifadesi 
                    kullanılmıştır. böylece tabloya focus lanıldığında sadece Shift+Delete yapılaınca row 
                    silinecek Ctrl+Shift+Delete yapıldığında ise seçili olan kolonun içeriği silinecektir.*/
                    HareketSil();
                    break;
                case Keys.F3:
                    OpenEntity();
                    break;
                case Keys.T when e.Control:
                    IptalEt();
                    break;
                case Keys.R when e.Control:
                    IptalGeriAl();
                    break;
                case Keys.F6:
                    BelgeHareketleri();
                    break;
                case Keys.A when e.Control :
                    FiltreTemizle();
                    break;
    
            }
        }

        protected virtual void Tablo_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            if (OwnerForm == null) return;/*bu kontrolü ekleme sebebimiz, user control olarak oluşturulmuş
            olan bir tabloyu bir edit forma eklemeye çalıştığımızda bu olay tetikleneceği ve OwnerForm
            umuz henüz null olacağı için hata verecektir bu hatayı önlemek için null kontrolü yapılarak 
            null olmaı durumunda bu event i atlamış olacağız ve hata oluşmayacaktır..*/

            OwnerForm.statusBarKısaYol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKısaYolAciklama.Visibility = BarItemVisibility.Never;
            if (!e.FocusedColumn.OptionsColumn.AllowEdit)
                Tablo_GotFocus(sender, null);
            else if(((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisaYol!=null)
            {
                OwnerForm.statusBarKısaYol.Visibility = BarItemVisibility.Always;
                OwnerForm.statusBarKısaYolAciklama.Visibility = BarItemVisibility.Always;

                OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama;
                OwnerForm.statusBarKısaYol.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisaYol;
                OwnerForm.statusBarKısaYolAciklama.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisaYolAciklama;
            }
            else if(((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama!=null)
                OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama;
        }

        protected virtual void Tablo_SablonChanged(object sender, EventArgs e)
        {
            //_TabloSablonKaydedilecek = true;
            SablonKaydet();
        }

        protected virtual void Tablo_DoubleClick(object sender, EventArgs e)
        {
            OpenEntity();
        }

        protected virtual void Tablo_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            /*bir tabloda row ların değişimi ile ilgili tetiklenen iki event vardır, biri içinde olduğumuz ,
             diğeri ise rowchanged event idir. rowchanged satır her değiştiğinde tetikleneceği için bunu kullanmadık
             kullanmış olduğumuz event satırdaki veri değiştiğinde tetiklenecektir...*/
            SutunGizleGoster();
            RowCellAllowEdit();
        }

        protected virtual void Tablo_RowCountChanged(object sender, EventArgs e){}

        protected virtual void Tablo_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) { }

    }
}

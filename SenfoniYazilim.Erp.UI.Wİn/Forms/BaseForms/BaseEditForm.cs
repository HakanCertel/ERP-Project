using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Common.Message;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid;
using SenfoniYazilim.Erp.UI.Wİn.Interfaces;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraGrid.Views.Base;
using System.Collections.Generic;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraVerticalGrid;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using DevExpress.XtraSplashScreen;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.Model.Entities;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms
{
    public partial class BaseEditForm :RibbonForm
    {
        public delegate void LoadCmmpletedEventHandler();
        public event LoadCmmpletedEventHandler LoadCompleted;

        private bool _formSablonKayitEdilecek;
        protected bool _tabloSablonKayitEdilecek;
        //BaseEditForm dan inherite olan formlar BaseEditForm a controlleri DataLayoutControl ile gönderiyor..önce datalayout içindeki
        //kontrolleri dolaşıp oluşturmuş olduğumuz event leri atamamız lazım..
        protected MyDataLayoutControl DataLayoutControl;
        protected MyDataLayoutControl[] DataLayoutControls;
        protected IBaseBll Bll;
        protected KartTuru BaseKartTuru;
        protected internal KartTuru DataSourceCardType=KartTuru.Stok;
        protected internal BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;
        protected bool IsLoaded;
        protected bool KayitSonrasiFormuKapat = true;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected internal IList<BaseHareketEntity> SelectedEntities;
        protected internal IslemTuru BaseIslemTuru;
        protected internal long Id;
        protected internal int SelectedItemId;//Edit formda eğer bir tablo varsa tablodaki ilgili kalemi seçili getirmek için kullanılacak
        protected internal bool RefreshYapilacak;
        protected internal IList<VardiyaBilgileriLastVersion> VardiyaBilgileri;
        protected bool FarkliSubeIslemi;

        public BaseEditForm()
        {
            InitializeComponent();
        }

        protected void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;
            //Form Events
            LocationChanged += BaseEditForm_LocationChanged;
            SizeChanged += BaseEditForm_SizeChanged;
            Load += BaseEditForm_Load;
            FormClosing += BaseEditForm_FormClosing;
            Shown += BaseEditForm_Shown;
               
            
            void ControlEvents(Control control)
            {
                control.KeyDown += Control_KeyDown;
                control.GotFocus += Control_GotFocus;
                control.Enter += Control_Enter;

                switch (control)
                {
                    case MyToogleSwitch tgl:
                        tgl.EditValueChanged += Control_EditValueChanged;
                        break;
                    case FilterControl edt:
                        edt.FilterChanged += Control_EditValueChanged;
                        break;
                    case ComboBoxEdit edt:
                        edt.EditValueChanged+= Control_EditValueChanged;
                        edt.SelectedValueChanged += Control_SelectedValueChanged;
                        break;
                    case MyLookUpEdit edt:
                        edt.EditValueChanged += Control_EditValueChanged;
                        break;
                    case MyButtonEdit edt:
                        edt.IdChanged += Control_IdChanged;
                        edt.EnabledChanged += Control_EnabledChanged;
                        edt.ButtonClick += Control_ButtonClick;
                        edt.DoubleClick += Control_DoubleClick;
                        break;
                    case MySimpleButton edt:
                        edt.Click += Control_SimpleButtonClick;    
                        break;
                    case MyCheckEdit edt:
                        edt.CheckedChanged += Control_EditValueChanged;
                        break;
                    // burada baseedit mybuttonedit den sonra tanımlanmasının nedeni baseedit bütün kontrollerin kök sınıfıdır, bu yüzden 
                    //edit formlarımızıda üç tip kontrol kullandık ve bir event gerçekleşeceği zaman önce bu bir buttonedit mi,değilse
                    //hangi kontrol olursa olsun her kontrolü kapsayan bir even bağlanır kontrollere ve bu event gerçekleşir..
                    case BaseEdit edt:
                        edt.EditValueChanged += Control_EditValueChanged;
                        break;
                    case TabPane tab:
                        tab.SelectedPageChanged += Control_SelectedPageChanged;
                        tab.SelectedPageChanging += Control_SelectedPageChanging;
                        break;
                    case PropertyGridControl pGrd:
                        pGrd.CellValueChanged += Control_CellValueChanged;
                        pGrd.FocusedRowChanged += Control_FocusedRowChanged;
                        break;
                    case MyGridControl grd:
                        grd.GotFocus+= Control_GotFocus; 
                        break;
                    
                }
            }

            if (DataLayoutControls == null)
            {
                if (DataLayoutControl == null) return;
                foreach (Control ctrl in DataLayoutControl.Controls)
                    ControlEvents(ctrl);
            }
            else
                foreach (var layout in DataLayoutControls)
                    foreach (Control ctrl in layout.Controls)
                        ControlEvents(ctrl);
        }

   

        private void ButonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);// burada ShowItems? ifadesi ShowItem dizisi boşmu
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);                                                                //değilse devamındaki işlei yap demek..
        }
        
        private void GeriAl()
        {
            if (Messages.EvetSeciliEvetHayir("Yapılan Değişiklikler Geri Alınacaktır, Onaylıyor Musunuz", "Geri Al Onay") != DialogResult.Yes) return;
            if (BaseIslemTuru == IslemTuru.EntityUpdate)
                Yukle();
            else
                Close();

        }

        protected virtual bool Kaydet(bool kapanis)
        {
            bool KayitIslemi()
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (BaseIslemTuru)
                {
                    case IslemTuru.EntityInsert:
                        if (EntityInsert())
                            return KayitSonrasiIslemler();
                        break;
                    case IslemTuru.EntityUpdate:
                        if (EntityUpdate())
                            return KayitSonrasiIslemler();
                        break;

                }

                bool KayitSonrasiIslemler()
                {
                    OldEntity = CurrentEntity;
                    RefreshYapilacak = true;//bu değere true atanır çünki bir kaıt işlemi yapılmıştır artık ve kayıt işleminden sonra
                    //formumuzdaki verileri gidip veritabanımızdan tekrar çekilip formumuz güncellenecektir..
                    ButonEnabledDurumu();

                    if (KayitSonrasiFormuKapat)
                        Close();
                    else
                        BaseIslemTuru = BaseIslemTuru == IslemTuru.EntityInsert ? IslemTuru.EntityUpdate : BaseIslemTuru;
                    return true;

                }
                return false;
            }

            var result = kapanis ? Messages.KapanisMesaj() : Messages.KayitMesaj();

            switch (result)
            {
                case DialogResult.Yes:
                    return KayitIslemi();
                case DialogResult.No:
                    if (kapanis)
                        btnKaydet.Enabled = false;
                    return true;
                case DialogResult.Cancel:
                    return false;
            }
            return false;
        }

        private void FarkliKaydet()
        {
            if (Messages.EvetSeciliEvetHayir("Bu Filtre Referans Alınarak Yeni Bir Kayıt Oluşturulacaktır. Onaylıyor Musunuz ?", "Kayıt Onay") != DialogResult.Yes) return;

            BaseIslemTuru = IslemTuru.EntityInsert;
            Yukle();
            if (Kaydet(true))
                Close();
        }

        protected virtual bool EntityInsert()
        {
            return ((IBaseGenelBll)Bll).Insert(CurrentEntity);
        }

        protected virtual bool EntityUpdate()
        {
            return ((IBaseGenelBll)Bll).Update(OldEntity, CurrentEntity);
        }

        protected virtual void EntityDelete()
        {
            if (!((IBaseCommonBll)Bll).Delete(OldEntity)) return;
            RefreshYapilacak = true;
            Close();
        }

        protected virtual void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
                Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);
        }

        protected virtual void SablonYukle()
        {
            Name.FormSablonYukle(this);
        }

        protected virtual void EnabledIsFalesOrTrue(bool enabled)
        {
            if (DataLayoutControls == null)
            {
                if (DataLayoutControl == null) return;
                foreach (Control ctrl in DataLayoutControl.Controls)
                {
                    switch (ctrl)
                    {
                        case BaseTablo tablo:
                            tablo.Tablo.OptionsBehavior.Editable = enabled;
                            tablo.insUpNavigator.Navigator.Buttons.Append.Enabled = enabled;
                            tablo.insUpNavigator.Navigator.Buttons.Remove.Enabled = enabled;
                            break;
                        default:
                            ctrl.Enabled = enabled;
                            break;
                    }
                }

            }
            //else
            //    foreach (var layout in DataLayoutControls)
            //        foreach (Control ctrl in layout.Controls)
        }
        protected virtual void ChangeStatus(ItemStatus status,GridView tablo)
        {
            var list = tablo.DataController.ListSource;
            if (list == null) return;
            var entities=list.Cast<BaseHareketEntity>().ToList();

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
        }
        protected virtual void RunMrp() { }

        protected virtual void FiltreUygula() { }

        protected virtual void BaskiOnIzlem() { }

        protected virtual void SifreSifirla() { }

        protected virtual void Yazdir() { }

        protected virtual void SecimYap(object sender) { }

        protected virtual void NesneyiKontrollereBagla() { }

        protected virtual void GuncelNesneOlustur() { }

        protected virtual void TabloYukle() { }

        protected virtual void BagliTabloYukle() { }

        protected virtual bool BagliTabloKaydet() { return false; }

        protected virtual bool BagliTabloHataliGirisKontrol() { return false; }

        protected virtual void ShowDetail(){}

        protected virtual void PlanKesinlestir(){}

        public virtual void Yukle() { }

        public virtual void Giris() { }

        protected virtual void DeleteConnectedControls(object sender) { }

        protected internal virtual IBaseEntity ReturnEntity() { return null; }

        protected internal virtual IEnumerable<IBaseEntity> ReturnEntities() { return null; }

        protected internal virtual bool HataliGirisKontrol() { return false; }

        protected virtual void VeriAktar() { }

        protected virtual void RezervasyonYap(){}

        protected virtual void Bol() { }

        protected internal virtual void Analiz(){}

        protected virtual void DefineFeature() { }

        protected internal virtual void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;//böyle bir kontrol kullanılmasının nedine datagrid de bir hücreye tıklanıp okul kartının açıldığını ve ilgili verilerin okul kartı sayfasının kontrollerine 
            //yüklenir ve her bir kontrole ilgili veri yüklenirken sürekli ButtonEnabledDurum fonksiyonu tetiklenecektir.bunun yüklenme esnasında tetiklenmesini istemediğimiz için bu 
            //okontrolü kullanırız ve IslLoad bool değişkenini true ya çekeriz..

            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity);
        }

        protected virtual void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnYeni)
            {
                if (!BaseKartTuru.YetkiKontrolu(YetkiTuru.Ekleyebilir)) return;
                BaseIslemTuru = IslemTuru.EntityInsert;
                Yukle();
            }
            else if (e.Item == btnGiris)
                Giris();
            else if (e.Item == btnKaydet)
                Kaydet(false);

            else if (e.Item == btnFarkliKaydet)
            {
                if (!BaseKartTuru.YetkiKontrolu(YetkiTuru.Ekleyebilir)) return;
                FarkliKaydet();
            }
            else if (e.Item == btnGerial)
                GeriAl();

            else if (e.Item == btnSil)
            {
                if (!BaseKartTuru.YetkiKontrolu(YetkiTuru.Silebilir)) return;
                EntityDelete();
            }
            else if (e.Item == btnTaksitOlustur)
                return;
            else if (e.Item == btnPlanKesinlestir)
                PlanKesinlestir();
            else if (e.Item == btnRunMrp)
                RunMrp();
            else if (e.Item == btnShowDetail)
                ShowDetail();
            else if (e.Item == btnUygula)
                FiltreUygula();
            else if (e.Item == btnYazdir)
                Yazdir();
            else if (e.Item == btnBaskiOnIzleme)
                BaskiOnIzlem();
            else if (e.Item == btnSifreSifirla)
                SifreSifirla();
            else if (e.Item == btnIceriVeriAktar)
                VeriAktar();
            else if (e.Item == btnRezervasyon)
                RezervasyonYap();
            else if (e.Item == btnUygulaBol)
                Bol();
            else if (e.Item == btnAnaliz)
                Analiz();
            else if (e.Item == btnFeatures)
                DefineFeature();
            else if (e.Item == btnCikis)
                Close();

            Cursor.Current = DefaultCursor;
        }


        private void BaseEditForm_LocationChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;
        }
        
        private void BaseEditForm_SizeChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            //var splashForm = new SplashScreenManager(Form.ActiveForm, typeof(BekleForm), true, true);
            //GeneralFunctions.SplashBaslat(splashForm);
            //splashForm.SetWaitFormCaption(splashCaption);
            //splashForm.SetWaitFormDescription("Sayfa Yükleniyor...");
            IsLoaded = true;
            GuncelNesneOlustur();
            SablonYukle();
            ButonGizleGoster();

            //Id = BaseIslemTuru.IdOlustur(OldEntity);

            if (FarkliSubeIslemi)
                Messages.UyariMesaji("İşlem Yapılan Kart Aktif Şube yada Dönemde Olmadığı için Yapılan Değişiklikler Kaydedilemez .");
            //GeneralFunctions.SplashDurdur(splashForm);
        }

        protected virtual void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
            if (IsMdiChild)
                Close();
            RefreshYapilacak = true;
            if (btnKaydet.Visibility == BarItemVisibility.Never || !btnKaydet.Enabled) return;

            if (!Kaydet(true))
                e.Cancel = true;
        }

        protected virtual void BaseEditForm_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            //GuncelNesneOlustur();
            //SablonYukle();
            //ButonGizleGoster();
            //if (LoadCompleted != null)
            //    LoadCompleted();

        }

        protected virtual void Tablo_EndSorting(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        protected virtual void Tablo_ColumnPositionChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        protected virtual void Tablo_ColumnWidthChanged(object sender, ColumnEventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        protected virtual void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (sender is MyButtonEdit edt)
                switch (e.KeyCode)
                {
                    case Keys.Delete when e.Control && e.Shift://burada ctrl+shift+delete yaptığımızda kontrolün içeriğini boşaltmış olacağız..
                        DeleteConnectedControls(sender);
                        edt.Id = null;
                        edt.EditValue = null;
                        break;
                    case Keys.F4:
                    case Keys.Down when e.Modifiers == Keys.Alt:
                        SecimYap(edt);
                        break;
                }
        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            var type = sender.GetType();

            if (type == typeof(MyButtonEdit) || type == typeof(MyGridView) || type == typeof(MyPictureEdit))//|| type == typeof(MyButtonEdit) ||)
            {
                statusBarKısaYol.Visibility = BarItemVisibility.Always;
                statusBarKısaYolAciklama.Visibility = BarItemVisibility.Always;

                statusBarAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarAciklama;
                statusBarKısaYol.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYol;
                statusBarKısaYolAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYolAciklama;
            }

            else if (sender is IStatusBarAciklama ctrl)
                statusBarAciklama.Caption = ctrl.StatusBarAciklama;
        }

        protected virtual void Control_Enter(object sender, EventArgs e){}

        private void Control_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_SimpleButtonClick(object sender, EventArgs e)
        {
            SecimYap(sender);
        }

        protected virtual void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }

        protected virtual void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }

        protected virtual void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e){}

        protected virtual void Control_SelectedPageChanging(object sender, SelectedPageChangingEventArgs e){}


        protected virtual void Control_SelectedValueChanged(object sender, EventArgs e) { }

        protected virtual void Control_EnabledChanged(object sender, EventArgs e) { }

        protected virtual void Control_CheckedChanged(object sender, EventArgs e){}

        protected virtual void Control_FocusedRowChanged(object sender, DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventArgs e){}

        protected virtual void Control_CellValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e){}

       
    }
}
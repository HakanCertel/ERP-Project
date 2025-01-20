namespace SenfoniYazilim.Erp.UI.Wİn.Forms.TahakkukForms
{
    partial class TahakkukListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TahakkukListForm));
            this.longNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.LongNavigator();
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKod = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOgrenciNo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTcKimlikNo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSoyadi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBabaAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colAnaAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKayitTarihi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKayitSekli = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKayitDurumu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSinifAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colGeldigiOkulAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKontenjanAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colYabanciDilAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colRehberAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTesvikAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSonrakiDonemKayitDurumu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSonrakiDonemKayitDurumuAciklama = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOzelKod1Adi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOzelKod2Adi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOzelKod3Adi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOzelKod4Adi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOzelKod5Adi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSubeAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 391);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1041, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1041, 289);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKod,
            this.colOgrenciNo,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colBabaAdi,
            this.colAnaAdi,
            this.colKayitTarihi,
            this.colKayitSekli,
            this.colKayitDurumu,
            this.colSinifAdi,
            this.colGeldigiOkulAdi,
            this.colKontenjanAdi,
            this.colYabanciDilAdi,
            this.colRehberAdi,
            this.colTesvikAdi,
            this.colSonrakiDonemKayitDurumu,
            this.colSonrakiDonemKayitDurumuAciklama,
            this.colOzelKod1Adi,
            this.colOzelKod2Adi,
            this.colOzelKod3Adi,
            this.colOzelKod4Adi,
            this.colOzelKod5Adi,
            this.colSubeAdi});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Tahakkuk Kartları";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = null;
            this.colId.StatusBarKisaYolAciklama = null;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Oğrenci No";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            // 
            // colOgrenciNo
            // 
            this.colOgrenciNo.Caption = "Okul No";
            this.colOgrenciNo.FieldName = "OgrenciNo";
            this.colOgrenciNo.Name = "colOgrenciNo";
            this.colOgrenciNo.OptionsColumn.AllowEdit = false;
            this.colOgrenciNo.StatusBarAciklama = null;
            this.colOgrenciNo.StatusBarKisaYol = null;
            this.colOgrenciNo.StatusBarKisaYolAciklama = null;
            this.colOgrenciNo.Visible = true;
            this.colOgrenciNo.VisibleIndex = 2;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "Tc Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisaYol = null;
            this.colTcKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.VisibleIndex = 1;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 3;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 4;
            // 
            // colBabaAdi
            // 
            this.colBabaAdi.Caption = "Baba Adı";
            this.colBabaAdi.FieldName = "BabaAdi";
            this.colBabaAdi.Name = "colBabaAdi";
            this.colBabaAdi.OptionsColumn.AllowEdit = false;
            this.colBabaAdi.StatusBarAciklama = null;
            this.colBabaAdi.StatusBarKisaYol = null;
            this.colBabaAdi.StatusBarKisaYolAciklama = null;
            this.colBabaAdi.Visible = true;
            this.colBabaAdi.VisibleIndex = 5;
            // 
            // colAnaAdi
            // 
            this.colAnaAdi.Caption = "Ana Adı";
            this.colAnaAdi.FieldName = "AnaAdi";
            this.colAnaAdi.Name = "colAnaAdi";
            this.colAnaAdi.OptionsColumn.AllowEdit = false;
            this.colAnaAdi.StatusBarAciklama = null;
            this.colAnaAdi.StatusBarKisaYol = null;
            this.colAnaAdi.StatusBarKisaYolAciklama = null;
            this.colAnaAdi.Visible = true;
            this.colAnaAdi.VisibleIndex = 6;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.Caption = "Kayıt Tarihi";
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.StatusBarAciklama = null;
            this.colKayitTarihi.StatusBarKisaYol = null;
            this.colKayitTarihi.StatusBarKisaYolAciklama = null;
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.VisibleIndex = 7;
            // 
            // colKayitSekli
            // 
            this.colKayitSekli.Caption = "Kayıt Şekli";
            this.colKayitSekli.FieldName = "KayitSekli";
            this.colKayitSekli.Name = "colKayitSekli";
            this.colKayitSekli.OptionsColumn.AllowEdit = false;
            this.colKayitSekli.StatusBarAciklama = null;
            this.colKayitSekli.StatusBarKisaYol = null;
            this.colKayitSekli.StatusBarKisaYolAciklama = null;
            this.colKayitSekli.Visible = true;
            this.colKayitSekli.VisibleIndex = 8;
            // 
            // colKayitDurumu
            // 
            this.colKayitDurumu.Caption = "Kayıt Durumu";
            this.colKayitDurumu.FieldName = "KayitDurumu";
            this.colKayitDurumu.Name = "colKayitDurumu";
            this.colKayitDurumu.OptionsColumn.AllowEdit = false;
            this.colKayitDurumu.StatusBarAciklama = null;
            this.colKayitDurumu.StatusBarKisaYol = null;
            this.colKayitDurumu.StatusBarKisaYolAciklama = null;
            this.colKayitDurumu.Visible = true;
            this.colKayitDurumu.VisibleIndex = 9;
            // 
            // colSinifAdi
            // 
            this.colSinifAdi.Caption = "Sınıf";
            this.colSinifAdi.FieldName = "SinifAdi";
            this.colSinifAdi.Name = "colSinifAdi";
            this.colSinifAdi.OptionsColumn.AllowEdit = false;
            this.colSinifAdi.StatusBarAciklama = null;
            this.colSinifAdi.StatusBarKisaYol = null;
            this.colSinifAdi.StatusBarKisaYolAciklama = null;
            this.colSinifAdi.Visible = true;
            this.colSinifAdi.VisibleIndex = 10;
            // 
            // colGeldigiOkulAdi
            // 
            this.colGeldigiOkulAdi.Caption = "Geldiği Okul";
            this.colGeldigiOkulAdi.FieldName = "GeldigiOkulAdi";
            this.colGeldigiOkulAdi.Name = "colGeldigiOkulAdi";
            this.colGeldigiOkulAdi.OptionsColumn.AllowEdit = false;
            this.colGeldigiOkulAdi.StatusBarAciklama = null;
            this.colGeldigiOkulAdi.StatusBarKisaYol = null;
            this.colGeldigiOkulAdi.StatusBarKisaYolAciklama = null;
            this.colGeldigiOkulAdi.Visible = true;
            this.colGeldigiOkulAdi.VisibleIndex = 11;
            // 
            // colKontenjanAdi
            // 
            this.colKontenjanAdi.Caption = "Kontenjan Durumu";
            this.colKontenjanAdi.FieldName = "KontenjanAdi";
            this.colKontenjanAdi.Name = "colKontenjanAdi";
            this.colKontenjanAdi.OptionsColumn.AllowEdit = false;
            this.colKontenjanAdi.StatusBarAciklama = null;
            this.colKontenjanAdi.StatusBarKisaYol = null;
            this.colKontenjanAdi.StatusBarKisaYolAciklama = null;
            this.colKontenjanAdi.Visible = true;
            this.colKontenjanAdi.VisibleIndex = 12;
            // 
            // colYabanciDilAdi
            // 
            this.colYabanciDilAdi.Caption = "Yabancı Dil";
            this.colYabanciDilAdi.FieldName = "YabanciDilAdi";
            this.colYabanciDilAdi.Name = "colYabanciDilAdi";
            this.colYabanciDilAdi.OptionsColumn.AllowEdit = false;
            this.colYabanciDilAdi.StatusBarAciklama = null;
            this.colYabanciDilAdi.StatusBarKisaYol = null;
            this.colYabanciDilAdi.StatusBarKisaYolAciklama = null;
            this.colYabanciDilAdi.Visible = true;
            this.colYabanciDilAdi.VisibleIndex = 13;
            // 
            // colRehberAdi
            // 
            this.colRehberAdi.Caption = "Sınıf Öğretmeni";
            this.colRehberAdi.FieldName = "RehberAdi";
            this.colRehberAdi.Name = "colRehberAdi";
            this.colRehberAdi.OptionsColumn.AllowEdit = false;
            this.colRehberAdi.StatusBarAciklama = null;
            this.colRehberAdi.StatusBarKisaYol = null;
            this.colRehberAdi.StatusBarKisaYolAciklama = null;
            this.colRehberAdi.Visible = true;
            this.colRehberAdi.VisibleIndex = 14;
            // 
            // colTesvikAdi
            // 
            this.colTesvikAdi.Caption = "Teşvik Durumu";
            this.colTesvikAdi.FieldName = "TesvikAdi";
            this.colTesvikAdi.Name = "colTesvikAdi";
            this.colTesvikAdi.OptionsColumn.AllowEdit = false;
            this.colTesvikAdi.StatusBarAciklama = null;
            this.colTesvikAdi.StatusBarKisaYol = null;
            this.colTesvikAdi.StatusBarKisaYolAciklama = null;
            this.colTesvikAdi.Visible = true;
            this.colTesvikAdi.VisibleIndex = 15;
            // 
            // colSonrakiDonemKayitDurumu
            // 
            this.colSonrakiDonemKayitDurumu.Caption = "Sonraki Dönem Kayıt Durumu";
            this.colSonrakiDonemKayitDurumu.FieldName = "SonrakiDonemKayitDurumu";
            this.colSonrakiDonemKayitDurumu.Name = "colSonrakiDonemKayitDurumu";
            this.colSonrakiDonemKayitDurumu.OptionsColumn.AllowEdit = false;
            this.colSonrakiDonemKayitDurumu.StatusBarAciklama = null;
            this.colSonrakiDonemKayitDurumu.StatusBarKisaYol = null;
            this.colSonrakiDonemKayitDurumu.StatusBarKisaYolAciklama = null;
            this.colSonrakiDonemKayitDurumu.Visible = true;
            this.colSonrakiDonemKayitDurumu.VisibleIndex = 16;
            // 
            // colSonrakiDonemKayitDurumuAciklama
            // 
            this.colSonrakiDonemKayitDurumuAciklama.Caption = "Açıklama";
            this.colSonrakiDonemKayitDurumuAciklama.FieldName = "SonrakiDonemKayitDurumuAciklama";
            this.colSonrakiDonemKayitDurumuAciklama.Name = "colSonrakiDonemKayitDurumuAciklama";
            this.colSonrakiDonemKayitDurumuAciklama.OptionsColumn.AllowEdit = false;
            this.colSonrakiDonemKayitDurumuAciklama.StatusBarAciklama = null;
            this.colSonrakiDonemKayitDurumuAciklama.StatusBarKisaYol = null;
            this.colSonrakiDonemKayitDurumuAciklama.StatusBarKisaYolAciklama = null;
            this.colSonrakiDonemKayitDurumuAciklama.Visible = true;
            this.colSonrakiDonemKayitDurumuAciklama.VisibleIndex = 17;
            // 
            // colOzelKod1Adi
            // 
            this.colOzelKod1Adi.Caption = "Özel Kod-1";
            this.colOzelKod1Adi.FieldName = "OzelKod1Adi";
            this.colOzelKod1Adi.Name = "colOzelKod1Adi";
            this.colOzelKod1Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod1Adi.StatusBarAciklama = null;
            this.colOzelKod1Adi.StatusBarKisaYol = null;
            this.colOzelKod1Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod1Adi.Visible = true;
            this.colOzelKod1Adi.VisibleIndex = 18;
            // 
            // colOzelKod2Adi
            // 
            this.colOzelKod2Adi.Caption = "Özel Kod-2";
            this.colOzelKod2Adi.FieldName = "OzelKod2Adi";
            this.colOzelKod2Adi.Name = "colOzelKod2Adi";
            this.colOzelKod2Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod2Adi.StatusBarAciklama = null;
            this.colOzelKod2Adi.StatusBarKisaYol = null;
            this.colOzelKod2Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod2Adi.Visible = true;
            this.colOzelKod2Adi.VisibleIndex = 19;
            // 
            // colOzelKod3Adi
            // 
            this.colOzelKod3Adi.Caption = "Özel Kod-3";
            this.colOzelKod3Adi.FieldName = "OzelKod3Adi";
            this.colOzelKod3Adi.Name = "colOzelKod3Adi";
            this.colOzelKod3Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod3Adi.StatusBarAciklama = null;
            this.colOzelKod3Adi.StatusBarKisaYol = null;
            this.colOzelKod3Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod3Adi.Visible = true;
            this.colOzelKod3Adi.VisibleIndex = 20;
            // 
            // colOzelKod4Adi
            // 
            this.colOzelKod4Adi.Caption = "Özel Kod-4";
            this.colOzelKod4Adi.FieldName = "OzelKod4Adi";
            this.colOzelKod4Adi.Name = "colOzelKod4Adi";
            this.colOzelKod4Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod4Adi.StatusBarAciklama = null;
            this.colOzelKod4Adi.StatusBarKisaYol = null;
            this.colOzelKod4Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod4Adi.Visible = true;
            this.colOzelKod4Adi.VisibleIndex = 21;
            // 
            // colOzelKod5Adi
            // 
            this.colOzelKod5Adi.Caption = "Özel Kod-5";
            this.colOzelKod5Adi.FieldName = "OzelKod5Adi";
            this.colOzelKod5Adi.Name = "colOzelKod5Adi";
            this.colOzelKod5Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod5Adi.StatusBarAciklama = null;
            this.colOzelKod5Adi.StatusBarKisaYol = null;
            this.colOzelKod5Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod5Adi.Visible = true;
            this.colOzelKod5Adi.VisibleIndex = 22;
            // 
            // colSubeAdi
            // 
            this.colSubeAdi.Caption = "Şube Adı";
            this.colSubeAdi.FieldName = "SubeAdi";
            this.colSubeAdi.Name = "colSubeAdi";
            this.colSubeAdi.OptionsColumn.AllowEdit = false;
            this.colSubeAdi.StatusBarAciklama = null;
            this.colSubeAdi.StatusBarKisaYol = null;
            this.colSubeAdi.StatusBarKisaYolAciklama = null;
            this.colSubeAdi.Visible = true;
            this.colSubeAdi.VisibleIndex = 23;
            // 
            // TahakkukListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 446);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "TahakkukListForm";
            this.Text = "Tahakkuk Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Grid.MyGridColumn colTcKimlikNo;
        private UserControls.Grid.MyGridColumn colOgrenciNo;
        private UserControls.Grid.MyGridColumn colAdi;
        private UserControls.Grid.MyGridColumn colSoyadi;
        private UserControls.Grid.MyGridColumn colBabaAdi;
        private UserControls.Grid.MyGridColumn colAnaAdi;
        private UserControls.Grid.MyGridColumn colKayitTarihi;
        private UserControls.Grid.MyGridColumn colKayitSekli;
        private UserControls.Grid.MyGridColumn colKayitDurumu;
        private UserControls.Grid.MyGridColumn colSinifAdi;
        private UserControls.Grid.MyGridColumn colGeldigiOkulAdi;
        private UserControls.Grid.MyGridColumn colKontenjanAdi;
        private UserControls.Grid.MyGridColumn colYabanciDilAdi;
        private UserControls.Grid.MyGridColumn colRehberAdi;
        private UserControls.Grid.MyGridColumn colTesvikAdi;
        private UserControls.Grid.MyGridColumn colSonrakiDonemKayitDurumu;
        private UserControls.Grid.MyGridColumn colSonrakiDonemKayitDurumuAciklama;
        private UserControls.Grid.MyGridColumn colOzelKod1Adi;
        private UserControls.Grid.MyGridColumn colOzelKod2Adi;
        private UserControls.Grid.MyGridColumn colOzelKod3Adi;
        private UserControls.Grid.MyGridColumn colOzelKod4Adi;
        private UserControls.Grid.MyGridColumn colOzelKod5Adi;
        private UserControls.Grid.MyGridColumn colSubeAdi;
    }
}
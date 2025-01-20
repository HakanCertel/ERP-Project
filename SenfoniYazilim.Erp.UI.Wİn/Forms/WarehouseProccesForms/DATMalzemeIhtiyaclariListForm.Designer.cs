namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms
{
    partial class DATMalzemeIhtiyaclariListForm
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
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colMrpBilgileriId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMrpKod = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colAnaReceteKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBagliOlduguAnaReceteId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBagliOlduguUstReceteStokKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBirimIhtiyac = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCalcEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colToplamIhtiyac = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colNetIhtiyac = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colToplamStokMiktari = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colToplamRezerveMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colAcikMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colRezerveMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBrutIhtiyac = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBirim = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTavsiyeEdilenUretimBaslamaTarihi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIhtiyacTarihi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colToplamUretimSuresi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colReceteSeviyesi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIstasyonKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOperasyonKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMakinaKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKayitMiktari = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOperasyonSeviyesi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.longNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.LongNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(1121, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit});
            this.grid.Size = new System.Drawing.Size(1121, 289);
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
            this.colMrpBilgileriId,
            this.colMrpKod,
            this.colAnaReceteKodu,
            this.colBagliOlduguAnaReceteId,
            this.colBagliOlduguUstReceteStokKodu,
            this.colStokId,
            this.colStokKodu,
            this.colStokAdi,
            this.colBirimIhtiyac,
            this.colToplamIhtiyac,
            this.colNetIhtiyac,
            this.colToplamStokMiktari,
            this.colToplamRezerveMiktar,
            this.colAcikMiktar,
            this.colRezerveMiktar,
            this.colBrutIhtiyac,
            this.colBirim,
            this.colTavsiyeEdilenUretimBaslamaTarihi,
            this.colIhtiyacTarihi,
            this.colToplamUretimSuresi,
            this.colReceteSeviyesi,
            this.colIstasyonKodu,
            this.colOperasyonKodu,
            this.colMakinaKodu,
            this.colKayitMiktari,
            this.colOperasyonSeviyesi});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsCustomization.AllowSort = false;
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
            this.tablo.ViewCaption = "Transfer Edilebilecek Malzeme İhtiyaç Listesi";
            // 
            // colMrpBilgileriId
            // 
            this.colMrpBilgileriId.Caption = "MrpBilgileriId";
            this.colMrpBilgileriId.FieldName = "MrpBilgileriId";
            this.colMrpBilgileriId.Name = "colMrpBilgileriId";
            this.colMrpBilgileriId.OptionsColumn.AllowEdit = false;
            this.colMrpBilgileriId.StatusBarAciklama = null;
            this.colMrpBilgileriId.StatusBarKisaYol = null;
            this.colMrpBilgileriId.StatusBarKisaYolAciklama = null;
            this.colMrpBilgileriId.Visible = true;
            this.colMrpBilgileriId.VisibleIndex = 21;
            // 
            // colMrpKod
            // 
            this.colMrpKod.Caption = "Mrp Kod";
            this.colMrpKod.FieldName = "MrpKod";
            this.colMrpKod.Name = "colMrpKod";
            this.colMrpKod.OptionsColumn.AllowEdit = false;
            this.colMrpKod.StatusBarAciklama = null;
            this.colMrpKod.StatusBarKisaYol = null;
            this.colMrpKod.StatusBarKisaYolAciklama = null;
            this.colMrpKod.Visible = true;
            this.colMrpKod.VisibleIndex = 0;
            this.colMrpKod.Width = 89;
            // 
            // colAnaReceteKodu
            // 
            this.colAnaReceteKodu.Caption = "Reçete Kodu";
            this.colAnaReceteKodu.FieldName = "AnaReceteKodu";
            this.colAnaReceteKodu.Name = "colAnaReceteKodu";
            this.colAnaReceteKodu.OptionsColumn.AllowEdit = false;
            this.colAnaReceteKodu.StatusBarAciklama = null;
            this.colAnaReceteKodu.StatusBarKisaYol = null;
            this.colAnaReceteKodu.StatusBarKisaYolAciklama = null;
            this.colAnaReceteKodu.Visible = true;
            this.colAnaReceteKodu.VisibleIndex = 1;
            // 
            // colBagliOlduguAnaReceteId
            // 
            this.colBagliOlduguAnaReceteId.Caption = "BagliOlduguAnaReceteId";
            this.colBagliOlduguAnaReceteId.FieldName = "BagliOlduguAnaReceteId";
            this.colBagliOlduguAnaReceteId.Name = "colBagliOlduguAnaReceteId";
            this.colBagliOlduguAnaReceteId.OptionsColumn.AllowEdit = false;
            this.colBagliOlduguAnaReceteId.StatusBarAciklama = null;
            this.colBagliOlduguAnaReceteId.StatusBarKisaYol = null;
            this.colBagliOlduguAnaReceteId.StatusBarKisaYolAciklama = null;
            this.colBagliOlduguAnaReceteId.Visible = true;
            this.colBagliOlduguAnaReceteId.VisibleIndex = 22;
            // 
            // colBagliOlduguUstReceteStokKodu
            // 
            this.colBagliOlduguUstReceteStokKodu.Caption = "Bilesen Recete Kodu";
            this.colBagliOlduguUstReceteStokKodu.FieldName = "BagliOlduguUstReceteStokKodu";
            this.colBagliOlduguUstReceteStokKodu.Name = "colBagliOlduguUstReceteStokKodu";
            this.colBagliOlduguUstReceteStokKodu.OptionsColumn.AllowEdit = false;
            this.colBagliOlduguUstReceteStokKodu.StatusBarAciklama = null;
            this.colBagliOlduguUstReceteStokKodu.StatusBarKisaYol = null;
            this.colBagliOlduguUstReceteStokKodu.StatusBarKisaYolAciklama = null;
            this.colBagliOlduguUstReceteStokKodu.Visible = true;
            this.colBagliOlduguUstReceteStokKodu.VisibleIndex = 2;
            this.colBagliOlduguUstReceteStokKodu.Width = 130;
            // 
            // colStokId
            // 
            this.colStokId.Caption = "Id";
            this.colStokId.FieldName = "StokId";
            this.colStokId.Name = "colStokId";
            this.colStokId.OptionsColumn.AllowEdit = false;
            this.colStokId.OptionsColumn.ShowInCustomizationForm = false;
            this.colStokId.StatusBarAciklama = null;
            this.colStokId.StatusBarKisaYol = null;
            this.colStokId.StatusBarKisaYolAciklama = null;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.StatusBarAciklama = null;
            this.colStokKodu.StatusBarKisaYol = null;
            this.colStokKodu.StatusBarKisaYolAciklama = null;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 3;
            this.colStokKodu.Width = 116;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.StatusBarAciklama = null;
            this.colStokAdi.StatusBarKisaYol = null;
            this.colStokAdi.StatusBarKisaYolAciklama = null;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 4;
            this.colStokAdi.Width = 134;
            // 
            // colBirimIhtiyac
            // 
            this.colBirimIhtiyac.Caption = "Birim İhtiyaç";
            this.colBirimIhtiyac.ColumnEdit = this.repositoryItemCalcEdit;
            this.colBirimIhtiyac.DisplayFormat.FormatString = "n3";
            this.colBirimIhtiyac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBirimIhtiyac.FieldName = "BirimIhtiyac";
            this.colBirimIhtiyac.Name = "colBirimIhtiyac";
            this.colBirimIhtiyac.OptionsColumn.AllowEdit = false;
            this.colBirimIhtiyac.StatusBarAciklama = null;
            this.colBirimIhtiyac.StatusBarKisaYol = null;
            this.colBirimIhtiyac.StatusBarKisaYolAciklama = null;
            this.colBirimIhtiyac.Visible = true;
            this.colBirimIhtiyac.VisibleIndex = 6;
            this.colBirimIhtiyac.Width = 81;
            // 
            // repositoryItemCalcEdit
            // 
            this.repositoryItemCalcEdit.AutoHeight = false;
            this.repositoryItemCalcEdit.DisplayFormat.FormatString = "n3";
            this.repositoryItemCalcEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEdit.EditFormat.FormatString = "n3";
            this.repositoryItemCalcEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEdit.Name = "repositoryItemCalcEdit";
            // 
            // colToplamIhtiyac
            // 
            this.colToplamIhtiyac.Caption = "Toplam İhtiyaç";
            this.colToplamIhtiyac.ColumnEdit = this.repositoryItemCalcEdit;
            this.colToplamIhtiyac.FieldName = "ToplamIhtiyac";
            this.colToplamIhtiyac.Name = "colToplamIhtiyac";
            this.colToplamIhtiyac.OptionsColumn.AllowEdit = false;
            this.colToplamIhtiyac.StatusBarAciklama = null;
            this.colToplamIhtiyac.StatusBarKisaYol = null;
            this.colToplamIhtiyac.StatusBarKisaYolAciklama = null;
            this.colToplamIhtiyac.Visible = true;
            this.colToplamIhtiyac.VisibleIndex = 7;
            this.colToplamIhtiyac.Width = 88;
            // 
            // colNetIhtiyac
            // 
            this.colNetIhtiyac.Caption = "Net İhtiyaç";
            this.colNetIhtiyac.ColumnEdit = this.repositoryItemCalcEdit;
            this.colNetIhtiyac.FieldName = "NetIhtiyac";
            this.colNetIhtiyac.Name = "colNetIhtiyac";
            this.colNetIhtiyac.OptionsColumn.AllowEdit = false;
            this.colNetIhtiyac.StatusBarAciklama = null;
            this.colNetIhtiyac.StatusBarKisaYol = null;
            this.colNetIhtiyac.StatusBarKisaYolAciklama = null;
            this.colNetIhtiyac.Visible = true;
            this.colNetIhtiyac.VisibleIndex = 9;
            // 
            // colToplamStokMiktari
            // 
            this.colToplamStokMiktari.Caption = "Toplam Stok";
            this.colToplamStokMiktari.ColumnEdit = this.repositoryItemCalcEdit;
            this.colToplamStokMiktari.FieldName = "ToplamStokMiktari";
            this.colToplamStokMiktari.Name = "colToplamStokMiktari";
            this.colToplamStokMiktari.OptionsColumn.AllowEdit = false;
            this.colToplamStokMiktari.StatusBarAciklama = null;
            this.colToplamStokMiktari.StatusBarKisaYol = null;
            this.colToplamStokMiktari.StatusBarKisaYolAciklama = null;
            this.colToplamStokMiktari.Visible = true;
            this.colToplamStokMiktari.VisibleIndex = 10;
            // 
            // colToplamRezerveMiktar
            // 
            this.colToplamRezerveMiktar.Caption = "Toplam Rezerve Miktar";
            this.colToplamRezerveMiktar.ColumnEdit = this.repositoryItemCalcEdit;
            this.colToplamRezerveMiktar.FieldName = "ToplamRezerveMiktar";
            this.colToplamRezerveMiktar.Name = "colToplamRezerveMiktar";
            this.colToplamRezerveMiktar.OptionsColumn.AllowEdit = false;
            this.colToplamRezerveMiktar.StatusBarAciklama = null;
            this.colToplamRezerveMiktar.StatusBarKisaYol = null;
            this.colToplamRezerveMiktar.StatusBarKisaYolAciklama = null;
            this.colToplamRezerveMiktar.Visible = true;
            this.colToplamRezerveMiktar.VisibleIndex = 11;
            this.colToplamRezerveMiktar.Width = 135;
            // 
            // colAcikMiktar
            // 
            this.colAcikMiktar.Caption = "Açık Miktar";
            this.colAcikMiktar.ColumnEdit = this.repositoryItemCalcEdit;
            this.colAcikMiktar.FieldName = "AcikMiktar";
            this.colAcikMiktar.Name = "colAcikMiktar";
            this.colAcikMiktar.OptionsColumn.AllowEdit = false;
            this.colAcikMiktar.StatusBarAciklama = null;
            this.colAcikMiktar.StatusBarKisaYol = null;
            this.colAcikMiktar.StatusBarKisaYolAciklama = null;
            this.colAcikMiktar.Visible = true;
            this.colAcikMiktar.VisibleIndex = 12;
            // 
            // colRezerveMiktar
            // 
            this.colRezerveMiktar.Caption = "Rezerve";
            this.colRezerveMiktar.ColumnEdit = this.repositoryItemCalcEdit;
            this.colRezerveMiktar.FieldName = "RezerveMiktar";
            this.colRezerveMiktar.Name = "colRezerveMiktar";
            this.colRezerveMiktar.StatusBarAciklama = null;
            this.colRezerveMiktar.StatusBarKisaYol = null;
            this.colRezerveMiktar.StatusBarKisaYolAciklama = null;
            this.colRezerveMiktar.Visible = true;
            this.colRezerveMiktar.VisibleIndex = 13;
            // 
            // colBrutIhtiyac
            // 
            this.colBrutIhtiyac.Caption = "Brüt Ihtiyaç";
            this.colBrutIhtiyac.ColumnEdit = this.repositoryItemCalcEdit;
            this.colBrutIhtiyac.FieldName = "BrutIhtiyac";
            this.colBrutIhtiyac.Name = "colBrutIhtiyac";
            this.colBrutIhtiyac.OptionsColumn.AllowEdit = false;
            this.colBrutIhtiyac.StatusBarAciklama = null;
            this.colBrutIhtiyac.StatusBarKisaYol = null;
            this.colBrutIhtiyac.StatusBarKisaYolAciklama = null;
            this.colBrutIhtiyac.Visible = true;
            this.colBrutIhtiyac.VisibleIndex = 8;
            // 
            // colBirim
            // 
            this.colBirim.Caption = "Birim";
            this.colBirim.FieldName = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            this.colBirim.StatusBarAciklama = null;
            this.colBirim.StatusBarKisaYol = null;
            this.colBirim.StatusBarKisaYolAciklama = null;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 5;
            // 
            // colTavsiyeEdilenUretimBaslamaTarihi
            // 
            this.colTavsiyeEdilenUretimBaslamaTarihi.Caption = "Başlama Tarihi";
            this.colTavsiyeEdilenUretimBaslamaTarihi.DisplayFormat.FormatString = "d";
            this.colTavsiyeEdilenUretimBaslamaTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTavsiyeEdilenUretimBaslamaTarihi.FieldName = "TavsiyeEdilenUretimBaslamaTarihi";
            this.colTavsiyeEdilenUretimBaslamaTarihi.Name = "colTavsiyeEdilenUretimBaslamaTarihi";
            this.colTavsiyeEdilenUretimBaslamaTarihi.OptionsColumn.AllowEdit = false;
            this.colTavsiyeEdilenUretimBaslamaTarihi.StatusBarAciklama = null;
            this.colTavsiyeEdilenUretimBaslamaTarihi.StatusBarKisaYol = null;
            this.colTavsiyeEdilenUretimBaslamaTarihi.StatusBarKisaYolAciklama = null;
            this.colTavsiyeEdilenUretimBaslamaTarihi.Visible = true;
            this.colTavsiyeEdilenUretimBaslamaTarihi.VisibleIndex = 16;
            this.colTavsiyeEdilenUretimBaslamaTarihi.Width = 103;
            // 
            // colIhtiyacTarihi
            // 
            this.colIhtiyacTarihi.Caption = "İhtiyaç Tarihi";
            this.colIhtiyacTarihi.FieldName = "IhtiyacTarihi";
            this.colIhtiyacTarihi.Name = "colIhtiyacTarihi";
            this.colIhtiyacTarihi.OptionsColumn.AllowEdit = false;
            this.colIhtiyacTarihi.StatusBarAciklama = null;
            this.colIhtiyacTarihi.StatusBarKisaYol = null;
            this.colIhtiyacTarihi.StatusBarKisaYolAciklama = null;
            this.colIhtiyacTarihi.Visible = true;
            this.colIhtiyacTarihi.VisibleIndex = 15;
            // 
            // colToplamUretimSuresi
            // 
            this.colToplamUretimSuresi.Caption = "Uretim Suresi";
            this.colToplamUretimSuresi.FieldName = "ToplamUretimSuresi";
            this.colToplamUretimSuresi.Name = "colToplamUretimSuresi";
            this.colToplamUretimSuresi.OptionsColumn.AllowEdit = false;
            this.colToplamUretimSuresi.StatusBarAciklama = null;
            this.colToplamUretimSuresi.StatusBarKisaYol = null;
            this.colToplamUretimSuresi.StatusBarKisaYolAciklama = null;
            this.colToplamUretimSuresi.Visible = true;
            this.colToplamUretimSuresi.VisibleIndex = 14;
            // 
            // colReceteSeviyesi
            // 
            this.colReceteSeviyesi.Caption = "Recete Seviyesi";
            this.colReceteSeviyesi.FieldName = "ReceteSeviyesi";
            this.colReceteSeviyesi.Name = "colReceteSeviyesi";
            this.colReceteSeviyesi.OptionsColumn.AllowEdit = false;
            this.colReceteSeviyesi.StatusBarAciklama = null;
            this.colReceteSeviyesi.StatusBarKisaYol = null;
            this.colReceteSeviyesi.StatusBarKisaYolAciklama = null;
            this.colReceteSeviyesi.Visible = true;
            this.colReceteSeviyesi.VisibleIndex = 17;
            // 
            // colIstasyonKodu
            // 
            this.colIstasyonKodu.Caption = "Istasyon Kodu";
            this.colIstasyonKodu.FieldName = "IstasyonKodu";
            this.colIstasyonKodu.Name = "colIstasyonKodu";
            this.colIstasyonKodu.OptionsColumn.AllowEdit = false;
            this.colIstasyonKodu.StatusBarAciklama = null;
            this.colIstasyonKodu.StatusBarKisaYol = null;
            this.colIstasyonKodu.StatusBarKisaYolAciklama = null;
            this.colIstasyonKodu.Visible = true;
            this.colIstasyonKodu.VisibleIndex = 18;
            // 
            // colOperasyonKodu
            // 
            this.colOperasyonKodu.Caption = "Operasyon Kodu";
            this.colOperasyonKodu.FieldName = "OperasyonKodu";
            this.colOperasyonKodu.Name = "colOperasyonKodu";
            this.colOperasyonKodu.OptionsColumn.AllowEdit = false;
            this.colOperasyonKodu.StatusBarAciklama = null;
            this.colOperasyonKodu.StatusBarKisaYol = null;
            this.colOperasyonKodu.StatusBarKisaYolAciklama = null;
            this.colOperasyonKodu.Visible = true;
            this.colOperasyonKodu.VisibleIndex = 19;
            // 
            // colMakinaKodu
            // 
            this.colMakinaKodu.Caption = "MakinaKodu";
            this.colMakinaKodu.FieldName = "MakinaKodu";
            this.colMakinaKodu.Name = "colMakinaKodu";
            this.colMakinaKodu.OptionsColumn.AllowEdit = false;
            this.colMakinaKodu.StatusBarAciklama = null;
            this.colMakinaKodu.StatusBarKisaYol = null;
            this.colMakinaKodu.StatusBarKisaYolAciklama = null;
            this.colMakinaKodu.Visible = true;
            this.colMakinaKodu.VisibleIndex = 20;
            // 
            // colKayitMiktari
            // 
            this.colKayitMiktari.Caption = "Kayıt Miktarı";
            this.colKayitMiktari.ColumnEdit = this.repositoryItemCalcEdit;
            this.colKayitMiktari.FieldName = "KayitMiktari";
            this.colKayitMiktari.Name = "colKayitMiktari";
            this.colKayitMiktari.OptionsColumn.ShowInCustomizationForm = false;
            this.colKayitMiktari.StatusBarAciklama = null;
            this.colKayitMiktari.StatusBarKisaYol = null;
            this.colKayitMiktari.StatusBarKisaYolAciklama = null;
            // 
            // colOperasyonSeviyesi
            // 
            this.colOperasyonSeviyesi.Caption = "Operasyon Seviyesi";
            this.colOperasyonSeviyesi.FieldName = "OperasyonSeviyesi";
            this.colOperasyonSeviyesi.Name = "colOperasyonSeviyesi";
            this.colOperasyonSeviyesi.OptionsColumn.AllowEdit = false;
            this.colOperasyonSeviyesi.StatusBarAciklama = null;
            this.colOperasyonSeviyesi.StatusBarKisaYol = null;
            this.colOperasyonSeviyesi.StatusBarKisaYolAciklama = null;
            this.colOperasyonSeviyesi.Visible = true;
            this.colOperasyonSeviyesi.VisibleIndex = 23;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 391);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1121, 24);
            this.longNavigator.TabIndex = 4;
            // 
            // DATMalzemeIhtiyaclariListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 446);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "DATMalzemeIhtiyaclariListForm";
            this.Text = "Transfer Edilebilecek Malzeme İhtiyaç Listesi";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colAnaReceteKodu;
        private UserControls.Grid.MyGridColumn colStokKodu;
        private UserControls.Grid.MyGridColumn colStokAdi;
        private UserControls.Grid.MyGridColumn colBirimIhtiyac;
        private UserControls.Grid.MyGridColumn colToplamIhtiyac;
        private UserControls.Grid.MyGridColumn colBirim;
        private UserControls.Grid.MyGridColumn colTavsiyeEdilenUretimBaslamaTarihi;
        private UserControls.Grid.MyGridColumn colIhtiyacTarihi;
        private UserControls.Grid.MyGridColumn colMrpKod;
        private UserControls.Grid.MyGridColumn colMrpBilgileriId;
        private UserControls.Grid.MyGridColumn colBagliOlduguAnaReceteId;
        private UserControls.Grid.MyGridColumn colBagliOlduguUstReceteStokKodu;
        private UserControls.Grid.MyGridColumn colToplamUretimSuresi;
        private UserControls.Grid.MyGridColumn colReceteSeviyesi;
        private UserControls.Grid.MyGridColumn colIstasyonKodu;
        private UserControls.Grid.MyGridColumn colOperasyonKodu;
        private UserControls.Grid.MyGridColumn colMakinaKodu;
        private UserControls.Grid.MyGridColumn colToplamStokMiktari;
        private UserControls.Grid.MyGridColumn colBrutIhtiyac;
        private UserControls.Grid.MyGridColumn colToplamRezerveMiktar;
        private UserControls.Grid.MyGridColumn colAcikMiktar;
        private UserControls.Grid.MyGridColumn colRezerveMiktar;
        private UserControls.Grid.MyGridColumn colNetIhtiyac;
        private UserControls.Grid.MyGridColumn colStokId;
        private UserControls.Grid.MyGridColumn colKayitMiktari;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit;
        private UserControls.Grid.MyGridColumn colOperasyonSeviyesi;
        private UserControls.Navigators.LongNavigator longNavigator;
    }
}
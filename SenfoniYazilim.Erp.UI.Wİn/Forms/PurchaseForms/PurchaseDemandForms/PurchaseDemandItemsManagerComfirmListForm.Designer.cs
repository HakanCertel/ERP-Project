namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms
{
    partial class PurchaseDemandItemsManagerComfirmListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseDemandItemsManagerComfirmListForm));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.longNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.LongNavigator();
            this.btnYoneticiOnay = new DevExpress.XtraBars.BarButtonItem();
            this.btnTeklifTopla = new DevExpress.XtraBars.BarButtonItem();
            this.btnSatinalmaSipariseCevir = new DevExpress.XtraBars.BarButtonItem();
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colItemId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPurchaseDemandId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDemandedCompanyId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPurchaseOfferItemId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colConnectedItemId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDemandQty = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCalcGeneral = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colComfirmedQty = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDemandedDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemDateTalepTarihi = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colDemandFile = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemButtonBelge = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDemandDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDemandItemDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIsDemandItemCanceled = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCheckIsItemCanceled = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colIsTopDemand = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIsTopDemandExisted = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIsBlocked = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPurchaseOfferDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialUnit = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDemandedCompanyName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStorageStockQty = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaxPurchaseOrderQty = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMinPurchaseOrderQty = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaxStockQty = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMinStockQty = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCreatorName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCreatedDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUpdatingName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUpdatingDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemButtonSatinalmaTalepStok = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonFirma = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemCalcTalepMiktari = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSatinalmaTalepKalemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTalepTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTalepTarihi.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonBelge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckIsItemCanceled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonSatinalmaTalepStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcTalepMiktari)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnYoneticiOnay,
            this.btnTeklifTopla,
            this.btnSatinalmaSipariseCevir});
            this.ribbonControl.MaxItemId = 1;
            this.ribbonControl.Size = new System.Drawing.Size(1062, 56);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // btnMakbuzYeni
            // 
            this.btnMakbuzYeni.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMakbuzYeni.ImageOptions.Image")));
            this.btnMakbuzYeni.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMakbuzYeni.ImageOptions.LargeImage")));
            // 
            // barSubItem3
            // 
            this.barSubItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem3.ImageOptions.Image")));
            // 
            // btnRaporYeni
            // 
            this.btnRaporYeni.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporYeni.ImageOptions.Image")));
            this.btnRaporYeni.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRaporYeni.ImageOptions.LargeImage")));
            // 
            // btnIceriVeriAktar
            // 
            this.btnIceriVeriAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIceriVeriAktar.ImageOptions.Image")));
            this.btnIceriVeriAktar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnIceriVeriAktar.ImageOptions.LargeImage")));
            // 
            // btnIndirimTalep
            // 
            this.btnIndirimTalep.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIndirimTalep.ImageOptions.Image")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 391);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1062, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // btnYoneticiOnay
            // 
            this.btnYoneticiOnay.Caption = "Yönetici Onayına Gönder";
            this.btnYoneticiOnay.Id = 115;
            this.btnYoneticiOnay.ImageOptions.Image = global::SenfoniYazilim.Erp.UI.Wİn.Properties.Resources.bringtofrontoftext_16x16;
            this.btnYoneticiOnay.ImageOptions.LargeImage = global::SenfoniYazilim.Erp.UI.Wİn.Properties.Resources.bringtofrontoftext_32x32;
            this.btnYoneticiOnay.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.O));
            this.btnYoneticiOnay.Name = "btnYoneticiOnay";
            // 
            // btnTeklifTopla
            // 
            this.btnTeklifTopla.Caption = "Teklif Topla";
            this.btnTeklifTopla.Id = 116;
            this.btnTeklifTopla.ImageOptions.Image = global::SenfoniYazilim.Erp.UI.Wİn.Properties.Resources.touchmode_16x16;
            this.btnTeklifTopla.ImageOptions.LargeImage = global::SenfoniYazilim.Erp.UI.Wİn.Properties.Resources.touchmode_32x32;
            this.btnTeklifTopla.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.T));
            this.btnTeklifTopla.Name = "btnTeklifTopla";
            // 
            // btnSatinalmaSipariseCevir
            // 
            this.btnSatinalmaSipariseCevir.Caption = "Satınalma Siparişine Çevir";
            this.btnSatinalmaSipariseCevir.Id = 117;
            this.btnSatinalmaSipariseCevir.ImageOptions.Image = global::SenfoniYazilim.Erp.UI.Wİn.Properties.Resources.indentincrease_16x16;
            this.btnSatinalmaSipariseCevir.ImageOptions.LargeImage = global::SenfoniYazilim.Erp.UI.Wİn.Properties.Resources.indentincrease_32x32;
            this.btnSatinalmaSipariseCevir.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.C));
            this.btnSatinalmaSipariseCevir.Name = "btnSatinalmaSipariseCevir";
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 56);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonSatinalmaTalepStok,
            this.repositoryItemButtonFirma,
            this.repositoryItemButtonBelge,
            this.repositoryItemDateTalepTarihi,
            this.repositoryItemCalcTalepMiktari,
            this.repositoryItemCalcGeneral,
            this.repositoryItemCheckIsItemCanceled});
            this.grid.Size = new System.Drawing.Size(1062, 335);
            this.grid.TabIndex = 27;
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
            this.colItemId,
            this.colPurchaseDemandId,
            this.colMaterialId,
            this.colDemandedCompanyId,
            this.colPurchaseOfferItemId,
            this.colConnectedItemId,
            this.colDemandQty,
            this.colComfirmedQty,
            this.colDemandedDate,
            this.colDemandFile,
            this.colDemandDescription,
            this.colDemandItemDescription,
            this.colIsDemandItemCanceled,
            this.colIsTopDemand,
            this.colIsTopDemandExisted,
            this.colIsBlocked,
            this.colPurchaseOfferDescription,
            this.colMaterialCode,
            this.colMaterialName,
            this.colMaterialUnit,
            this.colDemandedCompanyName,
            this.colStorageStockQty,
            this.colMaxPurchaseOrderQty,
            this.colMinPurchaseOrderQty,
            this.colMaxStockQty,
            this.colMinStockQty,
            this.colCreatorName,
            this.colCreatedDate,
            this.colUpdatingName,
            this.colUpdatingDate});
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
            this.tablo.ViewCaption = "Onay Bekleyen Talep Kalemleri";
            // 
            // colItemId
            // 
            this.colItemId.Caption = "Id";
            this.colItemId.FieldName = "Id";
            this.colItemId.Name = "colItemId";
            this.colItemId.OptionsColumn.AllowEdit = false;
            this.colItemId.OptionsColumn.ShowInCustomizationForm = false;
            this.colItemId.OptionsFilter.AllowAutoFilter = false;
            this.colItemId.StatusBarAciklama = null;
            this.colItemId.StatusBarKisaYol = null;
            this.colItemId.StatusBarKisaYolAciklama = null;
            // 
            // colPurchaseDemandId
            // 
            this.colPurchaseDemandId.Caption = "PurchaseDemandId ";
            this.colPurchaseDemandId.FieldName = "PurchaseDemandId";
            this.colPurchaseDemandId.Name = "colPurchaseDemandId";
            this.colPurchaseDemandId.OptionsColumn.AllowEdit = false;
            this.colPurchaseDemandId.OptionsColumn.ShowInCustomizationForm = false;
            this.colPurchaseDemandId.StatusBarAciklama = null;
            this.colPurchaseDemandId.StatusBarKisaYol = null;
            this.colPurchaseDemandId.StatusBarKisaYolAciklama = null;
            // 
            // colMaterialId
            // 
            this.colMaterialId.Caption = "StokId";
            this.colMaterialId.FieldName = "MaterialId";
            this.colMaterialId.Name = "colMaterialId";
            this.colMaterialId.OptionsColumn.AllowEdit = false;
            this.colMaterialId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMaterialId.OptionsColumn.ShowInCustomizationForm = false;
            this.colMaterialId.StatusBarAciklama = null;
            this.colMaterialId.StatusBarKisaYol = null;
            this.colMaterialId.StatusBarKisaYolAciklama = null;
            // 
            // colDemandedCompanyId
            // 
            this.colDemandedCompanyId.Caption = "FirmaId";
            this.colDemandedCompanyId.FieldName = "DemandedCompanyId";
            this.colDemandedCompanyId.Name = "colDemandedCompanyId";
            this.colDemandedCompanyId.OptionsColumn.AllowEdit = false;
            this.colDemandedCompanyId.OptionsColumn.ShowInCustomizationForm = false;
            this.colDemandedCompanyId.OptionsFilter.AllowAutoFilter = false;
            this.colDemandedCompanyId.StatusBarAciklama = null;
            this.colDemandedCompanyId.StatusBarKisaYol = null;
            this.colDemandedCompanyId.StatusBarKisaYolAciklama = null;
            // 
            // colPurchaseOfferItemId
            // 
            this.colPurchaseOfferItemId.Caption = "Teklif Kalem No";
            this.colPurchaseOfferItemId.FieldName = "PurchaseOfferItemId";
            this.colPurchaseOfferItemId.Name = "colPurchaseOfferItemId";
            this.colPurchaseOfferItemId.OptionsColumn.AllowEdit = false;
            this.colPurchaseOfferItemId.StatusBarAciklama = null;
            this.colPurchaseOfferItemId.StatusBarKisaYol = null;
            this.colPurchaseOfferItemId.StatusBarKisaYolAciklama = null;
            this.colPurchaseOfferItemId.Visible = true;
            this.colPurchaseOfferItemId.VisibleIndex = 4;
            // 
            // colConnectedItemId
            // 
            this.colConnectedItemId.Caption = "Birleştirilmiş Talep No";
            this.colConnectedItemId.FieldName = "ConnectedItemsId";
            this.colConnectedItemId.Name = "colConnectedItemId";
            this.colConnectedItemId.OptionsColumn.AllowEdit = false;
            this.colConnectedItemId.OptionsColumn.ShowInCustomizationForm = false;
            this.colConnectedItemId.OptionsFilter.AllowAutoFilter = false;
            this.colConnectedItemId.StatusBarAciklama = null;
            this.colConnectedItemId.StatusBarKisaYol = null;
            this.colConnectedItemId.StatusBarKisaYolAciklama = null;
            this.colConnectedItemId.Visible = true;
            this.colConnectedItemId.VisibleIndex = 22;
            // 
            // colDemandQty
            // 
            this.colDemandQty.Caption = "Talep Edilen Miktar";
            this.colDemandQty.ColumnEdit = this.repositoryItemCalcGeneral;
            this.colDemandQty.FieldName = "DemandQty";
            this.colDemandQty.Name = "colDemandQty";
            this.colDemandQty.OptionsColumn.AllowEdit = false;
            this.colDemandQty.OptionsFilter.AllowAutoFilter = false;
            this.colDemandQty.StatusBarAciklama = null;
            this.colDemandQty.StatusBarKisaYol = null;
            this.colDemandQty.StatusBarKisaYolAciklama = null;
            this.colDemandQty.Visible = true;
            this.colDemandQty.VisibleIndex = 2;
            this.colDemandQty.Width = 104;
            // 
            // repositoryItemCalcGeneral
            // 
            this.repositoryItemCalcGeneral.AutoHeight = false;
            this.repositoryItemCalcGeneral.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, true, false, false, editorButtonImageOptions2)});
            this.repositoryItemCalcGeneral.DisplayFormat.FormatString = "n3";
            this.repositoryItemCalcGeneral.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcGeneral.Name = "repositoryItemCalcGeneral";
            this.repositoryItemCalcGeneral.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colComfirmedQty
            // 
            this.colComfirmedQty.Caption = "Onaylanan Miktar";
            this.colComfirmedQty.ColumnEdit = this.repositoryItemCalcTalepMiktari;
            this.colComfirmedQty.FieldName = "ComfirmedQty";
            this.colComfirmedQty.Name = "colComfirmedQty";
            this.colComfirmedQty.StatusBarAciklama = null;
            this.colComfirmedQty.StatusBarKisaYol = null;
            this.colComfirmedQty.StatusBarKisaYolAciklama = null;
            this.colComfirmedQty.Visible = true;
            this.colComfirmedQty.VisibleIndex = 7;
            // 
            // colDemandedDate
            // 
            this.colDemandedDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDemandedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDemandedDate.Caption = "Talep Tarihi";
            this.colDemandedDate.ColumnEdit = this.repositoryItemDateTalepTarihi;
            this.colDemandedDate.FieldName = "DemandedDate";
            this.colDemandedDate.Name = "colDemandedDate";
            this.colDemandedDate.OptionsColumn.AllowEdit = false;
            this.colDemandedDate.OptionsFilter.AllowAutoFilter = false;
            this.colDemandedDate.StatusBarAciklama = null;
            this.colDemandedDate.StatusBarKisaYol = null;
            this.colDemandedDate.StatusBarKisaYolAciklama = null;
            this.colDemandedDate.Visible = true;
            this.colDemandedDate.VisibleIndex = 6;
            this.colDemandedDate.Width = 90;
            // 
            // repositoryItemDateTalepTarihi
            // 
            this.repositoryItemDateTalepTarihi.AutoHeight = false;
            this.repositoryItemDateTalepTarihi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateTalepTarihi.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateTalepTarihi.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemDateTalepTarihi.Name = "repositoryItemDateTalepTarihi";
            this.repositoryItemDateTalepTarihi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colDemandFile
            // 
            this.colDemandFile.Caption = "Belge";
            this.colDemandFile.ColumnEdit = this.repositoryItemButtonBelge;
            this.colDemandFile.FieldName = "DemandFile";
            this.colDemandFile.Name = "colDemandFile";
            this.colDemandFile.OptionsColumn.AllowEdit = false;
            this.colDemandFile.OptionsFilter.AllowAutoFilter = false;
            this.colDemandFile.StatusBarAciklama = null;
            this.colDemandFile.StatusBarKisaYol = null;
            this.colDemandFile.StatusBarKisaYolAciklama = null;
            this.colDemandFile.Visible = true;
            this.colDemandFile.VisibleIndex = 9;
            this.colDemandFile.Width = 38;
            // 
            // repositoryItemButtonBelge
            // 
            this.repositoryItemButtonBelge.AutoHeight = false;
            this.repositoryItemButtonBelge.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonBelge.Name = "repositoryItemButtonBelge";
            this.repositoryItemButtonBelge.NullText = "Belge";
            this.repositoryItemButtonBelge.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colDemandDescription
            // 
            this.colDemandDescription.Caption = "Açıklama";
            this.colDemandDescription.FieldName = "DemandDescription";
            this.colDemandDescription.Name = "colDemandDescription";
            this.colDemandDescription.OptionsColumn.AllowEdit = false;
            this.colDemandDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDemandDescription.OptionsFilter.AllowAutoFilter = false;
            this.colDemandDescription.StatusBarAciklama = null;
            this.colDemandDescription.StatusBarKisaYol = null;
            this.colDemandDescription.StatusBarKisaYolAciklama = null;
            this.colDemandDescription.Visible = true;
            this.colDemandDescription.VisibleIndex = 8;
            this.colDemandDescription.Width = 165;
            // 
            // colDemandItemDescription
            // 
            this.colDemandItemDescription.Caption = "Talep Kalem Açıklaması";
            this.colDemandItemDescription.FieldName = "DemandItemDescription";
            this.colDemandItemDescription.Name = "colDemandItemDescription";
            this.colDemandItemDescription.OptionsColumn.AllowEdit = false;
            this.colDemandItemDescription.StatusBarAciklama = null;
            this.colDemandItemDescription.StatusBarKisaYol = null;
            this.colDemandItemDescription.StatusBarKisaYolAciklama = null;
            this.colDemandItemDescription.Visible = true;
            this.colDemandItemDescription.VisibleIndex = 10;
            // 
            // colIsDemandItemCanceled
            // 
            this.colIsDemandItemCanceled.Caption = "İptal Edildi";
            this.colIsDemandItemCanceled.ColumnEdit = this.repositoryItemCheckIsItemCanceled;
            this.colIsDemandItemCanceled.FieldName = "IsDemandItemCanceled";
            this.colIsDemandItemCanceled.Name = "colIsDemandItemCanceled";
            this.colIsDemandItemCanceled.OptionsColumn.AllowEdit = false;
            this.colIsDemandItemCanceled.StatusBarAciklama = null;
            this.colIsDemandItemCanceled.StatusBarKisaYol = null;
            this.colIsDemandItemCanceled.StatusBarKisaYolAciklama = null;
            this.colIsDemandItemCanceled.Visible = true;
            this.colIsDemandItemCanceled.VisibleIndex = 11;
            // 
            // repositoryItemCheckIsItemCanceled
            // 
            this.repositoryItemCheckIsItemCanceled.AutoHeight = false;
            this.repositoryItemCheckIsItemCanceled.Name = "repositoryItemCheckIsItemCanceled";
            // 
            // colIsTopDemand
            // 
            this.colIsTopDemand.Caption = "Üst Talep";
            this.colIsTopDemand.FieldName = "IsTopDeman";
            this.colIsTopDemand.Name = "colIsTopDemand";
            this.colIsTopDemand.OptionsColumn.AllowEdit = false;
            this.colIsTopDemand.StatusBarAciklama = null;
            this.colIsTopDemand.StatusBarKisaYol = null;
            this.colIsTopDemand.StatusBarKisaYolAciklama = null;
            this.colIsTopDemand.Visible = true;
            this.colIsTopDemand.VisibleIndex = 12;
            // 
            // colIsTopDemandExisted
            // 
            this.colIsTopDemandExisted.Caption = "Üst";
            this.colIsTopDemandExisted.FieldName = "IsTopDemandExisted";
            this.colIsTopDemandExisted.Name = "colIsTopDemandExisted";
            this.colIsTopDemandExisted.OptionsColumn.AllowEdit = false;
            this.colIsTopDemandExisted.OptionsColumn.ShowInCustomizationForm = false;
            this.colIsTopDemandExisted.StatusBarAciklama = null;
            this.colIsTopDemandExisted.StatusBarKisaYol = null;
            this.colIsTopDemandExisted.StatusBarKisaYolAciklama = null;
            // 
            // colIsBlocked
            // 
            this.colIsBlocked.Caption = "Bloke Edildi";
            this.colIsBlocked.FieldName = "IsBlocked";
            this.colIsBlocked.Name = "colIsBlocked";
            this.colIsBlocked.OptionsColumn.AllowEdit = false;
            this.colIsBlocked.StatusBarAciklama = null;
            this.colIsBlocked.StatusBarKisaYol = null;
            this.colIsBlocked.StatusBarKisaYolAciklama = null;
            this.colIsBlocked.Visible = true;
            this.colIsBlocked.VisibleIndex = 13;
            // 
            // colPurchaseOfferDescription
            // 
            this.colPurchaseOfferDescription.Caption = "Teklif Açıklaması";
            this.colPurchaseOfferDescription.FieldName = "PurchaseOfferDescription";
            this.colPurchaseOfferDescription.Name = "colPurchaseOfferDescription";
            this.colPurchaseOfferDescription.OptionsColumn.AllowEdit = false;
            this.colPurchaseOfferDescription.StatusBarAciklama = null;
            this.colPurchaseOfferDescription.StatusBarKisaYol = null;
            this.colPurchaseOfferDescription.StatusBarKisaYolAciklama = null;
            this.colPurchaseOfferDescription.Visible = true;
            this.colPurchaseOfferDescription.VisibleIndex = 14;
            // 
            // colMaterialCode
            // 
            this.colMaterialCode.Caption = "Stok Kodu";
            this.colMaterialCode.FieldName = "MaterialCode";
            this.colMaterialCode.Name = "colMaterialCode";
            this.colMaterialCode.OptionsColumn.AllowEdit = false;
            this.colMaterialCode.StatusBarAciklama = null;
            this.colMaterialCode.StatusBarKisaYol = null;
            this.colMaterialCode.StatusBarKisaYolAciklama = null;
            this.colMaterialCode.Visible = true;
            this.colMaterialCode.VisibleIndex = 0;
            this.colMaterialCode.Width = 86;
            // 
            // colMaterialName
            // 
            this.colMaterialName.Caption = "Stok Adı";
            this.colMaterialName.FieldName = "MaterialName";
            this.colMaterialName.Name = "colMaterialName";
            this.colMaterialName.OptionsColumn.AllowEdit = false;
            this.colMaterialName.OptionsFilter.AllowAutoFilter = false;
            this.colMaterialName.StatusBarAciklama = null;
            this.colMaterialName.StatusBarKisaYol = null;
            this.colMaterialName.StatusBarKisaYolAciklama = null;
            this.colMaterialName.Visible = true;
            this.colMaterialName.VisibleIndex = 1;
            this.colMaterialName.Width = 168;
            // 
            // colMaterialUnit
            // 
            this.colMaterialUnit.Caption = "Birim";
            this.colMaterialUnit.FieldName = "MaterialUnit";
            this.colMaterialUnit.Name = "colMaterialUnit";
            this.colMaterialUnit.OptionsColumn.AllowEdit = false;
            this.colMaterialUnit.OptionsFilter.AllowAutoFilter = false;
            this.colMaterialUnit.StatusBarAciklama = null;
            this.colMaterialUnit.StatusBarKisaYol = null;
            this.colMaterialUnit.StatusBarKisaYolAciklama = null;
            this.colMaterialUnit.Visible = true;
            this.colMaterialUnit.VisibleIndex = 5;
            this.colMaterialUnit.Width = 39;
            // 
            // colDemandedCompanyName
            // 
            this.colDemandedCompanyName.Caption = "Talep Edilen Firma";
            this.colDemandedCompanyName.FieldName = "DemandedCompanyName";
            this.colDemandedCompanyName.Name = "colDemandedCompanyName";
            this.colDemandedCompanyName.OptionsColumn.AllowEdit = false;
            this.colDemandedCompanyName.StatusBarAciklama = null;
            this.colDemandedCompanyName.StatusBarKisaYol = null;
            this.colDemandedCompanyName.StatusBarKisaYolAciklama = null;
            this.colDemandedCompanyName.Visible = true;
            this.colDemandedCompanyName.VisibleIndex = 17;
            // 
            // colStorageStockQty
            // 
            this.colStorageStockQty.Caption = "Stok Miktarı";
            this.colStorageStockQty.FieldName = "StorageStockQty";
            this.colStorageStockQty.Name = "colStorageStockQty";
            this.colStorageStockQty.OptionsColumn.AllowEdit = false;
            this.colStorageStockQty.StatusBarAciklama = null;
            this.colStorageStockQty.StatusBarKisaYol = null;
            this.colStorageStockQty.StatusBarKisaYolAciklama = null;
            this.colStorageStockQty.Visible = true;
            this.colStorageStockQty.VisibleIndex = 3;
            // 
            // colMaxPurchaseOrderQty
            // 
            this.colMaxPurchaseOrderQty.Caption = "Max.Sip.Miktarı";
            this.colMaxPurchaseOrderQty.FieldName = "MaxPurchaseOrderQty";
            this.colMaxPurchaseOrderQty.Name = "colMaxPurchaseOrderQty";
            this.colMaxPurchaseOrderQty.OptionsColumn.AllowEdit = false;
            this.colMaxPurchaseOrderQty.StatusBarAciklama = null;
            this.colMaxPurchaseOrderQty.StatusBarKisaYol = null;
            this.colMaxPurchaseOrderQty.StatusBarKisaYolAciklama = null;
            this.colMaxPurchaseOrderQty.Visible = true;
            this.colMaxPurchaseOrderQty.VisibleIndex = 16;
            this.colMaxPurchaseOrderQty.Width = 91;
            // 
            // colMinPurchaseOrderQty
            // 
            this.colMinPurchaseOrderQty.Caption = "Min.Sip.Miktarı";
            this.colMinPurchaseOrderQty.FieldName = "MinPurchaseOrderQty";
            this.colMinPurchaseOrderQty.Name = "colMinPurchaseOrderQty";
            this.colMinPurchaseOrderQty.OptionsColumn.AllowEdit = false;
            this.colMinPurchaseOrderQty.StatusBarAciklama = null;
            this.colMinPurchaseOrderQty.StatusBarKisaYol = null;
            this.colMinPurchaseOrderQty.StatusBarKisaYolAciklama = null;
            this.colMinPurchaseOrderQty.Visible = true;
            this.colMinPurchaseOrderQty.VisibleIndex = 18;
            this.colMinPurchaseOrderQty.Width = 88;
            // 
            // colMaxStockQty
            // 
            this.colMaxStockQty.Caption = "Max.Stok Mik.";
            this.colMaxStockQty.FieldName = "MaxStockQty";
            this.colMaxStockQty.Name = "colMaxStockQty";
            this.colMaxStockQty.OptionsColumn.AllowEdit = false;
            this.colMaxStockQty.StatusBarAciklama = null;
            this.colMaxStockQty.StatusBarKisaYol = null;
            this.colMaxStockQty.StatusBarKisaYolAciklama = null;
            this.colMaxStockQty.Visible = true;
            this.colMaxStockQty.VisibleIndex = 19;
            // 
            // colMinStockQty
            // 
            this.colMinStockQty.Caption = "Min.Stok Mik.";
            this.colMinStockQty.FieldName = "MinStockQty";
            this.colMinStockQty.Name = "colMinStockQty";
            this.colMinStockQty.OptionsColumn.AllowEdit = false;
            this.colMinStockQty.StatusBarAciklama = null;
            this.colMinStockQty.StatusBarKisaYol = null;
            this.colMinStockQty.StatusBarKisaYolAciklama = null;
            this.colMinStockQty.Visible = true;
            this.colMinStockQty.VisibleIndex = 20;
            // 
            // colCreatorName
            // 
            this.colCreatorName.Caption = "Kayıt Sahibi";
            this.colCreatorName.FieldName = "CreatorName";
            this.colCreatorName.Name = "colCreatorName";
            this.colCreatorName.OptionsColumn.AllowEdit = false;
            this.colCreatorName.StatusBarAciklama = null;
            this.colCreatorName.StatusBarKisaYol = null;
            this.colCreatorName.StatusBarKisaYolAciklama = null;
            this.colCreatorName.Visible = true;
            this.colCreatorName.VisibleIndex = 15;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.AppearanceCell.Options.UseTextOptions = true;
            this.colCreatedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCreatedDate.Caption = "Oluşturulma Tarihi";
            this.colCreatedDate.ColumnEdit = this.repositoryItemDateTalepTarihi;
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.OptionsColumn.AllowEdit = false;
            this.colCreatedDate.StatusBarAciklama = null;
            this.colCreatedDate.StatusBarKisaYol = null;
            this.colCreatedDate.StatusBarKisaYolAciklama = null;
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 21;
            this.colCreatedDate.Width = 105;
            // 
            // colUpdatingName
            // 
            this.colUpdatingName.Caption = "Güncelleyen";
            this.colUpdatingName.FieldName = "UpdatingName";
            this.colUpdatingName.Name = "colUpdatingName";
            this.colUpdatingName.OptionsColumn.AllowEdit = false;
            this.colUpdatingName.StatusBarAciklama = null;
            this.colUpdatingName.StatusBarKisaYol = null;
            this.colUpdatingName.StatusBarKisaYolAciklama = null;
            this.colUpdatingName.Visible = true;
            this.colUpdatingName.VisibleIndex = 23;
            // 
            // colUpdatingDate
            // 
            this.colUpdatingDate.Caption = "Güncelleme Tarihi";
            this.colUpdatingDate.FieldName = "UpdatingDate";
            this.colUpdatingDate.Name = "colUpdatingDate";
            this.colUpdatingDate.OptionsColumn.AllowEdit = false;
            this.colUpdatingDate.StatusBarAciklama = null;
            this.colUpdatingDate.StatusBarKisaYol = null;
            this.colUpdatingDate.StatusBarKisaYolAciklama = null;
            this.colUpdatingDate.Visible = true;
            this.colUpdatingDate.VisibleIndex = 24;
            // 
            // repositoryItemButtonSatinalmaTalepStok
            // 
            this.repositoryItemButtonSatinalmaTalepStok.AutoHeight = false;
            this.repositoryItemButtonSatinalmaTalepStok.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonSatinalmaTalepStok.Name = "repositoryItemButtonSatinalmaTalepStok";
            this.repositoryItemButtonSatinalmaTalepStok.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemButtonFirma
            // 
            this.repositoryItemButtonFirma.AutoHeight = false;
            this.repositoryItemButtonFirma.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonFirma.Name = "repositoryItemButtonFirma";
            this.repositoryItemButtonFirma.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemCalcTalepMiktari
            // 
            this.repositoryItemCalcTalepMiktari.AutoHeight = false;
            this.repositoryItemCalcTalepMiktari.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcTalepMiktari.DisplayFormat.FormatString = "n3";
            this.repositoryItemCalcTalepMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcTalepMiktari.EditFormat.FormatString = "n3";
            this.repositoryItemCalcTalepMiktari.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcTalepMiktari.Mask.EditMask = "n3";
            this.repositoryItemCalcTalepMiktari.Name = "repositoryItemCalcTalepMiktari";
            // 
            // PurchaseDemandItemsManagerComfirmListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 446);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "PurchaseDemandItemsManagerComfirmListForm";
            this.Text = "Onay Bekleyen Satinalma Talep Kalem Kayıtları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSatinalmaTalepKalemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTalepTarihi.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTalepTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonBelge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckIsItemCanceled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonSatinalmaTalepStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcTalepMiktari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected UserControls.Navigators.LongNavigator longNavigator;
        protected DevExpress.XtraBars.BarButtonItem btnSatinalmaSipariseCevir;
        internal DevExpress.XtraBars.BarButtonItem btnYoneticiOnay;
        public DevExpress.XtraBars.BarButtonItem btnTeklifTopla;
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colItemId;
        private UserControls.Grid.MyGridColumn colPurchaseDemandId;
        private UserControls.Grid.MyGridColumn colMaterialId;
        private UserControls.Grid.MyGridColumn colDemandedCompanyId;
        private UserControls.Grid.MyGridColumn colPurchaseOfferItemId;
        private UserControls.Grid.MyGridColumn colConnectedItemId;
        private UserControls.Grid.MyGridColumn colDemandQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcGeneral;
        private UserControls.Grid.MyGridColumn colComfirmedQty;
        private UserControls.Grid.MyGridColumn colDemandedDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateTalepTarihi;
        private UserControls.Grid.MyGridColumn colDemandFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonBelge;
        private UserControls.Grid.MyGridColumn colDemandDescription;
        private UserControls.Grid.MyGridColumn colDemandItemDescription;
        private UserControls.Grid.MyGridColumn colIsDemandItemCanceled;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckIsItemCanceled;
        private UserControls.Grid.MyGridColumn colIsTopDemand;
        private UserControls.Grid.MyGridColumn colIsTopDemandExisted;
        private UserControls.Grid.MyGridColumn colIsBlocked;
        private UserControls.Grid.MyGridColumn colPurchaseOfferDescription;
        private UserControls.Grid.MyGridColumn colMaterialCode;
        private UserControls.Grid.MyGridColumn colMaterialName;
        private UserControls.Grid.MyGridColumn colMaterialUnit;
        private UserControls.Grid.MyGridColumn colDemandedCompanyName;
        private UserControls.Grid.MyGridColumn colStorageStockQty;
        private UserControls.Grid.MyGridColumn colMaxPurchaseOrderQty;
        private UserControls.Grid.MyGridColumn colMinPurchaseOrderQty;
        private UserControls.Grid.MyGridColumn colMaxStockQty;
        private UserControls.Grid.MyGridColumn colMinStockQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonFirma;
        private UserControls.Grid.MyGridColumn colCreatorName;
        private UserControls.Grid.MyGridColumn colCreatedDate;
        private UserControls.Grid.MyGridColumn colUpdatingName;
        private UserControls.Grid.MyGridColumn colUpdatingDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonSatinalmaTalepStok;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcTalepMiktari;
    }
}
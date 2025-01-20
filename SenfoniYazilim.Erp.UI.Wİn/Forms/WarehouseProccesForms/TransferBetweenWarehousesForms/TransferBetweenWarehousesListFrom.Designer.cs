namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.TransferBetweenWarehousesForms
{
    partial class TransferBetweenWarehousesListFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferBetweenWarehousesListFrom));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKullaniciId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTransferId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTransferDepoId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTransferDepoKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTransferDepoAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTransferEdilenDepoId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTransferEdilenDepoKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTransferEdilenDepoAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBirim = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemMiktar = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colTransferTarihi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.longNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.LongNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMiktar)).BeginInit();
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
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMiktar});
            this.grid.Size = new System.Drawing.Size(1041, 289);
            this.grid.TabIndex = 18;
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
            this.colKullaniciId,
            this.colTransferId,
            this.colStokId,
            this.colStokKodu,
            this.colStokAdi,
            this.colTransferDepoId,
            this.colTransferDepoKodu,
            this.colTransferDepoAdi,
            this.colTransferEdilenDepoId,
            this.colTransferEdilenDepoKodu,
            this.colTransferEdilenDepoAdi,
            this.colBirim,
            this.colMiktar,
            this.colTransferTarihi});
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
            this.tablo.ViewCaption = "Depo Transfer Bilgileri";
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
            // colKullaniciId
            // 
            this.colKullaniciId.AppearanceCell.Options.UseTextOptions = true;
            this.colKullaniciId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKullaniciId.Caption = "KullaniciId";
            this.colKullaniciId.FieldName = "KullaniciId";
            this.colKullaniciId.Name = "colKullaniciId";
            this.colKullaniciId.OptionsColumn.AllowEdit = false;
            this.colKullaniciId.OptionsColumn.ShowInCustomizationForm = false;
            this.colKullaniciId.StatusBarAciklama = null;
            this.colKullaniciId.StatusBarKisaYol = null;
            this.colKullaniciId.StatusBarKisaYolAciklama = null;
            // 
            // colTransferId
            // 
            this.colTransferId.Caption = "TransferId";
            this.colTransferId.FieldName = "TransferId";
            this.colTransferId.Name = "colTransferId";
            this.colTransferId.OptionsColumn.AllowEdit = false;
            this.colTransferId.OptionsColumn.ShowInCustomizationForm = false;
            this.colTransferId.StatusBarAciklama = null;
            this.colTransferId.StatusBarKisaYol = null;
            this.colTransferId.StatusBarKisaYolAciklama = null;
            // 
            // colStokId
            // 
            this.colStokId.Caption = "StokId";
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
            this.colStokKodu.VisibleIndex = 0;
            this.colStokKodu.Width = 117;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adi";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.StatusBarAciklama = null;
            this.colStokAdi.StatusBarKisaYol = null;
            this.colStokAdi.StatusBarKisaYolAciklama = null;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 1;
            this.colStokAdi.Width = 328;
            // 
            // colTransferDepoId
            // 
            this.colTransferDepoId.Caption = "TransferDepoId";
            this.colTransferDepoId.FieldName = "TransferDepoId";
            this.colTransferDepoId.Name = "colTransferDepoId";
            this.colTransferDepoId.OptionsColumn.AllowEdit = false;
            this.colTransferDepoId.OptionsColumn.ShowInCustomizationForm = false;
            this.colTransferDepoId.StatusBarAciklama = null;
            this.colTransferDepoId.StatusBarKisaYol = null;
            this.colTransferDepoId.StatusBarKisaYolAciklama = null;
            // 
            // colTransferDepoKodu
            // 
            this.colTransferDepoKodu.Caption = "Transfer Depo Kodu";
            this.colTransferDepoKodu.FieldName = "TransferDepoKodu";
            this.colTransferDepoKodu.Name = "colTransferDepoKodu";
            this.colTransferDepoKodu.OptionsColumn.AllowEdit = false;
            this.colTransferDepoKodu.StatusBarAciklama = null;
            this.colTransferDepoKodu.StatusBarKisaYol = null;
            this.colTransferDepoKodu.StatusBarKisaYolAciklama = null;
            this.colTransferDepoKodu.Visible = true;
            this.colTransferDepoKodu.VisibleIndex = 4;
            this.colTransferDepoKodu.Width = 117;
            // 
            // colTransferDepoAdi
            // 
            this.colTransferDepoAdi.Caption = "Transfer Depo";
            this.colTransferDepoAdi.FieldName = "TransferDepoAdi";
            this.colTransferDepoAdi.Name = "colTransferDepoAdi";
            this.colTransferDepoAdi.OptionsColumn.AllowEdit = false;
            this.colTransferDepoAdi.StatusBarAciklama = null;
            this.colTransferDepoAdi.StatusBarKisaYol = null;
            this.colTransferDepoAdi.StatusBarKisaYolAciklama = null;
            this.colTransferDepoAdi.Visible = true;
            this.colTransferDepoAdi.VisibleIndex = 5;
            this.colTransferDepoAdi.Width = 155;
            // 
            // colTransferEdilenDepoId
            // 
            this.colTransferEdilenDepoId.Caption = "TransferEdilenDepoId";
            this.colTransferEdilenDepoId.FieldName = "TransferEdilenDepoId";
            this.colTransferEdilenDepoId.Name = "colTransferEdilenDepoId";
            this.colTransferEdilenDepoId.OptionsColumn.AllowEdit = false;
            this.colTransferEdilenDepoId.OptionsColumn.ShowInCustomizationForm = false;
            this.colTransferEdilenDepoId.StatusBarAciklama = null;
            this.colTransferEdilenDepoId.StatusBarKisaYol = null;
            this.colTransferEdilenDepoId.StatusBarKisaYolAciklama = null;
            // 
            // colTransferEdilenDepoKodu
            // 
            this.colTransferEdilenDepoKodu.Caption = "Transfer Edilen Depo Kodu";
            this.colTransferEdilenDepoKodu.FieldName = "TransferEdilenDepoKodu";
            this.colTransferEdilenDepoKodu.Name = "colTransferEdilenDepoKodu";
            this.colTransferEdilenDepoKodu.OptionsColumn.AllowEdit = false;
            this.colTransferEdilenDepoKodu.StatusBarAciklama = null;
            this.colTransferEdilenDepoKodu.StatusBarKisaYol = null;
            this.colTransferEdilenDepoKodu.StatusBarKisaYolAciklama = null;
            this.colTransferEdilenDepoKodu.Visible = true;
            this.colTransferEdilenDepoKodu.VisibleIndex = 6;
            this.colTransferEdilenDepoKodu.Width = 149;
            // 
            // colTransferEdilenDepoAdi
            // 
            this.colTransferEdilenDepoAdi.Caption = "Transfer Edilen Depo";
            this.colTransferEdilenDepoAdi.FieldName = "TransferEdilenDepoAdi";
            this.colTransferEdilenDepoAdi.Name = "colTransferEdilenDepoAdi";
            this.colTransferEdilenDepoAdi.OptionsColumn.AllowEdit = false;
            this.colTransferEdilenDepoAdi.StatusBarAciklama = null;
            this.colTransferEdilenDepoAdi.StatusBarKisaYol = null;
            this.colTransferEdilenDepoAdi.StatusBarKisaYolAciklama = null;
            this.colTransferEdilenDepoAdi.Visible = true;
            this.colTransferEdilenDepoAdi.VisibleIndex = 7;
            this.colTransferEdilenDepoAdi.Width = 111;
            // 
            // colBirim
            // 
            this.colBirim.Caption = "Birim ";
            this.colBirim.FieldName = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            this.colBirim.StatusBarAciklama = null;
            this.colBirim.StatusBarKisaYol = null;
            this.colBirim.StatusBarKisaYolAciklama = null;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 2;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar ";
            this.colMiktar.ColumnEdit = this.repositoryItemMiktar;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.StatusBarAciklama = null;
            this.colMiktar.StatusBarKisaYol = null;
            this.colMiktar.StatusBarKisaYolAciklama = null;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 3;
            this.colMiktar.Width = 142;
            // 
            // repositoryItemMiktar
            // 
            this.repositoryItemMiktar.AutoHeight = false;
            this.repositoryItemMiktar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMiktar.DisplayFormat.FormatString = "n3";
            this.repositoryItemMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemMiktar.EditFormat.FormatString = "n3";
            this.repositoryItemMiktar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemMiktar.Name = "repositoryItemMiktar";
            // 
            // colTransferTarihi
            // 
            this.colTransferTarihi.Caption = "Transfer Tarihi";
            this.colTransferTarihi.FieldName = "TransferTarihi";
            this.colTransferTarihi.Name = "colTransferTarihi";
            this.colTransferTarihi.OptionsColumn.AllowEdit = false;
            this.colTransferTarihi.StatusBarAciklama = null;
            this.colTransferTarihi.StatusBarKisaYol = null;
            this.colTransferTarihi.StatusBarKisaYolAciklama = null;
            this.colTransferTarihi.Visible = true;
            this.colTransferTarihi.VisibleIndex = 8;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 391);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1041, 24);
            this.longNavigator.TabIndex = 19;
            // 
            // DepolarArasiTransferListFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 446);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "DepolarArasiTransferListFrom";
            this.Text = "Depolar Arası Transfer Bilgileri";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKullaniciId;
        private UserControls.Grid.MyGridColumn colTransferId;
        private UserControls.Grid.MyGridColumn colStokId;
        private UserControls.Grid.MyGridColumn colStokKodu;
        private UserControls.Grid.MyGridColumn colStokAdi;
        private UserControls.Grid.MyGridColumn colTransferDepoId;
        private UserControls.Grid.MyGridColumn colTransferEdilenDepoId;
        private UserControls.Grid.MyGridColumn colBirim;
        private UserControls.Grid.MyGridColumn colMiktar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemMiktar;
        private UserControls.Grid.MyGridColumn colTransferTarihi;
        private UserControls.Grid.MyGridColumn colTransferDepoKodu;
        private UserControls.Grid.MyGridColumn colTransferDepoAdi;
        private UserControls.Grid.MyGridColumn colTransferEdilenDepoKodu;
        private UserControls.Grid.MyGridColumn colTransferEdilenDepoAdi;
        private UserControls.Navigators.LongNavigator longNavigator;
    }
}
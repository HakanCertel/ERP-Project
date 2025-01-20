namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.SatinalmaFormTables
{
    partial class SatinalmaTalepEditFormTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatinalmaTalepEditFormTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colOwnerFormId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStockId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStockCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemButtonSatinalmaTalepStok = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colStockName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUnitCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDemandQty = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCalcTalepMiktari = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colDemandedDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemDateTalepTarihi = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colDemandFile = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemButtonBelge = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDemandItemDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDemandedCompanyId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemButtonFirma = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemImageComboBoxBirim = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.UnitId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonSatinalmaTalepStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcTalepMiktari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTalepTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTalepTarihi.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonBelge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBoxBirim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYukariTasi
            // 
            this.btnYukariTasi.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnYukariTasi.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnYukariTasi.Appearance.Options.UseBackColor = true;
            this.btnYukariTasi.Appearance.Options.UseForeColor = true;
            this.btnYukariTasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYukariTasi.ImageOptions.Image")));
            this.btnYukariTasi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            // 
            // btnAsagiTasi
            // 
            this.btnAsagiTasi.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAsagiTasi.Appearance.Options.UseForeColor = true;
            this.btnAsagiTasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAsagiTasi.ImageOptions.Image")));
            this.btnAsagiTasi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.Appearance.BackColor = System.Drawing.Color.White;
            this.panelButtons.Appearance.Options.UseBackColor = true;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 24);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonSatinalmaTalepStok,
            this.repositoryItemButtonFirma,
            this.repositoryItemImageComboBoxBirim,
            this.repositoryItemButtonBelge,
            this.repositoryItemDateTalepTarihi,
            this.repositoryItemCalcTalepMiktari});
            this.grid.Size = new System.Drawing.Size(612, 203);
            this.grid.TabIndex = 23;
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
            this.colOwnerFormId,
            this.colStockId,
            this.colStockCode,
            this.colStockName,
            this.UnitId,
            this.colUnitCode,
            this.colDemandQty,
            this.colDemandedDate,
            this.colDemandFile,
            this.colDemandItemDescription,
            this.colDemandedCompanyId,
            this.colCompanyName});
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
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Satınalma Talep Kalemleri";
            // 
            // colOwnerFormId
            // 
            this.colOwnerFormId.Caption = "SatinalmaTalepId ";
            this.colOwnerFormId.FieldName = "OwnerFormId";
            this.colOwnerFormId.Name = "colOwnerFormId";
            this.colOwnerFormId.OptionsColumn.AllowEdit = false;
            this.colOwnerFormId.OptionsColumn.ShowInCustomizationForm = false;
            this.colOwnerFormId.StatusBarAciklama = null;
            this.colOwnerFormId.StatusBarKisaYol = null;
            this.colOwnerFormId.StatusBarKisaYolAciklama = null;
            // 
            // colStockId
            // 
            this.colStockId.Caption = "StokId ";
            this.colStockId.FieldName = "StockId";
            this.colStockId.Name = "colStockId";
            this.colStockId.OptionsColumn.AllowEdit = false;
            this.colStockId.OptionsColumn.ShowInCustomizationForm = false;
            this.colStockId.StatusBarAciklama = null;
            this.colStockId.StatusBarKisaYol = null;
            this.colStockId.StatusBarKisaYolAciklama = null;
            // 
            // colStockCode
            // 
            this.colStockCode.Caption = "Stok Kodu";
            this.colStockCode.ColumnEdit = this.repositoryItemButtonSatinalmaTalepStok;
            this.colStockCode.FieldName = "StockCode";
            this.colStockCode.Name = "colStockCode";
            this.colStockCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colStockCode.OptionsFilter.AllowAutoFilter = false;
            this.colStockCode.OptionsFilter.AllowFilter = false;
            this.colStockCode.StatusBarAciklama = null;
            this.colStockCode.StatusBarKisaYol = null;
            this.colStockCode.StatusBarKisaYolAciklama = null;
            this.colStockCode.Visible = true;
            this.colStockCode.VisibleIndex = 0;
            this.colStockCode.Width = 87;
            // 
            // repositoryItemButtonSatinalmaTalepStok
            // 
            this.repositoryItemButtonSatinalmaTalepStok.AutoHeight = false;
            this.repositoryItemButtonSatinalmaTalepStok.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonSatinalmaTalepStok.Name = "repositoryItemButtonSatinalmaTalepStok";
            this.repositoryItemButtonSatinalmaTalepStok.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colStockName
            // 
            this.colStockName.Caption = "Stok Adı";
            this.colStockName.FieldName = "StockName";
            this.colStockName.Name = "colStockName";
            this.colStockName.OptionsColumn.AllowEdit = false;
            this.colStockName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colStockName.OptionsFilter.AllowAutoFilter = false;
            this.colStockName.OptionsFilter.AllowFilter = false;
            this.colStockName.StatusBarAciklama = null;
            this.colStockName.StatusBarKisaYol = null;
            this.colStockName.StatusBarKisaYolAciklama = null;
            this.colStockName.Visible = true;
            this.colStockName.VisibleIndex = 1;
            this.colStockName.Width = 170;
            // 
            // colUnitCode
            // 
            this.colUnitCode.Caption = "Birim ";
            this.colUnitCode.FieldName = "UnitCode";
            this.colUnitCode.Name = "colUnitCode";
            this.colUnitCode.OptionsColumn.AllowEdit = false;
            this.colUnitCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUnitCode.OptionsFilter.AllowAutoFilter = false;
            this.colUnitCode.OptionsFilter.AllowFilter = false;
            this.colUnitCode.StatusBarAciklama = null;
            this.colUnitCode.StatusBarKisaYol = null;
            this.colUnitCode.StatusBarKisaYolAciklama = null;
            this.colUnitCode.Visible = true;
            this.colUnitCode.VisibleIndex = 2;
            this.colUnitCode.Width = 52;
            // 
            // colDemandQty
            // 
            this.colDemandQty.Caption = "Miktar";
            this.colDemandQty.ColumnEdit = this.repositoryItemCalcTalepMiktari;
            this.colDemandQty.FieldName = "DemandQty";
            this.colDemandQty.Name = "colDemandQty";
            this.colDemandQty.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDemandQty.OptionsFilter.AllowAutoFilter = false;
            this.colDemandQty.OptionsFilter.AllowFilter = false;
            this.colDemandQty.StatusBarAciklama = null;
            this.colDemandQty.StatusBarKisaYol = null;
            this.colDemandQty.StatusBarKisaYolAciklama = null;
            this.colDemandQty.Visible = true;
            this.colDemandQty.VisibleIndex = 3;
            this.colDemandQty.Width = 69;
            // 
            // repositoryItemCalcTalepMiktari
            // 
            this.repositoryItemCalcTalepMiktari.AutoHeight = false;
            this.repositoryItemCalcTalepMiktari.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcTalepMiktari.DisplayFormat.FormatString = "n2";
            this.repositoryItemCalcTalepMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcTalepMiktari.EditFormat.FormatString = "n2";
            this.repositoryItemCalcTalepMiktari.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcTalepMiktari.Name = "repositoryItemCalcTalepMiktari";
            // 
            // colDemandedDate
            // 
            this.colDemandedDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDemandedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDemandedDate.Caption = "Talep Tarihi";
            this.colDemandedDate.ColumnEdit = this.repositoryItemDateTalepTarihi;
            this.colDemandedDate.FieldName = "DemandedDate";
            this.colDemandedDate.Name = "colDemandedDate";
            this.colDemandedDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDemandedDate.OptionsFilter.AllowAutoFilter = false;
            this.colDemandedDate.OptionsFilter.AllowFilter = false;
            this.colDemandedDate.StatusBarAciklama = null;
            this.colDemandedDate.StatusBarKisaYol = null;
            this.colDemandedDate.StatusBarKisaYolAciklama = null;
            this.colDemandedDate.Visible = true;
            this.colDemandedDate.VisibleIndex = 4;
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
            // 
            // colDemandFile
            // 
            this.colDemandFile.Caption = "Belge";
            this.colDemandFile.ColumnEdit = this.repositoryItemButtonBelge;
            this.colDemandFile.FieldName = "DemandFile";
            this.colDemandFile.Name = "colDemandFile";
            this.colDemandFile.OptionsFilter.AllowAutoFilter = false;
            this.colDemandFile.OptionsFilter.AllowFilter = false;
            this.colDemandFile.StatusBarAciklama = null;
            this.colDemandFile.StatusBarKisaYol = null;
            this.colDemandFile.StatusBarKisaYolAciklama = null;
            this.colDemandFile.Visible = true;
            this.colDemandFile.VisibleIndex = 7;
            this.colDemandFile.Width = 46;
            // 
            // repositoryItemButtonBelge
            // 
            this.repositoryItemButtonBelge.AutoHeight = false;
            this.repositoryItemButtonBelge.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonBelge.Name = "repositoryItemButtonBelge";
            this.repositoryItemButtonBelge.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colDemandItemDescription
            // 
            this.colDemandItemDescription.Caption = "Açıklama";
            this.colDemandItemDescription.FieldName = "DemandItemDescription";
            this.colDemandItemDescription.Name = "colDemandItemDescription";
            this.colDemandItemDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDemandItemDescription.OptionsFilter.AllowAutoFilter = false;
            this.colDemandItemDescription.OptionsFilter.AllowFilter = false;
            this.colDemandItemDescription.StatusBarAciklama = null;
            this.colDemandItemDescription.StatusBarKisaYol = null;
            this.colDemandItemDescription.StatusBarKisaYolAciklama = null;
            this.colDemandItemDescription.Visible = true;
            this.colDemandItemDescription.VisibleIndex = 5;
            this.colDemandItemDescription.Width = 244;
            // 
            // colDemandedCompanyId
            // 
            this.colDemandedCompanyId.Caption = "TalepEdilenFirmaId";
            this.colDemandedCompanyId.FieldName = "DemandedCompanyId";
            this.colDemandedCompanyId.Name = "colDemandedCompanyId";
            this.colDemandedCompanyId.OptionsColumn.AllowEdit = false;
            this.colDemandedCompanyId.OptionsColumn.ShowInCustomizationForm = false;
            this.colDemandedCompanyId.StatusBarAciklama = null;
            this.colDemandedCompanyId.StatusBarKisaYol = null;
            this.colDemandedCompanyId.StatusBarKisaYolAciklama = null;
            // 
            // colCompanyName
            // 
            this.colCompanyName.Caption = "Firma ";
            this.colCompanyName.ColumnEdit = this.repositoryItemButtonFirma;
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCompanyName.OptionsFilter.AllowAutoFilter = false;
            this.colCompanyName.OptionsFilter.AllowFilter = false;
            this.colCompanyName.StatusBarAciklama = null;
            this.colCompanyName.StatusBarKisaYol = null;
            this.colCompanyName.StatusBarKisaYolAciklama = null;
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 6;
            this.colCompanyName.Width = 172;
            // 
            // repositoryItemButtonFirma
            // 
            this.repositoryItemButtonFirma.AutoHeight = false;
            this.repositoryItemButtonFirma.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonFirma.Name = "repositoryItemButtonFirma";
            this.repositoryItemButtonFirma.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemImageComboBoxBirim
            // 
            this.repositoryItemImageComboBoxBirim.AutoHeight = false;
            this.repositoryItemImageComboBoxBirim.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBoxBirim.Name = "repositoryItemImageComboBoxBirim";
            // 
            // UnitId
            // 
            this.UnitId.Caption = "UnitId";
            this.UnitId.FieldName = "UnitId";
            this.UnitId.Name = "UnitId";
            this.UnitId.OptionsColumn.AllowEdit = false;
            this.UnitId.OptionsColumn.ShowInCustomizationForm = false;
            this.UnitId.StatusBarAciklama = null;
            this.UnitId.StatusBarKisaYol = null;
            this.UnitId.StatusBarKisaYolAciklama = null;
            // 
            // SatinalmaTalepEditFormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "SatinalmaTalepEditFormTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonSatinalmaTalepStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcTalepMiktari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTalepTarihi.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTalepTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonBelge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBoxBirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colOwnerFormId;
        private Grid.MyGridColumn colStockId;
        private Grid.MyGridColumn colStockCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonSatinalmaTalepStok;
        private Grid.MyGridColumn colStockName;
        private Grid.MyGridColumn colUnitCode;
        private Grid.MyGridColumn colDemandQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcTalepMiktari;
        private Grid.MyGridColumn colDemandedDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateTalepTarihi;
        private Grid.MyGridColumn colDemandFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonBelge;
        private Grid.MyGridColumn colDemandItemDescription;
        private Grid.MyGridColumn colDemandedCompanyId;
        private Grid.MyGridColumn colCompanyName;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonFirma;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBoxBirim;
        private Grid.MyGridColumn UnitId;
    }
}

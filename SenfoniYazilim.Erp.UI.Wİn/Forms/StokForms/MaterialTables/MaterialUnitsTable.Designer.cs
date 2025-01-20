namespace SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms.MaterialTables
{
    partial class MaterialUnitsTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialUnitsTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUnitId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemLookUpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colConversionRate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCalcEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colMaterialUnitName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYukariTasi
            // 
            this.btnYukariTasi.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnYukariTasi.Appearance.Options.UseForeColor = true;
            this.btnYukariTasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYukariTasi.ImageOptions.Image")));
            // 
            // btnAsagiTasi
            // 
            this.btnAsagiTasi.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAsagiTasi.Appearance.Options.UseForeColor = true;
            this.btnAsagiTasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAsagiTasi.ImageOptions.Image")));
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
            this.repositoryItemCalcEdit,
            this.repositoryItemLookUpUnit});
            this.grid.Size = new System.Drawing.Size(612, 203);
            this.grid.TabIndex = 33;
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
            this.colMaterialId,
            this.colMaterialUnitName,
            this.colUnitId,
            this.colConversionRate});
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
            this.tablo.ViewCaption = "Birimler";
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
            // colMaterialId
            // 
            this.colMaterialId.Caption = "Malzeme Id";
            this.colMaterialId.FieldName = "MaterialId";
            this.colMaterialId.Name = "colMaterialId";
            this.colMaterialId.OptionsColumn.AllowEdit = false;
            this.colMaterialId.StatusBarAciklama = null;
            this.colMaterialId.StatusBarKisaYol = null;
            this.colMaterialId.StatusBarKisaYolAciklama = null;
            // 
            // colUnitId
            // 
            this.colUnitId.Caption = "Çevrim Birimi";
            this.colUnitId.ColumnEdit = this.repositoryItemLookUpUnit;
            this.colUnitId.FieldName = "UnitId";
            this.colUnitId.Name = "colUnitId";
            this.colUnitId.StatusBarAciklama = null;
            this.colUnitId.StatusBarKisaYol = null;
            this.colUnitId.StatusBarKisaYolAciklama = null;
            this.colUnitId.Visible = true;
            this.colUnitId.VisibleIndex = 1;
            // 
            // repositoryItemLookUpUnit
            // 
            this.repositoryItemLookUpUnit.AutoHeight = false;
            this.repositoryItemLookUpUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpUnit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BirimAdi", "Birim")});
            this.repositoryItemLookUpUnit.Name = "repositoryItemLookUpUnit";
            // 
            // colConversionRate
            // 
            this.colConversionRate.Caption = "Çevrim Oranı";
            this.colConversionRate.ColumnEdit = this.repositoryItemCalcEdit;
            this.colConversionRate.FieldName = "ConversionRate";
            this.colConversionRate.Name = "colConversionRate";
            this.colConversionRate.StatusBarAciklama = null;
            this.colConversionRate.StatusBarKisaYol = null;
            this.colConversionRate.StatusBarKisaYolAciklama = null;
            this.colConversionRate.Visible = true;
            this.colConversionRate.VisibleIndex = 2;
            // 
            // repositoryItemCalcEdit
            // 
            this.repositoryItemCalcEdit.AutoHeight = false;
            this.repositoryItemCalcEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryItemCalcEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEdit.EditFormat.FormatString = "{0:n2}";
            this.repositoryItemCalcEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEdit.Mask.EditMask = "n2";
            this.repositoryItemCalcEdit.Name = "repositoryItemCalcEdit";
            // 
            // colMaterialUnitName
            // 
            this.colMaterialUnitName.Caption = "Malzeme Birim";
            this.colMaterialUnitName.FieldName = "MaterialUnitName";
            this.colMaterialUnitName.Name = "colMaterialUnitName";
            this.colMaterialUnitName.OptionsColumn.AllowEdit = false;
            this.colMaterialUnitName.StatusBarAciklama = null;
            this.colMaterialUnitName.StatusBarKisaYol = null;
            this.colMaterialUnitName.StatusBarKisaYolAciklama = null;
            this.colMaterialUnitName.Visible = true;
            this.colMaterialUnitName.VisibleIndex = 0;
            // 
            // MaterialUnitsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "MaterialUnitsTable";
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colMaterialId;
        private UserControls.Grid.MyGridColumn colUnitId;
        private UserControls.Grid.MyGridColumn colConversionRate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpUnit;
        private UserControls.Grid.MyGridColumn colMaterialUnitName;
    }
}

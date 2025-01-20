namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.DefinationsForms
{
    partial class DefinationAndFeatureEditTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefinationAndFeatureEditTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colDefinationId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKod = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDefinationDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colFeatureId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colFeatureCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colFeatureDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemButtonEditFeature = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditFeature)).BeginInit();
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
            this.repositoryItemButtonEditFeature});
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
            this.colDefinationId,
            this.colKod,
            this.colDefinationDescription,
            this.colFeatureId,
            this.colFeatureCode,
            this.colFeatureDescription});
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
            this.tablo.ViewCaption = "Özellik Tanımları";
            // 
            // colDefinationId
            // 
            this.colDefinationId.Caption = "DefinationId";
            this.colDefinationId.FieldName = "DefinationId";
            this.colDefinationId.Name = "colDefinationId";
            this.colDefinationId.OptionsColumn.AllowEdit = false;
            this.colDefinationId.StatusBarAciklama = null;
            this.colDefinationId.StatusBarKisaYol = null;
            this.colDefinationId.StatusBarKisaYolAciklama = null;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Tanım Kodu";
            this.colKod.FieldName = "DefinationKod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            // 
            // colDefinationDescription
            // 
            this.colDefinationDescription.Caption = "Tanım";
            this.colDefinationDescription.FieldName = "DefinationDescription";
            this.colDefinationDescription.Name = "colDefinationDescription";
            this.colDefinationDescription.OptionsColumn.AllowEdit = false;
            this.colDefinationDescription.StatusBarAciklama = null;
            this.colDefinationDescription.StatusBarKisaYol = null;
            this.colDefinationDescription.StatusBarKisaYolAciklama = null;
            this.colDefinationDescription.Visible = true;
            this.colDefinationDescription.VisibleIndex = 0;
            // 
            // colFeatureId
            // 
            this.colFeatureId.Caption = "FeatureId";
            this.colFeatureId.FieldName = "FeatureId";
            this.colFeatureId.Name = "colFeatureId";
            this.colFeatureId.OptionsColumn.AllowEdit = false;
            this.colFeatureId.StatusBarAciklama = null;
            this.colFeatureId.StatusBarKisaYol = null;
            this.colFeatureId.StatusBarKisaYolAciklama = null;
            // 
            // colFeatureCode
            // 
            this.colFeatureCode.Caption = "Özellik Kodu";
            this.colFeatureCode.FieldName = "FeatureCode";
            this.colFeatureCode.Name = "colFeatureCode";
            this.colFeatureCode.OptionsColumn.AllowEdit = false;
            this.colFeatureCode.StatusBarAciklama = null;
            this.colFeatureCode.StatusBarKisaYol = null;
            this.colFeatureCode.StatusBarKisaYolAciklama = null;
            // 
            // colFeatureDescription
            // 
            this.colFeatureDescription.Caption = "Özellik";
            this.colFeatureDescription.ColumnEdit = this.repositoryItemButtonEditFeature;
            this.colFeatureDescription.FieldName = "FeatureDescription";
            this.colFeatureDescription.Name = "colFeatureDescription";
            this.colFeatureDescription.StatusBarAciklama = null;
            this.colFeatureDescription.StatusBarKisaYol = null;
            this.colFeatureDescription.StatusBarKisaYolAciklama = null;
            this.colFeatureDescription.Visible = true;
            this.colFeatureDescription.VisibleIndex = 1;
            // 
            // repositoryItemButtonEditFeature
            // 
            this.repositoryItemButtonEditFeature.AutoHeight = false;
            this.repositoryItemButtonEditFeature.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditFeature.Name = "repositoryItemButtonEditFeature";
            this.repositoryItemButtonEditFeature.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // DefinationAndFeatureEditTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "DefinationAndFeatureEditTable";
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditFeature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colDefinationId;
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Grid.MyGridColumn colDefinationDescription;
        private UserControls.Grid.MyGridColumn colFeatureId;
        private UserControls.Grid.MyGridColumn colFeatureCode;
        private UserControls.Grid.MyGridColumn colFeatureDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditFeature;
    }
}

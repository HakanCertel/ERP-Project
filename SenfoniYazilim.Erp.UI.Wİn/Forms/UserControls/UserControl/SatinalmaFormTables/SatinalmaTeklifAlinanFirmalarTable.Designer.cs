namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.SatinalmaFormTables
{
    partial class SatinalmaTeklifAlinanFirmalarTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatinalmaTeklifAlinanFirmalarTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colFirmaAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemButtonFirma = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonFirma)).BeginInit();
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
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(50, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonFirma});
            this.grid.Size = new System.Drawing.Size(562, 227);
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
            this.colId,
            this.colFirmaAdi});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Teklif Alınacak Firmalar";
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
            // colFirmaAdi
            // 
            this.colFirmaAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colFirmaAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFirmaAdi.Caption = "Firma";
            this.colFirmaAdi.ColumnEdit = this.repositoryItemButtonFirma;
            this.colFirmaAdi.FieldName = "FirmaAdi";
            this.colFirmaAdi.Name = "colFirmaAdi";
            this.colFirmaAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFirmaAdi.OptionsFilter.AllowAutoFilter = false;
            this.colFirmaAdi.OptionsFilter.AllowFilter = false;
            this.colFirmaAdi.StatusBarAciklama = null;
            this.colFirmaAdi.StatusBarKisaYol = null;
            this.colFirmaAdi.StatusBarKisaYolAciklama = null;
            this.colFirmaAdi.Visible = true;
            this.colFirmaAdi.VisibleIndex = 0;
            this.colFirmaAdi.Width = 366;
            // 
            // repositoryItemButtonFirma
            // 
            this.repositoryItemButtonFirma.AutoHeight = false;
            this.repositoryItemButtonFirma.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonFirma.Name = "repositoryItemButtonFirma";
            this.repositoryItemButtonFirma.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // SatinalmaTeklifAlinanFirmalarTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "SatinalmaTeklifAlinanFirmalarTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonFirma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colId;
        private Grid.MyGridColumn colFirmaAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonFirma;
    }
}

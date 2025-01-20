namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.LanguageForms
{
    partial class LanguageEditFormTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageEditFormTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colLanguageCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colLanguageDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDefaultLanguage = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCheckEditDefaultLanguage = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colIsActive = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCheckEditIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colLocalEquivalent = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditDefaultLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditIsActive)).BeginInit();
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
            this.repositoryItemCheckEditDefaultLanguage,
            this.repositoryItemCheckEditIsActive});
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
            this.colLanguageCode,
            this.colLanguageDescription,
            this.colLocalEquivalent,
            this.colDefaultLanguage,
            this.colIsActive});
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
            this.tablo.ViewCaption = "Dil Bilgileri";
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
            // colLanguageCode
            // 
            this.colLanguageCode.AppearanceCell.Options.UseTextOptions = true;
            this.colLanguageCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLanguageCode.Caption = "Kod";
            this.colLanguageCode.FieldName = "LanguageCode";
            this.colLanguageCode.Name = "colLanguageCode";
            this.colLanguageCode.StatusBarAciklama = null;
            this.colLanguageCode.StatusBarKisaYol = null;
            this.colLanguageCode.StatusBarKisaYolAciklama = null;
            this.colLanguageCode.Visible = true;
            this.colLanguageCode.VisibleIndex = 0;
            // 
            // colLanguageDescription
            // 
            this.colLanguageDescription.Caption = "Açıklama";
            this.colLanguageDescription.FieldName = "LanguageDescription";
            this.colLanguageDescription.Name = "colLanguageDescription";
            this.colLanguageDescription.StatusBarAciklama = null;
            this.colLanguageDescription.StatusBarKisaYol = null;
            this.colLanguageDescription.StatusBarKisaYolAciklama = null;
            this.colLanguageDescription.Visible = true;
            this.colLanguageDescription.VisibleIndex = 1;
            this.colLanguageDescription.Width = 127;
            // 
            // colDefaultLanguage
            // 
            this.colDefaultLanguage.Caption = "Varsayılan";
            this.colDefaultLanguage.ColumnEdit = this.repositoryItemCheckEditDefaultLanguage;
            this.colDefaultLanguage.FieldName = "DefaultLanguage";
            this.colDefaultLanguage.Name = "colDefaultLanguage";
            this.colDefaultLanguage.StatusBarAciklama = null;
            this.colDefaultLanguage.StatusBarKisaYol = null;
            this.colDefaultLanguage.StatusBarKisaYolAciklama = null;
            this.colDefaultLanguage.Visible = true;
            this.colDefaultLanguage.VisibleIndex = 2;
            // 
            // repositoryItemCheckEditDefaultLanguage
            // 
            this.repositoryItemCheckEditDefaultLanguage.AutoHeight = false;
            this.repositoryItemCheckEditDefaultLanguage.Name = "repositoryItemCheckEditDefaultLanguage";
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Kullanım Dışı";
            this.colIsActive.ColumnEdit = this.repositoryItemCheckEditIsActive;
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.StatusBarAciklama = null;
            this.colIsActive.StatusBarKisaYol = null;
            this.colIsActive.StatusBarKisaYolAciklama = null;
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 4;
            // 
            // repositoryItemCheckEditIsActive
            // 
            this.repositoryItemCheckEditIsActive.AutoHeight = false;
            this.repositoryItemCheckEditIsActive.Name = "repositoryItemCheckEditIsActive";
            // 
            // colLocalEquivalent
            // 
            this.colLocalEquivalent.Caption = "Yerel Dildeki Karşılığı";
            this.colLocalEquivalent.Name = "colLocalEquivalent";
            this.colLocalEquivalent.OptionsColumn.AllowEdit = false;
            this.colLocalEquivalent.StatusBarAciklama = null;
            this.colLocalEquivalent.StatusBarKisaYol = null;
            this.colLocalEquivalent.StatusBarKisaYolAciklama = null;
            this.colLocalEquivalent.Visible = true;
            this.colLocalEquivalent.VisibleIndex = 3;
            // 
            // LanguageEditFormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "LanguageEditFormTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditDefaultLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditIsActive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colLanguageCode;
        private UserControls.Grid.MyGridColumn colLanguageDescription;
        private UserControls.Grid.MyGridColumn colDefaultLanguage;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditDefaultLanguage;
        private UserControls.Grid.MyGridColumn colIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditIsActive;
        private UserControls.Grid.MyGridColumn colLocalEquivalent;
    }
}

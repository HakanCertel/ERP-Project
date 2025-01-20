namespace SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms.CompanyTables
{
    partial class CompanyContactTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyContactTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colContactFullName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colContactPhoneNumber = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemTextPhone = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colContactEMail = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemTextEMail = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colIsDefault = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCheckIsDefault = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckIsDefault)).BeginInit();
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
            this.repositoryItemCheckIsDefault,
            this.repositoryItemTextEMail,
            this.repositoryItemTextPhone});
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
            this.colCompanyId,
            this.colContactFullName,
            this.colContactPhoneNumber,
            this.colContactEMail,
            this.colIsDefault});
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
            this.tablo.ViewCaption = "---------------------------------------------------";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = null;
            this.colId.StatusBarKisaYolAciklama = null;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 27;
            // 
            // colCompanyId
            // 
            this.colCompanyId.Caption = "CompanyId ";
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.OptionsColumn.AllowEdit = false;
            this.colCompanyId.OptionsColumn.ShowInCustomizationForm = false;
            this.colCompanyId.StatusBarAciklama = null;
            this.colCompanyId.StatusBarKisaYol = null;
            this.colCompanyId.StatusBarKisaYolAciklama = null;
            // 
            // colContactFullName
            // 
            this.colContactFullName.Caption = "Ad ve Soyad";
            this.colContactFullName.FieldName = "ContactFullName";
            this.colContactFullName.Name = "colContactFullName";
            this.colContactFullName.StatusBarAciklama = null;
            this.colContactFullName.StatusBarKisaYol = null;
            this.colContactFullName.StatusBarKisaYolAciklama = null;
            this.colContactFullName.Visible = true;
            this.colContactFullName.VisibleIndex = 1;
            // 
            // colContactPhoneNumber
            // 
            this.colContactPhoneNumber.Caption = "Telefon Numarası";
            this.colContactPhoneNumber.ColumnEdit = this.repositoryItemTextPhone;
            this.colContactPhoneNumber.FieldName = "ContactPhoneNumber";
            this.colContactPhoneNumber.Name = "colContactPhoneNumber";
            this.colContactPhoneNumber.StatusBarAciklama = null;
            this.colContactPhoneNumber.StatusBarKisaYol = null;
            this.colContactPhoneNumber.StatusBarKisaYolAciklama = null;
            this.colContactPhoneNumber.Visible = true;
            this.colContactPhoneNumber.VisibleIndex = 2;
            this.colContactPhoneNumber.Width = 102;
            // 
            // repositoryItemTextPhone
            // 
            this.repositoryItemTextPhone.AutoHeight = false;
            this.repositoryItemTextPhone.Mask.EditMask = "0(\\(\\d\\d\\) )?\\d{1,3}-\\d\\d\\d-\\d\\d-\\d\\d";
            this.repositoryItemTextPhone.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextPhone.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextPhone.Name = "repositoryItemTextPhone";
            // 
            // colContactEMail
            // 
            this.colContactEMail.Caption = "E-Mail";
            this.colContactEMail.ColumnEdit = this.repositoryItemTextEMail;
            this.colContactEMail.FieldName = "ContactEMail";
            this.colContactEMail.Name = "colContactEMail";
            this.colContactEMail.StatusBarAciklama = null;
            this.colContactEMail.StatusBarKisaYol = null;
            this.colContactEMail.StatusBarKisaYolAciklama = null;
            this.colContactEMail.Visible = true;
            this.colContactEMail.VisibleIndex = 3;
            this.colContactEMail.Width = 111;
            // 
            // repositoryItemTextEMail
            // 
            this.repositoryItemTextEMail.AutoHeight = false;
            this.repositoryItemTextEMail.Mask.EditMask = "((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_" +
    "-])+)+";
            this.repositoryItemTextEMail.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEMail.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEMail.Name = "repositoryItemTextEMail";
            // 
            // colIsDefault
            // 
            this.colIsDefault.Caption = "Varsayılan";
            this.colIsDefault.FieldName = "IsDefault";
            this.colIsDefault.Name = "colIsDefault";
            this.colIsDefault.StatusBarAciklama = null;
            this.colIsDefault.StatusBarKisaYol = null;
            this.colIsDefault.StatusBarKisaYolAciklama = null;
            this.colIsDefault.Visible = true;
            this.colIsDefault.VisibleIndex = 4;
            // 
            // repositoryItemCheckIsDefault
            // 
            this.repositoryItemCheckIsDefault.AutoHeight = false;
            this.repositoryItemCheckIsDefault.Name = "repositoryItemCheckIsDefault";
            // 
            // CompanyContactTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "CompanyContactTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckIsDefault)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colCompanyId;
        private UserControls.Grid.MyGridColumn colContactFullName;
        private UserControls.Grid.MyGridColumn colContactPhoneNumber;
        private UserControls.Grid.MyGridColumn colContactEMail;
        private UserControls.Grid.MyGridColumn colIsDefault;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckIsDefault;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEMail;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextPhone;
    }
}

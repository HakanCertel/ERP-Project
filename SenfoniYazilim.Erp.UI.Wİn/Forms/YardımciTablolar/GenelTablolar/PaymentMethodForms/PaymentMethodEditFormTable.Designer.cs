namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.PaymentMethodForms
{
    partial class PaymentMethodEditFormTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethodEditFormTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPaymentMethodCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPaymentMethodDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colLanguageId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colLanguageDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIsActive = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCheckEditIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
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
            this.colPaymentMethodCode,
            this.colPaymentMethodDescription,
            this.colLanguageId,
            this.colLanguageDescription,
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
            this.tablo.ViewCaption = "Ödeme Yöntemleri";
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
            // colPaymentMethodCode
            // 
            this.colPaymentMethodCode.AppearanceCell.Options.UseTextOptions = true;
            this.colPaymentMethodCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPaymentMethodCode.Caption = "Kod";
            this.colPaymentMethodCode.FieldName = "PaymentMethodCode";
            this.colPaymentMethodCode.Name = "colPaymentMethodCode";
            this.colPaymentMethodCode.StatusBarAciklama = null;
            this.colPaymentMethodCode.StatusBarKisaYol = null;
            this.colPaymentMethodCode.StatusBarKisaYolAciklama = null;
            this.colPaymentMethodCode.Visible = true;
            this.colPaymentMethodCode.VisibleIndex = 0;
            // 
            // colPaymentMethodDescription
            // 
            this.colPaymentMethodDescription.Caption = "Açıklama";
            this.colPaymentMethodDescription.FieldName = "PaymentMetheodDescription";
            this.colPaymentMethodDescription.Name = "colPaymentMethodDescription";
            this.colPaymentMethodDescription.StatusBarAciklama = null;
            this.colPaymentMethodDescription.StatusBarKisaYol = null;
            this.colPaymentMethodDescription.StatusBarKisaYolAciklama = null;
            this.colPaymentMethodDescription.Visible = true;
            this.colPaymentMethodDescription.VisibleIndex = 1;
            this.colPaymentMethodDescription.Width = 277;
            // 
            // colLanguageId
            // 
            this.colLanguageId.Caption = "LanguageId ";
            this.colLanguageId.FieldName = "LanguageId";
            this.colLanguageId.Name = "colLanguageId";
            this.colLanguageId.OptionsColumn.AllowEdit = false;
            this.colLanguageId.OptionsColumn.ShowInCustomizationForm = false;
            this.colLanguageId.StatusBarAciklama = null;
            this.colLanguageId.StatusBarKisaYol = null;
            this.colLanguageId.StatusBarKisaYolAciklama = null;
            // 
            // colLanguageDescription
            // 
            this.colLanguageDescription.Caption = "Tanımlı Olduğu Dil";
            this.colLanguageDescription.FieldName = "LanguageDescription";
            this.colLanguageDescription.Name = "colLanguageDescription";
            this.colLanguageDescription.OptionsColumn.AllowEdit = false;
            this.colLanguageDescription.StatusBarAciklama = null;
            this.colLanguageDescription.StatusBarKisaYol = null;
            this.colLanguageDescription.StatusBarKisaYolAciklama = null;
            this.colLanguageDescription.Visible = true;
            this.colLanguageDescription.VisibleIndex = 2;
            this.colLanguageDescription.Width = 123;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Kullanım Dışı";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.StatusBarAciklama = null;
            this.colIsActive.StatusBarKisaYol = null;
            this.colIsActive.StatusBarKisaYolAciklama = null;
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 3;
            this.colIsActive.Width = 87;
            // 
            // repositoryItemCheckEditIsActive
            // 
            this.repositoryItemCheckEditIsActive.AutoHeight = false;
            this.repositoryItemCheckEditIsActive.Name = "repositoryItemCheckEditIsActive";
            // 
            // PaymentMethodEditFormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "PaymentMethodEditFormTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditIsActive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colPaymentMethodCode;
        private UserControls.Grid.MyGridColumn colPaymentMethodDescription;
        private UserControls.Grid.MyGridColumn colLanguageId;
        private UserControls.Grid.MyGridColumn colLanguageDescription;
        private UserControls.Grid.MyGridColumn colIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditIsActive;
    }
}

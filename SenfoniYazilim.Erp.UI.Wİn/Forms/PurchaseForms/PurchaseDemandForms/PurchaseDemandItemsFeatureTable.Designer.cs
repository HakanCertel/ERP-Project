namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaTalepForms
{
    partial class PurchaseDemandItemsFeatureTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseDemandItemsFeatureTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colBaseCard = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOwnerFormId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colFeatureDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDocument = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
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
            this.colBaseCard,
            this.colOwnerFormId,
            this.colMaterialId,
            this.colMaterialCode,
            this.colMaterialName,
            this.colFeatureDescription,
            this.colDocument});
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
            this.tablo.ViewCaption = "Talep Kalem Özellikleri";
            // 
            // colBaseCard
            // 
            this.colBaseCard.Caption = "Bağlı Form";
            this.colBaseCard.FieldName = "BaseCard";
            this.colBaseCard.Name = "colBaseCard";
            this.colBaseCard.OptionsColumn.AllowEdit = false;
            this.colBaseCard.OptionsColumn.ShowInCustomizationForm = false;
            this.colBaseCard.StatusBarAciklama = null;
            this.colBaseCard.StatusBarKisaYol = null;
            this.colBaseCard.StatusBarKisaYolAciklama = null;
            // 
            // colOwnerFormId
            // 
            this.colOwnerFormId.Caption = "OwnerFormId";
            this.colOwnerFormId.FieldName = "OwnerFormId";
            this.colOwnerFormId.Name = "colOwnerFormId";
            this.colOwnerFormId.OptionsColumn.AllowEdit = false;
            this.colOwnerFormId.OptionsColumn.ShowInCustomizationForm = false;
            this.colOwnerFormId.StatusBarAciklama = null;
            this.colOwnerFormId.StatusBarKisaYol = null;
            this.colOwnerFormId.StatusBarKisaYolAciklama = null;
            this.colOwnerFormId.Visible = true;
            this.colOwnerFormId.VisibleIndex = 0;
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
            this.colMaterialId.Visible = true;
            this.colMaterialId.VisibleIndex = 1;
            // 
            // colMaterialCode
            // 
            this.colMaterialCode.Caption = "Malzeme Kodu";
            this.colMaterialCode.FieldName = "MaterialCode";
            this.colMaterialCode.Name = "colMaterialCode";
            this.colMaterialCode.OptionsColumn.AllowEdit = false;
            this.colMaterialCode.StatusBarAciklama = null;
            this.colMaterialCode.StatusBarKisaYol = null;
            this.colMaterialCode.StatusBarKisaYolAciklama = null;
            this.colMaterialCode.Visible = true;
            this.colMaterialCode.VisibleIndex = 2;
            // 
            // colMaterialName
            // 
            this.colMaterialName.Caption = "Malzeme Adı";
            this.colMaterialName.FieldName = "MaterialName";
            this.colMaterialName.Name = "colMaterialName";
            this.colMaterialName.OptionsColumn.AllowEdit = false;
            this.colMaterialName.StatusBarAciklama = null;
            this.colMaterialName.StatusBarKisaYol = null;
            this.colMaterialName.StatusBarKisaYolAciklama = null;
            this.colMaterialName.Visible = true;
            this.colMaterialName.VisibleIndex = 3;
            // 
            // colFeatureDescription
            // 
            this.colFeatureDescription.Caption = "Malzeme Özellikleri";
            this.colFeatureDescription.FieldName = "FeatureDescription";
            this.colFeatureDescription.Name = "colFeatureDescription";
            this.colFeatureDescription.StatusBarAciklama = null;
            this.colFeatureDescription.StatusBarKisaYol = null;
            this.colFeatureDescription.StatusBarKisaYolAciklama = null;
            this.colFeatureDescription.Visible = true;
            this.colFeatureDescription.VisibleIndex = 4;
            // 
            // colDocument
            // 
            this.colDocument.Caption = "Belge";
            this.colDocument.FieldName = "Document";
            this.colDocument.Name = "colDocument";
            this.colDocument.StatusBarAciklama = null;
            this.colDocument.StatusBarKisaYol = null;
            this.colDocument.StatusBarKisaYolAciklama = null;
            this.colDocument.Visible = true;
            this.colDocument.VisibleIndex = 5;
            // 
            // PurchaseDemandItemsFeatureTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "PurchaseDemandItemsFeatureTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colBaseCard;
        private UserControls.Grid.MyGridColumn colOwnerFormId;
        private UserControls.Grid.MyGridColumn colMaterialId;
        private UserControls.Grid.MyGridColumn colMaterialCode;
        private UserControls.Grid.MyGridColumn colMaterialName;
        private UserControls.Grid.MyGridColumn colFeatureDescription;
        private UserControls.Grid.MyGridColumn colDocument;
    }
}

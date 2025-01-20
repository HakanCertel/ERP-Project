namespace SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms.CompanyTables
{
    partial class CompanyPriceListTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyPriceListTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyPriceListsId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyPriceListCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemButtonPriceList = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCompanyPriceListName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyPriceListCurrencyName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyPriceListValidityStart = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyPriceListValidityEnd = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyPriceListDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIsDefault = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCheckIsDefault = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonPriceList)).BeginInit();
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
            this.repositoryItemButtonPriceList,
            this.repositoryItemCheckIsDefault});
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
            this.colCompanyPriceListsId,
            this.colCompanyPriceListCode,
            this.colCompanyPriceListName,
            this.colCompanyPriceListCurrencyName,
            this.colCompanyPriceListValidityStart,
            this.colCompanyPriceListValidityEnd,
            this.colCompanyPriceListDescription,
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
            this.tablo.ViewCaption = "Fiyat Listeleri";
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
            // 
            // colCompanyId
            // 
            this.colCompanyId.Caption = "FirmaId";
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.OptionsColumn.AllowEdit = false;
            this.colCompanyId.OptionsColumn.ShowInCustomizationForm = false;
            this.colCompanyId.StatusBarAciklama = null;
            this.colCompanyId.StatusBarKisaYol = null;
            this.colCompanyId.StatusBarKisaYolAciklama = null;
            this.colCompanyId.Visible = true;
            this.colCompanyId.VisibleIndex = 2;
            // 
            // colCompanyPriceListsId
            // 
            this.colCompanyPriceListsId.Caption = "CompanyPriceListsId ";
            this.colCompanyPriceListsId.FieldName = "CompanyPriceListsId";
            this.colCompanyPriceListsId.Name = "colCompanyPriceListsId";
            this.colCompanyPriceListsId.OptionsColumn.AllowEdit = false;
            this.colCompanyPriceListsId.OptionsColumn.ShowInCustomizationForm = false;
            this.colCompanyPriceListsId.StatusBarAciklama = null;
            this.colCompanyPriceListsId.StatusBarKisaYol = null;
            this.colCompanyPriceListsId.StatusBarKisaYolAciklama = null;
            // 
            // colCompanyPriceListCode
            // 
            this.colCompanyPriceListCode.AppearanceCell.Options.UseTextOptions = true;
            this.colCompanyPriceListCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCompanyPriceListCode.Caption = "Kod";
            this.colCompanyPriceListCode.ColumnEdit = this.repositoryItemButtonPriceList;
            this.colCompanyPriceListCode.FieldName = "CompanyPriceListCode";
            this.colCompanyPriceListCode.Name = "colCompanyPriceListCode";
            this.colCompanyPriceListCode.StatusBarAciklama = null;
            this.colCompanyPriceListCode.StatusBarKisaYol = null;
            this.colCompanyPriceListCode.StatusBarKisaYolAciklama = null;
            this.colCompanyPriceListCode.Visible = true;
            this.colCompanyPriceListCode.VisibleIndex = 1;
            // 
            // repositoryItemButtonPriceList
            // 
            this.repositoryItemButtonPriceList.AutoHeight = false;
            this.repositoryItemButtonPriceList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonPriceList.Name = "repositoryItemButtonPriceList";
            this.repositoryItemButtonPriceList.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colCompanyPriceListName
            // 
            this.colCompanyPriceListName.Caption = "Fiyat Listesi Adı";
            this.colCompanyPriceListName.FieldName = "CompanyPriceListName";
            this.colCompanyPriceListName.Name = "colCompanyPriceListName";
            this.colCompanyPriceListName.OptionsColumn.AllowEdit = false;
            this.colCompanyPriceListName.StatusBarAciklama = null;
            this.colCompanyPriceListName.StatusBarKisaYol = null;
            this.colCompanyPriceListName.StatusBarKisaYolAciklama = null;
            this.colCompanyPriceListName.Visible = true;
            this.colCompanyPriceListName.VisibleIndex = 3;
            this.colCompanyPriceListName.Width = 121;
            // 
            // colCompanyPriceListCurrencyName
            // 
            this.colCompanyPriceListCurrencyName.Caption = "Döviz Cinsi";
            this.colCompanyPriceListCurrencyName.FieldName = "CompanyPriceListCurrencyName";
            this.colCompanyPriceListCurrencyName.Name = "colCompanyPriceListCurrencyName";
            this.colCompanyPriceListCurrencyName.OptionsColumn.AllowEdit = false;
            this.colCompanyPriceListCurrencyName.StatusBarAciklama = null;
            this.colCompanyPriceListCurrencyName.StatusBarKisaYol = null;
            this.colCompanyPriceListCurrencyName.StatusBarKisaYolAciklama = null;
            this.colCompanyPriceListCurrencyName.Visible = true;
            this.colCompanyPriceListCurrencyName.VisibleIndex = 4;
            // 
            // colCompanyPriceListValidityStart
            // 
            this.colCompanyPriceListValidityStart.Caption = "Geçerlilik Başlangıç";
            this.colCompanyPriceListValidityStart.FieldName = "CompanyPriceListValidityStart";
            this.colCompanyPriceListValidityStart.Name = "colCompanyPriceListValidityStart";
            this.colCompanyPriceListValidityStart.OptionsColumn.AllowEdit = false;
            this.colCompanyPriceListValidityStart.StatusBarAciklama = null;
            this.colCompanyPriceListValidityStart.StatusBarKisaYol = null;
            this.colCompanyPriceListValidityStart.StatusBarKisaYolAciklama = null;
            this.colCompanyPriceListValidityStart.Visible = true;
            this.colCompanyPriceListValidityStart.VisibleIndex = 7;
            // 
            // colCompanyPriceListValidityEnd
            // 
            this.colCompanyPriceListValidityEnd.Caption = "Geçerlilik Bitiş";
            this.colCompanyPriceListValidityEnd.FieldName = "CompanyPriceListValidityEnd";
            this.colCompanyPriceListValidityEnd.Name = "colCompanyPriceListValidityEnd";
            this.colCompanyPriceListValidityEnd.OptionsColumn.AllowEdit = false;
            this.colCompanyPriceListValidityEnd.StatusBarAciklama = null;
            this.colCompanyPriceListValidityEnd.StatusBarKisaYol = null;
            this.colCompanyPriceListValidityEnd.StatusBarKisaYolAciklama = null;
            this.colCompanyPriceListValidityEnd.Visible = true;
            this.colCompanyPriceListValidityEnd.VisibleIndex = 6;
            // 
            // colCompanyPriceListDescription
            // 
            this.colCompanyPriceListDescription.Caption = "Açıklama";
            this.colCompanyPriceListDescription.FieldName = "CompanyPriceListDescription";
            this.colCompanyPriceListDescription.Name = "colCompanyPriceListDescription";
            this.colCompanyPriceListDescription.OptionsColumn.AllowEdit = false;
            this.colCompanyPriceListDescription.StatusBarAciklama = null;
            this.colCompanyPriceListDescription.StatusBarKisaYol = null;
            this.colCompanyPriceListDescription.StatusBarKisaYolAciklama = null;
            this.colCompanyPriceListDescription.Visible = true;
            this.colCompanyPriceListDescription.VisibleIndex = 5;
            this.colCompanyPriceListDescription.Width = 258;
            // 
            // colIsDefault
            // 
            this.colIsDefault.Caption = "Varsayılan";
            this.colIsDefault.ColumnEdit = this.repositoryItemCheckIsDefault;
            this.colIsDefault.FieldName = "IsDefault";
            this.colIsDefault.Name = "colIsDefault";
            this.colIsDefault.StatusBarAciklama = null;
            this.colIsDefault.StatusBarKisaYol = null;
            this.colIsDefault.StatusBarKisaYolAciklama = null;
            this.colIsDefault.Visible = true;
            this.colIsDefault.VisibleIndex = 0;
            this.colIsDefault.Width = 67;
            // 
            // repositoryItemCheckIsDefault
            // 
            this.repositoryItemCheckIsDefault.AutoHeight = false;
            this.repositoryItemCheckIsDefault.Name = "repositoryItemCheckIsDefault";
            // 
            // CompanyPriceListTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "CompanyPriceListTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonPriceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckIsDefault)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colCompanyPriceListCode;
        private UserControls.Grid.MyGridColumn colCompanyPriceListName;
        private UserControls.Grid.MyGridColumn colCompanyPriceListCurrencyName;
        private UserControls.Grid.MyGridColumn colCompanyPriceListDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonPriceList;
        private UserControls.Grid.MyGridColumn colCompanyId;
        private UserControls.Grid.MyGridColumn colCompanyPriceListsId;
        private UserControls.Grid.MyGridColumn colCompanyPriceListValidityStart;
        private UserControls.Grid.MyGridColumn colCompanyPriceListValidityEnd;
        private UserControls.Grid.MyGridColumn colIsDefault;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckIsDefault;
    }
}

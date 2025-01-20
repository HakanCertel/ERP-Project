namespace SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms.CompanyTables
{
    partial class AddressItemsTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressItemsTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colIsDefault = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCheckIsDefault = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colIsBranch = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCheckIsSube = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colBranchName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colEntireAddress = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCountryId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCountryName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemButtonCountry = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCityId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCityName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemButtonIlAdi = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCountyId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCountyName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemButtonIlceAdi = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colPostCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDistrict = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStreet = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colNumber = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBuild = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colApartment = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOpenAddress = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckIsDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckIsSube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonIlAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonIlceAdi)).BeginInit();
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
            this.repositoryItemButtonCountry,
            this.repositoryItemButtonIlAdi,
            this.repositoryItemButtonIlceAdi,
            this.repositoryItemCheckIsDefault,
            this.repositoryItemCheckIsSube});
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
            this.colIsDefault,
            this.colIsBranch,
            this.colBranchName,
            this.colEntireAddress,
            this.colCompanyId,
            this.colCountryId,
            this.colCountryName,
            this.colCityId,
            this.colCityName,
            this.colCountyId,
            this.colCountyName,
            this.colPostCode,
            this.colDistrict,
            this.colStreet,
            this.colNumber,
            this.colBuild,
            this.colApartment,
            this.colOpenAddress});
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
            this.tablo.ViewCaption = "Adres Bilgileri";
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
            this.colIsDefault.Width = 60;
            // 
            // repositoryItemCheckIsDefault
            // 
            this.repositoryItemCheckIsDefault.AutoHeight = false;
            this.repositoryItemCheckIsDefault.Name = "repositoryItemCheckIsDefault";
            // 
            // colIsBranch
            // 
            this.colIsBranch.Caption = "Şube Mi";
            this.colIsBranch.ColumnEdit = this.repositoryItemCheckIsSube;
            this.colIsBranch.FieldName = "IsBranch";
            this.colIsBranch.Name = "colIsBranch";
            this.colIsBranch.StatusBarAciklama = null;
            this.colIsBranch.StatusBarKisaYol = null;
            this.colIsBranch.StatusBarKisaYolAciklama = null;
            this.colIsBranch.Visible = true;
            this.colIsBranch.VisibleIndex = 1;
            this.colIsBranch.Width = 49;
            // 
            // repositoryItemCheckIsSube
            // 
            this.repositoryItemCheckIsSube.AutoHeight = false;
            this.repositoryItemCheckIsSube.Name = "repositoryItemCheckIsSube";
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "Şube Adı";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.OptionsColumn.AllowEdit = false;
            this.colBranchName.StatusBarAciklama = null;
            this.colBranchName.StatusBarKisaYol = null;
            this.colBranchName.StatusBarKisaYolAciklama = null;
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 2;
            this.colBranchName.Width = 141;
            // 
            // colEntireAddress
            // 
            this.colEntireAddress.Caption = "Adres Bilgisi";
            this.colEntireAddress.FieldName = "EntireAddress";
            this.colEntireAddress.Name = "colEntireAddress";
            this.colEntireAddress.OptionsColumn.AllowEdit = false;
            this.colEntireAddress.StatusBarAciklama = null;
            this.colEntireAddress.StatusBarKisaYol = null;
            this.colEntireAddress.StatusBarKisaYolAciklama = null;
            this.colEntireAddress.Visible = true;
            this.colEntireAddress.VisibleIndex = 3;
            this.colEntireAddress.Width = 326;
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
            // 
            // colCountryId
            // 
            this.colCountryId.Caption = "UlkeId";
            this.colCountryId.FieldName = "CountryId";
            this.colCountryId.Name = "colCountryId";
            this.colCountryId.OptionsColumn.ShowInCustomizationForm = false;
            this.colCountryId.StatusBarAciklama = null;
            this.colCountryId.StatusBarKisaYol = null;
            this.colCountryId.StatusBarKisaYolAciklama = null;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "Ülke";
            this.colCountryName.ColumnEdit = this.repositoryItemButtonCountry;
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.StatusBarAciklama = null;
            this.colCountryName.StatusBarKisaYol = null;
            this.colCountryName.StatusBarKisaYolAciklama = null;
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 4;
            this.colCountryName.Width = 93;
            // 
            // repositoryItemButtonCountry
            // 
            this.repositoryItemButtonCountry.AutoHeight = false;
            this.repositoryItemButtonCountry.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonCountry.Name = "repositoryItemButtonCountry";
            this.repositoryItemButtonCountry.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colCityId
            // 
            this.colCityId.Caption = "ilId ";
            this.colCityId.FieldName = "CityId";
            this.colCityId.Name = "colCityId";
            this.colCityId.OptionsColumn.ShowInCustomizationForm = false;
            this.colCityId.StatusBarAciklama = null;
            this.colCityId.StatusBarKisaYol = null;
            this.colCityId.StatusBarKisaYolAciklama = null;
            // 
            // colCityName
            // 
            this.colCityName.Caption = "İl";
            this.colCityName.ColumnEdit = this.repositoryItemButtonIlAdi;
            this.colCityName.FieldName = "CityName";
            this.colCityName.Name = "colCityName";
            this.colCityName.StatusBarAciklama = null;
            this.colCityName.StatusBarKisaYol = null;
            this.colCityName.StatusBarKisaYolAciklama = null;
            this.colCityName.Visible = true;
            this.colCityName.VisibleIndex = 5;
            this.colCityName.Width = 99;
            // 
            // repositoryItemButtonIlAdi
            // 
            this.repositoryItemButtonIlAdi.AutoHeight = false;
            this.repositoryItemButtonIlAdi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonIlAdi.Name = "repositoryItemButtonIlAdi";
            this.repositoryItemButtonIlAdi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colCountyId
            // 
            this.colCountyId.Caption = "IlceId ";
            this.colCountyId.FieldName = "CountyId";
            this.colCountyId.Name = "colCountyId";
            this.colCountyId.OptionsColumn.ShowInCustomizationForm = false;
            this.colCountyId.StatusBarAciklama = null;
            this.colCountyId.StatusBarKisaYol = null;
            this.colCountyId.StatusBarKisaYolAciklama = null;
            // 
            // colCountyName
            // 
            this.colCountyName.Caption = "İlçe";
            this.colCountyName.ColumnEdit = this.repositoryItemButtonIlceAdi;
            this.colCountyName.FieldName = "CountyName";
            this.colCountyName.Name = "colCountyName";
            this.colCountyName.StatusBarAciklama = null;
            this.colCountyName.StatusBarKisaYol = null;
            this.colCountyName.StatusBarKisaYolAciklama = null;
            this.colCountyName.Visible = true;
            this.colCountyName.VisibleIndex = 6;
            this.colCountyName.Width = 104;
            // 
            // repositoryItemButtonIlceAdi
            // 
            this.repositoryItemButtonIlceAdi.AutoHeight = false;
            this.repositoryItemButtonIlceAdi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonIlceAdi.Name = "repositoryItemButtonIlceAdi";
            this.repositoryItemButtonIlceAdi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colPostCode
            // 
            this.colPostCode.Caption = "Posta Kodu";
            this.colPostCode.FieldName = "PostCode";
            this.colPostCode.Name = "colPostCode";
            this.colPostCode.StatusBarAciklama = null;
            this.colPostCode.StatusBarKisaYol = null;
            this.colPostCode.StatusBarKisaYolAciklama = null;
            this.colPostCode.Visible = true;
            this.colPostCode.VisibleIndex = 7;
            this.colPostCode.Width = 102;
            // 
            // colDistrict
            // 
            this.colDistrict.Caption = "Mahalle ";
            this.colDistrict.FieldName = "District";
            this.colDistrict.Name = "colDistrict";
            this.colDistrict.StatusBarAciklama = null;
            this.colDistrict.StatusBarKisaYol = null;
            this.colDistrict.StatusBarKisaYolAciklama = null;
            this.colDistrict.Visible = true;
            this.colDistrict.VisibleIndex = 8;
            this.colDistrict.Width = 223;
            // 
            // colStreet
            // 
            this.colStreet.Caption = "Sokak ";
            this.colStreet.FieldName = "Street";
            this.colStreet.Name = "colStreet";
            this.colStreet.StatusBarAciklama = null;
            this.colStreet.StatusBarKisaYol = null;
            this.colStreet.StatusBarKisaYolAciklama = null;
            this.colStreet.Visible = true;
            this.colStreet.VisibleIndex = 9;
            this.colStreet.Width = 146;
            // 
            // colNumber
            // 
            this.colNumber.Caption = "Numara ";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.StatusBarAciklama = null;
            this.colNumber.StatusBarKisaYol = null;
            this.colNumber.StatusBarKisaYolAciklama = null;
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 10;
            this.colNumber.Width = 89;
            // 
            // colBuild
            // 
            this.colBuild.Caption = "Bina ";
            this.colBuild.FieldName = "Build";
            this.colBuild.Name = "colBuild";
            this.colBuild.StatusBarAciklama = null;
            this.colBuild.StatusBarKisaYol = null;
            this.colBuild.StatusBarKisaYolAciklama = null;
            this.colBuild.Visible = true;
            this.colBuild.VisibleIndex = 11;
            this.colBuild.Width = 134;
            // 
            // colApartment
            // 
            this.colApartment.Caption = "Daire";
            this.colApartment.FieldName = "Apartment";
            this.colApartment.Name = "colApartment";
            this.colApartment.StatusBarAciklama = null;
            this.colApartment.StatusBarKisaYol = null;
            this.colApartment.StatusBarKisaYolAciklama = null;
            this.colApartment.Visible = true;
            this.colApartment.VisibleIndex = 12;
            this.colApartment.Width = 60;
            // 
            // colOpenAddress
            // 
            this.colOpenAddress.Caption = "Açık Adres";
            this.colOpenAddress.FieldName = "OpenAddress";
            this.colOpenAddress.Name = "colOpenAddress";
            this.colOpenAddress.StatusBarAciklama = null;
            this.colOpenAddress.StatusBarKisaYol = null;
            this.colOpenAddress.StatusBarKisaYolAciklama = null;
            this.colOpenAddress.Visible = true;
            this.colOpenAddress.VisibleIndex = 13;
            this.colOpenAddress.Width = 300;
            // 
            // AddressItemsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "AddressItemsTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckIsDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckIsSube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonIlAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonIlceAdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colIsDefault;
        private UserControls.Grid.MyGridColumn colIsBranch;
        private UserControls.Grid.MyGridColumn colBranchName;
        private UserControls.Grid.MyGridColumn colEntireAddress;
        private UserControls.Grid.MyGridColumn colCompanyId;
        private UserControls.Grid.MyGridColumn colCountryId;
        private UserControls.Grid.MyGridColumn colCountryName;
        private UserControls.Grid.MyGridColumn colCityId;
        private UserControls.Grid.MyGridColumn colCityName;
        private UserControls.Grid.MyGridColumn colCountyId;
        private UserControls.Grid.MyGridColumn colCountyName;
        private UserControls.Grid.MyGridColumn colPostCode;
        private UserControls.Grid.MyGridColumn colDistrict;
        private UserControls.Grid.MyGridColumn colStreet;
        private UserControls.Grid.MyGridColumn colNumber;
        private UserControls.Grid.MyGridColumn colBuild;
        private UserControls.Grid.MyGridColumn colApartment;
        private UserControls.Grid.MyGridColumn colOpenAddress;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckIsDefault;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckIsSube;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonCountry;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonIlAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonIlceAdi;
    }
}

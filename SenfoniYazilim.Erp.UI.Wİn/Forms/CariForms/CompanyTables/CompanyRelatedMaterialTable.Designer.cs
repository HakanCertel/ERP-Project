namespace SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms.CompanyTables
{
    partial class CompanyRelatedMaterialTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyRelatedMaterialTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyMaterialUnitId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPackagingId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMinOrderQty = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaxOrderQty = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colContractId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUnitPrice = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCalcGeneral = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colDiscountRate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDeliveryDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemDateDeliveryDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBarcodeNumber = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIsActive = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCheckIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colMaterialCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemButtonMaterialCode = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colMaterialName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialUnit = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyMaterialCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyMaterialName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyMaterialUnitName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemComboBoxUnit = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colPackagingDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemComboBoxPackaging = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateDeliveryDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateDeliveryDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonMaterialCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxPackaging)).BeginInit();
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
            this.repositoryItemCalcGeneral,
            this.repositoryItemButtonMaterialCode,
            this.repositoryItemComboBoxUnit,
            this.repositoryItemComboBoxPackaging,
            this.repositoryItemDateDeliveryDate,
            this.repositoryItemCheckIsActive});
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
            this.colMaterialId,
            this.colCompanyId,
            this.colCompanyMaterialUnitId,
            this.colPackagingId,
            this.colMinOrderQty,
            this.colMaxOrderQty,
            this.colContractId,
            this.colUnitPrice,
            this.colDiscountRate,
            this.colDeliveryDate,
            this.colBarcodeNumber,
            this.colIsActive,
            this.colMaterialCode,
            this.colMaterialName,
            this.colMaterialUnit,
            this.colCompanyMaterialCode,
            this.colCompanyMaterialName,
            this.colCompanyMaterialUnitName,
            this.colPackagingDescription});
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
            this.tablo.ViewCaption = "İşlem Gören Malzemeler Listesi";
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
            this.colMaterialId.Caption = "MalzemeId";
            this.colMaterialId.FieldName = "MaterialId";
            this.colMaterialId.Name = "colMaterialId";
            this.colMaterialId.OptionsColumn.AllowEdit = false;
            this.colMaterialId.StatusBarAciklama = null;
            this.colMaterialId.StatusBarKisaYol = null;
            this.colMaterialId.StatusBarKisaYolAciklama = null;
            this.colMaterialId.Visible = true;
            this.colMaterialId.VisibleIndex = 0;
            // 
            // colCompanyId
            // 
            this.colCompanyId.Caption = "FirmaId";
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.OptionsColumn.AllowEdit = false;
            this.colCompanyId.StatusBarAciklama = null;
            this.colCompanyId.StatusBarKisaYol = null;
            this.colCompanyId.StatusBarKisaYolAciklama = null;
            this.colCompanyId.Visible = true;
            this.colCompanyId.VisibleIndex = 4;
            // 
            // colCompanyMaterialUnitId
            // 
            this.colCompanyMaterialUnitId.Caption = "FirmaMalzemeBirimId";
            this.colCompanyMaterialUnitId.FieldName = "CompanyMaterialUnitId";
            this.colCompanyMaterialUnitId.Name = "colCompanyMaterialUnitId";
            this.colCompanyMaterialUnitId.OptionsColumn.AllowEdit = false;
            this.colCompanyMaterialUnitId.StatusBarAciklama = null;
            this.colCompanyMaterialUnitId.StatusBarKisaYol = null;
            this.colCompanyMaterialUnitId.StatusBarKisaYolAciklama = null;
            this.colCompanyMaterialUnitId.Visible = true;
            this.colCompanyMaterialUnitId.VisibleIndex = 7;
            // 
            // colPackagingId
            // 
            this.colPackagingId.Caption = "AmbalajId";
            this.colPackagingId.FieldName = "PackagingId";
            this.colPackagingId.Name = "colPackagingId";
            this.colPackagingId.OptionsColumn.AllowEdit = false;
            this.colPackagingId.StatusBarAciklama = null;
            this.colPackagingId.StatusBarKisaYol = null;
            this.colPackagingId.StatusBarKisaYolAciklama = null;
            this.colPackagingId.Visible = true;
            this.colPackagingId.VisibleIndex = 9;
            // 
            // colMinOrderQty
            // 
            this.colMinOrderQty.Caption = "Min.Sipariş Mik.";
            this.colMinOrderQty.FieldName = "MinOrderQty";
            this.colMinOrderQty.Name = "colMinOrderQty";
            this.colMinOrderQty.StatusBarAciklama = null;
            this.colMinOrderQty.StatusBarKisaYol = null;
            this.colMinOrderQty.StatusBarKisaYolAciklama = null;
            this.colMinOrderQty.Visible = true;
            this.colMinOrderQty.VisibleIndex = 11;
            // 
            // colMaxOrderQty
            // 
            this.colMaxOrderQty.Caption = "Max. Sipariş Mik.";
            this.colMaxOrderQty.FieldName = "MaxOrderQty";
            this.colMaxOrderQty.Name = "colMaxOrderQty";
            this.colMaxOrderQty.StatusBarAciklama = null;
            this.colMaxOrderQty.StatusBarKisaYol = null;
            this.colMaxOrderQty.StatusBarKisaYolAciklama = null;
            this.colMaxOrderQty.Visible = true;
            this.colMaxOrderQty.VisibleIndex = 12;
            // 
            // colContractId
            // 
            this.colContractId.Caption = "SözleşmeId";
            this.colContractId.FieldName = "ContractId";
            this.colContractId.Name = "colContractId";
            this.colContractId.OptionsColumn.AllowEdit = false;
            this.colContractId.StatusBarAciklama = null;
            this.colContractId.StatusBarKisaYol = null;
            this.colContractId.StatusBarKisaYolAciklama = null;
            this.colContractId.Visible = true;
            this.colContractId.VisibleIndex = 13;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "Birim Fiyat";
            this.colUnitPrice.ColumnEdit = this.repositoryItemCalcGeneral;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.StatusBarAciklama = null;
            this.colUnitPrice.StatusBarKisaYol = null;
            this.colUnitPrice.StatusBarKisaYolAciklama = null;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 14;
            // 
            // repositoryItemCalcGeneral
            // 
            this.repositoryItemCalcGeneral.AutoHeight = false;
            this.repositoryItemCalcGeneral.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcGeneral.DisplayFormat.FormatString = "n3";
            this.repositoryItemCalcGeneral.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcGeneral.EditFormat.FormatString = "n3";
            this.repositoryItemCalcGeneral.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcGeneral.Name = "repositoryItemCalcGeneral";
            // 
            // colDiscountRate
            // 
            this.colDiscountRate.Caption = "İskonto Oranı";
            this.colDiscountRate.ColumnEdit = this.repositoryItemCalcGeneral;
            this.colDiscountRate.FieldName = "DiscountRate";
            this.colDiscountRate.Name = "colDiscountRate";
            this.colDiscountRate.StatusBarAciklama = null;
            this.colDiscountRate.StatusBarKisaYol = null;
            this.colDiscountRate.StatusBarKisaYolAciklama = null;
            this.colDiscountRate.Visible = true;
            this.colDiscountRate.VisibleIndex = 15;
            this.colDiscountRate.Width = 66;
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDeliveryDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeliveryDate.Caption = "Termin Tarihi";
            this.colDeliveryDate.ColumnEdit = this.repositoryItemDateDeliveryDate;
            this.colDeliveryDate.FieldName = "DeliveryDate";
            this.colDeliveryDate.Name = "colDeliveryDate";
            this.colDeliveryDate.StatusBarAciklama = null;
            this.colDeliveryDate.StatusBarKisaYol = null;
            this.colDeliveryDate.StatusBarKisaYolAciklama = null;
            this.colDeliveryDate.Visible = true;
            this.colDeliveryDate.VisibleIndex = 16;
            // 
            // repositoryItemDateDeliveryDate
            // 
            this.repositoryItemDateDeliveryDate.AutoHeight = false;
            this.repositoryItemDateDeliveryDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateDeliveryDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateDeliveryDate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemDateDeliveryDate.Name = "repositoryItemDateDeliveryDate";
            // 
            // colBarcodeNumber
            // 
            this.colBarcodeNumber.Caption = "Firma Barkodu";
            this.colBarcodeNumber.FieldName = "BarcodeNumber";
            this.colBarcodeNumber.Name = "colBarcodeNumber";
            this.colBarcodeNumber.StatusBarAciklama = null;
            this.colBarcodeNumber.StatusBarKisaYol = null;
            this.colBarcodeNumber.StatusBarKisaYolAciklama = null;
            this.colBarcodeNumber.Visible = true;
            this.colBarcodeNumber.VisibleIndex = 17;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Kullanım Dışı";
            this.colIsActive.ColumnEdit = this.repositoryItemCheckIsActive;
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.StatusBarAciklama = null;
            this.colIsActive.StatusBarKisaYol = null;
            this.colIsActive.StatusBarKisaYolAciklama = null;
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 18;
            // 
            // repositoryItemCheckIsActive
            // 
            this.repositoryItemCheckIsActive.AutoHeight = false;
            this.repositoryItemCheckIsActive.Name = "repositoryItemCheckIsActive";
            // 
            // colMaterialCode
            // 
            this.colMaterialCode.Caption = "Malzeme Kodu";
            this.colMaterialCode.ColumnEdit = this.repositoryItemButtonMaterialCode;
            this.colMaterialCode.FieldName = "MaterialCode";
            this.colMaterialCode.Name = "colMaterialCode";
            this.colMaterialCode.StatusBarAciklama = null;
            this.colMaterialCode.StatusBarKisaYol = null;
            this.colMaterialCode.StatusBarKisaYolAciklama = null;
            this.colMaterialCode.Visible = true;
            this.colMaterialCode.VisibleIndex = 1;
            // 
            // repositoryItemButtonMaterialCode
            // 
            this.repositoryItemButtonMaterialCode.AutoHeight = false;
            this.repositoryItemButtonMaterialCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonMaterialCode.Name = "repositoryItemButtonMaterialCode";
            this.repositoryItemButtonMaterialCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
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
            this.colMaterialName.VisibleIndex = 2;
            // 
            // colMaterialUnit
            // 
            this.colMaterialUnit.Caption = "Birim";
            this.colMaterialUnit.FieldName = "MaterialUnit";
            this.colMaterialUnit.Name = "colMaterialUnit";
            this.colMaterialUnit.OptionsColumn.AllowEdit = false;
            this.colMaterialUnit.StatusBarAciklama = null;
            this.colMaterialUnit.StatusBarKisaYol = null;
            this.colMaterialUnit.StatusBarKisaYolAciklama = null;
            this.colMaterialUnit.Visible = true;
            this.colMaterialUnit.VisibleIndex = 3;
            // 
            // colCompanyMaterialCode
            // 
            this.colCompanyMaterialCode.Caption = "Firma Malzeme Kodu";
            this.colCompanyMaterialCode.FieldName = "CompanyMaterialCode";
            this.colCompanyMaterialCode.Name = "colCompanyMaterialCode";
            this.colCompanyMaterialCode.StatusBarAciklama = null;
            this.colCompanyMaterialCode.StatusBarKisaYol = null;
            this.colCompanyMaterialCode.StatusBarKisaYolAciklama = null;
            this.colCompanyMaterialCode.Visible = true;
            this.colCompanyMaterialCode.VisibleIndex = 5;
            // 
            // colCompanyMaterialName
            // 
            this.colCompanyMaterialName.Caption = "Firma Malzeme Adı";
            this.colCompanyMaterialName.FieldName = "CompanyMaterialName";
            this.colCompanyMaterialName.Name = "colCompanyMaterialName";
            this.colCompanyMaterialName.StatusBarAciklama = null;
            this.colCompanyMaterialName.StatusBarKisaYol = null;
            this.colCompanyMaterialName.StatusBarKisaYolAciklama = null;
            this.colCompanyMaterialName.Visible = true;
            this.colCompanyMaterialName.VisibleIndex = 6;
            // 
            // colCompanyMaterialUnitName
            // 
            this.colCompanyMaterialUnitName.Caption = "Firma Malzeme Birimi";
            this.colCompanyMaterialUnitName.ColumnEdit = this.repositoryItemComboBoxUnit;
            this.colCompanyMaterialUnitName.FieldName = "CompanyMaterialUnitName";
            this.colCompanyMaterialUnitName.Name = "colCompanyMaterialUnitName";
            this.colCompanyMaterialUnitName.StatusBarAciklama = null;
            this.colCompanyMaterialUnitName.StatusBarKisaYol = null;
            this.colCompanyMaterialUnitName.StatusBarKisaYolAciklama = null;
            this.colCompanyMaterialUnitName.Visible = true;
            this.colCompanyMaterialUnitName.VisibleIndex = 8;
            // 
            // repositoryItemComboBoxUnit
            // 
            this.repositoryItemComboBoxUnit.AutoHeight = false;
            this.repositoryItemComboBoxUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBoxUnit.Name = "repositoryItemComboBoxUnit";
            this.repositoryItemComboBoxUnit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colPackagingDescription
            // 
            this.colPackagingDescription.Caption = "Ambalaj";
            this.colPackagingDescription.ColumnEdit = this.repositoryItemComboBoxPackaging;
            this.colPackagingDescription.FieldName = "PackagingDescription";
            this.colPackagingDescription.Name = "colPackagingDescription";
            this.colPackagingDescription.StatusBarAciklama = null;
            this.colPackagingDescription.StatusBarKisaYol = null;
            this.colPackagingDescription.StatusBarKisaYolAciklama = null;
            this.colPackagingDescription.Visible = true;
            this.colPackagingDescription.VisibleIndex = 10;
            // 
            // repositoryItemComboBoxPackaging
            // 
            this.repositoryItemComboBoxPackaging.AutoHeight = false;
            this.repositoryItemComboBoxPackaging.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBoxPackaging.Name = "repositoryItemComboBoxPackaging";
            this.repositoryItemComboBoxPackaging.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // CompanyRelatedMaterialTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "CompanyRelatedMaterialTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateDeliveryDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateDeliveryDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonMaterialCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxPackaging)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colMaterialId;
        private UserControls.Grid.MyGridColumn colCompanyId;
        private UserControls.Grid.MyGridColumn colCompanyMaterialUnitId;
        private UserControls.Grid.MyGridColumn colPackagingId;
        private UserControls.Grid.MyGridColumn colMinOrderQty;
        private UserControls.Grid.MyGridColumn colMaxOrderQty;
        private UserControls.Grid.MyGridColumn colContractId;
        private UserControls.Grid.MyGridColumn colUnitPrice;
        private UserControls.Grid.MyGridColumn colDiscountRate;
        private UserControls.Grid.MyGridColumn colDeliveryDate;
        private UserControls.Grid.MyGridColumn colBarcodeNumber;
        private UserControls.Grid.MyGridColumn colIsActive;
        private UserControls.Grid.MyGridColumn colMaterialCode;
        private UserControls.Grid.MyGridColumn colMaterialName;
        private UserControls.Grid.MyGridColumn colMaterialUnit;
        private UserControls.Grid.MyGridColumn colCompanyMaterialCode;
        private UserControls.Grid.MyGridColumn colCompanyMaterialName;
        private UserControls.Grid.MyGridColumn colCompanyMaterialUnitName;
        private UserControls.Grid.MyGridColumn colPackagingDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcGeneral;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateDeliveryDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonMaterialCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxPackaging;
    }
}

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PriceListForms.PriceListTables
{
    partial class PriceListEditTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceListEditTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colPriceListId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPriceListCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPriceListName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemButtonMaterialCode = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colMaterialName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialUnitName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUnitId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUnitCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemComboBoxUnitCode = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colUnitName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colItemPrice = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCalcEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colValidityStartDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colValidityEndDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPriceListItemDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPriceListDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIsActive = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCheckIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonMaterialCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxUnitCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckIsActive)).BeginInit();
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
            this.repositoryItemButtonMaterialCode,
            this.repositoryItemCalcEdit,
            this.repositoryItemDateEdit,
            this.repositoryItemCheckIsActive,
            this.repositoryItemComboBoxUnitCode});
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
            this.colPriceListId,
            this.colPriceListCode,
            this.colPriceListName,
            this.colMaterialId,
            this.colMaterialCode,
            this.colMaterialName,
            this.colMaterialUnitName,
            this.colUnitId,
            this.colUnitCode,
            this.colUnitName,
            this.colItemPrice,
            this.colValidityStartDate,
            this.colValidityEndDate,
            this.colPriceListItemDescription,
            this.colPriceListDescription,
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
            this.tablo.ViewCaption = "Malzeme Fiyat Listesi";
            // 
            // colPriceListId
            // 
            this.colPriceListId.Caption = "ListeId";
            this.colPriceListId.FieldName = "PriceListId";
            this.colPriceListId.Name = "colPriceListId";
            this.colPriceListId.OptionsColumn.AllowEdit = false;
            this.colPriceListId.StatusBarAciklama = null;
            this.colPriceListId.StatusBarKisaYol = null;
            this.colPriceListId.StatusBarKisaYolAciklama = null;
            this.colPriceListId.Visible = true;
            this.colPriceListId.VisibleIndex = 1;
            // 
            // colPriceListCode
            // 
            this.colPriceListCode.AppearanceCell.Options.UseTextOptions = true;
            this.colPriceListCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPriceListCode.Caption = "Liste Kodu";
            this.colPriceListCode.FieldName = "PriceListCode";
            this.colPriceListCode.Name = "colPriceListCode";
            this.colPriceListCode.OptionsColumn.AllowEdit = false;
            this.colPriceListCode.StatusBarAciklama = null;
            this.colPriceListCode.StatusBarKisaYol = null;
            this.colPriceListCode.StatusBarKisaYolAciklama = null;
            this.colPriceListCode.Visible = true;
            this.colPriceListCode.VisibleIndex = 0;
            // 
            // colPriceListName
            // 
            this.colPriceListName.Caption = "Liste Adı";
            this.colPriceListName.FieldName = "PriceListName";
            this.colPriceListName.Name = "colPriceListName";
            this.colPriceListName.OptionsColumn.AllowEdit = false;
            this.colPriceListName.StatusBarAciklama = null;
            this.colPriceListName.StatusBarKisaYol = null;
            this.colPriceListName.StatusBarKisaYolAciklama = null;
            this.colPriceListName.Visible = true;
            this.colPriceListName.VisibleIndex = 2;
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
            this.colMaterialId.VisibleIndex = 3;
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
            this.colMaterialCode.VisibleIndex = 4;
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
            this.colMaterialName.VisibleIndex = 5;
            // 
            // colMaterialUnitName
            // 
            this.colMaterialUnitName.Caption = "Malzeme Birimi";
            this.colMaterialUnitName.FieldName = "MaterialUnitname";
            this.colMaterialUnitName.Name = "colMaterialUnitName";
            this.colMaterialUnitName.OptionsColumn.AllowEdit = false;
            this.colMaterialUnitName.StatusBarAciklama = null;
            this.colMaterialUnitName.StatusBarKisaYol = null;
            this.colMaterialUnitName.StatusBarKisaYolAciklama = null;
            this.colMaterialUnitName.Visible = true;
            this.colMaterialUnitName.VisibleIndex = 6;
            // 
            // colUnitId
            // 
            this.colUnitId.Caption = "Fiyat Verilen Birim Id";
            this.colUnitId.FieldName = "UnitId";
            this.colUnitId.Name = "colUnitId";
            this.colUnitId.OptionsColumn.AllowEdit = false;
            this.colUnitId.StatusBarAciklama = null;
            this.colUnitId.StatusBarKisaYol = null;
            this.colUnitId.StatusBarKisaYolAciklama = null;
            this.colUnitId.Visible = true;
            this.colUnitId.VisibleIndex = 7;
            // 
            // colUnitCode
            // 
            this.colUnitCode.Caption = "Fiyat Verilen Birim";
            this.colUnitCode.ColumnEdit = this.repositoryItemComboBoxUnitCode;
            this.colUnitCode.FieldName = "UnitCode";
            this.colUnitCode.Name = "colUnitCode";
            this.colUnitCode.StatusBarAciklama = null;
            this.colUnitCode.StatusBarKisaYol = null;
            this.colUnitCode.StatusBarKisaYolAciklama = null;
            this.colUnitCode.Visible = true;
            this.colUnitCode.VisibleIndex = 8;
            // 
            // repositoryItemComboBoxUnitCode
            // 
            this.repositoryItemComboBoxUnitCode.AutoHeight = false;
            this.repositoryItemComboBoxUnitCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBoxUnitCode.Name = "repositoryItemComboBoxUnitCode";
            this.repositoryItemComboBoxUnitCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colUnitName
            // 
            this.colUnitName.Caption = "Fiyat Verilen Birim Ad";
            this.colUnitName.FieldName = "UnitName";
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.OptionsColumn.AllowEdit = false;
            this.colUnitName.StatusBarAciklama = null;
            this.colUnitName.StatusBarKisaYol = null;
            this.colUnitName.StatusBarKisaYolAciklama = null;
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 9;
            // 
            // colItemPrice
            // 
            this.colItemPrice.Caption = "Birim Fiyat";
            this.colItemPrice.ColumnEdit = this.repositoryItemCalcEdit;
            this.colItemPrice.FieldName = "ItemPrice";
            this.colItemPrice.Name = "colItemPrice";
            this.colItemPrice.StatusBarAciklama = null;
            this.colItemPrice.StatusBarKisaYol = null;
            this.colItemPrice.StatusBarKisaYolAciklama = null;
            this.colItemPrice.Visible = true;
            this.colItemPrice.VisibleIndex = 10;
            // 
            // repositoryItemCalcEdit
            // 
            this.repositoryItemCalcEdit.AutoHeight = false;
            this.repositoryItemCalcEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit.DisplayFormat.FormatString = "n3";
            this.repositoryItemCalcEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEdit.EditFormat.FormatString = "n3";
            this.repositoryItemCalcEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEdit.Name = "repositoryItemCalcEdit";
            // 
            // colValidityStartDate
            // 
            this.colValidityStartDate.AppearanceCell.Options.UseTextOptions = true;
            this.colValidityStartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValidityStartDate.Caption = "Geçerlilik Başlangıç Tarihi";
            this.colValidityStartDate.ColumnEdit = this.repositoryItemDateEdit;
            this.colValidityStartDate.FieldName = "ValidityStartDate";
            this.colValidityStartDate.Name = "colValidityStartDate";
            this.colValidityStartDate.StatusBarAciklama = null;
            this.colValidityStartDate.StatusBarKisaYol = null;
            this.colValidityStartDate.StatusBarKisaYolAciklama = null;
            this.colValidityStartDate.Visible = true;
            this.colValidityStartDate.VisibleIndex = 11;
            // 
            // repositoryItemDateEdit
            // 
            this.repositoryItemDateEdit.AutoHeight = false;
            this.repositoryItemDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemDateEdit.Name = "repositoryItemDateEdit";
            // 
            // colValidityEndDate
            // 
            this.colValidityEndDate.AppearanceCell.Options.UseTextOptions = true;
            this.colValidityEndDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValidityEndDate.Caption = "Geçerlilik Bitiş tarihi";
            this.colValidityEndDate.ColumnEdit = this.repositoryItemDateEdit;
            this.colValidityEndDate.FieldName = "ValidityEndDate";
            this.colValidityEndDate.Name = "colValidityEndDate";
            this.colValidityEndDate.StatusBarAciklama = null;
            this.colValidityEndDate.StatusBarKisaYol = null;
            this.colValidityEndDate.StatusBarKisaYolAciklama = null;
            this.colValidityEndDate.Visible = true;
            this.colValidityEndDate.VisibleIndex = 12;
            // 
            // colPriceListItemDescription
            // 
            this.colPriceListItemDescription.Caption = "Kalem Açıklaması";
            this.colPriceListItemDescription.FieldName = "PriceListItemDescription";
            this.colPriceListItemDescription.Name = "colPriceListItemDescription";
            this.colPriceListItemDescription.StatusBarAciklama = null;
            this.colPriceListItemDescription.StatusBarKisaYol = null;
            this.colPriceListItemDescription.StatusBarKisaYolAciklama = null;
            this.colPriceListItemDescription.Visible = true;
            this.colPriceListItemDescription.VisibleIndex = 13;
            // 
            // colPriceListDescription
            // 
            this.colPriceListDescription.Caption = "Liste Açıklaması";
            this.colPriceListDescription.FieldName = "PriceListDescription";
            this.colPriceListDescription.Name = "colPriceListDescription";
            this.colPriceListDescription.OptionsColumn.AllowEdit = false;
            this.colPriceListDescription.StatusBarAciklama = null;
            this.colPriceListDescription.StatusBarKisaYol = null;
            this.colPriceListDescription.StatusBarKisaYolAciklama = null;
            this.colPriceListDescription.Visible = true;
            this.colPriceListDescription.VisibleIndex = 14;
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
            this.colIsActive.VisibleIndex = 15;
            // 
            // repositoryItemCheckIsActive
            // 
            this.repositoryItemCheckIsActive.AutoHeight = false;
            this.repositoryItemCheckIsActive.Name = "repositoryItemCheckIsActive";
            // 
            // PriceListEditTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "PriceListEditTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonMaterialCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxUnitCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckIsActive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colPriceListId;
        private UserControls.Grid.MyGridColumn colPriceListCode;
        private UserControls.Grid.MyGridColumn colPriceListName;
        private UserControls.Grid.MyGridColumn colMaterialId;
        private UserControls.Grid.MyGridColumn colMaterialCode;
        private UserControls.Grid.MyGridColumn colMaterialName;
        private UserControls.Grid.MyGridColumn colMaterialUnitName;
        private UserControls.Grid.MyGridColumn colUnitId;
        private UserControls.Grid.MyGridColumn colUnitCode;
        private UserControls.Grid.MyGridColumn colUnitName;
        private UserControls.Grid.MyGridColumn colValidityStartDate;
        private UserControls.Grid.MyGridColumn colValidityEndDate;
        private UserControls.Grid.MyGridColumn colPriceListItemDescription;
        private UserControls.Grid.MyGridColumn colPriceListDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonMaterialCode;
        private UserControls.Grid.MyGridColumn colItemPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        private UserControls.Grid.MyGridColumn colIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxUnitCode;
    }
}

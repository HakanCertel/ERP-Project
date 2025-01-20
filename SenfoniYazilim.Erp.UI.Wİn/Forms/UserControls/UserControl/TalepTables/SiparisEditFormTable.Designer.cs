namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.SiparisTables
{
    partial class SiparisEditFormTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisEditFormTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colDemandId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStockId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStockCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStockName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colQuantity = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCalc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colUnit = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOrderDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colDeliveryDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUserId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
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
            this.repositoryItemCalc,
            this.repositoryItemDate});
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
            this.colDemandId,
            this.colUserId,
            this.colStockId,
            this.colStockCode,
            this.colStockName,
            this.colQuantity,
            this.colUnit,
            this.colOrderDate,
            this.colDeliveryDate});
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
            this.tablo.ViewCaption = "Sipariş Bilgileri";
            // 
            // colDemandId
            // 
            this.colDemandId.Caption = "DemandId ";
            this.colDemandId.FieldName = "DemandId";
            this.colDemandId.Name = "colDemandId";
            this.colDemandId.OptionsColumn.AllowEdit = false;
            this.colDemandId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDemandId.OptionsColumn.ShowInCustomizationForm = false;
            this.colDemandId.OptionsFilter.AllowAutoFilter = false;
            this.colDemandId.OptionsFilter.AllowFilter = false;
            this.colDemandId.StatusBarAciklama = null;
            this.colDemandId.StatusBarKisaYol = null;
            this.colDemandId.StatusBarKisaYolAciklama = null;
            // 
            // colStockId
            // 
            this.colStockId.Caption = "StockId";
            this.colStockId.FieldName = "StockId";
            this.colStockId.Name = "colStockId";
            this.colStockId.OptionsColumn.AllowEdit = false;
            this.colStockId.OptionsColumn.ShowInCustomizationForm = false;
            this.colStockId.StatusBarAciklama = null;
            this.colStockId.StatusBarKisaYol = null;
            this.colStockId.StatusBarKisaYolAciklama = null;
            // 
            // colStockCode
            // 
            this.colStockCode.Caption = "Stok Kodu";
            this.colStockCode.FieldName = "StockCode";
            this.colStockCode.Name = "colStockCode";
            this.colStockCode.OptionsColumn.AllowEdit = false;
            this.colStockCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colStockCode.StatusBarAciklama = null;
            this.colStockCode.StatusBarKisaYol = null;
            this.colStockCode.StatusBarKisaYolAciklama = null;
            this.colStockCode.Visible = true;
            this.colStockCode.VisibleIndex = 0;
            this.colStockCode.Width = 140;
            // 
            // colStockName
            // 
            this.colStockName.Caption = "Stok Adı";
            this.colStockName.FieldName = "StockName";
            this.colStockName.Name = "colStockName";
            this.colStockName.OptionsColumn.AllowEdit = false;
            this.colStockName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colStockName.OptionsFilter.AllowAutoFilter = false;
            this.colStockName.OptionsFilter.AllowFilter = false;
            this.colStockName.StatusBarAciklama = null;
            this.colStockName.StatusBarKisaYol = null;
            this.colStockName.StatusBarKisaYolAciklama = null;
            this.colStockName.Visible = true;
            this.colStockName.VisibleIndex = 1;
            this.colStockName.Width = 374;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Miktar ";
            this.colQuantity.ColumnEdit = this.repositoryItemCalc;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colQuantity.OptionsFilter.AllowAutoFilter = false;
            this.colQuantity.OptionsFilter.AllowFilter = false;
            this.colQuantity.StatusBarAciklama = null;
            this.colQuantity.StatusBarKisaYol = null;
            this.colQuantity.StatusBarKisaYolAciklama = null;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 86;
            // 
            // repositoryItemCalc
            // 
            this.repositoryItemCalc.AutoHeight = false;
            this.repositoryItemCalc.DisplayFormat.FormatString = "{n2:0}";
            this.repositoryItemCalc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalc.EditFormat.FormatString = "{n2:0}";
            this.repositoryItemCalc.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalc.Name = "repositoryItemCalc";
            // 
            // colUnit
            // 
            this.colUnit.Caption = "Birim ";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.AllowEdit = false;
            this.colUnit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUnit.OptionsFilter.AllowAutoFilter = false;
            this.colUnit.OptionsFilter.AllowFilter = false;
            this.colUnit.StatusBarAciklama = null;
            this.colUnit.StatusBarKisaYol = null;
            this.colUnit.StatusBarKisaYolAciklama = null;
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 2;
            // 
            // colOrderDate
            // 
            this.colOrderDate.AppearanceCell.Options.UseTextOptions = true;
            this.colOrderDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderDate.Caption = "Sipariş Tarihi";
            this.colOrderDate.ColumnEdit = this.repositoryItemDate;
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.OptionsColumn.AllowEdit = false;
            this.colOrderDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colOrderDate.OptionsFilter.AllowAutoFilter = false;
            this.colOrderDate.OptionsFilter.AllowFilter = false;
            this.colOrderDate.StatusBarAciklama = null;
            this.colOrderDate.StatusBarKisaYol = null;
            this.colOrderDate.StatusBarKisaYolAciklama = null;
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 4;
            this.colOrderDate.Width = 135;
            // 
            // repositoryItemDate
            // 
            this.repositoryItemDate.AutoHeight = false;
            this.repositoryItemDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemDate.Name = "repositoryItemDate";
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDeliveryDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeliveryDate.Caption = "Teslim Tarihi";
            this.colDeliveryDate.ColumnEdit = this.repositoryItemDate;
            this.colDeliveryDate.FieldName = "DeliveryDate";
            this.colDeliveryDate.Name = "colDeliveryDate";
            this.colDeliveryDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDeliveryDate.OptionsFilter.AllowAutoFilter = false;
            this.colDeliveryDate.OptionsFilter.AllowFilter = false;
            this.colDeliveryDate.StatusBarAciklama = null;
            this.colDeliveryDate.StatusBarKisaYol = null;
            this.colDeliveryDate.StatusBarKisaYolAciklama = null;
            this.colDeliveryDate.Visible = true;
            this.colDeliveryDate.VisibleIndex = 5;
            this.colDeliveryDate.Width = 145;
            // 
            // colUserId
            // 
            this.colUserId.Caption = "UserId ";
            this.colUserId.FieldName = "UserId";
            this.colUserId.Name = "colUserId";
            this.colUserId.OptionsColumn.AllowEdit = false;
            this.colUserId.OptionsColumn.ShowInCustomizationForm = false;
            this.colUserId.StatusBarAciklama = null;
            this.colUserId.StatusBarKisaYol = null;
            this.colUserId.StatusBarKisaYolAciklama = null;
            // 
            // SiparisEditFormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "SiparisEditFormTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colDemandId;
        private Grid.MyGridColumn colStockId;
        private Grid.MyGridColumn colStockCode;
        private Grid.MyGridColumn colStockName;
        private Grid.MyGridColumn colQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalc;
        private Grid.MyGridColumn colUnit;
        private Grid.MyGridColumn colOrderDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private Grid.MyGridColumn colDeliveryDate;
        private Grid.MyGridColumn colUserId;
    }
}

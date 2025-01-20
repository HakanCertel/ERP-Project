namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SiparisForms
{
    partial class OrderInformationsMultiSelectForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderInformationsMultiSelectForm));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colDemandId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDemandCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDemandStatus = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUserId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUserName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStockId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStockCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStockName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colQuantity = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCalc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colUnit = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOrderDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colDeliveryDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCurrentId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCurrentName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPlasiyerId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPlasiyerName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.longNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.LongNavigator();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // btnMakbuzYeni
            // 
            this.btnMakbuzYeni.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMakbuzYeni.ImageOptions.Image")));
            this.btnMakbuzYeni.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMakbuzYeni.ImageOptions.LargeImage")));
            // 
            // barSubItem3
            // 
            this.barSubItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem3.ImageOptions.Image")));
            // 
            // btnRaporYeni
            // 
            this.btnRaporYeni.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporYeni.ImageOptions.Image")));
            this.btnRaporYeni.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRaporYeni.ImageOptions.LargeImage")));
            // 
            // btnIceriVeriAktar
            // 
            this.btnIceriVeriAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIceriVeriAktar.ImageOptions.Image")));
            this.btnIceriVeriAktar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnIceriVeriAktar.ImageOptions.LargeImage")));
            // 
            // btnIndirimTalep
            // 
            this.btnIndirimTalep.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIndirimTalep.ImageOptions.Image")));
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalc,
            this.repositoryItemDate});
            this.grid.Size = new System.Drawing.Size(1062, 289);
            this.grid.TabIndex = 24;
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
            this.colDemandId,
            this.colDemandCode,
            this.colDemandStatus,
            this.colUserId,
            this.colUserName,
            this.colStockId,
            this.colStockCode,
            this.colStockName,
            this.colQuantity,
            this.colUnit,
            this.colOrderDate,
            this.colDeliveryDate,
            this.colCurrentId,
            this.colCurrentName,
            this.colPlasiyerId,
            this.colPlasiyerName});
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
            this.tablo.ViewCaption = "Talep Bilgileri";
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
            // colDemandCode
            // 
            this.colDemandCode.Caption = "Talep Kodu";
            this.colDemandCode.FieldName = "DemandCode";
            this.colDemandCode.Name = "colDemandCode";
            this.colDemandCode.OptionsColumn.AllowEdit = false;
            this.colDemandCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDemandCode.StatusBarAciklama = null;
            this.colDemandCode.StatusBarKisaYol = null;
            this.colDemandCode.StatusBarKisaYolAciklama = null;
            this.colDemandCode.Visible = true;
            this.colDemandCode.VisibleIndex = 2;
            // 
            // colDemandStatus
            // 
            this.colDemandStatus.Caption = "Talep Kategori";
            this.colDemandStatus.FieldName = "DemandStatus";
            this.colDemandStatus.Name = "colDemandStatus";
            this.colDemandStatus.OptionsColumn.AllowEdit = false;
            this.colDemandStatus.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDemandStatus.OptionsFilter.AllowAutoFilter = false;
            this.colDemandStatus.OptionsFilter.AllowFilter = false;
            this.colDemandStatus.StatusBarAciklama = null;
            this.colDemandStatus.StatusBarKisaYol = null;
            this.colDemandStatus.StatusBarKisaYolAciklama = null;
            this.colDemandStatus.Visible = true;
            this.colDemandStatus.VisibleIndex = 3;
            this.colDemandStatus.Width = 112;
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
            // colUserName
            // 
            this.colUserName.Caption = "Kullanıcı Adı";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.AllowEdit = false;
            this.colUserName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUserName.StatusBarAciklama = null;
            this.colUserName.StatusBarKisaYol = null;
            this.colUserName.StatusBarKisaYolAciklama = null;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 4;
            // 
            // colStockId
            // 
            this.colStockId.Caption = "StockId ";
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
            this.colStockCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colStockCode.StatusBarAciklama = null;
            this.colStockCode.StatusBarKisaYol = null;
            this.colStockCode.StatusBarKisaYolAciklama = null;
            this.colStockCode.Visible = true;
            this.colStockCode.VisibleIndex = 1;
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
            this.colStockName.VisibleIndex = 5;
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
            this.colQuantity.VisibleIndex = 7;
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
            this.colUnit.VisibleIndex = 6;
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
            this.colOrderDate.VisibleIndex = 8;
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
            this.colDeliveryDate.VisibleIndex = 9;
            this.colDeliveryDate.Width = 145;
            // 
            // colCurrentId
            // 
            this.colCurrentId.Caption = "CariId ";
            this.colCurrentId.FieldName = "CurrentId";
            this.colCurrentId.Name = "colCurrentId";
            this.colCurrentId.OptionsColumn.AllowEdit = false;
            this.colCurrentId.OptionsColumn.ShowInCustomizationForm = false;
            this.colCurrentId.StatusBarAciklama = null;
            this.colCurrentId.StatusBarKisaYol = null;
            this.colCurrentId.StatusBarKisaYolAciklama = null;
            // 
            // colCurrentName
            // 
            this.colCurrentName.Caption = "Cari";
            this.colCurrentName.FieldName = "CurrentName";
            this.colCurrentName.Name = "colCurrentName";
            this.colCurrentName.OptionsColumn.AllowEdit = false;
            this.colCurrentName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCurrentName.StatusBarAciklama = null;
            this.colCurrentName.StatusBarKisaYol = null;
            this.colCurrentName.StatusBarKisaYolAciklama = null;
            this.colCurrentName.Visible = true;
            this.colCurrentName.VisibleIndex = 10;
            this.colCurrentName.Width = 190;
            // 
            // colPlasiyerId
            // 
            this.colPlasiyerId.Caption = "PlasiyerId ";
            this.colPlasiyerId.FieldName = "PlasiyerId";
            this.colPlasiyerId.Name = "colPlasiyerId";
            this.colPlasiyerId.OptionsColumn.AllowEdit = false;
            this.colPlasiyerId.OptionsColumn.ShowInCustomizationForm = false;
            this.colPlasiyerId.StatusBarAciklama = null;
            this.colPlasiyerId.StatusBarKisaYol = null;
            this.colPlasiyerId.StatusBarKisaYolAciklama = null;
            // 
            // colPlasiyerName
            // 
            this.colPlasiyerName.Caption = "Plasiyer";
            this.colPlasiyerName.FieldName = "PlasiyerName";
            this.colPlasiyerName.Name = "colPlasiyerName";
            this.colPlasiyerName.OptionsColumn.AllowEdit = false;
            this.colPlasiyerName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPlasiyerName.StatusBarAciklama = null;
            this.colPlasiyerName.StatusBarKisaYol = null;
            this.colPlasiyerName.StatusBarKisaYolAciklama = null;
            this.colPlasiyerName.Visible = true;
            this.colPlasiyerName.VisibleIndex = 11;
            this.colPlasiyerName.Width = 150;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 391);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1062, 24);
            this.longNavigator.TabIndex = 25;
            // 
            // colId
            // 
            this.colId.Caption = "Id ";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = null;
            this.colId.StatusBarKisaYolAciklama = null;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // OrderInformationsMultiSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 446);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "OrderInformationsMultiSelectForm";
            this.Text = "Talep Bilgileri";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colDemandId;
        private UserControls.Grid.MyGridColumn colStockId;
        private UserControls.Grid.MyGridColumn colStockCode;
        private UserControls.Grid.MyGridColumn colStockName;
        private UserControls.Grid.MyGridColumn colQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalc;
        private UserControls.Grid.MyGridColumn colUnit;
        private UserControls.Grid.MyGridColumn colOrderDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private UserControls.Grid.MyGridColumn colDeliveryDate;
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyGridColumn colDemandCode;
        private UserControls.Grid.MyGridColumn colCurrentId;
        private UserControls.Grid.MyGridColumn colCurrentName;
        private UserControls.Grid.MyGridColumn colPlasiyerId;
        private UserControls.Grid.MyGridColumn colPlasiyerName;
        private UserControls.Grid.MyGridColumn colDemandStatus;
        private UserControls.Grid.MyGridColumn colUserId;
        private UserControls.Grid.MyGridColumn colUserName;
        private UserControls.Grid.MyGridColumn colId;
    }
}
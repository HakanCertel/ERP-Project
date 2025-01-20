namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.TransferBetweenWarehousesForms
{
    partial class TransferDemandBetweenWarehousesListFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferDemandBetweenWarehousesListFrom));
            this.longNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.LongNavigator();
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKod = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTransferWarehouseId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTransferWarehouseName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTransferedWarehouseId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTransferedWarehouseName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDemandingUserId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.DemandingUserName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCreatorUserId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCreatorUserName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCreateDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUpdatingUserId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUpdatingUserName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUpdateDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.TransferCreatingMethod = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDocumentDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDemandedDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSatinalmaTalepKalemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
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
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 391);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1062, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1062, 289);
            this.grid.TabIndex = 3;
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
            this.colKod,
            this.colTransferWarehouseId,
            this.colTransferWarehouseName,
            this.colTransferedWarehouseId,
            this.colTransferedWarehouseName,
            this.colDemandingUserId,
            this.DemandingUserName,
            this.colCreatorUserId,
            this.colCreatorUserName,
            this.colCreateDate,
            this.colUpdatingUserId,
            this.colUpdatingUserName,
            this.colUpdateDate,
            this.TransferCreatingMethod,
            this.colDemandedDate,
            this.colDocumentDate});
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
            this.tablo.ViewCaption = "Depolar Arası Transfer Talep Kartları";
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
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 121;
            // 
            // colTransferWarehouseId
            // 
            this.colTransferWarehouseId.Caption = "TransferWarehouseId";
            this.colTransferWarehouseId.FieldName = "TransferWarehouseId";
            this.colTransferWarehouseId.Name = "colTransferWarehouseId";
            this.colTransferWarehouseId.OptionsColumn.AllowEdit = false;
            this.colTransferWarehouseId.StatusBarAciklama = null;
            this.colTransferWarehouseId.StatusBarKisaYol = null;
            this.colTransferWarehouseId.StatusBarKisaYolAciklama = null;
            this.colTransferWarehouseId.Visible = true;
            this.colTransferWarehouseId.VisibleIndex = 1;
            // 
            // colTransferWarehouseName
            // 
            this.colTransferWarehouseName.Caption = "Transfer Depo";
            this.colTransferWarehouseName.FieldName = "TransferWarehouseName";
            this.colTransferWarehouseName.Name = "colTransferWarehouseName";
            this.colTransferWarehouseName.OptionsColumn.AllowEdit = false;
            this.colTransferWarehouseName.StatusBarAciklama = null;
            this.colTransferWarehouseName.StatusBarKisaYol = null;
            this.colTransferWarehouseName.StatusBarKisaYolAciklama = null;
            this.colTransferWarehouseName.Visible = true;
            this.colTransferWarehouseName.VisibleIndex = 2;
            this.colTransferWarehouseName.Width = 126;
            // 
            // colTransferedWarehouseId
            // 
            this.colTransferedWarehouseId.Caption = "TransferedWarehouseId";
            this.colTransferedWarehouseId.FieldName = "TransferedWarehouseId";
            this.colTransferedWarehouseId.Name = "colTransferedWarehouseId";
            this.colTransferedWarehouseId.OptionsColumn.AllowEdit = false;
            this.colTransferedWarehouseId.StatusBarAciklama = null;
            this.colTransferedWarehouseId.StatusBarKisaYol = null;
            this.colTransferedWarehouseId.StatusBarKisaYolAciklama = null;
            this.colTransferedWarehouseId.Visible = true;
            this.colTransferedWarehouseId.VisibleIndex = 3;
            // 
            // colTransferedWarehouseName
            // 
            this.colTransferedWarehouseName.Caption = "Transfer Edilen Depo";
            this.colTransferedWarehouseName.FieldName = "TransferedWarehouseName";
            this.colTransferedWarehouseName.Name = "colTransferedWarehouseName";
            this.colTransferedWarehouseName.OptionsColumn.AllowEdit = false;
            this.colTransferedWarehouseName.StatusBarAciklama = null;
            this.colTransferedWarehouseName.StatusBarKisaYol = null;
            this.colTransferedWarehouseName.StatusBarKisaYolAciklama = null;
            this.colTransferedWarehouseName.Visible = true;
            this.colTransferedWarehouseName.VisibleIndex = 4;
            this.colTransferedWarehouseName.Width = 172;
            // 
            // colDemandingUserId
            // 
            this.colDemandingUserId.Caption = "DemandingUserId";
            this.colDemandingUserId.FieldName = "DemandingUserId";
            this.colDemandingUserId.Name = "colDemandingUserId";
            this.colDemandingUserId.OptionsColumn.AllowEdit = false;
            this.colDemandingUserId.StatusBarAciklama = null;
            this.colDemandingUserId.StatusBarKisaYol = null;
            this.colDemandingUserId.StatusBarKisaYolAciklama = null;
            this.colDemandingUserId.Visible = true;
            this.colDemandingUserId.VisibleIndex = 5;
            // 
            // DemandingUserName
            // 
            this.DemandingUserName.Caption = "Talep Eden Kullanıcı";
            this.DemandingUserName.FieldName = "DemandingUserName";
            this.DemandingUserName.Name = "DemandingUserName";
            this.DemandingUserName.OptionsColumn.AllowEdit = false;
            this.DemandingUserName.StatusBarAciklama = null;
            this.DemandingUserName.StatusBarKisaYol = null;
            this.DemandingUserName.StatusBarKisaYolAciklama = null;
            this.DemandingUserName.Visible = true;
            this.DemandingUserName.VisibleIndex = 6;
            this.DemandingUserName.Width = 136;
            // 
            // colCreatorUserId
            // 
            this.colCreatorUserId.Caption = "CreatorUserId";
            this.colCreatorUserId.FieldName = "CreatorUserId";
            this.colCreatorUserId.Name = "colCreatorUserId";
            this.colCreatorUserId.OptionsColumn.AllowEdit = false;
            this.colCreatorUserId.StatusBarAciklama = null;
            this.colCreatorUserId.StatusBarKisaYol = null;
            this.colCreatorUserId.StatusBarKisaYolAciklama = null;
            this.colCreatorUserId.Visible = true;
            this.colCreatorUserId.VisibleIndex = 7;
            // 
            // colCreatorUserName
            // 
            this.colCreatorUserName.Caption = "Kaydı Oluşturan Kullanıcı";
            this.colCreatorUserName.FieldName = "CreatorUserName";
            this.colCreatorUserName.Name = "colCreatorUserName";
            this.colCreatorUserName.OptionsColumn.AllowEdit = false;
            this.colCreatorUserName.StatusBarAciklama = null;
            this.colCreatorUserName.StatusBarKisaYol = null;
            this.colCreatorUserName.StatusBarKisaYolAciklama = null;
            this.colCreatorUserName.Visible = true;
            this.colCreatorUserName.VisibleIndex = 8;
            this.colCreatorUserName.Width = 136;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "Oluşturulma Tarihi";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.OptionsColumn.AllowEdit = false;
            this.colCreateDate.StatusBarAciklama = null;
            this.colCreateDate.StatusBarKisaYol = null;
            this.colCreateDate.StatusBarKisaYolAciklama = null;
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 9;
            this.colCreateDate.Width = 119;
            // 
            // colUpdatingUserId
            // 
            this.colUpdatingUserId.Caption = "UpdatingUserId";
            this.colUpdatingUserId.FieldName = "UpdatingUserId";
            this.colUpdatingUserId.Name = "colUpdatingUserId";
            this.colUpdatingUserId.OptionsColumn.AllowEdit = false;
            this.colUpdatingUserId.StatusBarAciklama = null;
            this.colUpdatingUserId.StatusBarKisaYol = null;
            this.colUpdatingUserId.StatusBarKisaYolAciklama = null;
            this.colUpdatingUserId.Visible = true;
            this.colUpdatingUserId.VisibleIndex = 10;
            // 
            // colUpdatingUserName
            // 
            this.colUpdatingUserName.Caption = "Güncelleyen Kullanıcı";
            this.colUpdatingUserName.FieldName = "UpdatingUserName";
            this.colUpdatingUserName.Name = "colUpdatingUserName";
            this.colUpdatingUserName.OptionsColumn.AllowEdit = false;
            this.colUpdatingUserName.StatusBarAciklama = null;
            this.colUpdatingUserName.StatusBarKisaYol = null;
            this.colUpdatingUserName.StatusBarKisaYolAciklama = null;
            this.colUpdatingUserName.Visible = true;
            this.colUpdatingUserName.VisibleIndex = 11;
            this.colUpdatingUserName.Width = 120;
            // 
            // colUpdateDate
            // 
            this.colUpdateDate.Caption = "Son Güncellenme Tarihi";
            this.colUpdateDate.FieldName = "UpdateDate";
            this.colUpdateDate.Name = "colUpdateDate";
            this.colUpdateDate.OptionsColumn.AllowEdit = false;
            this.colUpdateDate.StatusBarAciklama = null;
            this.colUpdateDate.StatusBarKisaYol = null;
            this.colUpdateDate.StatusBarKisaYolAciklama = null;
            this.colUpdateDate.Visible = true;
            this.colUpdateDate.VisibleIndex = 12;
            this.colUpdateDate.Width = 133;
            // 
            // TransferCreatingMethod
            // 
            this.TransferCreatingMethod.Caption = "Transfer Oluşturma Yöntemi";
            this.TransferCreatingMethod.FieldName = "TransferCreatingMethod";
            this.TransferCreatingMethod.Name = "TransferCreatingMethod";
            this.TransferCreatingMethod.OptionsColumn.AllowEdit = false;
            this.TransferCreatingMethod.StatusBarAciklama = null;
            this.TransferCreatingMethod.StatusBarKisaYol = null;
            this.TransferCreatingMethod.StatusBarKisaYolAciklama = null;
            this.TransferCreatingMethod.Visible = true;
            this.TransferCreatingMethod.VisibleIndex = 13;
            this.TransferCreatingMethod.Width = 160;
            // 
            // colDocumentDate
            // 
            this.colDocumentDate.Caption = "Evrak Tarihi";
            this.colDocumentDate.FieldName = "DocumentDate";
            this.colDocumentDate.Name = "colDocumentDate";
            this.colDocumentDate.OptionsColumn.AllowEdit = false;
            this.colDocumentDate.StatusBarAciklama = null;
            this.colDocumentDate.StatusBarKisaYol = null;
            this.colDocumentDate.StatusBarKisaYolAciklama = null;
            this.colDocumentDate.Visible = true;
            this.colDocumentDate.VisibleIndex = 14;
            this.colDocumentDate.Width = 89;
            // 
            // colDemandedDate
            // 
            this.colDemandedDate.Caption = "Talep Edilen Tarih";
            this.colDemandedDate.FieldName = "DemandedDate";
            this.colDemandedDate.Name = "colDemandedDate";
            this.colDemandedDate.OptionsColumn.AllowEdit = false;
            this.colDemandedDate.StatusBarAciklama = null;
            this.colDemandedDate.StatusBarKisaYol = null;
            this.colDemandedDate.StatusBarKisaYolAciklama = null;
            this.colDemandedDate.Visible = true;
            this.colDemandedDate.VisibleIndex = 15;
            this.colDemandedDate.Width = 98;
            // 
            // TransferDemandBetweenWarehousesListFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 446);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "TransferDemandBetweenWarehousesListFrom";
            this.Text = "Depolar Arası Transfer Talep Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSatinalmaTalepKalemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Grid.MyGridColumn colTransferWarehouseId;
        private UserControls.Grid.MyGridColumn colTransferWarehouseName;
        private UserControls.Grid.MyGridColumn colTransferedWarehouseId;
        private UserControls.Grid.MyGridColumn colTransferedWarehouseName;
        private UserControls.Grid.MyGridColumn colDemandingUserId;
        private UserControls.Grid.MyGridColumn DemandingUserName;
        private UserControls.Grid.MyGridColumn colCreatorUserId;
        private UserControls.Grid.MyGridColumn colCreatorUserName;
        private UserControls.Grid.MyGridColumn colCreateDate;
        private UserControls.Grid.MyGridColumn colUpdatingUserId;
        private UserControls.Grid.MyGridColumn colUpdatingUserName;
        private UserControls.Grid.MyGridColumn colUpdateDate;
        private UserControls.Grid.MyGridColumn TransferCreatingMethod;
        private UserControls.Grid.MyGridColumn colDemandedDate;
        private UserControls.Grid.MyGridColumn colDocumentDate;
    }
}
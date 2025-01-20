namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.CRPForms.IsEmriForms.IsEmriTables
{
    partial class WorkOrderMaterialTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkOrderMaterialTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOwnerFormId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMrpBilgileriId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMalzemeIhtiyacBilgileriId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBagliOlduguReceteId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMaterialName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colWarehouseId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemLookUpDepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colWarehouseName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUnitId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemLookUpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.UnitCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUnitQty = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colWastageQty = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCalc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colTotalRequestQty = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colRemainingRequestQty = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpDepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYukariTasi
            // 
            this.btnYukariTasi.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnYukariTasi.Appearance.Options.UseForeColor = true;
            this.btnYukariTasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYukariTasi.ImageOptions.Image")));
            // 
            // btnAsagiTasi
            // 
            this.btnAsagiTasi.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAsagiTasi.Appearance.Options.UseForeColor = true;
            this.btnAsagiTasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAsagiTasi.ImageOptions.Image")));
            // 
            // panelButtons
            // 
            this.panelButtons.Appearance.BackColor = System.Drawing.Color.White;
            this.panelButtons.Appearance.Options.UseBackColor = true;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 24);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalc,
            this.repositoryItemLookUpDepo,
            this.repositoryItemLookUpUnit});
            this.grid.Size = new System.Drawing.Size(612, 203);
            this.grid.TabIndex = 33;
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
            this.colOwnerFormId,
            this.colMrpBilgileriId,
            this.colMalzemeIhtiyacBilgileriId,
            this.colBagliOlduguReceteId,
            this.colMaterialId,
            this.colMaterialCode,
            this.colMaterialName,
            this.colWarehouseId,
            this.colWarehouseName,
            this.colUnitId,
            this.UnitCode,
            this.colUnitQty,
            this.colWastageQty,
            this.colTotalRequestQty,
            this.colRemainingRequestQty});
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
            this.tablo.ViewCaption = "İş Emri Malzeme Kalemleri";
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
            // colOwnerFormId
            // 
            this.colOwnerFormId.AppearanceCell.Options.UseTextOptions = true;
            this.colOwnerFormId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerFormId.Caption = "OwnerFormId";
            this.colOwnerFormId.FieldName = "OwnerFormId";
            this.colOwnerFormId.Name = "colOwnerFormId";
            this.colOwnerFormId.OptionsColumn.AllowEdit = false;
            this.colOwnerFormId.OptionsColumn.ShowInCustomizationForm = false;
            this.colOwnerFormId.StatusBarAciklama = null;
            this.colOwnerFormId.StatusBarKisaYol = null;
            this.colOwnerFormId.StatusBarKisaYolAciklama = null;
            // 
            // colMrpBilgileriId
            // 
            this.colMrpBilgileriId.Caption = "MrpBilgileriId";
            this.colMrpBilgileriId.FieldName = "MrpBilgileriId";
            this.colMrpBilgileriId.Name = "colMrpBilgileriId";
            this.colMrpBilgileriId.OptionsColumn.AllowEdit = false;
            this.colMrpBilgileriId.OptionsColumn.ShowInCustomizationForm = false;
            this.colMrpBilgileriId.StatusBarAciklama = null;
            this.colMrpBilgileriId.StatusBarKisaYol = null;
            this.colMrpBilgileriId.StatusBarKisaYolAciklama = null;
            // 
            // colMalzemeIhtiyacBilgileriId
            // 
            this.colMalzemeIhtiyacBilgileriId.Caption = "MalzemeIhtiyacBilgileriId";
            this.colMalzemeIhtiyacBilgileriId.FieldName = "MalzemeIhtiyacBilgileriId";
            this.colMalzemeIhtiyacBilgileriId.Name = "colMalzemeIhtiyacBilgileriId";
            this.colMalzemeIhtiyacBilgileriId.OptionsColumn.AllowEdit = false;
            this.colMalzemeIhtiyacBilgileriId.OptionsColumn.ShowInCustomizationForm = false;
            this.colMalzemeIhtiyacBilgileriId.StatusBarAciklama = null;
            this.colMalzemeIhtiyacBilgileriId.StatusBarKisaYol = null;
            this.colMalzemeIhtiyacBilgileriId.StatusBarKisaYolAciklama = null;
            // 
            // colBagliOlduguReceteId
            // 
            this.colBagliOlduguReceteId.Caption = "BagliOlduguReceteId";
            this.colBagliOlduguReceteId.FieldName = "BagliOlduguReceteId";
            this.colBagliOlduguReceteId.Name = "colBagliOlduguReceteId";
            this.colBagliOlduguReceteId.OptionsColumn.AllowEdit = false;
            this.colBagliOlduguReceteId.OptionsColumn.ShowInCustomizationForm = false;
            this.colBagliOlduguReceteId.StatusBarAciklama = null;
            this.colBagliOlduguReceteId.StatusBarKisaYol = null;
            this.colBagliOlduguReceteId.StatusBarKisaYolAciklama = null;
            // 
            // colMaterialId
            // 
            this.colMaterialId.Caption = " MaterialId";
            this.colMaterialId.FieldName = "MaterialId";
            this.colMaterialId.Name = "colMaterialId";
            this.colMaterialId.OptionsColumn.AllowEdit = false;
            this.colMaterialId.OptionsColumn.ShowInCustomizationForm = false;
            this.colMaterialId.StatusBarAciklama = null;
            this.colMaterialId.StatusBarKisaYol = null;
            this.colMaterialId.StatusBarKisaYolAciklama = null;
            // 
            // colMaterialCode
            // 
            this.colMaterialCode.Caption = "Stok Kodu";
            this.colMaterialCode.FieldName = "MaterialCode";
            this.colMaterialCode.Name = "colMaterialCode";
            this.colMaterialCode.OptionsColumn.AllowEdit = false;
            this.colMaterialCode.StatusBarAciklama = null;
            this.colMaterialCode.StatusBarKisaYol = null;
            this.colMaterialCode.StatusBarKisaYolAciklama = null;
            this.colMaterialCode.Visible = true;
            this.colMaterialCode.VisibleIndex = 0;
            // 
            // colMaterialName
            // 
            this.colMaterialName.Caption = "Stok Adı";
            this.colMaterialName.FieldName = "MaterialName";
            this.colMaterialName.Name = "colMaterialName";
            this.colMaterialName.OptionsColumn.AllowEdit = false;
            this.colMaterialName.StatusBarAciklama = null;
            this.colMaterialName.StatusBarKisaYol = null;
            this.colMaterialName.StatusBarKisaYolAciklama = null;
            this.colMaterialName.Visible = true;
            this.colMaterialName.VisibleIndex = 1;
            // 
            // colWarehouseId
            // 
            this.colWarehouseId.Caption = "WarehouseId";
            this.colWarehouseId.ColumnEdit = this.repositoryItemLookUpDepo;
            this.colWarehouseId.FieldName = "WarehouseId";
            this.colWarehouseId.Name = "colWarehouseId";
            this.colWarehouseId.StatusBarAciklama = null;
            this.colWarehouseId.StatusBarKisaYol = null;
            this.colWarehouseId.StatusBarKisaYolAciklama = null;
            this.colWarehouseId.Visible = true;
            this.colWarehouseId.VisibleIndex = 7;
            // 
            // repositoryItemLookUpDepo
            // 
            this.repositoryItemLookUpDepo.AutoHeight = false;
            this.repositoryItemLookUpDepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpDepo.Name = "repositoryItemLookUpDepo";
            // 
            // colWarehouseName
            // 
            this.colWarehouseName.Caption = "Depo";
            this.colWarehouseName.FieldName = "WarehouseName";
            this.colWarehouseName.Name = "colWarehouseName";
            this.colWarehouseName.OptionsColumn.AllowEdit = false;
            this.colWarehouseName.StatusBarAciklama = null;
            this.colWarehouseName.StatusBarKisaYol = null;
            this.colWarehouseName.StatusBarKisaYolAciklama = null;
            this.colWarehouseName.Visible = true;
            this.colWarehouseName.VisibleIndex = 5;
            // 
            // colUnitId
            // 
            this.colUnitId.Caption = "UnitId";
            this.colUnitId.ColumnEdit = this.repositoryItemLookUpUnit;
            this.colUnitId.FieldName = "UnitId";
            this.colUnitId.Name = "colUnitId";
            this.colUnitId.StatusBarAciklama = null;
            this.colUnitId.StatusBarKisaYol = null;
            this.colUnitId.StatusBarKisaYolAciklama = null;
            this.colUnitId.Visible = true;
            this.colUnitId.VisibleIndex = 2;
            // 
            // repositoryItemLookUpUnit
            // 
            this.repositoryItemLookUpUnit.AutoHeight = false;
            this.repositoryItemLookUpUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpUnit.Name = "repositoryItemLookUpUnit";
            // 
            // UnitCode
            // 
            this.UnitCode.Caption = "Birim";
            this.UnitCode.FieldName = "UnitCode";
            this.UnitCode.Name = "UnitCode";
            this.UnitCode.OptionsColumn.AllowEdit = false;
            this.UnitCode.StatusBarAciklama = null;
            this.UnitCode.StatusBarKisaYol = null;
            this.UnitCode.StatusBarKisaYolAciklama = null;
            this.UnitCode.Visible = true;
            this.UnitCode.VisibleIndex = 3;
            // 
            // colUnitQty
            // 
            this.colUnitQty.Caption = "Birim İhtiyaç";
            this.colUnitQty.FieldName = "UnitQty";
            this.colUnitQty.Name = "colUnitQty";
            this.colUnitQty.StatusBarAciklama = null;
            this.colUnitQty.StatusBarKisaYol = null;
            this.colUnitQty.StatusBarKisaYolAciklama = null;
            this.colUnitQty.Visible = true;
            this.colUnitQty.VisibleIndex = 4;
            // 
            // colWastageQty
            // 
            this.colWastageQty.Caption = "Fire Miktarı";
            this.colWastageQty.FieldName = "WastageQty";
            this.colWastageQty.Name = "colWastageQty";
            this.colWastageQty.StatusBarAciklama = null;
            this.colWastageQty.StatusBarKisaYol = null;
            this.colWastageQty.StatusBarKisaYolAciklama = null;
            this.colWastageQty.Visible = true;
            this.colWastageQty.VisibleIndex = 6;
            // 
            // repositoryItemCalc
            // 
            this.repositoryItemCalc.AutoHeight = false;
            this.repositoryItemCalc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalc.DisplayFormat.FormatString = "n3";
            this.repositoryItemCalc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalc.EditFormat.FormatString = "n3";
            this.repositoryItemCalc.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalc.Name = "repositoryItemCalc";
            // 
            // colTotalRequestQty
            // 
            this.colTotalRequestQty.Caption = "Tolam İhtiyaç";
            this.colTotalRequestQty.ColumnEdit = this.repositoryItemCalc;
            this.colTotalRequestQty.FieldName = "TotalRequestQty";
            this.colTotalRequestQty.Name = "colTotalRequestQty";
            this.colTotalRequestQty.OptionsColumn.AllowEdit = false;
            this.colTotalRequestQty.StatusBarAciklama = null;
            this.colTotalRequestQty.StatusBarKisaYol = null;
            this.colTotalRequestQty.StatusBarKisaYolAciklama = null;
            this.colTotalRequestQty.Visible = true;
            this.colTotalRequestQty.VisibleIndex = 8;
            // 
            // colRemainingRequestQty
            // 
            this.colRemainingRequestQty.Caption = "Kalan İhtiyaç";
            this.colRemainingRequestQty.FieldName = "RemainingRequestQty";
            this.colRemainingRequestQty.Name = "colRemainingRequestQty";
            this.colRemainingRequestQty.OptionsColumn.AllowEdit = false;
            this.colRemainingRequestQty.StatusBarAciklama = null;
            this.colRemainingRequestQty.StatusBarKisaYol = null;
            this.colRemainingRequestQty.StatusBarKisaYolAciklama = null;
            this.colRemainingRequestQty.Visible = true;
            this.colRemainingRequestQty.VisibleIndex = 9;
            // 
            // WorkOrderMaterialTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "WorkOrderMaterialTable";
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpDepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colOwnerFormId;
        private UserControls.Grid.MyGridColumn colMrpBilgileriId;
        private UserControls.Grid.MyGridColumn colMalzemeIhtiyacBilgileriId;
        private UserControls.Grid.MyGridColumn colBagliOlduguReceteId;
        private UserControls.Grid.MyGridColumn colMaterialId;
        private UserControls.Grid.MyGridColumn colMaterialCode;
        private UserControls.Grid.MyGridColumn colMaterialName;
        private UserControls.Grid.MyGridColumn colWarehouseId;
        private UserControls.Grid.MyGridColumn colWarehouseName;
        private UserControls.Grid.MyGridColumn colUnitId;
        private UserControls.Grid.MyGridColumn UnitCode;
        private UserControls.Grid.MyGridColumn colUnitQty;
        private UserControls.Grid.MyGridColumn colWastageQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpDepo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalc;
        private UserControls.Grid.MyGridColumn colTotalRequestQty;
        private UserControls.Grid.MyGridColumn colRemainingRequestQty;
    }
}

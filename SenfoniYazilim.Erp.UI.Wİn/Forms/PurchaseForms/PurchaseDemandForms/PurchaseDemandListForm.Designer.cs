namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.PurchaseDemandForms
{
    partial class PurchaseDemandListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseDemandListForm));
            this.longNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.LongNavigator();
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKod = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colRecordDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCreatorName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUpdatingName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUpdatingDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDemandDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colProjeId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colResponsibilityName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
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
            this.colProjeId,
            this.colResponsibilityName,
            this.colRecordDate,
            this.colCreatorName,
            this.colUpdatingDate,
            this.colUpdatingName,
            this.colDemandDescription});
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
            this.tablo.ViewCaption = "Satınalma Talep Kartları";
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
            this.colKod.Caption = "Talep Kodu";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 1;
            // 
            // colRecordDate
            // 
            this.colRecordDate.Caption = "Kayıt Tarihi";
            this.colRecordDate.FieldName = "RecordDate";
            this.colRecordDate.Name = "colRecordDate";
            this.colRecordDate.OptionsColumn.AllowEdit = false;
            this.colRecordDate.StatusBarAciklama = null;
            this.colRecordDate.StatusBarKisaYol = null;
            this.colRecordDate.StatusBarKisaYolAciklama = null;
            this.colRecordDate.Visible = true;
            this.colRecordDate.VisibleIndex = 5;
            // 
            // colCreatorName
            // 
            this.colCreatorName.Caption = "Kaydı Oluşturan";
            this.colCreatorName.FieldName = "CreatorName";
            this.colCreatorName.Name = "colCreatorName";
            this.colCreatorName.OptionsColumn.AllowEdit = false;
            this.colCreatorName.StatusBarAciklama = null;
            this.colCreatorName.StatusBarKisaYol = null;
            this.colCreatorName.StatusBarKisaYolAciklama = null;
            this.colCreatorName.Visible = true;
            this.colCreatorName.VisibleIndex = 4;
            this.colCreatorName.Width = 104;
            // 
            // colUpdatingName
            // 
            this.colUpdatingName.Caption = "Güncelleyen";
            this.colUpdatingName.FieldName = "UpdatingName";
            this.colUpdatingName.Name = "colUpdatingName";
            this.colUpdatingName.OptionsColumn.AllowEdit = false;
            this.colUpdatingName.StatusBarAciklama = null;
            this.colUpdatingName.StatusBarKisaYol = null;
            this.colUpdatingName.StatusBarKisaYolAciklama = null;
            this.colUpdatingName.Visible = true;
            this.colUpdatingName.VisibleIndex = 6;
            // 
            // colUpdatingDate
            // 
            this.colUpdatingDate.Caption = "Güncelleme Tarihi";
            this.colUpdatingDate.FieldName = "UpdatingDate";
            this.colUpdatingDate.Name = "colUpdatingDate";
            this.colUpdatingDate.OptionsColumn.AllowEdit = false;
            this.colUpdatingDate.StatusBarAciklama = null;
            this.colUpdatingDate.StatusBarKisaYol = null;
            this.colUpdatingDate.StatusBarKisaYolAciklama = null;
            this.colUpdatingDate.Visible = true;
            this.colUpdatingDate.VisibleIndex = 7;
            this.colUpdatingDate.Width = 123;
            // 
            // colDemandDescription
            // 
            this.colDemandDescription.Caption = "Açıklama";
            this.colDemandDescription.FieldName = "DemandDescription";
            this.colDemandDescription.Name = "colDemandDescription";
            this.colDemandDescription.OptionsColumn.AllowEdit = false;
            this.colDemandDescription.StatusBarAciklama = null;
            this.colDemandDescription.StatusBarKisaYol = null;
            this.colDemandDescription.StatusBarKisaYolAciklama = null;
            this.colDemandDescription.Visible = true;
            this.colDemandDescription.VisibleIndex = 2;
            this.colDemandDescription.Width = 199;
            // 
            // colProjeId
            // 
            this.colProjeId.Caption = "ProjeId ";
            this.colProjeId.FieldName = "ProjeId";
            this.colProjeId.Name = "colProjeId";
            this.colProjeId.OptionsColumn.AllowEdit = false;
            this.colProjeId.StatusBarAciklama = null;
            this.colProjeId.StatusBarKisaYol = null;
            this.colProjeId.StatusBarKisaYolAciklama = null;
            this.colProjeId.Visible = true;
            this.colProjeId.VisibleIndex = 0;
            // 
            // colResponsibilityName
            // 
            this.colResponsibilityName.Caption = "Satınalma Sorumlusu";
            this.colResponsibilityName.FieldName = "ResponsibilityName";
            this.colResponsibilityName.Name = "colResponsibilityName";
            this.colResponsibilityName.OptionsColumn.AllowEdit = false;
            this.colResponsibilityName.StatusBarAciklama = null;
            this.colResponsibilityName.StatusBarKisaYol = null;
            this.colResponsibilityName.StatusBarKisaYolAciklama = null;
            this.colResponsibilityName.Visible = true;
            this.colResponsibilityName.VisibleIndex = 3;
            this.colResponsibilityName.Width = 196;
            // 
            // PurchaseDemandListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 446);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "PurchaseDemandListForm";
            this.Text = "Satınalma Talepleri";
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
        private UserControls.Grid.MyGridColumn colRecordDate;
        private UserControls.Grid.MyGridColumn colCreatorName;
        private UserControls.Grid.MyGridColumn colUpdatingName;
        private UserControls.Grid.MyGridColumn colUpdatingDate;
        private UserControls.Grid.MyGridColumn colDemandDescription;
        private UserControls.Grid.MyGridColumn colProjeId;
        private UserControls.Grid.MyGridColumn colResponsibilityName;
    }
}
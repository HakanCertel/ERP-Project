namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.GenelEditFormTable
{
    partial class RolYetkileriTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolYetkileriTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colKartTuru = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colGorebilir = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colEkleyebilir = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDegistirebilir = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSilebilir = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Appearance.BackColor = System.Drawing.Color.White;
            this.panelButtons.Appearance.Options.UseBackColor = true;
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
            // insUpNavigator
            // 
            this.insUpNavigator.Size = new System.Drawing.Size(612, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(27, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryCheck});
            this.grid.Size = new System.Drawing.Size(612, 229);
            this.grid.TabIndex = 17;
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
            this.colKartTuru,
            this.colGorebilir,
            this.colEkleyebilir,
            this.colDegistirebilir,
            this.colSilebilir});
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
            this.tablo.ViewCaption = "Rol Yetkileri";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.ColumnEdit = this.repositoryCheck;
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = null;
            this.colId.StatusBarKisaYolAciklama = null;
            // 
            // repositoryCheck
            // 
            this.repositoryCheck.AutoHeight = false;
            this.repositoryCheck.Name = "repositoryCheck";
            this.repositoryCheck.ValueChecked = ((byte)(1));
            this.repositoryCheck.ValueGrayed = ((byte)(2));
            this.repositoryCheck.ValueUnchecked = ((byte)(0));
            // 
            // colKartTuru
            // 
            this.colKartTuru.Caption = "Kart Türü";
            this.colKartTuru.FieldName = "KartTuru";
            this.colKartTuru.Name = "colKartTuru";
            this.colKartTuru.OptionsColumn.AllowEdit = false;
            this.colKartTuru.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKartTuru.OptionsFilter.AllowAutoFilter = false;
            this.colKartTuru.OptionsFilter.AllowFilter = false;
            this.colKartTuru.StatusBarAciklama = null;
            this.colKartTuru.StatusBarKisaYol = null;
            this.colKartTuru.StatusBarKisaYolAciklama = null;
            this.colKartTuru.Visible = true;
            this.colKartTuru.VisibleIndex = 0;
            this.colKartTuru.Width = 296;
            // 
            // colGorebilir
            // 
            this.colGorebilir.Caption = "Görebilir";
            this.colGorebilir.ColumnEdit = this.repositoryCheck;
            this.colGorebilir.FieldName = "Gorebilir";
            this.colGorebilir.Name = "colGorebilir";
            this.colGorebilir.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGorebilir.OptionsFilter.AllowAutoFilter = false;
            this.colGorebilir.OptionsFilter.AllowFilter = false;
            this.colGorebilir.StatusBarAciklama = null;
            this.colGorebilir.StatusBarKisaYol = null;
            this.colGorebilir.StatusBarKisaYolAciklama = null;
            this.colGorebilir.Visible = true;
            this.colGorebilir.VisibleIndex = 1;
            // 
            // colEkleyebilir
            // 
            this.colEkleyebilir.Caption = "Ekleyebilir ";
            this.colEkleyebilir.ColumnEdit = this.repositoryCheck;
            this.colEkleyebilir.FieldName = "Ekleyebilir";
            this.colEkleyebilir.Name = "colEkleyebilir";
            this.colEkleyebilir.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEkleyebilir.OptionsFilter.AllowAutoFilter = false;
            this.colEkleyebilir.OptionsFilter.AllowFilter = false;
            this.colEkleyebilir.StatusBarAciklama = null;
            this.colEkleyebilir.StatusBarKisaYol = null;
            this.colEkleyebilir.StatusBarKisaYolAciklama = null;
            this.colEkleyebilir.Visible = true;
            this.colEkleyebilir.VisibleIndex = 2;
            // 
            // colDegistirebilir
            // 
            this.colDegistirebilir.Caption = "Değiştirebilir";
            this.colDegistirebilir.ColumnEdit = this.repositoryCheck;
            this.colDegistirebilir.FieldName = "Degistirebilir";
            this.colDegistirebilir.Name = "colDegistirebilir";
            this.colDegistirebilir.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDegistirebilir.OptionsFilter.AllowAutoFilter = false;
            this.colDegistirebilir.OptionsFilter.AllowFilter = false;
            this.colDegistirebilir.StatusBarAciklama = null;
            this.colDegistirebilir.StatusBarKisaYol = null;
            this.colDegistirebilir.StatusBarKisaYolAciklama = null;
            this.colDegistirebilir.Visible = true;
            this.colDegistirebilir.VisibleIndex = 3;
            // 
            // colSilebilir
            // 
            this.colSilebilir.Caption = "Silebilir ";
            this.colSilebilir.ColumnEdit = this.repositoryCheck;
            this.colSilebilir.FieldName = "Silebilir";
            this.colSilebilir.Name = "colSilebilir";
            this.colSilebilir.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSilebilir.OptionsFilter.AllowAutoFilter = false;
            this.colSilebilir.OptionsFilter.AllowFilter = false;
            this.colSilebilir.StatusBarAciklama = null;
            this.colSilebilir.StatusBarKisaYol = null;
            this.colSilebilir.StatusBarKisaYolAciklama = null;
            this.colSilebilir.Visible = true;
            this.colSilebilir.VisibleIndex = 4;
            // 
            // RolYetkileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "RolYetkileriTable";
            this.Size = new System.Drawing.Size(639, 253);
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colId;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryCheck;
        private Grid.MyGridColumn colKartTuru;
        private Grid.MyGridColumn colGorebilir;
        private Grid.MyGridColumn colEkleyebilir;
        private Grid.MyGridColumn colDegistirebilir;
        private Grid.MyGridColumn colSilebilir;
    }
}

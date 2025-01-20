namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.WarehouseSettingsForms
{
    partial class WarehouseSettingsTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseSettingsTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colUserId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKullaniciAdiSoyadi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKullaniciYetkisi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCanDemand = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCanTransfer = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
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
            this.colUserId,
            this.colKullaniciAdiSoyadi,
            this.colKullaniciYetkisi,
            this.colCanDemand,
            this.colCanTransfer});
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
            this.tablo.ViewCaption = "Ayarlar";
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
            // colUserId
            // 
            this.colUserId.Caption = "UserId";
            this.colUserId.FieldName = "UserId";
            this.colUserId.Name = "colUserId";
            this.colUserId.OptionsColumn.AllowEdit = false;
            this.colUserId.OptionsColumn.ShowInCustomizationForm = false;
            this.colUserId.StatusBarAciklama = null;
            this.colUserId.StatusBarKisaYol = null;
            this.colUserId.StatusBarKisaYolAciklama = null;
            // 
            // colKullaniciAdiSoyadi
            // 
            this.colKullaniciAdiSoyadi.Caption = "Kullanici";
            this.colKullaniciAdiSoyadi.FieldName = "KullaniciAdiSoyadi";
            this.colKullaniciAdiSoyadi.Name = "colKullaniciAdiSoyadi";
            this.colKullaniciAdiSoyadi.StatusBarAciklama = null;
            this.colKullaniciAdiSoyadi.StatusBarKisaYol = null;
            this.colKullaniciAdiSoyadi.StatusBarKisaYolAciklama = null;
            this.colKullaniciAdiSoyadi.Visible = true;
            this.colKullaniciAdiSoyadi.VisibleIndex = 0;
            this.colKullaniciAdiSoyadi.Width = 199;
            // 
            // colKullaniciYetkisi
            // 
            this.colKullaniciYetkisi.Caption = "Yetki";
            this.colKullaniciYetkisi.FieldName = "KullaniciYetkisi";
            this.colKullaniciYetkisi.Name = "colKullaniciYetkisi";
            this.colKullaniciYetkisi.StatusBarAciklama = null;
            this.colKullaniciYetkisi.StatusBarKisaYol = null;
            this.colKullaniciYetkisi.StatusBarKisaYolAciklama = null;
            this.colKullaniciYetkisi.Visible = true;
            this.colKullaniciYetkisi.VisibleIndex = 1;
            this.colKullaniciYetkisi.Width = 110;
            // 
            // colCanDemand
            // 
            this.colCanDemand.Caption = "Talep Edebilir";
            this.colCanDemand.FieldName = "CanDemand";
            this.colCanDemand.Name = "colCanDemand";
            this.colCanDemand.StatusBarAciklama = null;
            this.colCanDemand.StatusBarKisaYol = null;
            this.colCanDemand.StatusBarKisaYolAciklama = null;
            this.colCanDemand.Visible = true;
            this.colCanDemand.VisibleIndex = 2;
            this.colCanDemand.Width = 97;
            // 
            // colCanTransfer
            // 
            this.colCanTransfer.Caption = "Transfer Edebilir";
            this.colCanTransfer.FieldName = "CanTransfer";
            this.colCanTransfer.Name = "colCanTransfer";
            this.colCanTransfer.StatusBarAciklama = null;
            this.colCanTransfer.StatusBarKisaYol = null;
            this.colCanTransfer.StatusBarKisaYolAciklama = null;
            this.colCanTransfer.Visible = true;
            this.colCanTransfer.VisibleIndex = 3;
            this.colCanTransfer.Width = 94;
            // 
            // WarehouseSettingsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "WarehouseSettingsTable";
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKullaniciAdiSoyadi;
        private UserControls.Grid.MyGridColumn colKullaniciYetkisi;
        private UserControls.Grid.MyGridColumn colCanDemand;
        private UserControls.Grid.MyGridColumn colCanTransfer;
        private UserControls.Grid.MyGridColumn colUserId;
    }
}

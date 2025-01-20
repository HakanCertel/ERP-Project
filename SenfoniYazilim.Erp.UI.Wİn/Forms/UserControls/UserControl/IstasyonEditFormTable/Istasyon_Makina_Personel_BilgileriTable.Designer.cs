namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.IstasyonEditFormTable
{
    partial class Istasyon_Makina_Personel_BilgileriTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Istasyon_Makina_Personel_BilgileriTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colMakinaId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMakinaKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemMakina = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colMakinaAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPersonelId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPersonelAdiSoyadi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemPersonel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colAciklama = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMakina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPersonel)).BeginInit();
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
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(27, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMakina,
            this.repositoryItemPersonel});
            this.grid.Size = new System.Drawing.Size(527, 229);
            this.grid.TabIndex = 5;
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
            this.colMakinaId,
            this.colMakinaKodu,
            this.colMakinaAdi,
            this.colPersonelId,
            this.colPersonelAdiSoyadi,
            this.colAciklama});
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
            this.tablo.ViewCaption = "İstasyon Makina-Personel Bilgileri";
            // 
            // colMakinaId
            // 
            this.colMakinaId.Caption = "MakinaId";
            this.colMakinaId.FieldName = "MakinaId";
            this.colMakinaId.Name = "colMakinaId";
            this.colMakinaId.OptionsColumn.AllowEdit = false;
            this.colMakinaId.OptionsColumn.ShowInCustomizationForm = false;
            this.colMakinaId.StatusBarAciklama = null;
            this.colMakinaId.StatusBarKisaYol = null;
            this.colMakinaId.StatusBarKisaYolAciklama = null;
            // 
            // colMakinaKodu
            // 
            this.colMakinaKodu.Caption = "Makina Kodu";
            this.colMakinaKodu.FieldName = "MakinaKodu";
            this.colMakinaKodu.Name = "colMakinaKodu";
            this.colMakinaKodu.OptionsColumn.AllowEdit = false;
            this.colMakinaKodu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMakinaKodu.OptionsFilter.AllowAutoFilter = false;
            this.colMakinaKodu.OptionsFilter.AllowFilter = false;
            this.colMakinaKodu.StatusBarAciklama = null;
            this.colMakinaKodu.StatusBarKisaYol = null;
            this.colMakinaKodu.StatusBarKisaYolAciklama = null;
            this.colMakinaKodu.Visible = true;
            this.colMakinaKodu.VisibleIndex = 0;
            this.colMakinaKodu.Width = 125;
            // 
            // repositoryItemMakina
            // 
            this.repositoryItemMakina.AutoHeight = false;
            this.repositoryItemMakina.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemMakina.Name = "repositoryItemMakina";
            this.repositoryItemMakina.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colMakinaAdi
            // 
            this.colMakinaAdi.Caption = "Makina";
            this.colMakinaAdi.FieldName = "MakinaAdi";
            this.colMakinaAdi.Name = "colMakinaAdi";
            this.colMakinaAdi.OptionsColumn.AllowEdit = false;
            this.colMakinaAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMakinaAdi.OptionsFilter.AllowAutoFilter = false;
            this.colMakinaAdi.OptionsFilter.AllowFilter = false;
            this.colMakinaAdi.StatusBarAciklama = null;
            this.colMakinaAdi.StatusBarKisaYol = null;
            this.colMakinaAdi.StatusBarKisaYolAciklama = null;
            this.colMakinaAdi.Visible = true;
            this.colMakinaAdi.VisibleIndex = 1;
            this.colMakinaAdi.Width = 283;
            // 
            // colPersonelId
            // 
            this.colPersonelId.Caption = "PersonelId";
            this.colPersonelId.FieldName = "PersonelId";
            this.colPersonelId.Name = "colPersonelId";
            this.colPersonelId.OptionsColumn.AllowEdit = false;
            this.colPersonelId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPersonelId.OptionsColumn.ShowInCustomizationForm = false;
            this.colPersonelId.OptionsFilter.AllowAutoFilter = false;
            this.colPersonelId.OptionsFilter.AllowFilter = false;
            this.colPersonelId.StatusBarAciklama = null;
            this.colPersonelId.StatusBarKisaYol = null;
            this.colPersonelId.StatusBarKisaYolAciklama = null;
            // 
            // colPersonelAdiSoyadi
            // 
            this.colPersonelAdiSoyadi.Caption = "Personel";
            this.colPersonelAdiSoyadi.ColumnEdit = this.repositoryItemPersonel;
            this.colPersonelAdiSoyadi.FieldName = "PersonelAdiSoyadi";
            this.colPersonelAdiSoyadi.Name = "colPersonelAdiSoyadi";
            this.colPersonelAdiSoyadi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPersonelAdiSoyadi.OptionsFilter.AllowAutoFilter = false;
            this.colPersonelAdiSoyadi.OptionsFilter.AllowFilter = false;
            this.colPersonelAdiSoyadi.StatusBarAciklama = null;
            this.colPersonelAdiSoyadi.StatusBarKisaYol = null;
            this.colPersonelAdiSoyadi.StatusBarKisaYolAciklama = null;
            this.colPersonelAdiSoyadi.Visible = true;
            this.colPersonelAdiSoyadi.VisibleIndex = 2;
            this.colPersonelAdiSoyadi.Width = 251;
            // 
            // repositoryItemPersonel
            // 
            this.repositoryItemPersonel.AutoHeight = false;
            this.repositoryItemPersonel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemPersonel.Name = "repositoryItemPersonel";
            this.repositoryItemPersonel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAciklama.OptionsFilter.AllowAutoFilter = false;
            this.colAciklama.OptionsFilter.AllowFilter = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 3;
            this.colAciklama.Width = 358;
            // 
            // Istasyon_Makina_Personel_BilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "Istasyon_Makina_Personel_BilgileriTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMakina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colMakinaId;
        private Grid.MyGridColumn colMakinaKodu;
        private Grid.MyGridColumn colMakinaAdi;
        private Grid.MyGridColumn colPersonelId;
        private Grid.MyGridColumn colPersonelAdiSoyadi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemMakina;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemPersonel;
        private Grid.MyGridColumn colAciklama;
    }
}

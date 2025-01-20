namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.ReceteForms.ReceteEditFormTable
{
    partial class ReceteOperasyonBilgiTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceteOperasyonBilgiTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colOperasyonId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOperasyonKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemOperasyon = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colOperasyonAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOperasyonSirasi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colAciklama = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemIstasyon = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemMakina = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemOperasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIstasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMakina)).BeginInit();
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
            this.repositoryItemOperasyon,
            this.repositoryItemIstasyon,
            this.repositoryItemMakina});
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
            this.colOperasyonId,
            this.colOperasyonKodu,
            this.colOperasyonAdi,
            this.colOperasyonSirasi,
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
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Operasyon Bilgileri";
            // 
            // colOperasyonId
            // 
            this.colOperasyonId.Caption = "OperasyonId ";
            this.colOperasyonId.FieldName = "OperasyonId";
            this.colOperasyonId.Name = "colOperasyonId";
            this.colOperasyonId.OptionsColumn.AllowEdit = false;
            this.colOperasyonId.OptionsColumn.ShowInCustomizationForm = false;
            this.colOperasyonId.StatusBarAciklama = null;
            this.colOperasyonId.StatusBarKisaYol = null;
            this.colOperasyonId.StatusBarKisaYolAciklama = null;
            // 
            // colOperasyonKodu
            // 
            this.colOperasyonKodu.AppearanceCell.Options.UseTextOptions = true;
            this.colOperasyonKodu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOperasyonKodu.Caption = "Operasyon Kodu";
            this.colOperasyonKodu.ColumnEdit = this.repositoryItemOperasyon;
            this.colOperasyonKodu.FieldName = "OperasyonKodu";
            this.colOperasyonKodu.Name = "colOperasyonKodu";
            this.colOperasyonKodu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colOperasyonKodu.OptionsFilter.AllowAutoFilter = false;
            this.colOperasyonKodu.OptionsFilter.AllowFilter = false;
            this.colOperasyonKodu.StatusBarAciklama = null;
            this.colOperasyonKodu.StatusBarKisaYol = null;
            this.colOperasyonKodu.StatusBarKisaYolAciklama = null;
            this.colOperasyonKodu.Visible = true;
            this.colOperasyonKodu.VisibleIndex = 1;
            this.colOperasyonKodu.Width = 49;
            // 
            // repositoryItemOperasyon
            // 
            this.repositoryItemOperasyon.AutoHeight = false;
            this.repositoryItemOperasyon.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemOperasyon.Name = "repositoryItemOperasyon";
            this.repositoryItemOperasyon.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colOperasyonAdi
            // 
            this.colOperasyonAdi.Caption = "Operasyon Adı";
            this.colOperasyonAdi.FieldName = "OperasyonAdi";
            this.colOperasyonAdi.Name = "colOperasyonAdi";
            this.colOperasyonAdi.OptionsColumn.AllowEdit = false;
            this.colOperasyonAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colOperasyonAdi.OptionsFilter.AllowAutoFilter = false;
            this.colOperasyonAdi.OptionsFilter.AllowFilter = false;
            this.colOperasyonAdi.StatusBarAciklama = null;
            this.colOperasyonAdi.StatusBarKisaYol = null;
            this.colOperasyonAdi.StatusBarKisaYolAciklama = null;
            this.colOperasyonAdi.Visible = true;
            this.colOperasyonAdi.VisibleIndex = 2;
            this.colOperasyonAdi.Width = 406;
            // 
            // colOperasyonSirasi
            // 
            this.colOperasyonSirasi.Caption = "Operasyon Sırası";
            this.colOperasyonSirasi.FieldName = "OperasyonSirasi";
            this.colOperasyonSirasi.Name = "colOperasyonSirasi";
            this.colOperasyonSirasi.OptionsColumn.AllowEdit = false;
            this.colOperasyonSirasi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colOperasyonSirasi.OptionsFilter.AllowAutoFilter = false;
            this.colOperasyonSirasi.OptionsFilter.AllowFilter = false;
            this.colOperasyonSirasi.StatusBarAciklama = null;
            this.colOperasyonSirasi.StatusBarKisaYol = null;
            this.colOperasyonSirasi.StatusBarKisaYolAciklama = null;
            this.colOperasyonSirasi.Visible = true;
            this.colOperasyonSirasi.VisibleIndex = 0;
            this.colOperasyonSirasi.Width = 99;
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
            this.colAciklama.Width = 40;
            // 
            // repositoryItemIstasyon
            // 
            this.repositoryItemIstasyon.AutoHeight = false;
            this.repositoryItemIstasyon.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemIstasyon.Name = "repositoryItemIstasyon";
            this.repositoryItemIstasyon.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemMakina
            // 
            this.repositoryItemMakina.AutoHeight = false;
            this.repositoryItemMakina.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemMakina.Name = "repositoryItemMakina";
            this.repositoryItemMakina.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // ReceteOperasyonBilgiTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "ReceteOperasyonBilgiTable";
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemOperasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIstasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMakina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colOperasyonId;
        private UserControls.Grid.MyGridColumn colOperasyonKodu;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemOperasyon;
        private UserControls.Grid.MyGridColumn colOperasyonAdi;
        private UserControls.Grid.MyGridColumn colOperasyonSirasi;
        private UserControls.Grid.MyGridColumn colAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemIstasyon;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemMakina;
    }
}

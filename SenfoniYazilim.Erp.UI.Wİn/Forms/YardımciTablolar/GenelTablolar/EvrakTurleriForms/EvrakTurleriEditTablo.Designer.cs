namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.EvrakTurleriForms
{
    partial class EvrakTurleriEditTablo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvrakTurleriEditTablo));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colKayitTarihi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colGuncellemeTarihi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKaydiOlusturan = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKaydiGuncelleyen = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colEvrakTurKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colEvrakTurAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colEvrakTurTipi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokEtkilenir = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDurum = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colEFaturaOlusturulamaz = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryYakinlik = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryYakinlik)).BeginInit();
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
            this.repositoryYakinlik,
            this.repositoryCheckBox});
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
            this.colKayitTarihi,
            this.colGuncellemeTarihi,
            this.colKaydiOlusturan,
            this.colKaydiGuncelleyen,
            this.colEvrakTurKodu,
            this.colEvrakTurAdi,
            this.colEvrakTurTipi,
            this.colStokEtkilenir,
            this.colDurum,
            this.colEFaturaOlusturulamaz});
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
            this.tablo.ViewCaption = "Evrak Türleri";
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.Caption = "Kayıt Tarihi";
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKayitTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colKayitTarihi.OptionsFilter.AllowFilter = false;
            this.colKayitTarihi.StatusBarAciklama = null;
            this.colKayitTarihi.StatusBarKisaYol = null;
            this.colKayitTarihi.StatusBarKisaYolAciklama = null;
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.VisibleIndex = 0;
            // 
            // colGuncellemeTarihi
            // 
            this.colGuncellemeTarihi.Caption = "Güncelleme Tarihi";
            this.colGuncellemeTarihi.FieldName = "GuncellemeTarihi";
            this.colGuncellemeTarihi.Name = "colGuncellemeTarihi";
            this.colGuncellemeTarihi.OptionsColumn.AllowEdit = false;
            this.colGuncellemeTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGuncellemeTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colGuncellemeTarihi.OptionsFilter.AllowFilter = false;
            this.colGuncellemeTarihi.StatusBarAciklama = null;
            this.colGuncellemeTarihi.StatusBarKisaYol = null;
            this.colGuncellemeTarihi.StatusBarKisaYolAciklama = null;
            this.colGuncellemeTarihi.Visible = true;
            this.colGuncellemeTarihi.VisibleIndex = 1;
            // 
            // colKaydiOlusturan
            // 
            this.colKaydiOlusturan.Caption = "Kaydı Oluşturan";
            this.colKaydiOlusturan.FieldName = "KaydiOlusturan";
            this.colKaydiOlusturan.Name = "colKaydiOlusturan";
            this.colKaydiOlusturan.OptionsColumn.AllowEdit = false;
            this.colKaydiOlusturan.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKaydiOlusturan.OptionsFilter.AllowAutoFilter = false;
            this.colKaydiOlusturan.OptionsFilter.AllowFilter = false;
            this.colKaydiOlusturan.StatusBarAciklama = null;
            this.colKaydiOlusturan.StatusBarKisaYol = null;
            this.colKaydiOlusturan.StatusBarKisaYolAciklama = null;
            this.colKaydiOlusturan.Visible = true;
            this.colKaydiOlusturan.VisibleIndex = 2;
            // 
            // colKaydiGuncelleyen
            // 
            this.colKaydiGuncelleyen.Caption = "Kaydı Güncelleyen";
            this.colKaydiGuncelleyen.FieldName = "KaydiGuncelleyen";
            this.colKaydiGuncelleyen.Name = "colKaydiGuncelleyen";
            this.colKaydiGuncelleyen.OptionsColumn.AllowEdit = false;
            this.colKaydiGuncelleyen.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKaydiGuncelleyen.OptionsFilter.AllowAutoFilter = false;
            this.colKaydiGuncelleyen.OptionsFilter.AllowFilter = false;
            this.colKaydiGuncelleyen.StatusBarAciklama = null;
            this.colKaydiGuncelleyen.StatusBarKisaYol = null;
            this.colKaydiGuncelleyen.StatusBarKisaYolAciklama = null;
            this.colKaydiGuncelleyen.Visible = true;
            this.colKaydiGuncelleyen.VisibleIndex = 3;
            // 
            // colEvrakTurKodu
            // 
            this.colEvrakTurKodu.Caption = "Evrak Tur Kodu";
            this.colEvrakTurKodu.FieldName = "EvrakTurKodu";
            this.colEvrakTurKodu.Name = "colEvrakTurKodu";
            this.colEvrakTurKodu.OptionsFilter.AllowAutoFilter = false;
            this.colEvrakTurKodu.OptionsFilter.AllowFilter = false;
            this.colEvrakTurKodu.StatusBarAciklama = null;
            this.colEvrakTurKodu.StatusBarKisaYol = null;
            this.colEvrakTurKodu.StatusBarKisaYolAciklama = null;
            this.colEvrakTurKodu.Visible = true;
            this.colEvrakTurKodu.VisibleIndex = 5;
            // 
            // colEvrakTurAdi
            // 
            this.colEvrakTurAdi.Caption = "Evrak Tur Adı";
            this.colEvrakTurAdi.FieldName = "EvrakTurAdi";
            this.colEvrakTurAdi.Name = "colEvrakTurAdi";
            this.colEvrakTurAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colEvrakTurAdi.OptionsFilter.AllowAutoFilter = false;
            this.colEvrakTurAdi.OptionsFilter.AllowFilter = false;
            this.colEvrakTurAdi.StatusBarAciklama = null;
            this.colEvrakTurAdi.StatusBarKisaYol = null;
            this.colEvrakTurAdi.StatusBarKisaYolAciklama = null;
            this.colEvrakTurAdi.Visible = true;
            this.colEvrakTurAdi.VisibleIndex = 4;
            // 
            // colEvrakTurTipi
            // 
            this.colEvrakTurTipi.Caption = "Evrak Tur Tipi";
            this.colEvrakTurTipi.FieldName = "EvrakTurTipi";
            this.colEvrakTurTipi.Name = "colEvrakTurTipi";
            this.colEvrakTurTipi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvrakTurTipi.OptionsFilter.AllowAutoFilter = false;
            this.colEvrakTurTipi.OptionsFilter.AllowFilter = false;
            this.colEvrakTurTipi.StatusBarAciklama = null;
            this.colEvrakTurTipi.StatusBarKisaYol = null;
            this.colEvrakTurTipi.StatusBarKisaYolAciklama = null;
            this.colEvrakTurTipi.Visible = true;
            this.colEvrakTurTipi.VisibleIndex = 6;
            // 
            // colStokEtkilenir
            // 
            this.colStokEtkilenir.Caption = "Stok Etkilenir";
            this.colStokEtkilenir.ColumnEdit = this.repositoryCheckBox;
            this.colStokEtkilenir.FieldName = "StokEtkilenir";
            this.colStokEtkilenir.Name = "colStokEtkilenir";
            this.colStokEtkilenir.OptionsFilter.AllowAutoFilter = false;
            this.colStokEtkilenir.OptionsFilter.AllowFilter = false;
            this.colStokEtkilenir.StatusBarAciklama = null;
            this.colStokEtkilenir.StatusBarKisaYol = null;
            this.colStokEtkilenir.StatusBarKisaYolAciklama = null;
            this.colStokEtkilenir.Visible = true;
            this.colStokEtkilenir.VisibleIndex = 7;
            // 
            // repositoryCheckBox
            // 
            this.repositoryCheckBox.AutoHeight = false;
            this.repositoryCheckBox.Name = "repositoryCheckBox";
            // 
            // colDurum
            // 
            this.colDurum.Caption = "Aktif Mi";
            this.colDurum.ColumnEdit = this.repositoryCheckBox;
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDurum.OptionsFilter.AllowAutoFilter = false;
            this.colDurum.OptionsFilter.AllowFilter = false;
            this.colDurum.StatusBarAciklama = null;
            this.colDurum.StatusBarKisaYol = null;
            this.colDurum.StatusBarKisaYolAciklama = null;
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 8;
            // 
            // colEFaturaOlusturulamaz
            // 
            this.colEFaturaOlusturulamaz.Caption = "EFatura Oluşturulamaz";
            this.colEFaturaOlusturulamaz.ColumnEdit = this.repositoryCheckBox;
            this.colEFaturaOlusturulamaz.FieldName = "EFaturaOlusturulamaz";
            this.colEFaturaOlusturulamaz.Name = "colEFaturaOlusturulamaz";
            this.colEFaturaOlusturulamaz.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEFaturaOlusturulamaz.OptionsFilter.AllowAutoFilter = false;
            this.colEFaturaOlusturulamaz.OptionsFilter.AllowFilter = false;
            this.colEFaturaOlusturulamaz.StatusBarAciklama = null;
            this.colEFaturaOlusturulamaz.StatusBarKisaYol = null;
            this.colEFaturaOlusturulamaz.StatusBarKisaYolAciklama = null;
            this.colEFaturaOlusturulamaz.Visible = true;
            this.colEFaturaOlusturulamaz.VisibleIndex = 9;
            // 
            // repositoryYakinlik
            // 
            this.repositoryYakinlik.AutoHeight = false;
            this.repositoryYakinlik.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryYakinlik.Name = "repositoryYakinlik";
            this.repositoryYakinlik.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // EvrakTurleriEditTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "EvrakTurleriEditTablo";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryYakinlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colDurum;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryCheckBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryYakinlik;
        private UserControls.Grid.MyGridColumn colKayitTarihi;
        private UserControls.Grid.MyGridColumn colGuncellemeTarihi;
        private UserControls.Grid.MyGridColumn colKaydiOlusturan;
        private UserControls.Grid.MyGridColumn colKaydiGuncelleyen;
        private UserControls.Grid.MyGridColumn colEvrakTurAdi;
        private UserControls.Grid.MyGridColumn colEvrakTurKodu;
        private UserControls.Grid.MyGridColumn colEvrakTurTipi;
        private UserControls.Grid.MyGridColumn colStokEtkilenir;
        private UserControls.Grid.MyGridColumn colEFaturaOlusturulamaz;
    }
}

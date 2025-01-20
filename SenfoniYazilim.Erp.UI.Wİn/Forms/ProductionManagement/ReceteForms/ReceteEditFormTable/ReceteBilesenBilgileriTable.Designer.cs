namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.ReceteEditFormTable
{
    partial class ReceteBilesenBilgileriTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceteBilesenBilgileriTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colReceteId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOperasyonId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemLookUpOperasyon = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colStokKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokBirim = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colTuketimBirimId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemLookUpBirim = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTuketimDepoId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTuketimDepoAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemTuketimDepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colUretilebilir = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colOperasyonBilgileriId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemStok = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemDurum = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colFireOrani = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpOperasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpBirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTuketimDepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDurum)).BeginInit();
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
            this.repositoryItemStok,
            this.repositoryItemDecimal,
            this.repositoryItemDurum,
            this.repositoryItemCombo,
            this.repositoryItemTuketimDepo,
            this.repositoryItemLookUpOperasyon,
            this.repositoryItemLookUpBirim});
            this.grid.Size = new System.Drawing.Size(612, 203);
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
            this.colReceteId,
            this.colStokId,
            this.colOperasyonId,
            this.colStokKodu,
            this.colStokAdi,
            this.colStokBirim,
            this.colMiktar,
            this.colTuketimBirimId,
            this.colTuketimDepoId,
            this.colTuketimDepoAdi,
            this.colUretilebilir,
            this.colOperasyonBilgileriId,
            this.colFireOrani});
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
            this.tablo.ViewCaption = "Bileşen Bilgileri";
            // 
            // colReceteId
            // 
            this.colReceteId.Caption = "ReceteId";
            this.colReceteId.FieldName = "ReceteId";
            this.colReceteId.Name = "colReceteId";
            this.colReceteId.OptionsColumn.AllowEdit = false;
            this.colReceteId.OptionsColumn.ShowInCustomizationForm = false;
            this.colReceteId.StatusBarAciklama = null;
            this.colReceteId.StatusBarKisaYol = null;
            this.colReceteId.StatusBarKisaYolAciklama = null;
            // 
            // colStokId
            // 
            this.colStokId.Caption = "Stok Id";
            this.colStokId.FieldName = "StokId";
            this.colStokId.Name = "colStokId";
            this.colStokId.OptionsColumn.AllowEdit = false;
            this.colStokId.OptionsColumn.ShowInCustomizationForm = false;
            this.colStokId.StatusBarAciklama = null;
            this.colStokId.StatusBarKisaYol = null;
            this.colStokId.StatusBarKisaYolAciklama = null;
            // 
            // colOperasyonId
            // 
            this.colOperasyonId.Caption = "Operasyon";
            this.colOperasyonId.ColumnEdit = this.repositoryItemLookUpOperasyon;
            this.colOperasyonId.FieldName = "OperasyonId";
            this.colOperasyonId.Name = "colOperasyonId";
            this.colOperasyonId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colOperasyonId.OptionsFilter.AllowAutoFilter = false;
            this.colOperasyonId.OptionsFilter.AllowFilter = false;
            this.colOperasyonId.StatusBarAciklama = null;
            this.colOperasyonId.StatusBarKisaYol = null;
            this.colOperasyonId.StatusBarKisaYolAciklama = null;
            this.colOperasyonId.Visible = true;
            this.colOperasyonId.VisibleIndex = 0;
            // 
            // repositoryItemLookUpOperasyon
            // 
            this.repositoryItemLookUpOperasyon.AutoHeight = false;
            this.repositoryItemLookUpOperasyon.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpOperasyon.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OperasyonId", "OperasyonId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OperasyonAdi", "Operasyon")});
            this.repositoryItemLookUpOperasyon.Name = "repositoryItemLookUpOperasyon";
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.StatusBarAciklama = null;
            this.colStokKodu.StatusBarKisaYol = null;
            this.colStokKodu.StatusBarKisaYolAciklama = null;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 1;
            this.colStokKodu.Width = 101;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.StatusBarAciklama = null;
            this.colStokAdi.StatusBarKisaYol = null;
            this.colStokAdi.StatusBarKisaYolAciklama = null;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 2;
            this.colStokAdi.Width = 274;
            // 
            // colStokBirim
            // 
            this.colStokBirim.Caption = "Stok Birim";
            this.colStokBirim.FieldName = "StokBirim";
            this.colStokBirim.Name = "colStokBirim";
            this.colStokBirim.OptionsColumn.AllowEdit = false;
            this.colStokBirim.StatusBarAciklama = null;
            this.colStokBirim.StatusBarKisaYol = null;
            this.colStokBirim.StatusBarKisaYolAciklama = null;
            this.colStokBirim.Visible = true;
            this.colStokBirim.VisibleIndex = 3;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar ";
            this.colMiktar.ColumnEdit = this.repositoryItemDecimal;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.StatusBarAciklama = null;
            this.colMiktar.StatusBarKisaYol = null;
            this.colMiktar.StatusBarKisaYolAciklama = null;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 4;
            this.colMiktar.Width = 95;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDecimal.DisplayFormat.FormatString = "{0:n4}";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.EditFormat.FormatString = "n4";
            this.repositoryItemDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colTuketimBirimId
            // 
            this.colTuketimBirimId.Caption = "Tüketim Birimi";
            this.colTuketimBirimId.ColumnEdit = this.repositoryItemLookUpBirim;
            this.colTuketimBirimId.FieldName = "TuketimBirimId";
            this.colTuketimBirimId.Name = "colTuketimBirimId";
            this.colTuketimBirimId.StatusBarAciklama = null;
            this.colTuketimBirimId.StatusBarKisaYol = null;
            this.colTuketimBirimId.StatusBarKisaYolAciklama = null;
            this.colTuketimBirimId.Visible = true;
            this.colTuketimBirimId.VisibleIndex = 6;
            // 
            // repositoryItemLookUpBirim
            // 
            this.repositoryItemLookUpBirim.AutoHeight = false;
            this.repositoryItemLookUpBirim.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpBirim.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kod", "Kod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BirimAdi", "Birim Adı")});
            this.repositoryItemLookUpBirim.Name = "repositoryItemLookUpBirim";
            // 
            // colTuketimDepoId
            // 
            this.colTuketimDepoId.Caption = "TuketimDepoId";
            this.colTuketimDepoId.FieldName = "TuketimDepoId";
            this.colTuketimDepoId.Name = "colTuketimDepoId";
            this.colTuketimDepoId.OptionsColumn.AllowEdit = false;
            this.colTuketimDepoId.OptionsColumn.ShowInCustomizationForm = false;
            this.colTuketimDepoId.StatusBarAciklama = null;
            this.colTuketimDepoId.StatusBarKisaYol = null;
            this.colTuketimDepoId.StatusBarKisaYolAciklama = null;
            // 
            // colTuketimDepoAdi
            // 
            this.colTuketimDepoAdi.Caption = "Tüketim Depo";
            this.colTuketimDepoAdi.ColumnEdit = this.repositoryItemTuketimDepo;
            this.colTuketimDepoAdi.FieldName = "TuketimDepoAdi";
            this.colTuketimDepoAdi.Name = "colTuketimDepoAdi";
            this.colTuketimDepoAdi.StatusBarAciklama = null;
            this.colTuketimDepoAdi.StatusBarKisaYol = null;
            this.colTuketimDepoAdi.StatusBarKisaYolAciklama = null;
            this.colTuketimDepoAdi.Visible = true;
            this.colTuketimDepoAdi.VisibleIndex = 5;
            this.colTuketimDepoAdi.Width = 114;
            // 
            // repositoryItemTuketimDepo
            // 
            this.repositoryItemTuketimDepo.AutoHeight = false;
            this.repositoryItemTuketimDepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTuketimDepo.Name = "repositoryItemTuketimDepo";
            this.repositoryItemTuketimDepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colUretilebilir
            // 
            this.colUretilebilir.AppearanceCell.Options.UseTextOptions = true;
            this.colUretilebilir.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUretilebilir.Caption = "Durum";
            this.colUretilebilir.ColumnEdit = this.repositoryItemCombo;
            this.colUretilebilir.FieldName = "Uretilebilir";
            this.colUretilebilir.Name = "colUretilebilir";
            this.colUretilebilir.StatusBarAciklama = null;
            this.colUretilebilir.StatusBarKisaYol = null;
            this.colUretilebilir.StatusBarKisaYolAciklama = null;
            this.colUretilebilir.Visible = true;
            this.colUretilebilir.VisibleIndex = 7;
            this.colUretilebilir.Width = 147;
            // 
            // repositoryItemCombo
            // 
            this.repositoryItemCombo.AutoHeight = false;
            this.repositoryItemCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCombo.Name = "repositoryItemCombo";
            this.repositoryItemCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colOperasyonBilgileriId
            // 
            this.colOperasyonBilgileriId.Caption = "OperasyonBilgileriId";
            this.colOperasyonBilgileriId.FieldName = "OperasyonBilgileriId";
            this.colOperasyonBilgileriId.Name = "colOperasyonBilgileriId";
            this.colOperasyonBilgileriId.OptionsColumn.AllowEdit = false;
            this.colOperasyonBilgileriId.OptionsColumn.ShowInCustomizationForm = false;
            this.colOperasyonBilgileriId.StatusBarAciklama = null;
            this.colOperasyonBilgileriId.StatusBarKisaYol = null;
            this.colOperasyonBilgileriId.StatusBarKisaYolAciklama = null;
            // 
            // repositoryItemStok
            // 
            this.repositoryItemStok.AutoHeight = false;
            this.repositoryItemStok.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemStok.Name = "repositoryItemStok";
            // 
            // repositoryItemDurum
            // 
            this.repositoryItemDurum.AutoHeight = false;
            this.repositoryItemDurum.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDurum.Name = "repositoryItemDurum";
            // 
            // colFireOrani
            // 
            this.colFireOrani.Caption = "Fire Oranı";
            this.colFireOrani.ColumnEdit = this.repositoryItemDecimal;
            this.colFireOrani.FieldName = "FireOrani";
            this.colFireOrani.Name = "colFireOrani";
            this.colFireOrani.StatusBarAciklama = null;
            this.colFireOrani.StatusBarKisaYol = null;
            this.colFireOrani.StatusBarKisaYolAciklama = null;
            this.colFireOrani.Visible = true;
            this.colFireOrani.VisibleIndex = 8;
            // 
            // ReceteBilesenBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "ReceteBilesenBilgileriTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpOperasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpBirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTuketimDepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDurum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colStokId;
        private Grid.MyGridColumn colStokKodu;
        private Grid.MyGridColumn colStokAdi;
        private Grid.MyGridColumn colStokBirim;
        private Grid.MyGridColumn colMiktar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemStok;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private Grid.MyGridColumn colTuketimDepoAdi;
        private Grid.MyGridColumn colUretilebilir;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemDurum;
        private Grid.MyGridColumn colReceteId;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemCombo;
        private Grid.MyGridColumn colTuketimDepoId;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemTuketimDepo;
        private Grid.MyGridColumn colOperasyonBilgileriId;
        protected internal Grid.MyGridColumn colOperasyonId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpOperasyon;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpBirim;
        private Grid.MyGridColumn colTuketimBirimId;
        private Grid.MyGridColumn colFireOrani;
    }
}

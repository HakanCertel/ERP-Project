namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.IsEmriForms.IsEmriTables
{
    partial class BagliMalzemeKalemleriTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BagliMalzemeKalemleriTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colStokKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBirimId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBirimAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBirimIhtiyac = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colNetIhtiyac = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colFireMiktari = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTuketimBirimId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTuketimDepoAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemStok = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemDurum = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemTuketimDepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemLookUpDepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpBirim = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTuketimDepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpDepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpBirim)).BeginInit();
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
            this.repositoryItemLookUpDepo,
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
            this.colStokKodu,
            this.colStokAdi,
            this.colBirimId,
            this.colBirimAdi,
            this.colBirimIhtiyac,
            this.colNetIhtiyac,
            this.colFireMiktari,
            this.colTuketimBirimId,
            this.colTuketimDepoAdi});
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
            this.colStokKodu.VisibleIndex = 0;
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
            this.colStokAdi.VisibleIndex = 1;
            this.colStokAdi.Width = 274;
            // 
            // colBirimId
            // 
            this.colBirimId.Caption = "BirimId";
            this.colBirimId.FieldName = "BirimId";
            this.colBirimId.Name = "colBirimId";
            this.colBirimId.OptionsColumn.AllowEdit = false;
            this.colBirimId.StatusBarAciklama = null;
            this.colBirimId.StatusBarKisaYol = null;
            this.colBirimId.StatusBarKisaYolAciklama = null;
            this.colBirimId.Visible = true;
            this.colBirimId.VisibleIndex = 2;
            // 
            // colBirimAdi
            // 
            this.colBirimAdi.Caption = "Birim Adı";
            this.colBirimAdi.FieldName = "BirimAdi";
            this.colBirimAdi.Name = "colBirimAdi";
            this.colBirimAdi.OptionsColumn.AllowEdit = false;
            this.colBirimAdi.StatusBarAciklama = null;
            this.colBirimAdi.StatusBarKisaYol = null;
            this.colBirimAdi.StatusBarKisaYolAciklama = null;
            this.colBirimAdi.Visible = true;
            this.colBirimAdi.VisibleIndex = 3;
            // 
            // colBirimIhtiyac
            // 
            this.colBirimIhtiyac.Caption = "Birim İhtiyaç";
            this.colBirimIhtiyac.FieldName = "BirimIhtiyac";
            this.colBirimIhtiyac.Name = "colBirimIhtiyac";
            this.colBirimIhtiyac.OptionsColumn.AllowEdit = false;
            this.colBirimIhtiyac.StatusBarAciklama = null;
            this.colBirimIhtiyac.StatusBarKisaYol = null;
            this.colBirimIhtiyac.StatusBarKisaYolAciklama = null;
            this.colBirimIhtiyac.Visible = true;
            this.colBirimIhtiyac.VisibleIndex = 4;
            // 
            // colNetIhtiyac
            // 
            this.colNetIhtiyac.Caption = "Net İhtiyaç";
            this.colNetIhtiyac.ColumnEdit = this.repositoryItemDecimal;
            this.colNetIhtiyac.FieldName = "NetIhtiyac";
            this.colNetIhtiyac.Name = "colNetIhtiyac";
            this.colNetIhtiyac.StatusBarAciklama = null;
            this.colNetIhtiyac.StatusBarKisaYol = null;
            this.colNetIhtiyac.StatusBarKisaYolAciklama = null;
            this.colNetIhtiyac.Visible = true;
            this.colNetIhtiyac.VisibleIndex = 5;
            this.colNetIhtiyac.Width = 95;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.DisplayFormat.FormatString = "{0:n4}";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.EditFormat.FormatString = "n4";
            this.repositoryItemDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colFireMiktari
            // 
            this.colFireMiktari.Caption = "Fire Miktarı";
            this.colFireMiktari.ColumnEdit = this.repositoryItemDecimal;
            this.colFireMiktari.FieldName = "FireMiktari";
            this.colFireMiktari.Name = "colFireMiktari";
            this.colFireMiktari.StatusBarAciklama = null;
            this.colFireMiktari.StatusBarKisaYol = null;
            this.colFireMiktari.StatusBarKisaYolAciklama = null;
            this.colFireMiktari.Visible = true;
            this.colFireMiktari.VisibleIndex = 6;
            // 
            // colTuketimBirimId
            // 
            this.colTuketimBirimId.Caption = "TüketimId";
            this.colTuketimBirimId.FieldName = "DepoId";
            this.colTuketimBirimId.Name = "colTuketimBirimId";
            this.colTuketimBirimId.OptionsColumn.AllowEdit = false;
            this.colTuketimBirimId.StatusBarAciklama = null;
            this.colTuketimBirimId.StatusBarKisaYol = null;
            this.colTuketimBirimId.StatusBarKisaYolAciklama = null;
            this.colTuketimBirimId.Visible = true;
            this.colTuketimBirimId.VisibleIndex = 7;
            // 
            // colTuketimDepoAdi
            // 
            this.colTuketimDepoAdi.Caption = "Tüketim Depo";
            this.colTuketimDepoAdi.FieldName = "DepoAdi";
            this.colTuketimDepoAdi.Name = "colTuketimDepoAdi";
            this.colTuketimDepoAdi.StatusBarAciklama = null;
            this.colTuketimDepoAdi.StatusBarKisaYol = null;
            this.colTuketimDepoAdi.StatusBarKisaYolAciklama = null;
            this.colTuketimDepoAdi.Visible = true;
            this.colTuketimDepoAdi.VisibleIndex = 8;
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
            // repositoryItemCombo
            // 
            this.repositoryItemCombo.AutoHeight = false;
            this.repositoryItemCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCombo.Name = "repositoryItemCombo";
            this.repositoryItemCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemTuketimDepo
            // 
            this.repositoryItemTuketimDepo.AutoHeight = false;
            this.repositoryItemTuketimDepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTuketimDepo.Name = "repositoryItemTuketimDepo";
            this.repositoryItemTuketimDepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemLookUpDepo
            // 
            this.repositoryItemLookUpDepo.AutoHeight = false;
            this.repositoryItemLookUpDepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpDepo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kod", "Kod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WarehouseName", "Depo Adı")});
            this.repositoryItemLookUpDepo.Name = "repositoryItemLookUpDepo";
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
            // BagliMalzemeKalemleriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "BagliMalzemeKalemleriTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTuketimDepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpDepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpBirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colStokKodu;
        private UserControls.Grid.MyGridColumn colStokAdi;
        private UserControls.Grid.MyGridColumn colBirimId;
        private UserControls.Grid.MyGridColumn colNetIhtiyac;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemStok;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemDurum;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemCombo;
        private UserControls.Grid.MyGridColumn colTuketimDepoAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemTuketimDepo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpDepo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpBirim;
        private UserControls.Grid.MyGridColumn colTuketimBirimId;
        private UserControls.Grid.MyGridColumn colBirimIhtiyac;
        private UserControls.Grid.MyGridColumn colFireMiktari;
        private UserControls.Grid.MyGridColumn colBirimAdi;
    }
}

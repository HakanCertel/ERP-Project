namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms
{
    partial class OperasyonaBagliTuketilecekReceteBilesenleriList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperasyonaBagliTuketilecekReceteBilesenleriList));
            this.longNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.LongNavigator();
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokBirim = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemTuketimDepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemStok = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemDurum = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTuketimDepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDurum)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(610, 102);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 355);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(610, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemStok,
            this.repositoryItemDecimal,
            this.repositoryItemDurum,
            this.repositoryItemCombo,
            this.repositoryItemTuketimDepo});
            this.grid.Size = new System.Drawing.Size(610, 253);
            this.grid.TabIndex = 6;
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
            this.colStokKodu,
            this.colStokAdi,
            this.colStokBirim,
            this.colMiktar});
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
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = null;
            this.colId.StatusBarKisaYolAciklama = null;
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
            // colStokBirim
            // 
            this.colStokBirim.Caption = "Birim";
            this.colStokBirim.FieldName = "Birim";
            this.colStokBirim.Name = "colStokBirim";
            this.colStokBirim.OptionsColumn.AllowEdit = false;
            this.colStokBirim.StatusBarAciklama = null;
            this.colStokBirim.StatusBarKisaYol = null;
            this.colStokBirim.StatusBarKisaYolAciklama = null;
            this.colStokBirim.Visible = true;
            this.colStokBirim.VisibleIndex = 2;
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
            this.colMiktar.VisibleIndex = 3;
            this.colMiktar.Width = 95;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDecimal.DisplayFormat.FormatString = "{0:n4}";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.EditFormat.FormatString = "{0:n4}";
            this.repositoryItemDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // repositoryItemTuketimDepo
            // 
            this.repositoryItemTuketimDepo.AutoHeight = false;
            this.repositoryItemTuketimDepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTuketimDepo.Name = "repositoryItemTuketimDepo";
            this.repositoryItemTuketimDepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemCombo
            // 
            this.repositoryItemCombo.AutoHeight = false;
            this.repositoryItemCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCombo.Name = "repositoryItemCombo";
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
            // OperasyonaBagliTuketilecekReceteBilesenleriList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.MaximumSize = new System.Drawing.Size(620, 411);
            this.MinimumSize = new System.Drawing.Size(620, 411);
            this.Name = "OperasyonaBagliTuketilecekReceteBilesenleriList";
            this.Text = "Reçete Bileşen Bilgileri";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTuketimDepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDurum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colStokKodu;
        private UserControls.Grid.MyGridColumn colStokAdi;
        private UserControls.Grid.MyGridColumn colStokBirim;
        private UserControls.Grid.MyGridColumn colMiktar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemStok;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemDurum;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemCombo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemTuketimDepo;
    }
}
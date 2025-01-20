namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.ReceteEditFormTable
{
    partial class ReceteMakinaElemaniBilgileriTable
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
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colMakinaId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMakinaKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMakinaAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDegisimSuresi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemDegisimSuresi = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colAciklama = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemMakina = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemStok = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDegisimSuresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMakina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemStok)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMakina,
            this.repositoryItemStok,
            this.repositoryItemDegisimSuresi});
            this.grid.Size = new System.Drawing.Size(554, 229);
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
            this.colStokId,
            this.colStokKodu,
            this.colStokAdi,
            this.colDegisimSuresi,
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
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Makina Elemanları";
            // 
            // colMakinaId
            // 
            this.colMakinaId.Caption = "MakinaId";
            this.colMakinaId.FieldName = "MakinaId";
            this.colMakinaId.Name = "colMakinaId";
            this.colMakinaId.OptionsColumn.AllowEdit = false;
            this.colMakinaId.StatusBarAciklama = null;
            this.colMakinaId.StatusBarKisaYol = null;
            this.colMakinaId.StatusBarKisaYolAciklama = null;
            // 
            // colMakinaKodu
            // 
            this.colMakinaKodu.Caption = "Makina Kodu";
            this.colMakinaKodu.FieldName = "MakinaKodu";
            this.colMakinaKodu.Name = "colMakinaKodu";
            this.colMakinaKodu.StatusBarAciklama = null;
            this.colMakinaKodu.StatusBarKisaYol = null;
            this.colMakinaKodu.StatusBarKisaYolAciklama = null;
            this.colMakinaKodu.Visible = true;
            this.colMakinaKodu.VisibleIndex = 0;
            this.colMakinaKodu.Width = 106;
            // 
            // colMakinaAdi
            // 
            this.colMakinaAdi.Caption = "Makina";
            this.colMakinaAdi.FieldName = "MakinaAdi";
            this.colMakinaAdi.Name = "colMakinaAdi";
            this.colMakinaAdi.OptionsColumn.AllowEdit = false;
            this.colMakinaAdi.StatusBarAciklama = null;
            this.colMakinaAdi.StatusBarKisaYol = null;
            this.colMakinaAdi.StatusBarKisaYolAciklama = null;
            this.colMakinaAdi.Visible = true;
            this.colMakinaAdi.VisibleIndex = 1;
            this.colMakinaAdi.Width = 177;
            // 
            // colStokId
            // 
            this.colStokId.Caption = "StokId";
            this.colStokId.FieldName = "StokId";
            this.colStokId.Name = "colStokId";
            this.colStokId.OptionsColumn.AllowEdit = false;
            this.colStokId.StatusBarAciklama = null;
            this.colStokId.StatusBarKisaYol = null;
            this.colStokId.StatusBarKisaYolAciklama = null;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Makina Elemanı Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.StatusBarAciklama = null;
            this.colStokKodu.StatusBarKisaYol = null;
            this.colStokKodu.StatusBarKisaYolAciklama = null;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 2;
            this.colStokKodu.Width = 120;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Makina Elemanı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.StatusBarAciklama = null;
            this.colStokAdi.StatusBarKisaYol = null;
            this.colStokAdi.StatusBarKisaYolAciklama = null;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 3;
            this.colStokAdi.Width = 314;
            // 
            // colDegisimSuresi
            // 
            this.colDegisimSuresi.Caption = "Değişim Süresi";
            this.colDegisimSuresi.ColumnEdit = this.repositoryItemDegisimSuresi;
            this.colDegisimSuresi.DisplayFormat.FormatString = "{n:0}";
            this.colDegisimSuresi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDegisimSuresi.FieldName = "DegisimSuresi";
            this.colDegisimSuresi.Name = "colDegisimSuresi";
            this.colDegisimSuresi.StatusBarAciklama = null;
            this.colDegisimSuresi.StatusBarKisaYol = null;
            this.colDegisimSuresi.StatusBarKisaYolAciklama = null;
            this.colDegisimSuresi.Visible = true;
            this.colDegisimSuresi.VisibleIndex = 4;
            this.colDegisimSuresi.Width = 92;
            // 
            // repositoryItemDegisimSuresi
            // 
            this.repositoryItemDegisimSuresi.AutoHeight = false;
            this.repositoryItemDegisimSuresi.Name = "repositoryItemDegisimSuresi";
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 5;
            this.colAciklama.Width = 250;
            // 
            // repositoryItemMakina
            // 
            this.repositoryItemMakina.AutoHeight = false;
            this.repositoryItemMakina.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemMakina.Name = "repositoryItemMakina";
            this.repositoryItemMakina.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemStok
            // 
            this.repositoryItemStok.AutoHeight = false;
            this.repositoryItemStok.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemStok.Name = "repositoryItemStok";
            this.repositoryItemStok.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // ReceteMakinaElemaniBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "ReceteMakinaElemaniBilgileriTable";
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDegisimSuresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMakina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colMakinaId;
        private Grid.MyGridColumn colMakinaKodu;
        private Grid.MyGridColumn colMakinaAdi;
        private Grid.MyGridColumn colStokId;
        private Grid.MyGridColumn colStokKodu;
        private Grid.MyGridColumn colStokAdi;
        private Grid.MyGridColumn colAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemMakina;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemStok;
        private Grid.MyGridColumn colDegisimSuresi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDegisimSuresi;
    }
}

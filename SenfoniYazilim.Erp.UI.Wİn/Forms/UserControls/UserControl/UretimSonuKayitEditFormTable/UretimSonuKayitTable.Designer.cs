namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.UretimSonuKayitEditFormTable
{
    partial class UretimSonuKayitTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UretimSonuKayitTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colUretimSonuKayitId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDepoId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDepoKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemDepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDepoAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBirimId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBirimAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBirimIhtiyac = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colKayitMiktari = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colFireMiktari = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colFark = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colToplamMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
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
            this.repositoryItemDecimal,
            this.repositoryItemDate,
            this.repositoryItemDepo});
            this.grid.Size = new System.Drawing.Size(612, 203);
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
            this.colUretimSonuKayitId,
            this.colStokId,
            this.colStokKodu,
            this.colStokAdi,
            this.colDepoId,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colBirimId,
            this.colBirimAdi,
            this.colBirimIhtiyac,
            this.colKayitMiktari,
            this.colFireMiktari,
            this.colFark,
            this.colToplamMiktar});
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
            this.tablo.ViewCaption = "Malzeme Bilgileri";
            // 
            // colUretimSonuKayitId
            // 
            this.colUretimSonuKayitId.Caption = "UretimSonuKayitId";
            this.colUretimSonuKayitId.FieldName = "UretimSonuKayitId";
            this.colUretimSonuKayitId.Name = "colUretimSonuKayitId";
            this.colUretimSonuKayitId.OptionsColumn.AllowEdit = false;
            this.colUretimSonuKayitId.StatusBarAciklama = null;
            this.colUretimSonuKayitId.StatusBarKisaYol = null;
            this.colUretimSonuKayitId.StatusBarKisaYolAciklama = null;
            // 
            // colStokId
            // 
            this.colStokId.Caption = "StokId";
            this.colStokId.FieldName = "StokId";
            this.colStokId.Name = "colStokId";
            this.colStokId.OptionsColumn.AllowEdit = false;
            this.colStokId.OptionsColumn.ShowInCustomizationForm = false;
            this.colStokId.StatusBarAciklama = null;
            this.colStokId.StatusBarKisaYol = null;
            this.colStokId.StatusBarKisaYolAciklama = null;
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
            this.colStokKodu.Width = 124;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adi";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.StatusBarAciklama = null;
            this.colStokAdi.StatusBarKisaYol = null;
            this.colStokAdi.StatusBarKisaYolAciklama = null;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 1;
            this.colStokAdi.Width = 287;
            // 
            // colDepoId
            // 
            this.colDepoId.Caption = "DepoId";
            this.colDepoId.FieldName = "DepoId";
            this.colDepoId.Name = "colDepoId";
            this.colDepoId.OptionsColumn.AllowEdit = false;
            this.colDepoId.OptionsColumn.ShowInCustomizationForm = false;
            this.colDepoId.StatusBarAciklama = null;
            this.colDepoId.StatusBarKisaYol = null;
            this.colDepoId.StatusBarKisaYolAciklama = null;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.Caption = "Depo Kodu";
            this.colDepoKodu.ColumnEdit = this.repositoryItemDepo;
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.StatusBarAciklama = null;
            this.colDepoKodu.StatusBarKisaYol = null;
            this.colDepoKodu.StatusBarKisaYolAciklama = null;
            this.colDepoKodu.Visible = true;
            this.colDepoKodu.VisibleIndex = 4;
            this.colDepoKodu.Width = 108;
            // 
            // repositoryItemDepo
            // 
            this.repositoryItemDepo.AutoHeight = false;
            this.repositoryItemDepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDepo.Name = "repositoryItemDepo";
            this.repositoryItemDepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepoAdi.StatusBarAciklama = null;
            this.colDepoAdi.StatusBarKisaYol = null;
            this.colDepoAdi.StatusBarKisaYolAciklama = null;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 5;
            this.colDepoAdi.Width = 171;
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
            // 
            // colBirimAdi
            // 
            this.colBirimAdi.Caption = "Birim";
            this.colBirimAdi.FieldName = "BirimAdi";
            this.colBirimAdi.Name = "colBirimAdi";
            this.colBirimAdi.OptionsColumn.AllowEdit = false;
            this.colBirimAdi.StatusBarAciklama = null;
            this.colBirimAdi.StatusBarKisaYol = null;
            this.colBirimAdi.StatusBarKisaYolAciklama = null;
            this.colBirimAdi.Visible = true;
            this.colBirimAdi.VisibleIndex = 6;
            // 
            // colBirimIhtiyac
            // 
            this.colBirimIhtiyac.Caption = "Birim İhtiyaç";
            this.colBirimIhtiyac.ColumnEdit = this.repositoryItemDecimal;
            this.colBirimIhtiyac.FieldName = "BirimIhtiyac";
            this.colBirimIhtiyac.Name = "colBirimIhtiyac";
            this.colBirimIhtiyac.StatusBarAciklama = null;
            this.colBirimIhtiyac.StatusBarKisaYol = null;
            this.colBirimIhtiyac.StatusBarKisaYolAciklama = null;
            this.colBirimIhtiyac.Visible = true;
            this.colBirimIhtiyac.VisibleIndex = 2;
            this.colBirimIhtiyac.Width = 127;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.DisplayFormat.FormatString = "n3";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.EditFormat.FormatString = "n3";
            this.repositoryItemDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colKayitMiktari
            // 
            this.colKayitMiktari.Caption = "Toplam Tüketilen Miktar";
            this.colKayitMiktari.ColumnEdit = this.repositoryItemDecimal;
            this.colKayitMiktari.FieldName = "KayitMiktari";
            this.colKayitMiktari.Name = "colKayitMiktari";
            this.colKayitMiktari.OptionsColumn.AllowEdit = false;
            this.colKayitMiktari.StatusBarAciklama = null;
            this.colKayitMiktari.StatusBarKisaYol = null;
            this.colKayitMiktari.StatusBarKisaYolAciklama = null;
            this.colKayitMiktari.Visible = true;
            this.colKayitMiktari.VisibleIndex = 3;
            this.colKayitMiktari.Width = 155;
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
            this.colFireMiktari.VisibleIndex = 7;
            // 
            // colFark
            // 
            this.colFark.Caption = "Fark";
            this.colFark.ColumnEdit = this.repositoryItemDecimal;
            this.colFark.FieldName = "Fark";
            this.colFark.Name = "colFark";
            this.colFark.OptionsColumn.AllowEdit = false;
            this.colFark.OptionsColumn.ShowInCustomizationForm = false;
            this.colFark.StatusBarAciklama = null;
            this.colFark.StatusBarKisaYol = null;
            this.colFark.StatusBarKisaYolAciklama = null;
            // 
            // repositoryItemDate
            // 
            this.repositoryItemDate.AutoHeight = false;
            this.repositoryItemDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDate.Name = "repositoryItemDate";
            // 
            // colToplamMiktar
            // 
            this.colToplamMiktar.Caption = "ToplamMiktar";
            this.colToplamMiktar.ColumnEdit = this.repositoryItemDecimal;
            this.colToplamMiktar.FieldName = "ToplamMiktar";
            this.colToplamMiktar.Name = "colToplamMiktar";
            this.colToplamMiktar.OptionsColumn.AllowEdit = false;
            this.colToplamMiktar.OptionsColumn.ShowInCustomizationForm = false;
            this.colToplamMiktar.StatusBarAciklama = null;
            this.colToplamMiktar.StatusBarKisaYol = null;
            this.colToplamMiktar.StatusBarKisaYolAciklama = null;
            // 
            // UretimSonuKayitTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "UretimSonuKayitTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colStokId;
        private Grid.MyGridColumn colStokKodu;
        private Grid.MyGridColumn colStokAdi;
        private Grid.MyGridColumn colDepoId;
        private Grid.MyGridColumn colDepoKodu;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemDepo;
        private Grid.MyGridColumn colDepoAdi;
        private Grid.MyGridColumn colBirimId;
        private Grid.MyGridColumn colBirimIhtiyac;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private Grid.MyGridColumn colKayitMiktari;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private Grid.MyGridColumn colUretimSonuKayitId;
        private Grid.MyGridColumn colBirimAdi;
        private Grid.MyGridColumn colFireMiktari;
        private Grid.MyGridColumn colFark;
        private Grid.MyGridColumn colToplamMiktar;
    }
}

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.MrpEditFormTable
{
    partial class MrpRezervasyonBilgileriTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MrpRezervasyonBilgileriTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colKullaniciId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSiparisId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSiparisKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBagliOlduguUrunId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBagliOlduguUrunKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBagliOlduguUrunAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDepoId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDepoKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDepoAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colToplamStokMiktari = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colToplamRezerveEdilenMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colAcikMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIhtiyacMiktari = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colRezerveEdilenMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
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
            this.grid.Size = new System.Drawing.Size(527, 229);
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
            this.colKullaniciId,
            this.colSiparisId,
            this.colSiparisKodu,
            this.colBagliOlduguUrunId,
            this.colBagliOlduguUrunKodu,
            this.colBagliOlduguUrunAdi,
            this.colStokId,
            this.colStokKodu,
            this.colStokAdi,
            this.colDepoId,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colToplamStokMiktari,
            this.colToplamRezerveEdilenMiktar,
            this.colAcikMiktar,
            this.colIhtiyacMiktari,
            this.colRezerveEdilenMiktar});
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
            this.tablo.ViewCaption = "Malzeme İhtiyaç Bilgileri İçin Rezervasyon İşlemleri";
            // 
            // colKullaniciId
            // 
            this.colKullaniciId.Caption = "KullaniciId";
            this.colKullaniciId.FieldName = "KullaniciId";
            this.colKullaniciId.Name = "colKullaniciId";
            this.colKullaniciId.OptionsColumn.AllowEdit = false;
            this.colKullaniciId.OptionsColumn.ShowInCustomizationForm = false;
            this.colKullaniciId.StatusBarAciklama = null;
            this.colKullaniciId.StatusBarKisaYol = null;
            this.colKullaniciId.StatusBarKisaYolAciklama = null;
            // 
            // colSiparisId
            // 
            this.colSiparisId.Caption = "SiparisId";
            this.colSiparisId.FieldName = "SiparisId";
            this.colSiparisId.Name = "colSiparisId";
            this.colSiparisId.OptionsColumn.AllowEdit = false;
            this.colSiparisId.OptionsColumn.ShowInCustomizationForm = false;
            this.colSiparisId.StatusBarAciklama = null;
            this.colSiparisId.StatusBarKisaYol = null;
            this.colSiparisId.StatusBarKisaYolAciklama = null;
            // 
            // colSiparisKodu
            // 
            this.colSiparisKodu.Caption = "Sipariş Kodu";
            this.colSiparisKodu.FieldName = "SiparisKodu";
            this.colSiparisKodu.Name = "colSiparisKodu";
            this.colSiparisKodu.OptionsColumn.AllowEdit = false;
            this.colSiparisKodu.StatusBarAciklama = null;
            this.colSiparisKodu.StatusBarKisaYol = null;
            this.colSiparisKodu.StatusBarKisaYolAciklama = null;
            this.colSiparisKodu.Visible = true;
            this.colSiparisKodu.VisibleIndex = 0;
            // 
            // colBagliOlduguUrunId
            // 
            this.colBagliOlduguUrunId.Caption = "BagliOlduguUrunId";
            this.colBagliOlduguUrunId.FieldName = "BagliOlduguUrunId";
            this.colBagliOlduguUrunId.Name = "colBagliOlduguUrunId";
            this.colBagliOlduguUrunId.OptionsColumn.AllowEdit = false;
            this.colBagliOlduguUrunId.OptionsColumn.ShowInCustomizationForm = false;
            this.colBagliOlduguUrunId.StatusBarAciklama = null;
            this.colBagliOlduguUrunId.StatusBarKisaYol = null;
            this.colBagliOlduguUrunId.StatusBarKisaYolAciklama = null;
            // 
            // colBagliOlduguUrunKodu
            // 
            this.colBagliOlduguUrunKodu.Caption = "Bağlı Olduğu Stok Kodu";
            this.colBagliOlduguUrunKodu.FieldName = "BagliOlduguUrunKodu";
            this.colBagliOlduguUrunKodu.Name = "colBagliOlduguUrunKodu";
            this.colBagliOlduguUrunKodu.OptionsColumn.AllowEdit = false;
            this.colBagliOlduguUrunKodu.StatusBarAciklama = null;
            this.colBagliOlduguUrunKodu.StatusBarKisaYol = null;
            this.colBagliOlduguUrunKodu.StatusBarKisaYolAciklama = null;
            this.colBagliOlduguUrunKodu.Visible = true;
            this.colBagliOlduguUrunKodu.VisibleIndex = 1;
            this.colBagliOlduguUrunKodu.Width = 127;
            // 
            // colBagliOlduguUrunAdi
            // 
            this.colBagliOlduguUrunAdi.Caption = "Bağlı Olduğu Stok Adı";
            this.colBagliOlduguUrunAdi.FieldName = "BagliOlduguUrunAdi";
            this.colBagliOlduguUrunAdi.Name = "colBagliOlduguUrunAdi";
            this.colBagliOlduguUrunAdi.OptionsColumn.AllowEdit = false;
            this.colBagliOlduguUrunAdi.StatusBarAciklama = null;
            this.colBagliOlduguUrunAdi.StatusBarKisaYol = null;
            this.colBagliOlduguUrunAdi.StatusBarKisaYolAciklama = null;
            this.colBagliOlduguUrunAdi.Visible = true;
            this.colBagliOlduguUrunAdi.VisibleIndex = 2;
            this.colBagliOlduguUrunAdi.Width = 276;
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
            this.colStokKodu.VisibleIndex = 3;
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
            this.colStokAdi.VisibleIndex = 4;
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
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            this.colDepoKodu.StatusBarAciklama = null;
            this.colDepoKodu.StatusBarKisaYol = null;
            this.colDepoKodu.StatusBarKisaYolAciklama = null;
            this.colDepoKodu.Visible = true;
            this.colDepoKodu.VisibleIndex = 5;
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
            this.colDepoAdi.VisibleIndex = 6;
            // 
            // colToplamStokMiktari
            // 
            this.colToplamStokMiktari.Caption = "Toplam Stok";
            this.colToplamStokMiktari.FieldName = "ToplamStokMiktari";
            this.colToplamStokMiktari.Name = "colToplamStokMiktari";
            this.colToplamStokMiktari.OptionsColumn.AllowEdit = false;
            this.colToplamStokMiktari.StatusBarAciklama = null;
            this.colToplamStokMiktari.StatusBarKisaYol = null;
            this.colToplamStokMiktari.StatusBarKisaYolAciklama = null;
            this.colToplamStokMiktari.Visible = true;
            this.colToplamStokMiktari.VisibleIndex = 7;
            // 
            // colToplamRezerveEdilenMiktar
            // 
            this.colToplamRezerveEdilenMiktar.Caption = "Toplam Rezerve Edilen Miktar";
            this.colToplamRezerveEdilenMiktar.FieldName = "ToplamRezerveEdilenMiktar";
            this.colToplamRezerveEdilenMiktar.Name = "colToplamRezerveEdilenMiktar";
            this.colToplamRezerveEdilenMiktar.OptionsColumn.AllowEdit = false;
            this.colToplamRezerveEdilenMiktar.StatusBarAciklama = null;
            this.colToplamRezerveEdilenMiktar.StatusBarKisaYol = null;
            this.colToplamRezerveEdilenMiktar.StatusBarKisaYolAciklama = null;
            this.colToplamRezerveEdilenMiktar.Visible = true;
            this.colToplamRezerveEdilenMiktar.VisibleIndex = 8;
            // 
            // colAcikMiktar
            // 
            this.colAcikMiktar.Caption = "Açık Miktar";
            this.colAcikMiktar.FieldName = "AcikMiktar";
            this.colAcikMiktar.Name = "colAcikMiktar";
            this.colAcikMiktar.OptionsColumn.AllowEdit = false;
            this.colAcikMiktar.StatusBarAciklama = null;
            this.colAcikMiktar.StatusBarKisaYol = null;
            this.colAcikMiktar.StatusBarKisaYolAciklama = null;
            this.colAcikMiktar.Visible = true;
            this.colAcikMiktar.VisibleIndex = 9;
            // 
            // colIhtiyacMiktari
            // 
            this.colIhtiyacMiktari.Caption = "İhtiyaç Miktarı";
            this.colIhtiyacMiktari.FieldName = "IhtiyacMiktari";
            this.colIhtiyacMiktari.Name = "colIhtiyacMiktari";
            this.colIhtiyacMiktari.OptionsColumn.AllowEdit = false;
            this.colIhtiyacMiktari.StatusBarAciklama = null;
            this.colIhtiyacMiktari.StatusBarKisaYol = null;
            this.colIhtiyacMiktari.StatusBarKisaYolAciklama = null;
            this.colIhtiyacMiktari.Visible = true;
            this.colIhtiyacMiktari.VisibleIndex = 10;
            // 
            // colRezerveEdilenMiktar
            // 
            this.colRezerveEdilenMiktar.Caption = "Rezerve Edilecek Miktar";
            this.colRezerveEdilenMiktar.FieldName = "RezerveEdilenMiktar";
            this.colRezerveEdilenMiktar.Name = "colRezerveEdilenMiktar";
            this.colRezerveEdilenMiktar.StatusBarAciklama = null;
            this.colRezerveEdilenMiktar.StatusBarKisaYol = null;
            this.colRezerveEdilenMiktar.StatusBarKisaYolAciklama = null;
            this.colRezerveEdilenMiktar.Visible = true;
            this.colRezerveEdilenMiktar.VisibleIndex = 11;
            // 
            // MrpRezervasyonBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "MrpRezervasyonBilgileriTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colKullaniciId;
        private Grid.MyGridColumn colSiparisId;
        private Grid.MyGridColumn colSiparisKodu;
        private Grid.MyGridColumn colBagliOlduguUrunId;
        private Grid.MyGridColumn colBagliOlduguUrunKodu;
        private Grid.MyGridColumn colBagliOlduguUrunAdi;
        private Grid.MyGridColumn colStokId;
        private Grid.MyGridColumn colStokKodu;
        private Grid.MyGridColumn colStokAdi;
        private Grid.MyGridColumn colDepoId;
        private Grid.MyGridColumn colDepoKodu;
        private Grid.MyGridColumn colDepoAdi;
        private Grid.MyGridColumn colToplamStokMiktari;
        private Grid.MyGridColumn colToplamRezerveEdilenMiktar;
        private Grid.MyGridColumn colAcikMiktar;
        private Grid.MyGridColumn colIhtiyacMiktari;
        private Grid.MyGridColumn colRezerveEdilenMiktar;
    }
}

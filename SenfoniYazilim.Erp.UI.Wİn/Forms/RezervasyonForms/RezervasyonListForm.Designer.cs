namespace SenfoniYazilim.Erp.UI.Wİn.Forms.RezervasyonForms
{
    partial class RezervasyonListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonListForm));
            this.longNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.LongNavigator();
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKullaniciId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKullaniciAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSiparisId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSiparisKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colRezerveEdilenMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colToplamStokMiktari = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colToplamRezerveEdilenMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTabloAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIlgiliTabloKayıtId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colAcikMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colAciklama = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDepoId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDepoAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBirim = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colGrup = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colGrupId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colGrupAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
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
            this.longNavigator.Location = new System.Drawing.Point(0, 391);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1124, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1124, 289);
            this.grid.TabIndex = 3;
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
            this.colKullaniciId,
            this.colKullaniciAdi,
            this.colSiparisId,
            this.colSiparisKodu,
            this.colStokId,
            this.colStokAdi,
            this.colRezerveEdilenMiktar,
            this.colToplamStokMiktari,
            this.colToplamRezerveEdilenMiktar,
            this.colTabloAdi,
            this.colIlgiliTabloKayıtId,
            this.colAcikMiktar,
            this.colAciklama,
            this.colDepoId,
            this.colDepoAdi,
            this.colBirim,
            this.colGrup,
            this.colGrupId,
            this.colGrupAdi});
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
            this.tablo.ViewCaption = "Rezervasyon Bilgileri";
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
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.Caption = "Kullanıcı Adı";
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.OptionsColumn.AllowEdit = false;
            this.colKullaniciAdi.StatusBarAciklama = null;
            this.colKullaniciAdi.StatusBarKisaYol = null;
            this.colKullaniciAdi.StatusBarKisaYolAciklama = null;
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 0;
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
            this.colSiparisKodu.VisibleIndex = 1;
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
            // 
            // colRezerveEdilenMiktar
            // 
            this.colRezerveEdilenMiktar.Caption = "Rezervasyon Miktarı";
            this.colRezerveEdilenMiktar.FieldName = "RezerveEdilenMiktar";
            this.colRezerveEdilenMiktar.Name = "colRezerveEdilenMiktar";
            this.colRezerveEdilenMiktar.OptionsColumn.AllowEdit = false;
            this.colRezerveEdilenMiktar.StatusBarAciklama = null;
            this.colRezerveEdilenMiktar.StatusBarKisaYol = null;
            this.colRezerveEdilenMiktar.StatusBarKisaYolAciklama = null;
            this.colRezerveEdilenMiktar.Visible = true;
            this.colRezerveEdilenMiktar.VisibleIndex = 3;
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
            this.colToplamStokMiktari.VisibleIndex = 4;
            // 
            // colToplamRezerveEdilenMiktar
            // 
            this.colToplamRezerveEdilenMiktar.Caption = "Toplam Rezervasyon Miktarı";
            this.colToplamRezerveEdilenMiktar.FieldName = "ToplamRezerveEdilenMiktar";
            this.colToplamRezerveEdilenMiktar.Name = "colToplamRezerveEdilenMiktar";
            this.colToplamRezerveEdilenMiktar.OptionsColumn.AllowEdit = false;
            this.colToplamRezerveEdilenMiktar.StatusBarAciklama = null;
            this.colToplamRezerveEdilenMiktar.StatusBarKisaYol = null;
            this.colToplamRezerveEdilenMiktar.StatusBarKisaYolAciklama = null;
            this.colToplamRezerveEdilenMiktar.Visible = true;
            this.colToplamRezerveEdilenMiktar.VisibleIndex = 5;
            // 
            // colTabloAdi
            // 
            this.colTabloAdi.Caption = "Tabo Adı";
            this.colTabloAdi.FieldName = "TabloAdi";
            this.colTabloAdi.Name = "colTabloAdi";
            this.colTabloAdi.OptionsColumn.AllowEdit = false;
            this.colTabloAdi.StatusBarAciklama = null;
            this.colTabloAdi.StatusBarKisaYol = null;
            this.colTabloAdi.StatusBarKisaYolAciklama = null;
            this.colTabloAdi.Visible = true;
            this.colTabloAdi.VisibleIndex = 6;
            // 
            // colIlgiliTabloKayıtId
            // 
            this.colIlgiliTabloKayıtId.Caption = "IlgiliTabloKayıtId";
            this.colIlgiliTabloKayıtId.FieldName = "IlgiliTabloKayıtId";
            this.colIlgiliTabloKayıtId.Name = "colIlgiliTabloKayıtId";
            this.colIlgiliTabloKayıtId.OptionsColumn.AllowEdit = false;
            this.colIlgiliTabloKayıtId.OptionsColumn.ShowInCustomizationForm = false;
            this.colIlgiliTabloKayıtId.StatusBarAciklama = null;
            this.colIlgiliTabloKayıtId.StatusBarKisaYol = null;
            this.colIlgiliTabloKayıtId.StatusBarKisaYolAciklama = null;
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
            this.colAcikMiktar.VisibleIndex = 7;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 8;
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
            this.colDepoAdi.VisibleIndex = 9;
            // 
            // colBirim
            // 
            this.colBirim.Caption = "Birim ";
            this.colBirim.FieldName = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            this.colBirim.StatusBarAciklama = null;
            this.colBirim.StatusBarKisaYol = null;
            this.colBirim.StatusBarKisaYolAciklama = null;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 10;
            // 
            // colGrup
            // 
            this.colGrup.Caption = "Grup ";
            this.colGrup.FieldName = "Grup";
            this.colGrup.Name = "colGrup";
            this.colGrup.OptionsColumn.AllowEdit = false;
            this.colGrup.StatusBarAciklama = null;
            this.colGrup.StatusBarKisaYol = null;
            this.colGrup.StatusBarKisaYolAciklama = null;
            this.colGrup.Visible = true;
            this.colGrup.VisibleIndex = 11;
            // 
            // colGrupId
            // 
            this.colGrupId.Caption = "GrupId";
            this.colGrupId.FieldName = "GrupId";
            this.colGrupId.Name = "colGrupId";
            this.colGrupId.OptionsColumn.AllowEdit = false;
            this.colGrupId.OptionsColumn.ShowInCustomizationForm = false;
            this.colGrupId.StatusBarAciklama = null;
            this.colGrupId.StatusBarKisaYol = null;
            this.colGrupId.StatusBarKisaYolAciklama = null;
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.Caption = "Grup Adı";
            this.colGrupAdi.FieldName = "GrupAdi";
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.OptionsColumn.AllowEdit = false;
            this.colGrupAdi.StatusBarAciklama = null;
            this.colGrupAdi.StatusBarKisaYol = null;
            this.colGrupAdi.StatusBarKisaYolAciklama = null;
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.VisibleIndex = 12;
            // 
            // RezervasyonListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 446);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "RezervasyonListForm";
            this.Text = "Rezervasyon Bilgileri";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKullaniciId;
        private UserControls.Grid.MyGridColumn colKullaniciAdi;
        private UserControls.Grid.MyGridColumn colSiparisId;
        private UserControls.Grid.MyGridColumn colSiparisKodu;
        private UserControls.Grid.MyGridColumn colStokId;
        private UserControls.Grid.MyGridColumn colStokAdi;
        private UserControls.Grid.MyGridColumn colRezerveEdilenMiktar;
        private UserControls.Grid.MyGridColumn colToplamStokMiktari;
        private UserControls.Grid.MyGridColumn colToplamRezerveEdilenMiktar;
        private UserControls.Grid.MyGridColumn colTabloAdi;
        private UserControls.Grid.MyGridColumn colIlgiliTabloKayıtId;
        private UserControls.Grid.MyGridColumn colAcikMiktar;
        private UserControls.Grid.MyGridColumn colAciklama;
        private UserControls.Grid.MyGridColumn colDepoId;
        private UserControls.Grid.MyGridColumn colDepoAdi;
        private UserControls.Grid.MyGridColumn colBirim;
        private UserControls.Grid.MyGridColumn colGrup;
        private UserControls.Grid.MyGridColumn colGrupId;
        private UserControls.Grid.MyGridColumn colGrupAdi;
    }
}
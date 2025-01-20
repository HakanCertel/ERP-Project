namespace SenfoniYazilim.Erp.UI.Wİn.Forms.BankaHesapForms
{
    partial class BankaHesapListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankaHesapListForm));
            this.longNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.LongNavigator();
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKod = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colHesapAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colHesapTuru = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBankaAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBankaSubeAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colHesapAcilisTarihi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBlokeGunSayisi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIsyeriNo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTerminalNo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colHesapNo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIbanNo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOzelKod1Adi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOzelKod2Adi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colAciklama = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
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
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 391);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1041, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1041, 289);
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
            this.colKod,
            this.colHesapAdi,
            this.colHesapTuru,
            this.colBankaAdi,
            this.colBankaSubeAdi,
            this.colHesapAcilisTarihi,
            this.colBlokeGunSayisi,
            this.colIsyeriNo,
            this.colTerminalNo,
            this.colHesapNo,
            this.colIbanNo,
            this.colOzelKod1Adi,
            this.colOzelKod2Adi,
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
            this.tablo.ViewCaption = "Banka Hesap Kartları";
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
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            // 
            // colHesapAdi
            // 
            this.colHesapAdi.Caption = "Hesap Adı";
            this.colHesapAdi.FieldName = "HesapAdi";
            this.colHesapAdi.Name = "colHesapAdi";
            this.colHesapAdi.OptionsColumn.AllowEdit = false;
            this.colHesapAdi.StatusBarAciklama = null;
            this.colHesapAdi.StatusBarKisaYol = null;
            this.colHesapAdi.StatusBarKisaYolAciklama = null;
            this.colHesapAdi.Visible = true;
            this.colHesapAdi.VisibleIndex = 1;
            // 
            // colHesapTuru
            // 
            this.colHesapTuru.Caption = "Hesap Türü";
            this.colHesapTuru.FieldName = "HesapTuru";
            this.colHesapTuru.Name = "colHesapTuru";
            this.colHesapTuru.OptionsColumn.AllowEdit = false;
            this.colHesapTuru.StatusBarAciklama = null;
            this.colHesapTuru.StatusBarKisaYol = null;
            this.colHesapTuru.StatusBarKisaYolAciklama = null;
            this.colHesapTuru.Visible = true;
            this.colHesapTuru.VisibleIndex = 2;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka Adı";
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowEdit = false;
            this.colBankaAdi.StatusBarAciklama = null;
            this.colBankaAdi.StatusBarKisaYol = null;
            this.colBankaAdi.StatusBarKisaYolAciklama = null;
            this.colBankaAdi.Visible = true;
            this.colBankaAdi.VisibleIndex = 3;
            // 
            // colBankaSubeAdi
            // 
            this.colBankaSubeAdi.Caption = "Şube Adı";
            this.colBankaSubeAdi.FieldName = "BankaSubeAdi";
            this.colBankaSubeAdi.Name = "colBankaSubeAdi";
            this.colBankaSubeAdi.OptionsColumn.AllowEdit = false;
            this.colBankaSubeAdi.StatusBarAciklama = null;
            this.colBankaSubeAdi.StatusBarKisaYol = null;
            this.colBankaSubeAdi.StatusBarKisaYolAciklama = null;
            this.colBankaSubeAdi.Visible = true;
            this.colBankaSubeAdi.VisibleIndex = 4;
            // 
            // colHesapAcilisTarihi
            // 
            this.colHesapAcilisTarihi.Caption = "Hesap Açılış Tarihi";
            this.colHesapAcilisTarihi.FieldName = "HesapAcilisTarihi";
            this.colHesapAcilisTarihi.Name = "colHesapAcilisTarihi";
            this.colHesapAcilisTarihi.OptionsColumn.AllowEdit = false;
            this.colHesapAcilisTarihi.StatusBarAciklama = null;
            this.colHesapAcilisTarihi.StatusBarKisaYol = null;
            this.colHesapAcilisTarihi.StatusBarKisaYolAciklama = null;
            this.colHesapAcilisTarihi.Visible = true;
            this.colHesapAcilisTarihi.VisibleIndex = 5;
            // 
            // colBlokeGunSayisi
            // 
            this.colBlokeGunSayisi.Caption = "Bloke Gün Sayısı";
            this.colBlokeGunSayisi.FieldName = "BlokeGunSayisi";
            this.colBlokeGunSayisi.Name = "colBlokeGunSayisi";
            this.colBlokeGunSayisi.OptionsColumn.AllowEdit = false;
            this.colBlokeGunSayisi.StatusBarAciklama = null;
            this.colBlokeGunSayisi.StatusBarKisaYol = null;
            this.colBlokeGunSayisi.StatusBarKisaYolAciklama = null;
            this.colBlokeGunSayisi.Visible = true;
            this.colBlokeGunSayisi.VisibleIndex = 6;
            // 
            // colIsyeriNo
            // 
            this.colIsyeriNo.Caption = "İşyeri No";
            this.colIsyeriNo.FieldName = "IsyeriNo";
            this.colIsyeriNo.Name = "colIsyeriNo";
            this.colIsyeriNo.OptionsColumn.AllowEdit = false;
            this.colIsyeriNo.StatusBarAciklama = null;
            this.colIsyeriNo.StatusBarKisaYol = null;
            this.colIsyeriNo.StatusBarKisaYolAciklama = null;
            this.colIsyeriNo.Visible = true;
            this.colIsyeriNo.VisibleIndex = 7;
            // 
            // colTerminalNo
            // 
            this.colTerminalNo.Caption = "Terminal No";
            this.colTerminalNo.FieldName = "TerminalNo";
            this.colTerminalNo.Name = "colTerminalNo";
            this.colTerminalNo.OptionsColumn.AllowEdit = false;
            this.colTerminalNo.StatusBarAciklama = null;
            this.colTerminalNo.StatusBarKisaYol = null;
            this.colTerminalNo.StatusBarKisaYolAciklama = null;
            this.colTerminalNo.Visible = true;
            this.colTerminalNo.VisibleIndex = 8;
            // 
            // colHesapNo
            // 
            this.colHesapNo.Caption = "Hesap No";
            this.colHesapNo.FieldName = "HesapNo";
            this.colHesapNo.Name = "colHesapNo";
            this.colHesapNo.OptionsColumn.AllowEdit = false;
            this.colHesapNo.StatusBarAciklama = null;
            this.colHesapNo.StatusBarKisaYol = null;
            this.colHesapNo.StatusBarKisaYolAciklama = null;
            this.colHesapNo.Visible = true;
            this.colHesapNo.VisibleIndex = 9;
            // 
            // colIbanNo
            // 
            this.colIbanNo.Caption = "IBAN No";
            this.colIbanNo.FieldName = "IbanNo";
            this.colIbanNo.Name = "colIbanNo";
            this.colIbanNo.OptionsColumn.AllowEdit = false;
            this.colIbanNo.StatusBarAciklama = null;
            this.colIbanNo.StatusBarKisaYol = null;
            this.colIbanNo.StatusBarKisaYolAciklama = null;
            this.colIbanNo.Visible = true;
            this.colIbanNo.VisibleIndex = 10;
            // 
            // colOzelKod1Adi
            // 
            this.colOzelKod1Adi.Caption = "Özel Kod-1";
            this.colOzelKod1Adi.FieldName = "OzelKod1Adi";
            this.colOzelKod1Adi.Name = "colOzelKod1Adi";
            this.colOzelKod1Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod1Adi.StatusBarAciklama = null;
            this.colOzelKod1Adi.StatusBarKisaYol = null;
            this.colOzelKod1Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod1Adi.Visible = true;
            this.colOzelKod1Adi.VisibleIndex = 11;
            // 
            // colOzelKod2Adi
            // 
            this.colOzelKod2Adi.Caption = "Özel Kod-2";
            this.colOzelKod2Adi.FieldName = "OzelKod2Adi";
            this.colOzelKod2Adi.Name = "colOzelKod2Adi";
            this.colOzelKod2Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod2Adi.StatusBarAciklama = null;
            this.colOzelKod2Adi.StatusBarKisaYol = null;
            this.colOzelKod2Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod2Adi.Visible = true;
            this.colOzelKod2Adi.VisibleIndex = 12;
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
            this.colAciklama.VisibleIndex = 13;
            // 
            // BankaHesapListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 446);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "BankaHesapListForm";
            this.Text = "Banka Hesap Kartları";
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
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Grid.MyGridColumn colHesapAdi;
        private UserControls.Grid.MyGridColumn colHesapTuru;
        private UserControls.Grid.MyGridColumn colBankaAdi;
        private UserControls.Grid.MyGridColumn colBankaSubeAdi;
        private UserControls.Grid.MyGridColumn colHesapAcilisTarihi;
        private UserControls.Grid.MyGridColumn colBlokeGunSayisi;
        private UserControls.Grid.MyGridColumn colIsyeriNo;
        private UserControls.Grid.MyGridColumn colTerminalNo;
        private UserControls.Grid.MyGridColumn colHesapNo;
        private UserControls.Grid.MyGridColumn colIbanNo;
        private UserControls.Grid.MyGridColumn colOzelKod1Adi;
        private UserControls.Grid.MyGridColumn colOzelKod2Adi;
        private UserControls.Grid.MyGridColumn colAciklama;
    }
}
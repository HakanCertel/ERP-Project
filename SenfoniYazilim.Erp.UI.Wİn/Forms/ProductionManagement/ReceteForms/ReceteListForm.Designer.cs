namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms
{
    partial class ReceteListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceteListForm));
            this.longNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.LongNavigator();
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKod = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colReceteAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMalzemeBirimAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colReceteDepoId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colReceteDepoAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCinsi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colVarsayılan = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSatinalmaTalepKalemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(1041, 56);
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
            this.longNavigator.Size = new System.Drawing.Size(1041, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 56);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1041, 335);
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
            this.colReceteAdi,
            this.colStokId,
            this.colStokKodu,
            this.colStokAdi,
            this.colMalzemeBirimAdi,
            this.colMiktar,
            this.colReceteDepoId,
            this.colReceteDepoAdi,
            this.colCinsi,
            this.colVarsayılan});
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
            this.tablo.ViewCaption = "Reçete Kartları";
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
            // colReceteAdi
            // 
            this.colReceteAdi.Caption = "Reçete Adı";
            this.colReceteAdi.FieldName = "ReceteAdi";
            this.colReceteAdi.Name = "colReceteAdi";
            this.colReceteAdi.OptionsColumn.AllowEdit = false;
            this.colReceteAdi.StatusBarAciklama = null;
            this.colReceteAdi.StatusBarKisaYol = null;
            this.colReceteAdi.StatusBarKisaYolAciklama = null;
            this.colReceteAdi.Visible = true;
            this.colReceteAdi.VisibleIndex = 1;
            this.colReceteAdi.Width = 128;
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
            this.colStokKodu.Width = 100;
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
            this.colStokAdi.VisibleIndex = 4;
            this.colStokAdi.Width = 228;
            // 
            // colMalzemeBirimAdi
            // 
            this.colMalzemeBirimAdi.Caption = "Malzeme Birimi";
            this.colMalzemeBirimAdi.FieldName = "MalzemeBirimAdi";
            this.colMalzemeBirimAdi.Name = "colMalzemeBirimAdi";
            this.colMalzemeBirimAdi.OptionsColumn.AllowEdit = false;
            this.colMalzemeBirimAdi.StatusBarAciklama = null;
            this.colMalzemeBirimAdi.StatusBarKisaYol = null;
            this.colMalzemeBirimAdi.StatusBarKisaYolAciklama = null;
            this.colMalzemeBirimAdi.Visible = true;
            this.colMalzemeBirimAdi.VisibleIndex = 5;
            this.colMalzemeBirimAdi.Width = 99;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar ";
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.StatusBarAciklama = null;
            this.colMiktar.StatusBarKisaYol = null;
            this.colMiktar.StatusBarKisaYolAciklama = null;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 6;
            // 
            // colReceteDepoId
            // 
            this.colReceteDepoId.Caption = "ReceteDepoId";
            this.colReceteDepoId.FieldName = "ReceteDepoId";
            this.colReceteDepoId.Name = "colReceteDepoId";
            this.colReceteDepoId.OptionsColumn.AllowEdit = false;
            this.colReceteDepoId.OptionsColumn.ShowInCustomizationForm = false;
            this.colReceteDepoId.StatusBarAciklama = null;
            this.colReceteDepoId.StatusBarKisaYol = null;
            this.colReceteDepoId.StatusBarKisaYolAciklama = null;
            // 
            // colReceteDepoAdi
            // 
            this.colReceteDepoAdi.Caption = "Reçete Depo Adı";
            this.colReceteDepoAdi.FieldName = "ReceteDepoAdi";
            this.colReceteDepoAdi.Name = "colReceteDepoAdi";
            this.colReceteDepoAdi.OptionsColumn.AllowEdit = false;
            this.colReceteDepoAdi.StatusBarAciklama = null;
            this.colReceteDepoAdi.StatusBarKisaYol = null;
            this.colReceteDepoAdi.StatusBarKisaYolAciklama = null;
            this.colReceteDepoAdi.Visible = true;
            this.colReceteDepoAdi.VisibleIndex = 2;
            this.colReceteDepoAdi.Width = 99;
            // 
            // colCinsi
            // 
            this.colCinsi.Caption = "Cinsi ";
            this.colCinsi.FieldName = "UrunCinsi";
            this.colCinsi.Name = "colCinsi";
            this.colCinsi.OptionsColumn.AllowEdit = false;
            this.colCinsi.StatusBarAciklama = null;
            this.colCinsi.StatusBarKisaYol = null;
            this.colCinsi.StatusBarKisaYolAciklama = null;
            this.colCinsi.Visible = true;
            this.colCinsi.VisibleIndex = 7;
            this.colCinsi.Width = 121;
            // 
            // colVarsayılan
            // 
            this.colVarsayılan.Caption = "Varsayılan";
            this.colVarsayılan.FieldName = "Varsayılan";
            this.colVarsayılan.Name = "colVarsayılan";
            this.colVarsayılan.OptionsColumn.AllowEdit = false;
            this.colVarsayılan.StatusBarAciklama = null;
            this.colVarsayılan.StatusBarKisaYol = null;
            this.colVarsayılan.StatusBarKisaYolAciklama = null;
            this.colVarsayılan.Visible = true;
            this.colVarsayılan.VisibleIndex = 8;
            // 
            // ReceteListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 446);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "ReceteListForm";
            this.Text = "Recete Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSatinalmaTalepKalemleri)).EndInit();
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
        private UserControls.Grid.MyGridColumn colStokAdi;
        private UserControls.Grid.MyGridColumn colMalzemeBirimAdi;
        private UserControls.Grid.MyGridColumn colReceteDepoId;
        private UserControls.Grid.MyGridColumn colCinsi;
        private UserControls.Grid.MyGridColumn colMiktar;
        private UserControls.Grid.MyGridColumn colReceteAdi;
        private UserControls.Grid.MyGridColumn colStokId;
        private UserControls.Grid.MyGridColumn colStokKodu;
        private UserControls.Grid.MyGridColumn colReceteDepoAdi;
        private UserControls.Grid.MyGridColumn colVarsayılan;
    }
}
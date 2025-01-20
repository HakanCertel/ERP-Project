namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms
{
    partial class MakinaElemanlariListForm
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
            this.longNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.LongNavigator();
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colMakinaId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMakinaKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMakinaAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
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
            this.colMakinaId,
            this.colMakinaKodu,
            this.colMakinaAdi,
            this.colStokId,
            this.colStokKodu,
            this.colStokAdi,
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
            this.tablo.ViewCaption = "Makina Elemanları Listesi";
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
            this.colMakinaKodu.OptionsColumn.AllowEdit = false;
            this.colMakinaKodu.StatusBarAciklama = null;
            this.colMakinaKodu.StatusBarKisaYol = null;
            this.colMakinaKodu.StatusBarKisaYolAciklama = null;
            this.colMakinaKodu.Visible = true;
            this.colMakinaKodu.VisibleIndex = 0;
            this.colMakinaKodu.Width = 101;
            // 
            // colMakinaAdi
            // 
            this.colMakinaAdi.Caption = "Makina Adi";
            this.colMakinaAdi.FieldName = "MakinaAdi";
            this.colMakinaAdi.Name = "colMakinaAdi";
            this.colMakinaAdi.OptionsColumn.AllowEdit = false;
            this.colMakinaAdi.StatusBarAciklama = null;
            this.colMakinaAdi.StatusBarKisaYol = null;
            this.colMakinaAdi.StatusBarKisaYolAciklama = null;
            this.colMakinaAdi.Visible = true;
            this.colMakinaAdi.VisibleIndex = 1;
            this.colMakinaAdi.Width = 247;
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
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.StatusBarAciklama = null;
            this.colStokKodu.StatusBarKisaYol = null;
            this.colStokKodu.StatusBarKisaYolAciklama = null;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 2;
            this.colStokKodu.Width = 109;
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
            this.colStokAdi.VisibleIndex = 3;
            this.colStokAdi.Width = 307;
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
            this.colAciklama.VisibleIndex = 4;
            this.colAciklama.Width = 301;
            // 
            // MakinaElemanlariListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 446);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "MakinaElemanlariListForm";
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
        private UserControls.Grid.MyGridColumn colMakinaId;
        private UserControls.Grid.MyGridColumn colMakinaKodu;
        private UserControls.Grid.MyGridColumn colMakinaAdi;
        private UserControls.Grid.MyGridColumn colStokId;
        private UserControls.Grid.MyGridColumn colStokKodu;
        private UserControls.Grid.MyGridColumn colStokAdi;
        private UserControls.Grid.MyGridColumn colAciklama;
    }
}
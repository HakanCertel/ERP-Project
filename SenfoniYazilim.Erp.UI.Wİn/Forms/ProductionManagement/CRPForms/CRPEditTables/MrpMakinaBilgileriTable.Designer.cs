namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.MrpEditFormTable
{
    partial class MrpMakinaBilgileriTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MrpMakinaBilgileriTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colMakinaId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMakinaKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMakinaAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIstasyonId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIstasyonKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIstasyonAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKapasiteIhtiyaci = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDonemselKapasite = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
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
            this.colIstasyonId,
            this.colIstasyonKodu,
            this.colIstasyonAdi,
            this.colKapasiteIhtiyaci,
            this.colDonemselKapasite});
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
            this.tablo.ViewCaption = "Makina Bilgileri";
            // 
            // colMakinaId
            // 
            this.colMakinaId.Caption = "MakinaId";
            this.colMakinaId.FieldName = "MakinaId";
            this.colMakinaId.Name = "colMakinaId";
            this.colMakinaId.OptionsColumn.AllowEdit = false;
            this.colMakinaId.OptionsColumn.ShowInCustomizationForm = false;
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
            this.colMakinaKodu.Width = 90;
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
            this.colMakinaAdi.Width = 160;
            // 
            // colIstasyonId
            // 
            this.colIstasyonId.Caption = "IstasyonId";
            this.colIstasyonId.FieldName = "IstasyonId";
            this.colIstasyonId.Name = "colIstasyonId";
            this.colIstasyonId.OptionsColumn.AllowEdit = false;
            this.colIstasyonId.OptionsColumn.ShowInCustomizationForm = false;
            this.colIstasyonId.StatusBarAciklama = null;
            this.colIstasyonId.StatusBarKisaYol = null;
            this.colIstasyonId.StatusBarKisaYolAciklama = null;
            // 
            // colIstasyonKodu
            // 
            this.colIstasyonKodu.Caption = "Istasyon Kodu";
            this.colIstasyonKodu.FieldName = "IstasyonKodu";
            this.colIstasyonKodu.Name = "colIstasyonKodu";
            this.colIstasyonKodu.OptionsColumn.AllowEdit = false;
            this.colIstasyonKodu.StatusBarAciklama = null;
            this.colIstasyonKodu.StatusBarKisaYol = null;
            this.colIstasyonKodu.StatusBarKisaYolAciklama = null;
            this.colIstasyonKodu.Width = 90;
            // 
            // colIstasyonAdi
            // 
            this.colIstasyonAdi.Caption = "Istasyon";
            this.colIstasyonAdi.FieldName = "IstasyonAdi";
            this.colIstasyonAdi.Name = "colIstasyonAdi";
            this.colIstasyonAdi.OptionsColumn.AllowEdit = false;
            this.colIstasyonAdi.StatusBarAciklama = null;
            this.colIstasyonAdi.StatusBarKisaYol = null;
            this.colIstasyonAdi.StatusBarKisaYolAciklama = null;
            this.colIstasyonAdi.Visible = true;
            this.colIstasyonAdi.VisibleIndex = 0;
            this.colIstasyonAdi.Width = 103;
            // 
            // colKapasiteIhtiyaci
            // 
            this.colKapasiteIhtiyaci.AppearanceCell.Options.UseTextOptions = true;
            this.colKapasiteIhtiyaci.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colKapasiteIhtiyaci.Caption = "Kapasite İhtiyacı";
            this.colKapasiteIhtiyaci.FieldName = "KapasiteIhtiyaci";
            this.colKapasiteIhtiyaci.Name = "colKapasiteIhtiyaci";
            this.colKapasiteIhtiyaci.OptionsColumn.AllowEdit = false;
            this.colKapasiteIhtiyaci.StatusBarAciklama = null;
            this.colKapasiteIhtiyaci.StatusBarKisaYol = null;
            this.colKapasiteIhtiyaci.StatusBarKisaYolAciklama = null;
            this.colKapasiteIhtiyaci.Visible = true;
            this.colKapasiteIhtiyaci.VisibleIndex = 2;
            this.colKapasiteIhtiyaci.Width = 112;
            // 
            // colDonemselKapasite
            // 
            this.colDonemselKapasite.AppearanceCell.Options.UseTextOptions = true;
            this.colDonemselKapasite.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDonemselKapasite.Caption = "Dönemsel Kapsite";
            this.colDonemselKapasite.FieldName = "DonemselKapasite";
            this.colDonemselKapasite.Name = "colDonemselKapasite";
            this.colDonemselKapasite.OptionsColumn.AllowEdit = false;
            this.colDonemselKapasite.StatusBarAciklama = null;
            this.colDonemselKapasite.StatusBarKisaYol = null;
            this.colDonemselKapasite.StatusBarKisaYolAciklama = null;
            this.colDonemselKapasite.Visible = true;
            this.colDonemselKapasite.VisibleIndex = 3;
            this.colDonemselKapasite.Width = 111;
            // 
            // MrpMakinaBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "MrpMakinaBilgileriTable";
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
        private Grid.MyGridColumn colMakinaId;
        private Grid.MyGridColumn colMakinaKodu;
        private Grid.MyGridColumn colMakinaAdi;
        private Grid.MyGridColumn colIstasyonId;
        private Grid.MyGridColumn colIstasyonKodu;
        private Grid.MyGridColumn colIstasyonAdi;
        private Grid.MyGridColumn colKapasiteIhtiyaci;
        private Grid.MyGridColumn colDonemselKapasite;
    }
}

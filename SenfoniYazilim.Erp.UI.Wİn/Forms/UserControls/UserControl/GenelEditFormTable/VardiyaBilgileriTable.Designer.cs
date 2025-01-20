namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.GenelEditFormTable
{
    partial class VardiyaBilgileriTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VardiyaBilgileriTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colKacinciVardiya = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colGun = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMesaiBaslamaSaati = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryTimeEdit0 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.colMesaiBitisSaati = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMolaSuresi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKapasite = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBirimSure = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryImageComboDayOfWeek = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryTimeEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTimeEdit0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryImageComboDayOfWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTimeEdit)).BeginInit();
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
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(50, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTimeEdit0,
            this.repositoryImageComboDayOfWeek,
            this.repositoryTimeEdit});
            this.grid.Size = new System.Drawing.Size(562, 227);
            this.grid.TabIndex = 23;
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
            this.colKacinciVardiya,
            this.colGun,
            this.colMesaiBaslamaSaati,
            this.colMesaiBitisSaati,
            this.colMolaSuresi,
            this.colKapasite,
            this.colBirimSure});
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
            this.tablo.ViewCaption = "Vardiya Bilgileri";
            // 
            // colKacinciVardiya
            // 
            this.colKacinciVardiya.AppearanceCell.Options.UseTextOptions = true;
            this.colKacinciVardiya.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKacinciVardiya.Caption = "Vardiya";
            this.colKacinciVardiya.FieldName = "KacinciVardiya";
            this.colKacinciVardiya.Name = "colKacinciVardiya";
            this.colKacinciVardiya.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKacinciVardiya.OptionsFilter.AllowAutoFilter = false;
            this.colKacinciVardiya.OptionsFilter.AllowFilter = false;
            this.colKacinciVardiya.StatusBarAciklama = null;
            this.colKacinciVardiya.StatusBarKisaYol = null;
            this.colKacinciVardiya.StatusBarKisaYolAciklama = null;
            this.colKacinciVardiya.Visible = true;
            this.colKacinciVardiya.VisibleIndex = 0;
            // 
            // colGun
            // 
            this.colGun.AppearanceCell.Options.UseTextOptions = true;
            this.colGun.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGun.Caption = "Gün";
            this.colGun.FieldName = "Gun";
            this.colGun.Name = "colGun";
            this.colGun.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGun.OptionsFilter.AllowAutoFilter = false;
            this.colGun.OptionsFilter.AllowFilter = false;
            this.colGun.StatusBarAciklama = null;
            this.colGun.StatusBarKisaYol = null;
            this.colGun.StatusBarKisaYolAciklama = null;
            this.colGun.Visible = true;
            this.colGun.VisibleIndex = 1;
            this.colGun.Width = 88;
            // 
            // colMesaiBaslamaSaati
            // 
            this.colMesaiBaslamaSaati.Caption = "Başlama Saati";
            this.colMesaiBaslamaSaati.ColumnEdit = this.repositoryTimeEdit0;
            this.colMesaiBaslamaSaati.FieldName = "MesaiBaslamaSaati";
            this.colMesaiBaslamaSaati.Name = "colMesaiBaslamaSaati";
            this.colMesaiBaslamaSaati.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMesaiBaslamaSaati.OptionsFilter.AllowAutoFilter = false;
            this.colMesaiBaslamaSaati.OptionsFilter.AllowFilter = false;
            this.colMesaiBaslamaSaati.StatusBarAciklama = null;
            this.colMesaiBaslamaSaati.StatusBarKisaYol = null;
            this.colMesaiBaslamaSaati.StatusBarKisaYolAciklama = null;
            this.colMesaiBaslamaSaati.Visible = true;
            this.colMesaiBaslamaSaati.VisibleIndex = 2;
            // 
            // repositoryTimeEdit0
            // 
            this.repositoryTimeEdit0.AutoHeight = false;
            this.repositoryTimeEdit0.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTimeEdit0.Mask.EditMask = "(0?\\d|1\\d|2[0-3])\\:[0-5]\\d";
            this.repositoryTimeEdit0.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryTimeEdit0.Name = "repositoryTimeEdit0";
            // 
            // colMesaiBitisSaati
            // 
            this.colMesaiBitisSaati.Caption = "Bitiş Saati";
            this.colMesaiBitisSaati.ColumnEdit = this.repositoryTimeEdit0;
            this.colMesaiBitisSaati.FieldName = "MesaiBitisSaati";
            this.colMesaiBitisSaati.Name = "colMesaiBitisSaati";
            this.colMesaiBitisSaati.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMesaiBitisSaati.OptionsFilter.AllowAutoFilter = false;
            this.colMesaiBitisSaati.OptionsFilter.AllowFilter = false;
            this.colMesaiBitisSaati.StatusBarAciklama = null;
            this.colMesaiBitisSaati.StatusBarKisaYol = null;
            this.colMesaiBitisSaati.StatusBarKisaYolAciklama = null;
            this.colMesaiBitisSaati.Visible = true;
            this.colMesaiBitisSaati.VisibleIndex = 3;
            // 
            // colMolaSuresi
            // 
            this.colMolaSuresi.AppearanceCell.Options.UseTextOptions = true;
            this.colMolaSuresi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMolaSuresi.Caption = "Mola Süresi";
            this.colMolaSuresi.FieldName = "MolaSuresi";
            this.colMolaSuresi.Name = "colMolaSuresi";
            this.colMolaSuresi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMolaSuresi.OptionsFilter.AllowAutoFilter = false;
            this.colMolaSuresi.OptionsFilter.AllowFilter = false;
            this.colMolaSuresi.StatusBarAciklama = null;
            this.colMolaSuresi.StatusBarKisaYol = null;
            this.colMolaSuresi.StatusBarKisaYolAciklama = null;
            this.colMolaSuresi.Visible = true;
            this.colMolaSuresi.VisibleIndex = 4;
            // 
            // colKapasite
            // 
            this.colKapasite.AppearanceCell.Options.UseTextOptions = true;
            this.colKapasite.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colKapasite.Caption = "Kapasite ";
            this.colKapasite.FieldName = "Kapasite";
            this.colKapasite.Name = "colKapasite";
            this.colKapasite.OptionsColumn.AllowEdit = false;
            this.colKapasite.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKapasite.OptionsFilter.AllowAutoFilter = false;
            this.colKapasite.OptionsFilter.AllowFilter = false;
            this.colKapasite.StatusBarAciklama = null;
            this.colKapasite.StatusBarKisaYol = null;
            this.colKapasite.StatusBarKisaYolAciklama = null;
            this.colKapasite.Visible = true;
            this.colKapasite.VisibleIndex = 5;
            this.colKapasite.Width = 71;
            // 
            // colBirimSure
            // 
            this.colBirimSure.AppearanceCell.Options.UseTextOptions = true;
            this.colBirimSure.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBirimSure.Caption = "Birim";
            this.colBirimSure.FieldName = "BirimSure";
            this.colBirimSure.Name = "colBirimSure";
            this.colBirimSure.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBirimSure.OptionsFilter.AllowAutoFilter = false;
            this.colBirimSure.OptionsFilter.AllowFilter = false;
            this.colBirimSure.StatusBarAciklama = null;
            this.colBirimSure.StatusBarKisaYol = null;
            this.colBirimSure.StatusBarKisaYolAciklama = null;
            this.colBirimSure.Visible = true;
            this.colBirimSure.VisibleIndex = 6;
            // 
            // repositoryImageComboDayOfWeek
            // 
            this.repositoryImageComboDayOfWeek.AutoHeight = false;
            this.repositoryImageComboDayOfWeek.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryImageComboDayOfWeek.Name = "repositoryImageComboDayOfWeek";
            // 
            // repositoryTimeEdit
            // 
            this.repositoryTimeEdit.AutoHeight = false;
            this.repositoryTimeEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTimeEdit.Mask.EditMask = "\\d?\\d:\\d\\d";
            this.repositoryTimeEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.repositoryTimeEdit.Name = "repositoryTimeEdit";
            // 
            // VardiyaBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "VardiyaBilgileriTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTimeEdit0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryImageComboDayOfWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTimeEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryTimeEdit0;
        private Grid.MyGridColumn colKacinciVardiya;
        private Grid.MyGridColumn colGun;
        private Grid.MyGridColumn colMesaiBaslamaSaati;
        private Grid.MyGridColumn colMesaiBitisSaati;
        private Grid.MyGridColumn colMolaSuresi;
        private Grid.MyGridColumn colKapasite;
        private Grid.MyGridColumn colBirimSure;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryImageComboDayOfWeek;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit repositoryTimeEdit;
    }
}

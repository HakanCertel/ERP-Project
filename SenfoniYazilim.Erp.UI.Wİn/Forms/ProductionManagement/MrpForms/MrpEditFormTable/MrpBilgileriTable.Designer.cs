namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.MrpEditFormTable
{
    partial class MrpBilgileriTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MrpBilgileriTable));
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colUserId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colReceteId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colStokKodu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemStokKodu = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colStokAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMiktar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colBaslangicTarihi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemBasTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBitisTarihi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryItemBitTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colMrpCreatingMethod = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemStokKodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBasTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBasTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBitTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBitTarih.CalendarTimeProperties)).BeginInit();
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
            this.repositoryItemBasTarih,
            this.repositoryItemStokKodu,
            this.repositoryItemBitTarih});
            this.grid.Size = new System.Drawing.Size(612, 203);
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
            this.colUserId,
            this.colReceteId,
            this.colStokKodu,
            this.colStokAdi,
            this.colMiktar,
            this.colBaslangicTarihi,
            this.colBitisTarihi,
            this.colMrpCreatingMethod});
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
            this.tablo.ViewCaption = "Mrp Talep Kartları";
            // 
            // colUserId
            // 
            this.colUserId.Caption = "UserId ";
            this.colUserId.FieldName = "UserId";
            this.colUserId.Name = "colUserId";
            this.colUserId.OptionsColumn.AllowEdit = false;
            this.colUserId.OptionsColumn.ShowInCustomizationForm = false;
            this.colUserId.StatusBarAciklama = null;
            this.colUserId.StatusBarKisaYol = null;
            this.colUserId.StatusBarKisaYolAciklama = null;
            // 
            // colReceteId
            // 
            this.colReceteId.Caption = "ReceteId";
            this.colReceteId.FieldName = "ReceteId";
            this.colReceteId.Name = "colReceteId";
            this.colReceteId.OptionsColumn.AllowEdit = false;
            this.colReceteId.OptionsColumn.ShowInCustomizationForm = false;
            this.colReceteId.StatusBarAciklama = null;
            this.colReceteId.StatusBarKisaYol = null;
            this.colReceteId.StatusBarKisaYolAciklama = null;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.ColumnEdit = this.repositoryItemStokKodu;
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsFilter.AllowAutoFilter = false;
            this.colStokKodu.StatusBarAciklama = null;
            this.colStokKodu.StatusBarKisaYol = null;
            this.colStokKodu.StatusBarKisaYolAciklama = null;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 0;
            this.colStokKodu.Width = 139;
            // 
            // repositoryItemStokKodu
            // 
            this.repositoryItemStokKodu.AutoHeight = false;
            this.repositoryItemStokKodu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemStokKodu.Name = "repositoryItemStokKodu";
            this.repositoryItemStokKodu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
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
            this.colStokAdi.Width = 313;
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
            this.colMiktar.VisibleIndex = 2;
            this.colMiktar.Width = 85;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.EditFormat.FormatString = "{0:n2}";
            this.repositoryItemDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colBaslangicTarihi
            // 
            this.colBaslangicTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colBaslangicTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBaslangicTarihi.Caption = "Başlama Tarihi";
            this.colBaslangicTarihi.ColumnEdit = this.repositoryItemBasTarih;
            this.colBaslangicTarihi.FieldName = "BaslangicTarihi";
            this.colBaslangicTarihi.Name = "colBaslangicTarihi";
            this.colBaslangicTarihi.StatusBarAciklama = null;
            this.colBaslangicTarihi.StatusBarKisaYol = null;
            this.colBaslangicTarihi.StatusBarKisaYolAciklama = null;
            this.colBaslangicTarihi.Visible = true;
            this.colBaslangicTarihi.VisibleIndex = 3;
            this.colBaslangicTarihi.Width = 143;
            // 
            // repositoryItemBasTarih
            // 
            this.repositoryItemBasTarih.AutoHeight = false;
            this.repositoryItemBasTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBasTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBasTarih.DisplayFormat.FormatString = "G";
            this.repositoryItemBasTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemBasTarih.EditFormat.FormatString = "G";
            this.repositoryItemBasTarih.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemBasTarih.Mask.EditMask = "G";
            this.repositoryItemBasTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemBasTarih.Name = "repositoryItemBasTarih";
            // 
            // colBitisTarihi
            // 
            this.colBitisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colBitisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBitisTarihi.Caption = "Tahmini Tamamlanma Tarihi";
            this.colBitisTarihi.ColumnEdit = this.repositoryItemBitTarih;
            this.colBitisTarihi.FieldName = "BitisTarihi";
            this.colBitisTarihi.Name = "colBitisTarihi";
            this.colBitisTarihi.StatusBarAciklama = null;
            this.colBitisTarihi.StatusBarKisaYol = null;
            this.colBitisTarihi.StatusBarKisaYolAciklama = null;
            this.colBitisTarihi.Visible = true;
            this.colBitisTarihi.VisibleIndex = 4;
            this.colBitisTarihi.Width = 146;
            // 
            // repositoryItemBitTarih
            // 
            this.repositoryItemBitTarih.AutoHeight = false;
            this.repositoryItemBitTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBitTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBitTarih.DisplayFormat.FormatString = "G";
            this.repositoryItemBitTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemBitTarih.EditFormat.FormatString = "G";
            this.repositoryItemBitTarih.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemBitTarih.Mask.EditMask = "G";
            this.repositoryItemBitTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemBitTarih.Name = "repositoryItemBitTarih";
            // 
            // colMrpCreatingMethod
            // 
            this.colMrpCreatingMethod.Caption = "Mrp Oluşturma Yöntemi";
            this.colMrpCreatingMethod.FieldName = "MrpCreatingMethod";
            this.colMrpCreatingMethod.Name = "colMrpCreatingMethod";
            this.colMrpCreatingMethod.OptionsColumn.AllowEdit = false;
            this.colMrpCreatingMethod.StatusBarAciklama = null;
            this.colMrpCreatingMethod.StatusBarKisaYol = null;
            this.colMrpCreatingMethod.StatusBarKisaYolAciklama = null;
            this.colMrpCreatingMethod.Visible = true;
            this.colMrpCreatingMethod.VisibleIndex = 5;
            // 
            // MrpBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "MrpBilgileriTable";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemStokKodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBasTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBasTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBitTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBitTarih)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colReceteId;
        private Grid.MyGridColumn colStokKodu;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemStokKodu;
        private Grid.MyGridColumn colStokAdi;
        private Grid.MyGridColumn colMiktar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private Grid.MyGridColumn colBaslangicTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemBasTarih;
        private Grid.MyGridColumn colBitisTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemBitTarih;
        private Grid.MyGridColumn colUserId;
        private Grid.MyGridColumn colMrpCreatingMethod;
    }
}

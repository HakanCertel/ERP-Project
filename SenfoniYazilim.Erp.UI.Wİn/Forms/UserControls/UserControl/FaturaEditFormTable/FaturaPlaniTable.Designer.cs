namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.FaturaEditFormTable
{
    partial class FaturaPlaniTable
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
            this.colAciklama = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPlanTarihi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colPlanTutar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colPlanIndirim = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPlanNetTutar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colFaturaNo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTahakkukTarih = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTahakkukTutar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTahakkukIndirimTutar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTahakkukNetTutar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 246);
            this.insUpNavigator.Size = new System.Drawing.Size(586, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih,
            this.repositoryDecimal});
            this.grid.Size = new System.Drawing.Size(586, 246);
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
            this.colAciklama,
            this.colPlanTarihi,
            this.colPlanTutar,
            this.colPlanIndirim,
            this.colPlanNetTutar,
            this.colFaturaNo,
            this.colTahakkukTarih,
            this.colTahakkukTutar,
            this.colTahakkukIndirimTutar,
            this.colTahakkukNetTutar});
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
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Fatura Planı";
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
            this.colAciklama.VisibleIndex = 0;
            // 
            // colPlanTarihi
            // 
            this.colPlanTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colPlanTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlanTarihi.Caption = "Plan Tarihi";
            this.colPlanTarihi.ColumnEdit = this.repositoryTarih;
            this.colPlanTarihi.FieldName = "PlanTarihi";
            this.colPlanTarihi.Name = "colPlanTarihi";
            this.colPlanTarihi.OptionsColumn.AllowEdit = false;
            this.colPlanTarihi.StatusBarAciklama = null;
            this.colPlanTarihi.StatusBarKisaYol = null;
            this.colPlanTarihi.StatusBarKisaYolAciklama = null;
            this.colPlanTarihi.Visible = true;
            this.colPlanTarihi.VisibleIndex = 1;
            // 
            // repositoryTarih
            // 
            this.repositoryTarih.AutoHeight = false;
            this.repositoryTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryTarih.Name = "repositoryTarih";
            // 
            // colPlanTutar
            // 
            this.colPlanTutar.Caption = "Plan Tutar";
            this.colPlanTutar.ColumnEdit = this.repositoryDecimal;
            this.colPlanTutar.FieldName = "PlanTutar";
            this.colPlanTutar.Name = "colPlanTutar";
            this.colPlanTutar.OptionsColumn.AllowEdit = false;
            this.colPlanTutar.StatusBarAciklama = null;
            this.colPlanTutar.StatusBarKisaYol = null;
            this.colPlanTutar.StatusBarKisaYolAciklama = null;
            this.colPlanTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanTutar", "{0:n2}")});
            this.colPlanTutar.Visible = true;
            this.colPlanTutar.VisibleIndex = 2;
            // 
            // repositoryDecimal
            // 
            this.repositoryDecimal.Appearance.Options.UseTextOptions = true;
            this.repositoryDecimal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryDecimal.AutoHeight = false;
            this.repositoryDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.EditFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.Mask.EditMask = "n2";
            this.repositoryDecimal.Name = "repositoryDecimal";
            // 
            // colPlanIndirim
            // 
            this.colPlanIndirim.Caption = "Plan İndirim";
            this.colPlanIndirim.ColumnEdit = this.repositoryDecimal;
            this.colPlanIndirim.FieldName = "PlanIndirimTutar";
            this.colPlanIndirim.Name = "colPlanIndirim";
            this.colPlanIndirim.OptionsColumn.AllowEdit = false;
            this.colPlanIndirim.StatusBarAciklama = null;
            this.colPlanIndirim.StatusBarKisaYol = null;
            this.colPlanIndirim.StatusBarKisaYolAciklama = null;
            this.colPlanIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanIndirimTutar", "{0:n2}")});
            this.colPlanIndirim.Visible = true;
            this.colPlanIndirim.VisibleIndex = 3;
            // 
            // colPlanNetTutar
            // 
            this.colPlanNetTutar.Caption = "Plan Net Tutar";
            this.colPlanNetTutar.ColumnEdit = this.repositoryDecimal;
            this.colPlanNetTutar.FieldName = "PlanNetTutar";
            this.colPlanNetTutar.Name = "colPlanNetTutar";
            this.colPlanNetTutar.OptionsColumn.AllowEdit = false;
            this.colPlanNetTutar.StatusBarAciklama = null;
            this.colPlanNetTutar.StatusBarKisaYol = null;
            this.colPlanNetTutar.StatusBarKisaYolAciklama = null;
            this.colPlanNetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanNetTutar", "{0:n2}")});
            this.colPlanNetTutar.Visible = true;
            this.colPlanNetTutar.VisibleIndex = 4;
            this.colPlanNetTutar.Width = 90;
            // 
            // colFaturaNo
            // 
            this.colFaturaNo.Caption = "Fatura No";
            this.colFaturaNo.FieldName = "FaturaNo";
            this.colFaturaNo.Name = "colFaturaNo";
            this.colFaturaNo.OptionsColumn.AllowEdit = false;
            this.colFaturaNo.StatusBarAciklama = null;
            this.colFaturaNo.StatusBarKisaYol = null;
            this.colFaturaNo.StatusBarKisaYolAciklama = null;
            this.colFaturaNo.Visible = true;
            this.colFaturaNo.VisibleIndex = 5;
            // 
            // colTahakkukTarih
            // 
            this.colTahakkukTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTahakkukTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTahakkukTarih.Caption = "Tahakkuk Tarih";
            this.colTahakkukTarih.ColumnEdit = this.repositoryTarih;
            this.colTahakkukTarih.FieldName = "TahakkukTarih";
            this.colTahakkukTarih.Name = "colTahakkukTarih";
            this.colTahakkukTarih.OptionsColumn.AllowEdit = false;
            this.colTahakkukTarih.StatusBarAciklama = null;
            this.colTahakkukTarih.StatusBarKisaYol = null;
            this.colTahakkukTarih.StatusBarKisaYolAciklama = null;
            this.colTahakkukTarih.Visible = true;
            this.colTahakkukTarih.VisibleIndex = 6;
            this.colTahakkukTarih.Width = 86;
            // 
            // colTahakkukTutar
            // 
            this.colTahakkukTutar.Caption = "Tahakkuk Tutar";
            this.colTahakkukTutar.ColumnEdit = this.repositoryDecimal;
            this.colTahakkukTutar.FieldName = "TahakkukTutar";
            this.colTahakkukTutar.Name = "colTahakkukTutar";
            this.colTahakkukTutar.OptionsColumn.AllowEdit = false;
            this.colTahakkukTutar.StatusBarAciklama = null;
            this.colTahakkukTutar.StatusBarKisaYol = null;
            this.colTahakkukTutar.StatusBarKisaYolAciklama = null;
            this.colTahakkukTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TahakkukTutar", "{0:n2}")});
            this.colTahakkukTutar.Visible = true;
            this.colTahakkukTutar.VisibleIndex = 7;
            this.colTahakkukTutar.Width = 98;
            // 
            // colTahakkukIndirimTutar
            // 
            this.colTahakkukIndirimTutar.Caption = "Tahakkuk İndirim";
            this.colTahakkukIndirimTutar.ColumnEdit = this.repositoryDecimal;
            this.colTahakkukIndirimTutar.FieldName = "TahakkukIndirimTutar";
            this.colTahakkukIndirimTutar.Name = "colTahakkukIndirimTutar";
            this.colTahakkukIndirimTutar.OptionsColumn.AllowEdit = false;
            this.colTahakkukIndirimTutar.StatusBarAciklama = null;
            this.colTahakkukIndirimTutar.StatusBarKisaYol = null;
            this.colTahakkukIndirimTutar.StatusBarKisaYolAciklama = null;
            this.colTahakkukIndirimTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TahakkukIndirimTutar", "{0:n2}")});
            this.colTahakkukIndirimTutar.Visible = true;
            this.colTahakkukIndirimTutar.VisibleIndex = 8;
            this.colTahakkukIndirimTutar.Width = 98;
            // 
            // colTahakkukNetTutar
            // 
            this.colTahakkukNetTutar.Caption = "Tahakkuk Net Tutar";
            this.colTahakkukNetTutar.ColumnEdit = this.repositoryDecimal;
            this.colTahakkukNetTutar.FieldName = "TahakkukNetTutar";
            this.colTahakkukNetTutar.Name = "colTahakkukNetTutar";
            this.colTahakkukNetTutar.OptionsColumn.AllowEdit = false;
            this.colTahakkukNetTutar.StatusBarAciklama = null;
            this.colTahakkukNetTutar.StatusBarKisaYol = null;
            this.colTahakkukNetTutar.StatusBarKisaYolAciklama = null;
            this.colTahakkukNetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TahakkukNetTutar", "{0:n2}")});
            this.colTahakkukNetTutar.Visible = true;
            this.colTahakkukNetTutar.VisibleIndex = 9;
            this.colTahakkukNetTutar.Width = 112;
            // 
            // FaturaPlaniTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "FaturaPlaniTable";
            this.Size = new System.Drawing.Size(586, 270);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colAciklama;
        private Grid.MyGridColumn colPlanTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private Grid.MyGridColumn colPlanTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
        private Grid.MyGridColumn colPlanIndirim;
        private Grid.MyGridColumn colPlanNetTutar;
        private Grid.MyGridColumn colFaturaNo;
        private Grid.MyGridColumn colTahakkukTarih;
        private Grid.MyGridColumn colTahakkukTutar;
        private Grid.MyGridColumn colTahakkukIndirimTutar;
        private Grid.MyGridColumn colTahakkukNetTutar;
    }
}

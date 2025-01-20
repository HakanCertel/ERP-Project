namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.TahakkukEditFormTable
{
    partial class HizmetBilgileriTable
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colHizmetId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colHizmetAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colHizmeTuruId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colServisId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colServisYeriAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIslemTarihi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBaslamaTarihi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBrutUcret = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colKistDonemDusulenUcret = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colNetUcret = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIptalEdildi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colEgitimDonemiGunSayisi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colAlinanHizmetGunSayisi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colGunlukUcret = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIptalTarihi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryIptalTarihi = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colIptalNedeniId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIptalNedeniAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryIptalNedeni = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colGittigiOkulId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colGittigiOkulAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryGittigiOkul = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colIptalAciklama = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIptalTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIptalTarihi.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIptalNedeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryGittigiOkul)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 178);
            this.insUpNavigator.Size = new System.Drawing.Size(934, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih,
            this.repositoryDecimal,
            this.repositoryIptalNedeni,
            this.repositoryGittigiOkul,
            this.repositoryIptalTarihi});
            this.grid.Size = new System.Drawing.Size(934, 178);
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
            this.colHizmetId,
            this.colHizmetAdi,
            this.colHizmeTuruId,
            this.colServisId,
            this.colServisYeriAdi,
            this.colIslemTarihi,
            this.colBaslamaTarihi,
            this.colBrutUcret,
            this.colKistDonemDusulenUcret,
            this.colNetUcret,
            this.colIptalEdildi,
            this.colEgitimDonemiGunSayisi,
            this.colAlinanHizmetGunSayisi,
            this.colGunlukUcret,
            this.colIptalTarihi,
            this.colIptalNedeniId,
            this.colIptalNedeniAdi,
            this.colGittigiOkulId,
            this.colGittigiOkulAdi,
            this.colIptalAciklama});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colIptalEdildi;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleValue1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Italic;
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleValue1.Appearance.Options.HighPriority = true;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = true;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.tablo.FormatRules.Add(gridFormatRule1);
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsCustomization.AllowFilter = false;
            this.tablo.OptionsCustomization.AllowSort = false;
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Hizmet Bilgileri";
            // 
            // colHizmetId
            // 
            this.colHizmetId.Caption = "HizmetId ";
            this.colHizmetId.FieldName = "HizmetId";
            this.colHizmetId.Name = "colHizmetId";
            this.colHizmetId.OptionsColumn.AllowEdit = false;
            this.colHizmetId.OptionsColumn.ShowInCustomizationForm = false;
            this.colHizmetId.StatusBarAciklama = null;
            this.colHizmetId.StatusBarKisaYol = null;
            this.colHizmetId.StatusBarKisaYolAciklama = null;
            // 
            // colHizmetAdi
            // 
            this.colHizmetAdi.Caption = "Hizmet Adı";
            this.colHizmetAdi.FieldName = "HizmetAdi";
            this.colHizmetAdi.Name = "colHizmetAdi";
            this.colHizmetAdi.OptionsColumn.AllowEdit = false;
            this.colHizmetAdi.StatusBarAciklama = null;
            this.colHizmetAdi.StatusBarKisaYol = null;
            this.colHizmetAdi.StatusBarKisaYolAciklama = null;
            this.colHizmetAdi.Visible = true;
            this.colHizmetAdi.VisibleIndex = 0;
            // 
            // colHizmeTuruId
            // 
            this.colHizmeTuruId.Caption = "HizmeTuruId ";
            this.colHizmeTuruId.FieldName = "HizmeTuruId";
            this.colHizmeTuruId.Name = "colHizmeTuruId";
            this.colHizmeTuruId.OptionsColumn.AllowEdit = false;
            this.colHizmeTuruId.OptionsColumn.ShowInCustomizationForm = false;
            this.colHizmeTuruId.StatusBarAciklama = null;
            this.colHizmeTuruId.StatusBarKisaYol = null;
            this.colHizmeTuruId.StatusBarKisaYolAciklama = null;
            // 
            // colServisId
            // 
            this.colServisId.Caption = "ServisId ";
            this.colServisId.FieldName = "ServisId";
            this.colServisId.Name = "colServisId";
            this.colServisId.OptionsColumn.AllowEdit = false;
            this.colServisId.OptionsColumn.ShowInCustomizationForm = false;
            this.colServisId.StatusBarAciklama = null;
            this.colServisId.StatusBarKisaYol = null;
            this.colServisId.StatusBarKisaYolAciklama = null;
            // 
            // colServisYeriAdi
            // 
            this.colServisYeriAdi.Caption = "Servis Yeri Adı";
            this.colServisYeriAdi.FieldName = "ServisYeriAdi";
            this.colServisYeriAdi.Name = "colServisYeriAdi";
            this.colServisYeriAdi.OptionsColumn.AllowEdit = false;
            this.colServisYeriAdi.StatusBarAciklama = null;
            this.colServisYeriAdi.StatusBarKisaYol = null;
            this.colServisYeriAdi.StatusBarKisaYolAciklama = null;
            // 
            // colIslemTarihi
            // 
            this.colIslemTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colIslemTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIslemTarihi.Caption = "İşlem Tarihi";
            this.colIslemTarihi.ColumnEdit = this.repositoryTarih;
            this.colIslemTarihi.FieldName = "IslemTarihi";
            this.colIslemTarihi.Name = "colIslemTarihi";
            this.colIslemTarihi.OptionsColumn.AllowEdit = false;
            this.colIslemTarihi.StatusBarAciklama = null;
            this.colIslemTarihi.StatusBarKisaYol = null;
            this.colIslemTarihi.StatusBarKisaYolAciklama = null;
            this.colIslemTarihi.Visible = true;
            this.colIslemTarihi.VisibleIndex = 5;
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
            // colBaslamaTarihi
            // 
            this.colBaslamaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colBaslamaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBaslamaTarihi.Caption = "Başlama Tarihi";
            this.colBaslamaTarihi.ColumnEdit = this.repositoryTarih;
            this.colBaslamaTarihi.FieldName = "BaslamaTarihi";
            this.colBaslamaTarihi.Name = "colBaslamaTarihi";
            this.colBaslamaTarihi.OptionsColumn.AllowEdit = false;
            this.colBaslamaTarihi.StatusBarAciklama = null;
            this.colBaslamaTarihi.StatusBarKisaYol = null;
            this.colBaslamaTarihi.StatusBarKisaYolAciklama = null;
            this.colBaslamaTarihi.Visible = true;
            this.colBaslamaTarihi.VisibleIndex = 3;
            // 
            // colBrutUcret
            // 
            this.colBrutUcret.Caption = "Brüt Ücret";
            this.colBrutUcret.ColumnEdit = this.repositoryDecimal;
            this.colBrutUcret.FieldName = "BrutUcret";
            this.colBrutUcret.Name = "colBrutUcret";
            this.colBrutUcret.OptionsColumn.AllowEdit = false;
            this.colBrutUcret.StatusBarAciklama = null;
            this.colBrutUcret.StatusBarKisaYol = null;
            this.colBrutUcret.StatusBarKisaYolAciklama = null;
            this.colBrutUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BrutUcret", "{0:n2}")});
            this.colBrutUcret.Visible = true;
            this.colBrutUcret.VisibleIndex = 1;
            // 
            // repositoryDecimal
            // 
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
            // colKistDonemDusulenUcret
            // 
            this.colKistDonemDusulenUcret.Caption = "Kıst Dönem Düşülen Ücret";
            this.colKistDonemDusulenUcret.ColumnEdit = this.repositoryDecimal;
            this.colKistDonemDusulenUcret.FieldName = "KistDonemDusulenUcret";
            this.colKistDonemDusulenUcret.Name = "colKistDonemDusulenUcret";
            this.colKistDonemDusulenUcret.OptionsColumn.AllowEdit = false;
            this.colKistDonemDusulenUcret.StatusBarAciklama = null;
            this.colKistDonemDusulenUcret.StatusBarKisaYol = null;
            this.colKistDonemDusulenUcret.StatusBarKisaYolAciklama = null;
            this.colKistDonemDusulenUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KistDusulenUcret", "{0:n2}")});
            this.colKistDonemDusulenUcret.Visible = true;
            this.colKistDonemDusulenUcret.VisibleIndex = 2;
            // 
            // colNetUcret
            // 
            this.colNetUcret.Caption = "Net Ücret";
            this.colNetUcret.ColumnEdit = this.repositoryDecimal;
            this.colNetUcret.FieldName = "NetUcret";
            this.colNetUcret.Name = "colNetUcret";
            this.colNetUcret.OptionsColumn.AllowEdit = false;
            this.colNetUcret.StatusBarAciklama = null;
            this.colNetUcret.StatusBarKisaYol = null;
            this.colNetUcret.StatusBarKisaYolAciklama = null;
            this.colNetUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetUcret", "{0:n2}")});
            this.colNetUcret.Visible = true;
            this.colNetUcret.VisibleIndex = 4;
            // 
            // colIptalEdildi
            // 
            this.colIptalEdildi.Caption = "IptalEdildi ";
            this.colIptalEdildi.FieldName = "IptalEdildi";
            this.colIptalEdildi.Name = "colIptalEdildi";
            this.colIptalEdildi.OptionsColumn.AllowEdit = false;
            this.colIptalEdildi.OptionsColumn.ShowInCustomizationForm = false;
            this.colIptalEdildi.StatusBarAciklama = null;
            this.colIptalEdildi.StatusBarKisaYol = null;
            this.colIptalEdildi.StatusBarKisaYolAciklama = null;
            // 
            // colEgitimDonemiGunSayisi
            // 
            this.colEgitimDonemiGunSayisi.Caption = "Eğitim Dönemi Gün Sayısı";
            this.colEgitimDonemiGunSayisi.FieldName = "EgitimDonemiGunSayisi";
            this.colEgitimDonemiGunSayisi.Name = "colEgitimDonemiGunSayisi";
            this.colEgitimDonemiGunSayisi.OptionsColumn.AllowEdit = false;
            this.colEgitimDonemiGunSayisi.StatusBarAciklama = null;
            this.colEgitimDonemiGunSayisi.StatusBarKisaYol = null;
            this.colEgitimDonemiGunSayisi.StatusBarKisaYolAciklama = null;
            this.colEgitimDonemiGunSayisi.Visible = true;
            this.colEgitimDonemiGunSayisi.VisibleIndex = 6;
            // 
            // colAlinanHizmetGunSayisi
            // 
            this.colAlinanHizmetGunSayisi.Caption = "Alınan Hizmet Gün Sayısı";
            this.colAlinanHizmetGunSayisi.FieldName = "AlinanHizmetGunSayisi";
            this.colAlinanHizmetGunSayisi.Name = "colAlinanHizmetGunSayisi";
            this.colAlinanHizmetGunSayisi.OptionsColumn.AllowEdit = false;
            this.colAlinanHizmetGunSayisi.StatusBarAciklama = null;
            this.colAlinanHizmetGunSayisi.StatusBarKisaYol = null;
            this.colAlinanHizmetGunSayisi.StatusBarKisaYolAciklama = null;
            this.colAlinanHizmetGunSayisi.Visible = true;
            this.colAlinanHizmetGunSayisi.VisibleIndex = 7;
            // 
            // colGunlukUcret
            // 
            this.colGunlukUcret.Caption = "Günlük Ücret";
            this.colGunlukUcret.ColumnEdit = this.repositoryDecimal;
            this.colGunlukUcret.FieldName = "GunlukUcret";
            this.colGunlukUcret.Name = "colGunlukUcret";
            this.colGunlukUcret.OptionsColumn.AllowEdit = false;
            this.colGunlukUcret.StatusBarAciklama = null;
            this.colGunlukUcret.StatusBarKisaYol = null;
            this.colGunlukUcret.StatusBarKisaYolAciklama = null;
            this.colGunlukUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GunlukUcret", "{0:n2}")});
            this.colGunlukUcret.Visible = true;
            this.colGunlukUcret.VisibleIndex = 8;
            // 
            // colIptalTarihi
            // 
            this.colIptalTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colIptalTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIptalTarihi.Caption = "İptal Tarihi";
            this.colIptalTarihi.ColumnEdit = this.repositoryIptalTarihi;
            this.colIptalTarihi.FieldName = "IptalTarihi";
            this.colIptalTarihi.Name = "colIptalTarihi";
            this.colIptalTarihi.OptionsColumn.AllowEdit = false;
            this.colIptalTarihi.StatusBarAciklama = null;
            this.colIptalTarihi.StatusBarKisaYol = null;
            this.colIptalTarihi.StatusBarKisaYolAciklama = null;
            this.colIptalTarihi.Visible = true;
            this.colIptalTarihi.VisibleIndex = 9;
            // 
            // repositoryIptalTarihi
            // 
            this.repositoryIptalTarihi.AutoHeight = false;
            this.repositoryIptalTarihi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryIptalTarihi.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryIptalTarihi.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryIptalTarihi.Name = "repositoryIptalTarihi";
            this.repositoryIptalTarihi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colIptalNedeniId
            // 
            this.colIptalNedeniId.Caption = "IptalNedeniId";
            this.colIptalNedeniId.FieldName = "IptalNedeniId";
            this.colIptalNedeniId.Name = "colIptalNedeniId";
            this.colIptalNedeniId.OptionsColumn.AllowEdit = false;
            this.colIptalNedeniId.OptionsColumn.ShowInCustomizationForm = false;
            this.colIptalNedeniId.StatusBarAciklama = null;
            this.colIptalNedeniId.StatusBarKisaYol = null;
            this.colIptalNedeniId.StatusBarKisaYolAciklama = null;
            // 
            // colIptalNedeniAdi
            // 
            this.colIptalNedeniAdi.Caption = "İptal Nedeni";
            this.colIptalNedeniAdi.ColumnEdit = this.repositoryIptalNedeni;
            this.colIptalNedeniAdi.FieldName = "IptalNedeniAdi";
            this.colIptalNedeniAdi.Name = "colIptalNedeniAdi";
            this.colIptalNedeniAdi.OptionsColumn.AllowEdit = false;
            this.colIptalNedeniAdi.StatusBarAciklama = null;
            this.colIptalNedeniAdi.StatusBarKisaYol = null;
            this.colIptalNedeniAdi.StatusBarKisaYolAciklama = null;
            this.colIptalNedeniAdi.Visible = true;
            this.colIptalNedeniAdi.VisibleIndex = 10;
            // 
            // repositoryIptalNedeni
            // 
            this.repositoryIptalNedeni.AutoHeight = false;
            this.repositoryIptalNedeni.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryIptalNedeni.Name = "repositoryIptalNedeni";
            this.repositoryIptalNedeni.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colGittigiOkulId
            // 
            this.colGittigiOkulId.Caption = "GittiğiOkulId";
            this.colGittigiOkulId.FieldName = "GittigiOkulId";
            this.colGittigiOkulId.Name = "colGittigiOkulId";
            this.colGittigiOkulId.OptionsColumn.AllowEdit = false;
            this.colGittigiOkulId.OptionsColumn.ShowInCustomizationForm = false;
            this.colGittigiOkulId.StatusBarAciklama = null;
            this.colGittigiOkulId.StatusBarKisaYol = null;
            this.colGittigiOkulId.StatusBarKisaYolAciklama = null;
            // 
            // colGittigiOkulAdi
            // 
            this.colGittigiOkulAdi.Caption = "Gittiği Okul";
            this.colGittigiOkulAdi.ColumnEdit = this.repositoryGittigiOkul;
            this.colGittigiOkulAdi.FieldName = "GittigiOkulAdi";
            this.colGittigiOkulAdi.Name = "colGittigiOkulAdi";
            this.colGittigiOkulAdi.OptionsColumn.AllowEdit = false;
            this.colGittigiOkulAdi.StatusBarAciklama = null;
            this.colGittigiOkulAdi.StatusBarKisaYol = null;
            this.colGittigiOkulAdi.StatusBarKisaYolAciklama = null;
            this.colGittigiOkulAdi.Visible = true;
            this.colGittigiOkulAdi.VisibleIndex = 11;
            // 
            // repositoryGittigiOkul
            // 
            this.repositoryGittigiOkul.AutoHeight = false;
            this.repositoryGittigiOkul.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryGittigiOkul.Name = "repositoryGittigiOkul";
            this.repositoryGittigiOkul.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colIptalAciklama
            // 
            this.colIptalAciklama.Caption = "Açıklama";
            this.colIptalAciklama.FieldName = "IptalAciklama";
            this.colIptalAciklama.Name = "colIptalAciklama";
            this.colIptalAciklama.OptionsColumn.AllowEdit = false;
            this.colIptalAciklama.StatusBarAciklama = null;
            this.colIptalAciklama.StatusBarKisaYol = null;
            this.colIptalAciklama.StatusBarKisaYolAciklama = null;
            this.colIptalAciklama.Visible = true;
            this.colIptalAciklama.VisibleIndex = 12;
            // 
            // HizmetBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "HizmetBilgileriTable";
            this.Size = new System.Drawing.Size(934, 202);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIptalTarihi.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIptalTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIptalNedeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryGittigiOkul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colHizmetId;
        private Grid.MyGridColumn colHizmetAdi;
        private Grid.MyGridColumn colHizmeTuruId;
        private Grid.MyGridColumn colServisId;
        private Grid.MyGridColumn colServisYeriAdi;
        private Grid.MyGridColumn colIslemTarihi;
        private Grid.MyGridColumn colBaslamaTarihi;
        private Grid.MyGridColumn colBrutUcret;
        private Grid.MyGridColumn colKistDonemDusulenUcret;
        private Grid.MyGridColumn colNetUcret;
        private Grid.MyGridColumn colIptalEdildi;
        private Grid.MyGridColumn colEgitimDonemiGunSayisi;
        private Grid.MyGridColumn colAlinanHizmetGunSayisi;
        private Grid.MyGridColumn colGunlukUcret;
        private Grid.MyGridColumn colIptalTarihi;
        private Grid.MyGridColumn colIptalNedeniId;
        private Grid.MyGridColumn colIptalNedeniAdi;
        private Grid.MyGridColumn colGittigiOkulId;
        private Grid.MyGridColumn colGittigiOkulAdi;
        private Grid.MyGridColumn colIptalAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryIptalNedeni;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryGittigiOkul;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryIptalTarihi;
    }
}

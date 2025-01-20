namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.FaturaEditFormTable
{
    partial class FaturaTahakkukTable
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
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colOgrenciNo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTcKimlikNo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSoyadi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSinifAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKayitTarihi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colKayitSekli = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKayitDurumu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIptalDurumu = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colVeliTcKimliNo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colVeliAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colVeliSoyadi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colVeliYakinlikAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colVeliMeslekAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colVeliEvAdres = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colVeliEvAdresIl = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colVeliEvAdresIlce = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colAciklama = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPlanTarih = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPlanTutar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colPlanIndirim = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPlanNetTutar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOzelKod1 = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOzelKod2 = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOzelKod3 = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOzelKod4 = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colOzelKod5 = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colFaturaNo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTahakkukTarih = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTahakkukTutar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTahakkukIndirim = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTahakkukNetTutar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.coKdvHaricTutar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTahakkukKdvTutar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTahakkukToplamTutar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKdvSekli = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKdvOrani = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colFaturaAdres = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colFaturaAdresIl = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colFaturaAdresIlce = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
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
            this.insUpNavigator.Size = new System.Drawing.Size(699, 24);
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
            this.grid.Size = new System.Drawing.Size(699, 246);
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
            this.colOgrenciNo,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colSinifAdi,
            this.colKayitTarihi,
            this.colKayitSekli,
            this.colKayitDurumu,
            this.colIptalDurumu,
            this.colVeliTcKimliNo,
            this.colVeliAdi,
            this.colVeliSoyadi,
            this.colVeliYakinlikAdi,
            this.colVeliMeslekAdi,
            this.colVeliEvAdres,
            this.colVeliEvAdresIl,
            this.colVeliEvAdresIlce,
            this.colAciklama,
            this.colPlanTarih,
            this.colPlanTutar,
            this.colPlanIndirim,
            this.colPlanNetTutar,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colOzelKod3,
            this.colOzelKod4,
            this.colOzelKod5,
            this.colFaturaNo,
            this.colTahakkukTarih,
            this.colTahakkukTutar,
            this.colTahakkukIndirim,
            this.colTahakkukNetTutar,
            this.coKdvHaricTutar,
            this.colTahakkukKdvTutar,
            this.colTahakkukToplamTutar,
            this.colKdvSekli,
            this.colKdvOrani,
            this.colFaturaAdres,
            this.colFaturaAdresIl,
            this.colFaturaAdresIlce});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.LightCoral;
            formatConditionRuleExpression1.Appearance.Options.HighPriority = true;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseTextOptions = true;
            formatConditionRuleExpression1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            formatConditionRuleExpression1.Expression = "[HizmetNetTutar]<>[PlanNetTutar]";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            formatConditionRuleExpression2.Appearance.Options.HighPriority = true;
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Expression = "[HizmetNetTutar]==0";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.tablo.FormatRules.Add(gridFormatRule1);
            this.tablo.FormatRules.Add(gridFormatRule2);
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
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Fatura Planı Kartları";
            // 
            // colOgrenciNo
            // 
            this.colOgrenciNo.Caption = "Öğrenci No";
            this.colOgrenciNo.FieldName = "OgrenciNo";
            this.colOgrenciNo.Name = "colOgrenciNo";
            this.colOgrenciNo.OptionsColumn.AllowEdit = false;
            this.colOgrenciNo.StatusBarAciklama = null;
            this.colOgrenciNo.StatusBarKisaYol = null;
            this.colOgrenciNo.StatusBarKisaYolAciklama = null;
            this.colOgrenciNo.Visible = true;
            this.colOgrenciNo.VisibleIndex = 0;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "Tc Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisaYol = null;
            this.colTcKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.VisibleIndex = 1;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 2;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 3;
            // 
            // colSinifAdi
            // 
            this.colSinifAdi.Caption = "Sınıf";
            this.colSinifAdi.FieldName = "SinifAdi";
            this.colSinifAdi.Name = "colSinifAdi";
            this.colSinifAdi.OptionsColumn.AllowEdit = false;
            this.colSinifAdi.StatusBarAciklama = null;
            this.colSinifAdi.StatusBarKisaYol = null;
            this.colSinifAdi.StatusBarKisaYolAciklama = null;
            this.colSinifAdi.Visible = true;
            this.colSinifAdi.VisibleIndex = 4;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colKayitTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKayitTarihi.Caption = "Kayıt Tarihi";
            this.colKayitTarihi.ColumnEdit = this.repositoryTarih;
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.StatusBarAciklama = null;
            this.colKayitTarihi.StatusBarKisaYol = null;
            this.colKayitTarihi.StatusBarKisaYolAciklama = null;
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.VisibleIndex = 5;
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
            // colKayitSekli
            // 
            this.colKayitSekli.Caption = "Kayıt Şekli";
            this.colKayitSekli.FieldName = "KayitSekli";
            this.colKayitSekli.Name = "colKayitSekli";
            this.colKayitSekli.OptionsColumn.AllowEdit = false;
            this.colKayitSekli.StatusBarAciklama = null;
            this.colKayitSekli.StatusBarKisaYol = null;
            this.colKayitSekli.StatusBarKisaYolAciklama = null;
            this.colKayitSekli.Visible = true;
            this.colKayitSekli.VisibleIndex = 6;
            // 
            // colKayitDurumu
            // 
            this.colKayitDurumu.Caption = "Kayıt Durumu";
            this.colKayitDurumu.FieldName = "KayitDurumu";
            this.colKayitDurumu.Name = "colKayitDurumu";
            this.colKayitDurumu.OptionsColumn.AllowEdit = false;
            this.colKayitDurumu.StatusBarAciklama = null;
            this.colKayitDurumu.StatusBarKisaYol = null;
            this.colKayitDurumu.StatusBarKisaYolAciklama = null;
            this.colKayitDurumu.Visible = true;
            this.colKayitDurumu.VisibleIndex = 7;
            // 
            // colIptalDurumu
            // 
            this.colIptalDurumu.Caption = "İptal Durumu";
            this.colIptalDurumu.FieldName = "IptalDurumu";
            this.colIptalDurumu.Name = "colIptalDurumu";
            this.colIptalDurumu.OptionsColumn.AllowEdit = false;
            this.colIptalDurumu.StatusBarAciklama = null;
            this.colIptalDurumu.StatusBarKisaYol = null;
            this.colIptalDurumu.StatusBarKisaYolAciklama = null;
            this.colIptalDurumu.Visible = true;
            this.colIptalDurumu.VisibleIndex = 8;
            // 
            // colVeliTcKimliNo
            // 
            this.colVeliTcKimliNo.Caption = "Veli TcKimliNo";
            this.colVeliTcKimliNo.FieldName = "VeliTcKimliNo";
            this.colVeliTcKimliNo.Name = "colVeliTcKimliNo";
            this.colVeliTcKimliNo.OptionsColumn.AllowEdit = false;
            this.colVeliTcKimliNo.StatusBarAciklama = null;
            this.colVeliTcKimliNo.StatusBarKisaYol = null;
            this.colVeliTcKimliNo.StatusBarKisaYolAciklama = null;
            this.colVeliTcKimliNo.Visible = true;
            this.colVeliTcKimliNo.VisibleIndex = 9;
            // 
            // colVeliAdi
            // 
            this.colVeliAdi.Caption = "Veli Adı";
            this.colVeliAdi.FieldName = "VeliAdi";
            this.colVeliAdi.Name = "colVeliAdi";
            this.colVeliAdi.OptionsColumn.AllowEdit = false;
            this.colVeliAdi.StatusBarAciklama = null;
            this.colVeliAdi.StatusBarKisaYol = null;
            this.colVeliAdi.StatusBarKisaYolAciklama = null;
            this.colVeliAdi.Visible = true;
            this.colVeliAdi.VisibleIndex = 10;
            // 
            // colVeliSoyadi
            // 
            this.colVeliSoyadi.Caption = "Veli Soyadı";
            this.colVeliSoyadi.FieldName = "VeliSoyadi";
            this.colVeliSoyadi.Name = "colVeliSoyadi";
            this.colVeliSoyadi.OptionsColumn.AllowEdit = false;
            this.colVeliSoyadi.StatusBarAciklama = null;
            this.colVeliSoyadi.StatusBarKisaYol = null;
            this.colVeliSoyadi.StatusBarKisaYolAciklama = null;
            this.colVeliSoyadi.Visible = true;
            this.colVeliSoyadi.VisibleIndex = 11;
            // 
            // colVeliYakinlikAdi
            // 
            this.colVeliYakinlikAdi.Caption = "Yakınlık";
            this.colVeliYakinlikAdi.FieldName = "VeliYakinlikAdi";
            this.colVeliYakinlikAdi.Name = "colVeliYakinlikAdi";
            this.colVeliYakinlikAdi.OptionsColumn.AllowEdit = false;
            this.colVeliYakinlikAdi.StatusBarAciklama = null;
            this.colVeliYakinlikAdi.StatusBarKisaYol = null;
            this.colVeliYakinlikAdi.StatusBarKisaYolAciklama = null;
            this.colVeliYakinlikAdi.Visible = true;
            this.colVeliYakinlikAdi.VisibleIndex = 12;
            // 
            // colVeliMeslekAdi
            // 
            this.colVeliMeslekAdi.Caption = "Meslek";
            this.colVeliMeslekAdi.FieldName = "VeliMeslekAdi";
            this.colVeliMeslekAdi.Name = "colVeliMeslekAdi";
            this.colVeliMeslekAdi.OptionsColumn.AllowEdit = false;
            this.colVeliMeslekAdi.StatusBarAciklama = null;
            this.colVeliMeslekAdi.StatusBarKisaYol = null;
            this.colVeliMeslekAdi.StatusBarKisaYolAciklama = null;
            this.colVeliMeslekAdi.Visible = true;
            this.colVeliMeslekAdi.VisibleIndex = 13;
            // 
            // colVeliEvAdres
            // 
            this.colVeliEvAdres.Caption = "Veli Ev Adres";
            this.colVeliEvAdres.FieldName = "VeliEvAdres";
            this.colVeliEvAdres.Name = "colVeliEvAdres";
            this.colVeliEvAdres.OptionsColumn.AllowEdit = false;
            this.colVeliEvAdres.StatusBarAciklama = null;
            this.colVeliEvAdres.StatusBarKisaYol = null;
            this.colVeliEvAdres.StatusBarKisaYolAciklama = null;
            this.colVeliEvAdres.Visible = true;
            this.colVeliEvAdres.VisibleIndex = 14;
            // 
            // colVeliEvAdresIl
            // 
            this.colVeliEvAdresIl.Caption = "V_Adres İl";
            this.colVeliEvAdresIl.FieldName = "VeliEvAdresIl";
            this.colVeliEvAdresIl.Name = "colVeliEvAdresIl";
            this.colVeliEvAdresIl.OptionsColumn.AllowEdit = false;
            this.colVeliEvAdresIl.StatusBarAciklama = null;
            this.colVeliEvAdresIl.StatusBarKisaYol = null;
            this.colVeliEvAdresIl.StatusBarKisaYolAciklama = null;
            this.colVeliEvAdresIl.Visible = true;
            this.colVeliEvAdresIl.VisibleIndex = 15;
            // 
            // colVeliEvAdresIlce
            // 
            this.colVeliEvAdresIlce.Caption = "V_Adres İlce";
            this.colVeliEvAdresIlce.FieldName = "VeliEvAdresIlce";
            this.colVeliEvAdresIlce.Name = "colVeliEvAdresIlce";
            this.colVeliEvAdresIlce.OptionsColumn.AllowEdit = false;
            this.colVeliEvAdresIlce.StatusBarAciklama = null;
            this.colVeliEvAdresIlce.StatusBarKisaYol = null;
            this.colVeliEvAdresIlce.StatusBarKisaYolAciklama = null;
            this.colVeliEvAdresIlce.Visible = true;
            this.colVeliEvAdresIlce.VisibleIndex = 16;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Fatura Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 17;
            // 
            // colPlanTarih
            // 
            this.colPlanTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colPlanTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlanTarih.Caption = "Plan Tarih";
            this.colPlanTarih.ColumnEdit = this.repositoryTarih;
            this.colPlanTarih.FieldName = "PlanTarih";
            this.colPlanTarih.Name = "colPlanTarih";
            this.colPlanTarih.OptionsColumn.AllowEdit = false;
            this.colPlanTarih.StatusBarAciklama = null;
            this.colPlanTarih.StatusBarKisaYol = null;
            this.colPlanTarih.StatusBarKisaYolAciklama = null;
            this.colPlanTarih.Visible = true;
            this.colPlanTarih.VisibleIndex = 18;
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
            this.colPlanTutar.VisibleIndex = 19;
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
            this.colPlanIndirim.VisibleIndex = 20;
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
            this.colPlanNetTutar.VisibleIndex = 21;
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.Caption = "Özel Kod-1";
            this.colOzelKod1.FieldName = "OzelKod1";
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.OptionsColumn.AllowEdit = false;
            this.colOzelKod1.StatusBarAciklama = null;
            this.colOzelKod1.StatusBarKisaYol = null;
            this.colOzelKod1.StatusBarKisaYolAciklama = null;
            this.colOzelKod1.Visible = true;
            this.colOzelKod1.VisibleIndex = 22;
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.Caption = "Özel Kod-2";
            this.colOzelKod2.FieldName = "OzelKod2";
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.OptionsColumn.AllowEdit = false;
            this.colOzelKod2.StatusBarAciklama = null;
            this.colOzelKod2.StatusBarKisaYol = null;
            this.colOzelKod2.StatusBarKisaYolAciklama = null;
            this.colOzelKod2.Visible = true;
            this.colOzelKod2.VisibleIndex = 23;
            // 
            // colOzelKod3
            // 
            this.colOzelKod3.Caption = "Özel Kod-3";
            this.colOzelKod3.FieldName = "OzelKod3";
            this.colOzelKod3.Name = "colOzelKod3";
            this.colOzelKod3.OptionsColumn.AllowEdit = false;
            this.colOzelKod3.StatusBarAciklama = null;
            this.colOzelKod3.StatusBarKisaYol = null;
            this.colOzelKod3.StatusBarKisaYolAciklama = null;
            this.colOzelKod3.Visible = true;
            this.colOzelKod3.VisibleIndex = 24;
            // 
            // colOzelKod4
            // 
            this.colOzelKod4.Caption = "Özel Kod-4";
            this.colOzelKod4.FieldName = "OzelKod4";
            this.colOzelKod4.Name = "colOzelKod4";
            this.colOzelKod4.OptionsColumn.AllowEdit = false;
            this.colOzelKod4.StatusBarAciklama = null;
            this.colOzelKod4.StatusBarKisaYol = null;
            this.colOzelKod4.StatusBarKisaYolAciklama = null;
            this.colOzelKod4.Visible = true;
            this.colOzelKod4.VisibleIndex = 25;
            // 
            // colOzelKod5
            // 
            this.colOzelKod5.Caption = "Özel Kod-5";
            this.colOzelKod5.FieldName = "OzelKod5";
            this.colOzelKod5.Name = "colOzelKod5";
            this.colOzelKod5.OptionsColumn.AllowEdit = false;
            this.colOzelKod5.StatusBarAciklama = null;
            this.colOzelKod5.StatusBarKisaYol = null;
            this.colOzelKod5.StatusBarKisaYolAciklama = null;
            this.colOzelKod5.Visible = true;
            this.colOzelKod5.VisibleIndex = 26;
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
            this.colFaturaNo.VisibleIndex = 27;
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
            this.colTahakkukTarih.VisibleIndex = 28;
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
            this.colTahakkukTutar.VisibleIndex = 29;
            // 
            // colTahakkukIndirim
            // 
            this.colTahakkukIndirim.Caption = "Tahakkuk Indirim";
            this.colTahakkukIndirim.ColumnEdit = this.repositoryDecimal;
            this.colTahakkukIndirim.FieldName = "TahakkukIndirimTutar";
            this.colTahakkukIndirim.Name = "colTahakkukIndirim";
            this.colTahakkukIndirim.OptionsColumn.AllowEdit = false;
            this.colTahakkukIndirim.StatusBarAciklama = null;
            this.colTahakkukIndirim.StatusBarKisaYol = null;
            this.colTahakkukIndirim.StatusBarKisaYolAciklama = null;
            this.colTahakkukIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TahakkukIndirimTutar", "{0:n2}")});
            this.colTahakkukIndirim.Visible = true;
            this.colTahakkukIndirim.VisibleIndex = 30;
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
            this.colTahakkukNetTutar.VisibleIndex = 31;
            // 
            // coKdvHaricTutar
            // 
            this.coKdvHaricTutar.Caption = "Kdv Hariç Tutar";
            this.coKdvHaricTutar.ColumnEdit = this.repositoryDecimal;
            this.coKdvHaricTutar.FieldName = "KdvHaricTutar";
            this.coKdvHaricTutar.Name = "coKdvHaricTutar";
            this.coKdvHaricTutar.OptionsColumn.AllowEdit = false;
            this.coKdvHaricTutar.StatusBarAciklama = null;
            this.coKdvHaricTutar.StatusBarKisaYol = null;
            this.coKdvHaricTutar.StatusBarKisaYolAciklama = null;
            this.coKdvHaricTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KdvHaricTutar", "{0:n2}")});
            this.coKdvHaricTutar.Visible = true;
            this.coKdvHaricTutar.VisibleIndex = 32;
            // 
            // colTahakkukKdvTutar
            // 
            this.colTahakkukKdvTutar.Caption = "Kdv Tutar";
            this.colTahakkukKdvTutar.ColumnEdit = this.repositoryDecimal;
            this.colTahakkukKdvTutar.FieldName = "KdvTutar";
            this.colTahakkukKdvTutar.Name = "colTahakkukKdvTutar";
            this.colTahakkukKdvTutar.OptionsColumn.AllowEdit = false;
            this.colTahakkukKdvTutar.StatusBarAciklama = null;
            this.colTahakkukKdvTutar.StatusBarKisaYol = null;
            this.colTahakkukKdvTutar.StatusBarKisaYolAciklama = null;
            this.colTahakkukKdvTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KdvTutar", "{0:n2}")});
            this.colTahakkukKdvTutar.Visible = true;
            this.colTahakkukKdvTutar.VisibleIndex = 33;
            // 
            // colTahakkukToplamTutar
            // 
            this.colTahakkukToplamTutar.Caption = "Toplam Tutar";
            this.colTahakkukToplamTutar.ColumnEdit = this.repositoryDecimal;
            this.colTahakkukToplamTutar.FieldName = "ToplamTutar";
            this.colTahakkukToplamTutar.Name = "colTahakkukToplamTutar";
            this.colTahakkukToplamTutar.OptionsColumn.AllowEdit = false;
            this.colTahakkukToplamTutar.StatusBarAciklama = null;
            this.colTahakkukToplamTutar.StatusBarKisaYol = null;
            this.colTahakkukToplamTutar.StatusBarKisaYolAciklama = null;
            this.colTahakkukToplamTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ToplamTutar", "{0:n2}")});
            this.colTahakkukToplamTutar.Visible = true;
            this.colTahakkukToplamTutar.VisibleIndex = 34;
            // 
            // colKdvSekli
            // 
            this.colKdvSekli.Caption = "Kdv Şekli";
            this.colKdvSekli.FieldName = "KdvSekli";
            this.colKdvSekli.Name = "colKdvSekli";
            this.colKdvSekli.OptionsColumn.AllowEdit = false;
            this.colKdvSekli.StatusBarAciklama = null;
            this.colKdvSekli.StatusBarKisaYol = null;
            this.colKdvSekli.StatusBarKisaYolAciklama = null;
            this.colKdvSekli.Visible = true;
            this.colKdvSekli.VisibleIndex = 35;
            // 
            // colKdvOrani
            // 
            this.colKdvOrani.Caption = "Kdv Oranı";
            this.colKdvOrani.ColumnEdit = this.repositoryDecimal;
            this.colKdvOrani.FieldName = "KdvOrani";
            this.colKdvOrani.Name = "colKdvOrani";
            this.colKdvOrani.OptionsColumn.AllowEdit = false;
            this.colKdvOrani.StatusBarAciklama = null;
            this.colKdvOrani.StatusBarKisaYol = null;
            this.colKdvOrani.StatusBarKisaYolAciklama = null;
            this.colKdvOrani.Visible = true;
            this.colKdvOrani.VisibleIndex = 36;
            // 
            // colFaturaAdres
            // 
            this.colFaturaAdres.Caption = "Fatura Adresi";
            this.colFaturaAdres.FieldName = "FaturaAdres";
            this.colFaturaAdres.Name = "colFaturaAdres";
            this.colFaturaAdres.OptionsColumn.AllowEdit = false;
            this.colFaturaAdres.StatusBarAciklama = null;
            this.colFaturaAdres.StatusBarKisaYol = null;
            this.colFaturaAdres.StatusBarKisaYolAciklama = null;
            this.colFaturaAdres.Visible = true;
            this.colFaturaAdres.VisibleIndex = 37;
            // 
            // colFaturaAdresIl
            // 
            this.colFaturaAdresIl.Caption = "Fatura Adres Il";
            this.colFaturaAdresIl.FieldName = "FaturaAdresIlAdi";
            this.colFaturaAdresIl.Name = "colFaturaAdresIl";
            this.colFaturaAdresIl.OptionsColumn.AllowEdit = false;
            this.colFaturaAdresIl.StatusBarAciklama = null;
            this.colFaturaAdresIl.StatusBarKisaYol = null;
            this.colFaturaAdresIl.StatusBarKisaYolAciklama = null;
            this.colFaturaAdresIl.Visible = true;
            this.colFaturaAdresIl.VisibleIndex = 38;
            // 
            // colFaturaAdresIlce
            // 
            this.colFaturaAdresIlce.Caption = "Fatura Adres İlçe";
            this.colFaturaAdresIlce.FieldName = "FaturaAdresIlceAdi";
            this.colFaturaAdresIlce.Name = "colFaturaAdresIlce";
            this.colFaturaAdresIlce.OptionsColumn.AllowEdit = false;
            this.colFaturaAdresIlce.StatusBarAciklama = null;
            this.colFaturaAdresIlce.StatusBarKisaYol = null;
            this.colFaturaAdresIlce.StatusBarKisaYolAciklama = null;
            this.colFaturaAdresIlce.Visible = true;
            this.colFaturaAdresIlce.VisibleIndex = 39;
            // 
            // FaturaTahakkukTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "FaturaTahakkukTable";
            this.Size = new System.Drawing.Size(699, 270);
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
        private Grid.MyGridColumn colOgrenciNo;
        private Grid.MyGridColumn colTcKimlikNo;
        private Grid.MyGridColumn colAdi;
        private Grid.MyGridColumn colSoyadi;
        private Grid.MyGridColumn colSinifAdi;
        private Grid.MyGridColumn colKayitTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
        private Grid.MyGridColumn colKayitSekli;
        private Grid.MyGridColumn colKayitDurumu;
        private Grid.MyGridColumn colIptalDurumu;
        private Grid.MyGridColumn colVeliTcKimliNo;
        private Grid.MyGridColumn colVeliAdi;
        private Grid.MyGridColumn colVeliSoyadi;
        private Grid.MyGridColumn colVeliYakinlikAdi;
        private Grid.MyGridColumn colVeliMeslekAdi;
        private Grid.MyGridColumn colVeliEvAdres;
        private Grid.MyGridColumn colVeliEvAdresIl;
        private Grid.MyGridColumn colVeliEvAdresIlce;
        private Grid.MyGridColumn colPlanTutar;
        private Grid.MyGridColumn colPlanIndirim;
        private Grid.MyGridColumn colPlanNetTutar;
        private Grid.MyGridColumn colOzelKod1;
        private Grid.MyGridColumn colOzelKod2;
        private Grid.MyGridColumn colOzelKod3;
        private Grid.MyGridColumn colOzelKod4;
        private Grid.MyGridColumn colOzelKod5;
        private Grid.MyGridColumn colKdvSekli;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private Grid.MyGridColumn colAciklama;
        private Grid.MyGridColumn colPlanTarih;
        private Grid.MyGridColumn colFaturaNo;
        private Grid.MyGridColumn colTahakkukTarih;
        private Grid.MyGridColumn colTahakkukTutar;
        private Grid.MyGridColumn colTahakkukIndirim;
        private Grid.MyGridColumn colTahakkukNetTutar;
        private Grid.MyGridColumn coKdvHaricTutar;
        private Grid.MyGridColumn colTahakkukKdvTutar;
        private Grid.MyGridColumn colTahakkukToplamTutar;
        private Grid.MyGridColumn colKdvOrani;
        private Grid.MyGridColumn colFaturaAdres;
        private Grid.MyGridColumn colFaturaAdresIl;
        private Grid.MyGridColumn colFaturaAdresIlce;
    }
}

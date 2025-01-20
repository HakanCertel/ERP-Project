namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.TahakkukEditFormTable
{
    partial class IletisimBilgileriTable
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
            this.colVeli = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colFaturaAdresi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colYakinlikId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colYakinlikAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colTcKimlikNo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSoyadi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colEvTel = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIsTel1 = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCepTel1 = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colEvAdres = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colEvAdresIlAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colEvAdresIlceAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIsAdres = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIsAdresIlAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIsAdreIlceAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colMeslekAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colIsYeriAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colGorevAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.repositoryYakinlik = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryAdres = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryVeli = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryYakinlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryVeli)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryYakinlik,
            this.repositoryAdres,
            this.repositoryVeli});
            this.grid.Size = new System.Drawing.Size(725, 195);
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
            this.colVeli,
            this.colFaturaAdresi,
            this.colYakinlikId,
            this.colYakinlikAdi,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colEvTel,
            this.colIsTel1,
            this.colCepTel1,
            this.colEvAdres,
            this.colEvAdresIlAdi,
            this.colEvAdresIlceAdi,
            this.colIsAdres,
            this.colIsAdresIlAdi,
            this.colIsAdreIlceAdi,
            this.colMeslekAdi,
            this.colIsYeriAdi,
            this.colGorevAdi});
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
            this.tablo.ViewCaption = "İletişim Bilgileri";
            // 
            // colVeli
            // 
            this.colVeli.Caption = "Veli ";
            this.colVeli.ColumnEdit = this.repositoryVeli;
            this.colVeli.FieldName = "Veli";
            this.colVeli.Name = "colVeli";
            this.colVeli.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colVeli.OptionsFilter.AllowAutoFilter = false;
            this.colVeli.OptionsFilter.AllowFilter = false;
            this.colVeli.StatusBarAciklama = null;
            this.colVeli.StatusBarKisaYol = null;
            this.colVeli.StatusBarKisaYolAciklama = null;
            this.colVeli.Visible = true;
            this.colVeli.VisibleIndex = 0;
            // 
            // colFaturaAdresi
            // 
            this.colFaturaAdresi.Caption = "Fatura Adresi";
            this.colFaturaAdresi.ColumnEdit = this.repositoryAdres;
            this.colFaturaAdresi.FieldName = "FaturaAdresi";
            this.colFaturaAdresi.Name = "colFaturaAdresi";
            this.colFaturaAdresi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFaturaAdresi.OptionsFilter.AllowAutoFilter = false;
            this.colFaturaAdresi.OptionsFilter.AllowFilter = false;
            this.colFaturaAdresi.StatusBarAciklama = null;
            this.colFaturaAdresi.StatusBarKisaYol = null;
            this.colFaturaAdresi.StatusBarKisaYolAciklama = null;
            this.colFaturaAdresi.Visible = true;
            this.colFaturaAdresi.VisibleIndex = 1;
            // 
            // colYakinlikId
            // 
            this.colYakinlikId.Caption = "YakınlıId";
            this.colYakinlikId.FieldName = "YakinlikId";
            this.colYakinlikId.Name = "colYakinlikId";
            this.colYakinlikId.OptionsColumn.AllowEdit = false;
            this.colYakinlikId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colYakinlikId.OptionsColumn.ShowInCustomizationForm = false;
            this.colYakinlikId.OptionsFilter.AllowAutoFilter = false;
            this.colYakinlikId.OptionsFilter.AllowFilter = false;
            this.colYakinlikId.StatusBarAciklama = null;
            this.colYakinlikId.StatusBarKisaYol = null;
            this.colYakinlikId.StatusBarKisaYolAciklama = null;
            // 
            // colYakinlikAdi
            // 
            this.colYakinlikAdi.Caption = "Yakınlık";
            this.colYakinlikAdi.ColumnEdit = this.repositoryYakinlik;
            this.colYakinlikAdi.FieldName = "YakinlikAdi";
            this.colYakinlikAdi.Name = "colYakinlikAdi";
            this.colYakinlikAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colYakinlikAdi.OptionsFilter.AllowAutoFilter = false;
            this.colYakinlikAdi.OptionsFilter.AllowFilter = false;
            this.colYakinlikAdi.StatusBarAciklama = null;
            this.colYakinlikAdi.StatusBarKisaYol = null;
            this.colYakinlikAdi.StatusBarKisaYolAciklama = null;
            this.colYakinlikAdi.Visible = true;
            this.colYakinlikAdi.VisibleIndex = 2;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "Tc Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTcKimlikNo.OptionsFilter.AllowAutoFilter = false;
            this.colTcKimlikNo.OptionsFilter.AllowFilter = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisaYol = null;
            this.colTcKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.VisibleIndex = 3;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAdi.OptionsFilter.AllowAutoFilter = false;
            this.colAdi.OptionsFilter.AllowFilter = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 4;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSoyadi.OptionsFilter.AllowAutoFilter = false;
            this.colSoyadi.OptionsFilter.AllowFilter = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 5;
            // 
            // colEvTel
            // 
            this.colEvTel.Caption = "Ev Telefonu";
            this.colEvTel.FieldName = "EvTel";
            this.colEvTel.Name = "colEvTel";
            this.colEvTel.OptionsColumn.AllowEdit = false;
            this.colEvTel.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvTel.OptionsFilter.AllowAutoFilter = false;
            this.colEvTel.OptionsFilter.AllowFilter = false;
            this.colEvTel.StatusBarAciklama = null;
            this.colEvTel.StatusBarKisaYol = null;
            this.colEvTel.StatusBarKisaYolAciklama = null;
            this.colEvTel.Visible = true;
            this.colEvTel.VisibleIndex = 6;
            // 
            // colIsTel1
            // 
            this.colIsTel1.Caption = "İş Telefonu-1";
            this.colIsTel1.FieldName = "IsTel1";
            this.colIsTel1.Name = "colIsTel1";
            this.colIsTel1.OptionsColumn.AllowEdit = false;
            this.colIsTel1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsTel1.OptionsFilter.AllowAutoFilter = false;
            this.colIsTel1.OptionsFilter.AllowFilter = false;
            this.colIsTel1.StatusBarAciklama = null;
            this.colIsTel1.StatusBarKisaYol = null;
            this.colIsTel1.StatusBarKisaYolAciklama = null;
            this.colIsTel1.Visible = true;
            this.colIsTel1.VisibleIndex = 7;
            // 
            // colCepTel1
            // 
            this.colCepTel1.Caption = "Cep Telefonu-1";
            this.colCepTel1.FieldName = "CepTel1";
            this.colCepTel1.Name = "colCepTel1";
            this.colCepTel1.OptionsColumn.AllowEdit = false;
            this.colCepTel1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCepTel1.OptionsFilter.AllowAutoFilter = false;
            this.colCepTel1.OptionsFilter.AllowFilter = false;
            this.colCepTel1.StatusBarAciklama = null;
            this.colCepTel1.StatusBarKisaYol = null;
            this.colCepTel1.StatusBarKisaYolAciklama = null;
            this.colCepTel1.Visible = true;
            this.colCepTel1.VisibleIndex = 8;
            // 
            // colEvAdres
            // 
            this.colEvAdres.Caption = "Ev Adresi";
            this.colEvAdres.FieldName = "EvAdres";
            this.colEvAdres.Name = "colEvAdres";
            this.colEvAdres.OptionsColumn.AllowEdit = false;
            this.colEvAdres.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdres.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdres.OptionsFilter.AllowFilter = false;
            this.colEvAdres.StatusBarAciklama = null;
            this.colEvAdres.StatusBarKisaYol = null;
            this.colEvAdres.StatusBarKisaYolAciklama = null;
            this.colEvAdres.Visible = true;
            this.colEvAdres.VisibleIndex = 9;
            // 
            // colEvAdresIlAdi
            // 
            this.colEvAdresIlAdi.Caption = "Il";
            this.colEvAdresIlAdi.CustomizationCaption = "Ev Adres Il Adı";
            this.colEvAdresIlAdi.FieldName = "EvAdresIlAdi";
            this.colEvAdresIlAdi.Name = "colEvAdresIlAdi";
            this.colEvAdresIlAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresIlAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdresIlAdi.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdresIlAdi.OptionsFilter.AllowFilter = false;
            this.colEvAdresIlAdi.StatusBarAciklama = null;
            this.colEvAdresIlAdi.StatusBarKisaYol = null;
            this.colEvAdresIlAdi.StatusBarKisaYolAciklama = null;
            this.colEvAdresIlAdi.Visible = true;
            this.colEvAdresIlAdi.VisibleIndex = 10;
            // 
            // colEvAdresIlceAdi
            // 
            this.colEvAdresIlceAdi.Caption = "İlçe";
            this.colEvAdresIlceAdi.CustomizationCaption = "Ev Adresi İlçe Adı";
            this.colEvAdresIlceAdi.FieldName = "EvAdresIlceAdi";
            this.colEvAdresIlceAdi.Name = "colEvAdresIlceAdi";
            this.colEvAdresIlceAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresIlceAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdresIlceAdi.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdresIlceAdi.OptionsFilter.AllowFilter = false;
            this.colEvAdresIlceAdi.StatusBarAciklama = null;
            this.colEvAdresIlceAdi.StatusBarKisaYol = null;
            this.colEvAdresIlceAdi.StatusBarKisaYolAciklama = null;
            this.colEvAdresIlceAdi.Visible = true;
            this.colEvAdresIlceAdi.VisibleIndex = 11;
            // 
            // colIsAdres
            // 
            this.colIsAdres.Caption = "İş Adresi";
            this.colIsAdres.FieldName = "IsAdres";
            this.colIsAdres.Name = "colIsAdres";
            this.colIsAdres.OptionsColumn.AllowEdit = false;
            this.colIsAdres.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdres.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdres.OptionsFilter.AllowFilter = false;
            this.colIsAdres.StatusBarAciklama = null;
            this.colIsAdres.StatusBarKisaYol = null;
            this.colIsAdres.StatusBarKisaYolAciklama = null;
            this.colIsAdres.Visible = true;
            this.colIsAdres.VisibleIndex = 12;
            // 
            // colIsAdresIlAdi
            // 
            this.colIsAdresIlAdi.Caption = "İl";
            this.colIsAdresIlAdi.CustomizationCaption = "İş Adresi İl Adı";
            this.colIsAdresIlAdi.FieldName = "IsAdresIlAdi";
            this.colIsAdresIlAdi.Name = "colIsAdresIlAdi";
            this.colIsAdresIlAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresIlAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdresIlAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdresIlAdi.OptionsFilter.AllowFilter = false;
            this.colIsAdresIlAdi.StatusBarAciklama = null;
            this.colIsAdresIlAdi.StatusBarKisaYol = null;
            this.colIsAdresIlAdi.StatusBarKisaYolAciklama = null;
            this.colIsAdresIlAdi.Visible = true;
            this.colIsAdresIlAdi.VisibleIndex = 13;
            // 
            // colIsAdreIlceAdi
            // 
            this.colIsAdreIlceAdi.Caption = "İlçe";
            this.colIsAdreIlceAdi.CustomizationCaption = "İş Adresi İlçe Adı";
            this.colIsAdreIlceAdi.FieldName = "IsAdresIlceAdi";
            this.colIsAdreIlceAdi.Name = "colIsAdreIlceAdi";
            this.colIsAdreIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdreIlceAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdreIlceAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdreIlceAdi.OptionsFilter.AllowFilter = false;
            this.colIsAdreIlceAdi.StatusBarAciklama = null;
            this.colIsAdreIlceAdi.StatusBarKisaYol = null;
            this.colIsAdreIlceAdi.StatusBarKisaYolAciklama = null;
            this.colIsAdreIlceAdi.Visible = true;
            this.colIsAdreIlceAdi.VisibleIndex = 14;
            // 
            // colMeslekAdi
            // 
            this.colMeslekAdi.Caption = "Meslek";
            this.colMeslekAdi.FieldName = "MeslekAdi";
            this.colMeslekAdi.Name = "colMeslekAdi";
            this.colMeslekAdi.OptionsColumn.AllowEdit = false;
            this.colMeslekAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMeslekAdi.OptionsFilter.AllowAutoFilter = false;
            this.colMeslekAdi.OptionsFilter.AllowFilter = false;
            this.colMeslekAdi.StatusBarAciklama = null;
            this.colMeslekAdi.StatusBarKisaYol = null;
            this.colMeslekAdi.StatusBarKisaYolAciklama = null;
            this.colMeslekAdi.Visible = true;
            this.colMeslekAdi.VisibleIndex = 15;
            // 
            // colIsYeriAdi
            // 
            this.colIsYeriAdi.Caption = "İş Yeri";
            this.colIsYeriAdi.FieldName = "IsYeriAdi";
            this.colIsYeriAdi.Name = "colIsYeriAdi";
            this.colIsYeriAdi.OptionsColumn.AllowEdit = false;
            this.colIsYeriAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsYeriAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsYeriAdi.OptionsFilter.AllowFilter = false;
            this.colIsYeriAdi.StatusBarAciklama = null;
            this.colIsYeriAdi.StatusBarKisaYol = null;
            this.colIsYeriAdi.StatusBarKisaYolAciklama = null;
            this.colIsYeriAdi.Visible = true;
            this.colIsYeriAdi.VisibleIndex = 16;
            // 
            // colGorevAdi
            // 
            this.colGorevAdi.Caption = "Görev";
            this.colGorevAdi.FieldName = "GorevAdi";
            this.colGorevAdi.Name = "colGorevAdi";
            this.colGorevAdi.OptionsColumn.AllowEdit = false;
            this.colGorevAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGorevAdi.OptionsFilter.AllowAutoFilter = false;
            this.colGorevAdi.OptionsFilter.AllowFilter = false;
            this.colGorevAdi.StatusBarAciklama = null;
            this.colGorevAdi.StatusBarKisaYol = null;
            this.colGorevAdi.StatusBarKisaYolAciklama = null;
            this.colGorevAdi.Visible = true;
            this.colGorevAdi.VisibleIndex = 17;
            // 
            // repositoryYakinlik
            // 
            this.repositoryYakinlik.AutoHeight = false;
            this.repositoryYakinlik.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryYakinlik.Name = "repositoryYakinlik";
            this.repositoryYakinlik.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryAdres
            // 
            this.repositoryAdres.AutoHeight = false;
            this.repositoryAdres.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryAdres.Name = "repositoryAdres";
            // 
            // repositoryVeli
            // 
            this.repositoryVeli.AutoHeight = false;
            this.repositoryVeli.Name = "repositoryVeli";
            // 
            // IletisimBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "IletisimBilgileriTable";
            this.Size = new System.Drawing.Size(725, 219);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryYakinlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryVeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colVeli;
        private Grid.MyGridColumn colFaturaAdresi;
        private Grid.MyGridColumn colYakinlikId;
        private Grid.MyGridColumn colYakinlikAdi;
        private Grid.MyGridColumn colTcKimlikNo;
        private Grid.MyGridColumn colAdi;
        private Grid.MyGridColumn colSoyadi;
        private Grid.MyGridColumn colEvTel;
        private Grid.MyGridColumn colIsTel1;
        private Grid.MyGridColumn colCepTel1;
        private Grid.MyGridColumn colEvAdres;
        private Grid.MyGridColumn colEvAdresIlAdi;
        private Grid.MyGridColumn colEvAdresIlceAdi;
        private Grid.MyGridColumn colIsAdres;
        private Grid.MyGridColumn colIsAdresIlAdi;
        private Grid.MyGridColumn colIsAdreIlceAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryVeli;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryAdres;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryYakinlik;
        private Grid.MyGridColumn colMeslekAdi;
        private Grid.MyGridColumn colIsYeriAdi;
        private Grid.MyGridColumn colGorevAdi;
    }
}

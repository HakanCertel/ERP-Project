﻿namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    partial class DonemParametreEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyDataLayoutControl();
            this.propertyGridControl = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.repositoryItemCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.category = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.DonemTarihleri = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.DonemBitisTarihi = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.DonemBaslamaTarihi = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.EgitimTarihleri = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.EgitimBaslamaTarihi = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.EgitimBitisTarihi = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.category1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.GünTarihininOncesineHizmetBaslamaTarihiGirilebilir = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.GünTarihininOncesineMakbuzTarihiGirilebilir = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.GünTarihininOncesineIptalTarihiGirilebilir = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.category2 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.GünTarihininSonrasinaIptalTarihiGirilebilir = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.GünTarihininSonrasinaMakbuzTarihiGirilebilir = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.category3 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.HizmetTahakkukKurusKullan = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.IndirimTahakkukKurusKullan = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.OdemePlaniKurusKullan = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.FaturaTahakkukKurusKullan = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.category4 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.MaksimumTaksitTarihi = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MaksimumTaksitSayisi = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.GittigiOkulZorunlu = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.YetkiKontroluAnlikYapilacak = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.txtSube = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(446, 56);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.propertyGridControl);
            this.myDataLayoutControl.Controls.Add(this.txtSube);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 56);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup1;
            this.myDataLayoutControl.Size = new System.Drawing.Size(446, 435);
            this.myDataLayoutControl.TabIndex = 1;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // propertyGridControl
            // 
            this.propertyGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGridControl.Enabled = false;
            this.propertyGridControl.Location = new System.Drawing.Point(12, 36);
            this.propertyGridControl.Name = "propertyGridControl";
            this.propertyGridControl.OptionsBehavior.PropertySort = DevExpress.XtraVerticalGrid.PropertySort.NoSort;
            this.propertyGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheck,
            this.repositoryItemTarih,
            this.repositoryItemSpinEdit});
            this.propertyGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.category,
            this.category1,
            this.category2,
            this.category3,
            this.category4});
            this.propertyGridControl.Size = new System.Drawing.Size(422, 387);
            this.propertyGridControl.TabIndex = 5;
            this.propertyGridControl.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView;
            // 
            // repositoryItemCheck
            // 
            this.repositoryItemCheck.AutoHeight = false;
            this.repositoryItemCheck.Name = "repositoryItemCheck";
            // 
            // repositoryItemTarih
            // 
            this.repositoryItemTarih.AutoHeight = false;
            this.repositoryItemTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemTarih.Name = "repositoryItemTarih";
            // 
            // repositoryItemSpinEdit
            // 
            this.repositoryItemSpinEdit.AutoHeight = false;
            this.repositoryItemSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit.DisplayFormat.FormatString = "{0:d0}";
            this.repositoryItemSpinEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit.EditFormat.FormatString = "{0:d0}";
            this.repositoryItemSpinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit.Mask.EditMask = "d";
            this.repositoryItemSpinEdit.MaxValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.repositoryItemSpinEdit.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSpinEdit.Name = "repositoryItemSpinEdit";
            // 
            // category
            // 
            this.category.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.DonemTarihleri,
            this.EgitimTarihleri});
            this.category.Name = "category";
            this.category.Properties.Caption = "Dönem Tarihleri";
            // 
            // DonemTarihleri
            // 
            this.DonemTarihleri.Name = "DonemTarihleri";
            this.DonemTarihleri.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.DonemBitisTarihi,
            this.DonemBaslamaTarihi});
            // 
            // DonemBitisTarihi
            // 
            this.DonemBitisTarihi.FieldName = "DonemBitisTarihi";
            this.DonemBitisTarihi.RowEdit = this.repositoryItemTarih;
            // 
            // DonemBaslamaTarihi
            // 
            this.DonemBaslamaTarihi.Caption = "Dönem Başlama - Bitiş Tarihleri";
            this.DonemBaslamaTarihi.FieldName = "DonemBaslamaTarihi";
            this.DonemBaslamaTarihi.RowEdit = this.repositoryItemTarih;
            // 
            // EgitimTarihleri
            // 
            this.EgitimTarihleri.Name = "EgitimTarihleri";
            this.EgitimTarihleri.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.EgitimBaslamaTarihi,
            this.EgitimBitisTarihi});
            // 
            // EgitimBaslamaTarihi
            // 
            this.EgitimBaslamaTarihi.Caption = "Eğitim Başlama - Bitiş Tarihleri";
            this.EgitimBaslamaTarihi.FieldName = "EgitimBaslamaTarihi";
            // 
            // EgitimBitisTarihi
            // 
            this.EgitimBitisTarihi.FieldName = "EgitimBitisTarihi";
            // 
            // category1
            // 
            this.category1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.GünTarihininOncesineHizmetBaslamaTarihiGirilebilir,
            this.GünTarihininOncesineMakbuzTarihiGirilebilir,
            this.GünTarihininOncesineIptalTarihiGirilebilir});
            this.category1.Name = "category1";
            this.category1.Properties.Caption = "Günün Tarihinden Öncesine Girilebilir";
            // 
            // GünTarihininOncesineHizmetBaslamaTarihiGirilebilir
            // 
            this.GünTarihininOncesineHizmetBaslamaTarihiGirilebilir.Name = "GünTarihininOncesineHizmetBaslamaTarihiGirilebilir";
            this.GünTarihininOncesineHizmetBaslamaTarihiGirilebilir.Properties.Caption = "Hizmet Başlama Tarihi";
            this.GünTarihininOncesineHizmetBaslamaTarihiGirilebilir.Properties.FieldName = "GünTarihininOncesineHizmetBaslamaTarihiGirilebilir";
            this.GünTarihininOncesineHizmetBaslamaTarihiGirilebilir.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // GünTarihininOncesineMakbuzTarihiGirilebilir
            // 
            this.GünTarihininOncesineMakbuzTarihiGirilebilir.Name = "GünTarihininOncesineMakbuzTarihiGirilebilir";
            this.GünTarihininOncesineMakbuzTarihiGirilebilir.Properties.Caption = "Makbuz Tarihi";
            this.GünTarihininOncesineMakbuzTarihiGirilebilir.Properties.FieldName = "GünTarihininOncesineMakbuzTarihiGirilebilir";
            this.GünTarihininOncesineMakbuzTarihiGirilebilir.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // GünTarihininOncesineIptalTarihiGirilebilir
            // 
            this.GünTarihininOncesineIptalTarihiGirilebilir.Name = "GünTarihininOncesineIptalTarihiGirilebilir";
            this.GünTarihininOncesineIptalTarihiGirilebilir.Properties.Caption = "İptal Tarihi";
            this.GünTarihininOncesineIptalTarihiGirilebilir.Properties.FieldName = "GünTarihininOncesineIptalTarihiGirilebilir";
            this.GünTarihininOncesineIptalTarihiGirilebilir.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // category2
            // 
            this.category2.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir,
            this.GünTarihininSonrasinaIptalTarihiGirilebilir,
            this.GünTarihininSonrasinaMakbuzTarihiGirilebilir});
            this.category2.Name = "category2";
            this.category2.Properties.Caption = "Günün Tarihinden Sonrasına Girilebilir";
            // 
            // GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir
            // 
            this.GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir.Name = "GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir";
            this.GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir.Properties.Caption = "Hizmet Başlama Tarihi";
            this.GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir.Properties.FieldName = "GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir";
            this.GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // GünTarihininSonrasinaIptalTarihiGirilebilir
            // 
            this.GünTarihininSonrasinaIptalTarihiGirilebilir.Name = "GünTarihininSonrasinaIptalTarihiGirilebilir";
            this.GünTarihininSonrasinaIptalTarihiGirilebilir.Properties.Caption = "İptal Tarihi";
            this.GünTarihininSonrasinaIptalTarihiGirilebilir.Properties.FieldName = "GünTarihininSonrasinaIptalTarihiGirilebilir";
            this.GünTarihininSonrasinaIptalTarihiGirilebilir.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // GünTarihininSonrasinaMakbuzTarihiGirilebilir
            // 
            this.GünTarihininSonrasinaMakbuzTarihiGirilebilir.Name = "GünTarihininSonrasinaMakbuzTarihiGirilebilir";
            this.GünTarihininSonrasinaMakbuzTarihiGirilebilir.Properties.Caption = "Makbuz Tarihi";
            this.GünTarihininSonrasinaMakbuzTarihiGirilebilir.Properties.FieldName = "GünTarihininSonrasinaMakbuzTarihiGirilebilir";
            this.GünTarihininSonrasinaMakbuzTarihiGirilebilir.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // category3
            // 
            this.category3.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.HizmetTahakkukKurusKullan,
            this.IndirimTahakkukKurusKullan,
            this.OdemePlaniKurusKullan,
            this.FaturaTahakkukKurusKullan});
            this.category3.Name = "category3";
            this.category3.Properties.Caption = "Kuruş Kullan";
            // 
            // HizmetTahakkukKurusKullan
            // 
            this.HizmetTahakkukKurusKullan.Name = "HizmetTahakkukKurusKullan";
            this.HizmetTahakkukKurusKullan.Properties.Caption = "Hizmet Bilgileri";
            this.HizmetTahakkukKurusKullan.Properties.FieldName = "HizmetTahakkukKurusKullan";
            this.HizmetTahakkukKurusKullan.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // IndirimTahakkukKurusKullan
            // 
            this.IndirimTahakkukKurusKullan.Name = "IndirimTahakkukKurusKullan";
            this.IndirimTahakkukKurusKullan.Properties.Caption = "İndirim Bilgileri";
            this.IndirimTahakkukKurusKullan.Properties.FieldName = "IndirimTahakkukKurusKullan";
            this.IndirimTahakkukKurusKullan.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // OdemePlaniKurusKullan
            // 
            this.OdemePlaniKurusKullan.Name = "OdemePlaniKurusKullan";
            this.OdemePlaniKurusKullan.Properties.Caption = "Ödeme Bilgileri";
            this.OdemePlaniKurusKullan.Properties.FieldName = "OdemePlaniKurusKullan";
            this.OdemePlaniKurusKullan.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // FaturaTahakkukKurusKullan
            // 
            this.FaturaTahakkukKurusKullan.Name = "FaturaTahakkukKurusKullan";
            this.FaturaTahakkukKurusKullan.Properties.Caption = "Fatura Bilgileri";
            this.FaturaTahakkukKurusKullan.Properties.FieldName = "FaturaTahakkukKurusKullan";
            this.FaturaTahakkukKurusKullan.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // category4
            // 
            this.category4.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.MaksimumTaksitTarihi,
            this.MaksimumTaksitSayisi,
            this.GittigiOkulZorunlu,
            this.YetkiKontroluAnlikYapilacak});
            this.category4.Name = "category4";
            this.category4.Properties.Caption = "Diğer Parametreler";
            // 
            // MaksimumTaksitTarihi
            // 
            this.MaksimumTaksitTarihi.Appearance.Options.UseTextOptions = true;
            this.MaksimumTaksitTarihi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaksimumTaksitTarihi.Name = "MaksimumTaksitTarihi";
            this.MaksimumTaksitTarihi.Properties.Caption = "Maksimum Taksit Tarihi";
            this.MaksimumTaksitTarihi.Properties.FieldName = "MaksimumTaksitTarihi";
            this.MaksimumTaksitTarihi.Properties.RowEdit = this.repositoryItemTarih;
            // 
            // MaksimumTaksitSayisi
            // 
            this.MaksimumTaksitSayisi.Appearance.Options.UseTextOptions = true;
            this.MaksimumTaksitSayisi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaksimumTaksitSayisi.Name = "MaksimumTaksitSayisi";
            this.MaksimumTaksitSayisi.Properties.Caption = "Maksimum Taksit Sayısı";
            this.MaksimumTaksitSayisi.Properties.FieldName = "MaksimumTaksitSayisi";
            this.MaksimumTaksitSayisi.Properties.RowEdit = this.repositoryItemSpinEdit;
            // 
            // GittigiOkulZorunlu
            // 
            this.GittigiOkulZorunlu.Name = "GittigiOkulZorunlu";
            this.GittigiOkulZorunlu.Properties.Caption = "Gittiği Okulun Seçilmesi Zorunlu";
            this.GittigiOkulZorunlu.Properties.FieldName = "GittigiOkulZorunlu";
            this.GittigiOkulZorunlu.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // YetkiKontroluAnlikYapilacak
            // 
            this.YetkiKontroluAnlikYapilacak.Name = "YetkiKontroluAnlikYapilacak";
            this.YetkiKontroluAnlikYapilacak.Properties.Caption = "Kullanıcı Yetki Kontrolü Anlık Yapılsın";
            this.YetkiKontroluAnlikYapilacak.Properties.FieldName = "YetkiKontroluAnlikYapilacak";
            this.YetkiKontroluAnlikYapilacak.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // txtSube
            // 
            this.txtSube.EditValue = "Lütfen Bir Şube Seçiniz ...";
            this.txtSube.EnterMoveNextControl = true;
            this.txtSube.Id = null;
            this.txtSube.Location = new System.Drawing.Point(39, 12);
            this.txtSube.MenuManager = this.ribbonControl;
            this.txtSube.Name = "txtSube";
            this.txtSube.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSube.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSube.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtSube.Properties.NullText = "Lütfen Bir Şube Seçiniz...";
            this.txtSube.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtSube.Size = new System.Drawing.Size(395, 20);
            this.txtSube.StatusBarAciklama = null;
            this.txtSube.StatusBarKisaYol = "F4 :";
            this.txtSube.StatusBarKisaYolAciklama = null;
            this.txtSube.StyleController = this.myDataLayoutControl;
            this.txtSube.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 100D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 100D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(446, 435);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtSube;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(426, 24);
            this.layoutControlItem1.Text = "Şube";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(24, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.propertyGridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(426, 391);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // DonemParametreEditForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 491);
            this.Controls.Add(this.myDataLayoutControl);
            this.Name = "DonemParametreEditForm";
            this.Text = "Donem Parametreleri";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Forms.UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow DonemTarihleri;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties DonemBitisTarihi;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties DonemBaslamaTarihi;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow EgitimTarihleri;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties EgitimBaslamaTarihi;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties EgitimBitisTarihi;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow GünTarihininOncesineHizmetBaslamaTarihiGirilebilir;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow GünTarihininOncesineMakbuzTarihiGirilebilir;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow GünTarihininOncesineIptalTarihiGirilebilir;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow GünTarihininSonrasinaIptalTarihiGirilebilir;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow GünTarihininSonrasinaMakbuzTarihiGirilebilir;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow HizmetTahakkukKurusKullan;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow IndirimTahakkukKurusKullan;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow OdemePlaniKurusKullan;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow FaturaTahakkukKurusKullan;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MaksimumTaksitTarihi;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MaksimumTaksitSayisi;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow GittigiOkulZorunlu;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow YetkiKontroluAnlikYapilacak;
        private Forms.UserControls.Controls.MyButtonEdit txtSube;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
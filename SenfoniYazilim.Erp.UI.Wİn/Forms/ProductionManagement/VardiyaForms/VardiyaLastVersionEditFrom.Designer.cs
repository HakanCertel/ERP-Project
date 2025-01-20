namespace SenfoniYazilim.Erp.UI.Wİn.Forms.VardiyaForms
{
    partial class VardiyaLastVersionEditFrom
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyDataLayoutControl();
            this.vardiyaBilgileriTable = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.GenelEditFormTable.VardiyaBilgileriTable();
            this.tglDurum = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyToogleSwitch();
            this.txtVardiyaSayisi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MySpinEdit();
            this.txtVardiyaSistemAd = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyTextEdit();
            this.txtVardiyaSistemKod = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyKodTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVardiyaSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVardiyaSistemAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVardiyaSistemKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.vardiyaBilgileriTable);
            this.myDataLayoutControl.Controls.Add(this.tglDurum);
            this.myDataLayoutControl.Controls.Add(this.txtVardiyaSayisi);
            this.myDataLayoutControl.Controls.Add(this.txtVardiyaSistemAd);
            this.myDataLayoutControl.Controls.Add(this.txtVardiyaSistemKod);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 56);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup1;
            this.myDataLayoutControl.Size = new System.Drawing.Size(848, 435);
            this.myDataLayoutControl.TabIndex = 1;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // vardiyaBilgileriTable
            // 
            this.vardiyaBilgileriTable.Location = new System.Drawing.Point(12, 36);
            this.vardiyaBilgileriTable.Name = "vardiyaBilgileriTable";
            this.vardiyaBilgileriTable.Size = new System.Drawing.Size(824, 387);
            this.vardiyaBilgileriTable.TabIndex = 5;
            // 
            // tglDurum
            // 
            this.tglDurum.EnterMoveNextControl = true;
            this.tglDurum.Location = new System.Drawing.Point(741, 12);
            this.tglDurum.MenuManager = this.ribbonControl;
            this.tglDurum.Name = "tglDurum";
            this.tglDurum.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tglDurum.Properties.Appearance.Options.UseForeColor = true;
            this.tglDurum.Properties.AutoHeight = false;
            this.tglDurum.Properties.AutoWidth = true;
            this.tglDurum.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglDurum.Properties.OffText = "Pasif";
            this.tglDurum.Properties.OnText = "Aktif";
            this.tglDurum.Size = new System.Drawing.Size(97, 20);
            this.tglDurum.StatusBarAciklama = "Kartın Kullanım Durumunu Seçiniz.";
            this.tglDurum.StyleController = this.myDataLayoutControl;
            this.tglDurum.TabIndex = 4;
            // 
            // txtVardiyaSayisi
            // 
            this.txtVardiyaSayisi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtVardiyaSayisi.EnterMoveNextControl = true;
            this.txtVardiyaSayisi.Location = new System.Drawing.Point(706, 12);
            this.txtVardiyaSayisi.MenuManager = this.ribbonControl;
            this.txtVardiyaSayisi.Name = "txtVardiyaSayisi";
            this.txtVardiyaSayisi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtVardiyaSayisi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtVardiyaSayisi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtVardiyaSayisi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVardiyaSayisi.Properties.Mask.EditMask = "d";
            this.txtVardiyaSayisi.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtVardiyaSayisi.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtVardiyaSayisi.Size = new System.Drawing.Size(31, 20);
            this.txtVardiyaSayisi.StatusBarAciklama = null;
            this.txtVardiyaSayisi.StyleController = this.myDataLayoutControl;
            this.txtVardiyaSayisi.TabIndex = 2;
            // 
            // txtVardiyaSistemAd
            // 
            this.txtVardiyaSistemAd.EnterMoveNextControl = true;
            this.txtVardiyaSistemAd.Id = ((long)(0));
            this.txtVardiyaSistemAd.Location = new System.Drawing.Point(356, 12);
            this.txtVardiyaSistemAd.MenuManager = this.ribbonControl;
            this.txtVardiyaSistemAd.Name = "txtVardiyaSistemAd";
            this.txtVardiyaSistemAd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtVardiyaSistemAd.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtVardiyaSistemAd.Properties.MaxLength = 50;
            this.txtVardiyaSistemAd.Size = new System.Drawing.Size(261, 20);
            this.txtVardiyaSistemAd.StatusBarAciklama = null;
            this.txtVardiyaSistemAd.StyleController = this.myDataLayoutControl;
            this.txtVardiyaSistemAd.TabIndex = 1;
            // 
            // txtVardiyaSistemKod
            // 
            this.txtVardiyaSistemKod.EnterMoveNextControl = true;
            this.txtVardiyaSistemKod.Id = ((long)(0));
            this.txtVardiyaSistemKod.Location = new System.Drawing.Point(112, 12);
            this.txtVardiyaSistemKod.MenuManager = this.ribbonControl;
            this.txtVardiyaSistemKod.Name = "txtVardiyaSistemKod";
            this.txtVardiyaSistemKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtVardiyaSistemKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtVardiyaSistemKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtVardiyaSistemKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtVardiyaSistemKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtVardiyaSistemKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtVardiyaSistemKod.Properties.MaxLength = 20;
            this.txtVardiyaSistemKod.Size = new System.Drawing.Size(140, 20);
            this.txtVardiyaSistemKod.StatusBarAciklama = "Kod Giriniz.";
            this.txtVardiyaSistemKod.StyleController = this.myDataLayoutControl;
            this.txtVardiyaSistemKod.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 40D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 60D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 120D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 99D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 100D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(848, 435);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtVardiyaSistemKod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(244, 24);
            this.layoutControlItem1.Text = "Vardiya Sistem Kodu";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(97, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtVardiyaSistemAd;
            this.layoutControlItem2.Location = new System.Drawing.Point(244, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(365, 24);
            this.layoutControlItem2.Text = "Vardiya Sistem Adı";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(97, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtVardiyaSayisi;
            this.layoutControlItem3.Location = new System.Drawing.Point(609, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(120, 24);
            this.layoutControlItem3.Text = "Vardiya Sayısı";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(80, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.tglDurum;
            this.layoutControlItem4.Location = new System.Drawing.Point(729, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.vardiyaBilgileriTable;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnSpan = 4;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem5.Size = new System.Drawing.Size(828, 391);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // VardiyaLastVersionEditFrom
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 491);
            this.Controls.Add(this.myDataLayoutControl);
            this.Name = "VardiyaLastVersionEditFrom";
            this.Text = "Vardiya Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVardiyaSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVardiyaSistemAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVardiyaSistemKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private UserControls.Controls.MySpinEdit txtVardiyaSayisi;
        private UserControls.Controls.MyTextEdit txtVardiyaSistemAd;
        private UserControls.Controls.MyKodTextEdit txtVardiyaSistemKod;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private UserControls.Controls.MyToogleSwitch tglDurum;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private UserControls.UserControl.GenelEditFormTable.VardiyaBilgileriTable vardiyaBilgileriTable;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
﻿namespace SenfoniYazilim.Erp.UI.Wİn.Forms.KullaniciForms
{
    partial class SifreDegistirEditForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyDataLayoutControl();
            this.txtYeniSifreTekrar = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyTextEdit();
            this.txtGizliKelime = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyTextEdit();
            this.txtEskiSifre = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyTextEdit();
            this.txtYeniSifre = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifreTekrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGizliKelime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEskiSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(300, 56);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtYeniSifreTekrar);
            this.myDataLayoutControl.Controls.Add(this.txtGizliKelime);
            this.myDataLayoutControl.Controls.Add(this.txtEskiSifre);
            this.myDataLayoutControl.Controls.Add(this.txtYeniSifre);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 56);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup1;
            this.myDataLayoutControl.Size = new System.Drawing.Size(300, 164);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.EnterMoveNextControl = true;
            this.txtYeniSifreTekrar.Id = ((long)(0));
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(102, 60);
            this.txtYeniSifreTekrar.MenuManager = this.ribbonControl;
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtYeniSifreTekrar.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtYeniSifreTekrar.Properties.MaxLength = 50;
            this.txtYeniSifreTekrar.Properties.UseSystemPasswordChar = true;
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(186, 20);
            this.txtYeniSifreTekrar.StatusBarAciklama = null;
            this.txtYeniSifreTekrar.StyleController = this.myDataLayoutControl;
            this.txtYeniSifreTekrar.TabIndex = 2;
            // 
            // txtGizliKelime
            // 
            this.txtGizliKelime.EnterMoveNextControl = true;
            this.txtGizliKelime.Id = ((long)(0));
            this.txtGizliKelime.Location = new System.Drawing.Point(102, 84);
            this.txtGizliKelime.MenuManager = this.ribbonControl;
            this.txtGizliKelime.Name = "txtGizliKelime";
            this.txtGizliKelime.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtGizliKelime.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtGizliKelime.Properties.MaxLength = 50;
            this.txtGizliKelime.Size = new System.Drawing.Size(186, 20);
            this.txtGizliKelime.StatusBarAciklama = null;
            this.txtGizliKelime.StyleController = this.myDataLayoutControl;
            this.txtGizliKelime.TabIndex = 3;
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.EnterMoveNextControl = true;
            this.txtEskiSifre.Id = ((long)(0));
            this.txtEskiSifre.Location = new System.Drawing.Point(102, 12);
            this.txtEskiSifre.MenuManager = this.ribbonControl;
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtEskiSifre.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEskiSifre.Properties.MaxLength = 50;
            this.txtEskiSifre.Properties.UseSystemPasswordChar = true;
            this.txtEskiSifre.Size = new System.Drawing.Size(186, 20);
            this.txtEskiSifre.StatusBarAciklama = null;
            this.txtEskiSifre.StyleController = this.myDataLayoutControl;
            this.txtEskiSifre.TabIndex = 0;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.EnterMoveNextControl = true;
            this.txtYeniSifre.Id = ((long)(0));
            this.txtYeniSifre.Location = new System.Drawing.Point(102, 36);
            this.txtYeniSifre.MenuManager = this.ribbonControl;
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtYeniSifre.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtYeniSifre.Properties.MaxLength = 50;
            this.txtYeniSifre.Properties.UseSystemPasswordChar = true;
            this.txtYeniSifre.Size = new System.Drawing.Size(186, 20);
            this.txtYeniSifre.StatusBarAciklama = null;
            this.txtYeniSifre.StyleController = this.myDataLayoutControl;
            this.txtYeniSifre.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.layoutControlItem6});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 100D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4});
            this.layoutControlGroup1.Size = new System.Drawing.Size(300, 164);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtYeniSifre;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem3.Text = "Yeni Şifre";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtEskiSifre;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem5.Text = "Eski Şifre";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtYeniSifreTekrar;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem1.Text = "Yeni Şifre (Tekrar)";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtGizliKelime;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem6.Size = new System.Drawing.Size(280, 72);
            this.layoutControlItem6.Text = "Gizli Kelime";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(87, 13);
            // 
            // SifreDegistirEditForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.myDataLayoutControl);
            this.MinimumSize = new System.Drawing.Size(310, 225);
            this.Name = "SifreDegistirEditForm";
            this.Text = "Şifre Değiştir";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifreTekrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGizliKelime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEskiSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private UserControls.Controls.MyTextEdit txtYeniSifreTekrar;
        private UserControls.Controls.MyTextEdit txtGizliKelime;
        private UserControls.Controls.MyTextEdit txtEskiSifre;
        private UserControls.Controls.MyTextEdit txtYeniSifre;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
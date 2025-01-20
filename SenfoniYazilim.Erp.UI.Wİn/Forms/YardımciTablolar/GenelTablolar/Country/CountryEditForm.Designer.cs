namespace SenfoniYazilim.Erp.UI.Wİn.Forms.IlForms
{
    partial class CountryEditForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyDataLayoutControl();
            this.tglState = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyToogleSwitch();
            this.txtDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyMemoEdit();
            this.txtCountryName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyTextEdit();
            this.txtCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyKodTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblCountryName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCountryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(390, 56);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.tglState);
            this.myDataLayoutControl.Controls.Add(this.txtDescription);
            this.myDataLayoutControl.Controls.Add(this.txtCountryName);
            this.myDataLayoutControl.Controls.Add(this.txtCode);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 56);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup1;
            this.myDataLayoutControl.Size = new System.Drawing.Size(390, 239);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // tglState
            // 
            this.tglState.EnterMoveNextControl = true;
            this.tglState.Location = new System.Drawing.Point(283, 12);
            this.tglState.MenuManager = this.ribbonControl;
            this.tglState.Name = "tglState";
            this.tglState.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tglState.Properties.Appearance.Options.UseForeColor = true;
            this.tglState.Properties.AutoHeight = false;
            this.tglState.Properties.AutoWidth = true;
            this.tglState.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglState.Properties.OffText = "Pasif";
            this.tglState.Properties.OnText = "Aktif";
            this.tglState.Size = new System.Drawing.Size(97, 20);
            this.tglState.StatusBarAciklama = "Kartın Kullanım Durumunu Seçiniz.";
            this.tglState.StyleController = this.myDataLayoutControl;
            this.tglState.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(56, 60);
            this.txtDescription.MenuManager = this.ribbonControl;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDescription.Properties.MaxLength = 500;
            this.txtDescription.Size = new System.Drawing.Size(322, 167);
            this.txtDescription.StatusBarAciklama = "Açıklama Giriniz.";
            this.txtDescription.StyleController = this.myDataLayoutControl;
            this.txtDescription.TabIndex = 1;
            // 
            // txtCountryName
            // 
            this.txtCountryName.EnterMoveNextControl = true;
            this.txtCountryName.Id = ((long)(0));
            this.txtCountryName.Location = new System.Drawing.Point(56, 36);
            this.txtCountryName.MenuManager = this.ribbonControl;
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCountryName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCountryName.Properties.MaxLength = 50;
            this.txtCountryName.Size = new System.Drawing.Size(152, 20);
            this.txtCountryName.StatusBarAciklama = "İl Adı Giriniz.";
            this.txtCountryName.StyleController = this.myDataLayoutControl;
            this.txtCountryName.TabIndex = 0;
            // 
            // txtCode
            // 
            this.txtCode.EditValue = "";
            this.txtCode.EnterMoveNextControl = true;
            this.txtCode.Id = ((long)(0));
            this.txtCode.Location = new System.Drawing.Point(56, 12);
            this.txtCode.MenuManager = this.ribbonControl;
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCode.Properties.MaxLength = 20;
            this.txtCode.Size = new System.Drawing.Size(152, 20);
            this.txtCode.StatusBarAciklama = "Kod Giriniz.";
            this.txtCode.StyleController = this.myDataLayoutControl;
            this.txtCode.TabIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblCode,
            this.lblCountryName,
            this.lblDescription,
            this.layoutControlItem4});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 99D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 100D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.layoutControlGroup1.Size = new System.Drawing.Size(390, 239);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lblCode
            // 
            this.lblCode.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lblCode.AppearanceItemCaption.Options.UseForeColor = true;
            this.lblCode.Control = this.txtCode;
            this.lblCode.Location = new System.Drawing.Point(0, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(200, 24);
            this.lblCode.Text = "Kod";
            this.lblCode.TextSize = new System.Drawing.Size(41, 13);
            // 
            // lblCountryName
            // 
            this.lblCountryName.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lblCountryName.AppearanceItemCaption.Options.UseForeColor = true;
            this.lblCountryName.Control = this.txtCountryName;
            this.lblCountryName.Location = new System.Drawing.Point(0, 24);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.OptionsTableLayoutItem.RowIndex = 1;
            this.lblCountryName.Size = new System.Drawing.Size(200, 24);
            this.lblCountryName.Text = "Ülke Adı";
            this.lblCountryName.TextSize = new System.Drawing.Size(41, 13);
            // 
            // lblDescription
            // 
            this.lblDescription.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lblDescription.AppearanceItemCaption.Options.UseForeColor = true;
            this.lblDescription.Control = this.txtDescription;
            this.lblDescription.Location = new System.Drawing.Point(0, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.OptionsTableLayoutItem.ColumnSpan = 3;
            this.lblDescription.OptionsTableLayoutItem.RowIndex = 2;
            this.lblDescription.Size = new System.Drawing.Size(370, 171);
            this.lblDescription.Text = "Açıklama";
            this.lblDescription.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.tglState;
            this.layoutControlItem4.Location = new System.Drawing.Point(271, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // CountryEditForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 295);
            this.Controls.Add(this.myDataLayoutControl);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "CountryEditForm";
            this.Text = "Ülke Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCountryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private UserControls.Controls.MyToogleSwitch tglState;
        private UserControls.Controls.MyMemoEdit txtDescription;
        private UserControls.Controls.MyTextEdit txtCountryName;
        private UserControls.Controls.MyKodTextEdit txtCode;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lblCode;
        private DevExpress.XtraLayout.LayoutControlItem lblCountryName;
        private DevExpress.XtraLayout.LayoutControlItem lblDescription;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.PaymentMethodForms
{
    partial class PaymentMethodEditForm
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
            this.myDataLayoutControl = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyDataLayoutControl();
            this.txtLanguage = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyLookUpEdit();
            this.txtSerial = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyTextEdit();
            this.paymentMethodEditFormTable = new SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.PaymentMethodForms.PaymentMethodEditFormTable();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblSerial = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblLanguage = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLanguage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSerial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtLanguage);
            this.myDataLayoutControl.Controls.Add(this.txtSerial);
            this.myDataLayoutControl.Controls.Add(this.paymentMethodEditFormTable);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 56);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup1;
            this.myDataLayoutControl.Size = new System.Drawing.Size(848, 435);
            this.myDataLayoutControl.TabIndex = 1;
            this.myDataLayoutControl.Text = "myDataLayoutControl";
            // 
            // txtLanguage
            // 
            this.txtLanguage.EnterMoveNextControl = true;
            this.txtLanguage.Location = new System.Drawing.Point(67, 12);
            this.txtLanguage.MenuManager = this.ribbonControl;
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtLanguage.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtLanguage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLanguage.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LanguageCode", "Kod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LanguageDescription", 40, "Dil")});
            this.txtLanguage.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch;
            this.txtLanguage.Properties.NullText = "All";
            this.txtLanguage.Properties.ShowFooter = false;
            this.txtLanguage.Size = new System.Drawing.Size(141, 20);
            this.txtLanguage.StatusBarAciklama = null;
            this.txtLanguage.StatusBarKisaYol = "F4 :";
            this.txtLanguage.StatusBarKisaYolAciklama = "Seçim Yap";
            this.txtLanguage.StyleController = this.myDataLayoutControl;
            this.txtLanguage.TabIndex = 7;
            // 
            // txtSerial
            // 
            this.txtSerial.EnterMoveNextControl = true;
            this.txtSerial.Id = ((long)(0));
            this.txtSerial.Location = new System.Drawing.Point(267, 12);
            this.txtSerial.MenuManager = this.ribbonControl;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSerial.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSerial.Properties.MaxLength = 50;
            this.txtSerial.Size = new System.Drawing.Size(191, 20);
            this.txtSerial.StatusBarAciklama = null;
            this.txtSerial.StyleController = this.myDataLayoutControl;
            this.txtSerial.TabIndex = 6;
            // 
            // paymentMethodEditFormTable
            // 
            this.paymentMethodEditFormTable.Location = new System.Drawing.Point(12, 36);
            this.paymentMethodEditFormTable.Name = "paymentMethodEditFormTable";
            this.paymentMethodEditFormTable.Size = new System.Drawing.Size(824, 387);
            this.paymentMethodEditFormTable.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lblSerial,
            this.lblLanguage});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 250D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 99D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
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
            this.layoutControlItem1.Control = this.paymentMethodEditFormTable;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem1.Size = new System.Drawing.Size(828, 391);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lblSerial
            // 
            this.lblSerial.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lblSerial.AppearanceItemCaption.Options.UseForeColor = true;
            this.lblSerial.Control = this.txtSerial;
            this.lblSerial.Location = new System.Drawing.Point(200, 0);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lblSerial.Size = new System.Drawing.Size(250, 24);
            this.lblSerial.Text = "Seri";
            this.lblSerial.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lblSerial.TextSize = new System.Drawing.Size(50, 20);
            this.lblSerial.TextToControlDistance = 5;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lblLanguage.AppearanceItemCaption.Options.UseForeColor = true;
            this.lblLanguage.Control = this.txtLanguage;
            this.lblLanguage.Location = new System.Drawing.Point(0, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(200, 24);
            this.lblLanguage.Text = "Dil";
            this.lblLanguage.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lblLanguage.TextSize = new System.Drawing.Size(50, 20);
            this.lblLanguage.TextToControlDistance = 5;
            // 
            // PaymentMethodEditForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 491);
            this.Controls.Add(this.myDataLayoutControl);
            this.Name = "PaymentMethodEditForm";
            this.Text = "PaymentMethodEditForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtLanguage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSerial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private PaymentMethodEditFormTable paymentMethodEditFormTable;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        protected internal UserControls.Controls.MyTextEdit txtSerial;
        private DevExpress.XtraLayout.LayoutControlItem lblSerial;
        private DevExpress.XtraLayout.LayoutControlItem lblLanguage;
        protected internal UserControls.Controls.MyLookUpEdit txtLanguage;
    }
}
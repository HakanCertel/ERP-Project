namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.WarehouseSettingsForms
{
    partial class WarehouseSettingsForm
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.warehouseSettingsTable = new SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.WarehouseSettingsForms.WarehouseSettingsTable();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtWarehouseCode = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyButtonEdit();
            this.Depo = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtWarehouseName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyTextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(690, 56);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtWarehouseName);
            this.myDataLayoutControl.Controls.Add(this.txtWarehouseCode);
            this.myDataLayoutControl.Controls.Add(this.warehouseSettingsTable);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 56);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup1;
            this.myDataLayoutControl.Size = new System.Drawing.Size(690, 345);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.Depo,
            this.layoutControlItem1});
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(690, 345);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // warehouseSettingsTable
            // 
            this.warehouseSettingsTable.Location = new System.Drawing.Point(12, 60);
            this.warehouseSettingsTable.Name = "warehouseSettingsTable";
            this.warehouseSettingsTable.Size = new System.Drawing.Size(666, 273);
            this.warehouseSettingsTable.TabIndex = 4;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.warehouseSettingsTable;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem2.Size = new System.Drawing.Size(670, 277);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // txtWarehouseCode
            // 
            this.txtWarehouseCode.EnterMoveNextControl = true;
            this.txtWarehouseCode.Id = null;
            this.txtWarehouseCode.Location = new System.Drawing.Point(40, 12);
            this.txtWarehouseCode.MenuManager = this.ribbonControl;
            this.txtWarehouseCode.Name = "txtWarehouseCode";
            this.txtWarehouseCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtWarehouseCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtWarehouseCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtWarehouseCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtWarehouseCode.Size = new System.Drawing.Size(168, 20);
            this.txtWarehouseCode.StatusBarAciklama = null;
            this.txtWarehouseCode.StatusBarKisaYol = "F4 :";
            this.txtWarehouseCode.StatusBarKisaYolAciklama = null;
            this.txtWarehouseCode.StyleController = this.myDataLayoutControl;
            this.txtWarehouseCode.TabIndex = 5;
            // 
            // Depo
            // 
            this.Depo.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.Depo.AppearanceItemCaption.Options.UseForeColor = true;
            this.Depo.Control = this.txtWarehouseCode;
            this.Depo.Location = new System.Drawing.Point(0, 0);
            this.Depo.Name = "Depo";
            this.Depo.Size = new System.Drawing.Size(200, 24);
            this.Depo.TextSize = new System.Drawing.Size(25, 13);
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.EnterMoveNextControl = true;
            this.txtWarehouseName.Id = ((long)(0));
            this.txtWarehouseName.Location = new System.Drawing.Point(212, 12);
            this.txtWarehouseName.MenuManager = this.ribbonControl;
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtWarehouseName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtWarehouseName.Properties.MaxLength = 50;
            this.txtWarehouseName.Properties.ReadOnly = true;
            this.txtWarehouseName.Size = new System.Drawing.Size(367, 20);
            this.txtWarehouseName.StatusBarAciklama = null;
            this.txtWarehouseName.StyleController = this.myDataLayoutControl;
            this.txtWarehouseName.TabIndex = 6;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtWarehouseName;
            this.layoutControlItem1.Location = new System.Drawing.Point(200, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem1.Size = new System.Drawing.Size(371, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // WarehouseSettingsForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 401);
            this.Controls.Add(this.myDataLayoutControl);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "WarehouseSettingsForm";
            this.Text = "Ayarlar";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private WarehouseSettingsTable warehouseSettingsTable;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private UserControls.Controls.MyTextEdit txtWarehouseName;
        private UserControls.Controls.MyButtonEdit txtWarehouseCode;
        private DevExpress.XtraLayout.LayoutControlItem Depo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
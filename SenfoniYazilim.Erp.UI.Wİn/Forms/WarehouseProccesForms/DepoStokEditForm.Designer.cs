namespace SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms
{
    partial class DepoStokEditForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyDataLayoutControl();
            this.depoStokTable = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.DepoStokEditFormTable.DepoStokTable();
            this.txtDepoAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutDepoAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnCokluStokDuzelt = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepoAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDepoAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCokluStokDuzelt});
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.depoStokTable);
            this.myDataLayoutControl.Controls.Add(this.txtDepoAdi);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 56);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup1;
            this.myDataLayoutControl.Size = new System.Drawing.Size(848, 455);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // depoStokTable
            // 
            this.depoStokTable.Location = new System.Drawing.Point(12, 44);
            this.depoStokTable.Name = "depoStokTable";
            this.depoStokTable.Size = new System.Drawing.Size(824, 399);
            this.depoStokTable.TabIndex = 4;
            // 
            // txtDepoAdi
            // 
            this.txtDepoAdi.EnterMoveNextControl = true;
            this.txtDepoAdi.Id = null;
            this.txtDepoAdi.Location = new System.Drawing.Point(58, 12);
            this.txtDepoAdi.MenuManager = this.ribbonControl;
            this.txtDepoAdi.Name = "txtDepoAdi";
            this.txtDepoAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtDepoAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDepoAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDepoAdi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDepoAdi.Size = new System.Drawing.Size(110, 20);
            this.txtDepoAdi.StatusBarAciklama = null;
            this.txtDepoAdi.StatusBarKisaYol = "F4 :";
            this.txtDepoAdi.StatusBarKisaYolAciklama = null;
            this.txtDepoAdi.StyleController = this.myDataLayoutControl;
            this.txtDepoAdi.TabIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutDepoAdi,
            this.layoutControlItem1});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 160D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 180D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 100D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 8D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 100D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.layoutControlGroup1.Size = new System.Drawing.Size(848, 455);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutDepoAdi
            // 
            this.layoutDepoAdi.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutDepoAdi.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutDepoAdi.Control = this.txtDepoAdi;
            this.layoutDepoAdi.Location = new System.Drawing.Point(0, 0);
            this.layoutDepoAdi.Name = "layoutDepoAdi";
            this.layoutDepoAdi.Size = new System.Drawing.Size(160, 24);
            this.layoutDepoAdi.Text = "Depo Adı";
            this.layoutDepoAdi.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.depoStokTable;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 4;
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(828, 403);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnCokluStokDuzelt
            // 
            this.btnCokluStokDuzelt.Caption = "Çoklu Stok Düzelt";
            this.btnCokluStokDuzelt.Id = 20;
            this.btnCokluStokDuzelt.ImageOptions.Image = global::SenfoniYazilim.Erp.UI.Wİn.Properties.Resources.edit_16x16;
            this.btnCokluStokDuzelt.Name = "btnCokluStokDuzelt";
            // 
            // DepoStokEditForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 511);
            this.Controls.Add(this.myDataLayoutControl);
            this.Name = "DepoStokEditForm";
            this.Text = "Depo Stok Güncelleme Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDepoAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDepoAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        protected internal UserControls.Controls.MyButtonEdit txtDepoAdi;
        private DevExpress.XtraLayout.LayoutControlItem layoutDepoAdi;
        private UserControls.UserControl.DepoStokEditFormTable.DepoStokTable depoStokTable;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem btnCokluStokDuzelt;
    }
}
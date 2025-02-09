﻿namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    partial class SubeDonemSecimEditForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls.MyDataLayoutControl();
            this.donemNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.SmallNavigator();
            this.subeNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.SmallNavigator();
            this.donemGrid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.donemTablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colDonemId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDonemAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.subeGrid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.subeTablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.coSubelId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSubeAdi = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donemTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(681, 56);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.donemNavigator);
            this.myDataLayoutControl.Controls.Add(this.subeNavigator);
            this.myDataLayoutControl.Controls.Add(this.donemGrid);
            this.myDataLayoutControl.Controls.Add(this.subeGrid);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 56);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup1;
            this.myDataLayoutControl.Size = new System.Drawing.Size(681, 258);
            this.myDataLayoutControl.TabIndex = 1;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // donemNavigator
            // 
            this.donemNavigator.Location = new System.Drawing.Point(342, 224);
            this.donemNavigator.Name = "donemNavigator";
            this.donemNavigator.Size = new System.Drawing.Size(327, 22);
            this.donemNavigator.TabIndex = 7;
            // 
            // subeNavigator
            // 
            this.subeNavigator.Location = new System.Drawing.Point(12, 224);
            this.subeNavigator.Name = "subeNavigator";
            this.subeNavigator.Size = new System.Drawing.Size(326, 22);
            this.subeNavigator.TabIndex = 6;
            // 
            // donemGrid
            // 
            this.donemGrid.Location = new System.Drawing.Point(342, 12);
            this.donemGrid.MainView = this.donemTablo;
            this.donemGrid.MenuManager = this.ribbonControl;
            this.donemGrid.Name = "donemGrid";
            this.donemGrid.Size = new System.Drawing.Size(327, 208);
            this.donemGrid.TabIndex = 5;
            this.donemGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.donemTablo});
            // 
            // donemTablo
            // 
            this.donemTablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.donemTablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.donemTablo.Appearance.FooterPanel.Options.UseFont = true;
            this.donemTablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.donemTablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.donemTablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.donemTablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.donemTablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.donemTablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.donemTablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.donemTablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDonemId,
            this.colDonemAdi});
            this.donemTablo.GridControl = this.donemGrid;
            this.donemTablo.Name = "donemTablo";
            this.donemTablo.OptionsMenu.EnableColumnMenu = false;
            this.donemTablo.OptionsMenu.EnableFooterMenu = false;
            this.donemTablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.donemTablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.donemTablo.OptionsPrint.AutoWidth = false;
            this.donemTablo.OptionsPrint.PrintFooter = false;
            this.donemTablo.OptionsPrint.PrintGroupFooter = false;
            this.donemTablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.donemTablo.OptionsView.RowAutoHeight = true;
            this.donemTablo.OptionsView.ShowColumnHeaders = false;
            this.donemTablo.OptionsView.ShowGroupPanel = false;
            this.donemTablo.OptionsView.ShowViewCaption = true;
            this.donemTablo.StatusBarAciklama = null;
            this.donemTablo.StatusBarKisaYol = null;
            this.donemTablo.StatusBarKisaYolAciklama = null;
            this.donemTablo.ViewCaption = "Dönem Kartları";
            // 
            // colDonemId
            // 
            this.colDonemId.Caption = "Id";
            this.colDonemId.FieldName = "DonemId";
            this.colDonemId.Name = "colDonemId";
            this.colDonemId.OptionsColumn.AllowEdit = false;
            this.colDonemId.StatusBarAciklama = null;
            this.colDonemId.StatusBarKisaYol = null;
            this.colDonemId.StatusBarKisaYolAciklama = null;
            // 
            // colDonemAdi
            // 
            this.colDonemAdi.Caption = "Dönem Adı";
            this.colDonemAdi.FieldName = "DonemAdi";
            this.colDonemAdi.Name = "colDonemAdi";
            this.colDonemAdi.OptionsColumn.AllowEdit = false;
            this.colDonemAdi.StatusBarAciklama = null;
            this.colDonemAdi.StatusBarKisaYol = null;
            this.colDonemAdi.StatusBarKisaYolAciklama = null;
            this.colDonemAdi.Visible = true;
            this.colDonemAdi.VisibleIndex = 0;
            // 
            // subeGrid
            // 
            this.subeGrid.Location = new System.Drawing.Point(12, 12);
            this.subeGrid.MainView = this.subeTablo;
            this.subeGrid.MenuManager = this.ribbonControl;
            this.subeGrid.Name = "subeGrid";
            this.subeGrid.Size = new System.Drawing.Size(326, 208);
            this.subeGrid.TabIndex = 4;
            this.subeGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.subeTablo});
            // 
            // subeTablo
            // 
            this.subeTablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.subeTablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.subeTablo.Appearance.FooterPanel.Options.UseFont = true;
            this.subeTablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.subeTablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.subeTablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.subeTablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.subeTablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.subeTablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.subeTablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.subeTablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coSubelId,
            this.colSubeAdi});
            this.subeTablo.GridControl = this.subeGrid;
            this.subeTablo.Name = "subeTablo";
            this.subeTablo.OptionsMenu.EnableColumnMenu = false;
            this.subeTablo.OptionsMenu.EnableFooterMenu = false;
            this.subeTablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.subeTablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.subeTablo.OptionsPrint.AutoWidth = false;
            this.subeTablo.OptionsPrint.PrintFooter = false;
            this.subeTablo.OptionsPrint.PrintGroupFooter = false;
            this.subeTablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.subeTablo.OptionsView.RowAutoHeight = true;
            this.subeTablo.OptionsView.ShowColumnHeaders = false;
            this.subeTablo.OptionsView.ShowGroupPanel = false;
            this.subeTablo.OptionsView.ShowViewCaption = true;
            this.subeTablo.StatusBarAciklama = null;
            this.subeTablo.StatusBarKisaYol = null;
            this.subeTablo.StatusBarKisaYolAciklama = null;
            this.subeTablo.ViewCaption = "Şube Kartları";
            // 
            // coSubelId
            // 
            this.coSubelId.Caption = "Id";
            this.coSubelId.FieldName = "SubeId";
            this.coSubelId.Name = "coSubelId";
            this.coSubelId.OptionsColumn.AllowEdit = false;
            this.coSubelId.StatusBarAciklama = null;
            this.coSubelId.StatusBarKisaYol = null;
            this.coSubelId.StatusBarKisaYolAciklama = null;
            // 
            // colSubeAdi
            // 
            this.colSubeAdi.Caption = "Şube Adı";
            this.colSubeAdi.FieldName = "SubeAdi";
            this.colSubeAdi.Name = "colSubeAdi";
            this.colSubeAdi.OptionsColumn.AllowEdit = false;
            this.colSubeAdi.StatusBarAciklama = null;
            this.colSubeAdi.StatusBarKisaYol = null;
            this.colSubeAdi.StatusBarKisaYolAciklama = null;
            this.colSubeAdi.Visible = true;
            this.colSubeAdi.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 50D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 26D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(681, 258);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.subeGrid;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(330, 212);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.donemGrid;
            this.layoutControlItem2.Location = new System.Drawing.Point(330, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(331, 212);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.subeNavigator;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 212);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(330, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.donemNavigator;
            this.layoutControlItem4.Location = new System.Drawing.Point(330, 212);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem4.Size = new System.Drawing.Size(331, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // SubeDonemSecimEditForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 314);
            this.Controls.Add(this.myDataLayoutControl);
            this.Name = "SubeDonemSecimEditForm";
            this.Text = "Şube Ve Dönem Seçim";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donemTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Forms.UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Forms.UserControls.Navigators.SmallNavigator donemNavigator;
        private Forms.UserControls.Navigators.SmallNavigator subeNavigator;
        private Forms.UserControls.Grid.MyGridControl donemGrid;
        private Forms.UserControls.Grid.MyGridView donemTablo;
        private Forms.UserControls.Grid.MyGridColumn colDonemId;
        private Forms.UserControls.Grid.MyGridColumn colDonemAdi;
        private Forms.UserControls.Grid.MyGridControl subeGrid;
        private Forms.UserControls.Grid.MyGridView subeTablo;
        private Forms.UserControls.Grid.MyGridColumn coSubelId;
        private Forms.UserControls.Grid.MyGridColumn colSubeAdi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
﻿namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.SatinalmaSiparisForms
{
    partial class PurchaseOrderListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderListForm));
            this.longNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.LongNavigator();
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKod = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyNameOrdered = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDocumentDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDeliveryCompanyDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDeliveryDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPaymentMethodDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colVase = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colBankDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPurchaseOrderDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPurchaseOrderNote = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyContactName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyContactMobilePhone = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyContactEMail = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSatinalmaTalepKalemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // btnMakbuzYeni
            // 
            this.btnMakbuzYeni.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMakbuzYeni.ImageOptions.Image")));
            this.btnMakbuzYeni.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMakbuzYeni.ImageOptions.LargeImage")));
            // 
            // barSubItem3
            // 
            this.barSubItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem3.ImageOptions.Image")));
            // 
            // btnRaporYeni
            // 
            this.btnRaporYeni.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporYeni.ImageOptions.Image")));
            this.btnRaporYeni.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRaporYeni.ImageOptions.LargeImage")));
            // 
            // btnIceriVeriAktar
            // 
            this.btnIceriVeriAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIceriVeriAktar.ImageOptions.Image")));
            this.btnIceriVeriAktar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnIceriVeriAktar.ImageOptions.LargeImage")));
            // 
            // btnIndirimTalep
            // 
            this.btnIndirimTalep.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIndirimTalep.ImageOptions.Image")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 391);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1062, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1062, 289);
            this.grid.TabIndex = 3;
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
            this.colId,
            this.colKod,
            this.colCompanyNameOrdered,
            this.colDocumentDate,
            this.colDeliveryCompanyDescription,
            this.colDeliveryDate,
            this.colPaymentMethodDescription,
            this.colVase,
            this.colBankDescription,
            this.colPurchaseOrderDescription,
            this.colPurchaseOrderNote,
            this.colCompanyContactName,
            this.colCompanyContactMobilePhone,
            this.colCompanyContactEMail});
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
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Siparişler";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = null;
            this.colId.StatusBarKisaYolAciklama = null;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            // 
            // colCompanyNameOrdered
            // 
            this.colCompanyNameOrdered.Caption = "Firma Adı";
            this.colCompanyNameOrdered.FieldName = "CompanyNameOrdered";
            this.colCompanyNameOrdered.Name = "colCompanyNameOrdered";
            this.colCompanyNameOrdered.OptionsColumn.AllowEdit = false;
            this.colCompanyNameOrdered.StatusBarAciklama = null;
            this.colCompanyNameOrdered.StatusBarKisaYol = null;
            this.colCompanyNameOrdered.StatusBarKisaYolAciklama = null;
            this.colCompanyNameOrdered.Visible = true;
            this.colCompanyNameOrdered.VisibleIndex = 1;
            // 
            // colDocumentDate
            // 
            this.colDocumentDate.Caption = "Evrak Tarihi";
            this.colDocumentDate.FieldName = "DocumentDate";
            this.colDocumentDate.Name = "colDocumentDate";
            this.colDocumentDate.OptionsColumn.AllowEdit = false;
            this.colDocumentDate.StatusBarAciklama = null;
            this.colDocumentDate.StatusBarKisaYol = null;
            this.colDocumentDate.StatusBarKisaYolAciklama = null;
            this.colDocumentDate.Visible = true;
            this.colDocumentDate.VisibleIndex = 2;
            // 
            // colDeliveryCompanyDescription
            // 
            this.colDeliveryCompanyDescription.Caption = "Teslim Edilecek Firma";
            this.colDeliveryCompanyDescription.FieldName = "DeliveryCompanyDescription";
            this.colDeliveryCompanyDescription.Name = "colDeliveryCompanyDescription";
            this.colDeliveryCompanyDescription.OptionsColumn.AllowEdit = false;
            this.colDeliveryCompanyDescription.StatusBarAciklama = null;
            this.colDeliveryCompanyDescription.StatusBarKisaYol = null;
            this.colDeliveryCompanyDescription.StatusBarKisaYolAciklama = null;
            this.colDeliveryCompanyDescription.Visible = true;
            this.colDeliveryCompanyDescription.VisibleIndex = 3;
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.Caption = "Teslim Tarihi";
            this.colDeliveryDate.FieldName = "DeliveryDate";
            this.colDeliveryDate.Name = "colDeliveryDate";
            this.colDeliveryDate.OptionsColumn.AllowEdit = false;
            this.colDeliveryDate.StatusBarAciklama = null;
            this.colDeliveryDate.StatusBarKisaYol = null;
            this.colDeliveryDate.StatusBarKisaYolAciklama = null;
            this.colDeliveryDate.Visible = true;
            this.colDeliveryDate.VisibleIndex = 4;
            // 
            // colPaymentMethodDescription
            // 
            this.colPaymentMethodDescription.Caption = "Ödeme Şekli";
            this.colPaymentMethodDescription.FieldName = "PaymentMethodDescription";
            this.colPaymentMethodDescription.Name = "colPaymentMethodDescription";
            this.colPaymentMethodDescription.OptionsColumn.AllowEdit = false;
            this.colPaymentMethodDescription.StatusBarAciklama = null;
            this.colPaymentMethodDescription.StatusBarKisaYol = null;
            this.colPaymentMethodDescription.StatusBarKisaYolAciklama = null;
            this.colPaymentMethodDescription.Visible = true;
            this.colPaymentMethodDescription.VisibleIndex = 5;
            // 
            // colVase
            // 
            this.colVase.Caption = "Vade";
            this.colVase.FieldName = "Vase";
            this.colVase.Name = "colVase";
            this.colVase.OptionsColumn.AllowEdit = false;
            this.colVase.StatusBarAciklama = null;
            this.colVase.StatusBarKisaYol = null;
            this.colVase.StatusBarKisaYolAciklama = null;
            this.colVase.Visible = true;
            this.colVase.VisibleIndex = 6;
            // 
            // colBankDescription
            // 
            this.colBankDescription.Caption = "Banka";
            this.colBankDescription.FieldName = "BankDescription";
            this.colBankDescription.Name = "colBankDescription";
            this.colBankDescription.OptionsColumn.AllowEdit = false;
            this.colBankDescription.StatusBarAciklama = null;
            this.colBankDescription.StatusBarKisaYol = null;
            this.colBankDescription.StatusBarKisaYolAciklama = null;
            this.colBankDescription.Visible = true;
            this.colBankDescription.VisibleIndex = 7;
            // 
            // colPurchaseOrderDescription
            // 
            this.colPurchaseOrderDescription.Caption = "Açıklama";
            this.colPurchaseOrderDescription.FieldName = "PurchaseOrderDescription";
            this.colPurchaseOrderDescription.Name = "colPurchaseOrderDescription";
            this.colPurchaseOrderDescription.OptionsColumn.AllowEdit = false;
            this.colPurchaseOrderDescription.StatusBarAciklama = null;
            this.colPurchaseOrderDescription.StatusBarKisaYol = null;
            this.colPurchaseOrderDescription.StatusBarKisaYolAciklama = null;
            this.colPurchaseOrderDescription.Visible = true;
            this.colPurchaseOrderDescription.VisibleIndex = 8;
            // 
            // colPurchaseOrderNote
            // 
            this.colPurchaseOrderNote.Caption = "Not";
            this.colPurchaseOrderNote.FieldName = "PurchaseOrderNote";
            this.colPurchaseOrderNote.Name = "colPurchaseOrderNote";
            this.colPurchaseOrderNote.OptionsColumn.AllowEdit = false;
            this.colPurchaseOrderNote.StatusBarAciklama = null;
            this.colPurchaseOrderNote.StatusBarKisaYol = null;
            this.colPurchaseOrderNote.StatusBarKisaYolAciklama = null;
            this.colPurchaseOrderNote.Visible = true;
            this.colPurchaseOrderNote.VisibleIndex = 9;
            // 
            // colCompanyContactName
            // 
            this.colCompanyContactName.Caption = "Firma İlgilisi";
            this.colCompanyContactName.FieldName = "CompanyContactName";
            this.colCompanyContactName.Name = "colCompanyContactName";
            this.colCompanyContactName.OptionsColumn.AllowEdit = false;
            this.colCompanyContactName.StatusBarAciklama = null;
            this.colCompanyContactName.StatusBarKisaYol = null;
            this.colCompanyContactName.StatusBarKisaYolAciklama = null;
            this.colCompanyContactName.Visible = true;
            this.colCompanyContactName.VisibleIndex = 10;
            // 
            // colCompanyContactMobilePhone
            // 
            this.colCompanyContactMobilePhone.Caption = "Telefon Numarası";
            this.colCompanyContactMobilePhone.FieldName = "CompanyContactMobilePhone";
            this.colCompanyContactMobilePhone.Name = "colCompanyContactMobilePhone";
            this.colCompanyContactMobilePhone.OptionsColumn.AllowEdit = false;
            this.colCompanyContactMobilePhone.StatusBarAciklama = null;
            this.colCompanyContactMobilePhone.StatusBarKisaYol = null;
            this.colCompanyContactMobilePhone.StatusBarKisaYolAciklama = null;
            this.colCompanyContactMobilePhone.Visible = true;
            this.colCompanyContactMobilePhone.VisibleIndex = 11;
            // 
            // colCompanyContactEMail
            // 
            this.colCompanyContactEMail.Caption = "EMail";
            this.colCompanyContactEMail.FieldName = "CompanyContactEMail";
            this.colCompanyContactEMail.Name = "colCompanyContactEMail";
            this.colCompanyContactEMail.OptionsColumn.AllowEdit = false;
            this.colCompanyContactEMail.StatusBarAciklama = null;
            this.colCompanyContactEMail.StatusBarKisaYol = null;
            this.colCompanyContactEMail.StatusBarKisaYolAciklama = null;
            this.colCompanyContactEMail.Visible = true;
            this.colCompanyContactEMail.VisibleIndex = 12;
            // 
            // PurchaseOrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 446);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "PurchaseOrderListForm";
            this.Text = "Satınalma Sipariş Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSatinalmaTalepKalemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Grid.MyGridColumn colCompanyNameOrdered;
        private UserControls.Grid.MyGridColumn colDocumentDate;
        private UserControls.Grid.MyGridColumn colDeliveryCompanyDescription;
        private UserControls.Grid.MyGridColumn colDeliveryDate;
        private UserControls.Grid.MyGridColumn colPaymentMethodDescription;
        private UserControls.Grid.MyGridColumn colVase;
        private UserControls.Grid.MyGridColumn colBankDescription;
        private UserControls.Grid.MyGridColumn colPurchaseOrderDescription;
        private UserControls.Grid.MyGridColumn colPurchaseOrderNote;
        private UserControls.Grid.MyGridColumn colCompanyContactName;
        private UserControls.Grid.MyGridColumn colCompanyContactMobilePhone;
        private UserControls.Grid.MyGridColumn colCompanyContactEMail;
    }
}
namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SaleWayBillForms
{
    partial class PurchaseWayBillListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseWayBillListForm));
            this.longNavigator = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators.LongNavigator();
            this.grid = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridControl();
            this.tablo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridView();
            this.colId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colKod = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyNameOrdered = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDocumentDate = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCurrencyDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPurchaseWayBillDescription = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colPurchaseWayBillNote = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDeliveryCompanyContactName = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDeliveryCompanyContactMobilePhone = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDeliveryCompanyContactEMail = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSequenceNo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colSerialNo = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colCompanyId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
            this.colDeliveryCompanyId = new SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Grid.MyGridColumn();
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
            this.colCurrencyDescription,
            this.colPurchaseWayBillDescription,
            this.colPurchaseWayBillNote,
            this.colDeliveryCompanyContactName,
            this.colDeliveryCompanyContactMobilePhone,
            this.colDeliveryCompanyContactEMail,
            this.colSequenceNo,
            this.colSerialNo,
            this.colCompanyId,
            this.colDeliveryCompanyId});
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
            this.tablo.ViewCaption = "İrsaliye Listesi";
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
            this.colKod.Caption = "İrsaliye Numarası";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 106;
            // 
            // colCompanyNameOrdered
            // 
            this.colCompanyNameOrdered.Caption = "Firma";
            this.colCompanyNameOrdered.FieldName = "CompanyNameOrdered";
            this.colCompanyNameOrdered.Name = "colCompanyNameOrdered";
            this.colCompanyNameOrdered.OptionsColumn.AllowEdit = false;
            this.colCompanyNameOrdered.StatusBarAciklama = null;
            this.colCompanyNameOrdered.StatusBarKisaYol = null;
            this.colCompanyNameOrdered.StatusBarKisaYolAciklama = null;
            this.colCompanyNameOrdered.Visible = true;
            this.colCompanyNameOrdered.VisibleIndex = 3;
            this.colCompanyNameOrdered.Width = 297;
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
            this.colDocumentDate.VisibleIndex = 4;
            this.colDocumentDate.Width = 102;
            // 
            // colCurrencyDescription
            // 
            this.colCurrencyDescription.Caption = "Döviz Cinsi";
            this.colCurrencyDescription.FieldName = "CurrencyDescription";
            this.colCurrencyDescription.Name = "colCurrencyDescription";
            this.colCurrencyDescription.OptionsColumn.AllowEdit = false;
            this.colCurrencyDescription.StatusBarAciklama = null;
            this.colCurrencyDescription.StatusBarKisaYol = null;
            this.colCurrencyDescription.StatusBarKisaYolAciklama = null;
            this.colCurrencyDescription.Visible = true;
            this.colCurrencyDescription.VisibleIndex = 5;
            // 
            // colPurchaseWayBillDescription
            // 
            this.colPurchaseWayBillDescription.Caption = "Açıklama";
            this.colPurchaseWayBillDescription.FieldName = "PurchaseWayBillDescription";
            this.colPurchaseWayBillDescription.Name = "colPurchaseWayBillDescription";
            this.colPurchaseWayBillDescription.OptionsColumn.AllowEdit = false;
            this.colPurchaseWayBillDescription.StatusBarAciklama = null;
            this.colPurchaseWayBillDescription.StatusBarKisaYol = null;
            this.colPurchaseWayBillDescription.StatusBarKisaYolAciklama = null;
            this.colPurchaseWayBillDescription.Visible = true;
            this.colPurchaseWayBillDescription.VisibleIndex = 6;
            this.colPurchaseWayBillDescription.Width = 164;
            // 
            // colPurchaseWayBillNote
            // 
            this.colPurchaseWayBillNote.Caption = "Not";
            this.colPurchaseWayBillNote.FieldName = "PurchaseWayBillNote";
            this.colPurchaseWayBillNote.Name = "colPurchaseWayBillNote";
            this.colPurchaseWayBillNote.OptionsColumn.AllowEdit = false;
            this.colPurchaseWayBillNote.StatusBarAciklama = null;
            this.colPurchaseWayBillNote.StatusBarKisaYol = null;
            this.colPurchaseWayBillNote.StatusBarKisaYolAciklama = null;
            this.colPurchaseWayBillNote.Visible = true;
            this.colPurchaseWayBillNote.VisibleIndex = 7;
            this.colPurchaseWayBillNote.Width = 183;
            // 
            // colDeliveryCompanyContactName
            // 
            this.colDeliveryCompanyContactName.Caption = "İlgili Kişi";
            this.colDeliveryCompanyContactName.FieldName = "DeliveryCompanyContactName";
            this.colDeliveryCompanyContactName.Name = "colDeliveryCompanyContactName";
            this.colDeliveryCompanyContactName.OptionsColumn.AllowEdit = false;
            this.colDeliveryCompanyContactName.StatusBarAciklama = null;
            this.colDeliveryCompanyContactName.StatusBarKisaYol = null;
            this.colDeliveryCompanyContactName.StatusBarKisaYolAciklama = null;
            this.colDeliveryCompanyContactName.Visible = true;
            this.colDeliveryCompanyContactName.VisibleIndex = 8;
            // 
            // colDeliveryCompanyContactMobilePhone
            // 
            this.colDeliveryCompanyContactMobilePhone.Caption = "Telefon Numarası";
            this.colDeliveryCompanyContactMobilePhone.FieldName = "DeliveryCompanyContactMobilePhone";
            this.colDeliveryCompanyContactMobilePhone.Name = "colDeliveryCompanyContactMobilePhone";
            this.colDeliveryCompanyContactMobilePhone.OptionsColumn.AllowEdit = false;
            this.colDeliveryCompanyContactMobilePhone.StatusBarAciklama = null;
            this.colDeliveryCompanyContactMobilePhone.StatusBarKisaYol = null;
            this.colDeliveryCompanyContactMobilePhone.StatusBarKisaYolAciklama = null;
            this.colDeliveryCompanyContactMobilePhone.Visible = true;
            this.colDeliveryCompanyContactMobilePhone.VisibleIndex = 9;
            this.colDeliveryCompanyContactMobilePhone.Width = 107;
            // 
            // colDeliveryCompanyContactEMail
            // 
            this.colDeliveryCompanyContactEMail.Caption = "E-Mail";
            this.colDeliveryCompanyContactEMail.FieldName = "DeliveryCompanyContactEMail";
            this.colDeliveryCompanyContactEMail.Name = "colDeliveryCompanyContactEMail";
            this.colDeliveryCompanyContactEMail.OptionsColumn.AllowEdit = false;
            this.colDeliveryCompanyContactEMail.StatusBarAciklama = null;
            this.colDeliveryCompanyContactEMail.StatusBarKisaYol = null;
            this.colDeliveryCompanyContactEMail.StatusBarKisaYolAciklama = null;
            this.colDeliveryCompanyContactEMail.Visible = true;
            this.colDeliveryCompanyContactEMail.VisibleIndex = 10;
            // 
            // colSequenceNo
            // 
            this.colSequenceNo.Caption = "Sıra Numarası";
            this.colSequenceNo.FieldName = "SequenceNo";
            this.colSequenceNo.Name = "colSequenceNo";
            this.colSequenceNo.OptionsColumn.AllowEdit = false;
            this.colSequenceNo.StatusBarAciklama = null;
            this.colSequenceNo.StatusBarKisaYol = null;
            this.colSequenceNo.StatusBarKisaYolAciklama = null;
            this.colSequenceNo.Visible = true;
            this.colSequenceNo.VisibleIndex = 2;
            // 
            // colSerialNo
            // 
            this.colSerialNo.Caption = "Seri Numarası";
            this.colSerialNo.FieldName = "SerialNo";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.OptionsColumn.AllowEdit = false;
            this.colSerialNo.StatusBarAciklama = null;
            this.colSerialNo.StatusBarKisaYol = null;
            this.colSerialNo.StatusBarKisaYolAciklama = null;
            this.colSerialNo.Visible = true;
            this.colSerialNo.VisibleIndex = 1;
            // 
            // colCompanyId
            // 
            this.colCompanyId.Caption = "CompanyId";
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.OptionsColumn.AllowEdit = false;
            this.colCompanyId.StatusBarAciklama = null;
            this.colCompanyId.StatusBarKisaYol = null;
            this.colCompanyId.StatusBarKisaYolAciklama = null;
            this.colCompanyId.Visible = true;
            this.colCompanyId.VisibleIndex = 11;
            // 
            // colDeliveryCompanyId
            // 
            this.colDeliveryCompanyId.Caption = "DeliveryCompanyId";
            this.colDeliveryCompanyId.FieldName = "DeliveryCompanyId";
            this.colDeliveryCompanyId.Name = "colDeliveryCompanyId";
            this.colDeliveryCompanyId.OptionsColumn.AllowEdit = false;
            this.colDeliveryCompanyId.StatusBarAciklama = null;
            this.colDeliveryCompanyId.StatusBarKisaYol = null;
            this.colDeliveryCompanyId.StatusBarKisaYolAciklama = null;
            this.colDeliveryCompanyId.Visible = true;
            this.colDeliveryCompanyId.VisibleIndex = 12;
            // 
            // PurchaseWayBillListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 446);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "PurchaseWayBillListForm";
            this.Text = "Satınalma İrsaliye Listesi";
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
        private UserControls.Grid.MyGridColumn colCurrencyDescription;
        private UserControls.Grid.MyGridColumn colPurchaseWayBillDescription;
        private UserControls.Grid.MyGridColumn colPurchaseWayBillNote;
        private UserControls.Grid.MyGridColumn colDeliveryCompanyContactName;
        private UserControls.Grid.MyGridColumn colDeliveryCompanyContactMobilePhone;
        private UserControls.Grid.MyGridColumn colDeliveryCompanyContactEMail;
        private UserControls.Grid.MyGridColumn colSequenceNo;
        private UserControls.Grid.MyGridColumn colSerialNo;
        private UserControls.Grid.MyGridColumn colCompanyId;
        private UserControls.Grid.MyGridColumn colDeliveryCompanyId;
    }
}
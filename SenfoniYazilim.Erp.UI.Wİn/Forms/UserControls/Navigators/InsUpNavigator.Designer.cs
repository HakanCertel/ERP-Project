namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Navigators
{
    partial class InsUpNavigator
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsUpNavigator));
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.Navigator = new DevExpress.XtraEditors.ControlNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("first_16x16.png", "office2013/arrows/first_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/first_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "first_16x16.png");
            this.imageCollection.InsertGalleryImage("doubleprev_16x16.png", "office2013/arrows/doubleprev_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/doubleprev_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "doubleprev_16x16.png");
            this.imageCollection.InsertGalleryImage("prev_16x16.png", "office2013/arrows/prev_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/prev_16x16.png"), 2);
            this.imageCollection.Images.SetKeyName(2, "prev_16x16.png");
            this.imageCollection.InsertGalleryImage("next_16x16.png", "office2013/arrows/next_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/next_16x16.png"), 3);
            this.imageCollection.Images.SetKeyName(3, "next_16x16.png");
            this.imageCollection.InsertGalleryImage("doublenext_16x16.png", "office2013/arrows/doublenext_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/doublenext_16x16.png"), 4);
            this.imageCollection.Images.SetKeyName(4, "doublenext_16x16.png");
            this.imageCollection.InsertGalleryImage("last_16x16.png", "office2013/arrows/last_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/last_16x16.png"), 5);
            this.imageCollection.Images.SetKeyName(5, "last_16x16.png");
            this.imageCollection.InsertGalleryImage("addfile_16x16.png", "office2013/actions/addfile_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/addfile_16x16.png"), 6);
            this.imageCollection.Images.SetKeyName(6, "addfile_16x16.png");
            this.imageCollection.InsertGalleryImage("deletelist_16x16.png", "office2013/actions/deletelist_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/deletelist_16x16.png"), 7);
            this.imageCollection.Images.SetKeyName(7, "deletelist_16x16.png");
            // 
            // Navigator
            // 
            this.Navigator.Buttons.Append.ImageIndex = 6;
            this.Navigator.Buttons.CancelEdit.Visible = false;
            this.Navigator.Buttons.Edit.Visible = false;
            this.Navigator.Buttons.EndEdit.Visible = false;
            this.Navigator.Buttons.First.ImageIndex = 0;
            this.Navigator.Buttons.ImageList = this.imageCollection;
            this.Navigator.Buttons.Last.ImageIndex = 5;
            this.Navigator.Buttons.Next.ImageIndex = 3;
            this.Navigator.Buttons.NextPage.Visible = false;
            this.Navigator.Buttons.Prev.ImageIndex = 2;
            this.Navigator.Buttons.PrevPage.Visible = false;
            this.Navigator.Buttons.Remove.ImageIndex = 7;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Location = new System.Drawing.Point(0, 0);
            this.Navigator.Name = "Navigator";
            this.Navigator.ShowToolTips = true;
            this.Navigator.Size = new System.Drawing.Size(601, 24);
            this.Navigator.TabIndex = 1;
            this.Navigator.Text = "controlNavigator1";
            // 
            // InsUpNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Navigator);
            this.Name = "InsUpNavigator";
            this.Size = new System.Drawing.Size(601, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.ImageCollection imageCollection;
        protected internal DevExpress.XtraEditors.ControlNavigator Navigator;
    }
}

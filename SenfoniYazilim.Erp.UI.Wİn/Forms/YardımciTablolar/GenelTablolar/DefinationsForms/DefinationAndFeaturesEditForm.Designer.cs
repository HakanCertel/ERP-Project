namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.DefinationsForms
{
    partial class DefinationAndFeaturesEditForm
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
            this.definationAndFeatureEditTable = new SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.DefinationsForms.DefinationAndFeatureEditTable();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(313, 56);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // definationAndFeatureEditTable
            // 
            this.definationAndFeatureEditTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.definationAndFeatureEditTable.Location = new System.Drawing.Point(0, 56);
            this.definationAndFeatureEditTable.Name = "definationAndFeatureEditTable";
            this.definationAndFeatureEditTable.Size = new System.Drawing.Size(313, 455);
            this.definationAndFeatureEditTable.TabIndex = 1;
            // 
            // DefinationAndFeaturesEditForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 511);
            this.Controls.Add(this.definationAndFeatureEditTable);
            this.MaximumSize = new System.Drawing.Size(323, 516);
            this.Name = "DefinationAndFeaturesEditForm";
            this.Text = "Özellikler";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.definationAndFeatureEditTable, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DefinationAndFeatureEditTable definationAndFeatureEditTable;
    }
}
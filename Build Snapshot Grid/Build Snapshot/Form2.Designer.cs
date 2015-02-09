namespace Build_Snapshot
{
    partial class Form2
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
            this.DGV_Builds = new System.Windows.Forms.DataGridView();
            this.LBL_LastUpdated = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Builds)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Builds
            // 
            this.DGV_Builds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Builds.Location = new System.Drawing.Point(12, 47);
            this.DGV_Builds.Name = "DGV_Builds";
            this.DGV_Builds.Size = new System.Drawing.Size(240, 150);
            this.DGV_Builds.TabIndex = 0;
            // 
            // LBL_LastUpdated
            // 
            this.LBL_LastUpdated.AutoSize = true;
            this.LBL_LastUpdated.Location = new System.Drawing.Point(13, 13);
            this.LBL_LastUpdated.Name = "LBL_LastUpdated";
            this.LBL_LastUpdated.Size = new System.Drawing.Size(93, 13);
            this.LBL_LastUpdated.TabIndex = 1;
            this.LBL_LastUpdated.Text = "LBL_LastUpdated";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LBL_LastUpdated);
            this.Controls.Add(this.DGV_Builds);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Builds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Builds;
        private System.Windows.Forms.Label LBL_LastUpdated;
    }
}
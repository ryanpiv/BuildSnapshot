namespace Build_Snapshot
{
    partial class Form1
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
            this.BTN_Snapshot = new System.Windows.Forms.Button();
            this.CLB_Environment = new System.Windows.Forms.CheckedListBox();
            this.CLB_GAID = new System.Windows.Forms.CheckedListBox();
            this.LBL_Environment = new System.Windows.Forms.Label();
            this.LBL_GAID = new System.Windows.Forms.Label();
            this.CB_ManualOverride = new System.Windows.Forms.CheckBox();
            this.CLB_CalcEngine = new System.Windows.Forms.CheckedListBox();
            this.LBL_CalcEngine = new System.Windows.Forms.Label();
            this.TB_ManualOverride = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_Snapshot
            // 
            this.BTN_Snapshot.Location = new System.Drawing.Point(273, 278);
            this.BTN_Snapshot.Name = "BTN_Snapshot";
            this.BTN_Snapshot.Size = new System.Drawing.Size(75, 23);
            this.BTN_Snapshot.TabIndex = 3;
            this.BTN_Snapshot.Text = "Snapshot";
            this.BTN_Snapshot.UseVisualStyleBackColor = true;
            this.BTN_Snapshot.Click += new System.EventHandler(this.BtnSnapshot_Click);
            // 
            // CLB_Environment
            // 
            this.CLB_Environment.FormattingEnabled = true;
            this.CLB_Environment.Items.AddRange(new object[] {
            "QD1",
            "QD2",
            "QD3",
            "QD4",
            "QD5",
            "TD1",
            "TD2",
            "TD3",
            "PROD"});
            this.CLB_Environment.Location = new System.Drawing.Point(15, 25);
            this.CLB_Environment.Name = "CLB_Environment";
            this.CLB_Environment.Size = new System.Drawing.Size(88, 139);
            this.CLB_Environment.TabIndex = 4;
            // 
            // CLB_GAID
            // 
            this.CLB_GAID.FormattingEnabled = true;
            this.CLB_GAID.Items.AddRange(new object[] {
            "5380",
            "5381",
            "5385",
            "5481",
            "5482",
            "5484",
            "5485",
            "5532",
            "5574",
            "5575",
            "5576",
            "5577",
            "5578",
            "5706",
            "5924",
            "6096",
            "6343"});
            this.CLB_GAID.Location = new System.Drawing.Point(121, 25);
            this.CLB_GAID.Name = "CLB_GAID";
            this.CLB_GAID.Size = new System.Drawing.Size(107, 139);
            this.CLB_GAID.TabIndex = 5;
            // 
            // LBL_Environment
            // 
            this.LBL_Environment.AutoSize = true;
            this.LBL_Environment.Location = new System.Drawing.Point(12, 9);
            this.LBL_Environment.Name = "LBL_Environment";
            this.LBL_Environment.Size = new System.Drawing.Size(66, 13);
            this.LBL_Environment.TabIndex = 6;
            this.LBL_Environment.Text = "Environment";
            // 
            // LBL_GAID
            // 
            this.LBL_GAID.AutoSize = true;
            this.LBL_GAID.Location = new System.Drawing.Point(118, 9);
            this.LBL_GAID.Name = "LBL_GAID";
            this.LBL_GAID.Size = new System.Drawing.Size(33, 13);
            this.LBL_GAID.TabIndex = 7;
            this.LBL_GAID.Text = "GAID";
            // 
            // CB_ManualOverride
            // 
            this.CB_ManualOverride.AutoSize = true;
            this.CB_ManualOverride.Location = new System.Drawing.Point(15, 175);
            this.CB_ManualOverride.Name = "CB_ManualOverride";
            this.CB_ManualOverride.Size = new System.Drawing.Size(104, 17);
            this.CB_ManualOverride.TabIndex = 8;
            this.CB_ManualOverride.Text = "Manual Override";
            this.CB_ManualOverride.UseVisualStyleBackColor = true;
            this.CB_ManualOverride.CheckedChanged += new System.EventHandler(this.CB_ManualOverride_CheckedChanged);
            // 
            // CLB_CalcEngine
            // 
            this.CLB_CalcEngine.FormattingEnabled = true;
            this.CLB_CalcEngine.Items.AddRange(new object[] {
            "OneAm",
            "Farmers",
            "FBMI",
            "Zurich",
            "Erie"});
            this.CLB_CalcEngine.Location = new System.Drawing.Point(234, 25);
            this.CLB_CalcEngine.Name = "CLB_CalcEngine";
            this.CLB_CalcEngine.Size = new System.Drawing.Size(114, 139);
            this.CLB_CalcEngine.TabIndex = 10;
            // 
            // LBL_CalcEngine
            // 
            this.LBL_CalcEngine.AutoSize = true;
            this.LBL_CalcEngine.Location = new System.Drawing.Point(231, 9);
            this.LBL_CalcEngine.Name = "LBL_CalcEngine";
            this.LBL_CalcEngine.Size = new System.Drawing.Size(64, 13);
            this.LBL_CalcEngine.TabIndex = 11;
            this.LBL_CalcEngine.Text = "Calc Engine";
            // 
            // TB_ManualOverride
            // 
            this.TB_ManualOverride.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_ManualOverride.Location = new System.Drawing.Point(15, 198);
            this.TB_ManualOverride.Multiline = true;
            this.TB_ManualOverride.Name = "TB_ManualOverride";
            this.TB_ManualOverride.Size = new System.Drawing.Size(333, 74);
            this.TB_ManualOverride.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 323);
            this.Controls.Add(this.TB_ManualOverride);
            this.Controls.Add(this.LBL_CalcEngine);
            this.Controls.Add(this.CLB_CalcEngine);
            this.Controls.Add(this.CB_ManualOverride);
            this.Controls.Add(this.LBL_GAID);
            this.Controls.Add(this.LBL_Environment);
            this.Controls.Add(this.CLB_GAID);
            this.Controls.Add(this.CLB_Environment);
            this.Controls.Add(this.BTN_Snapshot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Build Snapshot 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Snapshot;
        private System.Windows.Forms.CheckedListBox CLB_Environment;
        private System.Windows.Forms.CheckedListBox CLB_GAID;
        private System.Windows.Forms.Label LBL_Environment;
        private System.Windows.Forms.Label LBL_GAID;
        private System.Windows.Forms.CheckBox CB_ManualOverride;
        private System.Windows.Forms.CheckedListBox CLB_CalcEngine;
        private System.Windows.Forms.Label LBL_CalcEngine;
        private System.Windows.Forms.TextBox TB_ManualOverride;
    }
}


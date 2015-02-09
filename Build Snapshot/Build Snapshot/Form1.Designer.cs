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
            this.BtnSnapshot = new System.Windows.Forms.Button();
            this.CBEnvironment = new System.Windows.Forms.ComboBox();
            this.RBGAID = new System.Windows.Forms.RadioButton();
            this.RBCalcEngine = new System.Windows.Forms.RadioButton();
            this.TBGAID = new System.Windows.Forms.TextBox();
            this.TBCalcEngine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBSnapshot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSnapshot
            // 
            this.BtnSnapshot.Location = new System.Drawing.Point(89, 123);
            this.BtnSnapshot.Name = "BtnSnapshot";
            this.BtnSnapshot.Size = new System.Drawing.Size(75, 23);
            this.BtnSnapshot.TabIndex = 3;
            this.BtnSnapshot.Text = "Snapshot";
            this.BtnSnapshot.UseVisualStyleBackColor = true;
            this.BtnSnapshot.Click += new System.EventHandler(this.BtnSnapshot_Click);
            // 
            // CBEnvironment
            // 
            this.CBEnvironment.FormattingEnabled = true;
            this.CBEnvironment.Items.AddRange(new object[] {
            "QD1",
            "QD2",
            "QD3",
            "QD4",
            "QD5",
            "TD1",
            "TD2",
            "TD3"});
            this.CBEnvironment.Location = new System.Drawing.Point(124, 26);
            this.CBEnvironment.Name = "CBEnvironment";
            this.CBEnvironment.Size = new System.Drawing.Size(100, 21);
            this.CBEnvironment.TabIndex = 4;
            // 
            // RBGAID
            // 
            this.RBGAID.AutoSize = true;
            this.RBGAID.Location = new System.Drawing.Point(23, 53);
            this.RBGAID.Name = "RBGAID";
            this.RBGAID.Size = new System.Drawing.Size(51, 17);
            this.RBGAID.TabIndex = 5;
            this.RBGAID.TabStop = true;
            this.RBGAID.Text = "GAID";
            this.RBGAID.UseVisualStyleBackColor = true;
            // 
            // RBCalcEngine
            // 
            this.RBCalcEngine.AutoSize = true;
            this.RBCalcEngine.Location = new System.Drawing.Point(23, 79);
            this.RBCalcEngine.Name = "RBCalcEngine";
            this.RBCalcEngine.Size = new System.Drawing.Size(82, 17);
            this.RBCalcEngine.TabIndex = 6;
            this.RBCalcEngine.TabStop = true;
            this.RBCalcEngine.Text = "Calc Engine";
            this.RBCalcEngine.UseVisualStyleBackColor = true;
            // 
            // TBGAID
            // 
            this.TBGAID.Location = new System.Drawing.Point(124, 53);
            this.TBGAID.Name = "TBGAID";
            this.TBGAID.Size = new System.Drawing.Size(100, 20);
            this.TBGAID.TabIndex = 7;
            // 
            // TBCalcEngine
            // 
            this.TBCalcEngine.Location = new System.Drawing.Point(124, 79);
            this.TBCalcEngine.Name = "TBCalcEngine";
            this.TBCalcEngine.Size = new System.Drawing.Size(100, 20);
            this.TBCalcEngine.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Environment";
            // 
            // TBSnapshot
            // 
            this.TBSnapshot.Location = new System.Drawing.Point(23, 152);
            this.TBSnapshot.Name = "TBSnapshot";
            this.TBSnapshot.Size = new System.Drawing.Size(201, 20);
            this.TBSnapshot.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 188);
            this.Controls.Add(this.TBSnapshot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBCalcEngine);
            this.Controls.Add(this.TBGAID);
            this.Controls.Add(this.RBCalcEngine);
            this.Controls.Add(this.RBGAID);
            this.Controls.Add(this.CBEnvironment);
            this.Controls.Add(this.BtnSnapshot);
            this.Name = "Form1";
            this.Text = "Build Snapshot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSnapshot;
        private System.Windows.Forms.ComboBox CBEnvironment;
        private System.Windows.Forms.RadioButton RBGAID;
        private System.Windows.Forms.RadioButton RBCalcEngine;
        private System.Windows.Forms.TextBox TBGAID;
        private System.Windows.Forms.TextBox TBCalcEngine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBSnapshot;
    }
}


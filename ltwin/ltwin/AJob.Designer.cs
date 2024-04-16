namespace ltwin
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbDone = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txbJob = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txbJob);
            this.panel1.Controls.Add(this.ckbDone);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 49);
            this.panel1.TabIndex = 0;
            // 
            // ckbDone
            // 
            this.ckbDone.AutoSize = true;
            this.ckbDone.Location = new System.Drawing.Point(3, 3);
            this.ckbDone.Name = "ckbDone";
            this.ckbDone.Size = new System.Drawing.Size(18, 17);
            this.ckbDone.TabIndex = 0;
            this.ckbDone.UseVisualStyleBackColor = true;
            // 
            // txbJob
            // 
            this.txbJob.Location = new System.Drawing.Point(27, 3);
            this.txbJob.Name = "txbJob";
            this.txbJob.Size = new System.Drawing.Size(454, 22);
            this.txbJob.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Location = new System.Drawing.Point(487, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 43);
            this.panel2.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(19, 3);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(49, 22);
            this.numericUpDown2.TabIndex = 1;
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(1089, 57);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbJob;
        private System.Windows.Forms.CheckBox ckbDone;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

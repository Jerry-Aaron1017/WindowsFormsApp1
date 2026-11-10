namespace WindowsFormsApp1
{
    partial class frmTrackThread
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
            this.RUN = new System.Windows.Forms.Button();
            this.threadStarts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.RUN.Location = new System.Drawing.Point(130, 96);
            this.RUN.Name = "button1";
            this.RUN.Size = new System.Drawing.Size(109, 42);
            this.RUN.TabIndex = 0;
            this.RUN.Text = "RUN";
            this.RUN.UseVisualStyleBackColor = true;
            this.RUN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.threadStarts.AutoSize = true;
            this.threadStarts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.threadStarts.Location = new System.Drawing.Point(112, 56);
            this.threadStarts.Name = "label1";
            this.threadStarts.Size = new System.Drawing.Size(156, 26);
            this.threadStarts.TabIndex = 1;
            this.threadStarts.Text = "-Thread Starts-";
            // 
            // frmTrackThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(380, 198);
            this.Controls.Add(this.threadStarts);
            this.Controls.Add(this.RUN);
            this.Name = "frmTrackThread";
            this.Text = "frmTrackThread";
            CenterToScreen();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button RUN;
        private System.Windows.Forms.Label threadStarts;
    }
}


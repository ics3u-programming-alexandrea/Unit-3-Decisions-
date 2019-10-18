namespace ProgressBarAlex
{
    partial class frmProgressBar
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
            this.prbProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prbProgressBar
            // 
            this.prbProgressBar.Location = new System.Drawing.Point(37, 170);
            this.prbProgressBar.Name = "prbProgressBar";
            this.prbProgressBar.Size = new System.Drawing.Size(233, 70);
            this.prbProgressBar.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(101, 66);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 306);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.prbProgressBar);
            this.Name = "frmProgressBar";
            this.Text = "Progress Bar Alex";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbProgressBar;
        private System.Windows.Forms.Button btnStart;
    }
}


namespace PerfectSquaresAlex
{
    partial class frmPerfectSquares
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
            this.btnStart = new System.Windows.Forms.Button();
            this.nudNumbers = new System.Windows.Forms.NumericUpDown();
            this.lstSquares = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(250, 47);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 38);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudNumbers
            // 
            this.nudNumbers.Location = new System.Drawing.Point(250, 125);
            this.nudNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumbers.Name = "nudNumbers";
            this.nudNumbers.Size = new System.Drawing.Size(120, 20);
            this.nudNumbers.TabIndex = 1;
            this.nudNumbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstSquares
            // 
            this.lstSquares.FormattingEnabled = true;
            this.lstSquares.Location = new System.Drawing.Point(206, 173);
            this.lstSquares.Name = "lstSquares";
            this.lstSquares.Size = new System.Drawing.Size(208, 147);
            this.lstSquares.TabIndex = 2;
            // 
            // frmPerfectSquares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.lstSquares);
            this.Controls.Add(this.nudNumbers);
            this.Controls.Add(this.btnStart);
            this.Name = "frmPerfectSquares";
            this.Text = "Perfect Squares by Alex";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudNumbers;
        private System.Windows.Forms.ListBox lstSquares;
    }
}


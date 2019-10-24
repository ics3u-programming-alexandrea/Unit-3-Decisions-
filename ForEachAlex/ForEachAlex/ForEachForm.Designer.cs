namespace ForEachAlex
{
    partial class frmForEach
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lblClick = new System.Windows.Forms.Label();
            this.lstClick = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(311, 49);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(144, 78);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClick.Location = new System.Drawing.Point(296, 202);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(47, 20);
            this.lblClick.TabIndex = 1;
            this.lblClick.Text = "Click";
            // 
            // lstClick
            // 
            this.lstClick.FormattingEnabled = true;
            this.lstClick.Location = new System.Drawing.Point(45, 14);
            this.lstClick.Name = "lstClick";
            this.lstClick.Size = new System.Drawing.Size(120, 394);
            this.lstClick.TabIndex = 2;
            // 
            // frmForEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.lstClick);
            this.Controls.Add(this.lblClick);
            this.Controls.Add(this.btnClick);
            this.Name = "frmForEach";
            this.Text = "For Each by Alex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblClick;
        private System.Windows.Forms.ListBox lstClick;
    }
}


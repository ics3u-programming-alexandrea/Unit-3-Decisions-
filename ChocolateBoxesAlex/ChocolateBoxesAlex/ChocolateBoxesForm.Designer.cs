namespace ChocolateBoxesAlex
{
    partial class frmChocolateBoxes
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblPrize = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblInsert = new System.Windows.Forms.Label();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheck.Location = new System.Drawing.Point(325, 170);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(92, 36);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.BackColor = System.Drawing.Color.Transparent;
            this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrize.Location = new System.Drawing.Point(401, 291);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(85, 29);
            this.lblPrize.TabIndex = 1;
            this.lblPrize.Text = "label1";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.Color.Transparent;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.Yellow;
            this.lblComment.Location = new System.Drawing.Point(57, 291);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(169, 29);
            this.lblComment.TabIndex = 2;
            this.lblComment.Text = "Your Prize is:";
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.BackColor = System.Drawing.Color.Transparent;
            this.lblInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsert.ForeColor = System.Drawing.Color.Yellow;
            this.lblInsert.Location = new System.Drawing.Point(-7, 78);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(561, 29);
            this.lblInsert.TabIndex = 3;
            this.lblInsert.Text = "Insert the number of Chocolate Boxes you sold:";
            this.lblInsert.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(618, 87);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(112, 20);
            this.txtInsert.TabIndex = 4;
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChocolateBoxesAlex.Properties.Resources.j1;
            this.ClientSize = new System.Drawing.Size(817, 510);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.lblInsert);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.btnCheck);
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocolate Boxes by Alex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.TextBox txtInsert;
    }
}


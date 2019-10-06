namespace RockPaperScissorsAlex
{
    partial class frmRockPaperScissors
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
            this.grbPChoice = new System.Windows.Forms.GroupBox();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.grbCChoice = new System.Windows.Forms.GroupBox();
            this.radCScissors = new System.Windows.Forms.RadioButton();
            this.radCPaper = new System.Windows.Forms.RadioButton();
            this.radCRock = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.grbPChoice.SuspendLayout();
            this.grbCChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPChoice
            // 
            this.grbPChoice.BackColor = System.Drawing.Color.White;
            this.grbPChoice.Controls.Add(this.radScissors);
            this.grbPChoice.Controls.Add(this.radPaper);
            this.grbPChoice.Controls.Add(this.radRock);
            this.grbPChoice.Location = new System.Drawing.Point(32, 33);
            this.grbPChoice.Name = "grbPChoice";
            this.grbPChoice.Size = new System.Drawing.Size(218, 154);
            this.grbPChoice.TabIndex = 0;
            this.grbPChoice.TabStop = false;
            this.grbPChoice.Text = "Player\'s Choice";
            this.grbPChoice.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Location = new System.Drawing.Point(7, 111);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(64, 17);
            this.radScissors.TabIndex = 2;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            this.radScissors.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Location = new System.Drawing.Point(7, 60);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(53, 17);
            this.radPaper.TabIndex = 1;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            this.radPaper.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Location = new System.Drawing.Point(8, 18);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(51, 17);
            this.radRock.TabIndex = 0;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            // 
            // grbCChoice
            // 
            this.grbCChoice.Controls.Add(this.radCScissors);
            this.grbCChoice.Controls.Add(this.radCPaper);
            this.grbCChoice.Controls.Add(this.radCRock);
            this.grbCChoice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grbCChoice.Location = new System.Drawing.Point(32, 213);
            this.grbCChoice.Name = "grbCChoice";
            this.grbCChoice.Size = new System.Drawing.Size(218, 161);
            this.grbCChoice.TabIndex = 1;
            this.grbCChoice.TabStop = false;
            this.grbCChoice.Text = "Computer\'s Choice";
            this.grbCChoice.Enter += new System.EventHandler(this.grbCChoice_Enter);
            // 
            // radCScissors
            // 
            this.radCScissors.AutoSize = true;
            this.radCScissors.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.radCScissors.Location = new System.Drawing.Point(8, 138);
            this.radCScissors.Name = "radCScissors";
            this.radCScissors.Size = new System.Drawing.Size(64, 17);
            this.radCScissors.TabIndex = 2;
            this.radCScissors.TabStop = true;
            this.radCScissors.Text = "Scissors";
            this.radCScissors.UseVisualStyleBackColor = true;
            // 
            // radCPaper
            // 
            this.radCPaper.AutoSize = true;
            this.radCPaper.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.radCPaper.Location = new System.Drawing.Point(8, 88);
            this.radCPaper.Name = "radCPaper";
            this.radCPaper.Size = new System.Drawing.Size(53, 17);
            this.radCPaper.TabIndex = 1;
            this.radCPaper.TabStop = true;
            this.radCPaper.Text = "Paper";
            this.radCPaper.UseVisualStyleBackColor = true;
            // 
            // radCRock
            // 
            this.radCRock.AutoSize = true;
            this.radCRock.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.radCRock.Location = new System.Drawing.Point(8, 32);
            this.radCRock.Name = "radCRock";
            this.radCRock.Size = new System.Drawing.Size(51, 17);
            this.radCRock.TabIndex = 0;
            this.radCRock.TabStop = true;
            this.radCRock.Text = "Rock";
            this.radCRock.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlay.Location = new System.Drawing.Point(295, 169);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(96, 38);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblComment.Location = new System.Drawing.Point(312, 245);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(66, 24);
            this.lblComment.TabIndex = 3;
            this.lblComment.Text = "label1";
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RockPaperScissorsAlex.Properties.Resources.d;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbCChoice);
            this.Controls.Add(this.grbPChoice);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock, Paper, Scissors By Alex";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            this.grbPChoice.ResumeLayout(false);
            this.grbPChoice.PerformLayout();
            this.grbCChoice.ResumeLayout(false);
            this.grbCChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPChoice;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.GroupBox grbCChoice;
        private System.Windows.Forms.RadioButton radCScissors;
        private System.Windows.Forms.RadioButton radCPaper;
        private System.Windows.Forms.RadioButton radCRock;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblComment;
    }
}


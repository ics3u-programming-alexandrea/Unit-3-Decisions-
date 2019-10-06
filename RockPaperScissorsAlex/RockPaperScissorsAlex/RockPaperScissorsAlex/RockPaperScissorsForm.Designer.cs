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
            this.btnPlay = new System.Windows.Forms.Button();
            this.grbPlayerChoice = new System.Windows.Forms.GroupBox();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.grbComputerChoice = new System.Windows.Forms.GroupBox();
            this.radCRock = new System.Windows.Forms.RadioButton();
            this.radCPaper = new System.Windows.Forms.RadioButton();
            this.radCScissors = new System.Windows.Forms.RadioButton();
            this.lblComment = new System.Windows.Forms.Label();
            this.grbPlayerChoice.SuspendLayout();
            this.grbComputerChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Location = new System.Drawing.Point(254, 209);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(95, 44);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // grbPlayerChoice
            // 
            this.grbPlayerChoice.BackColor = System.Drawing.Color.Transparent;
            this.grbPlayerChoice.Controls.Add(this.radScissors);
            this.grbPlayerChoice.Controls.Add(this.radPaper);
            this.grbPlayerChoice.Controls.Add(this.radRock);
            this.grbPlayerChoice.Location = new System.Drawing.Point(12, 12);
            this.grbPlayerChoice.Name = "grbPlayerChoice";
            this.grbPlayerChoice.Size = new System.Drawing.Size(201, 220);
            this.grbPlayerChoice.TabIndex = 1;
            this.grbPlayerChoice.TabStop = false;
            this.grbPlayerChoice.Text = "Player\'s Choice";
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.BackColor = System.Drawing.Color.Black;
            this.radScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radScissors.ForeColor = System.Drawing.Color.Transparent;
            this.radScissors.Location = new System.Drawing.Point(20, 157);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(121, 28);
            this.radScissors.TabIndex = 6;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "SCISSORS";
            this.radScissors.UseVisualStyleBackColor = false;
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.BackColor = System.Drawing.Color.Black;
            this.radPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPaper.ForeColor = System.Drawing.Color.Transparent;
            this.radPaper.Location = new System.Drawing.Point(20, 90);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(91, 28);
            this.radPaper.TabIndex = 5;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "PAPER";
            this.radPaper.UseVisualStyleBackColor = false;
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.BackColor = System.Drawing.Color.Black;
            this.radRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRock.ForeColor = System.Drawing.Color.Transparent;
            this.radRock.Location = new System.Drawing.Point(20, 29);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(81, 28);
            this.radRock.TabIndex = 4;
            this.radRock.TabStop = true;
            this.radRock.Text = "ROCK";
            this.radRock.UseVisualStyleBackColor = false;
            // 
            // grbComputerChoice
            // 
            this.grbComputerChoice.BackColor = System.Drawing.Color.Transparent;
            this.grbComputerChoice.Controls.Add(this.radCScissors);
            this.grbComputerChoice.Controls.Add(this.radCPaper);
            this.grbComputerChoice.Controls.Add(this.radCRock);
            this.grbComputerChoice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grbComputerChoice.Location = new System.Drawing.Point(12, 233);
            this.grbComputerChoice.Name = "grbComputerChoice";
            this.grbComputerChoice.Size = new System.Drawing.Size(177, 185);
            this.grbComputerChoice.TabIndex = 2;
            this.grbComputerChoice.TabStop = false;
            this.grbComputerChoice.Text = "Computer\'s Choice";
            this.grbComputerChoice.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radCRock
            // 
            this.radCRock.AutoSize = true;
            this.radCRock.BackColor = System.Drawing.Color.Gray;
            this.radCRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCRock.ForeColor = System.Drawing.Color.Transparent;
            this.radCRock.Location = new System.Drawing.Point(20, 35);
            this.radCRock.Name = "radCRock";
            this.radCRock.Size = new System.Drawing.Size(81, 28);
            this.radCRock.TabIndex = 7;
            this.radCRock.TabStop = true;
            this.radCRock.Text = "ROCK";
            this.radCRock.UseVisualStyleBackColor = false;
            // 
            // radCPaper
            // 
            this.radCPaper.AutoSize = true;
            this.radCPaper.BackColor = System.Drawing.Color.Gray;
            this.radCPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCPaper.ForeColor = System.Drawing.Color.Transparent;
            this.radCPaper.Location = new System.Drawing.Point(20, 91);
            this.radCPaper.Name = "radCPaper";
            this.radCPaper.Size = new System.Drawing.Size(91, 28);
            this.radCPaper.TabIndex = 7;
            this.radCPaper.TabStop = true;
            this.radCPaper.Text = "PAPER";
            this.radCPaper.UseVisualStyleBackColor = false;
            // 
            // radCScissors
            // 
            this.radCScissors.AutoSize = true;
            this.radCScissors.BackColor = System.Drawing.Color.Gray;
            this.radCScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCScissors.ForeColor = System.Drawing.Color.Transparent;
            this.radCScissors.Location = new System.Drawing.Point(20, 157);
            this.radCScissors.Name = "radCScissors";
            this.radCScissors.Size = new System.Drawing.Size(121, 28);
            this.radCScissors.TabIndex = 7;
            this.radCScissors.TabStop = true;
            this.radCScissors.Text = "SCISSORS";
            this.radCScissors.UseVisualStyleBackColor = false;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.SystemColors.Control;
            this.lblComment.Location = new System.Drawing.Point(262, 272);
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
            this.ClientSize = new System.Drawing.Size(668, 455);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.grbComputerChoice);
            this.Controls.Add(this.grbPlayerChoice);
            this.Controls.Add(this.btnPlay);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock, Paper, Scissors by Alex";
            this.grbPlayerChoice.ResumeLayout(false);
            this.grbPlayerChoice.PerformLayout();
            this.grbComputerChoice.ResumeLayout(false);
            this.grbComputerChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox grbPlayerChoice;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.GroupBox grbComputerChoice;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.RadioButton radCRock;
        private System.Windows.Forms.RadioButton radCPaper;
        private System.Windows.Forms.RadioButton radCScissors;
        private System.Windows.Forms.Label lblComment;
    }
}


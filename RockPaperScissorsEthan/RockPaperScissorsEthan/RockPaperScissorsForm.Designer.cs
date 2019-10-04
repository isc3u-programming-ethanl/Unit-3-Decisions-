namespace RockPaperScissorsEthan
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
            this.grbUserChoice = new System.Windows.Forms.GroupBox();
            this.grbComputerChoice = new System.Windows.Forms.GroupBox();
            this.radRockUser = new System.Windows.Forms.RadioButton();
            this.radPaperUser = new System.Windows.Forms.RadioButton();
            this.radScissorsUser = new System.Windows.Forms.RadioButton();
            this.radRockComputer = new System.Windows.Forms.RadioButton();
            this.radPaperComputer = new System.Windows.Forms.RadioButton();
            this.radScissorsComputer = new System.Windows.Forms.RadioButton();
            this.grbUserChoice.SuspendLayout();
            this.grbComputerChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUserChoice
            // 
            this.grbUserChoice.Controls.Add(this.radScissorsUser);
            this.grbUserChoice.Controls.Add(this.radPaperUser);
            this.grbUserChoice.Controls.Add(this.radRockUser);
            this.grbUserChoice.Location = new System.Drawing.Point(98, 51);
            this.grbUserChoice.Name = "grbUserChoice";
            this.grbUserChoice.Size = new System.Drawing.Size(204, 105);
            this.grbUserChoice.TabIndex = 0;
            this.grbUserChoice.TabStop = false;
            this.grbUserChoice.Text = "User Choice";
            this.grbUserChoice.Enter += new System.EventHandler(this.GrbUserChoice_Enter);
            // 
            // grbComputerChoice
            // 
            this.grbComputerChoice.Controls.Add(this.radScissorsComputer);
            this.grbComputerChoice.Controls.Add(this.radRockComputer);
            this.grbComputerChoice.Controls.Add(this.radPaperComputer);
            this.grbComputerChoice.Location = new System.Drawing.Point(98, 210);
            this.grbComputerChoice.Name = "grbComputerChoice";
            this.grbComputerChoice.Size = new System.Drawing.Size(200, 100);
            this.grbComputerChoice.TabIndex = 0;
            this.grbComputerChoice.TabStop = false;
            this.grbComputerChoice.Text = "Computer";
            this.grbComputerChoice.Enter += new System.EventHandler(this.GrbComputerChoice_Enter);
            // 
            // radRockUser
            // 
            this.radRockUser.AutoSize = true;
            this.radRockUser.Location = new System.Drawing.Point(11, 19);
            this.radRockUser.Name = "radRockUser";
            this.radRockUser.Size = new System.Drawing.Size(51, 17);
            this.radRockUser.TabIndex = 0;
            this.radRockUser.TabStop = true;
            this.radRockUser.Text = "Rock";
            this.radRockUser.UseVisualStyleBackColor = true;
            this.radRockUser.CheckedChanged += new System.EventHandler(this.RadRockUser_CheckedChanged);
            // 
            // radPaperUser
            // 
            this.radPaperUser.AutoSize = true;
            this.radPaperUser.Location = new System.Drawing.Point(11, 49);
            this.radPaperUser.Name = "radPaperUser";
            this.radPaperUser.Size = new System.Drawing.Size(53, 17);
            this.radPaperUser.TabIndex = 1;
            this.radPaperUser.TabStop = true;
            this.radPaperUser.Text = "Paper";
            this.radPaperUser.UseVisualStyleBackColor = true;
            this.radPaperUser.CheckedChanged += new System.EventHandler(this.RadPaperUser_CheckedChanged);
            // 
            // radScissorsUser
            // 
            this.radScissorsUser.AutoSize = true;
            this.radScissorsUser.Location = new System.Drawing.Point(11, 82);
            this.radScissorsUser.Name = "radScissorsUser";
            this.radScissorsUser.Size = new System.Drawing.Size(64, 17);
            this.radScissorsUser.TabIndex = 2;
            this.radScissorsUser.TabStop = true;
            this.radScissorsUser.Text = "Scissors";
            this.radScissorsUser.UseVisualStyleBackColor = true;
            this.radScissorsUser.CheckedChanged += new System.EventHandler(this.RadScissorsUser_CheckedChanged);
            // 
            // radRockComputer
            // 
            this.radRockComputer.AutoSize = true;
            this.radRockComputer.Location = new System.Drawing.Point(11, 19);
            this.radRockComputer.Name = "radRockComputer";
            this.radRockComputer.Size = new System.Drawing.Size(51, 17);
            this.radRockComputer.TabIndex = 1;
            this.radRockComputer.TabStop = true;
            this.radRockComputer.Text = "Rock";
            this.radRockComputer.UseVisualStyleBackColor = true;
            this.radRockComputer.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // radPaperComputer
            // 
            this.radPaperComputer.AutoSize = true;
            this.radPaperComputer.Location = new System.Drawing.Point(11, 42);
            this.radPaperComputer.Name = "radPaperComputer";
            this.radPaperComputer.Size = new System.Drawing.Size(53, 17);
            this.radPaperComputer.TabIndex = 2;
            this.radPaperComputer.TabStop = true;
            this.radPaperComputer.Text = "Paper";
            this.radPaperComputer.UseVisualStyleBackColor = true;
            this.radPaperComputer.CheckedChanged += new System.EventHandler(this.RadPaperComputer_CheckedChanged);
            // 
            // radScissorsComputer
            // 
            this.radScissorsComputer.AutoSize = true;
            this.radScissorsComputer.Location = new System.Drawing.Point(11, 65);
            this.radScissorsComputer.Name = "radScissorsComputer";
            this.radScissorsComputer.Size = new System.Drawing.Size(64, 17);
            this.radScissorsComputer.TabIndex = 3;
            this.radScissorsComputer.TabStop = true;
            this.radScissorsComputer.Text = "Scissors";
            this.radScissorsComputer.UseVisualStyleBackColor = true;
            this.radScissorsComputer.CheckedChanged += new System.EventHandler(this.RadScissorsComputer_CheckedChanged);
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbComputerChoice);
            this.Controls.Add(this.grbUserChoice);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissors by Ethan";
            this.Load += new System.EventHandler(this.FrmRockPaperScissors_Load);
            this.grbUserChoice.ResumeLayout(false);
            this.grbUserChoice.PerformLayout();
            this.grbComputerChoice.ResumeLayout(false);
            this.grbComputerChoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUserChoice;
        private System.Windows.Forms.GroupBox grbComputerChoice;
        private System.Windows.Forms.RadioButton radScissorsUser;
        private System.Windows.Forms.RadioButton radPaperUser;
        private System.Windows.Forms.RadioButton radRockUser;
        private System.Windows.Forms.RadioButton radScissorsComputer;
        private System.Windows.Forms.RadioButton radRockComputer;
        private System.Windows.Forms.RadioButton radPaperComputer;
    }
}


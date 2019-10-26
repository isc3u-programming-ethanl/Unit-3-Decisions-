namespace NumberGuessingGameEthan
{
    partial class frmNumberGuessingGame
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
            this.lblInput = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.picOutput = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(48, 56);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(359, 25);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Guess an integer between 1 and 10:";
            this.lblInput.Click += new System.EventHandler(this.LblInput_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(53, 132);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(125, 45);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(413, 57);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 26);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(240, 142);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(48, 25);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "???";
            this.lblAnswer.Click += new System.EventHandler(this.LblAnswer_Click);
            // 
            // picOutput
            // 
            this.picOutput.Image = global::NumberGuessingGameEthan.Properties.Resources.checkmark1;
            this.picOutput.Location = new System.Drawing.Point(331, 202);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(182, 182);
            this.picOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOutput.TabIndex = 4;
            this.picOutput.TabStop = false;
            // 
            // frmNumberGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picOutput);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblInput);
            this.Name = "frmNumberGuessingGame";
            this.Text = "Number Guessing Game by Ethan";
            this.Load += new System.EventHandler(this.FrmNumberGuessingGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.PictureBox picOutput;
    }
}


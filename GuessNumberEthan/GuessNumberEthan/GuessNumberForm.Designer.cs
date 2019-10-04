namespace GuessNumberEthan
{
    partial class frmGuessNumber
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
            this.lblClickText = new System.Windows.Forms.Label();
            this.lblClickText2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblClickText
            // 
            this.lblClickText.AutoSize = true;
            this.lblClickText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickText.Location = new System.Drawing.Point(78, 67);
            this.lblClickText.Name = "lblClickText";
            this.lblClickText.Size = new System.Drawing.Size(386, 25);
            this.lblClickText.TabIndex = 0;
            this.lblClickText.Text = "Guess an integer between 1 and 10";
            this.lblClickText.Click += new System.EventHandler(this.LblClickText_Click);
            // 
            // lblClickText2
            // 
            this.lblClickText2.AutoSize = true;
            this.lblClickText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickText2.Location = new System.Drawing.Point(249, 196);
            this.lblClickText2.Name = "lblClickText2";
            this.lblClickText2.Size = new System.Drawing.Size(51, 25);
            this.lblClickText2.TabIndex = 1;
            this.lblClickText2.Text = "???";
            this.lblClickText2.Click += new System.EventHandler(this.LblClickText2_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(91, 185);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(103, 46);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Check";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(504, 73);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer.TabIndex = 3;
            this.txtAnswer.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // frmGuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblClickText2);
            this.Controls.Add(this.lblClickText);
            this.Name = "frmGuessNumber";
            this.Text = "Number game updated by Ethan";
            this.Load += new System.EventHandler(this.FrmGuessNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClickText;
        private System.Windows.Forms.Label lblClickText2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtAnswer;
    }
}


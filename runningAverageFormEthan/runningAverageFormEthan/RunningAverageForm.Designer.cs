namespace runningAverageFormEthan
{
    partial class frmRunningAverage
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
            this.lblInputText = new System.Windows.Forms.Label();
            this.lblExitText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputText
            // 
            this.lblInputText.AutoSize = true;
            this.lblInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputText.Location = new System.Drawing.Point(62, 52);
            this.lblInputText.Name = "lblInputText";
            this.lblInputText.Size = new System.Drawing.Size(297, 25);
            this.lblInputText.TabIndex = 0;
            this.lblInputText.Text = "Enter a number from 0 to 100:";
            // 
            // lblExitText
            // 
            this.lblExitText.AutoSize = true;
            this.lblExitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitText.Location = new System.Drawing.Point(62, 114);
            this.lblExitText.Name = "lblExitText";
            this.lblExitText.Size = new System.Drawing.Size(172, 25);
            this.lblExitText.TabIndex = 1;
            this.lblExitText.Text = "(Enter -1 to exit.)";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(374, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(67, 171);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(215, 54);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(64, 287);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(48, 25);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "???";
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblExitText);
            this.Controls.Add(this.lblInputText);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average by Ethan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputText;
        private System.Windows.Forms.Label lblExitText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblOutput;
    }
}


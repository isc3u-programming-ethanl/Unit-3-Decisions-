namespace PerfectSquaresWithWhileLoop
{
    partial class frmPerfectSquareWithLoopForm
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
            this.nupInput = new System.Windows.Forms.NumericUpDown();
            this.lstPerfectSquares = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(176, 74);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 51);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // nupInput
            // 
            this.nupInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupInput.Location = new System.Drawing.Point(180, 160);
            this.nupInput.Name = "nupInput";
            this.nupInput.Size = new System.Drawing.Size(120, 22);
            this.nupInput.TabIndex = 1;
            this.nupInput.ValueChanged += new System.EventHandler(this.NupInput_ValueChanged);
            // 
            // lstPerfectSquares
            // 
            this.lstPerfectSquares.FormattingEnabled = true;
            this.lstPerfectSquares.Location = new System.Drawing.Point(145, 224);
            this.lstPerfectSquares.Name = "lstPerfectSquares";
            this.lstPerfectSquares.Size = new System.Drawing.Size(187, 95);
            this.lstPerfectSquares.TabIndex = 3;
            this.lstPerfectSquares.SelectedIndexChanged += new System.EventHandler(this.LstPerfectSquares_SelectedIndexChanged);
            // 
            // frmPerfectSquareWithLoopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.lstPerfectSquares);
            this.Controls.Add(this.nupInput);
            this.Controls.Add(this.btnStart);
            this.Name = "frmPerfectSquareWithLoopForm";
            this.Text = "Perfect Squares With While Loop by Ethan";
            ((System.ComponentModel.ISupportInitialize)(this.nupInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nupInput;
        private System.Windows.Forms.ListBox lstPerfectSquares;
    }
}


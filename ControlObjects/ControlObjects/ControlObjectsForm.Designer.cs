namespace ControlObjects
{
    partial class frmControlObjects
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
            this.btnColourChange = new System.Windows.Forms.Button();
            this.lblColourChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnColourChange
            // 
            this.btnColourChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColourChange.Location = new System.Drawing.Point(216, 52);
            this.btnColourChange.Name = "btnColourChange";
            this.btnColourChange.Size = new System.Drawing.Size(135, 61);
            this.btnColourChange.TabIndex = 0;
            this.btnColourChange.Text = "Change Colour";
            this.btnColourChange.UseVisualStyleBackColor = true;
            this.btnColourChange.Click += new System.EventHandler(this.BtnColourChange_Click);
            // 
            // lblColourChange
            // 
            this.lblColourChange.AutoSize = true;
            this.lblColourChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourChange.Location = new System.Drawing.Point(226, 197);
            this.lblColourChange.Name = "lblColourChange";
            this.lblColourChange.Size = new System.Drawing.Size(156, 25);
            this.lblColourChange.TabIndex = 1;
            this.lblColourChange.Text = "Change Colour";
            this.lblColourChange.Click += new System.EventHandler(this.LblColourChange_Click);
            // 
            // frmControlObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblColourChange);
            this.Controls.Add(this.btnColourChange);
            this.Name = "frmControlObjects";
            this.Text = "Change Colour by Ethan";
            this.Load += new System.EventHandler(this.FrmControlObjects_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColourChange;
        private System.Windows.Forms.Label lblColourChange;
    }
}


namespace CSC240_07_01_FiveColors_SES
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UxTitleLabel = new System.Windows.Forms.Label();
            this.UxManualLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UxTitleLabel
            // 
            this.UxTitleLabel.AutoSize = true;
            this.UxTitleLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxTitleLabel.Location = new System.Drawing.Point(271, 27);
            this.UxTitleLabel.Name = "UxTitleLabel";
            this.UxTitleLabel.Size = new System.Drawing.Size(186, 26);
            this.UxTitleLabel.TabIndex = 0;
            this.UxTitleLabel.Text = "Color Generator:";
            // 
            // UxManualLabel
            // 
            this.UxManualLabel.AutoSize = true;
            this.UxManualLabel.Location = new System.Drawing.Point(211, 97);
            this.UxManualLabel.Name = "UxManualLabel";
            this.UxManualLabel.Size = new System.Drawing.Size(294, 20);
            this.UxManualLabel.TabIndex = 1;
            this.UxManualLabel.Text = "Please Choose Background Color Manually:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UxManualLabel);
            this.Controls.Add(this.UxTitleLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UxTitleLabel;
        private Label UxManualLabel;
    }
}
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
            this.components = new System.ComponentModel.Container();
            this.UxTitleLabel = new System.Windows.Forms.Label();
            this.UxManualLabel = new System.Windows.Forms.Label();
            this.UxBlueRadioButton = new System.Windows.Forms.RadioButton();
            this.UxRedRadioButton = new System.Windows.Forms.RadioButton();
            this.UxPurpleRadioButton = new System.Windows.Forms.RadioButton();
            this.UxYellowRadioButton = new System.Windows.Forms.RadioButton();
            this.UxGreenRadioButton = new System.Windows.Forms.RadioButton();
            this.UxColorButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UxInstructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UxTitleLabel
            // 
            this.UxTitleLabel.AutoSize = true;
            this.UxTitleLabel.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxTitleLabel.ForeColor = System.Drawing.Color.Cyan;
            this.UxTitleLabel.Location = new System.Drawing.Point(224, 24);
            this.UxTitleLabel.Name = "UxTitleLabel";
            this.UxTitleLabel.Size = new System.Drawing.Size(312, 45);
            this.UxTitleLabel.TabIndex = 0;
            this.UxTitleLabel.Text = "Color Generator:";
            // 
            // UxManualLabel
            // 
            this.UxManualLabel.AutoSize = true;
            this.UxManualLabel.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxManualLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UxManualLabel.Location = new System.Drawing.Point(141, 91);
            this.UxManualLabel.Name = "UxManualLabel";
            this.UxManualLabel.Size = new System.Drawing.Size(510, 32);
            this.UxManualLabel.TabIndex = 1;
            this.UxManualLabel.Text = "Please Choose Background Color Manually:";
            // 
            // UxBlueRadioButton
            // 
            this.UxBlueRadioButton.AutoSize = true;
            this.UxBlueRadioButton.Font = new System.Drawing.Font("Baskerville Old Face", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxBlueRadioButton.ForeColor = System.Drawing.Color.Blue;
            this.UxBlueRadioButton.Location = new System.Drawing.Point(29, 140);
            this.UxBlueRadioButton.Name = "UxBlueRadioButton";
            this.UxBlueRadioButton.Size = new System.Drawing.Size(96, 25);
            this.UxBlueRadioButton.TabIndex = 2;
            this.UxBlueRadioButton.TabStop = true;
            this.UxBlueRadioButton.Text = "<-- Blue";
            this.UxBlueRadioButton.UseVisualStyleBackColor = true;
            // 
            // UxRedRadioButton
            // 
            this.UxRedRadioButton.AutoSize = true;
            this.UxRedRadioButton.Font = new System.Drawing.Font("Baskerville Old Face", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxRedRadioButton.ForeColor = System.Drawing.Color.Red;
            this.UxRedRadioButton.Location = new System.Drawing.Point(161, 186);
            this.UxRedRadioButton.Name = "UxRedRadioButton";
            this.UxRedRadioButton.Size = new System.Drawing.Size(91, 25);
            this.UxRedRadioButton.TabIndex = 3;
            this.UxRedRadioButton.TabStop = true;
            this.UxRedRadioButton.Text = "<-- Red";
            this.UxRedRadioButton.UseVisualStyleBackColor = true;
            // 
            // UxPurpleRadioButton
            // 
            this.UxPurpleRadioButton.AutoSize = true;
            this.UxPurpleRadioButton.Font = new System.Drawing.Font("Baskerville Old Face", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxPurpleRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UxPurpleRadioButton.Location = new System.Drawing.Point(307, 140);
            this.UxPurpleRadioButton.Name = "UxPurpleRadioButton";
            this.UxPurpleRadioButton.Size = new System.Drawing.Size(111, 25);
            this.UxPurpleRadioButton.TabIndex = 4;
            this.UxPurpleRadioButton.TabStop = true;
            this.UxPurpleRadioButton.Text = "<-- Purple";
            this.UxPurpleRadioButton.UseVisualStyleBackColor = true;
            this.UxPurpleRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // UxYellowRadioButton
            // 
            this.UxYellowRadioButton.AutoSize = true;
            this.UxYellowRadioButton.Font = new System.Drawing.Font("Baskerville Old Face", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxYellowRadioButton.ForeColor = System.Drawing.Color.Yellow;
            this.UxYellowRadioButton.Location = new System.Drawing.Point(459, 186);
            this.UxYellowRadioButton.Name = "UxYellowRadioButton";
            this.UxYellowRadioButton.Size = new System.Drawing.Size(113, 25);
            this.UxYellowRadioButton.TabIndex = 5;
            this.UxYellowRadioButton.TabStop = true;
            this.UxYellowRadioButton.Text = "<-- Yellow";
            this.UxYellowRadioButton.UseVisualStyleBackColor = true;
            // 
            // UxGreenRadioButton
            // 
            this.UxGreenRadioButton.AutoSize = true;
            this.UxGreenRadioButton.Font = new System.Drawing.Font("Baskerville Old Face", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxGreenRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.UxGreenRadioButton.Location = new System.Drawing.Point(610, 140);
            this.UxGreenRadioButton.Name = "UxGreenRadioButton";
            this.UxGreenRadioButton.Size = new System.Drawing.Size(109, 25);
            this.UxGreenRadioButton.TabIndex = 6;
            this.UxGreenRadioButton.TabStop = true;
            this.UxGreenRadioButton.Text = "<-- Green";
            this.UxGreenRadioButton.UseVisualStyleBackColor = true;
            // 
            // UxColorButton
            // 
            this.UxColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UxColorButton.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxColorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UxColorButton.Location = new System.Drawing.Point(211, 318);
            this.UxColorButton.Name = "UxColorButton";
            this.UxColorButton.Size = new System.Drawing.Size(325, 84);
            this.UxColorButton.TabIndex = 7;
            this.UxColorButton.Text = "Start";
            this.UxColorButton.UseVisualStyleBackColor = false;
            this.UxColorButton.Click += new System.EventHandler(this.UxColorButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UxInstructionLabel
            // 
            this.UxInstructionLabel.AutoSize = true;
            this.UxInstructionLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxInstructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UxInstructionLabel.Location = new System.Drawing.Point(161, 267);
            this.UxInstructionLabel.Name = "UxInstructionLabel";
            this.UxInstructionLabel.Size = new System.Drawing.Size(431, 23);
            this.UxInstructionLabel.TabIndex = 9;
            this.UxInstructionLabel.Text = "Press Button to Generate Random Background Color";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UxInstructionLabel);
            this.Controls.Add(this.UxColorButton);
            this.Controls.Add(this.UxGreenRadioButton);
            this.Controls.Add(this.UxYellowRadioButton);
            this.Controls.Add(this.UxPurpleRadioButton);
            this.Controls.Add(this.UxRedRadioButton);
            this.Controls.Add(this.UxBlueRadioButton);
            this.Controls.Add(this.UxManualLabel);
            this.Controls.Add(this.UxTitleLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UxTitleLabel;
        private Label UxManualLabel;
        private RadioButton UxBlueRadioButton;
        private RadioButton UxRedRadioButton;
        private RadioButton UxPurpleRadioButton;
        private RadioButton UxYellowRadioButton;
        private RadioButton UxGreenRadioButton;
        private Button UxColorButton;
        private System.Windows.Forms.Timer timer1;
        private Label UxInstructionLabel;
    }
}
namespace CSC240_07_01_FiveColors_SES
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (UxBlueRadioButton.Checked)
                this.BackColor = Color.Blue;
            else if (UxRedRadioButton.Checked)
                this.BackColor = Color.Red;
            else if (UxGreenRadioButton.Checked)
                this.BackColor = Color.Green;
            else if (UxPurpleRadioButton.Checked)
                this.BackColor = Color.Purple;
            else if (UxYellowRadioButton.Checked)
                this.BackColor = Color.Yellow;
            else (UxBlueRadioButton.Checked) = false;                
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
